using System.Globalization;
using Integrador2026.Datos;
using Integrador2026.Entidades;
using Microsoft.Data.SqlClient;

namespace Integrador2026
{
    public partial class frmPrincipal : Form
    {
        private Image _fotoProductoDefault;
        private Image _fotoVendedorDefault;
        private bool _cargando;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            _fotoProductoDefault = pbxFotoproducto.Image;
            _fotoVendedorDefault = pbxVendedor.Image;

            CargarProductos("");
            CargarVendedores("");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        // 
        //  UTILS GENERALES
        //

        private void Aviso(string mensaje)
        {
            MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Info(string mensaje)
        {
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ErrorBD(string accion, SqlException ex)
        {
            MessageBox.Show($"No se pudo {accion}:\n{ex.Message}", "Error de base de datos",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Convierte texto a número
        private static bool TryNumero(string texto, out decimal valor)
        {
            return decimal.TryParse(texto.Trim(), NumberStyles.AllowDecimalPoint,
                                    CultureInfo.CurrentCulture, out valor);
        }

        // Muestra IMAGEN
        private void MostrarFoto(PictureBox pbx, Image porDefecto, string carpeta, int id)
        {
            if (pbx.Image != null && pbx.Image != porDefecto)
                pbx.Image.Dispose();
            pbx.Image = porDefecto;

            string baseRuta = Path.Combine(Application.StartupPath, "Imagenes", carpeta, id.ToString());
            foreach (string ext in new[] { ".jpg", ".png" })
            {
                if (!File.Exists(baseRuta + ext)) continue;
                try
                {
                    using var img = Image.FromFile(baseRuta + ext);
                    pbx.Image = new Bitmap(img);
                }
                catch (Exception)
                {
                    // la imagen por defecto
                }
                break;
            }
        }

        //
        //  PRODUCTOS
        //

        // ---------- BUSCAR / LISTAR ----------
        private void CargarProductos(string texto)
        {
            try
            {
                _cargando = true;
                dgvProductos.DataSource = ProductoDAL.Buscar(texto);
                FormatearGridProductos();
                dgvProductos.ClearSelection();
            }
            catch (SqlException ex)
            {
                ErrorBD("consultar los productos", ex);
            }
            finally
            {
                _cargando = false;
            }
        }

        private void FormatearGridProductos()
        {
            dgvProductos.Columns["Id"].HeaderText = "Código";
            dgvProductos.Columns["PrecioCosto"].HeaderText = "Precio costo";
            dgvProductos.Columns["PrecioBruto"].HeaderText = "Precio bruto";
            dgvProductos.Columns["PrecioVenta"].HeaderText = "Precio venta";
            dgvProductos.Columns["SubCategoria"].HeaderText = "Subcategoría";
            dgvProductos.Columns["Categoria"].HeaderText = "Categoría";
            dgvProductos.Columns["Descripcion"].HeaderText = "Descripción";

            foreach (string col in new[] { "PrecioCosto", "PrecioBruto", "PrecioVenta" })
                dgvProductos.Columns[col].DefaultCellStyle.Format = "N2";
            foreach (string col in new[] { "Margen", "IVA" })
                dgvProductos.Columns[col].DefaultCellStyle.Format = "0.####";
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            CargarProductos(txtBuscarProducto.Text.Trim());
            if (dgvProductos.Rows.Count == 0)
                Info("No se encontraron productos con ese criterio.");
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (_cargando || dgvProductos.SelectedRows.Count == 0) return;
            if (dgvProductos.SelectedRows[0].DataBoundItem is Producto p)
                MostrarProducto(p);
        }

        private void MostrarProducto(Producto p)
        {
            txtIdProducto.Text = p.Id.ToString();
            txtNombre.Text = p.Nombre;
            txtDescripcion.Text = p.Descripcion;
            txtPreciocosto.Text = p.PrecioCosto.ToString("0.00");
            txtMargen.Text = p.Margen.ToString("0.########");
            txtIVA.Text = p.IVA.ToString("0.########");
            txtPreciobruto.Text = p.PrecioBruto.ToString("N2");
            txtPrecioventa.Text = p.PrecioVenta.ToString("N2");
            txtProveedor.Text = p.Proveedor;
            cboCategoria.Text = p.Categoria;
            cboSubcategoria.Text = p.SubCategoria;
            MostrarFoto(pbxFotoproducto, _fotoProductoDefault, "Productos", p.Id);
        }

        // ---------- LEER Y VALIDAR ----------
        private Producto LeerProducto()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtProveedor.Text))
            {
                Aviso("Complete nombre, descripción y proveedor.");
                return null;
            }
            if (cboCategoria.SelectedIndex < 0 || cboSubcategoria.SelectedIndex < 0)
            {
                Aviso("Seleccione categoría y subcategoría.");
                return null;
            }
            if (!TryNumero(txtPreciocosto.Text, out decimal costo) || costo <= 0)
            {
                Aviso("El precio de costo debe ser un número mayor a 0 (use coma como separador decimal).");
                return null;
            }
            if (!TryNumero(txtMargen.Text, out decimal margen))
            {
                Aviso("El margen debe ser un número en forma decimal. Ejemplo: 0,30 equivale a 30%.");
                return null;
            }
            if (!TryNumero(txtIVA.Text, out decimal iva) || iva > 1)
            {
                Aviso("El IVA debe estar en forma decimal, entre 0 y 1. Ejemplo: 0,21 equivale a 21%.");
                return null;
            }

            int id = string.IsNullOrEmpty(txtIdProducto.Text) ? 0 : int.Parse(txtIdProducto.Text);
            return new Producto(id, txtNombre.Text.Trim(), txtDescripcion.Text.Trim(), costo,
                                (double)margen, (double)iva, txtProveedor.Text.Trim(),
                                cboCategoria.Text, cboSubcategoria.Text);
        }

        // ---------- INSERTAR ----------
        private void btnInsertarProducto_Click(object sender, EventArgs e)
        {
            Producto p = LeerProducto();
            if (p == null) return;
            try
            {
                ProductoDAL.Insertar(p);
                Info("Producto agregado correctamente.");
                LimpiarProducto();
                CargarProductos("");
            }
            catch (SqlException ex)
            {
                ErrorBD("insertar el producto", ex);
            }
        }

        // ---------- MODIFICAR ----------
        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdProducto.Text))
            {
                Aviso("Seleccione de la lista el producto que desea modificar.");
                return;
            }
            Producto p = LeerProducto();
            if (p == null) return;
            try
            {
                if (ProductoDAL.Modificar(p) > 0)
                    Info("Producto modificado correctamente.");
                else
                    Aviso("El producto ya no existe en la base de datos.");
                CargarProductos(txtBuscarProducto.Text.Trim());
            }
            catch (SqlException ex)
            {
                ErrorBD("modificar el producto", ex);
            }
        }

        // ---------- ELIMINAR ----------
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdProducto.Text))
            {
                Aviso("Seleccione de la lista el producto que desea eliminar.");
                return;
            }
            DialogResult r = MessageBox.Show($"¿Está seguro de eliminar el producto \"{txtNombre.Text}\"?",
                                             "Confirmar eliminación",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes) return;
            try
            {
                ProductoDAL.Eliminar(int.Parse(txtIdProducto.Text));
                Info("Producto eliminado.");
                LimpiarProducto();
                CargarProductos("");
            }
            catch (SqlException ex)
            {
                ErrorBD("eliminar el producto", ex);
            }
        }

        // ---------- LIMPIAR ----------
        private void btnLimpiarProducto_Click(object sender, EventArgs e)
        {
            LimpiarProducto();
        }

        private void LimpiarProducto()
        {
            foreach (TextBox t in new[] { txtIdProducto, txtNombre, txtDescripcion, txtPreciocosto,
                                          txtMargen, txtIVA, txtPreciobruto, txtPrecioventa, txtProveedor })
                t.Clear();
            cboCategoria.SelectedIndex = -1;
            cboSubcategoria.SelectedIndex = -1;
            dgvProductos.ClearSelection();
            MostrarFoto(pbxFotoproducto, _fotoProductoDefault, "Productos", 0);
            txtNombre.Focus();
        }

        // ---------- CÁLCULO DE PRECIOS ----------
        private void CalcularPrecios(object sender, EventArgs e)
        {
            if (TryNumero(txtPreciocosto.Text, out decimal costo) &&
                TryNumero(txtMargen.Text, out decimal margen) &&
                TryNumero(txtIVA.Text, out decimal iva))
            {
                decimal bruto = costo + costo * margen;
                txtPreciobruto.Text = bruto.ToString("N2");
                txtPrecioventa.Text = (bruto + bruto * iva).ToString("N2");
            }
            else
            {
                txtPreciobruto.Clear();
                txtPrecioventa.Clear();
            }
        }

        // 
        //  VENDEDORES
        // 

        // ---------- BUSCAR / LISTAR ----------
        private void CargarVendedores(string texto)
        {
            try
            {
                _cargando = true;
                dgvVendedores.DataSource = VendedorDAL.Buscar(texto);
                dgvVendedores.Columns["Id"].HeaderText = "Código";
                dgvVendedores.ClearSelection();
            }
            catch (SqlException ex)
            {
                ErrorBD("consultar los vendedores", ex);
            }
            finally
            {
                _cargando = false;
            }
        }

        private void btnBuscarVendedor_Click(object sender, EventArgs e)
        {
            CargarVendedores(txtBuscarVendedor.Text.Trim());
            if (dgvVendedores.Rows.Count == 0)
                Info("No se encontraron vendedores con ese criterio.");
        }

        private void dgvVendedores_SelectionChanged(object sender, EventArgs e)
        {
            if (_cargando || dgvVendedores.SelectedRows.Count == 0) return;
            if (dgvVendedores.SelectedRows[0].DataBoundItem is Vendedor v)
            {
                txtIdVendedor.Text = v.Id.ToString();
                txtNombreVendedor.Text = v.Nombre;
                txtApellidoVendedor.Text = v.Apellido;
                txtDNIVendedor.Text = v.DNI;
                mskCUITVendedor.Text = v.CUIT;
                MostrarFoto(pbxVendedor, _fotoVendedorDefault, "Vendedores", v.Id);
            }
        }

        // ---------- LEER Y VALIDAR ----------
        private Vendedor LeerVendedor()
        {
            if (string.IsNullOrWhiteSpace(txtNombreVendedor.Text) ||
                string.IsNullOrWhiteSpace(txtApellidoVendedor.Text))
            {
                Aviso("Complete nombre y apellido.");
                return null;
            }

            string dni = txtDNIVendedor.Text.Trim();
            if (dni.Length < 7 || dni.Length > 8 || !dni.All(char.IsDigit))
            {
                Aviso("El DNI debe tener 7 u 8 dígitos numéricos.");
                return null;
            }

            if (!mskCUITVendedor.MaskCompleted)
            {
                Aviso("Complete el CUIT (formato 00-00000000-0).");
                return null;
            }

            int id = string.IsNullOrEmpty(txtIdVendedor.Text) ? 0 : int.Parse(txtIdVendedor.Text);
            try
            {
                if (VendedorDAL.ExisteDni(dni, id))
                {
                    Aviso("Ya existe un vendedor con ese DNI.");
                    return null;
                }
            }
            catch (SqlException ex)
            {
                ErrorBD("validar el DNI", ex);
                return null;
            }

            return new Vendedor(id, txtNombreVendedor.Text.Trim(), txtApellidoVendedor.Text.Trim(),
                                dni, mskCUITVendedor.Text);
        }

        // ---------- INSERTAR ----------
        private void btnInsertarVendedor_Click(object sender, EventArgs e)
        {
            Vendedor v = LeerVendedor();
            if (v == null) return;
            try
            {
                VendedorDAL.Insertar(v);
                Info("Vendedor agregado correctamente.");
                LimpiarVendedor();
                CargarVendedores("");
            }
            catch (SqlException ex)
            {
                ErrorBD("insertar el vendedor", ex);
            }
        }

        // ---------- MODIFICAR ----------
        private void btnModificarVendedor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdVendedor.Text))
            {
                Aviso("Seleccione de la lista el vendedor que desea modificar.");
                return;
            }
            Vendedor v = LeerVendedor();
            if (v == null) return;
            try
            {
                if (VendedorDAL.Modificar(v) > 0)
                    Info("Vendedor modificado correctamente.");
                else
                    Aviso("El vendedor ya no existe en la base de datos.");
                CargarVendedores(txtBuscarVendedor.Text.Trim());
            }
            catch (SqlException ex)
            {
                ErrorBD("modificar el vendedor", ex);
            }
        }

        // ---------- ELIMINAR ----------
        private void btnEliminarVendedor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdVendedor.Text))
            {
                Aviso("Seleccione de la lista el vendedor que desea eliminar.");
                return;
            }
            DialogResult r = MessageBox.Show(
                $"¿Está seguro de eliminar a {txtApellidoVendedor.Text}, {txtNombreVendedor.Text}?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes) return;
            try
            {
                VendedorDAL.Eliminar(int.Parse(txtIdVendedor.Text));
                Info("Vendedor eliminado.");
                LimpiarVendedor();
                CargarVendedores("");
            }
            catch (SqlException ex)
            {
                ErrorBD("eliminar el vendedor", ex);
            }
        }

        // ---------- LIMPIAR ----------
        private void btnLimpiarVendedor_Click(object sender, EventArgs e)
        {
            LimpiarVendedor();
        }

        private void LimpiarVendedor()
        {
            txtIdVendedor.Clear();
            txtNombreVendedor.Clear();
            txtApellidoVendedor.Clear();
            txtDNIVendedor.Clear();
            mskCUITVendedor.Clear();
            dgvVendedores.ClearSelection();
            MostrarFoto(pbxVendedor, _fotoVendedorDefault, "Vendedores", 0);
            txtNombreVendedor.Focus();
        }

        // dni son caracteres
        private void txtDNIVendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void pbxVendedor_Click(object sender, EventArgs e)
        {

        }
    }
}
