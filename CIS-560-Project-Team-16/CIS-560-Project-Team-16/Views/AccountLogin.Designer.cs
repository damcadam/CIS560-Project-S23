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
            this.uxSignIn.Location = new System.Drawing.Point(149, 104);
            this.uxSignIn.Name = "uxSignIn";
            this.uxSignIn.Size = new System.Drawing.Size(131, 25);
            this.uxSignIn.TabIndex = 0;
            this.uxSignIn.Text = "Sign In";
            this.uxSignIn.UseVisualStyleBackColor = true;
            // 
            // uxCreateAccount
            // 
            this.uxCreateAccount.Location = new System.Drawing.Point(12, 104);
            this.uxCreateAccount.Name = "uxCreateAccount";
            this.uxCreateAccount.Size = new System.Drawing.Size(121, 25);
            this.uxCreateAccount.TabIndex = 1;
            this.uxCreateAccount.Text = "Create Account";
            this.uxCreateAccount.UseVisualStyleBackColor = true;
            // 
            // uxUsernameTextBox
            // 
            this.uxUsernameTextBox.Location = new System.Drawing.Point(115, 14);
            this.uxUsernameTextBox.Name = "uxUsernameTextBox";
            this.uxUsernameTextBox.Size = new System.Drawing.Size(155, 23);
            this.uxUsernameTextBox.TabIndex = 2;
            // 
            // uxUsernameLabel
            // 
            this.uxUsernameLabel.AutoSize = true;
            this.uxUsernameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxUsernameLabel.Location = new System.Drawing.Point(12, 9);
            this.uxUsernameLabel.Name = "uxUsernameLabel";
            this.uxUsernameLabel.Size = new System.Drawing.Size(97, 25);
            this.uxUsernameLabel.TabIndex = 3;
            this.uxUsernameLabel.Text = "Username";
            // 
            // uxPassword
            // 
            this.uxPassword.AutoSize = true;
            this.uxPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxPassword.Location = new System.Drawing.Point(12, 57);
            this.uxPassword.Name = "uxPassword";
            this.uxPassword.Size = new System.Drawing.Size(91, 25);
            this.uxPassword.TabIndex = 4;
            this.uxPassword.Text = "Password";
            // 
            // uxPasswordTextBox
            // 
            this.uxPasswordTextBox.Location = new System.Drawing.Point(115, 57);
            this.uxPasswordTextBox.Name = "uxPasswordTextBox";
            this.uxPasswordTextBox.Size = new System.Drawing.Size(155, 23);
            this.uxPasswordTextBox.TabIndex = 5;
            // 
            // uxStatusStrip
            // 
            this.uxStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxToolStripLabel});
            this.uxStatusStrip.Location = new System.Drawing.Point(0, 148);
            this.uxStatusStrip.Name = "uxStatusStrip";
            this.uxStatusStrip.Size = new System.Drawing.Size(293, 22);
            this.uxStatusStrip.TabIndex = 6;
            this.uxStatusStrip.Text = "statusStrip1";
            this.uxStatusStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // uxToolStripLabel
            // 
            this.uxToolStripLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxToolStripLabel.Name = "uxToolStripLabel";
            this.uxToolStripLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // AccountLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 170);
            this.Controls.Add(this.uxStatusStrip);
            this.Controls.Add(this.uxPasswordTextBox);
            this.Controls.Add(this.uxPassword);
            this.Controls.Add(this.uxUsernameLabel);
            this.Controls.Add(this.uxUsernameTextBox);
            this.Controls.Add(this.uxCreateAccount);
            this.Controls.Add(this.uxSignIn);
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