
namespace BasicFacebookFeatures
{
    partial class FormSchedulePosts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSchedulePosts));
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.comboBoxGroupToPost = new System.Windows.Forms.ComboBox();
            this.numericUpDownMinute = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.labelGroupsNames = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.labelPost = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelPostName = new System.Windows.Forms.Label();
            this.textBoxPostName = new System.Windows.Forms.TextBox();
            this.listBoxFuture = new System.Windows.Forms.ListBox();
            this.listBoxPostedDone = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRefreshPosts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPost
            // 
            this.textBoxPost.BackColor = System.Drawing.Color.LightGray;
            this.textBoxPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPost.Location = new System.Drawing.Point(47, 208);
            this.textBoxPost.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(746, 252);
            this.textBoxPost.TabIndex = 0;
            // 
            // buttonPost
            // 
            this.buttonPost.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPost.Location = new System.Drawing.Point(48, 588);
            this.buttonPost.Margin = new System.Windows.Forms.Padding(5);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(747, 75);
            this.buttonPost.TabIndex = 1;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = false;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // comboBoxGroupToPost
            // 
            this.comboBoxGroupToPost.BackColor = System.Drawing.Color.LightGray;
            this.comboBoxGroupToPost.FormattingEnabled = true;
            this.comboBoxGroupToPost.Location = new System.Drawing.Point(47, 528);
            this.comboBoxGroupToPost.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxGroupToPost.Name = "comboBoxGroupToPost";
            this.comboBoxGroupToPost.Size = new System.Drawing.Size(281, 28);
            this.comboBoxGroupToPost.TabIndex = 2;
            this.comboBoxGroupToPost.Tag = "";
            // 
            // numericUpDownMinute
            // 
            this.numericUpDownMinute.BackColor = System.Drawing.Color.LightGray;
            this.numericUpDownMinute.Location = new System.Drawing.Point(592, 528);
            this.numericUpDownMinute.Margin = new System.Windows.Forms.Padding(5);
            this.numericUpDownMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownMinute.Name = "numericUpDownMinute";
            this.numericUpDownMinute.Size = new System.Drawing.Size(202, 26);
            this.numericUpDownMinute.TabIndex = 4;
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.BackColor = System.Drawing.Color.LightGray;
            this.numericUpDownHours.Location = new System.Drawing.Point(350, 528);
            this.numericUpDownHours.Margin = new System.Windows.Forms.Padding(5);
            this.numericUpDownHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.Size = new System.Drawing.Size(200, 26);
            this.numericUpDownHours.TabIndex = 5;
            // 
            // labelGroupsNames
            // 
            this.labelGroupsNames.AutoSize = true;
            this.labelGroupsNames.BackColor = System.Drawing.Color.Transparent;
            this.labelGroupsNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroupsNames.ForeColor = System.Drawing.Color.White;
            this.labelGroupsNames.Location = new System.Drawing.Point(40, 492);
            this.labelGroupsNames.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelGroupsNames.Name = "labelGroupsNames";
            this.labelGroupsNames.Size = new System.Drawing.Size(73, 20);
            this.labelGroupsNames.TabIndex = 6;
            this.labelGroupsNames.Text = "Groups:";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.BackColor = System.Drawing.Color.Transparent;
            this.labelHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHours.ForeColor = System.Drawing.Color.White;
            this.labelHours.Location = new System.Drawing.Point(343, 492);
            this.labelHours.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(62, 20);
            this.labelHours.TabIndex = 7;
            this.labelHours.Text = "Hours:";
            // 
            // labelMinutes
            // 
            this.labelMinutes.AutoSize = true;
            this.labelMinutes.BackColor = System.Drawing.Color.Transparent;
            this.labelMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinutes.ForeColor = System.Drawing.Color.White;
            this.labelMinutes.Location = new System.Drawing.Point(585, 492);
            this.labelMinutes.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(77, 20);
            this.labelMinutes.TabIndex = 8;
            this.labelMinutes.Text = "Minutes:";
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.BackColor = System.Drawing.Color.Transparent;
            this.labelPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPost.ForeColor = System.Drawing.Color.White;
            this.labelPost.Location = new System.Drawing.Point(43, 172);
            this.labelPost.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(114, 20);
            this.labelPost.TabIndex = 9;
            this.labelPost.Text = "Text To Post:";
            // 
            // labelPostName
            // 
            this.labelPostName.AutoSize = true;
            this.labelPostName.BackColor = System.Drawing.Color.Transparent;
            this.labelPostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostName.ForeColor = System.Drawing.Color.White;
            this.labelPostName.Location = new System.Drawing.Point(40, 97);
            this.labelPostName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPostName.Name = "labelPostName";
            this.labelPostName.Size = new System.Drawing.Size(101, 20);
            this.labelPostName.TabIndex = 10;
            this.labelPostName.Text = "Post Name:";
            // 
            // textBoxPostName
            // 
            this.textBoxPostName.BackColor = System.Drawing.Color.LightGray;
            this.textBoxPostName.Location = new System.Drawing.Point(42, 132);
            this.textBoxPostName.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxPostName.Name = "textBoxPostName";
            this.textBoxPostName.Size = new System.Drawing.Size(286, 26);
            this.textBoxPostName.TabIndex = 11;
            // 
            // listBoxFuture
            // 
            this.listBoxFuture.BackColor = System.Drawing.Color.LightGray;
            this.listBoxFuture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFuture.ForeColor = System.Drawing.Color.Red;
            this.listBoxFuture.FormattingEnabled = true;
            this.listBoxFuture.ItemHeight = 16;
            this.listBoxFuture.Location = new System.Drawing.Point(855, 208);
            this.listBoxFuture.Margin = new System.Windows.Forms.Padding(5);
            this.listBoxFuture.Name = "listBoxFuture";
            this.listBoxFuture.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxFuture.Size = new System.Drawing.Size(456, 132);
            this.listBoxFuture.TabIndex = 12;
            // 
            // listBoxPostedDone
            // 
            this.listBoxPostedDone.BackColor = System.Drawing.Color.LightGray;
            this.listBoxPostedDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPostedDone.ForeColor = System.Drawing.Color.Green;
            this.listBoxPostedDone.FormattingEnabled = true;
            this.listBoxPostedDone.ItemHeight = 16;
            this.listBoxPostedDone.Location = new System.Drawing.Point(855, 443);
            this.listBoxPostedDone.Margin = new System.Windows.Forms.Padding(5);
            this.listBoxPostedDone.Name = "listBoxPostedDone";
            this.listBoxPostedDone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBoxPostedDone.Size = new System.Drawing.Size(456, 132);
            this.listBoxPostedDone.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(848, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Next Posts:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(848, 392);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Posted:";
            // 
            // buttonRefreshPosts
            // 
            this.buttonRefreshPosts.BackColor = System.Drawing.Color.Orange;
            this.buttonRefreshPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefreshPosts.Location = new System.Drawing.Point(855, 600);
            this.buttonRefreshPosts.Margin = new System.Windows.Forms.Padding(5);
            this.buttonRefreshPosts.Name = "buttonRefreshPosts";
            this.buttonRefreshPosts.Size = new System.Drawing.Size(458, 63);
            this.buttonRefreshPosts.TabIndex = 16;
            this.buttonRefreshPosts.Text = "Refresh";
            this.buttonRefreshPosts.UseVisualStyleBackColor = false;
            this.buttonRefreshPosts.Click += new System.EventHandler(this.buttonRefreshPosts_Click);
            // 
            // FormSchedulePosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.schedularPostsBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1333, 691);
            this.Controls.Add(this.buttonRefreshPosts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPostedDone);
            this.Controls.Add(this.listBoxFuture);
            this.Controls.Add(this.textBoxPostName);
            this.Controls.Add(this.labelPostName);
            this.Controls.Add(this.labelPost);
            this.Controls.Add(this.labelMinutes);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.labelGroupsNames);
            this.Controls.Add(this.numericUpDownHours);
            this.Controls.Add(this.numericUpDownMinute);
            this.Controls.Add(this.comboBoxGroupToPost);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.textBoxPost);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FormSchedulePosts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule Posts";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.ComboBox comboBoxGroupToPost;
        private System.Windows.Forms.NumericUpDown numericUpDownMinute;
        private System.Windows.Forms.NumericUpDown numericUpDownHours;
        private System.Windows.Forms.Label labelGroupsNames;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelPostName;
        private System.Windows.Forms.TextBox textBoxPostName;
        private System.Windows.Forms.ListBox listBoxFuture;
        private System.Windows.Forms.ListBox listBoxPostedDone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRefreshPosts;
    }
}