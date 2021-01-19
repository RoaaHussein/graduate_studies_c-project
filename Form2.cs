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
    public partial class Form2 : Form

    {
        public string state = "add";
        BL.CLS_STUDENTS prd = new BL.CLS_STUDENTS();
        

        public Form2()
        {
            InitializeComponent();
            comboBox12.DataSource = prd.GET_ALL_CATEGORISES();
            comboBox12.DisplayMember = "DEPARTMENT_NAME";
            comboBox12.ValueMember = "DEPARTMENT_ID";

            comboBox19.DataSource = prd.GET_ALL_CATEGORISES();
            comboBox19.DisplayMember = "DEPARTMENT_NAME";
            comboBox19.ValueMember = "DEPARTMENT_ID";

            comboBox13.DataSource = prd.GET_ALL_CATEGORISES();
            comboBox13.DisplayMember = "DEPARTMENT_NAME";
            comboBox13.ValueMember = "DEPARTMENT_ID";

            comboBox18.DataSource = prd.GET_ALL_CATEGORISES();
            comboBox18.DisplayMember = "DEPARTMENT_NAME";
            comboBox18.ValueMember = "DEPARTMENT_ID";

            comboBox14.DataSource = prd.GET_ALL_CATEGORISES2();
            comboBox14.DisplayMember = "COLLEGE_NAME";
            comboBox14.ValueMember = "COLLEGE_ID";

            comboBox17.DataSource = prd.GET_ALL_CATEGORISES2();
            comboBox17.DisplayMember = "COLLEGE_NAME";
            comboBox17.ValueMember = "COLLEGE_ID";

            comboBox15.DataSource = prd.GET_ALL_CATEGORISES3();
            comboBox15.DisplayMember = "PROGRAM_NAME";
            comboBox15.ValueMember = "PROGRAM_ID";

            comboBox20.DataSource = prd.GET_ALL_CATEGORISES3();
            comboBox20.DisplayMember = "PROGRAM_NAME";
            comboBox20.ValueMember = "PROGRAM_ID";

            comboBox16.DataSource = prd.GET_ALL_CATEGORISES3();
            comboBox16.DisplayMember = "PROGRAM_ID";
            comboBox16.ValueMember = "PROGRAM_ID";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Pictures |*.JPG; *.PNG; *.GIF; *.BMP;  ";
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
           
                if (state == "add")
            {
                
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byte[] byteimage = ms.ToArray();
                
                // for (int i=0; 1<dataGridView1.Rows.Count-1;i++)
                // {
                //  if(Convert.ToString(dataGridView1.Rows[i].Cells["IDTYPE"].Value)!="")
                //  {
                // if (Convert.ToString(dataGridView1.Rows[i].Cells["IDNUM"].Value) != "")
                // {
                //  if (Convert.ToString(dataGridView1.Rows[i].Cells["IDDATE"].Value) != "")
                // {
                // if (Convert.ToString(dataGridView1.Rows[i].Cells["IDSOURCE"].Value) != "")

                // {
                prd.ADD_STUDENT(textBox7.Text, textBox5.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox5.Text, textBox4.Text, textBox6.Text, comboBox7.Text, comboBox8.Text, comboBox4.Text, comboBox6.Text, textBox15.Text, textBox14.Text, textBox13.Text, textBox12.Text, textBox16.Text, comboBox9.Text, textBox2.Text, comboBox10.Text, textBox3.Text, comboBox11.Text, comboBox21.Text, comboBox22.Text, comboBox23.Text, textBox34.Text, textBox33.Text, Convert.ToInt32(comboBox13.SelectedValue),
                    comboBox18.Text, comboBox12.Text, comboBox19.Text, comboBox14.Text, comboBox17.Text, comboBox15.Text, comboBox16.Text, comboBox20.Text, textBox1.Text, textBox9.Text, textBox10.Text, textBox17.Text, textBox11.Text, textBox18.Text, textBox22.Text,
                    textBox21.Text, textBox20.Text, textBox23.Text, textBox19.Text, textBox24.Text, textBox25.Text, textBox26.Text, textBox27.Text, textBox28.Text, textBox29.Text, textBox35.Text, textBox31.Text, textBox37.Text, textBox32.Text, textBox30.Text, textBox36.Text , textBox38.Text, textBox39.Text, textBox41.Text, textBox43.Text, textBox45.Text, textBox48.Text, textBox49.Text, textBox62.Text, textBox61.Text, textBox60.Text, textBox65.Text, textBox64.Text, textBox63.Text, textBox40.Text, textBox42.Text, textBox44.Text, textBox46.Text , textBox47.Text, textBox50.Text, byteimage);

                // }
                //  }
                //}
                // }
                // }


                MessageBox.Show("تم الأضافة بنجاح", "عملية الأضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {

                
                
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] byteimage = ms.ToArray();

                prd.UPDATE_STUDENT(textBox7.Text, textBox5.Text, comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox5.Text, textBox4.Text, textBox6.Text, comboBox7.Text, comboBox8.Text, comboBox4.Text, comboBox6.Text, textBox15.Text, textBox14.Text, textBox13.Text, textBox12.Text, textBox16.Text, comboBox9.Text, textBox2.Text, comboBox10.Text, textBox3.Text, comboBox11.Text, comboBox21.Text, comboBox22.Text, comboBox23.Text, textBox34.Text, textBox33.Text, Convert.ToInt32(comboBox13.SelectedValue),
                    comboBox18.Text, comboBox12.Text, comboBox19.Text, comboBox14.Text, comboBox17.Text, comboBox15.Text, comboBox16.Text, comboBox20.Text, textBox1.Text, textBox9.Text, textBox10.Text, textBox17.Text, textBox11.Text, textBox18.Text, textBox22.Text,
                    textBox21.Text, textBox20.Text, textBox23.Text, textBox19.Text, textBox24.Text, textBox25.Text, textBox26.Text, textBox27.Text, textBox28.Text, textBox29.Text, textBox35.Text, textBox31.Text, textBox37.Text, textBox32.Text, textBox30.Text, textBox36.Text, textBox38.Text, textBox39.Text, textBox41.Text, textBox43.Text, textBox45.Text, textBox48.Text, textBox49.Text, textBox62.Text, textBox61.Text, textBox60.Text, textBox65.Text, textBox64.Text, textBox63.Text, textBox40.Text, textBox42.Text, textBox44.Text, textBox46.Text, textBox47.Text, textBox50.Text, byteimage);

                MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 

        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_Validated(object sender, EventArgs e)
        {
            if (state=="add")
            { 
            DataTable DT = new DataTable();
            DT = prd.VerifyproductID(textBox7.Text);
            if(DT.Rows.Count>0)
            {
                MessageBox.Show("هذا الرقم موجود مسبقا", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox7.Focus();
                textBox7.SelectionStart = 0;
                textBox7.SelectionLength = textBox7.TextLength;

            }
                }
        }
             

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form9 frm = new Form9();
            frm.ShowDialog();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void label77_Click(object sender, EventArgs e)
        {

        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
            

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox27_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox35_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox31_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox37_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.t1.Text = textBox39.Text;
            frm.t2.Text = textBox40.Text;
            frm.t3.Text = textBox41.Text;
            frm.t4.Text = textBox42.Text;
            frm.t5.Text = textBox43.Text;
            frm.t6.Text = textBox44.Text;
            frm.text3.Text = textBox1.Text;
            frm.text6.Text = textBox1.Text;
            frm.com3.Text=comboBox17.Text; 
           frm.com11.Text = comboBox17.Text; 
           frm.com4.Text = comboBox19.Text;
            frm.com10.Text = comboBox19.Text;
            frm.com12.Text = comboBox18.Text;
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.comboBox1.Text = comboBox17.Text;
            frm.comboBox2.Text = comboBox17.Text;
            frm.textBox3.Text = textBox1.Text;
            frm.comboBox5.Text = comboBox18.Text;
            frm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            Form6 frm = new Form6();
            //frm.dataGridView2.Rows.Add(textBox1.Text, comboBox3.Text, textBox18.Text, textBox24.Text, textBox3.Text, comboBox11.Text);
            frm.dataGridView2.Rows[0].Cells[0].Value = textBox1.Text;
            frm.dataGridView2.Rows[0].Cells[1].Value = comboBox3.Text;
            frm.dataGridView2.Rows[0].Cells[2].Value = textBox18.Text;
            frm.dataGridView2.Rows[0].Cells[3].Value = textBox24.Text;
            frm.dataGridView2.Rows[0].Cells[4].Value = textBox3.Text;
            frm.dataGridView2.Rows[0].Cells[5].Value = comboBox11.Text;


            frm.ShowDialog();

        }

        private void textBox62_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
