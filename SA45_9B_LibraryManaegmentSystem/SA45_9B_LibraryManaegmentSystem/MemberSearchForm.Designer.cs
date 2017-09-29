namespace SA45_9B_LibraryManaegmentSystem
{
    partial class MemberSearchForm
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
            this.memberID_label = new System.Windows.Forms.Label();
            this.memberName_label = new System.Windows.Forms.Label();
            this.memberID_textBox = new System.Windows.Forms.TextBox();
            this.memberName_textBox = new System.Windows.Forms.TextBox();
            this.phoneNumber_label = new System.Windows.Forms.Label();
            this.phoneNumber_textBox = new System.Windows.Forms.TextBox();
            this.search_groupBox = new System.Windows.Forms.GroupBox();
            this.search_button = new System.Windows.Forms.Button();
            this.search_dataGridView = new System.Windows.Forms.DataGridView();
            this.select_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.search_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // memberID_label
            // 
            this.memberID_label.AutoSize = true;
            this.memberID_label.Location = new System.Drawing.Point(9, 30);
            this.memberID_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memberID_label.Name = "memberID_label";
            this.memberID_label.Size = new System.Drawing.Size(91, 18);
            this.memberID_label.TabIndex = 0;
            this.memberID_label.Text = "Member ID";
            // 
            // memberName_label
            // 
            this.memberName_label.AutoSize = true;
            this.memberName_label.Location = new System.Drawing.Point(9, 66);
            this.memberName_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memberName_label.Name = "memberName_label";
            this.memberName_label.Size = new System.Drawing.Size(115, 18);
            this.memberName_label.TabIndex = 1;
            this.memberName_label.Text = "Member Name";
            // 
            // memberID_textBox
            // 
            this.memberID_textBox.Location = new System.Drawing.Point(135, 26);
            this.memberID_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.memberID_textBox.Name = "memberID_textBox";
            this.memberID_textBox.Size = new System.Drawing.Size(148, 26);
            this.memberID_textBox.TabIndex = 2;
            // 
            // memberName_textBox
            // 
            this.memberName_textBox.Location = new System.Drawing.Point(135, 66);
            this.memberName_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.memberName_textBox.Name = "memberName_textBox";
            this.memberName_textBox.Size = new System.Drawing.Size(148, 26);
            this.memberName_textBox.TabIndex = 3;
            // 
            // phoneNumber_label
            // 
            this.phoneNumber_label.AutoSize = true;
            this.phoneNumber_label.Location = new System.Drawing.Point(9, 108);
            this.phoneNumber_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneNumber_label.Name = "phoneNumber_label";
            this.phoneNumber_label.Size = new System.Drawing.Size(115, 18);
            this.phoneNumber_label.TabIndex = 4;
            this.phoneNumber_label.Text = "Phone Number";
            // 
            // phoneNumber_textBox
            // 
            this.phoneNumber_textBox.Location = new System.Drawing.Point(135, 104);
            this.phoneNumber_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneNumber_textBox.Name = "phoneNumber_textBox";
            this.phoneNumber_textBox.Size = new System.Drawing.Size(148, 26);
            this.phoneNumber_textBox.TabIndex = 5;
            // 
            // search_groupBox
            // 
            this.search_groupBox.Controls.Add(this.search_button);
            this.search_groupBox.Controls.Add(this.memberID_label);
            this.search_groupBox.Controls.Add(this.phoneNumber_textBox);
            this.search_groupBox.Controls.Add(this.memberName_label);
            this.search_groupBox.Controls.Add(this.memberName_textBox);
            this.search_groupBox.Controls.Add(this.phoneNumber_label);
            this.search_groupBox.Controls.Add(this.memberID_textBox);
            this.search_groupBox.Location = new System.Drawing.Point(416, 13);
            this.search_groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.search_groupBox.Name = "search_groupBox";
            this.search_groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.search_groupBox.Size = new System.Drawing.Size(422, 156);
            this.search_groupBox.TabIndex = 6;
            this.search_groupBox.TabStop = false;
            this.search_groupBox.Text = "Search Panal";
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(294, 100);
            this.search_button.Margin = new System.Windows.Forms.Padding(4);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(112, 32);
            this.search_button.TabIndex = 6;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // search_dataGridView
            // 
            this.search_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.search_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.search_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.search_dataGridView.Location = new System.Drawing.Point(42, 183);
            this.search_dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.search_dataGridView.Name = "search_dataGridView";
            this.search_dataGridView.Size = new System.Drawing.Size(798, 390);
            this.search_dataGridView.TabIndex = 7;
            // 
            // select_button
            // 
            this.select_button.Location = new System.Drawing.Point(42, 595);
            this.select_button.Margin = new System.Windows.Forms.Padding(4);
            this.select_button.Name = "select_button";
            this.select_button.Size = new System.Drawing.Size(112, 32);
            this.select_button.TabIndex = 8;
            this.select_button.Text = "Select";
            this.select_button.UseVisualStyleBackColor = true;
            this.select_button.Click += new System.EventHandler(this.select_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(726, 583);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(4);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(112, 32);
            this.cancel_button.TabIndex = 9;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SA45_9B_LibraryManaegmentSystem.Properties.Resources.photo;
            this.pictureBox1.Location = new System.Drawing.Point(42, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 18);
            this.label4.TabIndex = 83;
            this.label4.Text = "Contributed by Yi-Chieh Weng";
            // 
            // MemberSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(939, 763);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.select_button);
            this.Controls.Add(this.search_dataGridView);
            this.Controls.Add(this.search_groupBox);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MemberSearchForm";
            this.Text = "MemberSearchForm";
            this.search_groupBox.ResumeLayout(false);
            this.search_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label memberID_label;
        private System.Windows.Forms.Label memberName_label;
        private System.Windows.Forms.TextBox memberID_textBox;
        private System.Windows.Forms.TextBox memberName_textBox;
        private System.Windows.Forms.Label phoneNumber_label;
        private System.Windows.Forms.TextBox phoneNumber_textBox;
        private System.Windows.Forms.GroupBox search_groupBox;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.DataGridView search_dataGridView;
        private System.Windows.Forms.Button select_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}