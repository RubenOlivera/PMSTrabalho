namespace SeniorNet_Events
{
    partial class Principal
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
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonRegistar = new System.Windows.Forms.Button();
            this.buttonTipEvent = new System.Windows.Forms.Button();
            this.buttonLoc = new System.Windows.Forms.Button();
            this.buttonData = new System.Windows.Forms.Button();
            this.buttonTodos = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonLog
            // 
            this.buttonLog.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLog.Location = new System.Drawing.Point(774, 1);
            this.buttonLog.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(88, 34);
            this.buttonLog.TabIndex = 0;
            this.buttonLog.Text = "Login";
            this.buttonLog.UseVisualStyleBackColor = false;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // buttonRegistar
            // 
            this.buttonRegistar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRegistar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRegistar.Location = new System.Drawing.Point(658, 2);
            this.buttonRegistar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonRegistar.Name = "buttonRegistar";
            this.buttonRegistar.Size = new System.Drawing.Size(121, 35);
            this.buttonRegistar.TabIndex = 1;
            this.buttonRegistar.Text = "Novo User";
            this.buttonRegistar.UseVisualStyleBackColor = true;
            this.buttonRegistar.Click += new System.EventHandler(this.buttonRegistar_Click);
            // 
            // buttonTipEvent
            // 
            this.buttonTipEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTipEvent.Location = new System.Drawing.Point(56, 15);
            this.buttonTipEvent.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonTipEvent.Name = "buttonTipEvent";
            this.buttonTipEvent.Size = new System.Drawing.Size(216, 114);
            this.buttonTipEvent.TabIndex = 2;
            this.buttonTipEvent.Text = "Tipos de Eventos";
            this.buttonTipEvent.UseVisualStyleBackColor = true;
            // 
            // buttonLoc
            // 
            this.buttonLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoc.Location = new System.Drawing.Point(56, 152);
            this.buttonLoc.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonLoc.Name = "buttonLoc";
            this.buttonLoc.Size = new System.Drawing.Size(216, 110);
            this.buttonLoc.TabIndex = 3;
            this.buttonLoc.Text = "Regiões";
            this.buttonLoc.UseVisualStyleBackColor = true;
            // 
            // buttonData
            // 
            this.buttonData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonData.Location = new System.Drawing.Point(56, 291);
            this.buttonData.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonData.Name = "buttonData";
            this.buttonData.Size = new System.Drawing.Size(216, 109);
            this.buttonData.TabIndex = 4;
            this.buttonData.Text = "Data";
            this.buttonData.UseVisualStyleBackColor = true;
            // 
            // buttonTodos
            // 
            this.buttonTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTodos.Location = new System.Drawing.Point(56, 424);
            this.buttonTodos.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonTodos.Name = "buttonTodos";
            this.buttonTodos.Size = new System.Drawing.Size(216, 106);
            this.buttonTodos.TabIndex = 5;
            this.buttonTodos.Text = "Todos os eventos";
            this.buttonTodos.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(334, 106);
            this.listBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(495, 356);
            this.listBox1.TabIndex = 6;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(861, 545);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonTodos);
            this.Controls.Add(this.buttonData);
            this.Controls.Add(this.buttonLoc);
            this.Controls.Add(this.buttonTipEvent);
            this.Controls.Add(this.buttonRegistar);
            this.Controls.Add(this.buttonLog);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GESTÃO EVENTOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Button buttonRegistar;
        private System.Windows.Forms.Button buttonTipEvent;
        private System.Windows.Forms.Button buttonLoc;
        private System.Windows.Forms.Button buttonData;
        private System.Windows.Forms.Button buttonTodos;
        private System.Windows.Forms.ListBox listBox1;
    }
}

