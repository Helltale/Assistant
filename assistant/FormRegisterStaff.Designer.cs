namespace assistant
{
    partial class FormRegisterStaff
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
            this.textBoxRS_login = new System.Windows.Forms.TextBox();
            this.textBoxRS_password = new System.Windows.Forms.TextBox();
            this.buttonRS_create = new System.Windows.Forms.Button();
            this.buttonRS_back = new System.Windows.Forms.Button();
            this.textBoxRS_password1 = new System.Windows.Forms.TextBox();
            this.textBoxRS_mailS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "   Заполните пожалуйтса следующие поля";
            // 
            // textBoxRS_login
            // 
            this.textBoxRS_login.Location = new System.Drawing.Point(15, 37);
            this.textBoxRS_login.Name = "textBoxRS_login";
            this.textBoxRS_login.Size = new System.Drawing.Size(226, 20);
            this.textBoxRS_login.TabIndex = 1;
            this.textBoxRS_login.Enter += new System.EventHandler(this.textBoxRS_login_Enter);
            this.textBoxRS_login.Leave += new System.EventHandler(this.textBoxRS_login_Leave);
            // 
            // textBoxRS_password
            // 
            this.textBoxRS_password.Location = new System.Drawing.Point(15, 63);
            this.textBoxRS_password.Name = "textBoxRS_password";
            this.textBoxRS_password.Size = new System.Drawing.Size(226, 20);
            this.textBoxRS_password.TabIndex = 2;
            this.textBoxRS_password.Enter += new System.EventHandler(this.textBoxRS_password_Enter);
            this.textBoxRS_password.Leave += new System.EventHandler(this.textBoxRS_password_Leave);
            // 
            // buttonRS_create
            // 
            this.buttonRS_create.Location = new System.Drawing.Point(15, 139);
            this.buttonRS_create.Name = "buttonRS_create";
            this.buttonRS_create.Size = new System.Drawing.Size(112, 23);
            this.buttonRS_create.TabIndex = 3;
            this.buttonRS_create.Text = "Зарегистрировать";
            this.buttonRS_create.UseVisualStyleBackColor = true;
            this.buttonRS_create.Click += new System.EventHandler(this.buttonRS_create_Click);
            // 
            // buttonRS_back
            // 
            this.buttonRS_back.Location = new System.Drawing.Point(129, 139);
            this.buttonRS_back.Name = "buttonRS_back";
            this.buttonRS_back.Size = new System.Drawing.Size(112, 23);
            this.buttonRS_back.TabIndex = 4;
            this.buttonRS_back.Text = "Назад";
            this.buttonRS_back.UseVisualStyleBackColor = true;
            // 
            // textBoxRS_password1
            // 
            this.textBoxRS_password1.Location = new System.Drawing.Point(14, 89);
            this.textBoxRS_password1.Name = "textBoxRS_password1";
            this.textBoxRS_password1.Size = new System.Drawing.Size(227, 20);
            this.textBoxRS_password1.TabIndex = 5;
            this.textBoxRS_password1.Enter += new System.EventHandler(this.textBoxRS_password1_Enter);
            this.textBoxRS_password1.Leave += new System.EventHandler(this.textBoxRS_password1_Leave);
            // 
            // textBoxRS_mailS
            // 
            this.textBoxRS_mailS.Location = new System.Drawing.Point(15, 115);
            this.textBoxRS_mailS.Name = "textBoxRS_mailS";
            this.textBoxRS_mailS.Size = new System.Drawing.Size(226, 20);
            this.textBoxRS_mailS.TabIndex = 6;
            this.textBoxRS_mailS.Enter += new System.EventHandler(this.textBoxRS_mailS_Enter);
            this.textBoxRS_mailS.Leave += new System.EventHandler(this.textBoxRS_mailS_Leave);
            // 
            // FormRegisterStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 190);
            this.Controls.Add(this.textBoxRS_mailS);
            this.Controls.Add(this.textBoxRS_password1);
            this.Controls.Add(this.buttonRS_back);
            this.Controls.Add(this.buttonRS_create);
            this.Controls.Add(this.textBoxRS_password);
            this.Controls.Add(this.textBoxRS_login);
            this.Controls.Add(this.label1);
            this.Name = "FormRegisterStaff";
            this.Text = "FormRegister";
            this.Load += new System.EventHandler(this.FormRegisterStaff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRS_login;
        private System.Windows.Forms.TextBox textBoxRS_password;
        private System.Windows.Forms.Button buttonRS_create;
        private System.Windows.Forms.Button buttonRS_back;
        private System.Windows.Forms.TextBox textBoxRS_password1;
        private System.Windows.Forms.TextBox textBoxRS_mailS;
    }
}