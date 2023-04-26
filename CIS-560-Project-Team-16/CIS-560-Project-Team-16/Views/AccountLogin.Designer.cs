namespace CIS_560_Project_Team_16
{
    partial class AccountLogin
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
            uxALSignIn = new Button();
            uxALCreateAccount = new Button();
            uxALUsernameTextBox = new TextBox();
            uxALUsernameLabel = new Label();
            uxALPassword = new Label();
            uxALPasswordTextBox = new TextBox();
            uxALStatusStrip = new StatusStrip();
            uxALToolStripLabel = new ToolStripStatusLabel();
            label1 = new Label();
            uxALStatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // uxALSignIn
            // 
            uxALSignIn.Location = new Point(229, 193);
            uxALSignIn.Margin = new Padding(4, 5, 4, 5);
            uxALSignIn.Name = "uxALSignIn";
            uxALSignIn.Size = new Size(143, 42);
            uxALSignIn.TabIndex = 0;
            uxALSignIn.Text = "Sign In";
            uxALSignIn.UseVisualStyleBackColor = true;
            uxALSignIn.Click += uxSignIn_Click;
            // 
            // uxALCreateAccount
            // 
            uxALCreateAccount.Location = new Point(423, 292);
            uxALCreateAccount.Margin = new Padding(4, 5, 4, 5);
            uxALCreateAccount.Name = "uxALCreateAccount";
            uxALCreateAccount.Size = new Size(171, 42);
            uxALCreateAccount.TabIndex = 1;
            uxALCreateAccount.Text = "Create Account";
            uxALCreateAccount.UseVisualStyleBackColor = true;
            uxALCreateAccount.Click += uxCreateAccount_Click;
            // 
            // uxALUsernameTextBox
            // 
            uxALUsernameTextBox.Location = new Point(164, 32);
            uxALUsernameTextBox.Margin = new Padding(4, 5, 4, 5);
            uxALUsernameTextBox.Name = "uxALUsernameTextBox";
            uxALUsernameTextBox.Size = new Size(400, 31);
            uxALUsernameTextBox.TabIndex = 2;
            // 
            // uxALUsernameLabel
            // 
            uxALUsernameLabel.AutoSize = true;
            uxALUsernameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            uxALUsernameLabel.Location = new Point(8, 23);
            uxALUsernameLabel.Margin = new Padding(4, 0, 4, 0);
            uxALUsernameLabel.Name = "uxALUsernameLabel";
            uxALUsernameLabel.Size = new Size(151, 40);
            uxALUsernameLabel.TabIndex = 3;
            uxALUsernameLabel.Text = "Username:";
            // 
            // uxALPassword
            // 
            uxALPassword.AutoSize = true;
            uxALPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            uxALPassword.Location = new Point(17, 103);
            uxALPassword.Margin = new Padding(4, 0, 4, 0);
            uxALPassword.Name = "uxALPassword";
            uxALPassword.Size = new Size(142, 40);
            uxALPassword.TabIndex = 4;
            uxALPassword.Text = "Password:";
            // 
            // uxALPasswordTextBox
            // 
            uxALPasswordTextBox.Location = new Point(164, 103);
            uxALPasswordTextBox.Margin = new Padding(4, 5, 4, 5);
            uxALPasswordTextBox.Name = "uxALPasswordTextBox";
            uxALPasswordTextBox.Size = new Size(400, 31);
            uxALPasswordTextBox.TabIndex = 5;
            // 
            // uxALStatusStrip
            // 
            uxALStatusStrip.ImageScalingSize = new Size(24, 24);
            uxALStatusStrip.Items.AddRange(new ToolStripItem[] { uxALToolStripLabel });
            uxALStatusStrip.Location = new Point(0, 363);
            uxALStatusStrip.Name = "uxALStatusStrip";
            uxALStatusStrip.Padding = new Padding(1, 0, 20, 0);
            uxALStatusStrip.Size = new Size(611, 22);
            uxALStatusStrip.TabIndex = 6;
            uxALStatusStrip.Text = "statusStrip1";
            // 
            // uxALToolStripLabel
            // 
            uxALToolStripLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uxALToolStripLabel.Name = "uxALToolStripLabel";
            uxALToolStripLabel.Size = new Size(0, 15);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(181, 300);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(237, 30);
            label1.TabIndex = 7;
            label1.Text = "Don't have an account?";
            // 
            // AccountLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 385);
            Controls.Add(label1);
            Controls.Add(uxALStatusStrip);
            Controls.Add(uxALPasswordTextBox);
            Controls.Add(uxALPassword);
            Controls.Add(uxALUsernameLabel);
            Controls.Add(uxALUsernameTextBox);
            Controls.Add(uxALCreateAccount);
            Controls.Add(uxALSignIn);
            Margin = new Padding(4, 5, 4, 5);
            MinimizeBox = false;
            Name = "AccountLogin";
            Text = "AccountLogin";
            FormClosed += AccountLogin_FormClosed;
            uxALStatusStrip.ResumeLayout(false);
            uxALStatusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button uxALSignIn;
        private Button uxALCreateAccount;
        private TextBox uxALUsernameTextBox;
        private Label uxALUsernameLabel;
        private Label uxALPassword;
        private TextBox uxALPasswordTextBox;
        private StatusStrip uxALStatusStrip;
        private ToolStripStatusLabel uxALToolStripLabel;
        private Label label1;
    }
}