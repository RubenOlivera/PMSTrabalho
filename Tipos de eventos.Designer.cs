namespace SeniorNet_Events
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
            this.SuspendLayout();
            // 
            // buttonCult
            // 
            this.buttonCult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCult.Location = new System.Drawing.Point(40, 102);
            this.buttonCult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCult.Name = "buttonCult";
            this.buttonCult.Size = new System.Drawing.Size(152, 71);
            this.buttonCult.TabIndex = 0;
            this.buttonCult.Text = "Culturais";
            this.buttonCult.UseVisualStyleBackColor = true;
            this.buttonCult.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonMusicais
            // 
            this.buttonMusicais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMusicais.Location = new System.Drawing.Point(40, 197);
            this.buttonMusicais.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonMusicais.Name = "buttonMusicais";
            this.buttonMusicais.Size = new System.Drawing.Size(152, 75);
            this.buttonMusicais.TabIndex = 1;
            this.buttonMusicais.Text = "Musicais";
            this.buttonMusicais.UseVisualStyleBackColor = true;
            // 
            // buttonArt
            // 
            this.buttonArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArt.Location = new System.Drawing.Point(237, 102);
            this.buttonArt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonArt.Name = "buttonArt";
            this.buttonArt.Size = new System.Drawing.Size(164, 71);
            this.buttonArt.TabIndex = 2;
            this.buttonArt.Text = "Arte";
            this.buttonArt.UseVisualStyleBackColor = true;
            // 
            // buttonEspet
            // 
            this.buttonEspet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEspet.Location = new System.Drawing.Point(237, 197);
            this.buttonEspet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEspet.Name = "buttonEspet";
            this.buttonEspet.Size = new System.Drawing.Size(164, 75);
            this.buttonEspet.TabIndex = 3;
            this.buttonEspet.Text = "Espetaculos";
            this.buttonEspet.UseVisualStyleBackColor = true;
            this.buttonEspet.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonB
            // 
            this.buttonB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonB.Location = new System.Drawing.Point(323, 363);
            this.buttonB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(112, 45);
            this.buttonB.TabIndex = 4;
            this.buttonB.Text = "Voltar";
            this.buttonB.UseVisualStyleBackColor = true;
            // 
            // _Tipos_de_eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 435);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonEspet);
            this.Controls.Add(this.buttonArt);
            this.Controls.Add(this.buttonMusicais);
            this.Controls.Add(this.buttonCult);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "_Tipos_de_eventos";
            this.ShowIcon = false;
            this.Text = "TIPO DE EVENTOS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCult;
        private System.Windows.Forms.Button buttonMusicais;
        private System.Windows.Forms.Button buttonArt;
        private System.Windows.Forms.Button buttonEspet;
        private System.Windows.Forms.Button buttonB;
    }
}