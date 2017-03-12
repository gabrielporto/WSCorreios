namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.maskCep = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maskCep
            // 
            this.maskCep.Location = new System.Drawing.Point(85, 10);
            this.maskCep.Mask = "00000-000";
            this.maskCep.Name = "maskCep";
            this.maskCep.Size = new System.Drawing.Size(70, 20);
            this.maskCep.TabIndex = 0;
            this.maskCep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskCep_KeyDown);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(85, 36);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(70, 20);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 61);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.maskCep);
            this.Name = "Form1";
            this.Text = "Buscar Endereço";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskCep;
        private System.Windows.Forms.Button btnBuscar;
    }
}

