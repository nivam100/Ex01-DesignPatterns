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
            this.components = new System.ComponentModel.Container();
            this.labelUsername = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPostText = new System.Windows.Forms.TextBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.buttonFetchPosts = new System.Windows.Forms.Button();
            this.postsAndLikes = new System.Windows.Forms.ListBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonFetchFriends = new System.Windows.Forms.Button();
            this.listOfFriends = new System.Windows.Forms.ListBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonFetchLikedEvents = new System.Windows.Forms.Button();
            this.ListOfEvents = new System.Windows.Forms.ListBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonFetchPages = new System.Windows.Forms.Button();
            this.pages = new System.Windows.Forms.ListBox();
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCreateRandomPost = new System.Windows.Forms.Button();
            this.buttonGetBirthdays = new System.Windows.Forms.Button();
            this.friendsBirthdays = new System.Windows.Forms.ListBox();
            this.classAppId = new System.Windows.Forms.CheckBox();
            this.ourAppId = new System.Windows.Forms.CheckBox();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(166, 64);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 7;
            this.labelUsername.Text = "Username";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(250, 14);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(57, 50);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 6;
            this.pictureBoxProfile.TabStop = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(169, 38);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonLogout.Size = new System.Drawing.Size(75, 23);
            this.buttonLogout.TabIndex = 5;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.ButtonLogout_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(169, 12);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // textBoxPostText
            // 
            this.textBoxPostText.AcceptsReturn = true;
            this.textBoxPostText.AllowDrop = true;
            this.textBoxPostText.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPostText.Location = new System.Drawing.Point(313, 14);
            this.textBoxPostText.Name = "textBoxPostText";
            this.textBoxPostText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPostText.Size = new System.Drawing.Size(268, 23);
            this.textBoxPostText.TabIndex = 8;
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(587, 13);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(75, 23);
            this.buttonPost.TabIndex = 9;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.ButtonPost_Click);
            // 
            // buttonFetchPosts
            // 
            this.buttonFetchPosts.Location = new System.Drawing.Point(12, 97);
            this.buttonFetchPosts.Name = "buttonFetchPosts";
            this.buttonFetchPosts.Size = new System.Drawing.Size(139, 23);
            this.buttonFetchPosts.TabIndex = 11;
            this.buttonFetchPosts.Text = "Fetch Posts ";
            this.buttonFetchPosts.UseVisualStyleBackColor = true;
            this.buttonFetchPosts.Click += new System.EventHandler(this.ButtonFetchPosts_Click);
            // 
            // postsAndLikes
            // 
            this.postsAndLikes.DataSource = this.postBindingSource;
            this.postsAndLikes.DisplayMember = "Message";
            this.postsAndLikes.FormattingEnabled = true;
            this.postsAndLikes.Location = new System.Drawing.Point(12, 141);
            this.postsAndLikes.Name = "postsAndLikes";
            this.postsAndLikes.Size = new System.Drawing.Size(187, 199);
            this.postsAndLikes.TabIndex = 12;
            this.postsAndLikes.DoubleClick += new System.EventHandler(this.postsAndLikes_DoubleClick);
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // buttonFetchFriends
            // 
            this.buttonFetchFriends.Location = new System.Drawing.Point(224, 97);
            this.buttonFetchFriends.Name = "buttonFetchFriends";
            this.buttonFetchFriends.Size = new System.Drawing.Size(98, 23);
            this.buttonFetchFriends.TabIndex = 13;
            this.buttonFetchFriends.Text = "Fetch Friends";
            this.buttonFetchFriends.UseVisualStyleBackColor = true;
            this.buttonFetchFriends.Click += new System.EventHandler(this.ButtonFetchFriends_Click);
            // 
            // listOfFriends
            // 
            this.listOfFriends.DataSource = this.userBindingSource;
            this.listOfFriends.DisplayMember = "Name";
            this.listOfFriends.FormattingEnabled = true;
            this.listOfFriends.Location = new System.Drawing.Point(224, 141);
            this.listOfFriends.Name = "listOfFriends";
            this.listOfFriends.Size = new System.Drawing.Size(120, 199);
            this.listOfFriends.TabIndex = 14;
            this.listOfFriends.SelectedIndexChanged += new System.EventHandler(this.ListOfFriends_SelectedIndexChanged);
            this.listOfFriends.DoubleClick += new System.EventHandler(this.listOfFriends_DoubleClick);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // buttonFetchLikedEvents
            // 
            this.buttonFetchLikedEvents.Location = new System.Drawing.Point(386, 97);
            this.buttonFetchLikedEvents.Name = "buttonFetchLikedEvents";
            this.buttonFetchLikedEvents.Size = new System.Drawing.Size(97, 23);
            this.buttonFetchLikedEvents.TabIndex = 17;
            this.buttonFetchLikedEvents.Text = "Fetch Events";
            this.buttonFetchLikedEvents.UseVisualStyleBackColor = true;
            this.buttonFetchLikedEvents.Click += new System.EventHandler(this.ButtonFetchLikedEvents_Click);
            // 
            // ListOfEvents
            // 
            this.ListOfEvents.DataSource = this.eventBindingSource;
            this.ListOfEvents.DisplayMember = "Name";
            this.ListOfEvents.FormattingEnabled = true;
            this.ListOfEvents.Location = new System.Drawing.Point(386, 141);
            this.ListOfEvents.Name = "ListOfEvents";
            this.ListOfEvents.Size = new System.Drawing.Size(120, 199);
            this.ListOfEvents.TabIndex = 18;
            this.ListOfEvents.DoubleClick += new System.EventHandler(this.ListOfEvents_DoubleClick);
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // buttonFetchPages
            // 
            this.buttonFetchPages.Location = new System.Drawing.Point(542, 97);
            this.buttonFetchPages.Name = "buttonFetchPages";
            this.buttonFetchPages.Size = new System.Drawing.Size(88, 23);
            this.buttonFetchPages.TabIndex = 19;
            this.buttonFetchPages.Text = "Fetch Pages";
            this.buttonFetchPages.UseVisualStyleBackColor = true;
            this.buttonFetchPages.Click += new System.EventHandler(this.ButtonFetchPages_Click);
            // 
            // pages
            // 
            this.pages.DataSource = this.pageBindingSource;
            this.pages.DisplayMember = "Name";
            this.pages.FormattingEnabled = true;
            this.pages.Location = new System.Drawing.Point(542, 141);
            this.pages.Name = "pages";
            this.pages.Size = new System.Drawing.Size(120, 199);
            this.pages.TabIndex = 20;
            this.pages.DoubleClick += new System.EventHandler(this.pages_DoubleClick);
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // buttonCreateRandomPost
            // 
            this.buttonCreateRandomPost.Location = new System.Drawing.Point(313, 40);
            this.buttonCreateRandomPost.Name = "buttonCreateRandomPost";
            this.buttonCreateRandomPost.Size = new System.Drawing.Size(268, 23);
            this.buttonCreateRandomPost.TabIndex = 21;
            this.buttonCreateRandomPost.Text = "Create Random \"Pigoa\" Facebook";
            this.buttonCreateRandomPost.UseVisualStyleBackColor = true;
            this.buttonCreateRandomPost.Click += new System.EventHandler(this.ButtonCreateRandomPost_Click);
            // 
            // buttonGetBirthdays
            // 
            this.buttonGetBirthdays.Location = new System.Drawing.Point(692, 97);
            this.buttonGetBirthdays.Name = "buttonGetBirthdays";
            this.buttonGetBirthdays.Size = new System.Drawing.Size(163, 23);
            this.buttonGetBirthdays.TabIndex = 22;
            this.buttonGetBirthdays.Text = "Remind me friends birthdays!";
            this.buttonGetBirthdays.UseVisualStyleBackColor = true;
            this.buttonGetBirthdays.Click += new System.EventHandler(this.ButtonGetBirthdays_Click);
            // 
            // friendsBirthdays
            // 
            this.friendsBirthdays.FormattingEnabled = true;
            this.friendsBirthdays.Location = new System.Drawing.Point(692, 141);
            this.friendsBirthdays.Name = "friendsBirthdays";
            this.friendsBirthdays.Size = new System.Drawing.Size(215, 199);
            this.friendsBirthdays.TabIndex = 23;
            // 
            // classAppId
            // 
            this.classAppId.AutoSize = true;
            this.classAppId.Location = new System.Drawing.Point(12, 38);
            this.classAppId.Name = "classAppId";
            this.classAppId.Size = new System.Drawing.Size(87, 17);
            this.classAppId.TabIndex = 24;
            this.classAppId.Text = "Class App ID";
            this.classAppId.UseVisualStyleBackColor = true;
            this.classAppId.CheckedChanged += new System.EventHandler(this.ClassAppId_CheckedChanged);
            // 
            // ourAppId
            // 
            this.ourAppId.AutoSize = true;
            this.ourAppId.Location = new System.Drawing.Point(12, 60);
            this.ourAppId.Name = "ourAppId";
            this.ourAppId.Size = new System.Drawing.Size(79, 17);
            this.ourAppId.TabIndex = 25;
            this.ourAppId.Text = "Our App ID";
            this.ourAppId.UseVisualStyleBackColor = true;
            this.ourAppId.CheckedChanged += new System.EventHandler(this.OurAppId_CheckedChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(9, 13);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(117, 13);
            this.label.TabIndex = 26;
            this.label.Text = "Choose App ID To Use";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 363);
            this.Controls.Add(this.label);
            this.Controls.Add(this.ourAppId);
            this.Controls.Add(this.classAppId);
            this.Controls.Add(this.friendsBirthdays);
            this.Controls.Add(this.buttonGetBirthdays);
            this.Controls.Add(this.buttonCreateRandomPost);
            this.Controls.Add(this.pages);
            this.Controls.Add(this.buttonFetchPages);
            this.Controls.Add(this.ListOfEvents);
            this.Controls.Add(this.buttonFetchLikedEvents);
            this.Controls.Add(this.listOfFriends);
            this.Controls.Add(this.buttonFetchFriends);
            this.Controls.Add(this.postsAndLikes);
            this.Controls.Add(this.buttonFetchPosts);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.textBoxPostText);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
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
        private System.Windows.Forms.Button buttonFetchPosts;
        private System.Windows.Forms.ListBox postsAndLikes;
        private System.Windows.Forms.Button buttonFetchFriends;
        private System.Windows.Forms.ListBox listOfFriends;
        private System.Windows.Forms.Button buttonFetchLikedEvents;
        private System.Windows.Forms.ListBox ListOfEvents;
        private System.Windows.Forms.Button buttonFetchPages;
        private System.Windows.Forms.ListBox pages;
        private System.Windows.Forms.Button buttonCreateRandomPost;
        private System.Windows.Forms.Button buttonGetBirthdays;
        private System.Windows.Forms.ListBox friendsBirthdays;
        private System.Windows.Forms.CheckBox classAppId;
        private System.Windows.Forms.CheckBox ourAppId;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.BindingSource pageBindingSource;
    }
}

