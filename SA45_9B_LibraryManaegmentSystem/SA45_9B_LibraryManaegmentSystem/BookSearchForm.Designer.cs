namespace SA45_9B_LibraryManaegmentSystem
{
    partial class BookSearchForm
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
            this.search_dataGridView = new System.Windows.Forms.DataGridView();
            this.Ckeck_Column = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Search_comboBox2 = new System.Windows.Forms.ComboBox();
            this.Search_comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AdvanceSearch_button = new System.Windows.Forms.Button();
            this.author_textBox = new System.Windows.Forms.TextBox();
            this.title_textBox = new System.Windows.Forms.TextBox();
            this.ISBN_textBox = new System.Windows.Forms.TextBox();
            this.basicSearch_textBox = new System.Windows.Forms.TextBox();
            this.BasicSearch_button = new System.Windows.Forms.Button();
            this.basicSearch_groupBox = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.search_dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.basicSearch_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // search_dataGridView
            // 
            this.search_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.search_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.search_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.search_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ckeck_Column});
            this.search_dataGridView.Location = new System.Drawing.Point(100, 298);
            this.search_dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.search_dataGridView.Name = "search_dataGridView";
            this.search_dataGridView.Size = new System.Drawing.Size(873, 386);
            this.search_dataGridView.TabIndex = 0;
            this.search_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.search_dataGridView_CellContentClick);
            // 
            // Ckeck_Column
            // 
            this.Ckeck_Column.HeaderText = "Check Avilibility";
            this.Ckeck_Column.Name = "Ckeck_Column";
            this.Ckeck_Column.Text = "Ckeck";
            this.Ckeck_Column.UseColumnTextForButtonValue = true;
            this.Ckeck_Column.Width = 116;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 727);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(861, 727);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Search_comboBox2);
            this.groupBox1.Controls.Add(this.Search_comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AdvanceSearch_button);
            this.groupBox1.Controls.Add(this.author_textBox);
            this.groupBox1.Controls.Add(this.title_textBox);
            this.groupBox1.Controls.Add(this.ISBN_textBox);
            this.groupBox1.Location = new System.Drawing.Point(100, 116);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(873, 159);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Advance Search";
            // 
            // Search_comboBox2
            // 
            this.Search_comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Search_comboBox2.FormattingEnabled = true;
            this.Search_comboBox2.Items.AddRange(new object[] {
            "AND",
            "OR",
            "NOT"});
            this.Search_comboBox2.Location = new System.Drawing.Point(447, 73);
            this.Search_comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.Search_comboBox2.Name = "Search_comboBox2";
            this.Search_comboBox2.Size = new System.Drawing.Size(92, 26);
            this.Search_comboBox2.TabIndex = 14;
            // 
            // Search_comboBox1
            // 
            this.Search_comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Search_comboBox1.FormattingEnabled = true;
            this.Search_comboBox1.Items.AddRange(new object[] {
            "AND",
            "OR",
            "NOT"});
            this.Search_comboBox1.Location = new System.Drawing.Point(447, 32);
            this.Search_comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.Search_comboBox1.Name = "Search_comboBox1";
            this.Search_comboBox1.Size = new System.Drawing.Size(92, 26);
            this.Search_comboBox1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Author:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Book Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "ISBN Number:";
            // 
            // AdvanceSearch_button
            // 
            this.AdvanceSearch_button.Location = new System.Drawing.Point(681, 123);
            this.AdvanceSearch_button.Margin = new System.Windows.Forms.Padding(4);
            this.AdvanceSearch_button.Name = "AdvanceSearch_button";
            this.AdvanceSearch_button.Size = new System.Drawing.Size(112, 32);
            this.AdvanceSearch_button.TabIndex = 9;
            this.AdvanceSearch_button.Text = "Search";
            this.AdvanceSearch_button.UseVisualStyleBackColor = true;
            this.AdvanceSearch_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // author_textBox
            // 
            this.author_textBox.Location = new System.Drawing.Point(130, 107);
            this.author_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.author_textBox.Name = "author_textBox";
            this.author_textBox.Size = new System.Drawing.Size(289, 26);
            this.author_textBox.TabIndex = 8;
            // 
            // title_textBox
            // 
            this.title_textBox.Location = new System.Drawing.Point(130, 73);
            this.title_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.title_textBox.Name = "title_textBox";
            this.title_textBox.Size = new System.Drawing.Size(289, 26);
            this.title_textBox.TabIndex = 7;
            // 
            // ISBN_textBox
            // 
            this.ISBN_textBox.Location = new System.Drawing.Point(130, 32);
            this.ISBN_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.ISBN_textBox.Name = "ISBN_textBox";
            this.ISBN_textBox.Size = new System.Drawing.Size(289, 26);
            this.ISBN_textBox.TabIndex = 6;
            // 
            // basicSearch_textBox
            // 
            this.basicSearch_textBox.Location = new System.Drawing.Point(9, 37);
            this.basicSearch_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.basicSearch_textBox.Name = "basicSearch_textBox";
            this.basicSearch_textBox.Size = new System.Drawing.Size(176, 26);
            this.basicSearch_textBox.TabIndex = 6;
            // 
            // BasicSearch_button
            // 
            this.BasicSearch_button.Location = new System.Drawing.Point(213, 35);
            this.BasicSearch_button.Margin = new System.Windows.Forms.Padding(4);
            this.BasicSearch_button.Name = "BasicSearch_button";
            this.BasicSearch_button.Size = new System.Drawing.Size(112, 32);
            this.BasicSearch_button.TabIndex = 10;
            this.BasicSearch_button.Text = "Search";
            this.BasicSearch_button.UseVisualStyleBackColor = true;
            this.BasicSearch_button.Click += new System.EventHandler(this.button4_Click);
            // 
            // basicSearch_groupBox
            // 
            this.basicSearch_groupBox.Controls.Add(this.basicSearch_textBox);
            this.basicSearch_groupBox.Controls.Add(this.BasicSearch_button);
            this.basicSearch_groupBox.Location = new System.Drawing.Point(112, 22);
            this.basicSearch_groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.basicSearch_groupBox.Name = "basicSearch_groupBox";
            this.basicSearch_groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.basicSearch_groupBox.Size = new System.Drawing.Size(363, 91);
            this.basicSearch_groupBox.TabIndex = 11;
            this.basicSearch_groupBox.TabStop = false;
            this.basicSearch_groupBox.Text = "Baseic Search";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(96, 688);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(155, 18);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Print Total Book List";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(774, 688);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(199, 18);
            this.linkLabel2.TabIndex = 13;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Print Stock Status Analysis";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SA45_9B_LibraryManaegmentSystem.Properties.Resources.photo;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(754, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 18);
            this.label4.TabIndex = 81;
            this.label4.Text = "Contributed by Yi-Chieh Weng";
            // 
            // BookSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1052, 793);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.basicSearch_groupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.search_dataGridView);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookSearchForm";
            this.Text = "BookSearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.search_dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.basicSearch_groupBox.ResumeLayout(false);
            this.basicSearch_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView search_dataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AdvanceSearch_button;
        private System.Windows.Forms.TextBox author_textBox;
        private System.Windows.Forms.TextBox title_textBox;
        private System.Windows.Forms.TextBox ISBN_textBox;
        private System.Windows.Forms.TextBox basicSearch_textBox;
        private System.Windows.Forms.Button BasicSearch_button;
        private System.Windows.Forms.GroupBox basicSearch_groupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Search_comboBox1;
        private System.Windows.Forms.ComboBox Search_comboBox2;
        private System.Windows.Forms.DataGridViewButtonColumn Ckeck_Column;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}