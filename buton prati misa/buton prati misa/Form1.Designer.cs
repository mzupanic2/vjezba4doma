﻿namespace buton_prati_misa
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
            this.btnPrati = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrati
            // 
            this.btnPrati.Location = new System.Drawing.Point(94, 86);
            this.btnPrati.Name = "btnPrati";
            this.btnPrati.Size = new System.Drawing.Size(75, 23);
            this.btnPrati.TabIndex = 0;
            this.btnPrati.Text = "Pratim te ;)";
            this.btnPrati.UseVisualStyleBackColor = true;
            this.btnPrati.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnPrati_MouseClick);
            this.btnPrati.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPrati_MouseDown);
            this.btnPrati.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnPrati_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnPrati);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrati;
    }
}

