﻿namespace Tienda_De_Ropa
{
    partial class Vendedor
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
            this.btn_CerrarSesion = new System.Windows.Forms.Button();
            this.btn_GenerarVenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_IdVendedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_IdVenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Fecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DniCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_NombreCliente = new System.Windows.Forms.TextBox();
            this.txt_ApellidoCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbo_Producto = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.btn_AgregarProductoALista = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ConfirmarVenta = new System.Windows.Forms.Button();
            this.btn_CancelarVenta = new System.Windows.Forms.Button();
            this.btn_EliminarProductoDeLista = new System.Windows.Forms.Button();
            this.nud_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.cbo_MetodoDePago = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgv_ProductosCargados = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_ClienteNro = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductosCargados)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CerrarSesion
            // 
            this.btn_CerrarSesion.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CerrarSesion.Location = new System.Drawing.Point(16, 15);
            this.btn_CerrarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CerrarSesion.Name = "btn_CerrarSesion";
            this.btn_CerrarSesion.Size = new System.Drawing.Size(108, 74);
            this.btn_CerrarSesion.TabIndex = 0;
            this.btn_CerrarSesion.Text = "Cerrar Sesion";
            this.btn_CerrarSesion.UseVisualStyleBackColor = true;
            this.btn_CerrarSesion.Click += new System.EventHandler(this.btn_CerrarSesion_Click);
            // 
            // btn_GenerarVenta
            // 
            this.btn_GenerarVenta.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GenerarVenta.Location = new System.Drawing.Point(823, 15);
            this.btn_GenerarVenta.Margin = new System.Windows.Forms.Padding(4);
            this.btn_GenerarVenta.Name = "btn_GenerarVenta";
            this.btn_GenerarVenta.Size = new System.Drawing.Size(108, 74);
            this.btn_GenerarVenta.TabIndex = 1;
            this.btn_GenerarVenta.Text = "Generar Venta";
            this.btn_GenerarVenta.UseVisualStyleBackColor = true;
            this.btn_GenerarVenta.Click += new System.EventHandler(this.btn_GenerarVenta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vendedor N°:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(19, 97);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 12);
            this.panel1.TabIndex = 4;
            // 
            // txt_IdVendedor
            // 
            this.txt_IdVendedor.Enabled = false;
            this.txt_IdVendedor.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdVendedor.Location = new System.Drawing.Point(497, 117);
            this.txt_IdVendedor.Margin = new System.Windows.Forms.Padding(4);
            this.txt_IdVendedor.Name = "txt_IdVendedor";
            this.txt_IdVendedor.Size = new System.Drawing.Size(91, 35);
            this.txt_IdVendedor.TabIndex = 5;
            this.txt_IdVendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(596, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Venta N°:";
            // 
            // txt_IdVenta
            // 
            this.txt_IdVenta.Enabled = false;
            this.txt_IdVenta.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.txt_IdVenta.Location = new System.Drawing.Point(718, 117);
            this.txt_IdVenta.Margin = new System.Windows.Forms.Padding(4);
            this.txt_IdVenta.Name = "txt_IdVenta";
            this.txt_IdVenta.Size = new System.Drawing.Size(102, 35);
            this.txt_IdVenta.TabIndex = 7;
            this.txt_IdVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(392, 271);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha:";
            // 
            // txt_Fecha
            // 
            this.txt_Fecha.Enabled = false;
            this.txt_Fecha.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Fecha.Location = new System.Drawing.Point(527, 268);
            this.txt_Fecha.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.Size = new System.Drawing.Size(169, 35);
            this.txt_Fecha.TabIndex = 9;
            this.txt_Fecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Fecha.TextChanged += new System.EventHandler(this.txt_Fecha_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(287, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(390, 65);
            this.label4.TabIndex = 10;
            this.label4.Text = "Area: Vendedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(392, 227);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "D.N.I:";
            // 
            // txt_DniCliente
            // 
            this.txt_DniCliente.Enabled = false;
            this.txt_DniCliente.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.txt_DniCliente.Location = new System.Drawing.Point(527, 224);
            this.txt_DniCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DniCliente.Name = "txt_DniCliente";
            this.txt_DniCliente.Size = new System.Drawing.Size(169, 35);
            this.txt_DniCliente.TabIndex = 12;
            this.txt_DniCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 268);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nombres:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Yellow;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 227);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Apellidos:";
            // 
            // txt_NombreCliente
            // 
            this.txt_NombreCliente.Enabled = false;
            this.txt_NombreCliente.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.txt_NombreCliente.Location = new System.Drawing.Point(137, 268);
            this.txt_NombreCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NombreCliente.Name = "txt_NombreCliente";
            this.txt_NombreCliente.Size = new System.Drawing.Size(244, 35);
            this.txt_NombreCliente.TabIndex = 15;
            this.txt_NombreCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_ApellidoCliente
            // 
            this.txt_ApellidoCliente.Enabled = false;
            this.txt_ApellidoCliente.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.txt_ApellidoCliente.Location = new System.Drawing.Point(137, 224);
            this.txt_ApellidoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ApellidoCliente.Name = "txt_ApellidoCliente";
            this.txt_ApellidoCliente.Size = new System.Drawing.Size(244, 35);
            this.txt_ApellidoCliente.TabIndex = 16;
            this.txt_ApellidoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Yellow;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(293, 334);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 29);
            this.label8.TabIndex = 17;
            this.label8.Text = "Nombre del producto:";
            // 
            // cbo_Producto
            // 
            this.cbo_Producto.Enabled = false;
            this.cbo_Producto.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Producto.FormattingEnabled = true;
            this.cbo_Producto.Items.AddRange(new object[] {
            "",
            "Pelota de volleyball",
            "Pelota de tennis",
            "Zapatillas Adidas"});
            this.cbo_Producto.Location = new System.Drawing.Point(527, 331);
            this.cbo_Producto.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_Producto.Name = "cbo_Producto";
            this.cbo_Producto.Size = new System.Drawing.Size(407, 37);
            this.cbo_Producto.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Yellow;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 379);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 29);
            this.label9.TabIndex = 19;
            this.label9.Text = "Cantidad:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Yellow;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(293, 377);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 29);
            this.label11.TabIndex = 23;
            this.label11.Text = "Precio Unitario: ";
            // 
            // txt_Precio
            // 
            this.txt_Precio.Enabled = false;
            this.txt_Precio.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Precio.Location = new System.Drawing.Point(527, 376);
            this.txt_Precio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(147, 35);
            this.txt_Precio.TabIndex = 24;
            this.txt_Precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_AgregarProductoALista
            // 
            this.btn_AgregarProductoALista.Enabled = false;
            this.btn_AgregarProductoALista.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarProductoALista.Location = new System.Drawing.Point(682, 375);
            this.btn_AgregarProductoALista.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AgregarProductoALista.Name = "btn_AgregarProductoALista";
            this.btn_AgregarProductoALista.Size = new System.Drawing.Size(252, 36);
            this.btn_AgregarProductoALista.TabIndex = 25;
            this.btn_AgregarProductoALista.Text = "Agregar Producto";
            this.btn_AgregarProductoALista.UseVisualStyleBackColor = true;
            this.btn_AgregarProductoALista.Click += new System.EventHandler(this.btn_AgregarProductoALista_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(16, 420);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(918, 12);
            this.panel2.TabIndex = 7;
            // 
            // btn_ConfirmarVenta
            // 
            this.btn_ConfirmarVenta.Enabled = false;
            this.btn_ConfirmarVenta.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConfirmarVenta.Location = new System.Drawing.Point(622, 587);
            this.btn_ConfirmarVenta.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ConfirmarVenta.Name = "btn_ConfirmarVenta";
            this.btn_ConfirmarVenta.Size = new System.Drawing.Size(312, 38);
            this.btn_ConfirmarVenta.TabIndex = 27;
            this.btn_ConfirmarVenta.Text = "Confirmar Venta";
            this.btn_ConfirmarVenta.UseVisualStyleBackColor = true;
            this.btn_ConfirmarVenta.Click += new System.EventHandler(this.btn_ConfirmarVenta_Click);
            // 
            // btn_CancelarVenta
            // 
            this.btn_CancelarVenta.Enabled = false;
            this.btn_CancelarVenta.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelarVenta.Location = new System.Drawing.Point(335, 587);
            this.btn_CancelarVenta.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CancelarVenta.Name = "btn_CancelarVenta";
            this.btn_CancelarVenta.Size = new System.Drawing.Size(279, 38);
            this.btn_CancelarVenta.TabIndex = 28;
            this.btn_CancelarVenta.Text = "Cancelar Venta";
            this.btn_CancelarVenta.UseVisualStyleBackColor = true;
            this.btn_CancelarVenta.Click += new System.EventHandler(this.btn_CancelarVenta_Click);
            // 
            // btn_EliminarProductoDeLista
            // 
            this.btn_EliminarProductoDeLista.Enabled = false;
            this.btn_EliminarProductoDeLista.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarProductoDeLista.Location = new System.Drawing.Point(16, 587);
            this.btn_EliminarProductoDeLista.Margin = new System.Windows.Forms.Padding(4);
            this.btn_EliminarProductoDeLista.Name = "btn_EliminarProductoDeLista";
            this.btn_EliminarProductoDeLista.Size = new System.Drawing.Size(311, 38);
            this.btn_EliminarProductoDeLista.TabIndex = 29;
            this.btn_EliminarProductoDeLista.Text = "Eliminar producto de la lista";
            this.btn_EliminarProductoDeLista.UseVisualStyleBackColor = true;
            this.btn_EliminarProductoDeLista.Click += new System.EventHandler(this.btn_EliminarProductoDeLista_Click);
            // 
            // nud_Cantidad
            // 
            this.nud_Cantidad.Enabled = false;
            this.nud_Cantidad.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Cantidad.Location = new System.Drawing.Point(137, 377);
            this.nud_Cantidad.Margin = new System.Windows.Forms.Padding(4);
            this.nud_Cantidad.Name = "nud_Cantidad";
            this.nud_Cantidad.Size = new System.Drawing.Size(92, 35);
            this.nud_Cantidad.TabIndex = 31;
            this.nud_Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Yellow;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(706, 271);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 29);
            this.label12.TabIndex = 32;
            this.label12.Text = "Total:";
            // 
            // txt_Total
            // 
            this.txt_Total.Enabled = false;
            this.txt_Total.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Total.Location = new System.Drawing.Point(791, 268);
            this.txt_Total.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(143, 35);
            this.txt_Total.TabIndex = 33;
            this.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbo_MetodoDePago
            // 
            this.cbo_MetodoDePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_MetodoDePago.Enabled = false;
            this.cbo_MetodoDePago.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_MetodoDePago.FormattingEnabled = true;
            this.cbo_MetodoDePago.Items.AddRange(new object[] {
            "",
            "Pelota de volleyball",
            "Pelota de tennis",
            "Zapatillas Adidas"});
            this.cbo_MetodoDePago.Location = new System.Drawing.Point(704, 224);
            this.cbo_MetodoDePago.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_MetodoDePago.Name = "cbo_MetodoDePago";
            this.cbo_MetodoDePago.Size = new System.Drawing.Size(230, 37);
            this.cbo_MetodoDePago.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Yellow;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(706, 182);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(179, 29);
            this.label13.TabIndex = 35;
            this.label13.Text = "Metodo de pago:";
            // 
            // dgv_ProductosCargados
            // 
            this.dgv_ProductosCargados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProductosCargados.Enabled = false;
            this.dgv_ProductosCargados.Location = new System.Drawing.Point(16, 440);
            this.dgv_ProductosCargados.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_ProductosCargados.Name = "dgv_ProductosCargados";
            this.dgv_ProductosCargados.RowHeadersWidth = 51;
            this.dgv_ProductosCargados.Size = new System.Drawing.Size(918, 139);
            this.dgv_ProductosCargados.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Yellow;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 117);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(292, 39);
            this.label10.TabIndex = 37;
            this.label10.Text = "Datos del vendedor:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Yellow;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(19, 175);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(310, 39);
            this.label14.TabIndex = 38;
            this.label14.Text = "Datos del comprador:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Menu;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(13, 160);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(918, 11);
            this.panel3.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Yellow;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(392, 182);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 29);
            this.label15.TabIndex = 39;
            this.label15.Text = "Cliente N°:";
            // 
            // txt_ClienteNro
            // 
            this.txt_ClienteNro.Enabled = false;
            this.txt_ClienteNro.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ClienteNro.Location = new System.Drawing.Point(527, 179);
            this.txt_ClienteNro.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ClienteNro.Name = "txt_ClienteNro";
            this.txt_ClienteNro.Size = new System.Drawing.Size(96, 35);
            this.txt_ClienteNro.TabIndex = 40;
            this.txt_ClienteNro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Menu;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(19, 311);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(915, 12);
            this.panel4.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Yellow;
            this.label16.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(19, 327);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(261, 39);
            this.label16.TabIndex = 41;
            this.label16.Text = "Cargar Productos:";
            // 
            // Vendedor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(944, 632);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txt_ClienteNro);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgv_ProductosCargados);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbo_MetodoDePago);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.nud_Cantidad);
            this.Controls.Add(this.btn_EliminarProductoDeLista);
            this.Controls.Add(this.btn_CancelarVenta);
            this.Controls.Add(this.btn_ConfirmarVenta);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_AgregarProductoALista);
            this.Controls.Add(this.txt_Precio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbo_Producto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_ApellidoCliente);
            this.Controls.Add(this.txt_NombreCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_DniCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Fecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_IdVenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_IdVendedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_GenerarVenta);
            this.Controls.Add(this.btn_CerrarSesion);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Vendedor";
            this.Text = "Vendedor";
            this.Load += new System.EventHandler(this.Vendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductosCargados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CerrarSesion;
        private System.Windows.Forms.Button btn_GenerarVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_IdVendedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_IdVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Fecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_DniCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_NombreCliente;
        private System.Windows.Forms.TextBox txt_ApellidoCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbo_Producto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.Button btn_AgregarProductoALista;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_ConfirmarVenta;
        private System.Windows.Forms.Button btn_CancelarVenta;
        private System.Windows.Forms.Button btn_EliminarProductoDeLista;
        private System.Windows.Forms.NumericUpDown nud_Cantidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.ComboBox cbo_MetodoDePago;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgv_ProductosCargados;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_ClienteNro;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label16;
    }
}