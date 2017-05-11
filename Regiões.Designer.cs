namespace SeniorNet_Events
{
    partial class Regioes
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
            this.lblRegioes = new System.Windows.Forms.Label();
            this.buttonN = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.buttonV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRegioes
            // 
            this.lblRegioes.AutoSize = true;
            this.lblRegioes.Location = new System.Drawing.Point(24, 31);
            this.lblRegioes.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRegioes.Name = "lblRegioes";
            this.lblRegioes.Size = new System.Drawing.Size(0, 22);
            this.lblRegioes.TabIndex = 0;
            this.lblRegioes.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonN
            // 
            this.buttonN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonN.Location = new System.Drawing.Point(90, 69);
            this.buttonN.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(200, 79);
            this.buttonN.TabIndex = 1;
            this.buttonN.Text = "Norte";
            this.buttonN.UseVisualStyleBackColor = true;
            this.buttonN.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonC
            // 
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.Location = new System.Drawing.Point(90, 174);
            this.buttonC.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(200, 81);
            this.buttonC.TabIndex = 2;
            this.buttonC.Text = "Centro";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonS
            // 
            this.buttonS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonS.Location = new System.Drawing.Point(90, 282);
            this.buttonS.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(200, 76);
            this.buttonS.TabIndex = 3;
            this.buttonS.Text = "Sul";
            this.buttonS.UseVisualStyleBackColor = true;
            // 
            // buttonV
            // 
            this.buttonV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonV.Location = new System.Drawing.Point(354, 388);
            this.buttonV.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonV.Name = "buttonV";
            this.buttonV.Size = new System.Drawing.Size(137, 39);
            this.buttonV.TabIndex = 4;
            this.buttonV.Text = "Voltar";
            this.buttonV.UseVisualStyleBackColor = true;
            // 
            // Regioes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 442);
            this.Controls.Add(this.buttonV);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonN);
            this.Controls.Add(this.lblRegioes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Regioes";
            this.ShowIcon = false;
            this.Text = "REGIÕES";
            this.Load += new System.EventHandler(this.Regioes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegioes;
        private System.Windows.Forms.Button buttonN;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Button buttonV;
    }
}