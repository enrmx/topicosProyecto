namespace topicosProyecto
{
    partial class FormaDestino
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
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtNombreDestino = new System.Windows.Forms.TextBox();
            this.idCodigo = new System.Windows.Forms.TextBox();
            this.txtIdDestino = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(503, 430);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(366, 31);
            this.txtFecha.TabIndex = 28;
            // 
            // txtNombreDestino
            // 
            this.txtNombreDestino.Location = new System.Drawing.Point(503, 355);
            this.txtNombreDestino.Name = "txtNombreDestino";
            this.txtNombreDestino.Size = new System.Drawing.Size(366, 31);
            this.txtNombreDestino.TabIndex = 27;
            // 
            // idCodigo
            // 
            this.idCodigo.Location = new System.Drawing.Point(503, 280);
            this.idCodigo.Name = "idCodigo";
            this.idCodigo.Size = new System.Drawing.Size(366, 31);
            this.idCodigo.TabIndex = 26;
            // 
            // txtIdDestino
            // 
            this.txtIdDestino.Location = new System.Drawing.Point(503, 216);
            this.txtIdDestino.Name = "txtIdDestino";
            this.txtIdDestino.Size = new System.Drawing.Size(366, 31);
            this.txtIdDestino.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(269, 430);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 25);
            this.label11.TabIndex = 24;
            this.label11.Text = "fecha";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(269, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "codigo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(269, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "nombre destino";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "id destino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 42);
            this.label2.TabIndex = 20;
            this.label2.Text = "destino";
            // 
            // Destino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 718);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtNombreDestino);
            this.Controls.Add(this.idCodigo);
            this.Controls.Add(this.txtIdDestino);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Name = "Destino";
            this.Text = "Destino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtNombreDestino;
        private System.Windows.Forms.TextBox idCodigo;
        private System.Windows.Forms.TextBox txtIdDestino;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
    }
}