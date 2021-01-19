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
    public partial class maın1 : Form
    {
        
        private static maın1 frm;
        static void frm_formClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;  
        }

        public static maın1 getMainForm
            {
             get
            {
                if(frm==null)
                {
                    frm = new maın1();
                    frm.FormClosed+= new FormClosedEventHandler(frm_formClosed);
                }
                return frm;
            }
            
            }

        public maın1()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.button2.Enabled = false;
            this.button3.Enabled = false;
            this.button4.Enabled = false;
            this.button5.Enabled = false;
            this.button6.Enabled = false;
            this.button7.Enabled = false;

            



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 frm = new Form9();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form13 frm = new Form13();
            frm.ShowDialog();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form15 frm = new Form15();
            frm.ShowDialog();
        }

      

        private void button7_Click_2(object sender, EventArgs e)
        {

            //if (frm == null)
            //    frm = this;
            //this.Visible = false;
            this.button1.Visible = true;
            this.button2.Enabled = false;
            this.button3.Enabled = false;
            this.button4.Enabled = false;
            this.button5.Enabled = false;
            this.button6.Enabled = false;
            this.button7.Enabled = false;
            Form1 frm = new Form1();
            frm.ShowDialog();

        }
    }
}
