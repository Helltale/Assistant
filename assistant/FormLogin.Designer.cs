namespace assistant
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.login_Button = new System.Windows.Forms.Button();
            this.close_Button = new System.Windows.Forms.Button();
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // login_Button
            // 
            this.login_Button.BackColor = System.Drawing.Color.Silver;
            this.login_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_Button.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.login_Button.Location = new System.Drawing.Point(37, 87);
            this.login_Button.Name = "login_Button";
            this.login_Button.Size = new System.Drawing.Size(75, 23);
            this.login_Button.TabIndex = 1;
            this.login_Button.Text = "Войти";
            this.login_Button.UseVisualStyleBackColor = false;
            this.login_Button.Click += new System.EventHandler(this.login_Button_Click);
            // 
            // close_Button
            // 
            this.close_Button.BackColor = System.Drawing.Color.Silver;
            this.close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close_Button.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.close_Button.Location = new System.Drawing.Point(129, 87);
            this.close_Button.Name = "close_Button";
            this.close_Button.Size = new System.Drawing.Size(75, 23);
            this.close_Button.TabIndex = 2;
            this.close_Button.Text = "Выход";
            this.close_Button.UseVisualStyleBackColor = false;
            this.close_Button.Click += new System.EventHandler(this.close_Button_Click);
            // 
            // login_textBox
            // 
            this.login_textBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.login_textBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_textBox.Location = new System.Drawing.Point(37, 35);
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(167, 20);
            this.login_textBox.TabIndex = 3;
            this.login_textBox.TextChanged += new System.EventHandler(this.login_textBox_TextChanged);
            this.login_textBox.Enter += new System.EventHandler(this.login_textBox_Enter);
            this.login_textBox.Leave += new System.EventHandler(this.login_textBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = " Пожалуйста, войдите в систему";
            // 
            // password_textBox
            // 
            this.password_textBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.password_textBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_textBox.Location = new System.Drawing.Point(37, 61);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(167, 20);
            this.password_textBox.TabIndex = 6;
            this.password_textBox.TextChanged += new System.EventHandler(this.password_textBox_TextChanged_1);
            this.password_textBox.Enter += new System.EventHandler(this.password_textBox_Enter_1);
            this.password_textBox.Leave += new System.EventHandler(this.password_textBox_Leave_1);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(244, 121);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_textBox);
            this.Controls.Add(this.close_Button);
            this.Controls.Add(this.login_Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(260, 160);
            this.MinimumSize = new System.Drawing.Size(260, 160);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.Enter += new System.EventHandler(this.FormLogin_Enter);
            this.Leave += new System.EventHandler(this.FormLogin_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_Button;
        private System.Windows.Forms.Button close_Button;
        private System.Windows.Forms.TextBox login_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password_textBox;
    }
}