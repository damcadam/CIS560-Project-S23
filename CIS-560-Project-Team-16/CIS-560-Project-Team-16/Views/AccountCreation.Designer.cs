namespace CIS_560_Project_Team_16.Views
{
    partial class AccountCreation
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
            uxToLogInButton = new Button();
            uxSignUpButton = new Button();
            uxACUsernameLabel = new Label();
            uxACPasswordLabel = new Label();
            uxACPasswordConfirmLabel = new Label();
            uxACUsernameTextBox = new TextBox();
            uxACPasswordTextBox = new TextBox();
            uxACPasswordConfirmTextBox = new TextBox();
            uxACAccountPromptLabel = new Label();
            uxACStatusStrip = new StatusStrip();
            SuspendLayout();
            // 
            // uxToLogInButton
            // 
            uxToLogInButton.Location = new Point(341, 183);
            uxToLogInButton.Name = "uxToLogInButton";
            uxToLogInButton.Size = new Size(75, 23);
            uxToLogInButton.TabIndex = 0;
            uxToLogInButton.Text = "Log In";
            uxToLogInButton.UseVisualStyleBackColor = true;
            // 
            // uxSignUpButton
            // 
            uxSignUpButton.Location = new Point(164, 134);
            uxSignUpButton.Name = "uxSignUpButton";
            uxSignUpButton.Size = new Size(100, 25);
            uxSignUpButton.TabIndex = 1;
            uxSignUpButton.Text = "Create Account";
            uxSignUpButton.UseVisualStyleBackColor = true;
            // 
            // uxACUsernameLabel
            // 
            uxACUsernameLabel.AutoSize = true;
            uxACUsernameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            uxACUsernameLabel.Location = new Point(81, 18);
            uxACUsernameLabel.Name = "uxACUsernameLabel";
            uxACUsernameLabel.Size = new Size(101, 25);
            uxACUsernameLabel.TabIndex = 2;
            uxACUsernameLabel.Text = "Username:";
            // 
            // uxACPasswordLabel
            // 
            uxACPasswordLabel.AutoSize = true;
            uxACPasswordLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            uxACPasswordLabel.Location = new Point(87, 52);
            uxACPasswordLabel.Name = "uxACPasswordLabel";
            uxACPasswordLabel.Size = new Size(95, 25);
            uxACPasswordLabel.TabIndex = 3;
            uxACPasswordLabel.Text = "Password:";
            // 
            // uxACPasswordConfirmLabel
            // 
            uxACPasswordConfirmLabel.AutoSize = true;
            uxACPasswordConfirmLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            uxACPasswordConfirmLabel.Location = new Point(14, 87);
            uxACPasswordConfirmLabel.Name = "uxACPasswordConfirmLabel";
            uxACPasswordConfirmLabel.Size = new Size(168, 25);
            uxACPasswordConfirmLabel.TabIndex = 4;
            uxACPasswordConfirmLabel.Text = "Confirm Password:";
            // 
            // uxACUsernameTextBox
            // 
            uxACUsernameTextBox.Location = new Point(188, 23);
            uxACUsernameTextBox.Name = "uxACUsernameTextBox";
            uxACUsernameTextBox.Size = new Size(228, 23);
            uxACUsernameTextBox.TabIndex = 5;
            // 
            // uxACPasswordTextBox
            // 
            uxACPasswordTextBox.Location = new Point(188, 57);
            uxACPasswordTextBox.Name = "uxACPasswordTextBox";
            uxACPasswordTextBox.Size = new Size(228, 23);
            uxACPasswordTextBox.TabIndex = 6;
            // 
            // uxACPasswordConfirmTextBox
            // 
            uxACPasswordConfirmTextBox.Location = new Point(188, 92);
            uxACPasswordConfirmTextBox.Name = "uxACPasswordConfirmTextBox";
            uxACPasswordConfirmTextBox.Size = new Size(228, 23);
            uxACPasswordConfirmTextBox.TabIndex = 7;
            // 
            // uxACAccountPromptLabel
            // 
            uxACAccountPromptLabel.AutoSize = true;
            uxACAccountPromptLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            uxACAccountPromptLabel.Location = new Point(157, 183);
            uxACAccountPromptLabel.Name = "uxACAccountPromptLabel";
            uxACAccountPromptLabel.Size = new Size(178, 20);
            uxACAccountPromptLabel.TabIndex = 8;
            uxACAccountPromptLabel.Text = "Already have an account?";
            // 
            // uxACStatusStrip
            // 
            uxACStatusStrip.Location = new Point(0, 209);
            uxACStatusStrip.Name = "uxACStatusStrip";
            uxACStatusStrip.Size = new Size(428, 22);
            uxACStatusStrip.TabIndex = 9;
            uxACStatusStrip.Text = "statusStrip1";
            // 
            // AccountCreation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 231);
            Controls.Add(uxACStatusStrip);
            Controls.Add(uxACAccountPromptLabel);
            Controls.Add(uxACPasswordConfirmTextBox);
            Controls.Add(uxACPasswordTextBox);
            Controls.Add(uxACUsernameTextBox);
            Controls.Add(uxACPasswordConfirmLabel);
            Controls.Add(uxACPasswordLabel);
            Controls.Add(uxACUsernameLabel);
            Controls.Add(uxSignUpButton);
            Controls.Add(uxToLogInButton);
            Name = "AccountCreation";
            Text = "AccountCreation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button uxToLogInButton;
        private Button uxSignUpButton;
        private Label uxACUsernameLabel;
        private Label uxACPasswordLabel;
        private Label uxACPasswordConfirmLabel;
        private TextBox uxACUsernameTextBox;
        private TextBox uxACPasswordTextBox;
        private TextBox uxACPasswordConfirmTextBox;
        private Label uxACAccountPromptLabel;
        private StatusStrip uxACStatusStrip;
    }
}