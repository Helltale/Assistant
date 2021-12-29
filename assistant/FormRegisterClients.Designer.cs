namespace assistant
{
    partial class FormRegisterClients
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
            this.textBoxRC_firstname = new System.Windows.Forms.TextBox();
            this.textBoxRC_lastname = new System.Windows.Forms.TextBox();
            this.textBoxRC_patronymuc = new System.Windows.Forms.TextBox();
            this.textBoxRC_birthday = new System.Windows.Forms.TextBox();
            this.textBoxRC_telephone = new System.Windows.Forms.TextBox();
            this.textBoxRC_email = new System.Windows.Forms.TextBox();
            this.buttonRC_create = new System.Windows.Forms.Button();
            this.buttonRC_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxRC_firstname
            // 
            this.textBoxRC_firstname.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRC_firstname.Location = new System.Drawing.Point(14, 76);
            this.textBoxRC_firstname.Name = "textBoxRC_firstname";
            this.textBoxRC_firstname.Size = new System.Drawing.Size(170, 20);
            this.textBoxRC_firstname.TabIndex = 0;
            this.textBoxRC_firstname.TextChanged += new System.EventHandler(this.textBoxRC_firstname_TextChanged);
            this.textBoxRC_firstname.Enter += new System.EventHandler(this.textBoxRC_firstname_Enter);
            this.textBoxRC_firstname.Leave += new System.EventHandler(this.textBoxRC_firstname_Leave);
            // 
            // textBoxRC_lastname
            // 
            this.textBoxRC_lastname.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRC_lastname.Location = new System.Drawing.Point(14, 102);
            this.textBoxRC_lastname.Name = "textBoxRC_lastname";
            this.textBoxRC_lastname.Size = new System.Drawing.Size(170, 20);
            this.textBoxRC_lastname.TabIndex = 1;
            this.textBoxRC_lastname.Enter += new System.EventHandler(this.textBoxRC_lastname_Enter);
            this.textBoxRC_lastname.Leave += new System.EventHandler(this.textBoxRC_lastname_Leave);
            // 
            // textBoxRC_patronymuc
            // 
            this.textBoxRC_patronymuc.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRC_patronymuc.Location = new System.Drawing.Point(14, 128);
            this.textBoxRC_patronymuc.Name = "textBoxRC_patronymuc";
            this.textBoxRC_patronymuc.Size = new System.Drawing.Size(170, 20);
            this.textBoxRC_patronymuc.TabIndex = 2;
            this.textBoxRC_patronymuc.Enter += new System.EventHandler(this.textBoxRC_patronymuc_Enter);
            this.textBoxRC_patronymuc.Leave += new System.EventHandler(this.textBoxRC_patronymuc_Leave);
            // 
            // textBoxRC_birthday
            // 
            this.textBoxRC_birthday.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRC_birthday.Location = new System.Drawing.Point(14, 154);
            this.textBoxRC_birthday.Name = "textBoxRC_birthday";
            this.textBoxRC_birthday.Size = new System.Drawing.Size(170, 20);
            this.textBoxRC_birthday.TabIndex = 3;
            this.textBoxRC_birthday.Enter += new System.EventHandler(this.textBoxRC_birthday_Enter);
            this.textBoxRC_birthday.Leave += new System.EventHandler(this.textBoxRC_birthday_Leave);
            // 
            // textBoxRC_telephone
            // 
            this.textBoxRC_telephone.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRC_telephone.Location = new System.Drawing.Point(14, 180);
            this.textBoxRC_telephone.Name = "textBoxRC_telephone";
            this.textBoxRC_telephone.Size = new System.Drawing.Size(170, 20);
            this.textBoxRC_telephone.TabIndex = 4;
            this.textBoxRC_telephone.Enter += new System.EventHandler(this.textBoxRC_telephone_Enter);
            this.textBoxRC_telephone.Leave += new System.EventHandler(this.textBoxRC_telephone_Leave);
            // 
            // textBoxRC_email
            // 
            this.textBoxRC_email.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRC_email.Location = new System.Drawing.Point(14, 206);
            this.textBoxRC_email.Name = "textBoxRC_email";
            this.textBoxRC_email.Size = new System.Drawing.Size(170, 20);
            this.textBoxRC_email.TabIndex = 5;
            this.textBoxRC_email.Enter += new System.EventHandler(this.textBoxRC_email_Enter);
            this.textBoxRC_email.Leave += new System.EventHandler(this.textBoxRC_email_Leave);
            // 
            // buttonRC_create
            // 
            this.buttonRC_create.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRC_create.Location = new System.Drawing.Point(14, 232);
            this.buttonRC_create.Name = "buttonRC_create";
            this.buttonRC_create.Size = new System.Drawing.Size(75, 23);
            this.buttonRC_create.TabIndex = 6;
            this.buttonRC_create.Text = "Создать";
            this.buttonRC_create.UseVisualStyleBackColor = true;
            this.buttonRC_create.Click += new System.EventHandler(this.buttonRC_create_Click);
            // 
            // buttonRC_back
            // 
            this.buttonRC_back.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRC_back.Location = new System.Drawing.Point(109, 232);
            this.buttonRC_back.Name = "buttonRC_back";
            this.buttonRC_back.Size = new System.Drawing.Size(75, 23);
            this.buttonRC_back.TabIndex = 7;
            this.buttonRC_back.Text = "Назад";
            this.buttonRC_back.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 64);
            this.label1.TabIndex = 8;
            this.label1.Text = "Пожалуйста заполните \r\nинформацию o\r\nновом клиенте\r\n\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormRegisterClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(199, 271);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRC_back);
            this.Controls.Add(this.buttonRC_create);
            this.Controls.Add(this.textBoxRC_email);
            this.Controls.Add(this.textBoxRC_telephone);
            this.Controls.Add(this.textBoxRC_birthday);
            this.Controls.Add(this.textBoxRC_patronymuc);
            this.Controls.Add(this.textBoxRC_lastname);
            this.Controls.Add(this.textBoxRC_firstname);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(215, 310);
            this.MinimumSize = new System.Drawing.Size(215, 310);
            this.Name = "FormRegisterClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegisterClients";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRC_firstname;
        private System.Windows.Forms.TextBox textBoxRC_lastname;
        private System.Windows.Forms.TextBox textBoxRC_patronymuc;
        private System.Windows.Forms.TextBox textBoxRC_birthday;
        private System.Windows.Forms.TextBox textBoxRC_telephone;
        private System.Windows.Forms.TextBox textBoxRC_email;
        private System.Windows.Forms.Button buttonRC_create;
        private System.Windows.Forms.Button buttonRC_back;
        private System.Windows.Forms.Label label1;
    }
}