﻿namespace SeniorNet_Events
{
    partial class _Tipos_de_eventos
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
            this.buttonCult = new System.Windows.Forms.Button();
            this.buttonMusicais = new System.Windows.Forms.Button();
            this.buttonArt = new System.Windows.Forms.Button();
            this.buttonEspet = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCult
            // 
            this.buttonCult.Location = new System.Drawing.Point(27, 66);
            this.buttonCult.Name = "buttonCult";
            this.buttonCult.Size = new System.Drawing.Size(101, 46);
            this.buttonCult.TabIndex = 0;
            this.buttonCult.Text = "Culturais";
            this.buttonCult.UseVisualStyleBackColor = true;
            this.buttonCult.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonMusicais
            // 
            this.buttonMusicais.Location = new System.Drawing.Point(27, 128);
            this.buttonMusicais.Name = "buttonMusicais";
            this.buttonMusicais.Size = new System.Drawing.Size(101, 49);
            this.buttonMusicais.TabIndex = 1;
            this.buttonMusicais.Text = "Musicais";
            this.buttonMusicais.UseVisualStyleBackColor = true;
            // 
            // buttonArt
            // 
            this.buttonArt.Location = new System.Drawing.Point(158, 66);
            this.buttonArt.Name = "buttonArt";
            this.buttonArt.Size = new System.Drawing.Size(109, 46);
            this.buttonArt.TabIndex = 2;
            this.buttonArt.Text = "Arte";
            this.buttonArt.UseVisualStyleBackColor = true;
            // 
            // buttonEspet
            // 
            this.buttonEspet.Location = new System.Drawing.Point(158, 128);
            this.buttonEspet.Name = "buttonEspet";
            this.buttonEspet.Size = new System.Drawing.Size(109, 49);
            this.buttonEspet.TabIndex = 3;
            this.buttonEspet.Text = "Espetaculos";
            this.buttonEspet.UseVisualStyleBackColor = true;
            this.buttonEspet.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonB
            // 
            this.buttonB.Location = new System.Drawing.Point(27, 242);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(75, 29);
            this.buttonB.TabIndex = 4;
            this.buttonB.Text = "Voltar";
            this.buttonB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tipos de Eventos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // _Tipos_de_eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 283);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonEspet);
            this.Controls.Add(this.buttonArt);
            this.Controls.Add(this.buttonMusicais);
            this.Controls.Add(this.buttonCult);
            this.Name = "_Tipos_de_eventos";
            this.Text = "_Tipos_de_eventos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCult;
        private System.Windows.Forms.Button buttonMusicais;
        private System.Windows.Forms.Button buttonArt;
        private System.Windows.Forms.Button buttonEspet;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Label label1;
    }
}