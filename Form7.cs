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
    public partial class Form7 : Form

    {
        private static Form7 frm;

        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        

        public static Form7 getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new Form7();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        BL.CLS_MINUTES MINUTES = new BL.CLS_MINUTES();
        public Form7()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.dataGridView1.DataSource = MINUTES.GET_ALL_MINUTES();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = MINUTES.SearchMINUTES(txtID.Text);
            this.dataGridView1.DataSource = Dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل بالفعل تريد حذف المحضر المحدد؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                MINUTES.DeleteMinutes(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تمت عملية الحذف ", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form4 frm = new Form4();
            frm.text2.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.text1.Text = this.dataGridView1.CurrentRow.Cells[18].Value.ToString();
            frm.com2.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frm.text10.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.com3.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            frm.com4.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            frm.com5.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frm.text3.Text = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();
            frm.text4.Text = this.dataGridView1.CurrentRow.Cells[12].Value.ToString();
            frm.text11.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.text5.Text = this.dataGridView1.CurrentRow.Cells[13].Value.ToString();
            frm.text12.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm.text6.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            frm.com.Text = this.dataGridView1.CurrentRow.Cells[14].Value.ToString();
            frm.com10.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            frm.com11.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            frm.com12.Text = this.dataGridView1.CurrentRow.Cells[16].Value.ToString();
            frm.text7.Text = this.dataGridView1.CurrentRow.Cells[17].Value.ToString();
            frm.text8.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.Text = " تحديث المحضر :" + this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.button15.Text = "تحديث ";
            frm.state = "update";
            frm.text2.ReadOnly = true;
            frm.ShowDialog();










        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.textBox8.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.textBox6.Text = this.dataGridView1.CurrentRow.Cells[18].Value.ToString();
            frm.comboBox3.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frm.textBox5.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.comboBox1.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            frm.comboBox2.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            frm.comboBox4.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frm.textBox3.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            frm.textBox1.Text = this.dataGridView1.CurrentRow.Cells[25].Value.ToString();
            frm.textBox2.Text = this.dataGridView1.CurrentRow.Cells[23].Value.ToString();
            frm.textBox7.Text = this.dataGridView1.CurrentRow.Cells[24].Value.ToString();
            frm.comboBox5.Text = this.dataGridView1.CurrentRow.Cells[16].Value.ToString();
            frm.textBox15.Text = this.dataGridView1.CurrentRow.Cells[17].Value.ToString();
            frm.textBox14.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.Text = " تحديث المحضر :" + this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.button15.Text = "تحديث ";
            frm.state = "update";
            frm.textBox8.ReadOnly = true;
            frm.ShowDialog();





        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.textB4.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.textB5.Text = this.dataGridView1.CurrentRow.Cells[18].Value.ToString();
            frm.comb3.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frm.textB6.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.textB3.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            frm.comb1.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            frm.comb2.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frm.textB1.Text = this.dataGridView1.CurrentRow.Cells[18].Value.ToString();
            frm.textB2.Text = this.dataGridView1.CurrentRow.Cells[22].Value.ToString();
            frm.textB7.Text = this.dataGridView1.CurrentRow.Cells[17].Value.ToString();
            frm.textB8.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.Text = " تحديث المحضر :" + this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.button15.Text = "تحديث ";
            frm.state = "update";
            frm.textB4.ReadOnly = true;
            frm.ShowDialog();



        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void Form7_Load_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.text2.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.text1.Text = this.dataGridView1.CurrentRow.Cells[18].Value.ToString();
            frm.com2.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frm.text10.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.com3.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            frm.com4.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            frm.com5.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frm.text3.Text = this.dataGridView1.CurrentRow.Cells[11].Value.ToString();
            frm.text4.Text = this.dataGridView1.CurrentRow.Cells[12].Value.ToString();
            frm.text11.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.text5.Text = this.dataGridView1.CurrentRow.Cells[13].Value.ToString();
            frm.text12.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm.text6.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            frm.com.Text = this.dataGridView1.CurrentRow.Cells[14].Value.ToString();
            frm.com10.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            frm.com11.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            frm.com12.Text = this.dataGridView1.CurrentRow.Cells[16].Value.ToString();
            frm.text7.Text = this.dataGridView1.CurrentRow.Cells[17].Value.ToString();
            frm.text8.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.t1.Text = this.dataGridView1.CurrentRow.Cells[26].Value.ToString();
            frm.t2.Text = this.dataGridView1.CurrentRow.Cells[27].Value.ToString();
            frm.t3.Text = this.dataGridView1.CurrentRow.Cells[28].Value.ToString();
            frm.t4.Text = this.dataGridView1.CurrentRow.Cells[29].Value.ToString();
            frm.t5.Text = this.dataGridView1.CurrentRow.Cells[30].Value.ToString();
            frm.t6.Text = this.dataGridView1.CurrentRow.Cells[31].Value.ToString();
            frm.t7.Text = this.dataGridView1.CurrentRow.Cells[32].Value.ToString();
            frm.t8.Text = this.dataGridView1.CurrentRow.Cells[33].Value.ToString();
            //frm.t9.Text = this.dataGridView1.CurrentRow.Cells[34].Value.ToString();
           frm.Text = " تحديث جدول الاعمال  :" + this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
           frm.button15.Text = "تحديث ";
            frm.state = "update";
            frm.text2.ReadOnly = true;
           frm.button2.Enabled = false;
            frm.label9.Enabled = false;
            frm.t9.Enabled = false;
            //frm.text8.Enabled = false;
            frm.ShowDialog();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show(dataGridView1.CurrentRow.Cells[35].Value.ToString());
            //  Form6 frm = new Form6();
            //  MessageBox.Show(Convert.ToString(frm.dataGridView2.Rows[0].Cells[0].Value));

            Form6 frm = new Form6();
            frm.textB4.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.textB5.Text = this.dataGridView1.CurrentRow.Cells[18].Value.ToString();
            frm.comb3.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frm.textB6.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.textB3.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            frm.comb1.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            frm.comb2.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frm.textB1.Text = this.dataGridView1.CurrentRow.Cells[18].Value.ToString();
            frm.textB2.Text = this.dataGridView1.CurrentRow.Cells[22].Value.ToString();
            frm.textB7.Text = this.dataGridView1.CurrentRow.Cells[17].Value.ToString();
            frm.textB8.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.comb2.Text = this.dataGridView1.CurrentRow.Cells[14].Value.ToString();
            frm.dataGridView2.Rows[0].Cells[0].Value = this.
                dataGridView1.CurrentRow.Cells[34].Value.ToString();
            frm.dataGridView2.Rows[0].Cells[1].Value = this.
                dataGridView1.CurrentRow.Cells[35].Value.ToString();
            frm.dataGridView2.Rows[0].Cells[2].Value = this.
                dataGridView1.CurrentRow.Cells[36].Value.ToString();
            frm.dataGridView2.Rows[0].Cells[3].Value = this.
                dataGridView1.CurrentRow.Cells[37].Value.ToString();
            frm.dataGridView2.Rows[0].Cells[4].Value = this.
                dataGridView1.CurrentRow.Cells[38].Value.ToString();
            frm.dataGridView2.Rows[0].Cells[5].Value = this.
                dataGridView1.CurrentRow.Cells[39].Value.ToString();
            //MINUTES.UPDATE_MINUTESs(this.dataGridView1.CurrentRow.Cells[2].Value.ToString(),)
            frm.Text = " تحديث جدول الاعمال :" + this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.button15.Text = "تحديث ";
            frm.state = "update";
           frm.textB4.ReadOnly = true;
           frm.button2.Enabled = false;
            frm.label19.Enabled = false;
           // frm.textB8.Visible = false;
           frm.t9.Enabled = false;
            frm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.textBox8.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.textBox6.Text = this.dataGridView1.CurrentRow.Cells[18].Value.ToString();
            frm.comboBox3.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frm.textBox5.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.comboBox1.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            frm.comboBox2.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            frm.comboBox4.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frm.textBox3.Text = this.dataGridView1.CurrentRow.Cells[10].Value.ToString();
            frm.textBox1.Text = this.dataGridView1.CurrentRow.Cells[25].Value.ToString();
            frm.textBox2.Text = this.dataGridView1.CurrentRow.Cells[23].Value.ToString();
            frm.textBox7.Text = this.dataGridView1.CurrentRow.Cells[24].Value.ToString();
            frm.comboBox5.Text = this.dataGridView1.CurrentRow.Cells[16].Value.ToString();
            frm.textBox15.Text = this.dataGridView1.CurrentRow.Cells[17].Value.ToString();
            frm.textBox14.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.Text = " تحديث جدول الاعمال :" + this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.button15.Text = "تحديث ";
            frm.state = "update";
            frm.textBox8.ReadOnly = true;
            frm.button2.Enabled = false;
            frm.label22.Enabled = false;
            //frm.textBox14.Visible = false;
           frm.tt.Enabled = false;
            frm.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل بالفعل تريد حذف جدول الاعمال المحدد؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                MINUTES.DeleteMinutes(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تمت عملية الحذف ", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtID_TextChanged_1(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = MINUTES.SearchMINUTES(txtID.Text);
            this.dataGridView1.DataSource = Dt;


        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RPT.rpt_stu_single myReport = new RPT.rpt_stu_single();
           myReport.SetParameterValue("@MINUTES_ID", this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            RPT.FRM_RPT_STUDENTS myForm = new RPT.FRM_RPT_STUDENTS();
            myForm.crystalReportViewer1.ReportSource = myReport;
            myForm.ShowDialog();

            

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            RPT.rpt_minout myReport = new RPT.rpt_minout();
            myReport.SetParameterValue("@MINUTES_ID", this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            RPT.Form1 myForm = new RPT.Form1();
            myForm.crystalReportViewer2.ReportSource = myReport;
            myForm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RPT.minin myReport = new RPT.minin();
            myReport.SetParameterValue("@MINUTES_ID", this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            RPT.Form2 myForm = new RPT.Form2();
            myForm.crystalReportViewer3.ReportSource = myReport;
            myForm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RPT.rpt_stu_single_22 myReport = new RPT.rpt_stu_single_22();
            myReport.SetParameterValue("@MINUTES_ID", this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            RPT.Form3 myForm = new RPT.Form3();
            myForm.crystalReportViewer4.ReportSource = myReport;
            myForm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RPT.scheout myReport = new RPT.scheout();
            myReport.SetParameterValue("@MINUTES_ID", this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            RPT.Form5 myForm = new RPT.Form5();
            myForm.crystalReportViewer6.ReportSource = myReport;
            myForm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            RPT.schein myReport = new RPT.schein();
            myReport.SetParameterValue("@MINUTES_ID", this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            RPT.Form4 myForm = new RPT.Form4();
            myForm.crystalReportViewer5.ReportSource = myReport;
            myForm.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            RPT.table myReport = new RPT.table();
            myReport.SetParameterValue("@MINUTES_ID", this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            RPT.Form6 myForm = new RPT.Form6();
            myForm.crystalReportViewer6.ReportSource = myReport;
            myForm.ShowDialog();
        }
    }

}