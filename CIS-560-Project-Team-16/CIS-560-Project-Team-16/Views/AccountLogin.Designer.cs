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
            this.uxSignIn = new System.Windows.Forms.Button();
            this.uxCreateAccount = new System.Windows.Forms.Button();
            this.uxUsernameTextBox = new System.Windows.Forms.TextBox();
            this.uxUsernameLabel = new System.Windows.Forms.Label();
            this.uxPassword = new System.Windows.Forms.Label();
            this.uxPasswordTextBox = new System.Windows.Forms.TextBox();
            this.uxStatusStrip = new System.Windows.Forms.StatusStrip();
            this.uxToolStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.uxStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxSignIn
            // 
            this.uxSignIn.Location = new System.Drawing.Point(213, 173);
            this.uxSignIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxSignIn.Name = "uxSignIn";
            this.uxSignIn.Size = new System.Drawing.Size(187, 42);
            this.uxSignIn.TabIndex = 0;
            this.uxSignIn.Text = "Sign In";
            this.uxSignIn.UseVisualStyleBackColor = true;
            this.uxSignIn.Click += new System.EventHandler(this.uxSignIn_Click);
            // 
            // uxCreateAccount
            // 
            this.uxCreateAccount.Location = new System.Drawing.Point(17, 173);
            this.uxCreateAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxCreateAccount.Name = "uxCreateAccount";
            this.uxCreateAccount.Size = new System.Drawing.Size(173, 42);
            this.uxCreateAccount.TabIndex = 1;
            this.uxCreateAccount.Text = "Create Account";
            this.uxCreateAccount.UseVisualStyleBackColor = true;
            this.uxCreateAccount.Click += new System.EventHandler(this.uxCreateAccount_Click);
            // 
            // uxUsernameTextBox
            // 
            this.uxUsernameTextBox.Location = new System.Drawing.Point(164, 32);
            this.uxUsernameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxUsernameTextBox.Name = "uxUsernameTextBox";
            this.uxUsernameTextBox.Size = new System.Drawing.Size(220, 31);
            this.uxUsernameTextBox.TabIndex = 2;
            // 
            // uxUsernameLabel
            // 
            this.uxUsernameLabel.AutoSize = true;
            this.uxUsernameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxUsernameLabel.Location = new System.Drawing.Point(17, 23);
            this.uxUsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxUsernameLabel.Name = "uxUsernameLabel";
            this.uxUsernameLabel.Size = new System.Drawing.Size(145, 40);
            this.uxUsernameLabel.TabIndex = 3;
            this.uxUsernameLabel.Text = "Username";
            // 
            // uxPassword
            // 
            this.uxPassword.AutoSize = true;
            this.uxPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxPassword.Location = new System.Drawing.Point(17, 95);
            this.uxPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxPassword.Name = "uxPassword";
            this.uxPassword.Size = new System.Drawing.Size(136, 40);
            this.uxPassword.TabIndex = 4;
            this.uxPassword.Text = "Password";
            // 
            // uxPasswordTextBox
            // 
            this.uxPasswordTextBox.Location = new System.Drawing.Point(164, 104);
            this.uxPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxPasswordTextBox.Name = "uxPasswordTextBox";
            this.uxPasswordTextBox.Size = new System.Drawing.Size(220, 31);
            this.uxPasswordTextBox.TabIndex = 5;
            // 
            // uxStatusStrip
            // 
            this.uxStatusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.uxStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxToolStripLabel});
            this.uxStatusStrip.Location = new System.Drawing.Point(0, 348);
            this.uxStatusStrip.Name = "uxStatusStrip";
            this.uxStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 20, 0);
            this.uxStatusStrip.Size = new System.Drawing.Size(686, 28);
            this.uxStatusStrip.TabIndex = 6;
            this.uxStatusStrip.Text = "statusStrip1";
            // 
            // uxToolStripLabel
            // 
            this.uxToolStripLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxToolStripLabel.Name = "uxToolStripLabel";
            this.uxToolStripLabel.Size = new System.Drawing.Size(0, 21);
            // 
            // AccountLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 376);
            this.Controls.Add(this.uxStatusStrip);
            this.Controls.Add(this.uxPasswordTextBox);
            this.Controls.Add(this.uxPassword);
            this.Controls.Add(this.uxUsernameLabel);
            this.Controls.Add(this.uxUsernameTextBox);
            this.Controls.Add(this.uxCreateAccount);
            this.Controls.Add(this.uxSignIn);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AccountLogin";
            this.Text = "AccountLogin";
            this.uxStatusStrip.ResumeLayout(false);
            this.uxStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button uxSignIn;
        private Button uxCreateAccount;
        private TextBox uxUsernameTextBox;
        private Label uxUsernameLabel;
        private Label uxPassword;
        private TextBox uxPasswordTextBox;
        private StatusStrip uxStatusStrip;
        private ToolStripStatusLabel uxToolStripLabel;
    }
}