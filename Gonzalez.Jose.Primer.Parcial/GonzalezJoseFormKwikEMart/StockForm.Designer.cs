namespace GonzalezJoseFormKwikEMart
{
    partial class StockForm
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
            this.GeneralStockBtn = new System.Windows.Forms.Button();
            this.MenosDe10StockBtn = new System.Windows.Forms.Button();
            this.AgregarNuevoProductoBtn = new System.Windows.Forms.Button();
            this.ModificarProductoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GeneralStockBtn
            // 
            this.GeneralStockBtn.BackColor = System.Drawing.Color.Orange;
            this.GeneralStockBtn.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneralStockBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GeneralStockBtn.Location = new System.Drawing.Point(12, 130);
            this.GeneralStockBtn.Name = "GeneralStockBtn";
            this.GeneralStockBtn.Size = new System.Drawing.Size(392, 58);
            this.GeneralStockBtn.TabIndex = 1;
            this.GeneralStockBtn.Text = "Stock General";
            this.GeneralStockBtn.UseVisualStyleBackColor = false;
            this.GeneralStockBtn.Click += new System.EventHandler(this.GeneralStockBtn_Click);
            // 
            // MenosDe10StockBtn
            // 
            this.MenosDe10StockBtn.BackColor = System.Drawing.Color.Orange;
            this.MenosDe10StockBtn.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenosDe10StockBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MenosDe10StockBtn.Location = new System.Drawing.Point(12, 189);
            this.MenosDe10StockBtn.Name = "MenosDe10StockBtn";
            this.MenosDe10StockBtn.Size = new System.Drawing.Size(392, 68);
            this.MenosDe10StockBtn.TabIndex = 2;
            this.MenosDe10StockBtn.Text = "Stock Productos Escasos";
            this.MenosDe10StockBtn.UseVisualStyleBackColor = false;
            this.MenosDe10StockBtn.Click += new System.EventHandler(this.MenosDe10StockBtn_Click);
            // 
            // AgregarNuevoProductoBtn
            // 
            this.AgregarNuevoProductoBtn.BackColor = System.Drawing.Color.Orange;
            this.AgregarNuevoProductoBtn.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarNuevoProductoBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AgregarNuevoProductoBtn.Location = new System.Drawing.Point(12, 12);
            this.AgregarNuevoProductoBtn.Name = "AgregarNuevoProductoBtn";
            this.AgregarNuevoProductoBtn.Size = new System.Drawing.Size(392, 58);
            this.AgregarNuevoProductoBtn.TabIndex = 3;
            this.AgregarNuevoProductoBtn.Text = "Agregar Nuevo Producto";
            this.AgregarNuevoProductoBtn.UseVisualStyleBackColor = false;
            this.AgregarNuevoProductoBtn.Click += new System.EventHandler(this.AgregarNuevoProductoBtn_Click);
            // 
            // ModificarProductoBtn
            // 
            this.ModificarProductoBtn.BackColor = System.Drawing.Color.Orange;
            this.ModificarProductoBtn.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarProductoBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ModificarProductoBtn.Location = new System.Drawing.Point(12, 71);
            this.ModificarProductoBtn.Name = "ModificarProductoBtn";
            this.ModificarProductoBtn.Size = new System.Drawing.Size(392, 58);
            this.ModificarProductoBtn.TabIndex = 4;
            this.ModificarProductoBtn.Text = "Modificar Producto";
            this.ModificarProductoBtn.UseVisualStyleBackColor = false;
            this.ModificarProductoBtn.Click += new System.EventHandler(this.ModificarProductoBtn_Click);
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(416, 262);
            this.Controls.Add(this.ModificarProductoBtn);
            this.Controls.Add(this.AgregarNuevoProductoBtn);
            this.Controls.Add(this.MenosDe10StockBtn);
            this.Controls.Add(this.GeneralStockBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StockForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button GeneralStockBtn;
        private System.Windows.Forms.Button MenosDe10StockBtn;
        private System.Windows.Forms.Button AgregarNuevoProductoBtn;
        private System.Windows.Forms.Button ModificarProductoBtn;
    }
}