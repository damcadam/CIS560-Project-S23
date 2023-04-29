namespace CIS_560_Project_Team_16
{
    partial class MainWindow
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
            uxSignIn = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            textBox1 = new TextBox();
            button10 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // uxSignIn
            // 
            uxSignIn.Location = new Point(870, 77);
            uxSignIn.Name = "uxSignIn";
            uxSignIn.Size = new Size(131, 61);
            uxSignIn.TabIndex = 1;
            uxSignIn.Text = "Watch List";
            uxSignIn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(870, 602);
            button1.Name = "button1";
            button1.Size = new Size(131, 25);
            button1.TabIndex = 2;
            button1.Text = "Sign Out";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(701, 550);
            dataGridView1.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(870, 144);
            button3.Name = "button3";
            button3.Size = new Size(131, 61);
            button3.TabIndex = 5;
            button3.Text = "Favorites";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(870, 211);
            button2.Name = "button2";
            button2.Size = new Size(131, 61);
            button2.TabIndex = 6;
            button2.Text = "Most Viewed";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(870, 278);
            button4.Name = "button4";
            button4.Size = new Size(131, 61);
            button4.TabIndex = 7;
            button4.Text = "Highest Rated";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(719, 345);
            button5.Name = "button5";
            button5.Size = new Size(131, 61);
            button5.TabIndex = 8;
            button5.Text = "Edit";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(719, 278);
            button6.Name = "button6";
            button6.Size = new Size(131, 61);
            button6.TabIndex = 9;
            button6.Text = "Add";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(716, 446);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 23);
            textBox1.TabIndex = 13;
            // 
            // button10
            // 
            button10.Location = new Point(870, 410);
            button10.Name = "button10";
            button10.Size = new Size(131, 59);
            button10.TabIndex = 14;
            button10.Text = "Search";
            button10.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "\tgenres", "Documentary", "Short", "Sport", "Comedy", "Horror", "Drama", "News", "Fantasy", "History", "Romance", "Adventure", "Crime", "Action", "Western", "Biography", "War", "Thriller", "Sci-Fi", "Family", "Animation", "Mystery", "Music", "Musical", "Film-Noir", "Talk-Show", "Game-Show", "Adult", "Reality-TV", "None" });
            comboBox1.Location = new Point(716, 412);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(134, 23);
            comboBox1.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Heavy", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(390, 61);
            label1.TabIndex = 21;
            label1.Text = "Movie Database";
            // 
            // button11
            // 
            button11.Location = new Point(719, 77);
            button11.Name = "button11";
            button11.Size = new Size(131, 61);
            button11.TabIndex = 22;
            button11.Text = "Actors";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(719, 211);
            button12.Name = "button12";
            button12.Size = new Size(131, 61);
            button12.TabIndex = 23;
            button12.Text = "Directors";
            button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(719, 144);
            button13.Name = "button13";
            button13.Size = new Size(131, 61);
            button13.TabIndex = 24;
            button13.Text = "Movies";
            button13.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 639);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button10);
            Controls.Add(textBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(uxSignIn);
            Name = "MainWindow";
            Text = "Movie Database";
            FormClosed += MainWindow_FormClosed;
            Load += MainWindow_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button uxSignIn;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button6;
        private TextBox textBox1;
        private Button button10;
        private ComboBox comboBox1;
        private Label label1;
        private Button button11;
        private Button button12;
        private Button button13;
    }
}