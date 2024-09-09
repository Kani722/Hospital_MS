namespace WindowsFormsApp1
{
    partial class Patient
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.addBtn = new System.Windows.Forms.Button();
			this.updateBtn = new System.Windows.Forms.Button();
			this.deleteBtn = new System.Windows.Forms.Button();
			this.resetBtn = new System.Windows.Forms.Button();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label1.Location = new System.Drawing.Point(189, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 37);
			this.label1.TabIndex = 17;
			this.label1.Text = "Patient";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Turquoise;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label2.Location = new System.Drawing.Point(12, 195);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 27);
			this.label2.TabIndex = 18;
			this.label2.Text = "Patient ID";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.Ivory;
			this.textBox1.Location = new System.Drawing.Point(168, 200);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(208, 22);
			this.textBox1.TabIndex = 23;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Turquoise;
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label3.Location = new System.Drawing.Point(12, 242);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 27);
			this.label3.TabIndex = 24;
			this.label3.Text = "Name";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Turquoise;
			this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label4.Location = new System.Drawing.Point(12, 289);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(93, 27);
			this.label4.TabIndex = 25;
			this.label4.Text = "Address";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Turquoise;
			this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label5.Location = new System.Drawing.Point(467, 195);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 27);
			this.label5.TabIndex = 26;
			this.label5.Text = "Age";
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.Ivory;
			this.textBox2.Location = new System.Drawing.Point(168, 247);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(208, 22);
			this.textBox2.TabIndex = 27;
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.Color.Ivory;
			this.textBox3.Location = new System.Drawing.Point(168, 294);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(208, 22);
			this.textBox3.TabIndex = 28;
			// 
			// textBox4
			// 
			this.textBox4.BackColor = System.Drawing.Color.Ivory;
			this.textBox4.Location = new System.Drawing.Point(168, 341);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(208, 22);
			this.textBox4.TabIndex = 29;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Turquoise;
			this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label6.Location = new System.Drawing.Point(12, 336);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(118, 27);
			this.label6.TabIndex = 30;
			this.label6.Text = "Phone No.";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Turquoise;
			this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label7.Location = new System.Drawing.Point(467, 242);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(85, 27);
			this.label7.TabIndex = 31;
			this.label7.Text = "Gender";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Turquoise;
			this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label8.Location = new System.Drawing.Point(467, 289);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(139, 27);
			this.label8.TabIndex = 32;
			this.label8.Text = "Blood Group";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Turquoise;
			this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label9.Location = new System.Drawing.Point(467, 336);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 27);
			this.label9.TabIndex = 33;
			this.label9.Text = "Diseases";
			// 
			// textBox5
			// 
			this.textBox5.BackColor = System.Drawing.Color.Ivory;
			this.textBox5.Location = new System.Drawing.Point(653, 200);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(208, 22);
			this.textBox5.TabIndex = 34;
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.Color.Ivory;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
			this.comboBox1.Location = new System.Drawing.Point(653, 247);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(104, 24);
			this.comboBox1.TabIndex = 35;
			// 
			// comboBox2
			// 
			this.comboBox2.BackColor = System.Drawing.Color.Ivory;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "A+",
            "B+",
            "O+",
            "AB+",
            "A-",
            "O-",
            "AB-"});
			this.comboBox2.Location = new System.Drawing.Point(653, 294);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(129, 24);
			this.comboBox2.TabIndex = 36;
			// 
			// textBox6
			// 
			this.textBox6.BackColor = System.Drawing.Color.Ivory;
			this.textBox6.Location = new System.Drawing.Point(653, 341);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(208, 22);
			this.textBox6.TabIndex = 37;
			// 
			// addBtn
			// 
			this.addBtn.BackColor = System.Drawing.Color.Teal;
			this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.addBtn.Location = new System.Drawing.Point(365, 12);
			this.addBtn.Name = "addBtn";
			this.addBtn.Size = new System.Drawing.Size(113, 42);
			this.addBtn.TabIndex = 38;
			this.addBtn.Text = "ADD";
			this.addBtn.UseVisualStyleBackColor = false;
			this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
			// 
			// updateBtn
			// 
			this.updateBtn.BackColor = System.Drawing.Color.Teal;
			this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.updateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.updateBtn.Location = new System.Drawing.Point(644, 12);
			this.updateBtn.Name = "updateBtn";
			this.updateBtn.Size = new System.Drawing.Size(113, 42);
			this.updateBtn.TabIndex = 39;
			this.updateBtn.Text = "UPDATE";
			this.updateBtn.UseVisualStyleBackColor = false;
			this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
			// 
			// deleteBtn
			// 
			this.deleteBtn.BackColor = System.Drawing.Color.DeepPink;
			this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.deleteBtn.Location = new System.Drawing.Point(644, 93);
			this.deleteBtn.Name = "deleteBtn";
			this.deleteBtn.Size = new System.Drawing.Size(113, 42);
			this.deleteBtn.TabIndex = 40;
			this.deleteBtn.Text = "DELETE";
			this.deleteBtn.UseVisualStyleBackColor = false;
			this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
			// 
			// resetBtn
			// 
			this.resetBtn.BackColor = System.Drawing.Color.DeepPink;
			this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resetBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.resetBtn.Location = new System.Drawing.Point(365, 100);
			this.resetBtn.Name = "resetBtn";
			this.resetBtn.Size = new System.Drawing.Size(113, 42);
			this.resetBtn.TabIndex = 41;
			this.resetBtn.Text = "CLEAR";
			this.resetBtn.UseVisualStyleBackColor = false;
			this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
			// 
			// dataGridView2
			// 
			this.dataGridView2.BackgroundColor = System.Drawing.Color.Ivory;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(12, 381);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowHeadersWidth = 51;
			this.dataGridView2.RowTemplate.Height = 24;
			this.dataGridView2.Size = new System.Drawing.Size(897, 244);
			this.dataGridView2.TabIndex = 44;
			this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Red;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.Location = new System.Drawing.Point(871, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(59, 49);
			this.button1.TabIndex = 57;
			this.button1.Text = "X";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.home3;
			this.pictureBox1.Location = new System.Drawing.Point(484, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(154, 123);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 42;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.download21;
			this.pictureBox3.Location = new System.Drawing.Point(17, 12);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(152, 144);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 13;
			this.pictureBox3.TabStop = false;
			// 
			// Patient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Turquoise;
			this.ClientSize = new System.Drawing.Size(930, 637);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.resetBtn);
			this.Controls.Add(this.deleteBtn);
			this.Controls.Add(this.updateBtn);
			this.Controls.Add(this.addBtn);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Patient";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Patient";
			this.Load += new System.EventHandler(this.Patient_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Button button1;
	}
}