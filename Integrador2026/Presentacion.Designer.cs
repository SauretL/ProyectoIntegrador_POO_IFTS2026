namespace Integrador2026
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            toolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            tctPrincipal = new TabControl();
            tcbProducto = new TabPage();
            pbxFotoproducto = new PictureBox();
            cboSubcategoria = new ComboBox();
            cboCategoria = new ComboBox();
            txtProveedor = new TextBox();
            txtPrecioventa = new TextBox();
            txtPreciobruto = new TextBox();
            txtIVA = new TextBox();
            textBox4 = new TextBox();
            txtPreciocosto = new TextBox();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            lblSubcategoria = new Label();
            lblCategoria = new Label();
            lblProveedor = new Label();
            lblPrecioventa = new Label();
            lblPreciobruto = new Label();
            lbIVA = new Label();
            lblMargen = new Label();
            lblPreciocosto = new Label();
            lblDescripcion = new Label();
            lblNombre = new Label();
            tbcVendedor = new TabPage();
            tbcClienteIndividuo = new TabPage();
            tbcClienteEmpresa = new TabPage();
            imageList1 = new ImageList(components);
            lblNombreVendedor = new Label();
            lblApellidoVendedor = new Label();
            lblDNIVendedor = new Label();
            lblCUITVendedor = new Label();
            txtNombreVendedor = new TextBox();
            txtApellido = new TextBox();
            txtDNIVendedor = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            pbxVendedor = new PictureBox();
            menuStrip1.SuspendLayout();
            tctPrincipal.SuspendLayout();
            tcbProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxFotoproducto).BeginInit();
            tbcVendedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxVendedor).BeginInit();
            SuspendLayout();
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.ShortcutKeys = Keys.Alt | Keys.F4;
            toolStripMenuItem1.Size = new Size(41, 20);
            toolStripMenuItem1.Text = "Salir";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "Archivo";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // tctPrincipal
            // 
            tctPrincipal.Controls.Add(tcbProducto);
            tctPrincipal.Controls.Add(tbcVendedor);
            tctPrincipal.Controls.Add(tbcClienteIndividuo);
            tctPrincipal.Controls.Add(tbcClienteEmpresa);
            tctPrincipal.Dock = DockStyle.Fill;
            tctPrincipal.Font = new Font("Century", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tctPrincipal.ImageList = imageList1;
            tctPrincipal.Location = new Point(0, 24);
            tctPrincipal.Name = "tctPrincipal";
            tctPrincipal.SelectedIndex = 0;
            tctPrincipal.Size = new Size(784, 437);
            tctPrincipal.SizeMode = TabSizeMode.Fixed;
            tctPrincipal.TabIndex = 1;
            // 
            // tcbProducto
            // 
            tcbProducto.Controls.Add(pbxFotoproducto);
            tcbProducto.Controls.Add(cboSubcategoria);
            tcbProducto.Controls.Add(cboCategoria);
            tcbProducto.Controls.Add(txtProveedor);
            tcbProducto.Controls.Add(txtPrecioventa);
            tcbProducto.Controls.Add(txtPreciobruto);
            tcbProducto.Controls.Add(txtIVA);
            tcbProducto.Controls.Add(textBox4);
            tcbProducto.Controls.Add(txtPreciocosto);
            tcbProducto.Controls.Add(txtDescripcion);
            tcbProducto.Controls.Add(txtNombre);
            tcbProducto.Controls.Add(lblSubcategoria);
            tcbProducto.Controls.Add(lblCategoria);
            tcbProducto.Controls.Add(lblProveedor);
            tcbProducto.Controls.Add(lblPrecioventa);
            tcbProducto.Controls.Add(lblPreciobruto);
            tcbProducto.Controls.Add(lbIVA);
            tcbProducto.Controls.Add(lblMargen);
            tcbProducto.Controls.Add(lblPreciocosto);
            tcbProducto.Controls.Add(lblDescripcion);
            tcbProducto.Controls.Add(lblNombre);
            tcbProducto.ImageIndex = 2;
            tcbProducto.Location = new Point(4, 24);
            tcbProducto.Name = "tcbProducto";
            tcbProducto.Padding = new Padding(3);
            tcbProducto.Size = new Size(776, 409);
            tcbProducto.TabIndex = 0;
            tcbProducto.Text = "Productos";
            tcbProducto.UseVisualStyleBackColor = true;
            // 
            // pbxFotoproducto
            // 
            pbxFotoproducto.Image = Properties.Resources.Producto_SinFoto;
            pbxFotoproducto.Location = new Point(487, 289);
            pbxFotoproducto.Name = "pbxFotoproducto";
            pbxFotoproducto.Size = new Size(281, 111);
            pbxFotoproducto.SizeMode = PictureBoxSizeMode.Zoom;
            pbxFotoproducto.TabIndex = 20;
            pbxFotoproducto.TabStop = false;
            // 
            // cboSubcategoria
            // 
            cboSubcategoria.FormattingEnabled = true;
            cboSubcategoria.Items.AddRange(new object[] { "SUBCATEGORIA A.A", "SUBCATEGORIA A.B", "SUBCATEGORIA A.C", "SUBCATEGORIA B.B", "SUBCATEGORIA B.C", "SUBCATEGORIA C.C" });
            cboSubcategoria.Location = new Point(464, 232);
            cboSubcategoria.Name = "cboSubcategoria";
            cboSubcategoria.Size = new Size(121, 23);
            cboSubcategoria.TabIndex = 19;
            // 
            // cboCategoria
            // 
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Items.AddRange(new object[] { "CATEGORIA A", "CATEGORIA B", "CATEGORIA C" });
            cboCategoria.Location = new Point(443, 186);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(121, 23);
            cboCategoria.TabIndex = 18;
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(443, 149);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(100, 21);
            txtProveedor.TabIndex = 17;
            txtProveedor.TextChanged += textBox8_TextChanged;
            // 
            // txtPrecioventa
            // 
            txtPrecioventa.Location = new Point(463, 114);
            txtPrecioventa.Name = "txtPrecioventa";
            txtPrecioventa.Size = new Size(100, 21);
            txtPrecioventa.TabIndex = 16;
            // 
            // txtPreciobruto
            // 
            txtPreciobruto.Location = new Point(462, 74);
            txtPreciobruto.Name = "txtPreciobruto";
            txtPreciobruto.Size = new Size(100, 21);
            txtPreciobruto.TabIndex = 15;
            txtPreciobruto.TextChanged += textBox6_TextChanged;
            // 
            // txtIVA
            // 
            txtIVA.Location = new Point(92, 215);
            txtIVA.Name = "txtIVA";
            txtIVA.Size = new Size(100, 21);
            txtIVA.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(105, 183);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 21);
            textBox4.TabIndex = 13;
            // 
            // txtPreciocosto
            // 
            txtPreciocosto.Location = new Point(133, 149);
            txtPreciocosto.Name = "txtPreciocosto";
            txtPreciocosto.Size = new Size(100, 21);
            txtPreciocosto.TabIndex = 12;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(131, 117);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 21);
            txtDescripcion.TabIndex = 11;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(105, 78);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 21);
            txtNombre.TabIndex = 10;
            // 
            // lblSubcategoria
            // 
            lblSubcategoria.AutoSize = true;
            lblSubcategoria.Location = new Point(362, 232);
            lblSubcategoria.Name = "lblSubcategoria";
            lblSubcategoria.Size = new Size(86, 15);
            lblSubcategoria.TabIndex = 9;
            lblSubcategoria.Text = "Subcategoria";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(362, 189);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(66, 15);
            lblCategoria.TabIndex = 8;
            lblCategoria.Text = "Categoria";
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(362, 152);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(69, 15);
            lblProveedor.TabIndex = 7;
            lblProveedor.Text = "Proveedor";
            // 
            // lblPrecioventa
            // 
            lblPrecioventa.AutoSize = true;
            lblPrecioventa.Location = new Point(362, 114);
            lblPrecioventa.Name = "lblPrecioventa";
            lblPrecioventa.Size = new Size(85, 15);
            lblPrecioventa.TabIndex = 6;
            lblPrecioventa.Text = "Precio Venta";
            // 
            // lblPreciobruto
            // 
            lblPreciobruto.AutoSize = true;
            lblPreciobruto.Location = new Point(362, 78);
            lblPreciobruto.Name = "lblPreciobruto";
            lblPreciobruto.Size = new Size(84, 15);
            lblPreciobruto.TabIndex = 5;
            lblPreciobruto.Text = "Precio Bruto";
            // 
            // lbIVA
            // 
            lbIVA.AutoSize = true;
            lbIVA.Location = new Point(38, 222);
            lbIVA.Name = "lbIVA";
            lbIVA.Size = new Size(30, 15);
            lbIVA.TabIndex = 4;
            lbIVA.Text = "IVA";
            // 
            // lblMargen
            // 
            lblMargen.AutoSize = true;
            lblMargen.Location = new Point(38, 186);
            lblMargen.Name = "lblMargen";
            lblMargen.Size = new Size(53, 15);
            lblMargen.TabIndex = 3;
            lblMargen.Text = "Margen";
            // 
            // lblPreciocosto
            // 
            lblPreciocosto.AutoSize = true;
            lblPreciocosto.Location = new Point(38, 149);
            lblPreciocosto.Name = "lblPreciocosto";
            lblPreciocosto.Size = new Size(83, 15);
            lblPreciocosto.TabIndex = 2;
            lblPreciocosto.Text = "Precio Costo";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(38, 117);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(77, 15);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Descripción";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(38, 81);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(55, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            lblNombre.Click += label1_Click;
            // 
            // tbcVendedor
            // 
            tbcVendedor.Controls.Add(pbxVendedor);
            tbcVendedor.Controls.Add(maskedTextBox1);
            tbcVendedor.Controls.Add(txtDNIVendedor);
            tbcVendedor.Controls.Add(txtApellido);
            tbcVendedor.Controls.Add(txtNombreVendedor);
            tbcVendedor.Controls.Add(lblCUITVendedor);
            tbcVendedor.Controls.Add(lblDNIVendedor);
            tbcVendedor.Controls.Add(lblApellidoVendedor);
            tbcVendedor.Controls.Add(lblNombreVendedor);
            tbcVendedor.ImageIndex = 3;
            tbcVendedor.Location = new Point(4, 24);
            tbcVendedor.Name = "tbcVendedor";
            tbcVendedor.Padding = new Padding(3);
            tbcVendedor.Size = new Size(776, 409);
            tbcVendedor.TabIndex = 1;
            tbcVendedor.Text = "Vendedores";
            tbcVendedor.UseVisualStyleBackColor = true;
            tbcVendedor.Click += tbcVendedor_Click;
            // 
            // tbcClienteIndividuo
            // 
            tbcClienteIndividuo.ImageIndex = 0;
            tbcClienteIndividuo.Location = new Point(4, 25);
            tbcClienteIndividuo.Name = "tbcClienteIndividuo";
            tbcClienteIndividuo.Size = new Size(776, 408);
            tbcClienteIndividuo.TabIndex = 2;
            tbcClienteIndividuo.Text = "Clientes";
            tbcClienteIndividuo.UseVisualStyleBackColor = true;
            // 
            // tbcClienteEmpresa
            // 
            tbcClienteEmpresa.ImageIndex = 1;
            tbcClienteEmpresa.Location = new Point(4, 25);
            tbcClienteEmpresa.Name = "tbcClienteEmpresa";
            tbcClienteEmpresa.Size = new Size(776, 408);
            tbcClienteEmpresa.TabIndex = 3;
            tbcClienteEmpresa.Text = "Empresas";
            tbcClienteEmpresa.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Clientes.ico");
            imageList1.Images.SetKeyName(1, "Empresas.ico");
            imageList1.Images.SetKeyName(2, "Productos.ico");
            imageList1.Images.SetKeyName(3, "Vendedores.ico");
            // 
            // lblNombreVendedor
            // 
            lblNombreVendedor.AutoSize = true;
            lblNombreVendedor.Location = new Point(44, 147);
            lblNombreVendedor.Name = "lblNombreVendedor";
            lblNombreVendedor.Size = new Size(55, 15);
            lblNombreVendedor.TabIndex = 0;
            lblNombreVendedor.Text = "Nombre";
            // 
            // lblApellidoVendedor
            // 
            lblApellidoVendedor.AutoSize = true;
            lblApellidoVendedor.Location = new Point(44, 181);
            lblApellidoVendedor.Name = "lblApellidoVendedor";
            lblApellidoVendedor.Size = new Size(56, 15);
            lblApellidoVendedor.TabIndex = 1;
            lblApellidoVendedor.Text = "Apellido";
            lblApellidoVendedor.Click += label2_Click;
            // 
            // lblDNIVendedor
            // 
            lblDNIVendedor.AutoSize = true;
            lblDNIVendedor.Location = new Point(44, 213);
            lblDNIVendedor.Name = "lblDNIVendedor";
            lblDNIVendedor.Size = new Size(31, 15);
            lblDNIVendedor.TabIndex = 2;
            lblDNIVendedor.Text = "DNI";
            // 
            // lblCUITVendedor
            // 
            lblCUITVendedor.AutoSize = true;
            lblCUITVendedor.Location = new Point(44, 246);
            lblCUITVendedor.Name = "lblCUITVendedor";
            lblCUITVendedor.Size = new Size(39, 15);
            lblCUITVendedor.TabIndex = 3;
            lblCUITVendedor.Text = "CUIT";
            // 
            // txtNombreVendedor
            // 
            txtNombreVendedor.Location = new Point(259, 141);
            txtNombreVendedor.Name = "txtNombreVendedor";
            txtNombreVendedor.Size = new Size(100, 21);
            txtNombreVendedor.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(259, 175);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 21);
            txtApellido.TabIndex = 5;
            // 
            // txtDNIVendedor
            // 
            txtDNIVendedor.Location = new Point(259, 213);
            txtDNIVendedor.Name = "txtDNIVendedor";
            txtDNIVendedor.Size = new Size(100, 21);
            txtDNIVendedor.TabIndex = 6;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(259, 240);
            maskedTextBox1.Mask = "99-99999999-9";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 21);
            maskedTextBox1.TabIndex = 7;
            // 
            // pbxVendedor
            // 
            pbxVendedor.Image = Properties.Resources.Vendedor_SinFoto;
            pbxVendedor.Location = new Point(487, 254);
            pbxVendedor.Name = "pbxVendedor";
            pbxVendedor.Size = new Size(244, 132);
            pbxVendedor.SizeMode = PictureBoxSizeMode.Zoom;
            pbxVendedor.TabIndex = 8;
            pbxVendedor.TabStop = false;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(tctPrincipal);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INSUMOS DE COMPUTACIÓN";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tctPrincipal.ResumeLayout(false);
            tcbProducto.ResumeLayout(false);
            tcbProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxFotoproducto).EndInit();
            tbcVendedor.ResumeLayout(false);
            tbcVendedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxVendedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem toolStripMenuItem1;
        private MenuStrip menuStrip1;
        private TabControl tctPrincipal;
        private TabPage tcbProducto;
        private TabPage tbcVendedor;
        private TabPage tbcClienteIndividuo;
        private TabPage tbcClienteEmpresa;
        private ImageList imageList1;
        private TextBox txtIVA;
        private TextBox textBox4;
        private TextBox txtPreciocosto;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Label lblSubcategoria;
        private Label lblCategoria;
        private Label lblProveedor;
        private Label lblPrecioventa;
        private Label lblPreciobruto;
        private Label lbIVA;
        private Label lblMargen;
        private Label lblPreciocosto;
        private Label lblDescripcion;
        private Label lblNombre;
        private TextBox txtProveedor;
        private TextBox txtPrecioventa;
        private TextBox txtPreciobruto;
        private PictureBox pbxFotoproducto;
        private ComboBox cboSubcategoria;
        private ComboBox cboCategoria;
        private PictureBox pbxVendedor;
        private MaskedTextBox maskedTextBox1;
        private TextBox txtDNIVendedor;
        private TextBox txtApellido;
        private TextBox txtNombreVendedor;
        private Label lblCUITVendedor;
        private Label lblDNIVendedor;
        private Label lblApellidoVendedor;
        private Label lblNombreVendedor;
    }
}
