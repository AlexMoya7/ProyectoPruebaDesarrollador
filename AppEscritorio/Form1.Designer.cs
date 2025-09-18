using System.Windows.Forms;

namespace ProyectoPrueba.Escritorio
{
    partial class Form1 : Form
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.tabReportes = new System.Windows.Forms.TabControl();
            this.tabVentasArticulo = new System.Windows.Forms.TabPage();
            this.btnBuscarVentas = new System.Windows.Forms.Button();
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.dgvVentasArticulo = new System.Windows.Forms.DataGridView();
            this.tabVentasGlobales = new System.Windows.Forms.TabPage();
            this.dgvVentasTotales = new System.Windows.Forms.DataGridView();
            this.tabMasVendidos = new System.Windows.Forms.TabPage();
            this.dgvMasVendidos = new System.Windows.Forms.DataGridView();
            this.tabExistencias = new System.Windows.Forms.TabPage();
            this.dgvExistencias = new System.Windows.Forms.DataGridView();
            this.tabReportes.SuspendLayout();
            this.tabVentasArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasArticulo)).BeginInit();
            this.tabVentasGlobales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasTotales)).BeginInit();
            this.tabMasVendidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasVendidos)).BeginInit();
            this.tabExistencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistencias)).BeginInit();
            this.SuspendLayout();
            // 
            // tabReportes
            // 
            this.tabReportes.Controls.Add(this.tabVentasArticulo);
            this.tabReportes.Controls.Add(this.tabVentasGlobales);
            this.tabReportes.Controls.Add(this.tabMasVendidos);
            this.tabReportes.Controls.Add(this.tabExistencias);
            this.tabReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabReportes.Location = new System.Drawing.Point(0, 0);
            this.tabReportes.Name = "tabReportes";
            this.tabReportes.SelectedIndex = 0;
            this.tabReportes.Size = new System.Drawing.Size(800, 450);
            this.tabReportes.TabIndex = 0;
            // 
            // tabVentasArticulo
            // 
            this.tabVentasArticulo.Controls.Add(this.btnBuscarVentas);
            this.tabVentasArticulo.Controls.Add(this.cboProductos);
            this.tabVentasArticulo.Controls.Add(this.lblProducto);
            this.tabVentasArticulo.Controls.Add(this.dgvVentasArticulo);
            this.tabVentasArticulo.Location = new System.Drawing.Point(4, 25);
            this.tabVentasArticulo.Name = "tabVentasArticulo";
            this.tabVentasArticulo.Padding = new System.Windows.Forms.Padding(3);
            this.tabVentasArticulo.Size = new System.Drawing.Size(792, 421);
            this.tabVentasArticulo.TabIndex = 0;
            this.tabVentasArticulo.Text = "Ventas por Artículo";
            this.tabVentasArticulo.UseVisualStyleBackColor = true;
            // 
            // btnBuscarVentas
            // 
            this.btnBuscarVentas.Location = new System.Drawing.Point(310, 15);
            this.btnBuscarVentas.Name = "btnBuscarVentas";
            this.btnBuscarVentas.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarVentas.TabIndex = 3;
            this.btnBuscarVentas.Text = "Buscar";
            this.btnBuscarVentas.UseVisualStyleBackColor = true;
            this.btnBuscarVentas.Click += new System.EventHandler(this.btnBuscarVentas_Click);
            // 
            // cboProductos
            // 
            this.cboProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Location = new System.Drawing.Point(83, 15);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(221, 24);
            this.cboProductos.TabIndex = 2;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(16, 18);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(64, 16);
            this.lblProducto.TabIndex = 1;
            this.lblProducto.Text = "Producto:";
            // 
            // dgvVentasArticulo
            // 
            this.dgvVentasArticulo.AllowUserToAddRows = false;
            this.dgvVentasArticulo.AllowUserToDeleteRows = false;
            this.dgvVentasArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasArticulo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvVentasArticulo.Location = new System.Drawing.Point(3, 53);
            this.dgvVentasArticulo.Name = "dgvVentasArticulo";
            this.dgvVentasArticulo.ReadOnly = true;
            this.dgvVentasArticulo.RowHeadersWidth = 51;
            this.dgvVentasArticulo.RowTemplate.Height = 25;
            this.dgvVentasArticulo.Size = new System.Drawing.Size(786, 365);
            this.dgvVentasArticulo.TabIndex = 0;
            // 
            // tabVentasGlobales
            // 
            this.tabVentasGlobales.Controls.Add(this.dgvVentasTotales);
            this.tabVentasGlobales.Location = new System.Drawing.Point(4, 25);
            this.tabVentasGlobales.Name = "tabVentasGlobales";
            this.tabVentasGlobales.Padding = new System.Windows.Forms.Padding(3);
            this.tabVentasGlobales.Size = new System.Drawing.Size(792, 421);
            this.tabVentasGlobales.TabIndex = 1;
            this.tabVentasGlobales.Text = "Ventas Globales";
            this.tabVentasGlobales.UseVisualStyleBackColor = true;
            // 
            // dgvVentasTotales
            // 
            this.dgvVentasTotales.AllowUserToAddRows = false;
            this.dgvVentasTotales.AllowUserToDeleteRows = false;
            this.dgvVentasTotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentasTotales.Location = new System.Drawing.Point(0, 0);
            this.dgvVentasTotales.Name = "dgvVentasTotales";
            this.dgvVentasTotales.ReadOnly = true;
            this.dgvVentasTotales.RowHeadersWidth = 51;
            this.dgvVentasTotales.RowTemplate.Height = 24;
            this.dgvVentasTotales.Size = new System.Drawing.Size(789, 421);
            this.dgvVentasTotales.TabIndex = 0;
            // 
            // tabMasVendidos
            // 
            this.tabMasVendidos.Controls.Add(this.dgvMasVendidos);
            this.tabMasVendidos.Location = new System.Drawing.Point(4, 25);
            this.tabMasVendidos.Name = "tabMasVendidos";
            this.tabMasVendidos.Size = new System.Drawing.Size(792, 421);
            this.tabMasVendidos.TabIndex = 2;
            this.tabMasVendidos.Text = "Artículos más vendidos";
            this.tabMasVendidos.UseVisualStyleBackColor = true;
            // 
            // dgvMasVendidos
            // 
            this.dgvMasVendidos.AllowUserToAddRows = false;
            this.dgvMasVendidos.AllowUserToDeleteRows = false;
            this.dgvMasVendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasVendidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMasVendidos.Location = new System.Drawing.Point(0, 0);
            this.dgvMasVendidos.Name = "dgvMasVendidos";
            this.dgvMasVendidos.ReadOnly = true;
            this.dgvMasVendidos.RowHeadersWidth = 51;
            this.dgvMasVendidos.RowTemplate.Height = 25;
            this.dgvMasVendidos.Size = new System.Drawing.Size(792, 421);
            this.dgvMasVendidos.TabIndex = 0;
            // 
            // tabExistencias
            // 
            this.tabExistencias.Controls.Add(this.dgvExistencias);
            this.tabExistencias.Location = new System.Drawing.Point(4, 25);
            this.tabExistencias.Name = "tabExistencias";
            this.tabExistencias.Size = new System.Drawing.Size(792, 421);
            this.tabExistencias.TabIndex = 3;
            this.tabExistencias.Text = "Existencias";
            this.tabExistencias.UseVisualStyleBackColor = true;
            // 
            // dgvExistencias
            // 
            this.dgvExistencias.AllowUserToAddRows = false;
            this.dgvExistencias.AllowUserToDeleteRows = false;
            this.dgvExistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExistencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExistencias.Location = new System.Drawing.Point(0, 0);
            this.dgvExistencias.Name = "dgvExistencias";
            this.dgvExistencias.ReadOnly = true;
            this.dgvExistencias.RowHeadersWidth = 51;
            this.dgvExistencias.RowTemplate.Height = 25;
            this.dgvExistencias.Size = new System.Drawing.Size(792, 421);
            this.dgvExistencias.TabIndex = 0;
            //this.dgvExistencias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExistencias_CellContentClick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabReportes);
            this.Name = "Form1";
            this.Text = "Explotación de Información";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabReportes.ResumeLayout(false);
            this.tabVentasArticulo.ResumeLayout(false);
            this.tabVentasArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasArticulo)).EndInit();
            this.tabVentasGlobales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentasTotales)).EndInit();
            this.tabMasVendidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasVendidos)).EndInit();
            this.tabExistencias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistencias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabReportes;
        private System.Windows.Forms.TabPage tabVentasArticulo;
        private System.Windows.Forms.Button btnBuscarVentas;
        private System.Windows.Forms.ComboBox cboProductos;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.DataGridView dgvVentasArticulo;
        private System.Windows.Forms.TabPage tabVentasGlobales;
        private System.Windows.Forms.TabPage tabMasVendidos;
        private System.Windows.Forms.DataGridView dgvMasVendidos;
        private System.Windows.Forms.TabPage tabExistencias;
        private System.Windows.Forms.DataGridView dgvExistencias;
        private DataGridView dgvVentasTotales;
    }
}
