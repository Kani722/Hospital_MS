namespace WindowsFormsApp1
{
    partial class Doctor
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
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.addBtn = new System.Windows.Forms.Button();
			this.resetBtn = new System.Windows.Forms.Button();
			this.deleteBtn = new System.Windows.Forms.Button();
			this.updateBtn = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label1.Location = new System.Drawing.Point(268, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 37);
			this.label1.TabIndex = 16;
			this.label1.Text = "Doctor";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Turquoise;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label2.Location = new System.Drawing.Point(25, 179);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 27);
			this.label2.TabIndex = 17;
			this.label2.Text = "Doctor ID";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Turquoise;
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label3.Location = new System.Drawing.Point(194, 179);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 27);
			this.label3.TabIndex = 18;
			this.label3.Text = "Title";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Turquoise;
			this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label4.Location = new System.Drawing.Point(283, 179);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(147, 27);
			this.label4.TabIndex = 19;
			this.label4.Text = "Doctor Name";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Turquoise;
			this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label5.Location = new System.Drawing.Point(543, 179);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(151, 27);
			this.label5.TabIndex = 20;
			this.label5.Text = "Specialization";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Turquoise;
			this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label6.Location = new System.Drawing.Point(744, 179);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(175, 27);
			this.label6.TabIndex = 21;
			this.label6.Text = "License Number";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.Ivory;
			this.textBox1.Location = new System.Drawing.Point(12, 231);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(131, 22);
			this.textBox1.TabIndex = 22;
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.Ivory;
			this.textBox2.Location = new System.Drawing.Point(288, 231);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(224, 22);
			this.textBox2.TabIndex = 23;
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.Color.Ivory;
			this.textBox3.Location = new System.Drawing.Point(548, 229);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(154, 22);
			this.textBox3.TabIndex = 24;
			// 
			// textBox4
			// 
			this.textBox4.BackColor = System.Drawing.Color.Ivory;
			this.textBox4.Location = new System.Drawing.Point(743, 229);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(166, 22);
			this.textBox4.TabIndex = 25;
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.Color.Ivory;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Mr.",
            "Mrs.",
            "Miss."});
			this.comboBox1.Location = new System.Drawing.Point(177, 229);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(85, 24);
			this.comboBox1.TabIndex = 26;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.Ivory;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 287);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(897, 231);
			this.dataGridView1.TabIndex = 27;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
			// 
			// addBtn
			// 
			this.addBtn.BackColor = System.Drawing.Color.Teal;
			this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.addBtn.Location = new System.Drawing.Point(30, 551);
			this.addBtn.Name = "addBtn";
			this.addBtn.Size = new System.Drawing.Size(113, 42);
			this.addBtn.TabIndex = 31;
			this.addBtn.Text = "ADD";
			this.addBtn.UseVisualStyleBackColor = false;
			this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
			// 
			// resetBtn
			// 
			this.resetBtn.BackColor = System.Drawing.Color.DeepPink;
			this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resetBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.resetBtn.Location = new System.Drawing.Point(758, 551);
			this.resetBtn.Name = "resetBtn";
			this.resetBtn.Size = new System.Drawing.Size(113, 42);
			this.resetBtn.TabIndex = 32;
			this.resetBtn.Text = "CLEAR";
			this.resetBtn.UseVisualStyleBackColor = false;
			this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
			// 
			// deleteBtn
			// 
			this.deleteBtn.BackColor = System.Drawing.Color.DeepPink;
			this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.deleteBtn.Location = new System.Drawing.Point(581, 551);
			this.deleteBtn.Name = "deleteBtn";
			this.deleteBtn.Size = new System.Drawing.Size(113, 42);
			this.deleteBtn.TabIndex = 33;
			this.deleteBtn.Text = "DELETE";
			this.deleteBtn.UseVisualStyleBackColor = false;
			this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
			// 
			// updateBtn
			// 
			this.updateBtn.BackColor = System.Drawing.Color.Teal;
			this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.updateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.updateBtn.Location = new System.Drawing.Point(215, 551);
			this.updateBtn.Name = "updateBtn";
			this.updateBtn.Size = new System.Drawing.Size(113, 42);
			this.updateBtn.TabIndex = 34;
			this.updateBtn.Text = "UPDATE";
			this.updateBtn.UseVisualStyleBackColor = false;
			this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.home1;
			this.pictureBox1.Location = new System.Drawing.Point(415, 524);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(97, 79);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 28;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// pictureBox5
			// 
			this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.Login_logo;
			this.pictureBox5.Location = new System.Drawing.Point(120, 12);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(131, 123);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox5.TabIndex = 15;
			this.pictureBox5.TabStop = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Red;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.Location = new System.Drawing.Point(872, -1);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(59, 49);
			this.button1.TabIndex = 56;
			this.button1.Text = "X";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Doctor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Turquoise;
			this.ClientSize = new System.Drawing.Size(931, 632);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.updateBtn);
			this.Controls.Add(this.deleteBtn);
			this.Controls.Add(this.resetBtn);
			this.Controls.Add(this.addBtn);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox5);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Doctor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Doctor";
			this.Load += new System.EventHandler(this.Doctor_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
		private System.Windows.Forms.Button button1;
	}
}