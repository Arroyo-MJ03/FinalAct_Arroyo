namespace FinalAct_Arroyo
{
    partial class SignIn_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.passWord = new System.Windows.Forms.TextBox();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.linkToRegister = new System.Windows.Forms.LinkLabel();
            this.header2 = new System.Windows.Forms.Label();
            this.signInBtn = new System.Windows.Forms.Button();
            this.header1 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.subscript1 = new System.Windows.Forms.Label();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.passWord);
            this.panel1.Controls.Add(this.passwordlbl);
            this.panel1.Controls.Add(this.linkToRegister);
            this.panel1.Controls.Add(this.header2);
            this.panel1.Controls.Add(this.signInBtn);
            this.panel1.Controls.Add(this.header1);
            this.panel1.Controls.Add(this.userName);
            this.panel1.Controls.Add(this.subscript1);
            this.panel1.Controls.Add(this.usernamelbl);
            this.panel1.Location = new System.Drawing.Point(276, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 428);
            this.panel1.TabIndex = 10;
            // 
            // passWord
            // 
            this.passWord.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passWord.Location = new System.Drawing.Point(68, 237);
            this.passWord.Name = "passWord";
            this.passWord.Size = new System.Drawing.Size(298, 26);
            this.passWord.TabIndex = 10;
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlbl.Location = new System.Drawing.Point(65, 219);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(86, 20);
            this.passwordlbl.TabIndex = 9;
            this.passwordlbl.Text = "Password:";
            // 
            // linkToRegister
            // 
            this.linkToRegister.AutoSize = true;
            this.linkToRegister.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkToRegister.Location = new System.Drawing.Point(124, 372);
            this.linkToRegister.Name = "linkToRegister";
            this.linkToRegister.Size = new System.Drawing.Size(208, 14);
            this.linkToRegister.TabIndex = 7;
            this.linkToRegister.TabStop = true;
            this.linkToRegister.Text = "Don\'t have a Account? Register here.";
            this.linkToRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkToRegister_LinkClicked);
            // 
            // header2
            // 
            this.header2.AutoSize = true;
            this.header2.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header2.Location = new System.Drawing.Point(162, 48);
            this.header2.Name = "header2";
            this.header2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.header2.Size = new System.Drawing.Size(119, 32);
            this.header2.TabIndex = 8;
            this.header2.Text = "System";
            // 
            // signInBtn
            // 
            this.signInBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.signInBtn.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.signInBtn.FlatAppearance.BorderSize = 0;
            this.signInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signInBtn.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.signInBtn.Location = new System.Drawing.Point(144, 298);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(144, 44);
            this.signInBtn.TabIndex = 6;
            this.signInBtn.Text = "Sign In";
            this.signInBtn.UseVisualStyleBackColor = false;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // header1
            // 
            this.header1.AutoSize = true;
            this.header1.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header1.Location = new System.Drawing.Point(51, 16);
            this.header1.Name = "header1";
            this.header1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.header1.Size = new System.Drawing.Size(365, 32);
            this.header1.TabIndex = 0;
            this.header1.Text = "Inventory Management";
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(67, 162);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(298, 26);
            this.userName.TabIndex = 4;
            // 
            // subscript1
            // 
            this.subscript1.AutoSize = true;
            this.subscript1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subscript1.Location = new System.Drawing.Point(141, 87);
            this.subscript1.Name = "subscript1";
            this.subscript1.Size = new System.Drawing.Size(155, 15);
            this.subscript1.TabIndex = 1;
            this.subscript1.Text = "Sign In to your Account";
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelbl.Location = new System.Drawing.Point(64, 144);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(86, 20);
            this.usernamelbl.TabIndex = 2;
            this.usernamelbl.Text = "Username:";
            // 
            // SignIn_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1119, 520);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SignIn_Form";
            this.Text = "Inventory Management System";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox passWord;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.LinkLabel linkToRegister;
        private System.Windows.Forms.Label header2;
        private System.Windows.Forms.Button signInBtn;
        private System.Windows.Forms.Label header1;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label subscript1;
        private System.Windows.Forms.Label usernamelbl;
    }
}

