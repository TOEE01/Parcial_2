
namespace AppVentas.VISTA
{
    partial class FrmVenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.txtVenta = new System.Windows.Forms.TextBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgVenta = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBucarProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalFinal = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGuardarVenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de documento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de documento:";
            // 
            // cbTipoDocumento
            // 
            this.cbTipoDocumento.FormattingEnabled = true;
            this.cbTipoDocumento.Location = new System.Drawing.Point(467, 6);
            this.cbTipoDocumento.Name = "cbTipoDocumento";
            this.cbTipoDocumento.Size = new System.Drawing.Size(175, 21);
            this.cbTipoDocumento.TabIndex = 2;
            this.cbTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtVenta
            // 
            this.txtVenta.Location = new System.Drawing.Point(125, 6);
            this.txtVenta.Name = "txtVenta";
            this.txtVenta.Size = new System.Drawing.Size(198, 20);
            this.txtVenta.TabIndex = 3;
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(467, 39);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(175, 21);
            this.cbCliente.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cliente:";
            // 
            // dtgVenta
            // 
            this.dtgVenta.AllowUserToAddRows = false;
            this.dtgVenta.AllowUserToDeleteRows = false;
            this.dtgVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgVenta.BackgroundColor = System.Drawing.Color.Plum;
            this.dtgVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dtgVenta.Location = new System.Drawing.Point(22, 214);
            this.dtgVenta.Name = "dtgVenta";
            this.dtgVenta.ReadOnly = true;
            this.dtgVenta.Size = new System.Drawing.Size(657, 250);
            this.dtgVenta.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // txtBucarProducto
            // 
            this.txtBucarProducto.Location = new System.Drawing.Point(111, 126);
            this.txtBucarProducto.Name = "txtBucarProducto";
            this.txtBucarProducto.Size = new System.Drawing.Size(280, 20);
            this.txtBucarProducto.TabIndex = 7;
            this.txtBucarProducto.TextChanged += new System.EventHandler(this.txtBucarProducto_TextChanged);
            this.txtBucarProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Buscar Producto:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(397, 124);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(19, 188);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 10;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(133, 188);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(170, 20);
            this.txtNombreProducto.TabIndex = 11;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(322, 188);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(170, 20);
            this.txtPrecio.TabIndex = 12;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(510, 188);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(81, 20);
            this.txtCantidad.TabIndex = 13;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Código de producto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nombre de producto:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Precio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(507, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Cantidad:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(615, 188);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(147, 20);
            this.txtTotal.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(612, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Texto Total";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(687, 140);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(507, 488);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "TotalFinal";
            // 
            // txtTotalFinal
            // 
            this.txtTotalFinal.Enabled = false;
            this.txtTotalFinal.Location = new System.Drawing.Point(571, 481);
            this.txtTotalFinal.Name = "txtTotalFinal";
            this.txtTotalFinal.Size = new System.Drawing.Size(124, 20);
            this.txtTotalFinal.TabIndex = 22;
            this.txtTotalFinal.TextChanged += new System.EventHandler(this.txtTotalFinal_TextChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(442, 79);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(362, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Fecha:";
            // 
            // txtGuardarVenta
            // 
            this.txtGuardarVenta.Location = new System.Drawing.Point(688, 291);
            this.txtGuardarVenta.Name = "txtGuardarVenta";
            this.txtGuardarVenta.Size = new System.Drawing.Size(75, 36);
            this.txtGuardarVenta.TabIndex = 25;
            this.txtGuardarVenta.Text = "Guardar Venta";
            this.txtGuardarVenta.UseVisualStyleBackColor = true;
            this.txtGuardarVenta.Click += new System.EventHandler(this.txtGuardarVenta_Click);
            // 
            // FrmVenta
            // 
            this.AcceptButton = this.btnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(775, 521);
            this.Controls.Add(this.txtGuardarVenta);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtTotalFinal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBucarProducto);
            this.Controls.Add(this.dtgVenta);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVenta);
            this.Controls.Add(this.cbTipoDocumento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVenta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipoDocumento;
        private System.Windows.Forms.TextBox txtVenta;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgVenta;
        private System.Windows.Forms.TextBox txtBucarProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.TextBox txtNombreProducto;
        public System.Windows.Forms.TextBox txtPrecio;
        public System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotalFinal;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button txtGuardarVenta;
        public System.Windows.Forms.TextBox txtTotal;
    }
}