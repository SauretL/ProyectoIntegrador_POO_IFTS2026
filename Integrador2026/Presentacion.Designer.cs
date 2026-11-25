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
            dgvProductos = new DataGridView();
            btnLimpiarProducto = new Button();
            btnEliminarProducto = new Button();
            btnModificarProducto = new Button();
            btnInsertarProducto = new Button();
            pbxFotoproducto = new PictureBox();
            cboSubcategoria = new ComboBox();
            lblSubcategoria = new Label();
            cboCategoria = new ComboBox();
            lblCategoria = new Label();
            txtProveedor = new TextBox();
            lblProveedor = new Label();
            txtPrecioventa = new TextBox();
            lblPrecioventa = new Label();
            txtPreciobruto = new TextBox();
            lblPreciobruto = new Label();
            txtIVA = new TextBox();
            lbIVA = new Label();
            txtMargen = new TextBox();
            lblMargen = new Label();
            txtPreciocosto = new TextBox();
            lblPreciocosto = new Label();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtIdProducto = new TextBox();
            lblIdProducto = new Label();
            btnBuscarProducto = new Button();
            txtBuscarProducto = new TextBox();
            lblBuscarProducto = new Label();
            tbcVendedor = new TabPage();
            dgvVendedores = new DataGridView();
            btnLimpiarVendedor = new Button();
            btnEliminarVendedor = new Button();
            btnModificarVendedor = new Button();
            btnInsertarVendedor = new Button();
            pbxVendedor = new PictureBox();
            mskCUITVendedor = new MaskedTextBox();
            lblCUITVendedor = new Label();
            txtDNIVendedor = new TextBox();
            lblDNIVendedor = new Label();
            txtApellidoVendedor = new TextBox();
            lblApellidoVendedor = new Label();
            txtNombreVendedor = new TextBox();
            lblNombreVendedor = new Label();
            txtIdVendedor = new TextBox();
            lblIdVendedor = new Label();
            btnBuscarVendedor = new Button();
            txtBuscarVendedor = new TextBox();
            lblBuscarVendedor = new Label();
            tbcClienteIndividuo = new TabPage();
            tbcClienteEmpresa = new TabPage();
            imageList1 = new ImageList(components);
            menuStrip1.SuspendLayout();
            tctPrincipal.SuspendLayout();
            tcbProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxFotoproducto).BeginInit();
            tbcVendedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVendedores).BeginInit();
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
            menuStrip1.Size = new Size(979, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "Archivo";
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
            tctPrincipal.Size = new Size(979, 636);
            tctPrincipal.SizeMode = TabSizeMode.Fixed;
            tctPrincipal.TabIndex = 1;
            // 
            // tcbProducto
            // 
            tcbProducto.Controls.Add(dgvProductos);
            tcbProducto.Controls.Add(btnLimpiarProducto);
            tcbProducto.Controls.Add(btnEliminarProducto);
            tcbProducto.Controls.Add(btnModificarProducto);
            tcbProducto.Controls.Add(btnInsertarProducto);
            tcbProducto.Controls.Add(pbxFotoproducto);
            tcbProducto.Controls.Add(cboSubcategoria);
            tcbProducto.Controls.Add(lblSubcategoria);
            tcbProducto.Controls.Add(cboCategoria);
            tcbProducto.Controls.Add(lblCategoria);
            tcbProducto.Controls.Add(txtProveedor);
            tcbProducto.Controls.Add(lblProveedor);
            tcbProducto.Controls.Add(txtPrecioventa);
            tcbProducto.Controls.Add(lblPrecioventa);
            tcbProducto.Controls.Add(txtPreciobruto);
            tcbProducto.Controls.Add(lblPreciobruto);
            tcbProducto.Controls.Add(txtIVA);
            tcbProducto.Controls.Add(lbIVA);
            tcbProducto.Controls.Add(txtMargen);
            tcbProducto.Controls.Add(lblMargen);
            tcbProducto.Controls.Add(txtPreciocosto);
            tcbProducto.Controls.Add(lblPreciocosto);
            tcbProducto.Controls.Add(txtDescripcion);
            tcbProducto.Controls.Add(lblDescripcion);
            tcbProducto.Controls.Add(txtNombre);
            tcbProducto.Controls.Add(lblNombre);
            tcbProducto.Controls.Add(txtIdProducto);
            tcbProducto.Controls.Add(lblIdProducto);
            tcbProducto.Controls.Add(btnBuscarProducto);
            tcbProducto.Controls.Add(txtBuscarProducto);
            tcbProducto.Controls.Add(lblBuscarProducto);
            tcbProducto.ImageIndex = 2;
            tcbProducto.Location = new Point(4, 24);
            tcbProducto.Name = "tcbProducto";
            tcbProducto.Padding = new Padding(3);
            tcbProducto.Size = new Size(971, 608);
            tcbProducto.TabIndex = 0;
            tcbProducto.Text = "Productos";
            tcbProducto.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(38, 330);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(901, 255);
            dgvProductos.TabIndex = 30;
            dgvProductos.SelectionChanged += dgvProductos_SelectionChanged;
            // 
            // btnLimpiarProducto
            // 
            btnLimpiarProducto.Location = new Point(398, 285);
            btnLimpiarProducto.Name = "btnLimpiarProducto";
            btnLimpiarProducto.Size = new Size(110, 30);
            btnLimpiarProducto.TabIndex = 29;
            btnLimpiarProducto.Text = "Limpiar";
            btnLimpiarProducto.UseVisualStyleBackColor = true;
            btnLimpiarProducto.Click += btnLimpiarProducto_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(278, 285);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(110, 30);
            btnEliminarProducto.TabIndex = 28;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.Location = new Point(158, 285);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(110, 30);
            btnModificarProducto.TabIndex = 27;
            btnModificarProducto.Text = "Modificar";
            btnModificarProducto.UseVisualStyleBackColor = true;
            btnModificarProducto.Click += btnModificarProducto_Click;
            // 
            // btnInsertarProducto
            // 
            btnInsertarProducto.Location = new Point(38, 285);
            btnInsertarProducto.Name = "btnInsertarProducto";
            btnInsertarProducto.Size = new Size(110, 30);
            btnInsertarProducto.TabIndex = 26;
            btnInsertarProducto.Text = "Insertar";
            btnInsertarProducto.UseVisualStyleBackColor = true;
            btnInsertarProducto.Click += btnInsertarProducto_Click;
            // 
            // pbxFotoproducto
            // 
            pbxFotoproducto.Image = (Image)resources.GetObject("pbxFotoproducto.Image");
            pbxFotoproducto.Location = new Point(770, 62);
            pbxFotoproducto.Name = "pbxFotoproducto";
            pbxFotoproducto.Size = new Size(177, 211);
            pbxFotoproducto.SizeMode = PictureBoxSizeMode.Zoom;
            pbxFotoproducto.TabIndex = 25;
            pbxFotoproducto.TabStop = false;
            // 
            // cboSubcategoria
            // 
            cboSubcategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSubcategoria.FormattingEnabled = true;
            cboSubcategoria.Items.AddRange(new object[] { "SUBCATEGORIA A.A", "SUBCATEGORIA A.B", "SUBCATEGORIA A.C", "SUBCATEGORIA B.A", "SUBCATEGORIA B.B", "SUBCATEGORIA B.C", "SUBCATEGORIA C.A", "SUBCATEGORIA C.B", "SUBCATEGORIA C.C" });
            cboSubcategoria.Location = new Point(520, 202);
            cboSubcategoria.Name = "cboSubcategoria";
            cboSubcategoria.Size = new Size(220, 23);
            cboSubcategoria.TabIndex = 24;
            // 
            // lblSubcategoria
            // 
            lblSubcategoria.AutoSize = true;
            lblSubcategoria.Location = new Point(400, 206);
            lblSubcategoria.Name = "lblSubcategoria";
            lblSubcategoria.Size = new Size(86, 15);
            lblSubcategoria.TabIndex = 23;
            lblSubcategoria.Text = "Subcategoria";
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Items.AddRange(new object[] { "CATEGORIA A", "CATEGORIA B", "CATEGORIA C" });
            cboCategoria.Location = new Point(520, 167);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(220, 23);
            cboCategoria.TabIndex = 22;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(400, 171);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(66, 15);
            lblCategoria.TabIndex = 21;
            lblCategoria.Text = "Categoria";
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(520, 132);
            txtProveedor.MaxLength = 100;
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(220, 21);
            txtProveedor.TabIndex = 20;
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(400, 136);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(69, 15);
            lblProveedor.TabIndex = 19;
            lblProveedor.Text = "Proveedor";
            // 
            // txtPrecioventa
            // 
            txtPrecioventa.Location = new Point(520, 97);
            txtPrecioventa.Name = "txtPrecioventa";
            txtPrecioventa.ReadOnly = true;
            txtPrecioventa.Size = new Size(220, 21);
            txtPrecioventa.TabIndex = 18;
            // 
            // lblPrecioventa
            // 
            lblPrecioventa.AutoSize = true;
            lblPrecioventa.Location = new Point(400, 101);
            lblPrecioventa.Name = "lblPrecioventa";
            lblPrecioventa.Size = new Size(85, 15);
            lblPrecioventa.TabIndex = 17;
            lblPrecioventa.Text = "Precio Venta";
            // 
            // txtPreciobruto
            // 
            txtPreciobruto.Location = new Point(520, 62);
            txtPreciobruto.Name = "txtPreciobruto";
            txtPreciobruto.ReadOnly = true;
            txtPreciobruto.Size = new Size(220, 21);
            txtPreciobruto.TabIndex = 16;
            // 
            // lblPreciobruto
            // 
            lblPreciobruto.AutoSize = true;
            lblPreciobruto.Location = new Point(400, 66);
            lblPreciobruto.Name = "lblPreciobruto";
            lblPreciobruto.Size = new Size(84, 15);
            lblPreciobruto.TabIndex = 15;
            lblPreciobruto.Text = "Precio Bruto";
            // 
            // txtIVA
            // 
            txtIVA.Location = new Point(140, 237);
            txtIVA.Name = "txtIVA";
            txtIVA.Size = new Size(220, 21);
            txtIVA.TabIndex = 14;
            txtIVA.TextChanged += CalcularPrecios;
            // 
            // lbIVA
            // 
            lbIVA.AutoSize = true;
            lbIVA.Location = new Point(38, 241);
            lbIVA.Name = "lbIVA";
            lbIVA.Size = new Size(30, 15);
            lbIVA.TabIndex = 13;
            lbIVA.Text = "IVA";
            // 
            // txtMargen
            // 
            txtMargen.Location = new Point(140, 202);
            txtMargen.Name = "txtMargen";
            txtMargen.Size = new Size(220, 21);
            txtMargen.TabIndex = 12;
            txtMargen.TextChanged += CalcularPrecios;
            // 
            // lblMargen
            // 
            lblMargen.AutoSize = true;
            lblMargen.Location = new Point(38, 206);
            lblMargen.Name = "lblMargen";
            lblMargen.Size = new Size(53, 15);
            lblMargen.TabIndex = 11;
            lblMargen.Text = "Margen";
            // 
            // txtPreciocosto
            // 
            txtPreciocosto.Location = new Point(140, 167);
            txtPreciocosto.Name = "txtPreciocosto";
            txtPreciocosto.Size = new Size(220, 21);
            txtPreciocosto.TabIndex = 10;
            txtPreciocosto.TextChanged += CalcularPrecios;
            // 
            // lblPreciocosto
            // 
            lblPreciocosto.AutoSize = true;
            lblPreciocosto.Location = new Point(43, 171);
            lblPreciocosto.Name = "lblPreciocosto";
            lblPreciocosto.Size = new Size(83, 15);
            lblPreciocosto.TabIndex = 9;
            lblPreciocosto.Text = "Precio Costo";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(140, 132);
            txtDescripcion.MaxLength = 150;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(220, 21);
            txtDescripcion.TabIndex = 8;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(38, 136);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(77, 15);
            lblDescripcion.TabIndex = 7;
            lblDescripcion.Text = "Descripción";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(140, 97);
            txtNombre.MaxLength = 60;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(220, 21);
            txtNombre.TabIndex = 6;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(43, 101);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(55, 15);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre";
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(140, 62);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.ReadOnly = true;
            txtIdProducto.Size = new Size(220, 21);
            txtIdProducto.TabIndex = 4;
            // 
            // lblIdProducto
            // 
            lblIdProducto.AutoSize = true;
            lblIdProducto.Location = new Point(43, 68);
            lblIdProducto.Name = "lblIdProducto";
            lblIdProducto.Size = new Size(48, 15);
            lblIdProducto.TabIndex = 3;
            lblIdProducto.Text = "Código";
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Location = new Point(425, 10);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(100, 27);
            btnBuscarProducto.TabIndex = 2;
            btnBuscarProducto.Text = "Buscar";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new Point(110, 13);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(300, 21);
            txtBuscarProducto.TabIndex = 1;
            // 
            // lblBuscarProducto
            // 
            lblBuscarProducto.AutoSize = true;
            lblBuscarProducto.Location = new Point(38, 17);
            lblBuscarProducto.Name = "lblBuscarProducto";
            lblBuscarProducto.Size = new Size(49, 15);
            lblBuscarProducto.TabIndex = 0;
            lblBuscarProducto.Text = "Buscar";
            // 
            // tbcVendedor
            // 
            tbcVendedor.Controls.Add(dgvVendedores);
            tbcVendedor.Controls.Add(btnLimpiarVendedor);
            tbcVendedor.Controls.Add(btnEliminarVendedor);
            tbcVendedor.Controls.Add(btnModificarVendedor);
            tbcVendedor.Controls.Add(btnInsertarVendedor);
            tbcVendedor.Controls.Add(pbxVendedor);
            tbcVendedor.Controls.Add(mskCUITVendedor);
            tbcVendedor.Controls.Add(lblCUITVendedor);
            tbcVendedor.Controls.Add(txtDNIVendedor);
            tbcVendedor.Controls.Add(lblDNIVendedor);
            tbcVendedor.Controls.Add(txtApellidoVendedor);
            tbcVendedor.Controls.Add(lblApellidoVendedor);
            tbcVendedor.Controls.Add(txtNombreVendedor);
            tbcVendedor.Controls.Add(lblNombreVendedor);
            tbcVendedor.Controls.Add(txtIdVendedor);
            tbcVendedor.Controls.Add(lblIdVendedor);
            tbcVendedor.Controls.Add(btnBuscarVendedor);
            tbcVendedor.Controls.Add(txtBuscarVendedor);
            tbcVendedor.Controls.Add(lblBuscarVendedor);
            tbcVendedor.ImageIndex = 3;
            tbcVendedor.Location = new Point(4, 24);
            tbcVendedor.Name = "tbcVendedor";
            tbcVendedor.Padding = new Padding(3);
            tbcVendedor.Size = new Size(971, 608);
            tbcVendedor.TabIndex = 1;
            tbcVendedor.Text = "Vendedores";
            tbcVendedor.UseVisualStyleBackColor = true;
            // 
            // dgvVendedores
            // 
            dgvVendedores.AllowUserToAddRows = false;
            dgvVendedores.AllowUserToDeleteRows = false;
            dgvVendedores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVendedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVendedores.Location = new Point(38, 330);
            dgvVendedores.MultiSelect = false;
            dgvVendedores.Name = "dgvVendedores";
            dgvVendedores.ReadOnly = true;
            dgvVendedores.RowHeadersVisible = false;
            dgvVendedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVendedores.Size = new Size(901, 255);
            dgvVendedores.TabIndex = 18;
            dgvVendedores.SelectionChanged += dgvVendedores_SelectionChanged;
            // 
            // btnLimpiarVendedor
            // 
            btnLimpiarVendedor.Location = new Point(398, 285);
            btnLimpiarVendedor.Name = "btnLimpiarVendedor";
            btnLimpiarVendedor.Size = new Size(110, 30);
            btnLimpiarVendedor.TabIndex = 17;
            btnLimpiarVendedor.Text = "Limpiar";
            btnLimpiarVendedor.UseVisualStyleBackColor = true;
            btnLimpiarVendedor.Click += btnLimpiarVendedor_Click;
            // 
            // btnEliminarVendedor
            // 
            btnEliminarVendedor.Location = new Point(278, 285);
            btnEliminarVendedor.Name = "btnEliminarVendedor";
            btnEliminarVendedor.Size = new Size(110, 30);
            btnEliminarVendedor.TabIndex = 16;
            btnEliminarVendedor.Text = "Eliminar";
            btnEliminarVendedor.UseVisualStyleBackColor = true;
            btnEliminarVendedor.Click += btnEliminarVendedor_Click;
            // 
            // btnModificarVendedor
            // 
            btnModificarVendedor.Location = new Point(158, 285);
            btnModificarVendedor.Name = "btnModificarVendedor";
            btnModificarVendedor.Size = new Size(110, 30);
            btnModificarVendedor.TabIndex = 15;
            btnModificarVendedor.Text = "Modificar";
            btnModificarVendedor.UseVisualStyleBackColor = true;
            btnModificarVendedor.Click += btnModificarVendedor_Click;
            // 
            // btnInsertarVendedor
            // 
            btnInsertarVendedor.Location = new Point(38, 285);
            btnInsertarVendedor.Name = "btnInsertarVendedor";
            btnInsertarVendedor.Size = new Size(110, 30);
            btnInsertarVendedor.TabIndex = 14;
            btnInsertarVendedor.Text = "Insertar";
            btnInsertarVendedor.UseVisualStyleBackColor = true;
            btnInsertarVendedor.Click += btnInsertarVendedor_Click;
            // 
            // pbxVendedor
            // 
            pbxVendedor.Image = (Image)resources.GetObject("pbxVendedor.Image");
            pbxVendedor.Location = new Point(420, 62);
            pbxVendedor.Name = "pbxVendedor";
            pbxVendedor.Size = new Size(519, 198);
            pbxVendedor.SizeMode = PictureBoxSizeMode.Zoom;
            pbxVendedor.TabIndex = 13;
            pbxVendedor.TabStop = false;
            pbxVendedor.Click += pbxVendedor_Click;
            // 
            // mskCUITVendedor
            // 
            mskCUITVendedor.Location = new Point(140, 202);
            mskCUITVendedor.Mask = "00-00000000-0";
            mskCUITVendedor.Name = "mskCUITVendedor";
            mskCUITVendedor.Size = new Size(220, 21);
            mskCUITVendedor.TabIndex = 12;
            // 
            // lblCUITVendedor
            // 
            lblCUITVendedor.AutoSize = true;
            lblCUITVendedor.Location = new Point(38, 206);
            lblCUITVendedor.Name = "lblCUITVendedor";
            lblCUITVendedor.Size = new Size(39, 15);
            lblCUITVendedor.TabIndex = 11;
            lblCUITVendedor.Text = "CUIT";
            // 
            // txtDNIVendedor
            // 
            txtDNIVendedor.Location = new Point(140, 167);
            txtDNIVendedor.MaxLength = 8;
            txtDNIVendedor.Name = "txtDNIVendedor";
            txtDNIVendedor.Size = new Size(220, 21);
            txtDNIVendedor.TabIndex = 10;
            txtDNIVendedor.KeyPress += txtDNIVendedor_KeyPress;
            // 
            // lblDNIVendedor
            // 
            lblDNIVendedor.AutoSize = true;
            lblDNIVendedor.Location = new Point(38, 170);
            lblDNIVendedor.Name = "lblDNIVendedor";
            lblDNIVendedor.Size = new Size(31, 15);
            lblDNIVendedor.TabIndex = 9;
            lblDNIVendedor.Text = "DNI";
            // 
            // txtApellidoVendedor
            // 
            txtApellidoVendedor.Location = new Point(140, 132);
            txtApellidoVendedor.MaxLength = 100;
            txtApellidoVendedor.Name = "txtApellidoVendedor";
            txtApellidoVendedor.Size = new Size(220, 21);
            txtApellidoVendedor.TabIndex = 8;
            // 
            // lblApellidoVendedor
            // 
            lblApellidoVendedor.AutoSize = true;
            lblApellidoVendedor.Location = new Point(38, 136);
            lblApellidoVendedor.Name = "lblApellidoVendedor";
            lblApellidoVendedor.Size = new Size(56, 15);
            lblApellidoVendedor.TabIndex = 7;
            lblApellidoVendedor.Text = "Apellido";
            // 
            // txtNombreVendedor
            // 
            txtNombreVendedor.Location = new Point(140, 97);
            txtNombreVendedor.MaxLength = 100;
            txtNombreVendedor.Name = "txtNombreVendedor";
            txtNombreVendedor.Size = new Size(220, 21);
            txtNombreVendedor.TabIndex = 6;
            // 
            // lblNombreVendedor
            // 
            lblNombreVendedor.AutoSize = true;
            lblNombreVendedor.Location = new Point(45, 100);
            lblNombreVendedor.Name = "lblNombreVendedor";
            lblNombreVendedor.Size = new Size(55, 15);
            lblNombreVendedor.TabIndex = 5;
            lblNombreVendedor.Text = "Nombre";
            // 
            // txtIdVendedor
            // 
            txtIdVendedor.Location = new Point(140, 62);
            txtIdVendedor.Name = "txtIdVendedor";
            txtIdVendedor.ReadOnly = true;
            txtIdVendedor.Size = new Size(220, 21);
            txtIdVendedor.TabIndex = 4;
            // 
            // lblIdVendedor
            // 
            lblIdVendedor.AutoSize = true;
            lblIdVendedor.Location = new Point(45, 65);
            lblIdVendedor.Name = "lblIdVendedor";
            lblIdVendedor.Size = new Size(48, 15);
            lblIdVendedor.TabIndex = 3;
            lblIdVendedor.Text = "Código";
            // 
            // btnBuscarVendedor
            // 
            btnBuscarVendedor.Location = new Point(425, 10);
            btnBuscarVendedor.Name = "btnBuscarVendedor";
            btnBuscarVendedor.Size = new Size(100, 27);
            btnBuscarVendedor.TabIndex = 2;
            btnBuscarVendedor.Text = "Buscar";
            btnBuscarVendedor.UseVisualStyleBackColor = true;
            btnBuscarVendedor.Click += btnBuscarVendedor_Click;
            // 
            // txtBuscarVendedor
            // 
            txtBuscarVendedor.Location = new Point(110, 13);
            txtBuscarVendedor.Name = "txtBuscarVendedor";
            txtBuscarVendedor.Size = new Size(300, 21);
            txtBuscarVendedor.TabIndex = 1;
            // 
            // lblBuscarVendedor
            // 
            lblBuscarVendedor.AutoSize = true;
            lblBuscarVendedor.Location = new Point(38, 17);
            lblBuscarVendedor.Name = "lblBuscarVendedor";
            lblBuscarVendedor.Size = new Size(49, 15);
            lblBuscarVendedor.TabIndex = 0;
            lblBuscarVendedor.Text = "Buscar";
            // 
            // tbcClienteIndividuo
            // 
            tbcClienteIndividuo.ImageIndex = 0;
            tbcClienteIndividuo.Location = new Point(4, 24);
            tbcClienteIndividuo.Name = "tbcClienteIndividuo";
            tbcClienteIndividuo.Size = new Size(971, 608);
            tbcClienteIndividuo.TabIndex = 2;
            tbcClienteIndividuo.Text = "Clientes";
            tbcClienteIndividuo.UseVisualStyleBackColor = true;
            // 
            // tbcClienteEmpresa
            // 
            tbcClienteEmpresa.ImageIndex = 1;
            tbcClienteEmpresa.Location = new Point(4, 24);
            tbcClienteEmpresa.Name = "tbcClienteEmpresa";
            tbcClienteEmpresa.Size = new Size(971, 608);
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
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 660);
            Controls.Add(tctPrincipal);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INSUMOS DE COMPUTACIÓN";
            Load += frmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tctPrincipal.ResumeLayout(false);
            tcbProducto.ResumeLayout(false);
            tcbProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxFotoproducto).EndInit();
            tbcVendedor.ResumeLayout(false);
            tbcVendedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVendedores).EndInit();
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
        private Label lblBuscarProducto;
        private TextBox txtBuscarProducto;
        private Button btnBuscarProducto;
        private Label lblIdProducto;
        private TextBox txtIdProducto;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private Label lblPreciocosto;
        private TextBox txtPreciocosto;
        private Label lblMargen;
        private TextBox txtMargen;
        private Label lbIVA;
        private TextBox txtIVA;
        private Label lblPreciobruto;
        private TextBox txtPreciobruto;
        private Label lblPrecioventa;
        private TextBox txtPrecioventa;
        private Label lblProveedor;
        private TextBox txtProveedor;
        private Label lblCategoria;
        private ComboBox cboCategoria;
        private Label lblSubcategoria;
        private ComboBox cboSubcategoria;
        private PictureBox pbxFotoproducto;
        private Button btnInsertarProducto;
        private Button btnModificarProducto;
        private Button btnEliminarProducto;
        private Button btnLimpiarProducto;
        private DataGridView dgvProductos;
        private Label lblBuscarVendedor;
        private TextBox txtBuscarVendedor;
        private Button btnBuscarVendedor;
        private Label lblIdVendedor;
        private TextBox txtIdVendedor;
        private Label lblNombreVendedor;
        private TextBox txtNombreVendedor;
        private Label lblApellidoVendedor;
        private TextBox txtApellidoVendedor;
        private Label lblDNIVendedor;
        private TextBox txtDNIVendedor;
        private Label lblCUITVendedor;
        private MaskedTextBox mskCUITVendedor;
        private PictureBox pbxVendedor;
        private Button btnInsertarVendedor;
        private Button btnModificarVendedor;
        private Button btnEliminarVendedor;
        private Button btnLimpiarVendedor;
        private DataGridView dgvVendedores;
    }
}
