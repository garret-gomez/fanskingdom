namespace StoreUI
{
    partial class CustomerLoginForm
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
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginEmailLabel = new System.Windows.Forms.Label();
            this.emailLoginTextBox = new System.Windows.Forms.TextBox();
            this.passwordLoginLabel = new System.Windows.Forms.Label();
            this.passwordLoginTextBox = new System.Windows.Forms.TextBox();
            this.forgotPasswordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.loginFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.loginLabel.Location = new System.Drawing.Point(53, 45);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(113, 50);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Login";
            // 
            // loginEmailLabel
            // 
            this.loginEmailLabel.AutoSize = true;
            this.loginEmailLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginEmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.loginEmailLabel.Location = new System.Drawing.Point(53, 111);
            this.loginEmailLabel.Name = "loginEmailLabel";
            this.loginEmailLabel.Size = new System.Drawing.Size(63, 30);
            this.loginEmailLabel.TabIndex = 1;
            this.loginEmailLabel.Text = "Email";
            // 
            // emailLoginTextBox
            // 
            this.emailLoginTextBox.Location = new System.Drawing.Point(142, 111);
            this.emailLoginTextBox.Name = "emailLoginTextBox";
            this.emailLoginTextBox.Size = new System.Drawing.Size(211, 35);
            this.emailLoginTextBox.TabIndex = 2;
            // 
            // passwordLoginLabel
            // 
            this.passwordLoginLabel.AutoSize = true;
            this.passwordLoginLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.passwordLoginLabel.Location = new System.Drawing.Point(42, 186);
            this.passwordLoginLabel.Name = "passwordLoginLabel";
            this.passwordLoginLabel.Size = new System.Drawing.Size(99, 30);
            this.passwordLoginLabel.TabIndex = 3;
            this.passwordLoginLabel.Text = "Password";
            // 
            // passwordLoginTextBox
            // 
            this.passwordLoginTextBox.Location = new System.Drawing.Point(142, 186);
            this.passwordLoginTextBox.Name = "passwordLoginTextBox";
            this.passwordLoginTextBox.Size = new System.Drawing.Size(211, 35);
            this.passwordLoginTextBox.TabIndex = 4;
            // 
            // forgotPasswordLinkLabel
            // 
            this.forgotPasswordLinkLabel.AutoSize = true;
            this.forgotPasswordLinkLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPasswordLinkLabel.Location = new System.Drawing.Point(220, 233);
            this.forgotPasswordLinkLabel.Name = "forgotPasswordLinkLabel";
            this.forgotPasswordLinkLabel.Size = new System.Drawing.Size(133, 21);
            this.forgotPasswordLinkLabel.TabIndex = 5;
            this.forgotPasswordLinkLabel.TabStop = true;
            this.forgotPasswordLinkLabel.Text = "Forgot Password?";
            // 
            // loginFormButton
            // 
            this.loginFormButton.Location = new System.Drawing.Point(47, 287);
            this.loginFormButton.Name = "loginFormButton";
            this.loginFormButton.Size = new System.Drawing.Size(94, 46);
            this.loginFormButton.TabIndex = 6;
            this.loginFormButton.Text = "LOGIN";
            this.loginFormButton.UseVisualStyleBackColor = true;
            // 
            // CustomerLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(454, 436);
            this.Controls.Add(this.loginFormButton);
            this.Controls.Add(this.forgotPasswordLinkLabel);
            this.Controls.Add(this.passwordLoginTextBox);
            this.Controls.Add(this.passwordLoginLabel);
            this.Controls.Add(this.emailLoginTextBox);
            this.Controls.Add(this.loginEmailLabel);
            this.Controls.Add(this.loginLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CustomerLoginForm";
            this.Text = "CustomerLoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label loginEmailLabel;
        private System.Windows.Forms.TextBox emailLoginTextBox;
        private System.Windows.Forms.Label passwordLoginLabel;
        private System.Windows.Forms.TextBox passwordLoginTextBox;
        private System.Windows.Forms.LinkLabel forgotPasswordLinkLabel;
        private System.Windows.Forms.Button loginFormButton;
    }
}