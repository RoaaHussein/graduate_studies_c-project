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
    public partial class Form6 : Form

    {
        public string state = "add";

        BL.ClS_COLLAGE COLLAGE = new BL.ClS_COLLAGE();
        BL.CLS_DEPARTMENT DEPARTMENT = new BL.CLS_DEPARTMENT();
        BL.ClS_TOPIC TOPIC = new BL.ClS_TOPIC();
        BL.Cls_QUALIFICATION QUALIFICATION = new BL.Cls_QUALIFICATION();
        BL.CLS_SPECIALIZATION SPECIALIZATION = new BL.CLS_SPECIALIZATION();
        BL.CLS_MINUTES MINUTES = new BL.CLS_MINUTES();


        public Form6()
        {
            InitializeComponent();
            comb1.DataSource = DEPARTMENT.GET_ALL_DEPARTMENT();
            comb1.DisplayMember = "DEPARTMENT_NAME";
            comb1.ValueMember = "DEPARTMENT_ID";

            //comb2.DataSource = TOPIC.GET_ALL_TOPIC();
            //comb2.DisplayMember = "TYPE";
            //comb2.ValueMember = "TOPIC_ID";


        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_DBDataSet.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.student_DBDataSet.STUDENT);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {

               // for (int i = 0; i < dataGridView2.RowCount -1 ; i++)
                {
                    
                    
                    MINUTES.ADD_MINUTESss(textB4.Text,textB5.Text, comb3.Text, textB6.Text, textB3.Text, comb1.Text, comb2.Text, textB1.Text, textB2.Text, textB7.Text, textB8.Text,
                     

                       Convert.ToString(dataGridView2
                       .Rows[0].Cells[0].Value),
                       Convert.ToString(dataGridView2
                       .Rows[0].Cells[1].Value),
                       Convert.ToString(dataGridView2
                       .Rows[0].Cells[2].Value),
                       Convert.ToString(dataGridView2
                       .Rows[0].Cells[3].Value),
                       Convert.ToString(dataGridView2
                       .Rows[0].Cells[4].Value),
                       Convert.ToString(dataGridView2
                       .Rows[0].Cells[5].Value)
                       //Convert.ToString(dataGridView2.Rows[i].Cells[6].Value),
                       //Convert.ToString(dataGridView2.Rows[i].Cells[7].Value)
                       
                        );
                    



                }

                MessageBox.Show("تمت الاضافة بنجاح", "تمت الاضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else
            {
                
                MINUTES.UPDATE_MINUTESs(textB4.Text, textB5.Text, comb3.Text, textB6.Text, textB3.Text, comb1.Text, comb2.Text, textB1.Text, textB2.Text, textB7.Text, textB8.Text,
                    Convert.ToString(dataGridView2.Rows[0]
                    .Cells[0].Value),
                       Convert.ToString(dataGridView2
                       .Rows[0
                       ].Cells[1].Value),
                       Convert.ToString(dataGridView2
                       .Rows[0
                       ].Cells[2].Value),
                       Convert.ToString(dataGridView2
                       .Rows[0
                       ].Cells[3].Value),
                       Convert.ToString(dataGridView2
                       .Rows[0
                       ].Cells[4].Value),
                       Convert.ToString(dataGridView2
                       .Rows[0
                       ].Cells[5].Value));

                MessageBox.Show("تمت التعديل بنجاح", "تم التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form7.getMainForm.dataGridView1.DataSource = MINUTES.GET_ALL_MINUTES();

            }
            Form7.getMainForm.dataGridView1.DataSource = MINUTES.GET_ALL_MINUTES();

        }

        private void textB6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textB2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textB4_Validated(object sender, EventArgs e)
        {
            if (state == "add")
            {
                DataTable Dt = new DataTable();
                Dt = MINUTES.VerifyMINUTES_ID(textB4.Text);
                if (Dt.Rows.Count > 0)
                {
                    MessageBox.Show("هذا الرقم موجود مسبقا", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textB4.Focus();
                    textB4.SelectionStart = 0;
                    textB4.SelectionLength = textB4.TextLength;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comb3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textB4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textB4_Validated_1(object sender, EventArgs e)
        {
            if (state == "add")
            {
                DataTable DT = new DataTable();
                DT = MINUTES.VerifyMINUTES_ID(textB4.Text);
                if (DT.Rows.Count > 0)
                {
                    MessageBox.Show("هذا الرقم موجود مسبقا", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textB4.Focus();
                    textB4.SelectionStart = 0;
                    textB4.SelectionLength = textB4.TextLength;

                }
            }
        }

        private void textB2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textB4_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textB4_Validated_2(object sender, EventArgs e)
        {
            if (state == "add")
            {
                DataTable DT = new DataTable();
                DT = MINUTES.VerifyMINUTES_ID(textB4.Text);
                if (DT.Rows.Count > 0)
                {
                    MessageBox.Show("هذا الرقم موجود مسبقا", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textB4.Focus();
                    textB4.SelectionStart = 0;
                    textB4.SelectionLength = textB4.TextLength;

                }
            }
        }

        private void t9_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
                DataTable Dt = new DataTable();
                //Dt.Columns.Add("name1", typeof(string));
                // Dt.Columns.Add("name1", typeof(string));
                 Dt = MINUTES.stu_info (t9.Text);
                //comb1.Text = Dt.Rows[0][0].ToString();
                //dataGridView2.DataSource = Dt;
                dataGridView2.Rows[0].Cells[0].Value=Dt.Rows[0][5].ToString();
                dataGridView2.Rows[0].Cells[1].Value = Dt.Rows[0][4].ToString();
                dataGridView2.Rows[0].Cells[2].Value = Dt.Rows[0][3].ToString();
                dataGridView2.Rows[0].Cells[3].Value = Dt.Rows[0][2].ToString();
                dataGridView2.Rows[0].Cells[4].Value = Dt.Rows[0][1].ToString();
                dataGridView2.Rows[0].Cells[5].Value = Dt.Rows[0][0].ToString();
                //dataGridView2.Rows[0].Cells[0].Value= Dt.Columns.Add("name1", typeof(string));



                // dataGridView2.Dispose = DT;

                //frm.textBox1.Text= dataGridView2.Rows[0].Cells[0].Value 
                //dataGridView2.Rows[0].Cells[1].Value = comboBox3.Text;
                //dataGridView2.Rows[0].Cells[2].Value = textBox18.Text;
                //dataGridView2.Rows[0].Cells[3].Value = textBox24.Text;
                //dataGridView2.Rows[0].Cells[4].Value = textBox3.Text;
                //dataGridView2.Rows[0].Cells[5].Value = comboBox11.Text;

                //dataGridView2.Rows[0].Cells[0].Value = textBox1.Text;
                // this.dataGridView2.Rows[0].Cells[0].Value = textBox1.Text;
                //this.dataGridView2.Rows[0].Cells[1].Value = comboBox3.Text;
                //frm.dataGridView2.Rows[0].Cells[2].Value = textBox18.Text;
                //frm.dataGridView2.Rows[0].Cells[3].Value = textBox24.Text;
                //frm.dataGridView2.Rows[0].Cells[4].Value = textBox3.Text;
                //frm.dataGridView2.Rows[0].Cells[5].Value = comboBox11.Text;
            }
            else
            {
                DataTable Dt = new DataTable();
                Dt = MINUTES.stu_info (t9.Text);
                //comb1.Text = Dt.Rows[0][0].ToString();
                dataGridView2.DataSource = Dt;
            }
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textB4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
