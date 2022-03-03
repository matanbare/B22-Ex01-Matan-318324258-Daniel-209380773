
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
            this.textBoxPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPost.Location = new System.Drawing.Point(28, 135);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(449, 165);
            this.textBoxPost.TabIndex = 0;
            // 
            // buttonPost
            // 
            this.buttonPost.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPost.Location = new System.Drawing.Point(29, 382);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(448, 49);
            this.buttonPost.TabIndex = 1;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = false;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // comboBoxGroupToPost
            // 
            this.comboBoxGroupToPost.FormattingEnabled = true;
            this.comboBoxGroupToPost.Location = new System.Drawing.Point(28, 343);
            this.comboBoxGroupToPost.Name = "comboBoxGroupToPost";
            this.comboBoxGroupToPost.Size = new System.Drawing.Size(170, 21);
            this.comboBoxGroupToPost.TabIndex = 2;
            this.comboBoxGroupToPost.Tag = "";
            // 
            // numericUpDownMinute
            // 
            this.numericUpDownMinute.Location = new System.Drawing.Point(355, 343);
            this.numericUpDownMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownMinute.Name = "numericUpDownMinute";
            this.numericUpDownMinute.Size = new System.Drawing.Size(121, 20);
            this.numericUpDownMinute.TabIndex = 4;
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.Location = new System.Drawing.Point(210, 343);
            this.numericUpDownHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownHours.TabIndex = 5;
            // 
            // labelGroupsNames
            // 
            this.labelGroupsNames.AutoSize = true;
            this.labelGroupsNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGroupsNames.Location = new System.Drawing.Point(24, 320);
            this.labelGroupsNames.Name = "labelGroupsNames";
            this.labelGroupsNames.Size = new System.Drawing.Size(73, 20);
            this.labelGroupsNames.TabIndex = 6;
            this.labelGroupsNames.Text = "Groups:";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHours.Location = new System.Drawing.Point(206, 320);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(62, 20);
            this.labelHours.TabIndex = 7;
            this.labelHours.Text = "Hours:";
            // 
            // labelMinutes
            // 
            this.labelMinutes.AutoSize = true;
            this.labelMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinutes.Location = new System.Drawing.Point(351, 320);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(77, 20);
            this.labelMinutes.TabIndex = 8;
            this.labelMinutes.Text = "Minutes:";
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPost.Location = new System.Drawing.Point(25, 102);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(114, 20);
            this.labelPost.TabIndex = 9;
            this.labelPost.Text = "Text To Post:";
            // 
            // labelPostName
            // 
            this.labelPostName.AutoSize = true;
            this.labelPostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostName.Location = new System.Drawing.Point(25, 32);
            this.labelPostName.Name = "labelPostName";
            this.labelPostName.Size = new System.Drawing.Size(101, 20);
            this.labelPostName.TabIndex = 10;
            this.labelPostName.Text = "Post Name:";
            // 
            // textBoxPostName
            // 
            this.textBoxPostName.Location = new System.Drawing.Point(25, 69);
            this.textBoxPostName.Name = "textBoxPostName";
            this.textBoxPostName.Size = new System.Drawing.Size(173, 20);
            this.textBoxPostName.TabIndex = 11;
            // 
            // listBoxFuture
            // 
            this.listBoxFuture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFuture.ForeColor = System.Drawing.Color.Red;
            this.listBoxFuture.FormattingEnabled = true;
            this.listBoxFuture.ItemHeight = 15;
            this.listBoxFuture.Location = new System.Drawing.Point(513, 135);
            this.listBoxFuture.Name = "listBoxFuture";
            this.listBoxFuture.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxFuture.Size = new System.Drawing.Size(275, 94);
            this.listBoxFuture.TabIndex = 12;
            // 
            // listBoxPostedDone
            // 
            this.listBoxPostedDone.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxPostedDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPostedDone.ForeColor = System.Drawing.Color.Green;
            this.listBoxPostedDone.FormattingEnabled = true;
            this.listBoxPostedDone.ItemHeight = 15;
            this.listBoxPostedDone.Location = new System.Drawing.Point(513, 288);
            this.listBoxPostedDone.Name = "listBoxPostedDone";
            this.listBoxPostedDone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBoxPostedDone.Size = new System.Drawing.Size(275, 94);
            this.listBoxPostedDone.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(509, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Next Posts:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(509, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Posted:";
            // 
            // buttonRefreshPosts
            // 
            this.buttonRefreshPosts.BackColor = System.Drawing.Color.Orange;
            this.buttonRefreshPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefreshPosts.Location = new System.Drawing.Point(513, 390);
            this.buttonRefreshPosts.Name = "buttonRefreshPosts";
            this.buttonRefreshPosts.Size = new System.Drawing.Size(275, 41);
            this.buttonRefreshPosts.TabIndex = 16;
            this.buttonRefreshPosts.Text = "Refresh";
            this.buttonRefreshPosts.UseVisualStyleBackColor = false;
            this.buttonRefreshPosts.Click += new System.EventHandler(this.buttonRefreshPosts_Click);
            // 
            // FormSchedulePosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.BackgroundTimerPosts;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 449);
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
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSchedulePosts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSchedulePosts";
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