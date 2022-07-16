namespace PET_SHOP_MANAGER
{
    partial class Bill
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
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vbButton3 = new CustomButton.VBButton();
            this.vbButton6 = new CustomButton.VBButton();
            this.vbButton5 = new CustomButton.VBButton();
            this.vbButton4 = new CustomButton.VBButton();
            this.vbButton2 = new CustomButton.VBButton();
            this.vbButton1 = new CustomButton.VBButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(634, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 35);
            this.label8.TabIndex = 37;
            this.label8.Text = "Bill List";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(70, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 27);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(66, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(643, 260);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Phone";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Employee";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // vbButton3
            // 
            this.vbButton3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.vbButton3.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.vbButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton3.BorderRadius = 20;
            this.vbButton3.BorderSize = 0;
            this.vbButton3.FlatAppearance.BorderSize = 0;
            this.vbButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton3.ForeColor = System.Drawing.Color.White;
            this.vbButton3.Location = new System.Drawing.Point(55, 276);
            this.vbButton3.Name = "vbButton3";
            this.vbButton3.Size = new System.Drawing.Size(146, 44);
            this.vbButton3.TabIndex = 32;
            this.vbButton3.Text = "EMPLOYEE";
            this.vbButton3.TextColor = System.Drawing.Color.White;
            this.vbButton3.UseVisualStyleBackColor = false;
            // 
            // vbButton6
            // 
            this.vbButton6.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.vbButton6.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.vbButton6.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton6.BorderRadius = 20;
            this.vbButton6.BorderSize = 0;
            this.vbButton6.FlatAppearance.BorderSize = 0;
            this.vbButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton6.ForeColor = System.Drawing.Color.White;
            this.vbButton6.Location = new System.Drawing.Point(55, 426);
            this.vbButton6.Name = "vbButton6";
            this.vbButton6.Size = new System.Drawing.Size(146, 44);
            this.vbButton6.TabIndex = 35;
            this.vbButton6.Text = "LOGOUT";
            this.vbButton6.TextColor = System.Drawing.Color.White;
            this.vbButton6.UseVisualStyleBackColor = false;
            // 
            // vbButton5
            // 
            this.vbButton5.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.vbButton5.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.vbButton5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton5.BorderRadius = 20;
            this.vbButton5.BorderSize = 0;
            this.vbButton5.FlatAppearance.BorderSize = 0;
            this.vbButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton5.ForeColor = System.Drawing.Color.White;
            this.vbButton5.Location = new System.Drawing.Point(55, 376);
            this.vbButton5.Name = "vbButton5";
            this.vbButton5.Size = new System.Drawing.Size(146, 44);
            this.vbButton5.TabIndex = 34;
            this.vbButton5.Text = "BILLING";
            this.vbButton5.TextColor = System.Drawing.Color.White;
            this.vbButton5.UseVisualStyleBackColor = false;
            // 
            // vbButton4
            // 
            this.vbButton4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.vbButton4.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.vbButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton4.BorderRadius = 20;
            this.vbButton4.BorderSize = 0;
            this.vbButton4.FlatAppearance.BorderSize = 0;
            this.vbButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton4.ForeColor = System.Drawing.Color.White;
            this.vbButton4.Location = new System.Drawing.Point(55, 326);
            this.vbButton4.Name = "vbButton4";
            this.vbButton4.Size = new System.Drawing.Size(146, 44);
            this.vbButton4.TabIndex = 33;
            this.vbButton4.Text = "CUSTOMER";
            this.vbButton4.TextColor = System.Drawing.Color.White;
            this.vbButton4.UseVisualStyleBackColor = false;
            // 
            // vbButton2
            // 
            this.vbButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.vbButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.vbButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton2.BorderRadius = 20;
            this.vbButton2.BorderSize = 0;
            this.vbButton2.FlatAppearance.BorderSize = 0;
            this.vbButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton2.ForeColor = System.Drawing.Color.White;
            this.vbButton2.Location = new System.Drawing.Point(55, 226);
            this.vbButton2.Name = "vbButton2";
            this.vbButton2.Size = new System.Drawing.Size(146, 44);
            this.vbButton2.TabIndex = 31;
            this.vbButton2.Text = "PRODUCT";
            this.vbButton2.TextColor = System.Drawing.Color.White;
            this.vbButton2.UseVisualStyleBackColor = false;
            // 
            // vbButton1
            // 
            this.vbButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.vbButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.vbButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton1.BorderRadius = 20;
            this.vbButton1.BorderSize = 0;
            this.vbButton1.FlatAppearance.BorderSize = 0;
            this.vbButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton1.ForeColor = System.Drawing.Color.White;
            this.vbButton1.Location = new System.Drawing.Point(55, 176);
            this.vbButton1.Name = "vbButton1";
            this.vbButton1.Size = new System.Drawing.Size(146, 44);
            this.vbButton1.TabIndex = 30;
            this.vbButton1.Text = "HOME";
            this.vbButton1.TextColor = System.Drawing.Color.White;
            this.vbButton1.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PET_SHOP_MANAGER.Properties.Resources.Pet_shop_logo_generated;
            this.pictureBox2.Location = new System.Drawing.Point(77, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(386, 323);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 388);
            this.panel1.TabIndex = 28;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(346, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Phone";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(396, 31);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(162, 27);
            this.textBox3.TabIndex = 22;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(386, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(841, 247);
            this.panel2.TabIndex = 38;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Column6});
            this.dataGridView2.Location = new System.Drawing.Point(49, 15);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(634, 218);
            this.dataGridView2.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(587, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Employee";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(659, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 27);
            this.textBox1.TabIndex = 24;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Sex";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Dateofbirth";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Price";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Quantity";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.vbButton3);
            this.Controls.Add(this.vbButton6);
            this.Controls.Add(this.vbButton5);
            this.Controls.Add(this.vbButton4);
            this.Controls.Add(this.vbButton2);
            this.Controls.Add(this.vbButton1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bill";
            this.Text = "Custormer";
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CustomButton.VBButton vbButton3;
        private CustomButton.VBButton vbButton6;
        private CustomButton.VBButton vbButton5;
        private CustomButton.VBButton vbButton4;
        private CustomButton.VBButton vbButton2;
        private CustomButton.VBButton vbButton1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}