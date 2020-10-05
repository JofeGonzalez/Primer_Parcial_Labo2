namespace GonzalezJoseFormKwikEMart
{
    partial class VerificacionForm
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
            this.LogInBtn = new System.Windows.Forms.Button();
            this.DniEmpleadoVerificar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreVendedorLbl = new System.Windows.Forms.Label();
            this.ApellidoVendedorLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogInBtn
            // 
            this.LogInBtn.BackColor = System.Drawing.Color.Orange;
            this.LogInBtn.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInBtn.Location = new System.Drawing.Point(175, 113);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(123, 45);
            this.LogInBtn.TabIndex = 3;
            this.LogInBtn.Text = "Log In";
            this.LogInBtn.UseVisualStyleBackColor = false;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // DniEmpleadoVerificar
            // 
            this.DniEmpleadoVerificar.BackColor = System.Drawing.Color.Orange;
            this.DniEmpleadoVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DniEmpleadoVerificar.Location = new System.Drawing.Point(73, 6);
            this.DniEmpleadoVerificar.Name = "DniEmpleadoVerificar";
            this.DniEmpleadoVerificar.Size = new System.Drawing.Size(160, 29);
            this.DniEmpleadoVerificar.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.Font = new System.Drawing.Font("MV Boli", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dni";
            // 
            // NombreVendedorLbl
            // 
            this.NombreVendedorLbl.AutoSize = true;
            this.NombreVendedorLbl.BackColor = System.Drawing.Color.Transparent;
            this.NombreVendedorLbl.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreVendedorLbl.Location = new System.Drawing.Point(12, 98);
            this.NombreVendedorLbl.Name = "NombreVendedorLbl";
            this.NombreVendedorLbl.Size = new System.Drawing.Size(0, 28);
            this.NombreVendedorLbl.TabIndex = 6;
            // 
            // ApellidoVendedorLbl
            // 
            this.ApellidoVendedorLbl.AutoSize = true;
            this.ApellidoVendedorLbl.BackColor = System.Drawing.Color.Transparent;
            this.ApellidoVendedorLbl.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApellidoVendedorLbl.Location = new System.Drawing.Point(13, 130);
            this.ApellidoVendedorLbl.Name = "ApellidoVendedorLbl";
            this.ApellidoVendedorLbl.Size = new System.Drawing.Size(0, 28);
            this.ApellidoVendedorLbl.TabIndex = 7;
            // 
            // VerificacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GonzalezJoseFormKwikEMart.Properties.Resources.kembart;
            this.ClientSize = new System.Drawing.Size(300, 167);
            this.Controls.Add(this.ApellidoVendedorLbl);
            this.Controls.Add(this.NombreVendedorLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DniEmpleadoVerificar);
            this.Controls.Add(this.LogInBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VerificacionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerificacionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.TextBox DniEmpleadoVerificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NombreVendedorLbl;
        private System.Windows.Forms.Label ApellidoVendedorLbl;
    }
}