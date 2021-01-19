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
    public partial class Form1 : Form
    {
        BL.CLS_LOGIN log = new BL.CLS_LOGIN();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {   
           
            //maın1 frm = new maın1();
            //frm.ShowDialog();
            DataTable DT = log.LOGIN(textid.Text, textpwd.Text);
            if (DT.Rows.Count>0)
            {
                Program.id = DT.Rows[0][0].ToString();
                Program.name = DT.Rows[0][1].ToString();
                if (DT.Rows[0][3].ToString()=="مدير")
                {
                    //maın1 frm = new maın1();
                    //frm.button2.Enabled = true;
                    maın1.getMainForm.button1.Visible = false;
                    maın1.getMainForm.button2.Enabled = true;
                     maın1.getMainForm.button3.Enabled = true;
                    maın1.getMainForm.button4.Enabled = true;
                    maın1.getMainForm.button5.Enabled = true;
                    maın1.getMainForm.button4.Visible = true;
                    maın1.getMainForm.button6.Enabled = true;
                    maın1.getMainForm.button7.Enabled = true;
                    Form9.getMainForm.button13.Visible = false;

                    this.Close();
                }
                else if (DT.Rows[0][3].ToString() =="موظف")
                {
                    //maın1 frm = new maın1();
                    //frm.button2.Enabled = true;
                    maın1.getMainForm.button1.Visible = false;
                    maın1.getMainForm.button2.Enabled = true;
                   maın1.getMainForm.button3.Enabled = true;
                    //maın1.getMainForm.button4.Enabled = true;
                    maın1.getMainForm.button5.Enabled = true;
                   maın1.getMainForm.button4.Enabled = true;
                    maın1.getMainForm.button4.Visible = true;
                    maın1.getMainForm.button6.Enabled = true;
                   maın1.getMainForm.button7.Enabled = true;
                    Form9.getMainForm.button13.Visible = false;

                    this.Close();
                }
                }
            else
            {
                MessageBox.Show("  ! فشل الدخول  ");

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
