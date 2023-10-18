namespace ClinicaSanFrancisco.RegistroMedico.UI.WF
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.iconmaximizar = new System.Windows.Forms.PictureBox();
            this.iconrestaura = new System.Windows.Forms.PictureBox();
            this.iconminimizar = new System.Windows.Forms.PictureBox();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnReceta = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.btnInvent = new FontAwesome.Sharp.IconButton();
            this.btnEexpediente = new FontAwesome.Sharp.IconButton();
            this.btnFactura = new FontAwesome.Sharp.IconButton();
            this.btnCitas = new FontAwesome.Sharp.IconButton();
            this.btnPacientes = new FontAwesome.Sharp.IconButton();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconrestaura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MenuVertical.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(238)))), ((int)(((byte)(219)))));
            this.BarraTitulo.Controls.Add(this.iconmaximizar);
            this.BarraTitulo.Controls.Add(this.iconrestaura);
            this.BarraTitulo.Controls.Add(this.iconminimizar);
            this.BarraTitulo.Controls.Add(this.iconcerrar);
            this.BarraTitulo.Controls.Add(this.pictureBox1);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(333, 0);
            this.BarraTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1609, 46);
            this.BarraTitulo.TabIndex = 1;
            // 
            // iconmaximizar
            // 
            this.iconmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconmaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconmaximizar.Image = ((System.Drawing.Image)(resources.GetObject("iconmaximizar.Image")));
            this.iconmaximizar.Location = new System.Drawing.Point(1555, 6);
            this.iconmaximizar.Margin = new System.Windows.Forms.Padding(4);
            this.iconmaximizar.Name = "iconmaximizar";
            this.iconmaximizar.Size = new System.Drawing.Size(28, 23);
            this.iconmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconmaximizar.TabIndex = 3;
            this.iconmaximizar.TabStop = false;
            this.iconmaximizar.Click += new System.EventHandler(this.iconmaximizar_Click);
            // 
            // iconrestaura
            // 
            this.iconrestaura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconrestaura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconrestaura.Image = ((System.Drawing.Image)(resources.GetObject("iconrestaura.Image")));
            this.iconrestaura.Location = new System.Drawing.Point(1555, 4);
            this.iconrestaura.Margin = new System.Windows.Forms.Padding(4);
            this.iconrestaura.Name = "iconrestaura";
            this.iconrestaura.Size = new System.Drawing.Size(28, 23);
            this.iconrestaura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconrestaura.TabIndex = 6;
            this.iconrestaura.TabStop = false;
            this.iconrestaura.Click += new System.EventHandler(this.iconrestaura_Click);
            // 
            // iconminimizar
            // 
            this.iconminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconminimizar.Image = global::ClinicaSanFrancisco.RegistroMedico.UI.WF.Properties.Resources._048_delete;
            this.iconminimizar.Location = new System.Drawing.Point(1529, 4);
            this.iconminimizar.Margin = new System.Windows.Forms.Padding(4);
            this.iconminimizar.Name = "iconminimizar";
            this.iconminimizar.Size = new System.Drawing.Size(28, 23);
            this.iconminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconminimizar.TabIndex = 1;
            this.iconminimizar.TabStop = false;
            this.iconminimizar.Click += new System.EventHandler(this.iconminimizar_Click);
            // 
            // iconcerrar
            // 
            this.iconcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconcerrar.Image = global::ClinicaSanFrancisco.RegistroMedico.UI.WF.Properties.Resources._016_crossed;
            this.iconcerrar.Location = new System.Drawing.Point(1577, 4);
            this.iconcerrar.Margin = new System.Windows.Forms.Padding(4);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(28, 23);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconcerrar.TabIndex = 0;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(205)))), ((int)(((byte)(147)))));
            this.MenuVertical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuVertical.Controls.Add(this.btnLogout);
            this.MenuVertical.Controls.Add(this.btnReceta);
            this.MenuVertical.Controls.Add(this.panel1);
            this.MenuVertical.Controls.Add(this.btnUsuarios);
            this.MenuVertical.Controls.Add(this.btnInvent);
            this.MenuVertical.Controls.Add(this.btnEexpediente);
            this.MenuVertical.Controls.Add(this.btnFactura);
            this.MenuVertical.Controls.Add(this.btnCitas);
            this.MenuVertical.Controls.Add(this.btnPacientes);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Margin = new System.Windows.Forms.Padding(4);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(333, 1102);
            this.MenuVertical.TabIndex = 0;
            this.MenuVertical.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuVertical_MouseDown);
            this.MenuVertical.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuVertical_MouseMove);
            this.MenuVertical.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuVertical_MouseUp);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btnLogout.IconColor = System.Drawing.Color.White;
            this.btnLogout.IconSize = 50;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 1039);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Rotation = 0D;
            this.btnLogout.Size = new System.Drawing.Size(333, 63);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "      Cerrar Sessión";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.iconButton7_Click);
            // 
            // btnReceta
            // 
            this.btnReceta.BackColor = System.Drawing.Color.Transparent;
            this.btnReceta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReceta.FlatAppearance.BorderSize = 0;
            this.btnReceta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnReceta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnReceta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceta.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnReceta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceta.ForeColor = System.Drawing.Color.White;
            this.btnReceta.IconChar = FontAwesome.Sharp.IconChar.PrescriptionBottleAlt;
            this.btnReceta.IconColor = System.Drawing.Color.White;
            this.btnReceta.IconSize = 50;
            this.btnReceta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceta.Location = new System.Drawing.Point(4, 323);
            this.btnReceta.Margin = new System.Windows.Forms.Padding(4);
            this.btnReceta.Name = "btnReceta";
            this.btnReceta.Rotation = 0D;
            this.btnReceta.Size = new System.Drawing.Size(333, 63);
            this.btnReceta.TabIndex = 15;
            this.btnReceta.Text = "Recetas";
            this.btnReceta.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblCargo);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 53);
            this.panel1.TabIndex = 14;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(88, 14);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.Color.White;
            this.lblCargo.Location = new System.Drawing.Point(88, -3);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(50, 17);
            this.lblCargo.TabIndex = 2;
            this.lblCargo.Text = "Cargo";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(22, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(89, 30);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 16);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.HospitalUser;
            this.btnUsuarios.IconColor = System.Drawing.Color.White;
            this.btnUsuarios.IconSize = 50;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(4, 527);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Rotation = 0D;
            this.btnUsuarios.Size = new System.Drawing.Size(333, 63);
            this.btnUsuarios.TabIndex = 12;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            // 
            // btnInvent
            // 
            this.btnInvent.BackColor = System.Drawing.Color.Transparent;
            this.btnInvent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInvent.FlatAppearance.BorderSize = 0;
            this.btnInvent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnInvent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnInvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvent.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnInvent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvent.ForeColor = System.Drawing.Color.White;
            this.btnInvent.IconChar = FontAwesome.Sharp.IconChar.PeopleCarry;
            this.btnInvent.IconColor = System.Drawing.Color.White;
            this.btnInvent.IconSize = 50;
            this.btnInvent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvent.Location = new System.Drawing.Point(4, 459);
            this.btnInvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnInvent.Name = "btnInvent";
            this.btnInvent.Rotation = 0D;
            this.btnInvent.Size = new System.Drawing.Size(333, 63);
            this.btnInvent.TabIndex = 11;
            this.btnInvent.Text = "Inventario";
            this.btnInvent.UseVisualStyleBackColor = false;
            this.btnInvent.Click += new System.EventHandler(this.btnInvent_Click);
            // 
            // btnEexpediente
            // 
            this.btnEexpediente.BackColor = System.Drawing.Color.Transparent;
            this.btnEexpediente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEexpediente.FlatAppearance.BorderSize = 0;
            this.btnEexpediente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEexpediente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnEexpediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEexpediente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnEexpediente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEexpediente.ForeColor = System.Drawing.Color.White;
            this.btnEexpediente.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btnEexpediente.IconColor = System.Drawing.Color.White;
            this.btnEexpediente.IconSize = 50;
            this.btnEexpediente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEexpediente.Location = new System.Drawing.Point(4, 391);
            this.btnEexpediente.Margin = new System.Windows.Forms.Padding(4);
            this.btnEexpediente.Name = "btnEexpediente";
            this.btnEexpediente.Rotation = 0D;
            this.btnEexpediente.Size = new System.Drawing.Size(333, 63);
            this.btnEexpediente.TabIndex = 10;
            this.btnEexpediente.Text = "   Expedientes";
            this.btnEexpediente.UseVisualStyleBackColor = false;
            // 
            // btnFactura
            // 
            this.btnFactura.BackColor = System.Drawing.Color.Transparent;
            this.btnFactura.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFactura.FlatAppearance.BorderSize = 0;
            this.btnFactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactura.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnFactura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactura.ForeColor = System.Drawing.Color.White;
            this.btnFactura.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.btnFactura.IconColor = System.Drawing.Color.White;
            this.btnFactura.IconSize = 50;
            this.btnFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFactura.Location = new System.Drawing.Point(4, 255);
            this.btnFactura.Margin = new System.Windows.Forms.Padding(4);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Rotation = 0D;
            this.btnFactura.Size = new System.Drawing.Size(333, 63);
            this.btnFactura.TabIndex = 9;
            this.btnFactura.Text = "Facturas";
            this.btnFactura.UseVisualStyleBackColor = false;
            // 
            // btnCitas
            // 
            this.btnCitas.BackColor = System.Drawing.Color.Transparent;
            this.btnCitas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCitas.FlatAppearance.BorderSize = 0;
            this.btnCitas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCitas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCitas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCitas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitas.ForeColor = System.Drawing.Color.White;
            this.btnCitas.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnCitas.IconColor = System.Drawing.Color.White;
            this.btnCitas.IconSize = 50;
            this.btnCitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCitas.Location = new System.Drawing.Point(4, 187);
            this.btnCitas.Margin = new System.Windows.Forms.Padding(4);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Rotation = 0D;
            this.btnCitas.Size = new System.Drawing.Size(333, 63);
            this.btnCitas.TabIndex = 8;
            this.btnCitas.Text = "Citas";
            this.btnCitas.UseVisualStyleBackColor = false;
            // 
            // btnPacientes
            // 
            this.btnPacientes.BackColor = System.Drawing.Color.Transparent;
            this.btnPacientes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPacientes.FlatAppearance.BorderSize = 0;
            this.btnPacientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPacientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPacientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientes.ForeColor = System.Drawing.Color.White;
            this.btnPacientes.IconChar = FontAwesome.Sharp.IconChar.UserInjured;
            this.btnPacientes.IconColor = System.Drawing.Color.White;
            this.btnPacientes.IconSize = 50;
            this.btnPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacientes.Location = new System.Drawing.Point(4, 119);
            this.btnPacientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Rotation = 0D;
            this.btnPacientes.Size = new System.Drawing.Size(333, 63);
            this.btnPacientes.TabIndex = 7;
            this.btnPacientes.Text = "Paciente";
            this.btnPacientes.UseVisualStyleBackColor = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.Control;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panelContenedor.Location = new System.Drawing.Point(333, 46);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(4);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1609, 1056);
            this.panelContenedor.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconrestaura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox iconcerrar;
        private System.Windows.Forms.PictureBox iconminimizar;
        private System.Windows.Forms.PictureBox iconmaximizar;
        private FontAwesome.Sharp.IconButton btnPacientes;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private FontAwesome.Sharp.IconButton btnInvent;
        private FontAwesome.Sharp.IconButton btnEexpediente;
        private FontAwesome.Sharp.IconButton btnFactura;
        private FontAwesome.Sharp.IconButton btnCitas;
        private FontAwesome.Sharp.IconButton btnLogout;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.PictureBox iconrestaura;
        private FontAwesome.Sharp.IconButton btnReceta;
    }
}

