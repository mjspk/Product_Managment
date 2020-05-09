namespace Product_Managment.presentation_Access
{
    partial class Categories_Management_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories_Management_Frm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_position = new System.Windows.Forms.Label();
            this.last_bt = new System.Windows.Forms.Button();
            this.next_bt = new System.Windows.Forms.Button();
            this.previous_bt = new System.Windows.Forms.Button();
            this.first_bt = new System.Windows.Forms.Button();
            this.description_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.close_bt = new System.Windows.Forms.Button();
            this.print_bt = new System.Windows.Forms.Button();
            this.edit_bt = new System.Windows.Forms.Button();
            this.delete_bt = new System.Windows.Forms.Button();
            this.save_pdf_bt = new System.Windows.Forms.Button();
            this.save_excel_bt = new System.Windows.Forms.Button();
            this.print_all_bt = new System.Windows.Forms.Button();
            this.add_bt = new System.Windows.Forms.Button();
            this.new_bt = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_position);
            this.groupBox1.Controls.Add(this.last_bt);
            this.groupBox1.Controls.Add(this.next_bt);
            this.groupBox1.Controls.Add(this.previous_bt);
            this.groupBox1.Controls.Add(this.first_bt);
            this.groupBox1.Controls.Add(this.description_tb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.id_tb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category Info";
            // 
            // label_position
            // 
            this.label_position.AutoSize = true;
            this.label_position.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label_position.Location = new System.Drawing.Point(368, 134);
            this.label_position.Name = "label_position";
            this.label_position.Size = new System.Drawing.Size(0, 17);
            this.label_position.TabIndex = 8;
            // 
            // last_bt
            // 
            this.last_bt.Location = new System.Drawing.Point(506, 131);
            this.last_bt.Name = "last_bt";
            this.last_bt.Size = new System.Drawing.Size(75, 23);
            this.last_bt.TabIndex = 7;
            this.last_bt.Text = ">>||";
            this.last_bt.UseVisualStyleBackColor = true;
            this.last_bt.Click += new System.EventHandler(this.last_bt_Click);
            // 
            // next_bt
            // 
            this.next_bt.Location = new System.Drawing.Point(410, 131);
            this.next_bt.Name = "next_bt";
            this.next_bt.Size = new System.Drawing.Size(75, 23);
            this.next_bt.TabIndex = 6;
            this.next_bt.Text = ">>";
            this.next_bt.UseVisualStyleBackColor = true;
            this.next_bt.Click += new System.EventHandler(this.next_bt_Click);
            // 
            // previous_bt
            // 
            this.previous_bt.Location = new System.Drawing.Point(264, 131);
            this.previous_bt.Name = "previous_bt";
            this.previous_bt.Size = new System.Drawing.Size(75, 23);
            this.previous_bt.TabIndex = 5;
            this.previous_bt.Text = "<<";
            this.previous_bt.UseVisualStyleBackColor = true;
            this.previous_bt.Click += new System.EventHandler(this.previous_bt_Click);
            // 
            // first_bt
            // 
            this.first_bt.Location = new System.Drawing.Point(168, 131);
            this.first_bt.Name = "first_bt";
            this.first_bt.Size = new System.Drawing.Size(75, 23);
            this.first_bt.TabIndex = 4;
            this.first_bt.Text = "||<<";
            this.first_bt.UseVisualStyleBackColor = true;
            this.first_bt.Click += new System.EventHandler(this.first_bt_Click);
            // 
            // description_tb
            // 
            this.description_tb.Location = new System.Drawing.Point(171, 53);
            this.description_tb.Multiline = true;
            this.description_tb.Name = "description_tb";
            this.description_tb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.description_tb.Size = new System.Drawing.Size(412, 56);
            this.description_tb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category Description :";
            // 
            // id_tb
            // 
            this.id_tb.Location = new System.Drawing.Point(171, 27);
            this.id_tb.Name = "id_tb";
            this.id_tb.ReadOnly = true;
            this.id_tb.Size = new System.Drawing.Size(412, 24);
            this.id_tb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category ID :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.close_bt);
            this.groupBox2.Controls.Add(this.print_bt);
            this.groupBox2.Controls.Add(this.edit_bt);
            this.groupBox2.Controls.Add(this.delete_bt);
            this.groupBox2.Controls.Add(this.save_pdf_bt);
            this.groupBox2.Controls.Add(this.save_excel_bt);
            this.groupBox2.Controls.Add(this.print_all_bt);
            this.groupBox2.Controls.Add(this.add_bt);
            this.groupBox2.Controls.Add(this.new_bt);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox2.Location = new System.Drawing.Point(12, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(606, 79);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Processes";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // close_bt
            // 
            this.close_bt.BackgroundImage = global::Product_Managment.Properties.Resources.Oxygen480_actions_dialog_close;
            this.close_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close_bt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.close_bt.Location = new System.Drawing.Point(544, 18);
            this.close_bt.Name = "close_bt";
            this.close_bt.Size = new System.Drawing.Size(56, 49);
            this.close_bt.TabIndex = 17;
            this.close_bt.UseVisualStyleBackColor = true;
            this.close_bt.Click += new System.EventHandler(this.close_bt_Click);
            // 
            // print_bt
            // 
            this.print_bt.BackgroundImage = global::Product_Managment.Properties.Resources.x;
            this.print_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.print_bt.Location = new System.Drawing.Point(409, 18);
            this.print_bt.Name = "print_bt";
            this.print_bt.Size = new System.Drawing.Size(59, 51);
            this.print_bt.TabIndex = 16;
            this.print_bt.UseVisualStyleBackColor = true;
            this.print_bt.Click += new System.EventHandler(this.print_bt_Click_1);
            // 
            // edit_bt
            // 
            this.edit_bt.BackgroundImage = global::Product_Managment.Properties.Resources.Reclusekc_Pencil_Pencil;
            this.edit_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.edit_bt.Location = new System.Drawing.Point(203, 19);
            this.edit_bt.Name = "edit_bt";
            this.edit_bt.Size = new System.Drawing.Size(61, 52);
            this.edit_bt.TabIndex = 15;
            this.edit_bt.UseVisualStyleBackColor = true;
            this.edit_bt.Click += new System.EventHandler(this.edit_bt_Click_1);
            // 
            // delete_bt
            // 
            this.delete_bt.BackgroundImage = global::Product_Managment.Properties.Resources.new_5790466;
            this.delete_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete_bt.Location = new System.Drawing.Point(139, 19);
            this.delete_bt.Name = "delete_bt";
            this.delete_bt.Size = new System.Drawing.Size(58, 52);
            this.delete_bt.TabIndex = 14;
            this.delete_bt.UseVisualStyleBackColor = true;
            this.delete_bt.Click += new System.EventHandler(this.delete_bt_Click_1);
            // 
            // save_pdf_bt
            // 
            this.save_pdf_bt.BackgroundImage = global::Product_Managment.Properties.Resources.pdf_icon;
            this.save_pdf_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save_pdf_bt.Location = new System.Drawing.Point(270, 18);
            this.save_pdf_bt.Name = "save_pdf_bt";
            this.save_pdf_bt.Size = new System.Drawing.Size(67, 52);
            this.save_pdf_bt.TabIndex = 13;
            this.save_pdf_bt.UseVisualStyleBackColor = true;
            this.save_pdf_bt.Click += new System.EventHandler(this.save_pdf_bt_Click);
            // 
            // save_excel_bt
            // 
            this.save_excel_bt.BackgroundImage = global::Product_Managment.Properties.Resources.Excel_Icon;
            this.save_excel_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save_excel_bt.Location = new System.Drawing.Point(343, 18);
            this.save_excel_bt.Name = "save_excel_bt";
            this.save_excel_bt.Size = new System.Drawing.Size(60, 51);
            this.save_excel_bt.TabIndex = 12;
            this.save_excel_bt.UseVisualStyleBackColor = true;
            this.save_excel_bt.Click += new System.EventHandler(this.save_excel_bt_Click);
            // 
            // print_all_bt
            // 
            this.print_all_bt.BackgroundImage = global::Product_Managment.Properties.Resources.x;
            this.print_all_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.print_all_bt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.print_all_bt.Location = new System.Drawing.Point(474, 18);
            this.print_all_bt.Name = "print_all_bt";
            this.print_all_bt.Size = new System.Drawing.Size(61, 51);
            this.print_all_bt.TabIndex = 11;
            this.print_all_bt.Text = "ALL";
            this.print_all_bt.UseVisualStyleBackColor = true;
            this.print_all_bt.Click += new System.EventHandler(this.print_all_bt_Click);
            // 
            // add_bt
            // 
            this.add_bt.BackgroundImage = global::Product_Managment.Properties.Resources.add;
            this.add_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_bt.Location = new System.Drawing.Point(71, 20);
            this.add_bt.Name = "add_bt";
            this.add_bt.Size = new System.Drawing.Size(62, 51);
            this.add_bt.TabIndex = 7;
            this.add_bt.UseVisualStyleBackColor = true;
            this.add_bt.Click += new System.EventHandler(this.add_bt_Click);
            // 
            // new_bt
            // 
            this.new_bt.BackgroundImage = global::Product_Managment.Properties.Resources._1684_lvG8TtqV5u5GrcbwYk3iyQ;
            this.new_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.new_bt.Location = new System.Drawing.Point(5, 20);
            this.new_bt.Name = "new_bt";
            this.new_bt.Size = new System.Drawing.Size(60, 51);
            this.new_bt.TabIndex = 6;
            this.new_bt.UseVisualStyleBackColor = true;
            this.new_bt.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox3.Location = new System.Drawing.Point(12, 284);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(606, 204);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Categories List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(594, 179);
            this.dataGridView1.TabIndex = 0;
            // 
            // Categories_Management_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.CancelButton = this.close_bt;
            this.ClientSize = new System.Drawing.Size(630, 500);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Categories_Management_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Categories Management";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_position;
        private System.Windows.Forms.Button last_bt;
        private System.Windows.Forms.Button next_bt;
        private System.Windows.Forms.Button previous_bt;
        private System.Windows.Forms.Button first_bt;
        private System.Windows.Forms.TextBox description_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button save_pdf_bt;
        private System.Windows.Forms.Button save_excel_bt;
        private System.Windows.Forms.Button print_all_bt;
        private System.Windows.Forms.Button add_bt;
        private System.Windows.Forms.Button new_bt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button print_bt;
        private System.Windows.Forms.Button edit_bt;
        private System.Windows.Forms.Button delete_bt;
        private System.Windows.Forms.Button close_bt;
    }
}