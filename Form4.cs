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
    public partial class Form4 : Form
    {
        

        public string state = "add";
        BL.ClS_COLLAGE COLLAGE = new BL.ClS_COLLAGE();
        BL.CLS_DEPARTMENT DEPARTMENT = new BL.CLS_DEPARTMENT();
        BL.ClS_TOPIC TOPIC = new BL.ClS_TOPIC();
        BL.Cls_QUALIFICATION QUALIFICATION = new BL.Cls_QUALIFICATION();
        BL.CLS_SPECIALIZATION SPECIALIZATION = new BL.CLS_SPECIALIZATION();
        BL.CLS_MINUTES MINUTES = new BL.CLS_MINUTES();

        public Form4()
        {
            InitializeComponent();

            com3.DataSource = COLLAGE.GET_ALL_COLLEGE();
            com3.DisplayMember = "COLLEGE_NAME";
            com3.ValueMember = "COLLEGE_ID";

            com4.DataSource = DEPARTMENT.GET_ALL_DEPARTMENT();
            com4.DisplayMember = "DEPARTMENT_NAME";
            com4.ValueMember = "DEPARTMENT_ID";

            com5.DataSource = TOPIC.GET_ALL_TOPIC();
            com5.DisplayMember = "TYPE";
            com5.ValueMember = "TOPIC_ID";

            com.DataSource = QUALIFICATION.GET_ALL_QUALIFICATION();
            com.DisplayMember = "QUALIFICATION_NAME";
            com.ValueMember = "QUALIFICATION_ID";

            com10.DataSource = DEPARTMENT.GET_ALL_DEPARTMENT();
            com10.DisplayMember = "DEPARTMENT_NAME";
            com10.ValueMember = "DEPARTMENT_ID";

            com11.DataSource = COLLAGE.GET_ALL_COLLEGE();
            com11.DisplayMember = "COLLEGE_NAME";
            com11.ValueMember = "COLLEGE_ID";

            com12.DataSource = SPECIALIZATION.GET_ALL_SPECIALIZATION();
            com12.DisplayMember = "SPECIALIZATION_NAME";
            com12.ValueMember = "SPECIALIZATION_ID";

















        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void text2_Validated(object sender, EventArgs e)
        {
            if (state == "add")
            {
                DataTable Dt = new DataTable();
                Dt = MINUTES.VerifyMINUTES_ID(text2.Text);
                if (Dt.Rows.Count > 0)
                {
                    MessageBox.Show("هذا الرقم موجود مسبقا", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    text2.Focus();
                    text2.SelectionStart = 0;
                    text2.SelectionLength = text2.TextLength;


                }
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void text2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            if (state == "add")

            {
              

                MINUTES.ADD_MINUTES(text2.Text,text1.Text, com2.Text, text10.Text, com3.Text, com4.Text, com5.Text, text3.Text, text4.Text, text11.Text, text5.Text, text12.Text, text6.Text, com.Text, com10.Text, com11.Text, com12.Text, text7.Text, text8.Text, t1.Text, t2.Text, t3.Text, t4.Text, t5.Text, t6.Text, t7.Text, t8.Text/*, t9.Text*/);

                MessageBox.Show("تمت الاضافة بنجاح", "تمت الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                

                MINUTES.UPDATE_MINUTES(text2.Text,text1.Text, com2.Text, text10.Text, com3.Text, com4.Text, com5.Text, text3.Text, text4.Text, text11.Text, text5.Text, text12.Text, text6.Text, com.Text, com10.Text, com11.Text, com12.Text, text7.Text, text8.Text, t1.Text, t2.Text, t3.Text, t4.Text, t5.Text, t6.Text, t7.Text, t8.Text/*, t9.Text*/);

                MessageBox.Show("تمت التعديل بنجاح", "تم التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form7.getMainForm.dataGridView1.DataSource = MINUTES.GET_ALL_MINUTES();

               
            }
        }

        private void text2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void text2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void text2_Validated_1(object sender, EventArgs e)
        {
            if (state == "add")
            {
                DataTable DT = new DataTable();
                DT = MINUTES.VerifyMINUTES_ID (text2.Text);
                if (DT.Rows.Count > 0)
                {
                    MessageBox.Show("هذا الرقم موجود مسبقا", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    text2.Focus();
                    text2.SelectionStart = 0;
                    text2.SelectionLength = text2.TextLength;

                }
            }
        }

        private void t9_TextChanged(object sender, EventArgs e)
        {

            //DataTable Dt = new DataTable();
            //Dt = MINUTES.ADD_here(t9.Text);
            ////dataGridView1.DataSource = Dt;
            ////this.dataGridView1.DataSource = Dt;
            ////dataGridView1.DataSource = Dt;

            //t1.Text = Dt.Rows[0][0].ToString();
            //t2.Text = Dt.Rows[0][1].ToString();
            //t3.Text = Dt.Rows[0][2].ToString();
            //t4.Text = Dt.Rows[0][3].ToString();
            //t5.Text = Dt.Rows[0][4].ToString();
            //t6.Text = Dt.Rows[0][5].ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            
        }

        private void button2_Validated(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (state == "add")
            {
                DataTable Dt = new DataTable();
                Dt = MINUTES.ADD_here(t9.Text);
                //dataGridView1.DataSource = Dt;
                //this.dataGridView1.DataSource = Dt;
                //dataGridView1.DataSource = Dt;

                t1.Text = Dt.Rows[0][0].ToString();
                t2.Text = Dt.Rows[0][3].ToString();
                t3.Text = Dt.Rows[0][1].ToString();
                t4.Text = Dt.Rows[0][4].ToString();
                t5.Text = Dt.Rows[0][2].ToString();
                t6.Text = Dt.Rows[0][5].ToString();
                text3.Text = Dt.Rows[0][6].ToString();
                text6.Text = Dt.Rows[0][7].ToString();
                com3.Text = Dt.Rows[0][8].ToString();
                com11.Text = Dt.Rows[0][9].ToString();
                com4.Text = Dt.Rows[0][10].ToString();
                com10.Text = Dt.Rows[0][11].ToString();
                com12.Text = Dt.Rows[0][12].ToString();
            }
            else
            {
                DataTable Dt = new DataTable();
                Dt = MINUTES.ADD_here(t9.Text);
                //dataGridView1.DataSource = Dt;
                //this.dataGridView1.DataSource = Dt;
                //dataGridView1.DataSource = Dt;

                t1.Text = Dt.Rows[0][0].ToString();
                t2.Text = Dt.Rows[0][3].ToString();
                t3.Text = Dt.Rows[0][1].ToString();
                t4.Text = Dt.Rows[0][4].ToString();
                t5.Text = Dt.Rows[0][2].ToString();
                t6.Text = Dt.Rows[0][5].ToString();
                text3.Text = Dt.Rows[0][6].ToString();
                text6.Text = Dt.Rows[0][7].ToString();
                com3.Text = Dt.Rows[0][8].ToString();
                com11.Text = Dt.Rows[0][9].ToString();
                com4.Text = Dt.Rows[0][10].ToString();
                com10.Text = Dt.Rows[0][11].ToString();
                com12.Text = Dt.Rows[0][12].ToString();
            }

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
