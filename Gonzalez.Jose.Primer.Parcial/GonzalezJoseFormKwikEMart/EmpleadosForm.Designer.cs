namespace GonzalezJoseFormKwikEMart
{
    partial class EmpleadosForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DniVendedorTxt = new System.Windows.Forms.TextBox();
            this.ConfirmarVendedorBtn = new System.Windows.Forms.Button();
            this.DGVEmpleados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "VENTAS POR EMPLEADO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dni Vendedor";
            // 
            // DniVendedorTxt
            // 
            this.DniVendedorTxt.BackColor = System.Drawing.Color.Orange;
            this.DniVendedorTxt.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DniVendedorTxt.Location = new System.Drawing.Point(170, 53);
            this.DniVendedorTxt.Name = "DniVendedorTxt";
            this.DniVendedorTxt.Size = new System.Drawing.Size(141, 38);
            this.DniVendedorTxt.TabIndex = 2;
            // 
            // ConfirmarVendedorBtn
            // 
            this.ConfirmarVendedorBtn.BackColor = System.Drawing.Color.Orange;
            this.ConfirmarVendedorBtn.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmarVendedorBtn.Location = new System.Drawing.Point(328, 53);
            this.ConfirmarVendedorBtn.Name = "ConfirmarVendedorBtn";
            this.ConfirmarVendedorBtn.Size = new System.Drawing.Size(129, 40);
            this.ConfirmarVendedorBtn.TabIndex = 3;
            this.ConfirmarVendedorBtn.Text = "Confirmar";
            this.ConfirmarVendedorBtn.UseVisualStyleBackColor = false;
            this.ConfirmarVendedorBtn.Click += new System.EventHandler(this.ConfirmarVendedorBtn_Click);
            // 
            // DGVEmpleados
            // 
            this.DGVEmpleados.AllowUserToAddRows = false;
            this.DGVEmpleados.AllowUserToDeleteRows = false;
            this.DGVEmpleados.AllowUserToResizeColumns = false;
            this.DGVEmpleados.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DGVEmpleados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVEmpleados.BackgroundColor = System.Drawing.Color.Moccasin;
            this.DGVEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEmpleados.Location = new System.Drawing.Point(4, 99);
            this.DGVEmpleados.Name = "DGVEmpleados";
            this.DGVEmpleados.ReadOnly = true;
            this.DGVEmpleados.Size = new System.Drawing.Size(453, 211);
            this.DGVEmpleados.TabIndex = 7;
            // 
            // EmpleadosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(460, 317);
            this.Controls.Add(this.DGVEmpleados);
            this.Controls.Add(this.ConfirmarVendedorBtn);
            this.Controls.Add(this.DniVendedorTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmpleadosForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmpleadosForm";
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DniVendedorTxt;
        private System.Windows.Forms.Button ConfirmarVendedorBtn;
        private System.Windows.Forms.DataGridView DGVEmpleados;
    }
}