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
            this.buttonLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLog.Location = new System.Drawing.Point(551, 15);
            this.buttonLog.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(188, 72);
            this.buttonLog.TabIndex = 0;
            this.buttonLog.Text = "Login";
            this.buttonLog.UseVisualStyleBackColor = true;
            // 
            // buttonRegistar
            // 
            this.buttonRegistar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistar.Location = new System.Drawing.Point(351, 15);
            this.buttonRegistar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonRegistar.Name = "buttonRegistar";
            this.buttonRegistar.Size = new System.Drawing.Size(166, 72);
            this.buttonRegistar.TabIndex = 1;
            this.buttonRegistar.Text = "Registar User";
            this.buttonRegistar.UseVisualStyleBackColor = true;
            // 
            // buttonTipEvent
            // 
            this.buttonTipEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTipEvent.Location = new System.Drawing.Point(56, 58);
            this.buttonTipEvent.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonTipEvent.Name = "buttonTipEvent";
            this.buttonTipEvent.Size = new System.Drawing.Size(216, 97);
            this.buttonTipEvent.TabIndex = 2;
            this.buttonTipEvent.Text = "Tipos de Eventos";
            this.buttonTipEvent.UseVisualStyleBackColor = true;
            // 
            // buttonLoc
            // 
            this.buttonLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoc.Location = new System.Drawing.Point(56, 166);
            this.buttonLoc.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonLoc.Name = "buttonLoc";
            this.buttonLoc.Size = new System.Drawing.Size(216, 97);
            this.buttonLoc.TabIndex = 3;
            this.buttonLoc.Text = "Regiões";
            this.buttonLoc.UseVisualStyleBackColor = true;
            // 
            // buttonData
            // 
            this.buttonData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonData.Location = new System.Drawing.Point(56, 283);
            this.buttonData.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonData.Name = "buttonData";
            this.buttonData.Size = new System.Drawing.Size(216, 97);
            this.buttonData.TabIndex = 4;
            this.buttonData.Text = "Data";
            this.buttonData.UseVisualStyleBackColor = true;
            // 
            // buttonTodos
            // 
            this.buttonTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTodos.Location = new System.Drawing.Point(56, 404);
            this.buttonTodos.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonTodos.Name = "buttonTodos";
            this.buttonTodos.Size = new System.Drawing.Size(216, 97);
            this.buttonTodos.TabIndex = 5;
            this.buttonTodos.Text = "Todos os eventos";
            this.buttonTodos.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(375, 150);
            this.listBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(363, 290);
            this.listBox1.TabIndex = 6;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 535);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonTodos);
            this.Controls.Add(this.buttonData);
            this.Controls.Add(this.buttonLoc);
            this.Controls.Add(this.buttonTipEvent);
            this.Controls.Add(this.buttonRegistar);
            this.Controls.Add(this.buttonLog);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.ShowIcon = false;
            this.Text = "GESTÃO EVENTOS";
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

