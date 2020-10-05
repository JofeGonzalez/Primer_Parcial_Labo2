namespace GonzalezJoseFormKwikEMart
{
    partial class GralStockForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVGralStock = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGralStock)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVGralStock
            // 
            this.DGVGralStock.AllowUserToAddRows = false;
            this.DGVGralStock.AllowUserToDeleteRows = false;
            this.DGVGralStock.AllowUserToResizeColumns = false;
            this.DGVGralStock.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DGVGralStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVGralStock.BackgroundColor = System.Drawing.Color.Moccasin;
            this.DGVGralStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVGralStock.Location = new System.Drawing.Point(3, 2);
            this.DGVGralStock.Name = "DGVGralStock";
            this.DGVGralStock.ReadOnly = true;
            this.DGVGralStock.Size = new System.Drawing.Size(530, 258);
            this.DGVGralStock.TabIndex = 0;
            // 
            // GralStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(535, 265);
            this.Controls.Add(this.DGVGralStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GralStockForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GralStockForm";
            this.Load += new System.EventHandler(this.GralStockForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVGralStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVGralStock;
    }
}