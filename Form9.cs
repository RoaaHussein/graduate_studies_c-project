using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;




namespace login1
{
    public partial class Form9 : Form
    {
        private static Form9 frm;
        static void frm_formClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static Form9 getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new Form9();
                    frm.FormClosed += new FormClosedEventHandler(frm_formClosed);
                }
                return frm;
            }

        }



        BL.CLS_LOGIN log = new BL.CLS_LOGIN();
        BL.CLS_STUDENTS prd = new BL.CLS_STUDENTS();
        public Form9()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = prd.GET_ALL_STUDENTS();
        }

       

        private void Form9_Load(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.textBox7.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.textBox5.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.comboBox1.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.comboBox2.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.comboBox3.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm.comboBox5.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frm.textBox4.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frm.textBox6.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            frm.comboBox7.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            frm.comboBox8.Text = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();
            frm.comboBox4.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            frm.comboBox6.Text = this.dataGridView1.CurrentRow.Cells[12].Value.ToString();
            frm.textBox15.Text = this.dataGridView1.CurrentRow.Cells[27].Value.ToString();
            frm.textBox14.Text = this.dataGridView1.CurrentRow.Cells[26].Value.ToString();
            frm.textBox13.Text = this.dataGridView1.CurrentRow.Cells[25].Value.ToString();
            frm.textBox12.Text = this.dataGridView1.CurrentRow.Cells[24].Value.ToString();
            
            frm.textBox16.Text = this.dataGridView1.CurrentRow.Cells[14].Value.ToString();
            frm.comboBox9.Text = this.dataGridView1.CurrentRow.Cells[15].Value.ToString();
            frm.textBox2.Text = this.dataGridView1.CurrentRow.Cells[28].Value.ToString();
            frm.comboBox10.Text = this.dataGridView1.CurrentRow.Cells[16].Value.ToString();
            frm.textBox3.Text = this.dataGridView1.CurrentRow.Cells[17].Value.ToString();
            frm.comboBox11.Text = this.dataGridView1.CurrentRow.Cells[23].Value.ToString();
            frm.comboBox21.Text = this.dataGridView1.CurrentRow.Cells[22].Value.ToString();
            frm.comboBox22.Text = this.dataGridView1.CurrentRow.Cells[18].Value.ToString();
            frm.comboBox23.Text = this.dataGridView1.CurrentRow.Cells[19].Value.ToString();
            frm.textBox34.Text = this.dataGridView1.CurrentRow.Cells[21].Value.ToString();
            frm.textBox33.Text = this.dataGridView1.CurrentRow.Cells[20].Value.ToString();
            frm.comboBox13.Text = this.dataGridView1.CurrentRow.Cells[13].Value.ToString();
            frm.comboBox18.Text = this.dataGridView1.CurrentRow.Cells[37].Value.ToString();
            frm.comboBox12.Text = this.dataGridView1.CurrentRow.Cells[31].Value.ToString();
            frm.comboBox19.Text = this.dataGridView1.CurrentRow.Cells[36].Value.ToString();
            frm.comboBox14.Text = this.dataGridView1.CurrentRow.Cells[32].Value.ToString();
            frm.comboBox17.Text = this.dataGridView1.CurrentRow.Cells[35].Value.ToString();
            frm.comboBox15.Text = this.dataGridView1.CurrentRow.Cells[30].Value.ToString();
            frm.comboBox16.Text = this.dataGridView1.CurrentRow.Cells[33].Value.ToString();
            frm.comboBox20.Text = this.dataGridView1.CurrentRow.Cells[34].Value.ToString();
            frm.textBox1.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.textBox9.Text = this.dataGridView1.CurrentRow.Cells[38].Value.ToString();
            frm.textBox10.Text = this.dataGridView1.CurrentRow.Cells[39].Value.ToString();
            frm.textBox17.Text = this.dataGridView1.CurrentRow.Cells[40].Value.ToString();
            frm.textBox11.Text = this.dataGridView1.CurrentRow.Cells[41].Value.ToString();
            frm.textBox18.Text = this.dataGridView1.CurrentRow.Cells[42].Value.ToString();
            frm.textBox22.Text = this.dataGridView1.CurrentRow.Cells[43].Value.ToString();
            frm.textBox21.Text = this.dataGridView1.CurrentRow.Cells[44].Value.ToString();
            frm.textBox20.Text = this.dataGridView1.CurrentRow.Cells[45].Value.ToString();
            frm.textBox23.Text = this.dataGridView1.CurrentRow.Cells[46].Value.ToString();
            frm.textBox19.Text = this.dataGridView1.CurrentRow.Cells[47].Value.ToString();
            frm.textBox24.Text = this.dataGridView1.CurrentRow.Cells[48].Value.ToString();
            frm.textBox25.Text = this.dataGridView1.CurrentRow.Cells[49].Value.ToString();
            frm.textBox26.Text = this.dataGridView1.CurrentRow.Cells[50].Value.ToString();
            frm.textBox27.Text = this.dataGridView1.CurrentRow.Cells[51].Value.ToString();
            frm.textBox28.Text = this.dataGridView1.CurrentRow.Cells[52].Value.ToString();
            frm.textBox29.Text = this.dataGridView1.CurrentRow.Cells[53].Value.ToString();
            frm.textBox35.Text = this.dataGridView1.CurrentRow.Cells[54].Value.ToString();
            frm.textBox31.Text = this.dataGridView1.CurrentRow.Cells[55].Value.ToString();
            frm.textBox37.Text = this.dataGridView1.CurrentRow.Cells[56].Value.ToString();
            frm.textBox32.Text = this.dataGridView1.CurrentRow.Cells[57].Value.ToString();
            frm.textBox30.Text = this.dataGridView1.CurrentRow.Cells[58].Value.ToString();
            frm.textBox36.Text = this.dataGridView1.CurrentRow.Cells[59].Value.ToString();
            frm.textBox38.Text = this.dataGridView1.CurrentRow.Cells[60].Value.ToString();
            frm.textBox39.Text = this.dataGridView1.CurrentRow.Cells[61].Value.ToString();
            frm.textBox41.Text = this.dataGridView1.CurrentRow.Cells[62].Value.ToString();
            frm.textBox43.Text = this.dataGridView1.CurrentRow.Cells[63].Value.ToString();
            frm.textBox45.Text = this.dataGridView1.CurrentRow.Cells[64].Value.ToString();
            frm.textBox48.Text = this.dataGridView1.CurrentRow.Cells[65].Value.ToString();
            frm.textBox49.Text = this.dataGridView1.CurrentRow.Cells[66].Value.ToString();
            frm.textBox62.Text = this.dataGridView1.CurrentRow.Cells[67].Value.ToString();
            frm.textBox61.Text = this.dataGridView1.CurrentRow.Cells[68].Value.ToString();
            frm.textBox60.Text = this.dataGridView1.CurrentRow.Cells[69].Value.ToString();
            frm.textBox65.Text = this.dataGridView1.CurrentRow.Cells[70].Value.ToString();
            frm.textBox64.Text = this.dataGridView1.CurrentRow.Cells[71].Value.ToString();
            frm.textBox63.Text = this.dataGridView1.CurrentRow.Cells[72].Value.ToString();
            frm.textBox40.Text = this.dataGridView1.CurrentRow.Cells[73].Value.ToString();
            frm.textBox42.Text = this.dataGridView1.CurrentRow.Cells[74].Value.ToString();
            frm.textBox44.Text = this.dataGridView1.CurrentRow.Cells[75].Value.ToString();
            frm.textBox46.Text = this.dataGridView1.CurrentRow.Cells[76].Value.ToString();
            frm.textBox47.Text = this.dataGridView1.CurrentRow.Cells[77].Value.ToString();
            frm.textBox50.Text = this.dataGridView1.CurrentRow.Cells[78].Value.ToString();




            frm.Text="  تحديث بيانات الطالب "+ this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.button15.Text = "تحديث";
            frm.state = "update";
            frm.textBox7.ReadOnly = true;
            byte[] image = (byte[])prd.GET_IMAGE_STUDENT(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.pictureBox1.Image = Image.FromStream(ms);
            frm.button3.Visible = false;
            frm.button4.Visible = false;
            frm.button9.Visible = false;
            frm.ShowDialog();






        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT = prd.SearchStudent(textBox8.Text);
            this.dataGridView1.DataSource = DT;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            //Form1 frm = new Form1();
            //DataTable DT = log.LOGIN(frm.textid.Text, frm.textpwd.Text);
            //if (DT.Rows.Count > 0)
            //{

              //  if (DT.Rows[0][3].ToString() == "مدير")
            //    {
            //        ////maın1 frm = new maın1();
            //        ////frm.button2.Enabled = true;
            //        //maın1.getMainForm.button1.Visible = false;
            //        //maın1.getMainForm.button2.Enabled = true;
            //        //maın1.getMainForm.button3.Enabled = true;
            //        //maın1.getMainForm.button4.Enabled = true;
            //        //maın1.getMainForm.button5.Enabled = true;
            //        //maın1.getMainForm.button4.Visible = true;
            //        //maın1.getMainForm.button6.Enabled = true;
            //        //maın1.getMainForm.button7.Enabled = true;
            //        //Form9.getMainForm.button13.Enabled = true;
            //        //this.button13.Enabled = true;
            //        // .button13.Visible = false;


            //        this.Close();
            //    }
            //    else if (DT.Rows[0][3].ToString() == "موظف")
            //    {
            //        ////maın1 frm = new maın1();
            //        ////frm.button2.Enabled = true;
            //        //maın1.getMainForm.button1.Visible = false;
            //        //maın1.getMainForm.button2.Enabled = true;
            //        //maın1.getMainForm.button3.Enabled = true;
            //        ////maın1.getMainForm.button4.Enabled = true;
            //        //maın1.getMainForm.button5.Enabled = true;
            //        //maın1.getMainForm.button4.Enabled = false;
            //        //maın1.getMainForm.button4.Visible = true;
            //        //maın1.getMainForm.button6.Enabled = true;
            //        //maın1.getMainForm.button7.Enabled = true;
            //        //Form9.getMainForm.button13.Enabled = false;
            //        //Form9.getMainForm.button13.Enabled = false;
            //        //  this.button13.Enabled = false;
            //        MessageBox.Show("YOU CANT");

            //        this.Close();
            //    }
            //}




            if (MessageBox.Show("هل تريد فعلا حذف الطالب المحدد؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)==DialogResult.Yes)
            {
                prd.deletestudent(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = prd.GET_ALL_STUDENTS();
            }
            else
            {
                MessageBox.Show("تم الغاء عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
