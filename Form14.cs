using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login1
{
    public partial class Form14 : Form
    {
        BL.CLS_LOGIN login = new BL.CLS_LOGIN();
        public Form14()
        {
            InitializeComponent();
            this.dataGridView1user.DataSource = login.searchusers("");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form13 frm = new Form13();
            frm.text1.Text = dataGridView1user.CurrentRow.Cells[0].Value.ToString();
            frm.text2.Text = dataGridView1user.CurrentRow.Cells[1].Value.ToString();
            frm.text3.Text = dataGridView1user.CurrentRow.Cells[2].Value.ToString();
            frm.text4.Text = dataGridView1user.CurrentRow.Cells[2].Value.ToString();
            frm.com1.Text = dataGridView1user.CurrentRow.Cells[3].Value.ToString();
            //frm.text3.UseSystemPasswordChar = true;
            //frm.text4.UseSystemPasswordChar = true;
            frm.b1.Text = "تعديل";
            frm.ShowDialog();
            this.dataGridView1user.DataSource = login.searchusers("");
        }

        private void text_password(object sender, EventArgs e)
        {

        }

        private void Form14_Load(object sender, EventArgs e)
        {
            try {
                DataTable dt = login.user_author(Program.id, "1");
                if (Convert.ToBoolean(dt.Rows[0][4].ToString()) == false)
                    button13.Visible = false;
            } catch (Exception er) { }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT = login.searchusers(text8.Text);
            this.dataGridView1user.DataSource = DT; 
        }

      

        private void button13_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف المستخدم", "حذف المستخدم", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes)
            {
                login.delete_USER(this.dataGridView1user.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1user.DataSource = login.searchusers("");
            }
            
        }

       

        private void dataGridView1user_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(dataGridView1user.Columns[e.ColumnIndex].Index==2)
            {
                if (e.Value!= null)
                {
                    e.Value = "********";
                    e.FormattingApplied = true;
                }
            }
        }

        private void dataGridView1user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
