
namespace Taller2Base22022
{
    partial class ConsultaDatos
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
            this.btnVolverConsultaDatos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVolverConsultaDatos
            // 
            this.btnVolverConsultaDatos.Location = new System.Drawing.Point(12, 415);
            this.btnVolverConsultaDatos.Name = "btnVolverConsultaDatos";
            this.btnVolverConsultaDatos.Size = new System.Drawing.Size(75, 23);
            this.btnVolverConsultaDatos.TabIndex = 0;
            this.btnVolverConsultaDatos.Text = "Volver";
            this.btnVolverConsultaDatos.UseVisualStyleBackColor = true;
            this.btnVolverConsultaDatos.Click += new System.EventHandler(this.btnVolverConsultaDatos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consulta de Datos Sistema ABC";
            // 
            // ConsultaDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolverConsultaDatos);
            this.Name = "ConsultaDatos";
            this.Text = "ConsultaDatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolverConsultaDatos;
        private System.Windows.Forms.Label label1;
    }
}