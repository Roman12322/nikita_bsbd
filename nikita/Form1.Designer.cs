namespace nikita
{
    partial class auth
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login_auth_txt = new System.Windows.Forms.TextBox();
            this.pass_auth_txt = new System.Windows.Forms.TextBox();
            this.phone_auth_txt = new System.Windows.Forms.TextBox();
            this.signinstatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "sign in";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "phone number";
            // 
            // login_auth_txt
            // 
            this.login_auth_txt.Location = new System.Drawing.Point(93, 9);
            this.login_auth_txt.Name = "login_auth_txt";
            this.login_auth_txt.Size = new System.Drawing.Size(228, 20);
            this.login_auth_txt.TabIndex = 4;
            // 
            // pass_auth_txt
            // 
            this.pass_auth_txt.Location = new System.Drawing.Point(93, 43);
            this.pass_auth_txt.Name = "pass_auth_txt";
            this.pass_auth_txt.PasswordChar = '*';
            this.pass_auth_txt.Size = new System.Drawing.Size(228, 20);
            this.pass_auth_txt.TabIndex = 5;
            this.pass_auth_txt.UseSystemPasswordChar = true;
            // 
            // phone_auth_txt
            // 
            this.phone_auth_txt.Location = new System.Drawing.Point(93, 87);
            this.phone_auth_txt.Name = "phone_auth_txt";
            this.phone_auth_txt.Size = new System.Drawing.Size(228, 20);
            this.phone_auth_txt.TabIndex = 6;
            // 
            // signinstatus
            // 
            this.signinstatus.FormattingEnabled = true;
            this.signinstatus.Items.AddRange(new object[] {
            "customer",
            "driver"});
            this.signinstatus.Location = new System.Drawing.Point(109, 123);
            this.signinstatus.Name = "signinstatus";
            this.signinstatus.Size = new System.Drawing.Size(121, 21);
            this.signinstatus.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "sign in as";
            // 
            // auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 157);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.signinstatus);
            this.Controls.Add(this.phone_auth_txt);
            this.Controls.Add(this.pass_auth_txt);
            this.Controls.Add(this.login_auth_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "auth";
            this.Text = "authorize page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login_auth_txt;
        private System.Windows.Forms.TextBox pass_auth_txt;
        private System.Windows.Forms.TextBox phone_auth_txt;
        private System.Windows.Forms.ComboBox signinstatus;
        private System.Windows.Forms.Label label4;
    }
}

