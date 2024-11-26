using System.Windows.Forms;

namespace SampleJson
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.gboxOptions = new System.Windows.Forms.GroupBox();
            this.botCuenta = new System.Windows.Forms.Button();
            this.botAgregar = new System.Windows.Forms.Button();
            this.bot2 = new System.Windows.Forms.Button();
            this.botInicio = new System.Windows.Forms.Button();
            this.gbox2 = new System.Windows.Forms.GroupBox();
            this.lblInicio = new System.Windows.Forms.Label();
            this.gboxCuenta = new System.Windows.Forms.GroupBox();
            this.gboxIniciarSesion = new System.Windows.Forms.GroupBox();
            this.lblmsgIniciarSesion = new System.Windows.Forms.Label();
            this.botIniciarS = new System.Windows.Forms.Button();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.txtboxUser = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.gboxCrearCuenta = new System.Windows.Forms.GroupBox();
            this.lblmsgCrearCuenta = new System.Windows.Forms.Label();
            this.botCrear = new System.Windows.Forms.Button();
            this.txtboxContra = new System.Windows.Forms.TextBox();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.lblContra = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.botIniciarSesion = new System.Windows.Forms.Button();
            this.botCrearCuenta = new System.Windows.Forms.Button();
            this.gboxCuentaIni = new System.Windows.Forms.GroupBox();
            this.botCerrarS = new System.Windows.Forms.Button();
            this.picboxUser = new System.Windows.Forms.PictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gboxAgregarP = new System.Windows.Forms.GroupBox();
            this.lblErrorAgregar = new System.Windows.Forms.Label();
            this.botAgregarP = new System.Windows.Forms.Button();
            this.txtboxPrecioP = new System.Windows.Forms.TextBox();
            this.lblPrecioP = new System.Windows.Forms.Label();
            this.comboxCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoriaP = new System.Windows.Forms.Label();
            this.txtboxNameP = new System.Windows.Forms.TextBox();
            this.lblNombreP = new System.Windows.Forms.Label();
            this.gboxVerProductos = new System.Windows.Forms.GroupBox();
            this.botEliminarP = new System.Windows.Forms.Button();
            this.lblShowPrice = new System.Windows.Forms.Label();
            this.lblShowmsgE = new System.Windows.Forms.Label();
            this.llbPrice = new System.Windows.Forms.Label();
            this.lblEliminarPro = new System.Windows.Forms.Label();
            this.botActualizarLst = new System.Windows.Forms.Button();
            this.lblProductList = new System.Windows.Forms.Label();
            this.lstboxPDisponibles = new System.Windows.Forms.ListBox();
            this.lblAgregarPsinC = new System.Windows.Forms.Label();
            this.txtboxNamePEliminar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gboxOptions.SuspendLayout();
            this.gboxCuenta.SuspendLayout();
            this.gboxIniciarSesion.SuspendLayout();
            this.gboxCrearCuenta.SuspendLayout();
            this.gboxCuentaIni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gboxAgregarP.SuspendLayout();
            this.gboxVerProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxOptions
            // 
            this.gboxOptions.BackColor = System.Drawing.SystemColors.Control;
            this.gboxOptions.Controls.Add(this.botCuenta);
            this.gboxOptions.Controls.Add(this.botAgregar);
            this.gboxOptions.Controls.Add(this.bot2);
            this.gboxOptions.Controls.Add(this.botInicio);
            this.gboxOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gboxOptions.Location = new System.Drawing.Point(2, 227);
            this.gboxOptions.Name = "gboxOptions";
            this.gboxOptions.Size = new System.Drawing.Size(199, 443);
            this.gboxOptions.TabIndex = 0;
            this.gboxOptions.TabStop = false;
            // 
            // botCuenta
            // 
            this.botCuenta.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botCuenta.Location = new System.Drawing.Point(10, 336);
            this.botCuenta.Name = "botCuenta";
            this.botCuenta.Size = new System.Drawing.Size(173, 75);
            this.botCuenta.TabIndex = 6;
            this.botCuenta.Text = "CUENTA";
            this.botCuenta.UseVisualStyleBackColor = true;
            this.botCuenta.Click += new System.EventHandler(this.button1_Click);
            // 
            // botAgregar
            // 
            this.botAgregar.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botAgregar.Location = new System.Drawing.Point(10, 236);
            this.botAgregar.Name = "botAgregar";
            this.botAgregar.Size = new System.Drawing.Size(173, 75);
            this.botAgregar.TabIndex = 5;
            this.botAgregar.Text = "AGREGAR PRODUCTOS";
            this.botAgregar.UseVisualStyleBackColor = true;
            this.botAgregar.Click += new System.EventHandler(this.botAgregar_Click);
            // 
            // bot2
            // 
            this.bot2.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot2.Location = new System.Drawing.Point(10, 135);
            this.bot2.Name = "bot2";
            this.bot2.Size = new System.Drawing.Size(173, 75);
            this.bot2.TabIndex = 4;
            this.bot2.Text = "PRODUCTOS";
            this.bot2.UseVisualStyleBackColor = true;
            this.bot2.Click += new System.EventHandler(this.bot2_Click);
            // 
            // botInicio
            // 
            this.botInicio.BackColor = System.Drawing.Color.Khaki;
            this.botInicio.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botInicio.Location = new System.Drawing.Point(10, 38);
            this.botInicio.Name = "botInicio";
            this.botInicio.Size = new System.Drawing.Size(173, 75);
            this.botInicio.TabIndex = 3;
            this.botInicio.Text = "INICIO";
            this.botInicio.UseVisualStyleBackColor = false;
            this.botInicio.Click += new System.EventHandler(this.botInicio_Click);
            // 
            // gbox2
            // 
            this.gbox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbox2.BackColor = System.Drawing.Color.Yellow;
            this.gbox2.Location = new System.Drawing.Point(2, 2);
            this.gbox2.Name = "gbox2";
            this.gbox2.Size = new System.Drawing.Size(1794, 69);
            this.gbox2.TabIndex = 2;
            this.gbox2.TabStop = false;
            // 
            // lblInicio
            // 
            this.lblInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(967, 74);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(253, 46);
            this.lblInicio.TabIndex = 3;
            this.lblInicio.Text = "BIENVENIDO";
            this.lblInicio.Click += new System.EventHandler(this.lblInicio_Click);
            // 
            // gboxCuenta
            // 
            this.gboxCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxCuenta.BackColor = System.Drawing.SystemColors.Control;
            this.gboxCuenta.Controls.Add(this.gboxIniciarSesion);
            this.gboxCuenta.Controls.Add(this.gboxCrearCuenta);
            this.gboxCuenta.Controls.Add(this.botIniciarSesion);
            this.gboxCuenta.Controls.Add(this.botCrearCuenta);
            this.gboxCuenta.Location = new System.Drawing.Point(405, 265);
            this.gboxCuenta.Name = "gboxCuenta";
            this.gboxCuenta.Size = new System.Drawing.Size(962, 437);
            this.gboxCuenta.TabIndex = 4;
            this.gboxCuenta.TabStop = false;
            this.gboxCuenta.Visible = false;
            this.gboxCuenta.Enter += new System.EventHandler(this.gboxCuenta_Enter);
            // 
            // gboxIniciarSesion
            // 
            this.gboxIniciarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxIniciarSesion.Controls.Add(this.lblmsgIniciarSesion);
            this.gboxIniciarSesion.Controls.Add(this.botIniciarS);
            this.gboxIniciarSesion.Controls.Add(this.txtboxPassword);
            this.gboxIniciarSesion.Controls.Add(this.txtboxUser);
            this.gboxIniciarSesion.Controls.Add(this.lblPassword);
            this.gboxIniciarSesion.Controls.Add(this.lblUsuario);
            this.gboxIniciarSesion.Location = new System.Drawing.Point(525, 186);
            this.gboxIniciarSesion.Name = "gboxIniciarSesion";
            this.gboxIniciarSesion.Size = new System.Drawing.Size(382, 219);
            this.gboxIniciarSesion.TabIndex = 10;
            this.gboxIniciarSesion.TabStop = false;
            this.gboxIniciarSesion.Visible = false;
            // 
            // lblmsgIniciarSesion
            // 
            this.lblmsgIniciarSesion.AutoSize = true;
            this.lblmsgIniciarSesion.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsgIniciarSesion.Location = new System.Drawing.Point(24, 190);
            this.lblmsgIniciarSesion.Name = "lblmsgIniciarSesion";
            this.lblmsgIniciarSesion.Size = new System.Drawing.Size(0, 19);
            this.lblmsgIniciarSesion.TabIndex = 11;
            // 
            // botIniciarS
            // 
            this.botIniciarS.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botIniciarS.Location = new System.Drawing.Point(123, 112);
            this.botIniciarS.Name = "botIniciarS";
            this.botIniciarS.Size = new System.Drawing.Size(144, 30);
            this.botIniciarS.TabIndex = 10;
            this.botIniciarS.Text = "INICIAR SESIÓN";
            this.botIniciarS.UseVisualStyleBackColor = true;
            this.botIniciarS.Click += new System.EventHandler(this.botIniciarS_Click);
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPassword.Location = new System.Drawing.Point(190, 55);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(138, 25);
            this.txtboxPassword.TabIndex = 5;
            this.txtboxPassword.UseSystemPasswordChar = true;
            // 
            // txtboxUser
            // 
            this.txtboxUser.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxUser.Location = new System.Drawing.Point(190, 22);
            this.txtboxUser.Name = "txtboxUser";
            this.txtboxUser.Size = new System.Drawing.Size(138, 25);
            this.txtboxUser.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(66, 59);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(106, 19);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(7, 22);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(165, 19);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Nombre de usuario:";
            // 
            // gboxCrearCuenta
            // 
            this.gboxCrearCuenta.Controls.Add(this.lblmsgCrearCuenta);
            this.gboxCrearCuenta.Controls.Add(this.botCrear);
            this.gboxCrearCuenta.Controls.Add(this.txtboxContra);
            this.gboxCrearCuenta.Controls.Add(this.txtboxEmail);
            this.gboxCrearCuenta.Controls.Add(this.txtboxName);
            this.gboxCrearCuenta.Controls.Add(this.lblContra);
            this.gboxCrearCuenta.Controls.Add(this.lblEmail);
            this.gboxCrearCuenta.Controls.Add(this.lblName);
            this.gboxCrearCuenta.Location = new System.Drawing.Point(85, 186);
            this.gboxCrearCuenta.Name = "gboxCrearCuenta";
            this.gboxCrearCuenta.Size = new System.Drawing.Size(382, 219);
            this.gboxCrearCuenta.TabIndex = 9;
            this.gboxCrearCuenta.TabStop = false;
            this.gboxCrearCuenta.Visible = false;
            // 
            // lblmsgCrearCuenta
            // 
            this.lblmsgCrearCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblmsgCrearCuenta.AutoSize = true;
            this.lblmsgCrearCuenta.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsgCrearCuenta.Location = new System.Drawing.Point(23, 188);
            this.lblmsgCrearCuenta.Name = "lblmsgCrearCuenta";
            this.lblmsgCrearCuenta.Size = new System.Drawing.Size(0, 19);
            this.lblmsgCrearCuenta.TabIndex = 7;
            // 
            // botCrear
            // 
            this.botCrear.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botCrear.Location = new System.Drawing.Point(146, 140);
            this.botCrear.Name = "botCrear";
            this.botCrear.Size = new System.Drawing.Size(83, 25);
            this.botCrear.TabIndex = 10;
            this.botCrear.Text = "CREAR";
            this.botCrear.UseVisualStyleBackColor = true;
            this.botCrear.Click += new System.EventHandler(this.botCrear_Click);
            // 
            // txtboxContra
            // 
            this.txtboxContra.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxContra.Location = new System.Drawing.Point(190, 88);
            this.txtboxContra.Name = "txtboxContra";
            this.txtboxContra.Size = new System.Drawing.Size(138, 25);
            this.txtboxContra.TabIndex = 5;
            this.txtboxContra.UseSystemPasswordChar = true;
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEmail.Location = new System.Drawing.Point(190, 53);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(138, 25);
            this.txtboxEmail.TabIndex = 4;
            // 
            // txtboxName
            // 
            this.txtboxName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxName.Location = new System.Drawing.Point(190, 22);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(138, 25);
            this.txtboxName.TabIndex = 3;
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContra.Location = new System.Drawing.Point(66, 94);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(106, 19);
            this.lblContra.TabIndex = 2;
            this.lblContra.Text = "Contraseña:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(115, 57);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 19);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(7, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(165, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre de usuario:";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // botIniciarSesion
            // 
            this.botIniciarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botIniciarSesion.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botIniciarSesion.Location = new System.Drawing.Point(572, 68);
            this.botIniciarSesion.Name = "botIniciarSesion";
            this.botIniciarSesion.Size = new System.Drawing.Size(173, 75);
            this.botIniciarSesion.TabIndex = 8;
            this.botIniciarSesion.Text = "Iniciar Sesión";
            this.botIniciarSesion.UseVisualStyleBackColor = true;
            this.botIniciarSesion.Click += new System.EventHandler(this.botIniciarSesion_Click);
            // 
            // botCrearCuenta
            // 
            this.botCrearCuenta.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botCrearCuenta.Location = new System.Drawing.Point(265, 68);
            this.botCrearCuenta.Name = "botCrearCuenta";
            this.botCrearCuenta.Size = new System.Drawing.Size(173, 75);
            this.botCrearCuenta.TabIndex = 7;
            this.botCrearCuenta.Text = "Crear Cuenta";
            this.botCrearCuenta.UseVisualStyleBackColor = true;
            this.botCrearCuenta.Click += new System.EventHandler(this.botCrearCuenta_Click);
            // 
            // gboxCuentaIni
            // 
            this.gboxCuentaIni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxCuentaIni.BackColor = System.Drawing.SystemColors.Control;
            this.gboxCuentaIni.Controls.Add(this.botCerrarS);
            this.gboxCuentaIni.Controls.Add(this.picboxUser);
            this.gboxCuentaIni.Controls.Add(this.lblUserName);
            this.gboxCuentaIni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gboxCuentaIni.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxCuentaIni.Location = new System.Drawing.Point(1166, 121);
            this.gboxCuentaIni.Name = "gboxCuentaIni";
            this.gboxCuentaIni.Size = new System.Drawing.Size(303, 126);
            this.gboxCuentaIni.TabIndex = 6;
            this.gboxCuentaIni.TabStop = false;
            this.gboxCuentaIni.Text = "CUENTA";
            this.gboxCuentaIni.Visible = false;
            this.gboxCuentaIni.Enter += new System.EventHandler(this.gboxProductos_Enter);
            // 
            // botCerrarS
            // 
            this.botCerrarS.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botCerrarS.Location = new System.Drawing.Point(16, 89);
            this.botCerrarS.Name = "botCerrarS";
            this.botCerrarS.Size = new System.Drawing.Size(144, 30);
            this.botCerrarS.TabIndex = 11;
            this.botCerrarS.Text = "CERRAR SESIÓN";
            this.botCerrarS.UseVisualStyleBackColor = true;
            this.botCerrarS.Click += new System.EventHandler(this.botCerrarS_Click);
            // 
            // picboxUser
            // 
            this.picboxUser.Image = global::SampleJson.Properties.Resources.iconProfile;
            this.picboxUser.Location = new System.Drawing.Point(16, 32);
            this.picboxUser.Name = "picboxUser";
            this.picboxUser.Size = new System.Drawing.Size(73, 51);
            this.picboxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxUser.TabIndex = 1;
            this.picboxUser.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(95, 47);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(0, 24);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SampleJson.Properties.Resources.VerdugoLog;
            this.pictureBox1.Location = new System.Drawing.Point(2, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // gboxAgregarP
            // 
            this.gboxAgregarP.BackColor = System.Drawing.SystemColors.Control;
            this.gboxAgregarP.Controls.Add(this.lblErrorAgregar);
            this.gboxAgregarP.Controls.Add(this.botAgregarP);
            this.gboxAgregarP.Controls.Add(this.txtboxPrecioP);
            this.gboxAgregarP.Controls.Add(this.lblPrecioP);
            this.gboxAgregarP.Controls.Add(this.comboxCategoria);
            this.gboxAgregarP.Controls.Add(this.lblCategoriaP);
            this.gboxAgregarP.Controls.Add(this.txtboxNameP);
            this.gboxAgregarP.Controls.Add(this.lblNombreP);
            this.gboxAgregarP.Location = new System.Drawing.Point(319, 265);
            this.gboxAgregarP.Name = "gboxAgregarP";
            this.gboxAgregarP.Size = new System.Drawing.Size(1088, 437);
            this.gboxAgregarP.TabIndex = 7;
            this.gboxAgregarP.TabStop = false;
            this.gboxAgregarP.Visible = false;
            // 
            // lblErrorAgregar
            // 
            this.lblErrorAgregar.AutoSize = true;
            this.lblErrorAgregar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorAgregar.Location = new System.Drawing.Point(262, 247);
            this.lblErrorAgregar.Name = "lblErrorAgregar";
            this.lblErrorAgregar.Size = new System.Drawing.Size(0, 19);
            this.lblErrorAgregar.TabIndex = 7;
            // 
            // botAgregarP
            // 
            this.botAgregarP.AutoSize = true;
            this.botAgregarP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botAgregarP.Location = new System.Drawing.Point(422, 149);
            this.botAgregarP.Name = "botAgregarP";
            this.botAgregarP.Size = new System.Drawing.Size(188, 36);
            this.botAgregarP.TabIndex = 6;
            this.botAgregarP.Text = "Agregar Producto";
            this.botAgregarP.UseVisualStyleBackColor = true;
            this.botAgregarP.Click += new System.EventHandler(this.botAgregarP_Click);
            // 
            // txtboxPrecioP
            // 
            this.txtboxPrecioP.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPrecioP.Location = new System.Drawing.Point(773, 69);
            this.txtboxPrecioP.Name = "txtboxPrecioP";
            this.txtboxPrecioP.Size = new System.Drawing.Size(121, 27);
            this.txtboxPrecioP.TabIndex = 5;
            this.txtboxPrecioP.TextChanged += new System.EventHandler(this.txtboxPrecioP_TextChanged);
            this.txtboxPrecioP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxPrecioP_KeyPress);
            // 
            // lblPrecioP
            // 
            this.lblPrecioP.AutoSize = true;
            this.lblPrecioP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioP.Location = new System.Drawing.Point(690, 72);
            this.lblPrecioP.Name = "lblPrecioP";
            this.lblPrecioP.Size = new System.Drawing.Size(77, 24);
            this.lblPrecioP.TabIndex = 4;
            this.lblPrecioP.Text = "Precio:";
            // 
            // comboxCategoria
            // 
            this.comboxCategoria.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxCategoria.FormattingEnabled = true;
            this.comboxCategoria.Items.AddRange(new object[] {
            "Electrodomésticos",
            "Muebles",
            "Smartphones",
            ""});
            this.comboxCategoria.Location = new System.Drawing.Point(534, 71);
            this.comboxCategoria.Name = "comboxCategoria";
            this.comboxCategoria.Size = new System.Drawing.Size(121, 27);
            this.comboxCategoria.TabIndex = 3;
            // 
            // lblCategoriaP
            // 
            this.lblCategoriaP.AutoSize = true;
            this.lblCategoriaP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaP.Location = new System.Drawing.Point(418, 72);
            this.lblCategoriaP.Name = "lblCategoriaP";
            this.lblCategoriaP.Size = new System.Drawing.Size(109, 24);
            this.lblCategoriaP.TabIndex = 2;
            this.lblCategoriaP.Text = "Categoría:";
            // 
            // txtboxNameP
            // 
            this.txtboxNameP.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNameP.Location = new System.Drawing.Point(262, 69);
            this.txtboxNameP.Name = "txtboxNameP";
            this.txtboxNameP.Size = new System.Drawing.Size(121, 27);
            this.txtboxNameP.TabIndex = 1;
            // 
            // lblNombreP
            // 
            this.lblNombreP.AutoSize = true;
            this.lblNombreP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreP.Location = new System.Drawing.Point(38, 68);
            this.lblNombreP.Name = "lblNombreP";
            this.lblNombreP.Size = new System.Drawing.Size(217, 24);
            this.lblNombreP.TabIndex = 0;
            this.lblNombreP.Text = "Nombre del producto:";
            // 
            // gboxVerProductos
            // 
            this.gboxVerProductos.BackColor = System.Drawing.SystemColors.Control;
            this.gboxVerProductos.Controls.Add(this.txtboxNamePEliminar);
            this.gboxVerProductos.Controls.Add(this.botEliminarP);
            this.gboxVerProductos.Controls.Add(this.lblShowPrice);
            this.gboxVerProductos.Controls.Add(this.lblShowmsgE);
            this.gboxVerProductos.Controls.Add(this.llbPrice);
            this.gboxVerProductos.Controls.Add(this.lblEliminarPro);
            this.gboxVerProductos.Controls.Add(this.botActualizarLst);
            this.gboxVerProductos.Controls.Add(this.lblProductList);
            this.gboxVerProductos.Controls.Add(this.lstboxPDisponibles);
            this.gboxVerProductos.Location = new System.Drawing.Point(329, 227);
            this.gboxVerProductos.Name = "gboxVerProductos";
            this.gboxVerProductos.Size = new System.Drawing.Size(1140, 453);
            this.gboxVerProductos.TabIndex = 9;
            this.gboxVerProductos.TabStop = false;
            this.gboxVerProductos.Visible = false;
            this.gboxVerProductos.Enter += new System.EventHandler(this.gboxVerProductos_Enter);
            // 
            // botEliminarP
            // 
            this.botEliminarP.AutoSize = true;
            this.botEliminarP.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botEliminarP.Location = new System.Drawing.Point(188, 303);
            this.botEliminarP.Name = "botEliminarP";
            this.botEliminarP.Size = new System.Drawing.Size(160, 29);
            this.botEliminarP.TabIndex = 7;
            this.botEliminarP.Text = "Eliminar Producto";
            this.botEliminarP.UseVisualStyleBackColor = true;
            this.botEliminarP.Click += new System.EventHandler(this.botEliminarP_Click);
            // 
            // lblShowPrice
            // 
            this.lblShowPrice.AutoSize = true;
            this.lblShowPrice.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowPrice.Location = new System.Drawing.Point(759, 204);
            this.lblShowPrice.Name = "lblShowPrice";
            this.lblShowPrice.Size = new System.Drawing.Size(30, 19);
            this.lblShowPrice.TabIndex = 6;
            this.lblShowPrice.Text = "C$";
            this.lblShowPrice.Click += new System.EventHandler(this.lblShowPrice_Click);
            // 
            // lblShowmsgE
            // 
            this.lblShowmsgE.AutoSize = true;
            this.lblShowmsgE.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowmsgE.Location = new System.Drawing.Point(563, 106);
            this.lblShowmsgE.Name = "lblShowmsgE";
            this.lblShowmsgE.Size = new System.Drawing.Size(0, 19);
            this.lblShowmsgE.TabIndex = 5;
            // 
            // llbPrice
            // 
            this.llbPrice.AutoSize = true;
            this.llbPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbPrice.Location = new System.Drawing.Point(563, 199);
            this.llbPrice.Name = "llbPrice";
            this.llbPrice.Size = new System.Drawing.Size(163, 24);
            this.llbPrice.TabIndex = 4;
            this.llbPrice.Text = "Activos totales: ";
            this.llbPrice.Click += new System.EventHandler(this.llbPrice_Click);
            // 
            // lblEliminarPro
            // 
            this.lblEliminarPro.AutoSize = true;
            this.lblEliminarPro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminarPro.Location = new System.Drawing.Point(563, 59);
            this.lblEliminarPro.Name = "lblEliminarPro";
            this.lblEliminarPro.Size = new System.Drawing.Size(185, 24);
            this.lblEliminarPro.TabIndex = 3;
            this.lblEliminarPro.Text = "Eliminar producto:";
            this.lblEliminarPro.Click += new System.EventHandler(this.lblCategory_Click);
            // 
            // botActualizarLst
            // 
            this.botActualizarLst.AutoSize = true;
            this.botActualizarLst.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botActualizarLst.Location = new System.Drawing.Point(42, 304);
            this.botActualizarLst.Name = "botActualizarLst";
            this.botActualizarLst.Size = new System.Drawing.Size(97, 29);
            this.botActualizarLst.TabIndex = 2;
            this.botActualizarLst.Text = "Actualizar";
            this.botActualizarLst.UseVisualStyleBackColor = true;
            this.botActualizarLst.Click += new System.EventHandler(this.botActualizarLst_Click);
            // 
            // lblProductList
            // 
            this.lblProductList.AutoSize = true;
            this.lblProductList.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductList.Location = new System.Drawing.Point(167, 25);
            this.lblProductList.Name = "lblProductList";
            this.lblProductList.Size = new System.Drawing.Size(224, 24);
            this.lblProductList.TabIndex = 1;
            this.lblProductList.Text = "Productos Disponibles";
            // 
            // lstboxPDisponibles
            // 
            this.lstboxPDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxPDisponibles.FormattingEnabled = true;
            this.lstboxPDisponibles.ItemHeight = 20;
            this.lstboxPDisponibles.Location = new System.Drawing.Point(42, 59);
            this.lstboxPDisponibles.Name = "lstboxPDisponibles";
            this.lstboxPDisponibles.Size = new System.Drawing.Size(467, 204);
            this.lstboxPDisponibles.TabIndex = 0;
            this.lstboxPDisponibles.SelectedIndexChanged += new System.EventHandler(this.lstboxPDisponibles_SelectedIndexChanged);
            // 
            // lblAgregarPsinC
            // 
            this.lblAgregarPsinC.AutoSize = true;
            this.lblAgregarPsinC.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarPsinC.Location = new System.Drawing.Point(953, 177);
            this.lblAgregarPsinC.Name = "lblAgregarPsinC";
            this.lblAgregarPsinC.Size = new System.Drawing.Size(276, 27);
            this.lblAgregarPsinC.TabIndex = 8;
            this.lblAgregarPsinC.Text = "(?) Debes Iniciar Sesión";
            this.lblAgregarPsinC.Visible = false;
            // 
            // txtboxNamePEliminar
            // 
            this.txtboxNamePEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNamePEliminar.Location = new System.Drawing.Point(755, 59);
            this.txtboxNamePEliminar.Name = "txtboxNamePEliminar";
            this.txtboxNamePEliminar.Size = new System.Drawing.Size(136, 27);
            this.txtboxNamePEliminar.TabIndex = 8;
            this.txtboxNamePEliminar.Text = "Nombre del producto";
            this.txtboxNamePEliminar.TextChanged += new System.EventHandler(this.txtboxNamePEliminar_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(2, 754);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1794, 69);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1792, 818);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.gbox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gboxOptions);
            this.Controls.Add(this.gboxCuentaIni);
            this.Controls.Add(this.lblAgregarPsinC);
            this.Controls.Add(this.gboxAgregarP);
            this.Controls.Add(this.gboxVerProductos);
            this.Controls.Add(this.gboxCuenta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.Text = "El Verdugo";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.gboxOptions.ResumeLayout(false);
            this.gboxCuenta.ResumeLayout(false);
            this.gboxIniciarSesion.ResumeLayout(false);
            this.gboxIniciarSesion.PerformLayout();
            this.gboxCrearCuenta.ResumeLayout(false);
            this.gboxCrearCuenta.PerformLayout();
            this.gboxCuentaIni.ResumeLayout(false);
            this.gboxCuentaIni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gboxAgregarP.ResumeLayout(false);
            this.gboxAgregarP.PerformLayout();
            this.gboxVerProductos.ResumeLayout(false);
            this.gboxVerProductos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxOptions;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbox2;
        private System.Windows.Forms.Button botInicio;
        private System.Windows.Forms.Button bot2;
        private System.Windows.Forms.Button botAgregar;
        private System.Windows.Forms.Button botCuenta;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.GroupBox gboxCuenta;
        private System.Windows.Forms.Button botIniciarSesion;
        private System.Windows.Forms.Button botCrearCuenta;
        private GroupBox gboxCuentaIni;
        private GroupBox gboxCrearCuenta;
        private Label lblName;
        private Label lblContra;
        private Label lblEmail;
        private Button botCrear;
        private TextBox txtboxContra;
        private TextBox txtboxEmail;
        private TextBox txtboxName;
        private GroupBox gboxIniciarSesion;
        private Button botIniciarS;
        private TextBox txtboxPassword;
        private TextBox txtboxUser;
        private Label lblPassword;
        private Label lblUsuario;
        private Label lblmsgCrearCuenta;
        private Label lblmsgIniciarSesion;
        private Label lblUserName;
        private PictureBox picboxUser;
        private Button botCerrarSesion;
        private Button botCerrarS;
        private GroupBox gboxAgregarP;
        private Label lblCategoriaP;
        private TextBox txtboxNameP;
        private Label lblNombreP;
        private ComboBox comboxCategoria;
        private Button botAgregarP;
        private TextBox txtboxPrecioP;
        private Label lblPrecioP;
        private Label lblErrorAgregar;
        private Label lblAgregarPsinC;
        private GroupBox gboxVerProductos;
        private Label lblProductList;
        private ListBox lstboxPDisponibles;
        private Button botActualizarLst;
        private Label lblShowPrice;
        private Label lblShowmsgE;
        private Label llbPrice;
        private Label lblEliminarPro;
        private Button botEliminarP;
        private TextBox txtboxNamePEliminar;
        private GroupBox groupBox1;
    }
}

