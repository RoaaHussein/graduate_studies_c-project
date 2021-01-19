namespace login1
{
    partial class Form14
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1user = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.text8 = new System.Windows.Forms.TextBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1user)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1user
            // 
            this.dataGridView1user.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1user.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1user.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1user.Location = new System.Drawing.Point(37, 99);
            this.dataGridView1user.Name = "dataGridView1user";
            this.dataGridView1user.RowTemplate.Height = 28;
            this.dataGridView1user.Size = new System.Drawing.Size(929, 206);
            this.dataGridView1user.TabIndex = 185;
            this.dataGridView1user.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1user_CellContentClick);
            this.dataGridView1user.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1user_CellFormatting);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Maroon;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(903, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 30);
            this.label3.TabIndex = 184;
            this.label3.Text = ":بحث";
            // 
            // text8
            // 
            this.text8.BackColor = System.Drawing.Color.Gainsboro;
            this.text8.Location = new System.Drawing.Point(625, 40);
            this.text8.Name = "text8";
            this.text8.Size = new System.Drawing.Size(257, 27);
            this.text8.TabIndex = 183;
            this.text8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Maroon;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button13.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button13.Location = new System.Drawing.Point(579, 349);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(160, 43);
            this.button13.TabIndex = 182;
            this.button13.Text = "حذف المستخدم";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Maroon;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button14.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button14.Location = new System.Drawing.Point(758, 349);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(159, 43);
            this.button14.TabIndex = 181;
            this.button14.Text = "تعديل المستخدم";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::login1.Properties.Resources.kkkko;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(991, 494);
            this.Controls.Add(this.dataGridView1user);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text8);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form14";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة المستخدمين";
            this.Load += new System.EventHandler(this.Form14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text8;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
    }
}