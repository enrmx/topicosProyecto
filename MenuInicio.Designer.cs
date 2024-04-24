namespace topicosProyecto
{
    partial class MenuInicio
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
            this.btnViajes = new System.Windows.Forms.Button();
            this.btnViajeros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViajes
            // 
            this.btnViajes.Location = new System.Drawing.Point(211, 194);
            this.btnViajes.Name = "btnViajes";
            this.btnViajes.Size = new System.Drawing.Size(353, 319);
            this.btnViajes.TabIndex = 0;
            this.btnViajes.Text = "Viajes";
            this.btnViajes.UseVisualStyleBackColor = true;
            this.btnViajes.Click += new System.EventHandler(this.btnViajes_Click);
            // 
            // btnViajeros
            // 
            this.btnViajeros.Location = new System.Drawing.Point(837, 194);
            this.btnViajeros.Name = "btnViajeros";
            this.btnViajeros.Size = new System.Drawing.Size(353, 319);
            this.btnViajeros.TabIndex = 1;
            this.btnViajeros.Text = "Viajeros";
            this.btnViajeros.UseVisualStyleBackColor = true;
            this.btnViajeros.Click += new System.EventHandler(this.btnViajeros_Click);
            // 
            // MenuInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 746);
            this.Controls.Add(this.btnViajeros);
            this.Controls.Add(this.btnViajes);
            this.Name = "MenuInicio";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViajes;
        private System.Windows.Forms.Button btnViajeros;
    }
}

