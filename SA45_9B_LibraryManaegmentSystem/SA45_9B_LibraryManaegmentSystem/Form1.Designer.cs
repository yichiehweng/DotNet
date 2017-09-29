namespace SA45_9B_LibraryManaegmentSystem
{
    partial class MainForm
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
            this.MemberRecord_button = new System.Windows.Forms.Button();
            this.bookMatian_button = new System.Windows.Forms.Button();
            this.lengingBook_button = new System.Windows.Forms.Button();
            this.addNewMember_button = new System.Windows.Forms.Button();
            this.addNewBook_button = new System.Windows.Forms.Button();
            this.logout_button = new System.Windows.Forms.Button();
            this.info_groupBox = new System.Windows.Forms.GroupBox();
            this.changePassword_button = new System.Windows.Forms.Button();
            this.changeInfo_button = new System.Windows.Forms.Button();
            this.userName_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login_statusStrip = new System.Windows.Forms.StatusStrip();
            this.login_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Space_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.time_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.query_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.info_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.login_statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MemberRecord_button
            // 
            this.MemberRecord_button.Location = new System.Drawing.Point(336, 103);
            this.MemberRecord_button.Margin = new System.Windows.Forms.Padding(4);
            this.MemberRecord_button.Name = "MemberRecord_button";
            this.MemberRecord_button.Size = new System.Drawing.Size(406, 51);
            this.MemberRecord_button.TabIndex = 0;
            this.MemberRecord_button.Text = "Member Maintenance";
            this.MemberRecord_button.UseVisualStyleBackColor = true;
            this.MemberRecord_button.Click += new System.EventHandler(this.MemberRecord_button_Click);
            this.MemberRecord_button.MouseLeave += new System.EventHandler(this.MemberRecord_button_MouseLeave);
            this.MemberRecord_button.MouseHover += new System.EventHandler(this.MemberRecord_button_MouseHover);
            // 
            // bookMatian_button
            // 
            this.bookMatian_button.Location = new System.Drawing.Point(336, 224);
            this.bookMatian_button.Margin = new System.Windows.Forms.Padding(4);
            this.bookMatian_button.Name = "bookMatian_button";
            this.bookMatian_button.Size = new System.Drawing.Size(406, 57);
            this.bookMatian_button.TabIndex = 1;
            this.bookMatian_button.Text = "Book Maintenance";
            this.bookMatian_button.UseVisualStyleBackColor = true;
            this.bookMatian_button.Click += new System.EventHandler(this.button2_Click);
            this.bookMatian_button.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.bookMatian_button.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // lengingBook_button
            // 
            this.lengingBook_button.Location = new System.Drawing.Point(336, 352);
            this.lengingBook_button.Margin = new System.Windows.Forms.Padding(4);
            this.lengingBook_button.Name = "lengingBook_button";
            this.lengingBook_button.Size = new System.Drawing.Size(406, 53);
            this.lengingBook_button.TabIndex = 2;
            this.lengingBook_button.Text = "Lending of Books";
            this.lengingBook_button.UseVisualStyleBackColor = true;
            this.lengingBook_button.Click += new System.EventHandler(this.lengingBook_button_Click);
            this.lengingBook_button.MouseLeave += new System.EventHandler(this.lendingbook_button_MouseLeave);
            this.lengingBook_button.MouseHover += new System.EventHandler(this.lendingbook_button_MouseHover);
            // 
            // addNewMember_button
            // 
            this.addNewMember_button.Location = new System.Drawing.Point(336, 44);
            this.addNewMember_button.Margin = new System.Windows.Forms.Padding(4);
            this.addNewMember_button.Name = "addNewMember_button";
            this.addNewMember_button.Size = new System.Drawing.Size(406, 51);
            this.addNewMember_button.TabIndex = 4;
            this.addNewMember_button.Text = "Add New Member";
            this.addNewMember_button.UseVisualStyleBackColor = true;
            this.addNewMember_button.Click += new System.EventHandler(this.addNewMember_button_Click);
            this.addNewMember_button.MouseLeave += new System.EventHandler(this.AddNewBook_button_MouseLeave);
            this.addNewMember_button.MouseHover += new System.EventHandler(this.AddNewBook_button_MouseHover);
            // 
            // addNewBook_button
            // 
            this.addNewBook_button.Location = new System.Drawing.Point(336, 162);
            this.addNewBook_button.Margin = new System.Windows.Forms.Padding(4);
            this.addNewBook_button.Name = "addNewBook_button";
            this.addNewBook_button.Size = new System.Drawing.Size(406, 54);
            this.addNewBook_button.TabIndex = 5;
            this.addNewBook_button.Text = "Add New Books";
            this.addNewBook_button.UseVisualStyleBackColor = true;
            this.addNewBook_button.Click += new System.EventHandler(this.addNewBook_button_Click);
            this.addNewBook_button.MouseLeave += new System.EventHandler(this.AddNewBook_button_MouseLeave);
            this.addNewBook_button.MouseHover += new System.EventHandler(this.AddNewBook_button_MouseHover);
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(9, 368);
            this.logout_button.Margin = new System.Windows.Forms.Padding(4);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(184, 32);
            this.logout_button.TabIndex = 6;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            this.logout_button.MouseLeave += new System.EventHandler(this.logout_button_MouseLeave);
            this.logout_button.MouseHover += new System.EventHandler(this.logout_button_MouseHover);
            // 
            // info_groupBox
            // 
            this.info_groupBox.Controls.Add(this.changePassword_button);
            this.info_groupBox.Controls.Add(this.changeInfo_button);
            this.info_groupBox.Controls.Add(this.userName_label);
            this.info_groupBox.Controls.Add(this.pictureBox1);
            this.info_groupBox.Controls.Add(this.logout_button);
            this.info_groupBox.Location = new System.Drawing.Point(18, 17);
            this.info_groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.info_groupBox.Name = "info_groupBox";
            this.info_groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.info_groupBox.Size = new System.Drawing.Size(216, 429);
            this.info_groupBox.TabIndex = 7;
            this.info_groupBox.TabStop = false;
            this.info_groupBox.Text = "Welcome";
            // 
            // changePassword_button
            // 
            this.changePassword_button.Location = new System.Drawing.Point(9, 314);
            this.changePassword_button.Margin = new System.Windows.Forms.Padding(4);
            this.changePassword_button.Name = "changePassword_button";
            this.changePassword_button.Size = new System.Drawing.Size(183, 32);
            this.changePassword_button.TabIndex = 10;
            this.changePassword_button.Text = "Change Password";
            this.changePassword_button.UseVisualStyleBackColor = true;
            this.changePassword_button.Click += new System.EventHandler(this.changePassword_button_Click);
            this.changePassword_button.MouseLeave += new System.EventHandler(this.changPassWord_button_MouseLeave);
            this.changePassword_button.MouseHover += new System.EventHandler(this.changPassWord_button_MouseHover);
            // 
            // changeInfo_button
            // 
            this.changeInfo_button.Location = new System.Drawing.Point(9, 255);
            this.changeInfo_button.Margin = new System.Windows.Forms.Padding(4);
            this.changeInfo_button.Name = "changeInfo_button";
            this.changeInfo_button.Size = new System.Drawing.Size(184, 32);
            this.changeInfo_button.TabIndex = 9;
            this.changeInfo_button.Text = "Change Personal Info";
            this.changeInfo_button.UseVisualStyleBackColor = true;
            this.changeInfo_button.Click += new System.EventHandler(this.changeInfo_button_Click);
            this.changeInfo_button.MouseLeave += new System.EventHandler(this.changeInfo_button_MouseLeave);
            this.changeInfo_button.MouseHover += new System.EventHandler(this.changeInfo_button_MouseHover);
            // 
            // userName_label
            // 
            this.userName_label.AutoSize = true;
            this.userName_label.Location = new System.Drawing.Point(44, 207);
            this.userName_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userName_label.Name = "userName_label";
            this.userName_label.Size = new System.Drawing.Size(0, 18);
            this.userName_label.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SA45_9B_LibraryManaegmentSystem.Properties.Resources.NUS_coat_of_arms;
            this.pictureBox1.Location = new System.Drawing.Point(9, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // login_statusStrip
            // 
            this.login_statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.login_toolStripStatusLabel,
            this.Space_toolStripStatusLabel,
            this.time_toolStripStatusLabel});
            this.login_statusStrip.Location = new System.Drawing.Point(0, 561);
            this.login_statusStrip.Name = "login_statusStrip";
            this.login_statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.login_statusStrip.Size = new System.Drawing.Size(754, 22);
            this.login_statusStrip.TabIndex = 8;
            // 
            // login_toolStripStatusLabel
            // 
            this.login_toolStripStatusLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_toolStripStatusLabel.Name = "login_toolStripStatusLabel";
            this.login_toolStripStatusLabel.Size = new System.Drawing.Size(148, 17);
            this.login_toolStripStatusLabel.Text = "Please select an option";
            // 
            // Space_toolStripStatusLabel
            // 
            this.Space_toolStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.Space_toolStripStatusLabel.Name = "Space_toolStripStatusLabel";
            this.Space_toolStripStatusLabel.Size = new System.Drawing.Size(583, 17);
            this.Space_toolStripStatusLabel.Spring = true;
            // 
            // time_toolStripStatusLabel
            // 
            this.time_toolStripStatusLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_toolStripStatusLabel.Name = "time_toolStripStatusLabel";
            this.time_toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // query_button
            // 
            this.query_button.Location = new System.Drawing.Point(336, 289);
            this.query_button.Margin = new System.Windows.Forms.Padding(4);
            this.query_button.Name = "query_button";
            this.query_button.Size = new System.Drawing.Size(406, 54);
            this.query_button.TabIndex = 9;
            this.query_button.Text = "Query for Avalible Date";
            this.query_button.UseVisualStyleBackColor = true;
            this.query_button.Click += new System.EventHandler(this.query_button_Click);
            this.query_button.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.query_button.MouseHover += new System.EventHandler(this.query_button_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(566, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Beatify by zhong chuhong";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Receipt Form by Manisha Reddy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Database maintainenance by Ranjana ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(529, 531);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 18);
            this.label4.TabIndex = 82;
            this.label4.Text = "Contributed by Yi-Chieh Weng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 513);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 18);
            this.label5.TabIndex = 83;
            this.label5.Text = "Database creation by Yi-Chieh Weng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(529, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 18);
            this.label6.TabIndex = 84;
            this.label6.Text = "Intergration by Yi-Chieh Weng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(543, 496);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 18);
            this.label7.TabIndex = 85;
            this.label7.Text = "Validation by Yi-Chieh Weng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(205, 531);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(277, 18);
            this.label8.TabIndex = 86;
            this.label8.Text = "PrintBookListFrom by Yi-Chieh Weng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(244, 513);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(238, 18);
            this.label9.TabIndex = 87;
            this.label9.Text = "AnalysisForm by Yi-Chieh Weng";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(754, 583);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.query_button);
            this.Controls.Add(this.login_statusStrip);
            this.Controls.Add(this.info_groupBox);
            this.Controls.Add(this.addNewBook_button);
            this.Controls.Add(this.addNewMember_button);
            this.Controls.Add(this.lengingBook_button);
            this.Controls.Add(this.bookMatian_button);
            this.Controls.Add(this.MemberRecord_button);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.info_groupBox.ResumeLayout(false);
            this.info_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.login_statusStrip.ResumeLayout(false);
            this.login_statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MemberRecord_button;
        private System.Windows.Forms.Button bookMatian_button;
        private System.Windows.Forms.Button lengingBook_button;
        private System.Windows.Forms.Button addNewMember_button;
        private System.Windows.Forms.Button addNewBook_button;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.GroupBox info_groupBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label userName_label;
        private System.Windows.Forms.StatusStrip login_statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel login_toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel Space_toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel time_toolStripStatusLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button changeInfo_button;
        private System.Windows.Forms.Button changePassword_button;
        private System.Windows.Forms.Button query_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

