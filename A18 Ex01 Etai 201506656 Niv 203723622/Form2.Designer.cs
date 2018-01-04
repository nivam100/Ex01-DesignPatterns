namespace A18_Ex01_Etai_201506656_Niv_203723622
{
    partial class Form2
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
        protected void InitializeComponent()
        {
            this.more = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // more
            // 
            this.more.FormattingEnabled = true;
            this.more.HorizontalScrollbar = true;
            this.more.Location = new System.Drawing.Point(27, 10);
            this.more.Name = "more";
            this.more.Size = new System.Drawing.Size(195, 238);
            this.more.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 261);
            this.Controls.Add(this.more);
            this.Name = "Form2";
            this.Text = "More Info";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox more;
    }
}