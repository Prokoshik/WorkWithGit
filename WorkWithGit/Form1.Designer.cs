﻿namespace WorkWithGit
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxTricks = new System.Windows.Forms.CheckBox();
            this.labelKorda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Click Me";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(57, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "I am label :3";
            // 
            // checkBoxTricks
            // 
            this.checkBoxTricks.AutoSize = true;
            this.checkBoxTricks.Location = new System.Drawing.Point(12, 12);
            this.checkBoxTricks.Name = "checkBoxTricks";
            this.checkBoxTricks.Size = new System.Drawing.Size(111, 17);
            this.checkBoxTricks.TabIndex = 2;
            this.checkBoxTricks.Text = "Спрятать кнопку";
            this.checkBoxTricks.UseVisualStyleBackColor = true;
            this.checkBoxTricks.CheckedChanged += new System.EventHandler(this.checkBoxTricks_CheckedChanged);
            // 
            // labelKorda
            // 
            this.labelKorda.AutoSize = true;
            this.labelKorda.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKorda.ForeColor = System.Drawing.Color.Red;
            this.labelKorda.Location = new System.Drawing.Point(337, 296);
            this.labelKorda.Name = "labelKorda";
            this.labelKorda.Size = new System.Drawing.Size(172, 25);
            this.labelKorda.TabIndex = 3;
            this.labelKorda.Text = "Корда  апездал!!!!";
            this.labelKorda.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 356);
            this.Controls.Add(this.labelKorda);
            this.Controls.Add(this.checkBoxTricks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Первый совместный проект ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxTricks;
        private System.Windows.Forms.Label labelKorda;
    }
}

