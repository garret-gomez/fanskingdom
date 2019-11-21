namespace StoreUI
{
    partial class ChangePasswordForm
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
            this.changePasswordLabel = new System.Windows.Forms.Label();
            this.yourPasswordLabel = new System.Windows.Forms.Label();
            this.changePassword1Label = new System.Windows.Forms.Label();
            this.changePasswordTextBox = new System.Windows.Forms.TextBox();
            this.changePasswordConfirmLabel = new System.Windows.Forms.Label();
            this.changePasswordConfirmTextBox = new System.Windows.Forms.TextBox();
            this.submitChangePasswordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // changePasswordLabel
            // 
            this.changePasswordLabel.AutoSize = true;
            this.changePasswordLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.changePasswordLabel.Location = new System.Drawing.Point(23, 29);
            this.changePasswordLabel.Name = "changePasswordLabel";
            this.changePasswordLabel.Size = new System.Drawing.Size(312, 50);
            this.changePasswordLabel.TabIndex = 0;
            this.changePasswordLabel.Text = "Change Password";
            // 
            // yourPasswordLabel
            // 
            this.yourPasswordLabel.AutoSize = true;
            this.yourPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.yourPasswordLabel.Location = new System.Drawing.Point(23, 121);
            this.yourPasswordLabel.Name = "yourPasswordLabel";
            this.yourPasswordLabel.Size = new System.Drawing.Size(146, 30);
            this.yourPasswordLabel.TabIndex = 1;
            this.yourPasswordLabel.Text = "Your Password";
            // 
            // changePassword1Label
            // 
            this.changePassword1Label.AutoSize = true;
            this.changePassword1Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePassword1Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.changePassword1Label.Location = new System.Drawing.Point(23, 172);
            this.changePassword1Label.Name = "changePassword1Label";
            this.changePassword1Label.Size = new System.Drawing.Size(76, 21);
            this.changePassword1Label.TabIndex = 2;
            this.changePassword1Label.Text = "Password";
            // 
            // changePasswordTextBox
            // 
            this.changePasswordTextBox.Location = new System.Drawing.Point(105, 158);
            this.changePasswordTextBox.Name = "changePasswordTextBox";
            this.changePasswordTextBox.Size = new System.Drawing.Size(129, 35);
            this.changePasswordTextBox.TabIndex = 3;
            // 
            // changePasswordConfirmLabel
            // 
            this.changePasswordConfirmLabel.AutoSize = true;
            this.changePasswordConfirmLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordConfirmLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.changePasswordConfirmLabel.Location = new System.Drawing.Point(23, 221);
            this.changePasswordConfirmLabel.Name = "changePasswordConfirmLabel";
            this.changePasswordConfirmLabel.Size = new System.Drawing.Size(137, 21);
            this.changePasswordConfirmLabel.TabIndex = 4;
            this.changePasswordConfirmLabel.Text = "Password Confirm";
            // 
            // changePasswordConfirmTextBox
            // 
            this.changePasswordConfirmTextBox.Location = new System.Drawing.Point(176, 207);
            this.changePasswordConfirmTextBox.Name = "changePasswordConfirmTextBox";
            this.changePasswordConfirmTextBox.Size = new System.Drawing.Size(129, 35);
            this.changePasswordConfirmTextBox.TabIndex = 5;
            // 
            // submitChangePasswordButton
            // 
            this.submitChangePasswordButton.Location = new System.Drawing.Point(209, 286);
            this.submitChangePasswordButton.Name = "submitChangePasswordButton";
            this.submitChangePasswordButton.Size = new System.Drawing.Size(96, 43);
            this.submitChangePasswordButton.TabIndex = 6;
            this.submitChangePasswordButton.Text = "SUBMIT";
            this.submitChangePasswordButton.UseVisualStyleBackColor = true;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(531, 633);
            this.Controls.Add(this.submitChangePasswordButton);
            this.Controls.Add(this.changePasswordConfirmTextBox);
            this.Controls.Add(this.changePasswordConfirmLabel);
            this.Controls.Add(this.changePasswordTextBox);
            this.Controls.Add(this.changePassword1Label);
            this.Controls.Add(this.yourPasswordLabel);
            this.Controls.Add(this.changePasswordLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label changePasswordLabel;
        private System.Windows.Forms.Label yourPasswordLabel;
        private System.Windows.Forms.Label changePassword1Label;
        private System.Windows.Forms.TextBox changePasswordTextBox;
        private System.Windows.Forms.Label changePasswordConfirmLabel;
        private System.Windows.Forms.TextBox changePasswordConfirmTextBox;
        private System.Windows.Forms.Button submitChangePasswordButton;
    }
}