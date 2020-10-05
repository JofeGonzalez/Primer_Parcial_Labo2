namespace GonzalezJoseFormKwikEMart
{
    partial class ComprasForm
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
            this.DGVClientes = new System.Windows.Forms.DataGridView();
            this.AgregarNuevoClienteBtn = new System.Windows.Forms.Button();
            this.NuevoClienteApellidoTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NuevoClienteDniTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NuevoClienteNombreTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NuevoClienteDireccionTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RealizarCompraBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVClientes
            // 
            this.DGVClientes.AllowUserToAddRows = false;
            this.DGVClientes.AllowUserToDeleteRows = false;
            this.DGVClientes.AllowUserToResizeColumns = false;
            this.DGVClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DGVClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVClientes.BackgroundColor = System.Drawing.Color.Moccasin;
            this.DGVClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVClientes.Location = new System.Drawing.Point(8, 6);
            this.DGVClientes.Name = "DGVClientes";
            this.DGVClientes.ReadOnly = true;
            this.DGVClientes.Size = new System.Drawing.Size(327, 161);
            this.DGVClientes.TabIndex = 0;
            // 
            // AgregarNuevoClienteBtn
            // 
            this.AgregarNuevoClienteBtn.BackColor = System.Drawing.Color.Orange;
            this.AgregarNuevoClienteBtn.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarNuevoClienteBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AgregarNuevoClienteBtn.Location = new System.Drawing.Point(53, 326);
            this.AgregarNuevoClienteBtn.Name = "AgregarNuevoClienteBtn";
            this.AgregarNuevoClienteBtn.Size = new System.Drawing.Size(231, 43);
            this.AgregarNuevoClienteBtn.TabIndex = 1;
            this.AgregarNuevoClienteBtn.Text = "Agregar Cliente";
            this.AgregarNuevoClienteBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AgregarNuevoClienteBtn.UseVisualStyleBackColor = false;
            this.AgregarNuevoClienteBtn.Click += new System.EventHandler(this.AgregarNuevoClienteBtn_Click);
            // 
            // NuevoClienteApellidoTxt
            // 
            this.NuevoClienteApellidoTxt.BackColor = System.Drawing.Color.Orange;
            this.NuevoClienteApellidoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoClienteApellidoTxt.Location = new System.Drawing.Point(137, 214);
            this.NuevoClienteApellidoTxt.Name = "NuevoClienteApellidoTxt";
            this.NuevoClienteApellidoTxt.Size = new System.Drawing.Size(198, 29);
            this.NuevoClienteApellidoTxt.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Orange;
            this.label3.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 31);
            this.label3.TabIndex = 14;
            this.label3.Text = "Apellido";
            // 
            // NuevoClienteDniTxt
            // 
            this.NuevoClienteDniTxt.BackColor = System.Drawing.Color.Orange;
            this.NuevoClienteDniTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoClienteDniTxt.Location = new System.Drawing.Point(137, 256);
            this.NuevoClienteDniTxt.Name = "NuevoClienteDniTxt";
            this.NuevoClienteDniTxt.Size = new System.Drawing.Size(198, 29);
            this.NuevoClienteDniTxt.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "DNI";
            // 
            // NuevoClienteNombreTxt
            // 
            this.NuevoClienteNombreTxt.BackColor = System.Drawing.Color.Orange;
            this.NuevoClienteNombreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoClienteNombreTxt.Location = new System.Drawing.Point(137, 172);
            this.NuevoClienteNombreTxt.Name = "NuevoClienteNombreTxt";
            this.NuevoClienteNombreTxt.Size = new System.Drawing.Size(198, 29);
            this.NuevoClienteNombreTxt.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre";
            // 
            // NuevoClienteDireccionTxt
            // 
            this.NuevoClienteDireccionTxt.BackColor = System.Drawing.Color.Orange;
            this.NuevoClienteDireccionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoClienteDireccionTxt.Location = new System.Drawing.Point(137, 295);
            this.NuevoClienteDireccionTxt.Name = "NuevoClienteDireccionTxt";
            this.NuevoClienteDireccionTxt.Size = new System.Drawing.Size(198, 29);
            this.NuevoClienteDireccionTxt.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Orange;
            this.label4.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 31);
            this.label4.TabIndex = 16;
            this.label4.Text = "Direccion";
            // 
            // RealizarCompraBtn
            // 
            this.RealizarCompraBtn.BackColor = System.Drawing.Color.Orange;
            this.RealizarCompraBtn.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RealizarCompraBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RealizarCompraBtn.Location = new System.Drawing.Point(46, 371);
            this.RealizarCompraBtn.Name = "RealizarCompraBtn";
            this.RealizarCompraBtn.Size = new System.Drawing.Size(246, 43);
            this.RealizarCompraBtn.TabIndex = 17;
            this.RealizarCompraBtn.Text = "Realizar Compra";
            this.RealizarCompraBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RealizarCompraBtn.UseVisualStyleBackColor = false;
            this.RealizarCompraBtn.Click += new System.EventHandler(this.RealizarCompraBtn_Click);
            // 
            // ComprasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(348, 418);
            this.Controls.Add(this.RealizarCompraBtn);
            this.Controls.Add(this.NuevoClienteDireccionTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NuevoClienteApellidoTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NuevoClienteDniTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NuevoClienteNombreTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AgregarNuevoClienteBtn);
            this.Controls.Add(this.DGVClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComprasForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComprasForm";
            this.Load += new System.EventHandler(this.ComprasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVClientes;
        private System.Windows.Forms.Button AgregarNuevoClienteBtn;
        private System.Windows.Forms.TextBox NuevoClienteApellidoTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NuevoClienteDniTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NuevoClienteNombreTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NuevoClienteDireccionTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RealizarCompraBtn;
    }
}