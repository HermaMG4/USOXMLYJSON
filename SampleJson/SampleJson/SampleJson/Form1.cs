using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SampleJson
{
    public partial class Inicio : Form
    {
        //List<Usuario> ususarios = new List<Usuario>();

        public Inicio()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            botInicio.BackColor = Color.Snow;
            bot2.BackColor = Color.Snow;
            botCuenta.BackColor = Color.Khaki;
            botAgregar.BackColor = Color.Snow; 
            lblInicio.Visible = false;
            lblAgregarPsinC.Visible = false;
            gboxVerProductos.Visible = false;
            if (gboxCuentaIni.Visible == false)
            {
                gboxCuenta.Visible = true;
                gboxAgregarP.Visible = false;
                
            }
            else
            {
                gboxCuenta.Visible = false;
            }

        }

        private void gboxCuenta_Enter(object sender, EventArgs e)
        {

        }

        private void botIniciarSesion_Click(object sender, EventArgs e)
        {
            gboxIniciarSesion.Visible = !gboxIniciarSesion.Visible;
            txtboxUser.Text = string.Empty;
            txtboxPassword.Text = string.Empty;
            gboxCrearCuenta.Visible = false;
        }

        private void lblInicio_Click(object sender, EventArgs e)
        {

        }

        private void gboxProductos_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botCrearCuenta_Click(object sender, EventArgs e)
        {
            gboxCrearCuenta.Visible = !gboxCrearCuenta.Visible;
            txtboxName.Text = string.Empty;
            txtboxEmail.Text = string.Empty;
            txtboxContra.Text = string.Empty;
            gboxIniciarSesion.Visible = false;

        }

        private void botCrear_Click(object sender, EventArgs e)
        {
            #region "Agregar usuario al archivo Json"
            Usuario usuario;
            string user = txtboxName.Text;
            string password = txtboxContra.Text;
            if (ValidarEmail(txtboxEmail.Text) == false)
            {
                lblmsgCrearCuenta.ForeColor = Color.Red;
                lblmsgCrearCuenta.Text = "(?) Email no válido.";
            }
            else
            {
                usuario = new Usuario(txtboxName.Text, txtboxContra.Text, txtboxEmail.Text);

                List<Usuario> usuarios = new List<Usuario>();
                //checar si ya existe un Json que guarda usuarios
                if (File.Exists("UsuariosJson.txt"))
                {
                    string Json = File.ReadAllText("UsuariosJson.txt");
                    usuarios = JsonConvert.DeserializeObject<List<Usuario>>(Json);
                }

                //agregar usuario al archivo Json
                usuarios.Add(usuario);
                string usuariosJson = JsonConvert.SerializeObject(usuarios, Formatting.Indented);
                File.WriteAllText("UsuariosJson.txt", usuariosJson);

                //vaciar caja de texto y mostrar mensaje de cuenta creada
                txtboxName.Text = string.Empty;
                txtboxEmail.Text = string.Empty;
                txtboxContra.Text = string.Empty;
                lblmsgCrearCuenta.ForeColor= Color.Green;
                lblmsgCrearCuenta.Text = "(!) Cuenta creada exitosamente";
            }
            
         
           
            #endregion

        }

        private void botIniciarS_Click(object sender, EventArgs e)
        {
            #region "Iniciar sesion en cuentas del archivo Json"
            List<Usuario> UsuariosCreados = new List<Usuario>();
            if (File.Exists("UsuariosJson.txt"))
            {
                string Json = File.ReadAllText("UsuariosJson.txt");
                UsuariosCreados = JsonConvert.DeserializeObject<List<Usuario>>(Json);
            }
            foreach (var user in UsuariosCreados)
            {
                string username = user.Username;
                string password = user.Password;
                if (username == txtboxUser.Text)
                {
                    if(password == txtboxPassword.Text)
                    {
                        lblmsgIniciarSesion.ForeColor = Color.Green;
                        lblmsgIniciarSesion.Text = "(!) Ha iniciado sesión exitosamente.";
                        txtboxUser.Text = string.Empty;
                        txtboxPassword.Text = string.Empty;
                        gboxCuentaIni.Visible = true;
                        gboxCuenta.Visible = false;
                        lblUserName.Text = username;
                        
                    }
                    else 
                    {
                        lblmsgIniciarSesion.ForeColor = Color.Red;
                        lblmsgIniciarSesion.Text = "(?) Contraseña incorrecta.";
                    }
                }
                else
                {
                    lblmsgIniciarSesion.ForeColor = Color.Red;
                    lblmsgIniciarSesion.Text = "(X) El usuario no existe.";
                }
            }
            #endregion
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }



        private void botInicio_Click(object sender, EventArgs e)
        {
            botInicio.BackColor = Color.Khaki;
            bot2.BackColor = Color.Snow;
            botCuenta.BackColor = Color.Snow;
            botAgregar.BackColor = Color.Snow;
            gboxCuenta.Visible=false;
            lblInicio.Visible = true;
            gboxAgregarP.Visible = false;
            lblAgregarPsinC.Visible = false;
            gboxVerProductos.Visible = false;
        }

        private void botCerrarS_Click(object sender, EventArgs e)
        {
            botInicio.BackColor = Color.Snow;
            bot2.BackColor = Color.Snow;
            botCuenta.BackColor = Color.Khaki;
            botAgregar.BackColor = Color.Snow;
            gboxCuenta.Visible= true;
            lblmsgIniciarSesion.Text= string.Empty;
            gboxCuentaIni.Visible= false;
            gboxAgregarP.Visible= false;    
            gboxVerProductos.Visible= false;
        }

        private void bot2_Click(object sender, EventArgs e)
        {
            botInicio.BackColor = Color.Snow;
            bot2.BackColor = Color.Khaki;
            botCuenta.BackColor = Color.Snow;
            botAgregar.BackColor = Color.Snow;
            lblInicio.Visible = false;
            gboxCuenta.Visible = false;
            gboxAgregarP.Visible = false;
            if (gboxCuentaIni.Visible == true)
            {
                gboxVerProductos.Visible = true;
                lblAgregarPsinC.Visible= false;
            }
            else
            {
                lblAgregarPsinC.Visible = true;
                gboxVerProductos.Visible= false;
            }
        }

        private void botAgregar_Click(object sender, EventArgs e)
        {
            botInicio.BackColor = Color.Snow;
            bot2.BackColor = Color.Snow;
            botCuenta.BackColor = Color.Snow;
            botAgregar.BackColor = Color.Khaki;
            lblInicio.Visible = false;
            gboxCuenta.Visible= false;
            gboxVerProductos.Visible = false;
            if (gboxCuentaIni.Visible == true)
            {
                lblAgregarPsinC.Visible= false;
                gboxAgregarP.Visible = true;
            }
            else
            {
                lblAgregarPsinC.Visible = true;
            }
        }

        private static bool ValidarEmail(string ComprobarEmail)
        {
            string emailFormato = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (Regex.IsMatch(ComprobarEmail, emailFormato))
            {
                if (Regex.Replace(ComprobarEmail, emailFormato, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void botAgregarP_Click(object sender, EventArgs e)
        {
            #region "Obtener propiedades del producto"

            //obtener nombre del producto 
            //bool j = true;
            string nombreProducto = string.Empty;
            if (txtboxNameP.Text == string.Empty)
            {
                lblErrorAgregar.ForeColor = Color.Red;
                lblErrorAgregar.Text = "(?) Ingresar el nombre del producto.";
            }
            else
            {
                nombreProducto = txtboxNameP.Text;
            }

            //Obtener categoria
            string categoria = string.Empty;
            if (comboxCategoria.Text == string.Empty)
            {
                lblErrorAgregar.ForeColor = Color.Red;
                lblErrorAgregar.Text = "(?) Seleccione una categoría.";
            }
            else
            {
                categoria = comboxCategoria.Text;
            }

            //obtener precio
            double precioProducto = 0;
            if (txtboxPrecioP.Text != string.Empty)
            {
                precioProducto = Double.Parse(txtboxPrecioP.Text);
            }
            else
            {
                lblErrorAgregar.ForeColor = Color.Red;
                lblErrorAgregar.Text = "(?) Ingrese un precio.";
            }




            #endregion

            //Asegurarse que no se cree un objeto null
            if ((categoria != string.Empty) && (nombreProducto != string.Empty) && (txtboxPrecioP.Text != string.Empty))
            {
                Producto producto = new Producto(nombreProducto, categoria, precioProducto);
                //Checar si existe un Json con productos
                List<Producto> Productos = new List<Producto>();
                if (File.Exists("ProductosJson.txt"))
                {
                    string Json = File.ReadAllText("ProductosJson.txt");
                    Productos = JsonConvert.DeserializeObject<List<Producto>>(Json);
                }

                //guardar producto en archivo Json
                Productos.Add(producto);
                string productosJson = JsonConvert.SerializeObject(Productos, Formatting.Indented);
                File.WriteAllText("ProductosJson.txt", productosJson);

                txtboxNameP.Text = string.Empty;
                txtboxPrecioP.Text = string.Empty;
                lblErrorAgregar.ForeColor = Color.Green;
                lblErrorAgregar.Text = "(!) El producto se ha agregado exitosamente.";
            }
            
        }

        private void txtboxPrecioP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxPrecioP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (e.KeyChar != '.'))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void lstboxPDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void botActualizarLst_Click(object sender, EventArgs e)
        {
            double precio = 0;
            List<Producto> listaProductos = new List<Producto>();
            lstboxPDisponibles.Items.Clear();
            if (File.Exists("ProductosJson.txt"))
            {
                //leer Json de productos
                string Json = File.ReadAllText("ProductosJson.txt");
                listaProductos = JsonConvert.DeserializeObject<List<Producto>>(Json);

                //añadir productos a la listbox
                foreach (var producto in listaProductos)
                {
                    lstboxPDisponibles.Items.Add(producto);
                    precio += producto.Precio;
                }
                lblShowPrice.Text = $"C${precio.ToString()}";
            }
            else
            {
                MessageBox.Show("Información","Aún no se han añadido productos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gboxVerProductos_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void botEliminarP_Click(object sender, EventArgs e)
        {
            List<Producto> listaProductos = new List<Producto>();
            lstboxPDisponibles.Items.Clear();
            if (File.Exists("ProductosJson.txt") && txtboxNamePEliminar.Text != string.Empty)
            {
                string Json = File.ReadAllText("ProductosJson.txt");
                listaProductos = JsonConvert.DeserializeObject<List<Producto>>(Json);

                //eliminar producto
                Producto productoAEliminar = listaProductos.Find(p => p.NombreProducto == txtboxNamePEliminar.Text);
                listaProductos.Remove(productoAEliminar);
                lblShowmsgE.ForeColor = Color.Green;
                lblShowmsgE.Text = "(?) El producto ha sido eliminado.";

                File.Delete("ProductosJson.txt");
                string productosJson = JsonConvert.SerializeObject(listaProductos);
                File.WriteAllText("ProductosJson.txt", productosJson);
            }
            else
            {
                MessageBox.Show("Información", "No hay productos para eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblCategory_Click(object sender, EventArgs e)
        {

        }

        private void lblShowPrice_Click(object sender, EventArgs e)
        {
            
        }

        private void llbPrice_Click(object sender, EventArgs e)
        {

        }

        private void txtboxNamePEliminar_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
