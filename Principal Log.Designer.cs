namespace SeniorNet_Events
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
            this.buttonlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogout.Location = new System.Drawing.Point(558, 27);
            this.buttonlogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonlogout.Name = "buttonlogout";
            this.buttonlogout.Location = new System.Drawing.Point(241, 21);
            this.buttonlogout.Name = "buttonlogout";
            this.buttonlogout.Size = new System.Drawing.Size(131, 50);
            this.buttonlogout.TabIndex = 0;
            this.buttonlogout.Text = "LogOut";
            this.buttonlogout.UseVisualStyleBackColor = true;
            this.buttonlogout.Click += new System.EventHandler(this.buttonlogout_Click);
            // 
            // buttonNovoEvent
            // 
            this.buttonNovoEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNovoEvent.Location = new System.Drawing.Point(49, 69);
            this.buttonNovoEvent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNovoEvent.Location = new System.Drawing.Point(32, 77);
            this.buttonNovoEvent.Name = "buttonNovoEvent";
            this.buttonNovoEvent.Size = new System.Drawing.Size(156, 75);
            this.buttonNovoEvent.TabIndex = 1;
            this.buttonNovoEvent.Text = "Novo evento";
            this.buttonNovoEvent.UseVisualStyleBackColor = true;
            this.buttonNovoEvent.Click += new System.EventHandler(this.buttonNovoEvent_Click);
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
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(62, 234);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Location = new System.Drawing.Point(42, 147);
            this.listBox1.Name = "listBox1";
<<<<<<< .mine
            this.listBox1.Size = new System.Drawing.Size(200, 95);
=======
            this.listBox1.Size = new System.Drawing.Size(641, 124);
>>>>>>> .theirs
            this.listBox1.TabIndex = 4;
            // 
            // ButtumAlterar
            // 
            this.ButtumAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtumAlterar.Location = new System.Drawing.Point(581, 386);
            this.ButtumAlterar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtumAlterar.Location = new System.Drawing.Point(241, 248);
            this.ButtumAlterar.Name = "ButtumAlterar";
            this.ButtumAlterar.Size = new System.Drawing.Size(143, 59);
            this.ButtumAlterar.TabIndex = 5;
            this.ButtumAlterar.Text = "Alterar";
            this.ButtumAlterar.UseVisualStyleBackColor = true;
            this.ButtumAlterar.Click += new System.EventHandler(this.ButtumAlterar_Click);
            // 
            // Principal_Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< .mine
            this.ClientSize = new System.Drawing.Size(328, 283);
=======
            this.ClientSize = new System.Drawing.Size(737, 488);
>>>>>>> .theirs
            this.Controls.Add(this.ButtumAlterar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBoxAltEvent);
            this.Controls.Add(this.labelalt);
            this.Controls.Add(this.buttonNovoEvent);
            this.Controls.Add(this.buttonlogout);
            this.MinimizeBox = false;
            this.Name = "Principal_Log";
            this.ShowIcon = false;
            this.Text = "GESTÃO EVENTOS";
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