namespace WindowsFormsApp1
{
    partial class Diagnosis
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
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.addBtn = new System.Windows.Forms.Button();
			this.updateBtn = new System.Windows.Forms.Button();
			this.deleteBtn = new System.Windows.Forms.Button();
			this.resetBtn = new System.Windows.Forms.Button();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			this.SuspendLayout();
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label6.Location = new System.Drawing.Point(171, 59);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(154, 37);
			this.label6.TabIndex = 21;
			this.label6.Text = "Diagnosis";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Turquoise;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label2.Location = new System.Drawing.Point(12, 186);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(140, 27);
			this.label2.TabIndex = 22;
			this.label2.Text = "Diagnosis ID";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.MintCream;
			this.textBox1.Location = new System.Drawing.Point(206, 191);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(208, 22);
			this.textBox1.TabIndex = 24;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Turquoise;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label1.Location = new System.Drawing.Point(12, 256);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 27);
			this.label1.TabIndex = 25;
			this.label1.Text = "Patient ID";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Turquoise;
			this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label5.Location = new System.Drawing.Point(7, 331);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(160, 27);
			this.label5.TabIndex = 28;
			this.label5.Text = "Diagnosis Test";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Turquoise;
			this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label7.Location = new System.Drawing.Point(12, 414);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(105, 27);
			this.label7.TabIndex = 29;
			this.label7.Text = "Medicine";
			// 
			// textBox4
			// 
			this.textBox4.BackColor = System.Drawing.Color.Ivory;
			this.textBox4.Location = new System.Drawing.Point(206, 336);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(208, 22);
			this.textBox4.TabIndex = 32;
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.Color.Ivory;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
			this.comboBox1.Location = new System.Drawing.Point(206, 261);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(208, 24);
			this.comboBox1.TabIndex = 36;
			this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label8.Location = new System.Drawing.Point(495, 70);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(297, 37);
			this.label8.TabIndex = 38;
			this.label8.Text = "Diagnosis Summary";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.LightYellow;
			this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label9.Location = new System.Drawing.Point(500, 133);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(151, 27);
			this.label9.TabIndex = 39;
			this.label9.Text = "Patient Name";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.LightYellow;
			this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label10.Location = new System.Drawing.Point(750, 133);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(160, 27);
			this.label10.TabIndex = 40;
			this.label10.Text = "Diagnosis Test";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.Color.LightYellow;
			this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label12.Location = new System.Drawing.Point(645, 191);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(115, 27);
			this.label12.TabIndex = 42;
			this.label12.Text = "Medicines";
			// 
			// addBtn
			// 
			this.addBtn.BackColor = System.Drawing.Color.Teal;
			this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.addBtn.Location = new System.Drawing.Point(538, 280);
			this.addBtn.Name = "addBtn";
			this.addBtn.Size = new System.Drawing.Size(113, 42);
			this.addBtn.TabIndex = 43;
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
			this.updateBtn.Location = new System.Drawing.Point(806, 280);
			this.updateBtn.Name = "updateBtn";
			this.updateBtn.Size = new System.Drawing.Size(113, 42);
			this.updateBtn.TabIndex = 44;
			this.updateBtn.Text = "UPDATE";
			this.updateBtn.UseVisualStyleBackColor = false;
			this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
			// 
			// deleteBtn
			// 
			this.deleteBtn.BackColor = System.Drawing.Color.DeepPink;
			this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.deleteBtn.Location = new System.Drawing.Point(538, 419);
			this.deleteBtn.Name = "deleteBtn";
			this.deleteBtn.Size = new System.Drawing.Size(113, 42);
			this.deleteBtn.TabIndex = 45;
			this.deleteBtn.Text = "DELETE";
			this.deleteBtn.UseVisualStyleBackColor = false;
			this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
			// 
			// resetBtn
			// 
			this.resetBtn.BackColor = System.Drawing.Color.DeepPink;
			this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resetBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.resetBtn.Location = new System.Drawing.Point(806, 419);
			this.resetBtn.Name = "resetBtn";
			this.resetBtn.Size = new System.Drawing.Size(113, 42);
			this.resetBtn.TabIndex = 46;
			this.resetBtn.Text = "CLEAR";
			this.resetBtn.UseVisualStyleBackColor = false;
			this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
			// 
			// dataGridView2
			// 
			this.dataGridView2.BackgroundColor = System.Drawing.Color.Ivory;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(12, 502);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowHeadersWidth = 51;
			this.dataGridView2.RowTemplate.Height = 24;
			this.dataGridView2.Size = new System.Drawing.Size(931, 236);
			this.dataGridView2.TabIndex = 50;
			this.dataGridView2.DoubleClick += new System.EventHandler(this.dataGridView2_DoubleClick);
			// 
			// textBox5
			// 
			this.textBox5.BackColor = System.Drawing.Color.Ivory;
			this.textBox5.Location = new System.Drawing.Point(206, 419);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(208, 22);
			this.textBox5.TabIndex = 51;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Turquoise;
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label3.Location = new System.Drawing.Point(12, 304);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(0, 27);
			this.label3.TabIndex = 26;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.home;
			this.pictureBox1.Location = new System.Drawing.Point(678, 326);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(93, 89);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 48;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// pictureBox6
			// 
			this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox6.Image = global::WindowsFormsApp1.Properties.Resources.images1;
			this.pictureBox6.Location = new System.Drawing.Point(33, 25);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(119, 123);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox6.TabIndex = 20;
			this.pictureBox6.TabStop = false;
			this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Red;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.Location = new System.Drawing.Point(897, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(59, 49);
			this.button1.TabIndex = 56;
			this.button1.Text = "X";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Diagnosis
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Turquoise;
			this.ClientSize = new System.Drawing.Size(955, 750);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.resetBtn);
			this.Controls.Add(this.deleteBtn);
			this.Controls.Add(this.updateBtn);
			this.Controls.Add(this.addBtn);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.pictureBox6);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Diagnosis";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Diagnosis";
			this.Load += new System.EventHandler(this.Diagnosis_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
	}
}