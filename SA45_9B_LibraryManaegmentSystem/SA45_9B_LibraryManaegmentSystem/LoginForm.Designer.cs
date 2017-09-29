namespace SA45_9B_LibraryManaegmentSystem
{
    partial class LoginForm
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
            this.userName_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.userName_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.login_statusStrip = new System.Windows.Forms.StatusStrip();
            this.login_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Space_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.time_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.newUser_linkLabel = new System.Windows.Forms.LinkLabel();
            this.exit_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.login_statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // userName_label
            // 
            this.userName_label.AutoSize = true;
            this.userName_label.Location = new System.Drawing.Point(76, 110);
            this.userName_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userName_label.Name = "userName_label";
            this.userName_label.Size = new System.Drawing.Size(88, 22);
            this.userName_label.TabIndex = 0;
            this.userName_label.Text = "User Name";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(76, 168);
            this.password_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(74, 22);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "Password";
            // 
            // userName_textBox
            // 
            this.userName_textBox.Location = new System.Drawing.Point(192, 110);
            this.userName_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userName_textBox.Name = "userName_textBox";
            this.userName_textBox.Size = new System.Drawing.Size(148, 29);
            this.userName_textBox.TabIndex = 2;
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(192, 156);
            this.password_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.Size = new System.Drawing.Size(148, 29);
            this.password_textBox.TabIndex = 3;
            // 
            // login_button
            // 
            this.login_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.login_button.Location = new System.Drawing.Point(192, 220);
            this.login_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(112, 39);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // login_statusStrip
            // 
            this.login_statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.login_toolStripStatusLabel,
            this.Space_toolStripStatusLabel,
            this.time_toolStripStatusLabel});
            this.login_statusStrip.Location = new System.Drawing.Point(0, 355);
            this.login_statusStrip.Name = "login_statusStrip";
            this.login_statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.login_statusStrip.Size = new System.Drawing.Size(506, 24);
            this.login_statusStrip.TabIndex = 6;
            // 
            // login_toolStripStatusLabel
            // 
            this.login_toolStripStatusLabel.Font = new System.Drawing.Font("Sitka Display", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_toolStripStatusLabel.Name = "login_toolStripStatusLabel";
            this.login_toolStripStatusLabel.Size = new System.Drawing.Size(117, 19);
            this.login_toolStripStatusLabel.Text = "Welcome to Library";
            // 
            // Space_toolStripStatusLabel
            // 
            this.Space_toolStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.Space_toolStripStatusLabel.Name = "Space_toolStripStatusLabel";
            this.Space_toolStripStatusLabel.Size = new System.Drawing.Size(366, 19);
            this.Space_toolStripStatusLabel.Spring = true;
            // 
            // time_toolStripStatusLabel
            // 
            this.time_toolStripStatusLabel.Name = "time_toolStripStatusLabel";
            this.time_toolStripStatusLabel.Size = new System.Drawing.Size(0, 19);
            // 
            // newUser_linkLabel
            // 
            this.newUser_linkLabel.AutoSize = true;
            this.newUser_linkLabel.Location = new System.Drawing.Point(75, 228);
            this.newUser_linkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newUser_linkLabel.Name = "newUser_linkLabel";
            this.newUser_linkLabel.Size = new System.Drawing.Size(78, 22);
            this.newUser_linkLabel.TabIndex = 7;
            this.newUser_linkLabel.TabStop = true;
            this.newUser_linkLabel.Text = "New User";
            this.newUser_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.newUser_linkLabel_LinkClicked);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(192, 269);
            this.exit_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(112, 39);
            this.exit_button.TabIndex = 8;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 22);
            this.label4.TabIndex = 82;
            this.label4.Text = "Contributed by Yi-Chieh Weng";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(506, 379);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.newUser_linkLabel);
            this.Controls.Add(this.login_statusStrip);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.userName_textBox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.userName_label);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.login_statusStrip.ResumeLayout(false);
            this.login_statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userName_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox userName_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.StatusStrip login_statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel login_toolStripStatusLabel;
        private System.Windows.Forms.LinkLabel newUser_linkLabel;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.ToolStripStatusLabel Space_toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel time_toolStripStatusLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
    }
}