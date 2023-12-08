namespace FFEFKM
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.tabpage1 = new System.Windows.Forms.TabPage();
            this.tab_login = new System.Windows.Forms.TabPage();
            this.btn_loginregister = new System.Windows.Forms.Button();
            this.btn_loginlogin = new System.Windows.Forms.Button();
            this.txt_loginpassword = new System.Windows.Forms.TextBox();
            this.txt_loginmail = new System.Windows.Forms.TextBox();
            this.tab_register = new System.Windows.Forms.TabPage();
            this.btn_registerregister = new System.Windows.Forms.Button();
            this.btn_registerlogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_registerphone = new System.Windows.Forms.TextBox();
            this.txt_registerpassword = new System.Windows.Forms.TextBox();
            this.txt_registermail = new System.Windows.Forms.TextBox();
            this.txt_registername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.btn_close = new System.Windows.Forms.Button();
            this.tab_login.SuspendLayout();
            this.tab_register.SuspendLayout();
            this.tabcontrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabpage1
            // 
            this.tabpage1.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.tabpage1, "tabpage1");
            this.tabpage1.Name = "tabpage1";
            // 
            // tab_login
            // 
            this.tab_login.BackColor = System.Drawing.Color.DimGray;
            this.tab_login.Controls.Add(this.btn_loginregister);
            this.tab_login.Controls.Add(this.btn_loginlogin);
            this.tab_login.Controls.Add(this.txt_loginpassword);
            this.tab_login.Controls.Add(this.txt_loginmail);
            resources.ApplyResources(this.tab_login, "tab_login");
            this.tab_login.Name = "tab_login";
            // 
            // btn_loginregister
            // 
            resources.ApplyResources(this.btn_loginregister, "btn_loginregister");
            this.btn_loginregister.Name = "btn_loginregister";
            this.btn_loginregister.UseVisualStyleBackColor = true;
            this.btn_loginregister.Click += new System.EventHandler(this.btn_loginregister_Click);
            // 
            // btn_loginlogin
            // 
            resources.ApplyResources(this.btn_loginlogin, "btn_loginlogin");
            this.btn_loginlogin.Name = "btn_loginlogin";
            this.btn_loginlogin.UseVisualStyleBackColor = true;
            this.btn_loginlogin.Click += new System.EventHandler(this.btn_loginlogin_Click);
            // 
            // txt_loginpassword
            // 
            this.txt_loginpassword.BackColor = System.Drawing.SystemColors.HighlightText;
            resources.ApplyResources(this.txt_loginpassword, "txt_loginpassword");
            this.txt_loginpassword.Name = "txt_loginpassword";
            this.txt_loginpassword.UseSystemPasswordChar = true;
            // 
            // txt_loginmail
            // 
            this.txt_loginmail.BackColor = System.Drawing.SystemColors.HighlightText;
            resources.ApplyResources(this.txt_loginmail, "txt_loginmail");
            this.txt_loginmail.Name = "txt_loginmail";
            // 
            // tab_register
            // 
            this.tab_register.BackColor = System.Drawing.Color.DimGray;
            this.tab_register.Controls.Add(this.btn_registerregister);
            this.tab_register.Controls.Add(this.btn_registerlogin);
            this.tab_register.Controls.Add(this.label3);
            this.tab_register.Controls.Add(this.txt_registerphone);
            this.tab_register.Controls.Add(this.txt_registerpassword);
            this.tab_register.Controls.Add(this.txt_registermail);
            this.tab_register.Controls.Add(this.txt_registername);
            this.tab_register.Controls.Add(this.label2);
            this.tab_register.Controls.Add(this.label1);
            resources.ApplyResources(this.tab_register, "tab_register");
            this.tab_register.Name = "tab_register";
            // 
            // btn_registerregister
            // 
            resources.ApplyResources(this.btn_registerregister, "btn_registerregister");
            this.btn_registerregister.Name = "btn_registerregister";
            this.btn_registerregister.UseVisualStyleBackColor = true;
            this.btn_registerregister.Click += new System.EventHandler(this.btn_registerregister_Click);
            // 
            // btn_registerlogin
            // 
            resources.ApplyResources(this.btn_registerlogin, "btn_registerlogin");
            this.btn_registerlogin.Name = "btn_registerlogin";
            this.btn_registerlogin.UseVisualStyleBackColor = true;
            this.btn_registerlogin.Click += new System.EventHandler(this.btn_registerlogin_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txt_registerphone
            // 
            this.txt_registerphone.BackColor = System.Drawing.SystemColors.HighlightText;
            resources.ApplyResources(this.txt_registerphone, "txt_registerphone");
            this.txt_registerphone.Name = "txt_registerphone";
            // 
            // txt_registerpassword
            // 
            this.txt_registerpassword.BackColor = System.Drawing.SystemColors.HighlightText;
            resources.ApplyResources(this.txt_registerpassword, "txt_registerpassword");
            this.txt_registerpassword.Name = "txt_registerpassword";
            // 
            // txt_registermail
            // 
            this.txt_registermail.BackColor = System.Drawing.SystemColors.HighlightText;
            resources.ApplyResources(this.txt_registermail, "txt_registermail");
            this.txt_registermail.Name = "txt_registermail";
            // 
            // txt_registername
            // 
            this.txt_registername.BackColor = System.Drawing.SystemColors.HighlightText;
            resources.ApplyResources(this.txt_registername, "txt_registername");
            this.txt_registername.Name = "txt_registername";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.tab_register);
            this.tabcontrol.Controls.Add(this.tab_login);
            this.tabcontrol.Controls.Add(this.tabpage1);
            resources.ApplyResources(this.tabcontrol, "tabcontrol");
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.btn_close.ForeColor = System.Drawing.Color.DarkRed;
            resources.ApplyResources(this.btn_close, "btn_close");
            this.btn_close.Name = "btn_close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // LogIn
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.tabcontrol);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.tab_login.ResumeLayout(false);
            this.tab_login.PerformLayout();
            this.tab_register.ResumeLayout(false);
            this.tab_register.PerformLayout();
            this.tabcontrol.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabpage1;
        private System.Windows.Forms.TabPage tab_login;
        private System.Windows.Forms.Button btn_loginregister;
        private System.Windows.Forms.Button btn_loginlogin;
        private System.Windows.Forms.TextBox txt_loginpassword;
        private System.Windows.Forms.TextBox txt_loginmail;
        private System.Windows.Forms.TabPage tab_register;
        private System.Windows.Forms.Button btn_registerregister;
        private System.Windows.Forms.Button btn_registerlogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_registerphone;
        private System.Windows.Forms.TextBox txt_registerpassword;
        private System.Windows.Forms.TextBox txt_registermail;
        private System.Windows.Forms.TextBox txt_registername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.Button btn_close;
    }
}

