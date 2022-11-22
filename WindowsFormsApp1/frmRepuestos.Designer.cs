namespace WindowsFormsApp1
{
    partial class frmRepuestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepuestos));
            this.mrcDatosRepuestos = new System.Windows.Forms.GroupBox();
            this.mrcOrigen = new System.Windows.Forms.GroupBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.mrcRepuestosIngresados = new System.Windows.Forms.GroupBox();
            this.optNacional = new System.Windows.Forms.RadioButton();
            this.optImportado = new System.Windows.Forms.RadioButton();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblConsultaMarca = new System.Windows.Forms.Label();
            this.mrcConsultaOrigen = new System.Windows.Forms.GroupBox();
            this.optConsultaImportado = new System.Windows.Forms.RadioButton();
            this.optConsultaNacional = new System.Windows.Forms.RadioButton();
            this.cmbConsultaMarca = new System.Windows.Forms.ComboBox();
            this.lblConsultaDatos = new System.Windows.Forms.Label();
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.lstConsultaDatos = new System.Windows.Forms.ListBox();
            this.mrcDatosRepuestos.SuspendLayout();
            this.mrcOrigen.SuspendLayout();
            this.mrcRepuestosIngresados.SuspendLayout();
            this.mrcConsultaOrigen.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcDatosRepuestos
            // 
            this.mrcDatosRepuestos.Controls.Add(this.lblDescripcion);
            this.mrcDatosRepuestos.Controls.Add(this.txtDescripcion);
            this.mrcDatosRepuestos.Controls.Add(this.txtPrecio);
            this.mrcDatosRepuestos.Controls.Add(this.txtNumero);
            this.mrcDatosRepuestos.Controls.Add(this.lblPrecio);
            this.mrcDatosRepuestos.Controls.Add(this.lblNumero);
            this.mrcDatosRepuestos.Controls.Add(this.cmbMarca);
            this.mrcDatosRepuestos.Controls.Add(this.mrcOrigen);
            this.mrcDatosRepuestos.Controls.Add(this.lblMarca);
            this.mrcDatosRepuestos.Location = new System.Drawing.Point(21, 12);
            this.mrcDatosRepuestos.Name = "mrcDatosRepuestos";
            this.mrcDatosRepuestos.Size = new System.Drawing.Size(402, 182);
            this.mrcDatosRepuestos.TabIndex = 0;
            this.mrcDatosRepuestos.TabStop = false;
            this.mrcDatosRepuestos.Text = "Datos de Repuestos";
            this.mrcDatosRepuestos.Enter += new System.EventHandler(this.mrcDatosRepuestos_Enter);
            // 
            // mrcOrigen
            // 
            this.mrcOrigen.Controls.Add(this.optImportado);
            this.mrcOrigen.Controls.Add(this.optNacional);
            this.mrcOrigen.Location = new System.Drawing.Point(23, 60);
            this.mrcOrigen.Name = "mrcOrigen";
            this.mrcOrigen.Size = new System.Drawing.Size(142, 65);
            this.mrcOrigen.TabIndex = 1;
            this.mrcOrigen.TabStop = false;
            this.mrcOrigen.Text = "Origen";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(20, 26);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            // 
            // mrcRepuestosIngresados
            // 
            this.mrcRepuestosIngresados.Controls.Add(this.lstConsultaDatos);
            this.mrcRepuestosIngresados.Controls.Add(this.lblConsultaDatos);
            this.mrcRepuestosIngresados.Controls.Add(this.cmbConsultaMarca);
            this.mrcRepuestosIngresados.Controls.Add(this.mrcConsultaOrigen);
            this.mrcRepuestosIngresados.Controls.Add(this.lblConsultaMarca);
            this.mrcRepuestosIngresados.Location = new System.Drawing.Point(21, 209);
            this.mrcRepuestosIngresados.Name = "mrcRepuestosIngresados";
            this.mrcRepuestosIngresados.Size = new System.Drawing.Size(402, 182);
            this.mrcRepuestosIngresados.TabIndex = 1;
            this.mrcRepuestosIngresados.TabStop = false;
            this.mrcRepuestosIngresados.Text = "Repuestos Ingresados";
            // 
            // optNacional
            // 
            this.optNacional.AutoSize = true;
            this.optNacional.Location = new System.Drawing.Point(19, 19);
            this.optNacional.Name = "optNacional";
            this.optNacional.Size = new System.Drawing.Size(67, 17);
            this.optNacional.TabIndex = 2;
            this.optNacional.TabStop = true;
            this.optNacional.Text = "Nacional";
            this.optNacional.UseVisualStyleBackColor = true;
            // 
            // optImportado
            // 
            this.optImportado.AutoSize = true;
            this.optImportado.Location = new System.Drawing.Point(19, 42);
            this.optImportado.Name = "optImportado";
            this.optImportado.Size = new System.Drawing.Size(72, 17);
            this.optImportado.TabIndex = 3;
            this.optImportado.TabStop = true;
            this.optImportado.Text = "Importado";
            this.optImportado.UseVisualStyleBackColor = true;
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "Peugeot",
            "Renault ",
            "Fiat"});
            this.cmbMarca.Location = new System.Drawing.Point(65, 23);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(101, 21);
            this.cmbMarca.TabIndex = 2;
            this.cmbMarca.SelectedIndexChanged += new System.EventHandler(this.cmbMarca_SelectedIndexChanged);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(23, 131);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Número";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(23, 154);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(65, 128);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 5;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(65, 151);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 6;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(201, 51);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(168, 116);
            this.txtDescripcion.TabIndex = 7;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(207, 26);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblConsultaMarca
            // 
            this.lblConsultaMarca.AutoSize = true;
            this.lblConsultaMarca.Location = new System.Drawing.Point(23, 22);
            this.lblConsultaMarca.Name = "lblConsultaMarca";
            this.lblConsultaMarca.Size = new System.Drawing.Size(37, 13);
            this.lblConsultaMarca.TabIndex = 1;
            this.lblConsultaMarca.Text = "Marca";
            // 
            // mrcConsultaOrigen
            // 
            this.mrcConsultaOrigen.Controls.Add(this.optConsultaImportado);
            this.mrcConsultaOrigen.Controls.Add(this.optConsultaNacional);
            this.mrcConsultaOrigen.Location = new System.Drawing.Point(26, 76);
            this.mrcConsultaOrigen.Name = "mrcConsultaOrigen";
            this.mrcConsultaOrigen.Size = new System.Drawing.Size(142, 65);
            this.mrcConsultaOrigen.TabIndex = 2;
            this.mrcConsultaOrigen.TabStop = false;
            this.mrcConsultaOrigen.Text = "Origen";
            // 
            // optConsultaImportado
            // 
            this.optConsultaImportado.AutoSize = true;
            this.optConsultaImportado.Location = new System.Drawing.Point(19, 42);
            this.optConsultaImportado.Name = "optConsultaImportado";
            this.optConsultaImportado.Size = new System.Drawing.Size(72, 17);
            this.optConsultaImportado.TabIndex = 3;
            this.optConsultaImportado.TabStop = true;
            this.optConsultaImportado.Text = "Importado";
            this.optConsultaImportado.UseVisualStyleBackColor = true;
            // 
            // optConsultaNacional
            // 
            this.optConsultaNacional.AutoSize = true;
            this.optConsultaNacional.Location = new System.Drawing.Point(19, 19);
            this.optConsultaNacional.Name = "optConsultaNacional";
            this.optConsultaNacional.Size = new System.Drawing.Size(67, 17);
            this.optConsultaNacional.TabIndex = 2;
            this.optConsultaNacional.TabStop = true;
            this.optConsultaNacional.Text = "Nacional";
            this.optConsultaNacional.UseVisualStyleBackColor = true;
            // 
            // cmbConsultaMarca
            // 
            this.cmbConsultaMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConsultaMarca.FormattingEnabled = true;
            this.cmbConsultaMarca.Items.AddRange(new object[] {
            "Peugeot",
            "Renault ",
            "Fiat"});
            this.cmbConsultaMarca.Location = new System.Drawing.Point(64, 19);
            this.cmbConsultaMarca.Name = "cmbConsultaMarca";
            this.cmbConsultaMarca.Size = new System.Drawing.Size(101, 21);
            this.cmbConsultaMarca.TabIndex = 3;
            this.cmbConsultaMarca.SelectedIndexChanged += new System.EventHandler(this.cmbConsultaMarca_SelectedIndexChanged);
            // 
            // lblConsultaDatos
            // 
            this.lblConsultaDatos.AutoSize = true;
            this.lblConsultaDatos.Location = new System.Drawing.Point(217, 22);
            this.lblConsultaDatos.Name = "lblConsultaDatos";
            this.lblConsultaDatos.Size = new System.Drawing.Size(104, 13);
            this.lblConsultaDatos.TabIndex = 9;
            this.lblConsultaDatos.Text = "Datos de Repuestos";
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.Enabled = false;
            this.cmdRegistrar.Location = new System.Drawing.Point(479, 50);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(75, 23);
            this.cmdRegistrar.TabIndex = 2;
            this.cmdRegistrar.Text = "Registrar";
            this.cmdRegistrar.UseVisualStyleBackColor = true;
            this.cmdRegistrar.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(479, 108);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 23);
            this.cmdSalir.TabIndex = 3;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Enabled = false;
            this.cmdConsultar.Location = new System.Drawing.Point(479, 255);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(75, 23);
            this.cmdConsultar.TabIndex = 4;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Location = new System.Drawing.Point(479, 304);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(75, 23);
            this.cmdLimpiar.TabIndex = 5;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // lstConsultaDatos
            // 
            this.lstConsultaDatos.FormattingEnabled = true;
            this.lstConsultaDatos.Location = new System.Drawing.Point(201, 38);
            this.lstConsultaDatos.Name = "lstConsultaDatos";
            this.lstConsultaDatos.Size = new System.Drawing.Size(168, 121);
            this.lstConsultaDatos.TabIndex = 10;
            // 
            // frmRepuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 403);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdRegistrar);
            this.Controls.Add(this.mrcRepuestosIngresados);
            this.Controls.Add(this.mrcDatosRepuestos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRepuestos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repuestos";
            this.mrcDatosRepuestos.ResumeLayout(false);
            this.mrcDatosRepuestos.PerformLayout();
            this.mrcOrigen.ResumeLayout(false);
            this.mrcOrigen.PerformLayout();
            this.mrcRepuestosIngresados.ResumeLayout(false);
            this.mrcRepuestosIngresados.PerformLayout();
            this.mrcConsultaOrigen.ResumeLayout(false);
            this.mrcConsultaOrigen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcDatosRepuestos;
        private System.Windows.Forms.GroupBox mrcOrigen;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.GroupBox mrcRepuestosIngresados;
        private System.Windows.Forms.RadioButton optNacional;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.RadioButton optImportado;
        private System.Windows.Forms.ComboBox cmbConsultaMarca;
        private System.Windows.Forms.GroupBox mrcConsultaOrigen;
        private System.Windows.Forms.RadioButton optConsultaImportado;
        private System.Windows.Forms.RadioButton optConsultaNacional;
        private System.Windows.Forms.Label lblConsultaMarca;
        private System.Windows.Forms.Label lblConsultaDatos;
        private System.Windows.Forms.Button cmdRegistrar;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.ListBox lstConsultaDatos;
    }
}

