﻿namespace joao
{
    partial class Form2
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
            Cadastro = new Button();
            SuspendLayout();
            // 
            // Cadastro
            // 
            Cadastro.Location = new Point(241, 139);
            Cadastro.Name = "Cadastro";
            Cadastro.Size = new Size(276, 128);
            Cadastro.TabIndex = 0;
            Cadastro.Text = "Cadastro";
            Cadastro.UseVisualStyleBackColor = true;
            Cadastro.Click += Cadastro_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Cadastro);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button Cadastro;
    }
}