﻿
namespace DreamJoy_Calc
{
    partial class Form3
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
            this.buttonPunt = new System.Windows.Forms.Button();
            this.buttonCirkel = new System.Windows.Forms.Button();
            this.buttonCilinder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPunt
            // 
            this.buttonPunt.Location = new System.Drawing.Point(41, 45);
            this.buttonPunt.Name = "buttonPunt";
            this.buttonPunt.Size = new System.Drawing.Size(153, 67);
            this.buttonPunt.TabIndex = 0;
            this.buttonPunt.Text = "Test Punt";
            this.buttonPunt.UseVisualStyleBackColor = true;
            this.buttonPunt.Click += new System.EventHandler(this.buttonPunt_Click);
            // 
            // buttonCirkel
            // 
            this.buttonCirkel.Location = new System.Drawing.Point(41, 159);
            this.buttonCirkel.Name = "buttonCirkel";
            this.buttonCirkel.Size = new System.Drawing.Size(153, 67);
            this.buttonCirkel.TabIndex = 1;
            this.buttonCirkel.Text = "Test Cirkel";
            this.buttonCirkel.UseVisualStyleBackColor = true;
            this.buttonCirkel.Click += new System.EventHandler(this.buttonCirkel_Click);
            // 
            // buttonCilinder
            // 
            this.buttonCilinder.Location = new System.Drawing.Point(41, 274);
            this.buttonCilinder.Name = "buttonCilinder";
            this.buttonCilinder.Size = new System.Drawing.Size(153, 67);
            this.buttonCilinder.TabIndex = 2;
            this.buttonCilinder.Text = "Test Cilinder";
            this.buttonCilinder.UseVisualStyleBackColor = true;
            this.buttonCilinder.Click += new System.EventHandler(this.buttonCilinder_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 397);
            this.Controls.Add(this.buttonCilinder);
            this.Controls.Add(this.buttonCirkel);
            this.Controls.Add(this.buttonPunt);
            this.Name = "Form3";
            this.Text = "Cilinder";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPunt;
        private System.Windows.Forms.Button buttonCirkel;
        private System.Windows.Forms.Button buttonCilinder;
    }
}