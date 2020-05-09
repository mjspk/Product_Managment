namespace Product_Managment.presentation_Access
{
    partial class Login_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_frm));
            this.login_bt = new System.Windows.Forms.Button();
            this.user_name_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // login_bt
            // 
            this.login_bt.BackColor = System.Drawing.Color.Transparent;
            this.login_bt.Font = new System.Drawing.Font("Tahoma", 8F);
            this.login_bt.ForeColor = System.Drawing.Color.Maroon;
            this.login_bt.Location = new System.Drawing.Point(497, 230);
            this.login_bt.Name = "login_bt";
            this.login_bt.Size = new System.Drawing.Size(49, 22);
            this.login_bt.TabIndex = 0;
            this.login_bt.Text = "LOG IN >";
            this.login_bt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.login_bt.UseVisualStyleBackColor = false;
            this.login_bt.Click += new System.EventHandler(this.login_bt_Click);
            // 
            // user_name_tb
            // 
            this.user_name_tb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name_tb.Location = new System.Drawing.Point(338, 202);
            this.user_name_tb.Name = "user_name_tb";
            this.user_name_tb.Size = new System.Drawing.Size(208, 23);
            this.user_name_tb.TabIndex = 2;
            this.user_name_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.user_name_tb.TextChanged += new System.EventHandler(this.user_name_tb_TextChanged);
            this.user_name_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.user_name_tb_KeyDown);
            // 
            // password_tb
            // 
            this.password_tb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_tb.Location = new System.Drawing.Point(338, 230);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(208, 23);
            this.password_tb.TabIndex = 3;
            this.password_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_tb_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(245, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "USER NAME :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(245, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "PASSWORD :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(335, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox1.Location = new System.Drawing.Point(338, 280);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(121, 21);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Remamber me ";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // Login_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Product_Managment.Properties.Resources.Phototastic_2_16_2016_4c9e6880_1042_4de7_b471_8b41ed78270c;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(558, 313);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user_name_tb);
            this.Controls.Add(this.login_bt);
            this.Controls.Add(this.password_tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.Login_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_bt;
        private System.Windows.Forms.TextBox user_name_tb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}