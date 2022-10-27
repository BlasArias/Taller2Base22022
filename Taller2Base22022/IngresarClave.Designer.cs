
namespace Taller2Base22022
{
    partial class IngresarClave
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
            this.txtIngresarClave = new System.Windows.Forms.TextBox();
            this.btnClaveIngresada = new System.Windows.Forms.Button();
            this.btnVolverIngresoClave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar Clave:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIngresarClave
            // 
            this.txtIngresarClave.Location = new System.Drawing.Point(176, 74);
            this.txtIngresarClave.Name = "txtIngresarClave";
            this.txtIngresarClave.Size = new System.Drawing.Size(135, 20);
            this.txtIngresarClave.TabIndex = 1;
            // 
            // btnClaveIngresada
            // 
            this.btnClaveIngresada.Location = new System.Drawing.Point(209, 100);
            this.btnClaveIngresada.Name = "btnClaveIngresada";
            this.btnClaveIngresada.Size = new System.Drawing.Size(75, 23);
            this.btnClaveIngresada.TabIndex = 2;
            this.btnClaveIngresada.Text = "Confirmar";
            this.btnClaveIngresada.UseVisualStyleBackColor = true;
            this.btnClaveIngresada.Click += new System.EventHandler(this.btnClaveIngresada_Click);
            // 
            // btnVolverIngresoClave
            // 
            this.btnVolverIngresoClave.Location = new System.Drawing.Point(12, 145);
            this.btnVolverIngresoClave.Name = "btnVolverIngresoClave";
            this.btnVolverIngresoClave.Size = new System.Drawing.Size(75, 23);
            this.btnVolverIngresoClave.TabIndex = 3;
            this.btnVolverIngresoClave.Text = "Volver";
            this.btnVolverIngresoClave.UseVisualStyleBackColor = true;
            this.btnVolverIngresoClave.Click += new System.EventHandler(this.btnVolverIngresoClave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingresar Clave";
            // 
            // IngresarClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 180);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVolverIngresoClave);
            this.Controls.Add(this.btnClaveIngresada);
            this.Controls.Add(this.txtIngresarClave);
            this.Controls.Add(this.label1);
            this.Name = "IngresarClave";
            this.Text = "IngresarClave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIngresarClave;
        private System.Windows.Forms.Button btnClaveIngresada;
        private System.Windows.Forms.Button btnVolverIngresoClave;
        private System.Windows.Forms.Label label2;
    }
}