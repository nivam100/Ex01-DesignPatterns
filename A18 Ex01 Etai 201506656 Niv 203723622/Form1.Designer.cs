namespace A18_Ex01_Etai_201506656_Niv_203723622
{
    partial class Form1
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPostText = new System.Windows.Forms.TextBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.buttonInsertImagePost = new System.Windows.Forms.Button();
            this.buttonFetchPosts = new System.Windows.Forms.Button();
            this.postsAndLikes = new System.Windows.Forms.ListBox();
            this.buttonFetchFriends = new System.Windows.Forms.Button();
            this.lsitOfFriends = new System.Windows.Forms.ListBox();
            this.buttonFetchEvents = new System.Windows.Forms.Button();
            this.EventsList = new System.Windows.Forms.ListBox();
            this.buttonFetchLikedEvents = new System.Windows.Forms.Button();
            this.ListOfEvents = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(22, 67);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 7;
            this.labelUsername.Text = "Username";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(94, 12);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(57, 50);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 6;
            this.pictureBoxProfile.TabStop = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(12, 41);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 5;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(12, 12);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPostText
            // 
            this.textBoxPostText.AcceptsReturn = true;
            this.textBoxPostText.AllowDrop = true;
            this.textBoxPostText.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPostText.Location = new System.Drawing.Point(157, 12);
            this.textBoxPostText.Name = "textBoxPostText";
            this.textBoxPostText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPostText.Size = new System.Drawing.Size(268, 23);
            this.textBoxPostText.TabIndex = 8;
            this.textBoxPostText.TextChanged += new System.EventHandler(this.textBoxPostText_TextChanged);
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(431, 12);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(75, 23);
            this.buttonPost.TabIndex = 9;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // buttonInsertImagePost
            // 
            this.buttonInsertImagePost.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertImagePost.Location = new System.Drawing.Point(157, 39);
            this.buttonInsertImagePost.Name = "buttonInsertImagePost";
            this.buttonInsertImagePost.Size = new System.Drawing.Size(42, 23);
            this.buttonInsertImagePost.TabIndex = 10;
            this.buttonInsertImagePost.Text = "IMG";
            this.buttonInsertImagePost.UseVisualStyleBackColor = true;
            this.buttonInsertImagePost.Click += new System.EventHandler(this.buttonInsertImagePost_Click);
            // 
            // buttonFetchPosts
            // 
            this.buttonFetchPosts.Location = new System.Drawing.Point(12, 97);
            this.buttonFetchPosts.Name = "buttonFetchPosts";
            this.buttonFetchPosts.Size = new System.Drawing.Size(139, 23);
            this.buttonFetchPosts.TabIndex = 11;
            this.buttonFetchPosts.Text = "Fetch Posts ";
            this.buttonFetchPosts.UseVisualStyleBackColor = true;
            this.buttonFetchPosts.Click += new System.EventHandler(this.buttonFetchPosts_Click);
            // 
            // postsAndLikes
            // 
            this.postsAndLikes.FormattingEnabled = true;
            this.postsAndLikes.Location = new System.Drawing.Point(12, 141);
            this.postsAndLikes.Name = "postsAndLikes";
            this.postsAndLikes.Size = new System.Drawing.Size(187, 199);
            this.postsAndLikes.TabIndex = 12;
            this.postsAndLikes.SelectedIndexChanged += new System.EventHandler(this.postsAndLikes_SelectedIndexChanged);
            // 
            // buttonFetchFriends
            // 
            this.buttonFetchFriends.Location = new System.Drawing.Point(224, 97);
            this.buttonFetchFriends.Name = "buttonFetchFriends";
            this.buttonFetchFriends.Size = new System.Drawing.Size(98, 23);
            this.buttonFetchFriends.TabIndex = 13;
            this.buttonFetchFriends.Text = "Fetch Friends";
            this.buttonFetchFriends.UseVisualStyleBackColor = true;
            this.buttonFetchFriends.Click += new System.EventHandler(this.buttonFetchFriends_Click);
            // 
            // lsitOfFriends
            // 
            this.lsitOfFriends.FormattingEnabled = true;
            this.lsitOfFriends.Location = new System.Drawing.Point(224, 141);
            this.lsitOfFriends.Name = "lsitOfFriends";
            this.lsitOfFriends.Size = new System.Drawing.Size(120, 199);
            this.lsitOfFriends.TabIndex = 14;
            this.lsitOfFriends.SelectedIndexChanged += new System.EventHandler(this.lsitOfFriends_SelectedIndexChanged);
            // 
            // buttonFetchEvents
            // 
            this.buttonFetchEvents.Location = new System.Drawing.Point(393, 97);
            this.buttonFetchEvents.Name = "buttonFetchEvents";
            this.buttonFetchEvents.Size = new System.Drawing.Size(93, 23);
            this.buttonFetchEvents.TabIndex = 15;
            this.buttonFetchEvents.Text = "Fetch Events";
            this.buttonFetchEvents.UseVisualStyleBackColor = true;
            this.buttonFetchEvents.Click += new System.EventHandler(this.buttonFetchLikedEvents_Click);
            // 
            // EventsList
            // 
            this.EventsList.FormattingEnabled = true;
            this.EventsList.Location = new System.Drawing.Point(393, 141);
            this.EventsList.Name = "EventsList";
            this.EventsList.Size = new System.Drawing.Size(120, 199);
            this.EventsList.TabIndex = 16;
            // 
            // buttonFetchLikedEvents
            // 
            this.buttonFetchLikedEvents.Location = new System.Drawing.Point(567, 97);
            this.buttonFetchLikedEvents.Name = "buttonFetchLikedEvents";
            this.buttonFetchLikedEvents.Size = new System.Drawing.Size(97, 23);
            this.buttonFetchLikedEvents.TabIndex = 17;
            this.buttonFetchLikedEvents.Text = "Fetch Events";
            this.buttonFetchLikedEvents.UseVisualStyleBackColor = true;
            this.buttonFetchLikedEvents.Click += new System.EventHandler(this.buttonFetchLikedEvents_Click);
            // 
            // ListOfEvents
            // 
            this.ListOfEvents.FormattingEnabled = true;
            this.ListOfEvents.Location = new System.Drawing.Point(567, 141);
            this.ListOfEvents.Name = "ListOfEvents";
            this.ListOfEvents.Size = new System.Drawing.Size(120, 199);
            this.ListOfEvents.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 363);
            this.Controls.Add(this.ListOfEvents);
            this.Controls.Add(this.buttonFetchLikedEvents);
            this.Controls.Add(this.EventsList);
            this.Controls.Add(this.buttonFetchEvents);
            this.Controls.Add(this.lsitOfFriends);
            this.Controls.Add(this.buttonFetchFriends);
            this.Controls.Add(this.postsAndLikes);
            this.Controls.Add(this.buttonFetchPosts);
            this.Controls.Add(this.buttonInsertImagePost);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.textBoxPostText);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPostText;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Button buttonInsertImagePost;
        private System.Windows.Forms.Button buttonFetchPosts;
        private System.Windows.Forms.ListBox postsAndLikes;
        private System.Windows.Forms.Button buttonFetchFriends;
        private System.Windows.Forms.ListBox lsitOfFriends;
        private System.Windows.Forms.Button buttonFetchEvents;
        private System.Windows.Forms.ListBox EventsList;
        private System.Windows.Forms.Button buttonFetchLikedEvents;
        private System.Windows.Forms.ListBox ListOfEvents;
    }
}

