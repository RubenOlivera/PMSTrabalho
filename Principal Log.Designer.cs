namespace WindowsFormsApplication2
{
    partial class Principal_Log
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
            this.buttonlogout = new System.Windows.Forms.Button();
            this.buttonNovoEvent = new System.Windows.Forms.Button();
            this.labelalt = new System.Windows.Forms.Label();
            this.comboBoxAltEvent = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ButtumAlterar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonlogout
            // 
            this.buttonlogout.Location = new System.Drawing.Point(241, 12);
            this.buttonlogout.Name = "buttonlogout";
            this.buttonlogout.Size = new System.Drawing.Size(75, 23);
            this.buttonlogout.TabIndex = 0;
            this.buttonlogout.Text = "LogOut";
            this.buttonlogout.UseVisualStyleBackColor = true;
            // 
            // buttonNovoEvent
            // 
            this.buttonNovoEvent.Location = new System.Drawing.Point(32, 77);
            this.buttonNovoEvent.Name = "buttonNovoEvent";
            this.buttonNovoEvent.Size = new System.Drawing.Size(104, 37);
            this.buttonNovoEvent.TabIndex = 1;
            this.buttonNovoEvent.Text = "Novo evento";
            this.buttonNovoEvent.UseVisualStyleBackColor = true;
            // 
            // labelalt
            // 
            this.labelalt.AutoSize = true;
            this.labelalt.Location = new System.Drawing.Point(39, 123);
            this.labelalt.Name = "labelalt";
            this.labelalt.Size = new System.Drawing.Size(76, 13);
            this.labelalt.TabIndex = 2;
            this.labelalt.Text = "Alterar evento:";
            // 
            // comboBoxAltEvent
            // 
            this.comboBoxAltEvent.FormattingEnabled = true;
            this.comboBoxAltEvent.Location = new System.Drawing.Point(121, 120);
            this.comboBoxAltEvent.Name = "comboBoxAltEvent";
            this.comboBoxAltEvent.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAltEvent.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(42, 147);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 95);
            this.listBox1.TabIndex = 4;
            // 
            // ButtumAlterar
            // 
            this.ButtumAlterar.Location = new System.Drawing.Point(241, 248);
            this.ButtumAlterar.Name = "ButtumAlterar";
            this.ButtumAlterar.Size = new System.Drawing.Size(75, 23);
            this.ButtumAlterar.TabIndex = 5;
            this.ButtumAlterar.Text = "Alterar";
            this.ButtumAlterar.UseVisualStyleBackColor = true;
            // 
            // Principal_Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 283);
            this.Controls.Add(this.ButtumAlterar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBoxAltEvent);
            this.Controls.Add(this.labelalt);
            this.Controls.Add(this.buttonNovoEvent);
            this.Controls.Add(this.buttonlogout);
            this.Name = "Principal_Log";
            this.Text = "Principal_Log";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonlogout;
        private System.Windows.Forms.Button buttonNovoEvent;
        private System.Windows.Forms.Label labelalt;
        private System.Windows.Forms.ComboBox comboBoxAltEvent;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ButtumAlterar;
    }
}