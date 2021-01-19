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
    public partial class Form15 : Form
    {
        private static Form15 frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

      

        private void Form15_Load(object sender, EventArgs e)
        {
            frm = null;
        }
        public static Form15 getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new Form15();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        BL.CLS_MINUTES MINUTES = new BL.CLS_MINUTES();
        public Form15()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.dataGridView11.DataSource = MINUTES.GET_ALL_MINUTES();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = MINUTES.SearchMINUTES(textBox11.Text);
            this.dataGridView11.DataSource = Dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RPT.rpt_stu_single myReport = new RPT.rpt_stu_single();
            myReport.SetParameterValue("@MINUTES_ID", this.dataGridView11.CurrentRow.Cells[0].Value.ToString());
            RPT.FRM_RPT_STUDENTS myForm = new RPT.FRM_RPT_STUDENTS();
            myForm.crystalReportViewer1.ReportSource = myReport;
            myForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RPT.rpt_minout myReport = new RPT.rpt_minout();
            myReport.SetParameterValue("@MINUTES_ID", this.dataGridView11.CurrentRow.Cells[0].Value.ToString());
            RPT.Form1 myForm = new RPT.Form1();
            myForm.crystalReportViewer2.ReportSource = myReport;
            myForm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RPT.minin myReport = new RPT.minin();
            myReport.SetParameterValue("@MINUTES_ID", this.dataGridView11.CurrentRow.Cells[0].Value.ToString());
            RPT.Form2 myForm = new RPT.Form2();
            myForm.crystalReportViewer3.ReportSource = myReport;
            myForm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RPT.rpt_stu_single_22 myReport = new RPT.rpt_stu_single_22();
            myReport.SetParameterValue("@MINUTES_ID", this.dataGridView11.CurrentRow.Cells[0].Value.ToString());
            RPT.Form3 myForm = new RPT.Form3();
            myForm.crystalReportViewer4.ReportSource = myReport;
            myForm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RPT.scheout myReport = new RPT.scheout();
            myReport.SetParameterValue("@MINUTES_ID", this.dataGridView11.CurrentRow.Cells[0].Value.ToString());
            RPT.Form5 myForm = new RPT.Form5();
            myForm.crystalReportViewer6.ReportSource = myReport;
            myForm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            RPT.schein myReport = new RPT.schein();
            myReport.SetParameterValue("@MINUTES_ID", this.dataGridView11.CurrentRow.Cells[0].Value.ToString());
            RPT.Form4 myForm = new RPT.Form4();
            myForm.crystalReportViewer5.ReportSource = myReport;
            myForm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            RPT.table myReport = new RPT.table();
            myReport.SetParameterValue("@MINUTES_ID", this.dataGridView11.CurrentRow.Cells[0].Value.ToString());
            RPT.Form6 myForm = new RPT.Form6();
            myForm.crystalReportViewer6.ReportSource = myReport;
            myForm.ShowDialog();
        }
    }
}
