﻿namespace Product_Managment.presentation_Access
{
    partial class Backup_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Backup_frm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.browes_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.save_path = new System.Windows.Forms.TextBox();
            this.backup_bt = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.close_bt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.browes_bt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.save_path);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // browes_bt
            // 
            this.browes_bt.Location = new System.Drawing.Point(569, 68);
            this.browes_bt.Name = "browes_bt";
            this.browes_bt.Size = new System.Drawing.Size(75, 28);
            this.browes_bt.TabIndex = 2;
            this.browes_bt.Text = "....";
            this.browes_bt.UseVisualStyleBackColor = true;
            this.browes_bt.Click += new System.EventHandler(this.browes_bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "where you want to backup";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // save_path
            // 
            this.save_path.Location = new System.Drawing.Point(6, 68);
            this.save_path.Name = "save_path";
            this.save_path.ReadOnly = true;
            this.save_path.Size = new System.Drawing.Size(546, 28);
            this.save_path.TabIndex = 0;
            // 
            // backup_bt
            // 
            this.backup_bt.Font = new System.Drawing.Font("Tahoma", 12F);
            this.backup_bt.Location = new System.Drawing.Point(12, 156);
            this.backup_bt.Name = "backup_bt";
            this.backup_bt.Size = new System.Drawing.Size(75, 35);
            this.backup_bt.TabIndex = 4;
            this.backup_bt.Text = "Backup";
            this.backup_bt.UseVisualStyleBackColor = true;
            this.backup_bt.Click += new System.EventHandler(this.backup_bt_Click);
            // 
            // close_bt
            // 
            this.close_bt.BackgroundImage = global::Product_Managment.Properties.Resources.Oxygen480_actions_dialog_close;
            this.close_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close_bt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.close_bt.Location = new System.Drawing.Point(93, 156);
            this.close_bt.Name = "close_bt";
            this.close_bt.Size = new System.Drawing.Size(36, 35);
            this.close_bt.TabIndex = 8;
            this.close_bt.UseVisualStyleBackColor = true;
            this.close_bt.Click += new System.EventHandler(this.close_bt_Click);
            // 
            // Backup_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CancelButton = this.close_bt;
            this.ClientSize = new System.Drawing.Size(703, 197);
            this.Controls.Add(this.close_bt);
            this.Controls.Add(this.backup_bt);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Backup_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox save_path;
        private System.Windows.Forms.Button browes_bt;
        private System.Windows.Forms.Button backup_bt;
        private System.Windows.Forms.Button close_bt;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}