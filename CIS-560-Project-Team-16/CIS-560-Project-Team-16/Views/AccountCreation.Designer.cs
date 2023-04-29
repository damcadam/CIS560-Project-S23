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
            uxACToLogInPromptLabel = new Label();
            uxACStatusStrip = new StatusStrip();
            uxACToolStripLabel = new ToolStripStatusLabel();
            uxACShowPasswordsCheckBox = new CheckBox();
            uxACStatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // uxToLogInButton
            // 
            uxToLogInButton.Location = new Point(487, 305);
            uxToLogInButton.Margin = new Padding(4, 5, 4, 5);
            uxToLogInButton.Name = "uxToLogInButton";
            uxToLogInButton.Size = new Size(107, 38);
            uxToLogInButton.TabIndex = 0;
            uxToLogInButton.Text = "Log In";
            uxToLogInButton.UseVisualStyleBackColor = true;
            uxToLogInButton.Click += uxToLogInButton_Click;
            // 
            // uxSignUpButton
            // 
            uxSignUpButton.Location = new Point(450, 207);
            uxSignUpButton.Margin = new Padding(4, 5, 4, 5);
            uxSignUpButton.Name = "uxSignUpButton";
            uxSignUpButton.Size = new Size(143, 42);
            uxSignUpButton.TabIndex = 1;
            uxSignUpButton.Text = "Create Account";
            uxSignUpButton.UseVisualStyleBackColor = true;
            uxSignUpButton.Click += uxSignUpButton_Click;
            // 
            // uxACUsernameLabel
            // 
            uxACUsernameLabel.AutoSize = true;
            uxACUsernameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            uxACUsernameLabel.Location = new Point(116, 30);
            uxACUsernameLabel.Margin = new Padding(4, 0, 4, 0);
            uxACUsernameLabel.Name = "uxACUsernameLabel";
            uxACUsernameLabel.Size = new Size(151, 40);
            uxACUsernameLabel.TabIndex = 2;
            uxACUsernameLabel.Text = "Username:";
            // 
            // uxACPasswordLabel
            // 
            uxACPasswordLabel.AutoSize = true;
            uxACPasswordLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            uxACPasswordLabel.Location = new Point(124, 87);
            uxACPasswordLabel.Margin = new Padding(4, 0, 4, 0);
            uxACPasswordLabel.Name = "uxACPasswordLabel";
            uxACPasswordLabel.Size = new Size(142, 40);
            uxACPasswordLabel.TabIndex = 3;
            uxACPasswordLabel.Text = "Password:";
            // 
            // uxACPasswordConfirmLabel
            // 
            uxACPasswordConfirmLabel.AutoSize = true;
            uxACPasswordConfirmLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            uxACPasswordConfirmLabel.Location = new Point(20, 145);
            uxACPasswordConfirmLabel.Margin = new Padding(4, 0, 4, 0);
            uxACPasswordConfirmLabel.Name = "uxACPasswordConfirmLabel";
            uxACPasswordConfirmLabel.Size = new Size(252, 40);
            uxACPasswordConfirmLabel.TabIndex = 4;
            uxACPasswordConfirmLabel.Text = "Confirm Password:";
            // 
            // uxACUsernameTextBox
            // 
            uxACUsernameTextBox.Location = new Point(269, 38);
            uxACUsernameTextBox.Margin = new Padding(4, 5, 4, 5);
            uxACUsernameTextBox.Name = "uxACUsernameTextBox";
            uxACUsernameTextBox.Size = new Size(324, 31);
            uxACUsernameTextBox.TabIndex = 5;
            // 
            // uxACPasswordTextBox
            // 
            uxACPasswordTextBox.Location = new Point(269, 95);
            uxACPasswordTextBox.Margin = new Padding(4, 5, 4, 5);
            uxACPasswordTextBox.Name = "uxACPasswordTextBox";
            uxACPasswordTextBox.Size = new Size(324, 31);
            uxACPasswordTextBox.TabIndex = 6;
            // 
            // uxACPasswordConfirmTextBox
            // 
            uxACPasswordConfirmTextBox.Location = new Point(269, 153);
            uxACPasswordConfirmTextBox.Margin = new Padding(4, 5, 4, 5);
            uxACPasswordConfirmTextBox.Name = "uxACPasswordConfirmTextBox";
            uxACPasswordConfirmTextBox.Size = new Size(324, 31);
            uxACPasswordConfirmTextBox.TabIndex = 7;
            uxACPasswordConfirmTextBox.KeyDown += uxACPasswordConfirmTextBox_KeyDown;
            // 
            // uxACToLogInPromptLabel
            // 
            uxACToLogInPromptLabel.AutoSize = true;
            uxACToLogInPromptLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            uxACToLogInPromptLabel.Location = new Point(224, 305);
            uxACToLogInPromptLabel.Margin = new Padding(4, 0, 4, 0);
            uxACToLogInPromptLabel.Name = "uxACToLogInPromptLabel";
            uxACToLogInPromptLabel.Size = new Size(259, 30);
            uxACToLogInPromptLabel.TabIndex = 8;
            uxACToLogInPromptLabel.Text = "Already have an account?";
            // 
            // uxACStatusStrip
            // 
            uxACStatusStrip.ImageScalingSize = new Size(24, 24);
            uxACStatusStrip.Items.AddRange(new ToolStripItem[] { uxACToolStripLabel });
            uxACStatusStrip.Location = new Point(0, 363);
            uxACStatusStrip.Name = "uxACStatusStrip";
            uxACStatusStrip.Padding = new Padding(1, 0, 20, 0);
            uxACStatusStrip.Size = new Size(611, 22);
            uxACStatusStrip.TabIndex = 9;
            uxACStatusStrip.Text = "statusStrip1";
            // 
            // uxACToolStripLabel
            // 
            uxACToolStripLabel.Name = "uxACToolStripLabel";
            uxACToolStripLabel.Size = new Size(0, 15);
            // 
            // uxACShowPasswordsCheckBox
            // 
            uxACShowPasswordsCheckBox.AutoSize = true;
            uxACShowPasswordsCheckBox.Location = new Point(21, 212);
            uxACShowPasswordsCheckBox.Name = "uxACShowPasswordsCheckBox";
            uxACShowPasswordsCheckBox.Size = new Size(170, 29);
            uxACShowPasswordsCheckBox.TabIndex = 10;
            uxACShowPasswordsCheckBox.Text = "Show Passwords";
            uxACShowPasswordsCheckBox.UseVisualStyleBackColor = true;
            uxACShowPasswordsCheckBox.CheckedChanged += uxACShowPasswordsCheckBox_CheckedChanged;
            // 
            // AccountCreation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 385);
            Controls.Add(uxACShowPasswordsCheckBox);
            Controls.Add(uxACStatusStrip);
            Controls.Add(uxACToLogInPromptLabel);
            Controls.Add(uxACPasswordConfirmTextBox);
            Controls.Add(uxACPasswordTextBox);
            Controls.Add(uxACUsernameTextBox);
            Controls.Add(uxACPasswordConfirmLabel);
            Controls.Add(uxACPasswordLabel);
            Controls.Add(uxACUsernameLabel);
            Controls.Add(uxSignUpButton);
            Controls.Add(uxToLogInButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MinimizeBox = false;
            Name = "AccountCreation";
            Text = "Account Creation";
            FormClosed += AccountCreation_FormClosed;
            uxACStatusStrip.ResumeLayout(false);
            uxACStatusStrip.PerformLayout();
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
        private Label uxACToLogInPromptLabel;
        private StatusStrip uxACStatusStrip;
        private ToolStripStatusLabel uxACToolStripLabel;
        private CheckBox uxACShowPasswordsCheckBox;
    }
}