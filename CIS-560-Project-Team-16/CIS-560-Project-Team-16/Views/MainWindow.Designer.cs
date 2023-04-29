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
            uxWatchListButton = new Button();
            uxMWSignOutButton = new Button();
            dataGridView1 = new DataGridView();
            uxFavoritesButton = new Button();
            uxMostViewedButton = new Button();
            uxHighestRatedButton = new Button();
            uxEditButton = new Button();
            uxAddButton = new Button();
            uxSearchTextBox = new TextBox();
            uxSearchButton = new Button();
            uxGenreComboBox = new ComboBox();
            label1 = new Label();
            uxActorsButton = new Button();
            uxDirectorsButton = new Button();
            uxMoviesButton = new Button();
            uxSignedInAsLabel = new Label();
            uxCurrentUserLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // uxWatchListButton
            // 
            uxWatchListButton.Location = new Point(1243, 128);
            uxWatchListButton.Margin = new Padding(4, 5, 4, 5);
            uxWatchListButton.Name = "uxWatchListButton";
            uxWatchListButton.Size = new Size(187, 102);
            uxWatchListButton.TabIndex = 1;
            uxWatchListButton.Text = "Watch List";
            uxWatchListButton.UseVisualStyleBackColor = true;
            // 
            // uxMWSignOutButton
            // 
            uxMWSignOutButton.Location = new Point(894, 76);
            uxMWSignOutButton.Margin = new Padding(4, 5, 4, 5);
            uxMWSignOutButton.Name = "uxMWSignOutButton";
            uxMWSignOutButton.Size = new Size(124, 42);
            uxMWSignOutButton.TabIndex = 2;
            uxMWSignOutButton.Text = "Sign Out";
            uxMWSignOutButton.UseVisualStyleBackColor = true;
            uxMWSignOutButton.Click += uxMWSignOut_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 128);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1001, 653);
            dataGridView1.TabIndex = 4;
            // 
            // uxFavoritesButton
            // 
            uxFavoritesButton.Location = new Point(1243, 240);
            uxFavoritesButton.Margin = new Padding(4, 5, 4, 5);
            uxFavoritesButton.Name = "uxFavoritesButton";
            uxFavoritesButton.Size = new Size(187, 102);
            uxFavoritesButton.TabIndex = 5;
            uxFavoritesButton.Text = "Favorites";
            uxFavoritesButton.UseVisualStyleBackColor = true;
            // 
            // uxMostViewedButton
            // 
            uxMostViewedButton.Location = new Point(1243, 352);
            uxMostViewedButton.Margin = new Padding(4, 5, 4, 5);
            uxMostViewedButton.Name = "uxMostViewedButton";
            uxMostViewedButton.Size = new Size(187, 102);
            uxMostViewedButton.TabIndex = 6;
            uxMostViewedButton.Text = "Most Viewed";
            uxMostViewedButton.UseVisualStyleBackColor = true;
            // 
            // uxHighestRatedButton
            // 
            uxHighestRatedButton.Location = new Point(1243, 463);
            uxHighestRatedButton.Margin = new Padding(4, 5, 4, 5);
            uxHighestRatedButton.Name = "uxHighestRatedButton";
            uxHighestRatedButton.Size = new Size(187, 102);
            uxHighestRatedButton.TabIndex = 7;
            uxHighestRatedButton.Text = "Highest Rated";
            uxHighestRatedButton.UseVisualStyleBackColor = true;
            // 
            // uxEditButton
            // 
            uxEditButton.Location = new Point(1027, 575);
            uxEditButton.Margin = new Padding(4, 5, 4, 5);
            uxEditButton.Name = "uxEditButton";
            uxEditButton.Size = new Size(187, 102);
            uxEditButton.TabIndex = 8;
            uxEditButton.Text = "Edit";
            uxEditButton.UseVisualStyleBackColor = true;
            // 
            // uxAddButton
            // 
            uxAddButton.Location = new Point(1027, 463);
            uxAddButton.Margin = new Padding(4, 5, 4, 5);
            uxAddButton.Name = "uxAddButton";
            uxAddButton.Size = new Size(187, 102);
            uxAddButton.TabIndex = 9;
            uxAddButton.Text = "Add";
            uxAddButton.UseVisualStyleBackColor = true;
            uxAddButton.Click += uxAddButton_Click;
            // 
            // uxSearchTextBox
            // 
            uxSearchTextBox.Location = new Point(1027, 743);
            uxSearchTextBox.Margin = new Padding(4, 5, 4, 5);
            uxSearchTextBox.Name = "uxSearchTextBox";
            uxSearchTextBox.PlaceholderText = "Enter Title Here";
            uxSearchTextBox.Size = new Size(186, 31);
            uxSearchTextBox.TabIndex = 13;
            // 
            // uxSearchButton
            // 
            uxSearchButton.Location = new Point(1243, 683);
            uxSearchButton.Margin = new Padding(4, 5, 4, 5);
            uxSearchButton.Name = "uxSearchButton";
            uxSearchButton.Size = new Size(187, 98);
            uxSearchButton.TabIndex = 14;
            uxSearchButton.Text = "Search";
            uxSearchButton.UseVisualStyleBackColor = true;
            // 
            // uxGenreComboBox
            // 
            uxGenreComboBox.FormattingEnabled = true;
            uxGenreComboBox.Items.AddRange(new object[] { "Documentary", "Short", "Sport", "Comedy", "Horror", "Drama", "News", "Fantasy", "History", "Romance", "Adventure", "Crime", "Action", "Western", "Biography", "War", "Thriller", "Sci-Fi", "Family", "Animation", "Mystery", "Music", "Musical", "Film-Noir", "Talk-Show", "Game-Show", "Adult", "Reality-TV", "None" });
            uxGenreComboBox.Location = new Point(1027, 700);
            uxGenreComboBox.Margin = new Padding(4, 5, 4, 5);
            uxGenreComboBox.Name = "uxGenreComboBox";
            uxGenreComboBox.Size = new Size(186, 33);
            uxGenreComboBox.TabIndex = 15;
            uxGenreComboBox.Text = "Genres";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Heavy", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(584, 91);
            label1.TabIndex = 21;
            label1.Text = "Movie Database";
            // 
            // uxActorsButton
            // 
            uxActorsButton.Location = new Point(1027, 128);
            uxActorsButton.Margin = new Padding(4, 5, 4, 5);
            uxActorsButton.Name = "uxActorsButton";
            uxActorsButton.Size = new Size(187, 102);
            uxActorsButton.TabIndex = 22;
            uxActorsButton.Text = "Actors";
            uxActorsButton.UseVisualStyleBackColor = true;
            // 
            // uxDirectorsButton
            // 
            uxDirectorsButton.Location = new Point(1027, 352);
            uxDirectorsButton.Margin = new Padding(4, 5, 4, 5);
            uxDirectorsButton.Name = "uxDirectorsButton";
            uxDirectorsButton.Size = new Size(187, 102);
            uxDirectorsButton.TabIndex = 23;
            uxDirectorsButton.Text = "Directors";
            uxDirectorsButton.UseVisualStyleBackColor = true;
            // 
            // uxMoviesButton
            // 
            uxMoviesButton.Location = new Point(1027, 240);
            uxMoviesButton.Margin = new Padding(4, 5, 4, 5);
            uxMoviesButton.Name = "uxMoviesButton";
            uxMoviesButton.Size = new Size(187, 102);
            uxMoviesButton.TabIndex = 24;
            uxMoviesButton.Text = "Movies";
            uxMoviesButton.UseVisualStyleBackColor = true;
            // 
            // uxSignedInAsLabel
            // 
            uxSignedInAsLabel.AutoSize = true;
            uxSignedInAsLabel.Location = new Point(608, 85);
            uxSignedInAsLabel.Name = "uxSignedInAsLabel";
            uxSignedInAsLabel.Size = new Size(116, 25);
            uxSignedInAsLabel.TabIndex = 25;
            uxSignedInAsLabel.Text = "Signed In As:";
            // 
            // uxCurrentUserLabel
            // 
            uxCurrentUserLabel.AutoSize = true;
            uxCurrentUserLabel.Location = new Point(730, 85);
            uxCurrentUserLabel.Name = "uxCurrentUserLabel";
            uxCurrentUserLabel.Size = new Size(123, 25);
            uxCurrentUserLabel.TabIndex = 26;
            uxCurrentUserLabel.Text = "usernamehere";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1447, 796);
            Controls.Add(uxCurrentUserLabel);
            Controls.Add(uxSignedInAsLabel);
            Controls.Add(uxMoviesButton);
            Controls.Add(uxDirectorsButton);
            Controls.Add(uxActorsButton);
            Controls.Add(label1);
            Controls.Add(uxGenreComboBox);
            Controls.Add(uxSearchButton);
            Controls.Add(uxSearchTextBox);
            Controls.Add(uxAddButton);
            Controls.Add(uxEditButton);
            Controls.Add(uxHighestRatedButton);
            Controls.Add(uxMostViewedButton);
            Controls.Add(uxFavoritesButton);
            Controls.Add(dataGridView1);
            Controls.Add(uxMWSignOutButton);
            Controls.Add(uxWatchListButton);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainWindow";
            Text = "Movie Database";
            FormClosed += MainWindow_FormClosed;
            Load += MainWindow_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button uxWatchListButton;
        private Button uxMWSignOutButton;
        private DataGridView dataGridView1;
        private Button uxFavoritesButton;
        private Button uxMostViewedButton;
        private Button uxHighestRatedButton;
        private Button uxEditButton;
        private Button uxAddButton;
        private TextBox uxSearchTextBox;
        private Button uxSearchButton;
        private ComboBox uxGenreComboBox;
        private Label label1;
        private Button uxActorsButton;
        private Button uxDirectorsButton;
        private Button uxMoviesButton;
        private Label uxSignedInAsLabel;
        private Label uxCurrentUserLabel;
    }
}