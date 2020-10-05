namespace GonzalezJoseFormKwikEMart
{
    partial class FormPrincipal
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
            this.StockBtn = new System.Windows.Forms.Button();
            this.CompraBtn = new System.Windows.Forms.Button();
            this.EmpleadosBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StockBtn
            // 
            this.StockBtn.BackColor = System.Drawing.Color.Orange;
            this.StockBtn.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StockBtn.Location = new System.Drawing.Point(258, 50);
            this.StockBtn.Name = "StockBtn";
            this.StockBtn.Size = new System.Drawing.Size(146, 52);
            this.StockBtn.TabIndex = 0;
            this.StockBtn.Text = "STOCK";
            this.StockBtn.UseVisualStyleBackColor = false;
            this.StockBtn.Click += new System.EventHandler(this.StockBtn_Click);
            // 
            // CompraBtn
            // 
            this.CompraBtn.BackColor = System.Drawing.Color.Orange;
            this.CompraBtn.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompraBtn.Location = new System.Drawing.Point(219, 129);
            this.CompraBtn.Name = "CompraBtn";
            this.CompraBtn.Size = new System.Drawing.Size(185, 52);
            this.CompraBtn.TabIndex = 1;
            this.CompraBtn.Text = "COMPRA";
            this.CompraBtn.UseVisualStyleBackColor = false;
            this.CompraBtn.Click += new System.EventHandler(this.CompraBtn_Click);
            // 
            // EmpleadosBtn
            // 
            this.EmpleadosBtn.BackColor = System.Drawing.Color.Orange;
            this.EmpleadosBtn.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpleadosBtn.Location = new System.Drawing.Point(175, 213);
            this.EmpleadosBtn.Name = "EmpleadosBtn";
            this.EmpleadosBtn.Size = new System.Drawing.Size(229, 52);
            this.EmpleadosBtn.TabIndex = 2;
            this.EmpleadosBtn.Text = "EMPLEADOS";
            this.EmpleadosBtn.UseVisualStyleBackColor = false;
            this.EmpleadosBtn.Click += new System.EventHandler(this.EmpleadosBtn_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GonzalezJoseFormKwikEMart.Properties.Resources.kemapu;
            this.ClientSize = new System.Drawing.Size(416, 301);
            this.Controls.Add(this.EmpleadosBtn);
            this.Controls.Add(this.CompraBtn);
            this.Controls.Add(this.StockBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GonzalezJoseKwikEMart";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StockBtn;
        private System.Windows.Forms.Button CompraBtn;
        private System.Windows.Forms.Button EmpleadosBtn;
    }
}

