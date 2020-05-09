namespace Product_Managment.presentation_Access
{
    partial class Connection_setting
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
            this.label1 = new System.Windows.Forms.Label();
            this.sever_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.username_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.database_tb = new System.Windows.Forms.TextBox();
            this.win_rb = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sql_rb = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sever_tb
            // 
            this.sever_tb.Location = new System.Drawing.Point(142, 55);
            this.sever_tb.Name = "sever_tb";
            this.sever_tb.Size = new System.Drawing.Size(293, 30);
            this.sever_tb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // username_tb
            // 
            this.username_tb.Location = new System.Drawing.Point(142, 241);
            this.username_tb.Name = "username_tb";
            this.username_tb.ReadOnly = true;
            this.username_tb.Size = new System.Drawing.Size(300, 30);
            this.username_tb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(142, 287);
            this.password_tb.Name = "password_tb";
            this.password_tb.ReadOnly = true;
            this.password_tb.Size = new System.Drawing.Size(300, 30);
            this.password_tb.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "DataBase ";
            // 
            // database_tb
            // 
            this.database_tb.Location = new System.Drawing.Point(142, 105);
            this.database_tb.Name = "database_tb";
            this.database_tb.Size = new System.Drawing.Size(293, 30);
            this.database_tb.TabIndex = 7;
            // 
            // win_rb
            // 
            this.win_rb.AutoSize = true;
            this.win_rb.Location = new System.Drawing.Point(142, 158);
            this.win_rb.Name = "win_rb";
            this.win_rb.Size = new System.Drawing.Size(229, 27);
            this.win_rb.TabIndex = 8;
            this.win_rb.Text = "Windows Authentication";
            this.win_rb.UseVisualStyleBackColor = true;
            this.win_rb.CheckedChanged += new System.EventHandler(this.win_rb_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sql_rb);
            this.groupBox1.Controls.Add(this.win_rb);
            this.groupBox1.Controls.Add(this.database_tb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.password_tb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.username_tb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.sever_tb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 380);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // sql_rb
            // 
            this.sql_rb.AutoSize = true;
            this.sql_rb.Location = new System.Drawing.Point(142, 191);
            this.sql_rb.Name = "sql_rb";
            this.sql_rb.Size = new System.Drawing.Size(247, 27);
            this.sql_rb.TabIndex = 9;
            this.sql_rb.Text = "SQL Server Authentication";
            this.sql_rb.UseVisualStyleBackColor = true;
            this.sql_rb.CheckedChanged += new System.EventHandler(this.sql_rb_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.button1.Location = new System.Drawing.Point(33, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save Setting";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.button2.Location = new System.Drawing.Point(169, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Connection_setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(491, 461);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Connection_setting";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connnection_setting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sever_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox database_tb;
        private System.Windows.Forms.RadioButton win_rb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton sql_rb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}