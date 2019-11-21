namespace StoreUI
{
    partial class ForgotPasswordForm
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
            this.forgotPasswordQuestionLabel = new System.Windows.Forms.Label();
            this.forgotPasswordEmailLabel = new System.Windows.Forms.Label();
            this.forgotPasswordEmailTextBox = new System.Windows.Forms.TextBox();
            this.submitPasswordRecoveryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // forgotPasswordQuestionLabel
            // 
            this.forgotPasswordQuestionLabel.AutoSize = true;
            this.forgotPasswordQuestionLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPasswordQuestionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.forgotPasswordQuestionLabel.Location = new System.Drawing.Point(2, 25);
            this.forgotPasswordQuestionLabel.Name = "forgotPasswordQuestionLabel";
            this.forgotPasswordQuestionLabel.Size = new System.Drawing.Size(397, 50);
            this.forgotPasswordQuestionLabel.TabIndex = 0;
            this.forgotPasswordQuestionLabel.Text = "Forgot Your Password?";
            // 
            // forgotPasswordEmailLabel
            // 
            this.forgotPasswordEmailLabel.AutoSize = true;
            this.forgotPasswordEmailLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPasswordEmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.forgotPasswordEmailLabel.Location = new System.Drawing.Point(6, 147);
            this.forgotPasswordEmailLabel.Name = "forgotPasswordEmailLabel";
            this.forgotPasswordEmailLabel.Size = new System.Drawing.Size(152, 30);
            this.forgotPasswordEmailLabel.TabIndex = 1;
            this.forgotPasswordEmailLabel.Text = "E-Mail Address";
            // 
            // forgotPasswordEmailTextBox
            // 
            this.forgotPasswordEmailTextBox.Location = new System.Drawing.Point(164, 142);
            this.forgotPasswordEmailTextBox.Name = "forgotPasswordEmailTextBox";
            this.forgotPasswordEmailTextBox.Size = new System.Drawing.Size(204, 35);
            this.forgotPasswordEmailTextBox.TabIndex = 2;
            // 
            // submitPasswordRecoveryButton
            // 
            this.submitPasswordRecoveryButton.Location = new System.Drawing.Point(274, 216);
            this.submitPasswordRecoveryButton.Name = "submitPasswordRecoveryButton";
            this.submitPasswordRecoveryButton.Size = new System.Drawing.Size(94, 40);
            this.submitPasswordRecoveryButton.TabIndex = 3;
            this.submitPasswordRecoveryButton.Text = "SUBMIT";
            this.submitPasswordRecoveryButton.UseVisualStyleBackColor = true;
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(438, 489);
            this.Controls.Add(this.submitPasswordRecoveryButton);
            this.Controls.Add(this.forgotPasswordEmailTextBox);
            this.Controls.Add(this.forgotPasswordEmailLabel);
            this.Controls.Add(this.forgotPasswordQuestionLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "ForgotPasswordForm";
            this.Text = "ForgotPasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label forgotPasswordQuestionLabel;
        private System.Windows.Forms.Label forgotPasswordEmailLabel;
        private System.Windows.Forms.TextBox forgotPasswordEmailTextBox;
        private System.Windows.Forms.Button submitPasswordRecoveryButton;
    }
}