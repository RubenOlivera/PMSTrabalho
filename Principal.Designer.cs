namespace WindowsFormsApplication2
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
            this.buttonLog.Location = new System.Drawing.Point(325, 12);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(75, 23);
            this.buttonLog.TabIndex = 0;
            this.buttonLog.Text = "Log in";
            this.buttonLog.UseVisualStyleBackColor = true;
            // 
            // buttonRegistar
            // 
            this.buttonRegistar.Location = new System.Drawing.Point(244, 12);
            this.buttonRegistar.Name = "buttonRegistar";
            this.buttonRegistar.Size = new System.Drawing.Size(75, 23);
            this.buttonRegistar.TabIndex = 1;
            this.buttonRegistar.Text = "Registar";
            this.buttonRegistar.UseVisualStyleBackColor = true;
            // 
            // buttonTipEvent
            // 
            this.buttonTipEvent.Location = new System.Drawing.Point(41, 143);
            this.buttonTipEvent.Name = "buttonTipEvent";
            this.buttonTipEvent.Size = new System.Drawing.Size(118, 23);
            this.buttonTipEvent.TabIndex = 2;
            this.buttonTipEvent.Text = "Tipos de Eventos";
            this.buttonTipEvent.UseVisualStyleBackColor = true;
            // 
            // buttonLoc
            // 
            this.buttonLoc.Location = new System.Drawing.Point(41, 183);
            this.buttonLoc.Name = "buttonLoc";
            this.buttonLoc.Size = new System.Drawing.Size(118, 23);
            this.buttonLoc.TabIndex = 3;
            this.buttonLoc.Text = "Locais";
            this.buttonLoc.UseVisualStyleBackColor = true;
            // 
            // buttonData
            // 
            this.buttonData.Location = new System.Drawing.Point(41, 225);
            this.buttonData.Name = "buttonData";
            this.buttonData.Size = new System.Drawing.Size(118, 23);
            this.buttonData.TabIndex = 4;
            this.buttonData.Text = "Data";
            this.buttonData.UseVisualStyleBackColor = true;
            // 
            // buttonTodos
            // 
            this.buttonTodos.Location = new System.Drawing.Point(41, 264);
            this.buttonTodos.Name = "buttonTodos";
            this.buttonTodos.Size = new System.Drawing.Size(118, 23);
            this.buttonTodos.TabIndex = 5;
            this.buttonTodos.Text = "Todos os eventos";
            this.buttonTodos.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(186, 114);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 173);
            this.listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 316);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonTodos);
            this.Controls.Add(this.buttonData);
            this.Controls.Add(this.buttonLoc);
            this.Controls.Add(this.buttonTipEvent);
            this.Controls.Add(this.buttonRegistar);
            this.Controls.Add(this.buttonLog);
            this.Name = "Form1";
            this.Text = "Form1";
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

