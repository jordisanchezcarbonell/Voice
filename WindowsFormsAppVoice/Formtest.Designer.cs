namespace WindowsFormsAppVoice
{
    partial class Formtest
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxinput = new System.Windows.Forms.TextBox();
            this.textBoxoutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelestado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxinput
            // 
            this.textBoxinput.Location = new System.Drawing.Point(49, 70);
            this.textBoxinput.Multiline = true;
            this.textBoxinput.Name = "textBoxinput";
            this.textBoxinput.Size = new System.Drawing.Size(167, 189);
            this.textBoxinput.TabIndex = 0;
            // 
            // textBoxoutput
            // 
            this.textBoxoutput.Location = new System.Drawing.Point(402, 70);
            this.textBoxoutput.Multiline = true;
            this.textBoxoutput.Name = "textBoxoutput";
            this.textBoxoutput.Size = new System.Drawing.Size(167, 189);
            this.textBoxoutput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
            this.label1.Location = new System.Drawing.Point(110, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "INPUT";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
            this.label2.Location = new System.Drawing.Point(437, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "OUTPUT";
            // 
            // labelestado
            // 
            this.labelestado.AutoSize = true;
            this.labelestado.Location = new System.Drawing.Point(49, 323);
            this.labelestado.Name = "labelestado";
            this.labelestado.Size = new System.Drawing.Size(62, 13);
            this.labelestado.TabIndex = 4;
            this.labelestado.Text = "Estado: ON";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelestado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxoutput);
            this.Controls.Add(this.textBoxinput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Assistente de voz Jordi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxinput;
        private System.Windows.Forms.TextBox textBoxoutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelestado;
    }
}

