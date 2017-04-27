namespace WindowsFormsApplication2
{
    partial class Locais
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonN = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.buttonV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Locais";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonN
            // 
            this.buttonN.Location = new System.Drawing.Point(49, 50);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(109, 47);
            this.buttonN.TabIndex = 1;
            this.buttonN.Text = "Norte";
            this.buttonN.UseVisualStyleBackColor = true;
            this.buttonN.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(49, 103);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(109, 48);
            this.buttonC.TabIndex = 2;
            this.buttonC.Text = "Centro";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonS
            // 
            this.buttonS.Location = new System.Drawing.Point(49, 157);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(109, 45);
            this.buttonS.TabIndex = 3;
            this.buttonS.Text = "Sul";
            this.buttonS.UseVisualStyleBackColor = true;
            // 
            // buttonV
            // 
            this.buttonV.Location = new System.Drawing.Point(16, 226);
            this.buttonV.Name = "buttonV";
            this.buttonV.Size = new System.Drawing.Size(75, 23);
            this.buttonV.TabIndex = 4;
            this.buttonV.Text = "Voltar";
            this.buttonV.UseVisualStyleBackColor = true;
            // 
            // Locais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonV);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonN);
            this.Controls.Add(this.label1);
            this.Name = "Locais";
            this.Text = "Locais";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonN;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Button buttonV;
    }
}