namespace WorkWithGit
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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 182);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Click Me";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(86, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "I am label :3";
            // 
            // checkBoxTricks
            // 
            this.checkBoxTricks.AutoSize = true;
            this.checkBoxTricks.Location = new System.Drawing.Point(12, 12);
            this.checkBoxTricks.Name = "checkBoxTricks";
            this.checkBoxTricks.Size = new System.Drawing.Size(163, 24);
            this.checkBoxTricks.TabIndex = 2;
            this.checkBoxTricks.Text = "Спрятать кнопку";
            this.checkBoxTricks.UseVisualStyleBackColor = true;
            this.checkBoxTricks.CheckedChanged += new System.EventHandler(this.checkBoxTricks_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 356);
            this.Controls.Add(this.checkBoxTricks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Первый совместный проект ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxTricks;
    }
}

