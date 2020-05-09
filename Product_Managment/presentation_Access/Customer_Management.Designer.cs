namespace Product_Managment.presentation_Access
{
    partial class Customer_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Management));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tell_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastname_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstname_bt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.edit_bt = new System.Windows.Forms.Button();
            this.delete_bt = new System.Windows.Forms.Button();
            this.label_position = new System.Windows.Forms.Label();
            this.add_bt = new System.Windows.Forms.Button();
            this.last_bt = new System.Windows.Forms.Button();
            this.new_bt = new System.Windows.Forms.Button();
            this.next_bt = new System.Windows.Forms.Button();
            this.previous_bt = new System.Windows.Forms.Button();
            this.first_bt = new System.Windows.Forms.Button();
            this.close_bt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.search_tb);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 431);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer List";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // search_tb
            // 
            this.search_tb.Location = new System.Drawing.Point(101, 29);
            this.search_tb.Multiline = true;
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(281, 24);
            this.search_tb.TabIndex = 1;
            this.search_tb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 69);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(519, 356);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.email_tb);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tell_tb);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lastname_tb);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.firstname_bt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11F);
            this.groupBox2.Location = new System.Drawing.Point(549, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 214);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Info";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Product_Managment.Properties.Resources.noimage;
            this.pictureBox1.Location = new System.Drawing.Point(304, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // email_tb
            // 
            this.email_tb.Font = new System.Drawing.Font("Tahoma", 10F);
            this.email_tb.Location = new System.Drawing.Point(107, 158);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(174, 24);
            this.email_tb.TabIndex = 7;
            this.email_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.email_tb_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(26, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email :";
            // 
            // tell_tb
            // 
            this.tell_tb.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tell_tb.Location = new System.Drawing.Point(107, 115);
            this.tell_tb.Name = "tell_tb";
            this.tell_tb.Size = new System.Drawing.Size(174, 24);
            this.tell_tb.TabIndex = 5;
            this.tell_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tell_tb_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(26, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "TEL :";
            // 
            // lastname_tb
            // 
            this.lastname_tb.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lastname_tb.Location = new System.Drawing.Point(107, 69);
            this.lastname_tb.Name = "lastname_tb";
            this.lastname_tb.Size = new System.Drawing.Size(174, 24);
            this.lastname_tb.TabIndex = 3;
            this.lastname_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lastname_tb_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(26, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name :";
            // 
            // firstname_bt
            // 
            this.firstname_bt.Font = new System.Drawing.Font("Tahoma", 10F);
            this.firstname_bt.Location = new System.Drawing.Point(107, 29);
            this.firstname_bt.Name = "firstname_bt";
            this.firstname_bt.Size = new System.Drawing.Size(174, 24);
            this.firstname_bt.TabIndex = 1;
            this.firstname_bt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.firstname_bt_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Controls.Add(this.edit_bt);
            this.groupBox3.Controls.Add(this.delete_bt);
            this.groupBox3.Controls.Add(this.label_position);
            this.groupBox3.Controls.Add(this.add_bt);
            this.groupBox3.Controls.Add(this.last_bt);
            this.groupBox3.Controls.Add(this.new_bt);
            this.groupBox3.Controls.Add(this.next_bt);
            this.groupBox3.Controls.Add(this.previous_bt);
            this.groupBox3.Controls.Add(this.first_bt);
            this.groupBox3.Location = new System.Drawing.Point(547, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 169);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "EDIT";
            // 
            // edit_bt
            // 
            this.edit_bt.BackgroundImage = global::Product_Managment.Properties.Resources.Reclusekc_Pencil_Pencil;
            this.edit_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.edit_bt.Location = new System.Drawing.Point(340, 95);
            this.edit_bt.Name = "edit_bt";
            this.edit_bt.Size = new System.Drawing.Size(75, 53);
            this.edit_bt.TabIndex = 21;
            this.edit_bt.UseVisualStyleBackColor = true;
            this.edit_bt.Click += new System.EventHandler(this.edit_bt_Click);
            // 
            // delete_bt
            // 
            this.delete_bt.BackgroundImage = global::Product_Managment.Properties.Resources.new_57904661;
            this.delete_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete_bt.Location = new System.Drawing.Point(252, 95);
            this.delete_bt.Name = "delete_bt";
            this.delete_bt.Size = new System.Drawing.Size(75, 53);
            this.delete_bt.TabIndex = 19;
            this.delete_bt.UseVisualStyleBackColor = true;
            this.delete_bt.Click += new System.EventHandler(this.delete_bt_Click);
            // 
            // label_position
            // 
            this.label_position.AutoSize = true;
            this.label_position.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_position.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_position.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label_position.Location = new System.Drawing.Point(202, 54);
            this.label_position.Name = "label_position";
            this.label_position.Size = new System.Drawing.Size(0, 17);
            this.label_position.TabIndex = 22;
            // 
            // add_bt
            // 
            this.add_bt.BackgroundImage = global::Product_Managment.Properties.Resources.add;
            this.add_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_bt.Enabled = false;
            this.add_bt.Location = new System.Drawing.Point(106, 95);
            this.add_bt.Name = "add_bt";
            this.add_bt.Size = new System.Drawing.Size(75, 53);
            this.add_bt.TabIndex = 17;
            this.add_bt.Text = "\r\n";
            this.add_bt.UseVisualStyleBackColor = true;
            this.add_bt.Click += new System.EventHandler(this.add_bt_Click);
            // 
            // last_bt
            // 
            this.last_bt.Location = new System.Drawing.Point(340, 51);
            this.last_bt.Name = "last_bt";
            this.last_bt.Size = new System.Drawing.Size(75, 23);
            this.last_bt.TabIndex = 20;
            this.last_bt.Text = ">>||";
            this.last_bt.UseVisualStyleBackColor = true;
            this.last_bt.Click += new System.EventHandler(this.last_bt_Click);
            // 
            // new_bt
            // 
            this.new_bt.BackgroundImage = global::Product_Managment.Properties.Resources._1684_lvG8TtqV5u5GrcbwYk3iyQ;
            this.new_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.new_bt.Location = new System.Drawing.Point(18, 95);
            this.new_bt.Name = "new_bt";
            this.new_bt.Size = new System.Drawing.Size(75, 53);
            this.new_bt.TabIndex = 15;
            this.new_bt.UseVisualStyleBackColor = true;
            this.new_bt.Click += new System.EventHandler(this.new_bt_Click);
            // 
            // next_bt
            // 
            this.next_bt.Location = new System.Drawing.Point(252, 51);
            this.next_bt.Name = "next_bt";
            this.next_bt.Size = new System.Drawing.Size(75, 23);
            this.next_bt.TabIndex = 18;
            this.next_bt.Text = ">>";
            this.next_bt.UseVisualStyleBackColor = true;
            this.next_bt.Click += new System.EventHandler(this.next_bt_Click);
            // 
            // previous_bt
            // 
            this.previous_bt.Location = new System.Drawing.Point(106, 54);
            this.previous_bt.Name = "previous_bt";
            this.previous_bt.Size = new System.Drawing.Size(75, 23);
            this.previous_bt.TabIndex = 16;
            this.previous_bt.Text = "<<";
            this.previous_bt.UseVisualStyleBackColor = true;
            this.previous_bt.Click += new System.EventHandler(this.previous_bt_Click);
            // 
            // first_bt
            // 
            this.first_bt.Location = new System.Drawing.Point(18, 54);
            this.first_bt.Name = "first_bt";
            this.first_bt.Size = new System.Drawing.Size(75, 23);
            this.first_bt.TabIndex = 14;
            this.first_bt.Text = "||<<";
            this.first_bt.UseVisualStyleBackColor = true;
            this.first_bt.Click += new System.EventHandler(this.first_bt_Click);
            // 
            // close_bt
            // 
            this.close_bt.BackgroundImage = global::Product_Managment.Properties.Resources.Oxygen480_actions_dialog_close;
            this.close_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close_bt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.close_bt.Location = new System.Drawing.Point(944, 407);
            this.close_bt.Name = "close_bt";
            this.close_bt.Size = new System.Drawing.Size(41, 38);
            this.close_bt.TabIndex = 8;
            this.close_bt.UseVisualStyleBackColor = true;
            this.close_bt.Click += new System.EventHandler(this.close_bt_Click);
            // 
            // Customer_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.CancelButton = this.close_bt;
            this.ClientSize = new System.Drawing.Size(997, 455);
            this.Controls.Add(this.close_bt);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Customer_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer_Management";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox search_tb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tell_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastname_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstname_bt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button edit_bt;
        private System.Windows.Forms.Button delete_bt;
        private System.Windows.Forms.Label label_position;
        private System.Windows.Forms.Button add_bt;
        private System.Windows.Forms.Button last_bt;
        private System.Windows.Forms.Button new_bt;
        private System.Windows.Forms.Button next_bt;
        private System.Windows.Forms.Button previous_bt;
        private System.Windows.Forms.Button first_bt;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button close_bt;
    }
}