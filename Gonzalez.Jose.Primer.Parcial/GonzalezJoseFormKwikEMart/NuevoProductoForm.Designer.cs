namespace GonzalezJoseFormKwikEMart
{
    partial class NuevoProductoForm
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
            this.AgregarNuevoProductoBtn = new System.Windows.Forms.Button();
            this.NuevoProductoNombreTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NuevoProductoPrecioTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NuevoProductoCantidadTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AgregarNuevoProductoBtn
            // 
            this.AgregarNuevoProductoBtn.BackColor = System.Drawing.Color.Orange;
            this.AgregarNuevoProductoBtn.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarNuevoProductoBtn.Location = new System.Drawing.Point(99, 139);
            this.AgregarNuevoProductoBtn.Name = "AgregarNuevoProductoBtn";
            this.AgregarNuevoProductoBtn.Size = new System.Drawing.Size(147, 56);
            this.AgregarNuevoProductoBtn.TabIndex = 3;
            this.AgregarNuevoProductoBtn.Text = "Agregar";
            this.AgregarNuevoProductoBtn.UseVisualStyleBackColor = false;
            this.AgregarNuevoProductoBtn.Click += new System.EventHandler(this.AgregarNuevoProductoBtn_Click);
            // 
            // NuevoProductoNombreTxt
            // 
            this.NuevoProductoNombreTxt.BackColor = System.Drawing.Color.Orange;
            this.NuevoProductoNombreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoProductoNombreTxt.Location = new System.Drawing.Point(137, 9);
            this.NuevoProductoNombreTxt.Name = "NuevoProductoNombreTxt";
            this.NuevoProductoNombreTxt.Size = new System.Drawing.Size(198, 29);
            this.NuevoProductoNombreTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // NuevoProductoPrecioTxt
            // 
            this.NuevoProductoPrecioTxt.BackColor = System.Drawing.Color.Orange;
            this.NuevoProductoPrecioTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoProductoPrecioTxt.Location = new System.Drawing.Point(137, 93);
            this.NuevoProductoPrecioTxt.Name = "NuevoProductoPrecioTxt";
            this.NuevoProductoPrecioTxt.Size = new System.Drawing.Size(198, 29);
            this.NuevoProductoPrecioTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Precio";
            // 
            // NuevoProductoCantidadTxt
            // 
            this.NuevoProductoCantidadTxt.BackColor = System.Drawing.Color.Orange;
            this.NuevoProductoCantidadTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoProductoCantidadTxt.Location = new System.Drawing.Point(137, 51);
            this.NuevoProductoCantidadTxt.Name = "NuevoProductoCantidadTxt";
            this.NuevoProductoCantidadTxt.Size = new System.Drawing.Size(198, 29);
            this.NuevoProductoCantidadTxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Orange;
            this.label3.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cantidad";
            // 
            // NuevoProductoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(346, 203);
            this.Controls.Add(this.NuevoProductoCantidadTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NuevoProductoPrecioTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AgregarNuevoProductoBtn);
            this.Controls.Add(this.NuevoProductoNombreTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NuevoProductoForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AgregarNuevoProductoBtn;
        private System.Windows.Forms.TextBox NuevoProductoNombreTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NuevoProductoPrecioTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NuevoProductoCantidadTxt;
        private System.Windows.Forms.Label label3;
    }
}