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
    public partial class Form5 : Form

    {
        public string state = "add";
        BL.ClS_COLLAGE COLLAGE = new BL.ClS_COLLAGE();
        BL.CLS_DEPARTMENT DEPARTMENT = new BL.CLS_DEPARTMENT();
        BL.ClS_TOPIC TOPIC = new BL.ClS_TOPIC();
        BL.Cls_QUALIFICATION QUALIFICATION = new BL.Cls_QUALIFICATION();
        BL.CLS_SPECIALIZATION SPECIALIZATION = new BL.CLS_SPECIALIZATION();
        BL.CLS_MINUTES MINUTES = new BL.CLS_MINUTES();

        public Form5()
        {
            InitializeComponent();
            comboBox1.DataSource = COLLAGE.GET_ALL_COLLEGE();
            comboBox1.DisplayMember = "COLLEGE_NAME";
            comboBox1.ValueMember = "COLLEGE_ID";

            comboBox2.DataSource = DEPARTMENT.GET_ALL_DEPARTMENT();
            comboBox2.DisplayMember = "DEPARTMENT_NAME";
            comboBox2.ValueMember = "DEPARTMENT_ID";

            //comboBox4.DataSource = TOPIC.GET_ALL_TOPIC();
            //comboBox4.DisplayMember = "TYPE";
            //comboBox4.ValueMember = "TOPIC_ID";

            comboBox5.DataSource = SPECIALIZATION.GET_ALL_SPECIALIZATION();
            comboBox5.DisplayMember = "SPECIALIZATION_NAME";
            comboBox5.ValueMember = "SPECIALIZATION_ID";

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
                MINUTES.ADD_MINUTESss3(textBox8.Text,textBox6.Text, comboBox3.Text, textBox5.Text, comboBox1.Text, comboBox2.Text, comboBox4.Text, textBox3.Text, textBox1.Text, textBox7.Text, textBox2.Text, textBox15.Text, comboBox5.Text, textBox14.Text);
                MessageBox.Show("تمت الاضافة بنجاح", "تمت الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MINUTES.UPDATE_MINUTESs3(textBox8.Text, textBox6.Text, comboBox3.Text, textBox5.Text, comboBox1.Text, comboBox2.Text, comboBox4.Text, textBox3.Text, textBox1.Text, textBox7.Text, textBox2.Text, textBox15.Text, comboBox5.Text, textBox14.Text);
                MessageBox.Show("تمت التعديل بنجاح", "تم التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form7.getMainForm.dataGridView1.DataSource = MINUTES.GET_ALL_MINUTES();


            }




        }

        private void textBox8_Validated(object sender, EventArgs e)
        {
            if (state == "add")
            {
                DataTable Dt = new DataTable();
                Dt = MINUTES.VerifyMINUTES_ID(textBox8.Text);
                if (Dt.Rows.Count > 0)
                {
                    MessageBox.Show("هذا الرقم موجود مسبقا", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox8.Focus();
                    textBox8.SelectionStart = 0;
                    textBox8.SelectionLength = textBox8.TextLength;
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            if (state == "add")
            {
                MINUTES.ADD_MINUTESss3(textBox8.Text, textBox6.Text, comboBox3.Text, textBox5.Text, comboBox1.Text, comboBox2.Text, comboBox4.Text, textBox3.Text, textBox1.Text, textBox7.Text, textBox2.Text, textBox15.Text, comboBox5.Text, textBox14.Text);
                MessageBox.Show("تمت الاضافة بنجاح", "تمت الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MINUTES.UPDATE_MINUTESs3(textBox8.Text, textBox6.Text, comboBox3.Text, textBox5.Text, comboBox1.Text, comboBox2.Text, comboBox4.Text, textBox3.Text, textBox1.Text, textBox7.Text, textBox2.Text, textBox15.Text, comboBox5.Text, textBox14.Text);
                MessageBox.Show("تمت التعديل بنجاح", "تم التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form7.getMainForm.dataGridView1.DataSource = MINUTES.GET_ALL_MINUTES();

              //  MessageBox.Show("تمت التعديل بنجاح", "تم التعديل",
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox8_Validated_1(object sender, EventArgs e)
        {
            if (state == "add")
            {
                DataTable DT = new DataTable();
                DT = MINUTES.VerifyMINUTES_ID(textBox8.Text);
                if (DT.Rows.Count > 0)
                {
                    MessageBox.Show("هذا الرقم موجود مسبقا", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox8.Focus();
                    textBox8.SelectionStart = 0;
                    textBox8.SelectionLength = textBox8.TextLength;

                }
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void tt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
                DataTable Dt = new DataTable();
                Dt = MINUTES.ADD_there(tt.Text);
                comboBox1.Text = Dt.Rows[0][0].ToString();
                comboBox2.Text = Dt.Rows[0][1].ToString();
                textBox3.Text = Dt.Rows[0][2].ToString();
                comboBox5.Text = Dt.Rows[0][3].ToString();


            }
            else
            {

                DataTable Dt = new DataTable();
                Dt = MINUTES.ADD_there(tt.Text);
                comboBox1.Text = Dt.Rows[0][0].ToString();
                comboBox2.Text = Dt.Rows[0][1].ToString();
                textBox3.Text = Dt.Rows[0][2].ToString();
                comboBox5.Text = Dt.Rows[0][3].ToString();




            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
