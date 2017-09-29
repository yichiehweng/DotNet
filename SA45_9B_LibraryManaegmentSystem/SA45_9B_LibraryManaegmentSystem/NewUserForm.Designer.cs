namespace SA45_9B_LibraryManaegmentSystem
{
    partial class NewUserForm
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
            this.employeeID_label = new System.Windows.Forms.Label();
            this.employeeID_textBox = new System.Windows.Forms.TextBox();
            this.loginName_label = new System.Windows.Forms.Label();
            this.loginName_textBox = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.password2_label = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.submit_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeID_label
            // 
            this.employeeID_label.AutoSize = true;
            this.employeeID_label.Location = new System.Drawing.Point(69, 53);
            this.employeeID_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.employeeID_label.Name = "employeeID_label";
            this.employeeID_label.Size = new System.Drawing.Size(100, 18);
            this.employeeID_label.TabIndex = 0;
            this.employeeID_label.Text = "Employee ID";
            // 
            // employeeID_textBox
            // 
            this.employeeID_textBox.Location = new System.Drawing.Point(214, 53);
            this.employeeID_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.employeeID_textBox.Name = "employeeID_textBox";
            this.employeeID_textBox.Size = new System.Drawing.Size(148, 26);
            this.employeeID_textBox.TabIndex = 1;
            // 
            // loginName_label
            // 
            this.loginName_label.AutoSize = true;
            this.loginName_label.Location = new System.Drawing.Point(69, 97);
            this.loginName_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginName_label.Name = "loginName_label";
            this.loginName_label.Size = new System.Drawing.Size(87, 18);
            this.loginName_label.TabIndex = 2;
            this.loginName_label.Text = "login Name";
            // 
            // loginName_textBox
            // 
            this.loginName_textBox.Location = new System.Drawing.Point(214, 97);
            this.loginName_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.loginName_textBox.Name = "loginName_textBox";
            this.loginName_textBox.Size = new System.Drawing.Size(148, 26);
            this.loginName_textBox.TabIndex = 3;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(69, 142);
            this.password_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(120, 18);
            this.password_label.TabIndex = 4;
            this.password_label.Text = "Enter Password";
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(214, 139);
            this.password_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '*';
            this.password_textBox.Size = new System.Drawing.Size(148, 26);
            this.password_textBox.TabIndex = 5;
            // 
            // password2_label
            // 
            this.password2_label.AutoSize = true;
            this.password2_label.Location = new System.Drawing.Point(69, 182);
            this.password2_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password2_label.Name = "password2_label";
            this.password2_label.Size = new System.Drawing.Size(137, 18);
            this.password2_label.TabIndex = 6;
            this.password2_label.Text = "Reenter Password";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(214, 182);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(148, 26);
            this.textBox2.TabIndex = 7;
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(44, 253);
            this.submit_button.Margin = new System.Windows.Forms.Padding(4);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(112, 32);
            this.submit_button.TabIndex = 8;
            this.submit_button.Text = "Submit";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(338, 253);
            this.Cancel_button.Margin = new System.Windows.Forms.Padding(4);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(112, 32);
            this.Cancel_button.TabIndex = 9;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 342);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(538, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 18);
            this.label4.TabIndex = 82;
            this.label4.Text = "Contributed by Yi-Chieh Weng";
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(538, 364);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.password2_label);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.loginName_textBox);
            this.Controls.Add(this.loginName_label);
            this.Controls.Add(this.employeeID_textBox);
            this.Controls.Add(this.employeeID_label);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewUserForm";
            this.Text = "NewUserForm";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label employeeID_label;
        private System.Windows.Forms.TextBox employeeID_textBox;
        private System.Windows.Forms.Label loginName_label;
        private System.Windows.Forms.TextBox loginName_textBox;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Label password2_label;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label4;
    }
}