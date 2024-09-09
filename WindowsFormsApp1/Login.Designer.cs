namespace WindowsFormsApp1
{
    partial class Login
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
			this.label2 = new System.Windows.Forms.Label();
			this.admin = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.password = new System.Windows.Forms.RichTextBox();
			this.loginBtn = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.clearBtn = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(32, 370);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(130, 31);
			this.label2.TabIndex = 2;
			this.label2.Text = "Username";
			// 
			// admin
			// 
			this.admin.BackColor = System.Drawing.Color.Honeydew;
			this.admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.admin.Location = new System.Drawing.Point(238, 365);
			this.admin.Name = "admin";
			this.admin.Size = new System.Drawing.Size(315, 36);
			this.admin.TabIndex = 3;
			this.admin.Text = "";
			this.admin.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(32, 448);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(124, 31);
			this.label3.TabIndex = 4;
			this.label3.Text = "Password";
			// 
			// password
			// 
			this.password.BackColor = System.Drawing.Color.Honeydew;
			this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.password.Location = new System.Drawing.Point(238, 441);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(315, 37);
			this.password.TabIndex = 5;
			this.password.Text = " ";
			this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
			// 
			// loginBtn
			// 
			this.loginBtn.BackColor = System.Drawing.Color.Teal;
			this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.loginBtn.Location = new System.Drawing.Point(178, 520);
			this.loginBtn.Name = "loginBtn";
			this.loginBtn.Size = new System.Drawing.Size(113, 42);
			this.loginBtn.TabIndex = 6;
			this.loginBtn.Text = "LOGIN";
			this.loginBtn.UseVisualStyleBackColor = false;
			this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(115, -1);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(519, 44);
			this.label4.TabIndex = 8;
			this.label4.Text = "Hospital Management System\r\n";
			// 
			// clearBtn
			// 
			this.clearBtn.BackColor = System.Drawing.Color.DeepPink;
			this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clearBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.clearBtn.Location = new System.Drawing.Point(521, 520);
			this.clearBtn.Name = "clearBtn";
			this.clearBtn.Size = new System.Drawing.Size(113, 42);
			this.clearBtn.TabIndex = 9;
			this.clearBtn.Text = "CLEAR";
			this.clearBtn.UseVisualStyleBackColor = false;
			this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Red;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.Location = new System.Drawing.Point(721, -1);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(51, 53);
			this.button1.TabIndex = 10;
			this.button1.Text = "X";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.download_2;
			this.pictureBox1.Location = new System.Drawing.Point(288, 78);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(223, 214);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(771, 611);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.clearBtn);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.loginBtn);
			this.Controls.Add(this.password);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.admin);
			this.Controls.Add(this.label2);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Login_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox admin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox password;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button button1;
	}
}

