namespace SA45_9B_LibraryManaegmentSystem
{
    partial class LendingBookForm
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
            this.MemberInfo_groupBox = new System.Windows.Forms.GroupBox();
            this.phoneNumber_textBox = new System.Windows.Forms.TextBox();
            this.phoneNumber_label = new System.Windows.Forms.Label();
            this.memberSearch_button = new System.Windows.Forms.Button();
            this.memberName_textBox = new System.Windows.Forms.TextBox();
            this.memberID_textBox = new System.Windows.Forms.TextBox();
            this.memberName_label = new System.Windows.Forms.Label();
            this.memberID_label = new System.Windows.Forms.Label();
            this.bookInfo_groupBox = new System.Windows.Forms.GroupBox();
            this.remark_textBox = new System.Windows.Forms.TextBox();
            this.remark_label = new System.Windows.Forms.Label();
            this.dueDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.issueDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dueDate_label = new System.Windows.Forms.Label();
            this.issueDate_label = new System.Windows.Forms.Label();
            this.bookSearch_button = new System.Windows.Forms.Button();
            this.bookID_textBox = new System.Windows.Forms.TextBox();
            this.bookID_label = new System.Windows.Forms.Label();
            this.isbn_textBox = new System.Windows.Forms.TextBox();
            this.ISBN_label = new System.Windows.Forms.Label();
            this.bookTitle_textBox = new System.Windows.Forms.TextBox();
            this.bookTitle_label = new System.Windows.Forms.Label();
            this.lending_button = new System.Windows.Forms.Button();
            this.return_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.extend_button = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MemberInfo_groupBox.SuspendLayout();
            this.bookInfo_groupBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MemberInfo_groupBox
            // 
            this.MemberInfo_groupBox.Controls.Add(this.phoneNumber_textBox);
            this.MemberInfo_groupBox.Controls.Add(this.phoneNumber_label);
            this.MemberInfo_groupBox.Controls.Add(this.memberSearch_button);
            this.MemberInfo_groupBox.Controls.Add(this.memberName_textBox);
            this.MemberInfo_groupBox.Controls.Add(this.memberID_textBox);
            this.MemberInfo_groupBox.Controls.Add(this.memberName_label);
            this.MemberInfo_groupBox.Controls.Add(this.memberID_label);
            this.MemberInfo_groupBox.Location = new System.Drawing.Point(143, 37);
            this.MemberInfo_groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.MemberInfo_groupBox.Name = "MemberInfo_groupBox";
            this.MemberInfo_groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.MemberInfo_groupBox.Size = new System.Drawing.Size(456, 166);
            this.MemberInfo_groupBox.TabIndex = 0;
            this.MemberInfo_groupBox.TabStop = false;
            this.MemberInfo_groupBox.Text = "Member Info";
            // 
            // phoneNumber_textBox
            // 
            this.phoneNumber_textBox.Location = new System.Drawing.Point(202, 118);
            this.phoneNumber_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneNumber_textBox.Name = "phoneNumber_textBox";
            this.phoneNumber_textBox.Size = new System.Drawing.Size(148, 26);
            this.phoneNumber_textBox.TabIndex = 25;
            // 
            // phoneNumber_label
            // 
            this.phoneNumber_label.AutoSize = true;
            this.phoneNumber_label.Location = new System.Drawing.Point(32, 122);
            this.phoneNumber_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneNumber_label.Name = "phoneNumber_label";
            this.phoneNumber_label.Size = new System.Drawing.Size(115, 18);
            this.phoneNumber_label.TabIndex = 24;
            this.phoneNumber_label.Text = "Phone Number";
            // 
            // memberSearch_button
            // 
            this.memberSearch_button.Location = new System.Drawing.Point(376, 36);
            this.memberSearch_button.Margin = new System.Windows.Forms.Padding(4);
            this.memberSearch_button.Name = "memberSearch_button";
            this.memberSearch_button.Size = new System.Drawing.Size(46, 32);
            this.memberSearch_button.TabIndex = 23;
            this.memberSearch_button.Text = "...";
            this.memberSearch_button.UseVisualStyleBackColor = true;
            this.memberSearch_button.Click += new System.EventHandler(this.memberSearch_button_Click);
            // 
            // memberName_textBox
            // 
            this.memberName_textBox.Location = new System.Drawing.Point(200, 78);
            this.memberName_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.memberName_textBox.Name = "memberName_textBox";
            this.memberName_textBox.Size = new System.Drawing.Size(148, 26);
            this.memberName_textBox.TabIndex = 21;
            // 
            // memberID_textBox
            // 
            this.memberID_textBox.Location = new System.Drawing.Point(200, 36);
            this.memberID_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.memberID_textBox.Name = "memberID_textBox";
            this.memberID_textBox.Size = new System.Drawing.Size(148, 26);
            this.memberID_textBox.TabIndex = 20;
            // 
            // memberName_label
            // 
            this.memberName_label.AutoSize = true;
            this.memberName_label.Location = new System.Drawing.Point(32, 78);
            this.memberName_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memberName_label.Name = "memberName_label";
            this.memberName_label.Size = new System.Drawing.Size(115, 18);
            this.memberName_label.TabIndex = 18;
            this.memberName_label.Text = "Member Name";
            // 
            // memberID_label
            // 
            this.memberID_label.AutoSize = true;
            this.memberID_label.Location = new System.Drawing.Point(32, 36);
            this.memberID_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memberID_label.Name = "memberID_label";
            this.memberID_label.Size = new System.Drawing.Size(87, 18);
            this.memberID_label.TabIndex = 17;
            this.memberID_label.Text = "MemberID";
            // 
            // bookInfo_groupBox
            // 
            this.bookInfo_groupBox.Controls.Add(this.remark_textBox);
            this.bookInfo_groupBox.Controls.Add(this.remark_label);
            this.bookInfo_groupBox.Controls.Add(this.dueDate_dateTimePicker);
            this.bookInfo_groupBox.Controls.Add(this.issueDate_dateTimePicker);
            this.bookInfo_groupBox.Controls.Add(this.dueDate_label);
            this.bookInfo_groupBox.Controls.Add(this.issueDate_label);
            this.bookInfo_groupBox.Controls.Add(this.bookSearch_button);
            this.bookInfo_groupBox.Controls.Add(this.bookID_textBox);
            this.bookInfo_groupBox.Controls.Add(this.bookID_label);
            this.bookInfo_groupBox.Controls.Add(this.isbn_textBox);
            this.bookInfo_groupBox.Controls.Add(this.ISBN_label);
            this.bookInfo_groupBox.Controls.Add(this.bookTitle_textBox);
            this.bookInfo_groupBox.Controls.Add(this.bookTitle_label);
            this.bookInfo_groupBox.Location = new System.Drawing.Point(143, 211);
            this.bookInfo_groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.bookInfo_groupBox.Name = "bookInfo_groupBox";
            this.bookInfo_groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.bookInfo_groupBox.Size = new System.Drawing.Size(704, 317);
            this.bookInfo_groupBox.TabIndex = 1;
            this.bookInfo_groupBox.TabStop = false;
            this.bookInfo_groupBox.Text = "Book Info";
            // 
            // remark_textBox
            // 
            this.remark_textBox.Location = new System.Drawing.Point(105, 274);
            this.remark_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.remark_textBox.Name = "remark_textBox";
            this.remark_textBox.Size = new System.Drawing.Size(596, 26);
            this.remark_textBox.TabIndex = 89;
            // 
            // remark_label
            // 
            this.remark_label.AutoSize = true;
            this.remark_label.Location = new System.Drawing.Point(14, 274);
            this.remark_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.remark_label.Name = "remark_label";
            this.remark_label.Size = new System.Drawing.Size(72, 18);
            this.remark_label.TabIndex = 88;
            this.remark_label.Text = "Remarks";
            // 
            // dueDate_dateTimePicker
            // 
            this.dueDate_dateTimePicker.Location = new System.Drawing.Point(118, 231);
            this.dueDate_dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dueDate_dateTimePicker.Name = "dueDate_dateTimePicker";
            this.dueDate_dateTimePicker.Size = new System.Drawing.Size(298, 26);
            this.dueDate_dateTimePicker.TabIndex = 87;
            // 
            // issueDate_dateTimePicker
            // 
            this.issueDate_dateTimePicker.Location = new System.Drawing.Point(118, 191);
            this.issueDate_dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.issueDate_dateTimePicker.Name = "issueDate_dateTimePicker";
            this.issueDate_dateTimePicker.Size = new System.Drawing.Size(298, 26);
            this.issueDate_dateTimePicker.TabIndex = 86;
            // 
            // dueDate_label
            // 
            this.dueDate_label.AutoSize = true;
            this.dueDate_label.Location = new System.Drawing.Point(12, 231);
            this.dueDate_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dueDate_label.Name = "dueDate_label";
            this.dueDate_label.Size = new System.Drawing.Size(73, 18);
            this.dueDate_label.TabIndex = 85;
            this.dueDate_label.Text = "Due Date";
            // 
            // issueDate_label
            // 
            this.issueDate_label.AutoSize = true;
            this.issueDate_label.Location = new System.Drawing.Point(9, 191);
            this.issueDate_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.issueDate_label.Name = "issueDate_label";
            this.issueDate_label.Size = new System.Drawing.Size(83, 18);
            this.issueDate_label.TabIndex = 84;
            this.issueDate_label.Text = "Issue Date";
            // 
            // bookSearch_button
            // 
            this.bookSearch_button.Location = new System.Drawing.Point(302, 53);
            this.bookSearch_button.Margin = new System.Windows.Forms.Padding(4);
            this.bookSearch_button.Name = "bookSearch_button";
            this.bookSearch_button.Size = new System.Drawing.Size(46, 32);
            this.bookSearch_button.TabIndex = 83;
            this.bookSearch_button.Text = "...";
            this.bookSearch_button.UseVisualStyleBackColor = true;
            this.bookSearch_button.Click += new System.EventHandler(this.bookSearch_button_Click);
            // 
            // bookID_textBox
            // 
            this.bookID_textBox.Location = new System.Drawing.Point(118, 51);
            this.bookID_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.bookID_textBox.Name = "bookID_textBox";
            this.bookID_textBox.Size = new System.Drawing.Size(148, 26);
            this.bookID_textBox.TabIndex = 82;
            // 
            // bookID_label
            // 
            this.bookID_label.AutoSize = true;
            this.bookID_label.Location = new System.Drawing.Point(9, 51);
            this.bookID_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bookID_label.Name = "bookID_label";
            this.bookID_label.Size = new System.Drawing.Size(65, 18);
            this.bookID_label.TabIndex = 81;
            this.bookID_label.Text = "Book ID";
            // 
            // isbn_textBox
            // 
            this.isbn_textBox.Location = new System.Drawing.Point(118, 102);
            this.isbn_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.isbn_textBox.Name = "isbn_textBox";
            this.isbn_textBox.Size = new System.Drawing.Size(182, 26);
            this.isbn_textBox.TabIndex = 80;
            // 
            // ISBN_label
            // 
            this.ISBN_label.AutoSize = true;
            this.ISBN_label.Location = new System.Drawing.Point(9, 102);
            this.ISBN_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ISBN_label.Name = "ISBN_label";
            this.ISBN_label.Size = new System.Drawing.Size(108, 18);
            this.ISBN_label.TabIndex = 79;
            this.ISBN_label.Text = "ISBNNUmber";
            // 
            // bookTitle_textBox
            // 
            this.bookTitle_textBox.Location = new System.Drawing.Point(118, 143);
            this.bookTitle_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.bookTitle_textBox.Name = "bookTitle_textBox";
            this.bookTitle_textBox.Size = new System.Drawing.Size(574, 26);
            this.bookTitle_textBox.TabIndex = 78;
            // 
            // bookTitle_label
            // 
            this.bookTitle_label.AutoSize = true;
            this.bookTitle_label.Location = new System.Drawing.Point(9, 147);
            this.bookTitle_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bookTitle_label.Name = "bookTitle_label";
            this.bookTitle_label.Size = new System.Drawing.Size(80, 18);
            this.bookTitle_label.TabIndex = 77;
            this.bookTitle_label.Text = "Book Title";
            // 
            // lending_button
            // 
            this.lending_button.Location = new System.Drawing.Point(0, 376);
            this.lending_button.Margin = new System.Windows.Forms.Padding(4);
            this.lending_button.Name = "lending_button";
            this.lending_button.Size = new System.Drawing.Size(112, 32);
            this.lending_button.TabIndex = 2;
            this.lending_button.Text = "Lending";
            this.lending_button.UseVisualStyleBackColor = true;
            this.lending_button.Click += new System.EventHandler(this.lending_button_Click);
            // 
            // return_button
            // 
            this.return_button.Location = new System.Drawing.Point(0, 456);
            this.return_button.Margin = new System.Windows.Forms.Padding(4);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(112, 32);
            this.return_button.TabIndex = 3;
            this.return_button.Text = "Return";
            this.return_button.UseVisualStyleBackColor = true;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(0, 496);
            this.Back_button.Margin = new System.Windows.Forms.Padding(4);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(112, 32);
            this.Back_button.TabIndex = 4;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // extend_button
            // 
            this.extend_button.Location = new System.Drawing.Point(0, 416);
            this.extend_button.Margin = new System.Windows.Forms.Padding(4);
            this.extend_button.Name = "extend_button";
            this.extend_button.Size = new System.Drawing.Size(112, 32);
            this.extend_button.TabIndex = 6;
            this.extend_button.Text = "Extention";
            this.extend_button.UseVisualStyleBackColor = true;
            this.extend_button.Click += new System.EventHandler(this.extend_button_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 650);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(870, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(743, 543);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(101, 18);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Print Receipt";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SA45_9B_LibraryManaegmentSystem.Properties.Resources.photo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(651, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 18);
            this.label1.TabIndex = 82;
            this.label1.Text = "Contributed by zhong chuhong";
            // 
            // LendingBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(870, 672);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.extend_button);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.return_button);
            this.Controls.Add(this.lending_button);
            this.Controls.Add(this.bookInfo_groupBox);
            this.Controls.Add(this.MemberInfo_groupBox);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LendingBookForm";
            this.Text = "LendingBookForm";
            this.Load += new System.EventHandler(this.LendingBookForm_Load);
            this.MemberInfo_groupBox.ResumeLayout(false);
            this.MemberInfo_groupBox.PerformLayout();
            this.bookInfo_groupBox.ResumeLayout(false);
            this.bookInfo_groupBox.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox MemberInfo_groupBox;
        private System.Windows.Forms.Button memberSearch_button;
        private System.Windows.Forms.TextBox memberName_textBox;
        private System.Windows.Forms.TextBox memberID_textBox;
        private System.Windows.Forms.Label memberName_label;
        private System.Windows.Forms.Label memberID_label;
        private System.Windows.Forms.TextBox phoneNumber_textBox;
        private System.Windows.Forms.Label phoneNumber_label;
        private System.Windows.Forms.GroupBox bookInfo_groupBox;
        private System.Windows.Forms.Button bookSearch_button;
        private System.Windows.Forms.TextBox bookID_textBox;
        private System.Windows.Forms.Label bookID_label;
        private System.Windows.Forms.TextBox isbn_textBox;
        private System.Windows.Forms.Label ISBN_label;
        private System.Windows.Forms.TextBox bookTitle_textBox;
        private System.Windows.Forms.Label bookTitle_label;
        private System.Windows.Forms.Button lending_button;
        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.TextBox remark_textBox;
        private System.Windows.Forms.Label remark_label;
        private System.Windows.Forms.DateTimePicker dueDate_dateTimePicker;
        private System.Windows.Forms.DateTimePicker issueDate_dateTimePicker;
        private System.Windows.Forms.Label dueDate_label;
        private System.Windows.Forms.Label issueDate_label;
        private System.Windows.Forms.Button extend_button;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}