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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (text1.Text == string.Empty || text2.Text == string.Empty || text3.Text == string.Empty || text4.Text == string.Empty)
            {
                MessageBox.Show("الرجاء ادخل جميع البيانات", "  تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (text3.Text != text4.Text)
            {
                MessageBox.Show("كلمة السر غيرمتطابقة", "  تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (b1.Text == "اضافة")
            {
                BL.CLS_LOGIN user = new BL.CLS_LOGIN();
                user.ADD_USER(text1.Text, text2.Text, text3.Text, com1.Text);
                user.user_author(Convert.ToBoolean(checkBox1.Checked));
                MessageBox.Show("تم اضافة المستخدم بنجاح", "اضافة مستخدم جديد", MessageBoxButtons.OK, MessageBoxIcon.Information);
              


            }
            else if (b1.Text == "تعديل")
            {
                BL.CLS_LOGIN user = new BL.CLS_LOGIN();
                user.EDIT_USER(text1.Text, text2.Text, text3.Text, com1.Text);
                MessageBox.Show("تم تعديل المستخدم بنجاح", "تعديل مستخدم جديد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            text1.Clear();
            text2.Clear();
            text3.Clear();
            text4.Clear();
            text1.Focus();

        }

        private void text4_Validated(object sender, EventArgs e)
        {
            if (text3.Text != text4.Text)
            {
                MessageBox.Show("كلمة السر غيرمتطابقة", "  تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void text4_Validated_1(object sender, EventArgs e)
        {
            if (text3.Text != text4.Text)
            {
                MessageBox.Show("كلمة السر غيرمتطابقة", "  تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form14 frm = new Form14();
            frm.ShowDialog();
        }

        private void com1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void text2_TextChanged(object sender, EventArgs e)
        {

        }

        private void text4_TextChanged(object sender, EventArgs e)
        {

        }

        private void text1_TextChanged(object sender, EventArgs e)
        {

        }

        private void text3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
