namespace Comisaría
{
    partial class Form1
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
            this.btnCrearComisaria = new System.Windows.Forms.Button();
            this.gbAdmin = new System.Windows.Forms.GroupBox();
            this.btnListarIncidentes = new System.Windows.Forms.Button();
            this.gbOperaciones = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbAdminG = new System.Windows.Forms.GroupBox();
            this.lbPlaca = new System.Windows.Forms.Label();
            this.gbAdminI = new System.Windows.Forms.GroupBox();
            this.nudNroGuardia = new System.Windows.Forms.NumericUpDown();
            this.nudDesde = new System.Windows.Forms.NumericUpDown();
            this.nudDuracion = new System.Windows.Forms.NumericUpDown();
            this.nudHasta = new System.Windows.Forms.NumericUpDown();
            this.lbNroGuardia = new System.Windows.Forms.Label();
            this.lbDesde = new System.Windows.Forms.Label();
            this.lbDuracion = new System.Windows.Forms.Label();
            this.btnAsignacion = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lbMotivo = new System.Windows.Forms.Label();
            this.lbPersona = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.nudMinutos = new System.Windows.Forms.NumericUpDown();
            this.nudHora = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbTipo = new System.Windows.Forms.Label();
            this.tbPersona = new System.Windows.Forms.TextBox();
            this.lbDNI = new System.Windows.Forms.Label();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.lbxMotivo = new System.Windows.Forms.ListBox();
            this.gbAdmin.SuspendLayout();
            this.gbOperaciones.SuspendLayout();
            this.gbAdminG.SuspendLayout();
            this.gbAdminI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNroGuardia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHora)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearComisaria
            // 
            this.btnCrearComisaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearComisaria.Location = new System.Drawing.Point(156, 14);
            this.btnCrearComisaria.Name = "btnCrearComisaria";
            this.btnCrearComisaria.Size = new System.Drawing.Size(128, 57);
            this.btnCrearComisaria.TabIndex = 0;
            this.btnCrearComisaria.Text = "Abrir Comisaría";
            this.btnCrearComisaria.UseVisualStyleBackColor = true;
            this.btnCrearComisaria.Click += new System.EventHandler(this.btnCrearComisaria_Click);
            // 
            // gbAdmin
            // 
            this.gbAdmin.Controls.Add(this.btnListarIncidentes);
            this.gbAdmin.Controls.Add(this.btnCrearComisaria);
            this.gbAdmin.Location = new System.Drawing.Point(13, 13);
            this.gbAdmin.Name = "gbAdmin";
            this.gbAdmin.Size = new System.Drawing.Size(462, 77);
            this.gbAdmin.TabIndex = 1;
            this.gbAdmin.TabStop = false;
            this.gbAdmin.Text = "Administración comisaría";
            // 
            // btnListarIncidentes
            // 
            this.btnListarIncidentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarIncidentes.Location = new System.Drawing.Point(310, 14);
            this.btnListarIncidentes.Name = "btnListarIncidentes";
            this.btnListarIncidentes.Size = new System.Drawing.Size(128, 57);
            this.btnListarIncidentes.TabIndex = 1;
            this.btnListarIncidentes.Text = "Listar Incidentes";
            this.btnListarIncidentes.UseVisualStyleBackColor = true;
            // 
            // gbOperaciones
            // 
            this.gbOperaciones.Controls.Add(this.gbAdminI);
            this.gbOperaciones.Controls.Add(this.lbPlaca);
            this.gbOperaciones.Controls.Add(this.gbAdminG);
            this.gbOperaciones.Location = new System.Drawing.Point(13, 96);
            this.gbOperaciones.Name = "gbOperaciones";
            this.gbOperaciones.Size = new System.Drawing.Size(462, 355);
            this.gbOperaciones.TabIndex = 2;
            this.gbOperaciones.TabStop = false;
            this.gbOperaciones.Text = "Operaciones sobre el agente";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(172, 457);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(125, 26);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // gbAdminG
            // 
            this.gbAdminG.Controls.Add(this.btnAsignacion);
            this.gbAdminG.Controls.Add(this.lbDuracion);
            this.gbAdminG.Controls.Add(this.lbDesde);
            this.gbAdminG.Controls.Add(this.lbNroGuardia);
            this.gbAdminG.Controls.Add(this.nudHasta);
            this.gbAdminG.Controls.Add(this.nudDuracion);
            this.gbAdminG.Controls.Add(this.nudDesde);
            this.gbAdminG.Controls.Add(this.nudNroGuardia);
            this.gbAdminG.Location = new System.Drawing.Point(17, 41);
            this.gbAdminG.Name = "gbAdminG";
            this.gbAdminG.Size = new System.Drawing.Size(421, 102);
            this.gbAdminG.TabIndex = 0;
            this.gbAdminG.TabStop = false;
            this.gbAdminG.Text = "Administración de guardias";
            // 
            // lbPlaca
            // 
            this.lbPlaca.AutoSize = true;
            this.lbPlaca.Location = new System.Drawing.Point(60, 25);
            this.lbPlaca.Name = "lbPlaca";
            this.lbPlaca.Size = new System.Drawing.Size(86, 13);
            this.lbPlaca.TabIndex = 1;
            this.lbPlaca.Text = "Placa de Agente";
            // 
            // gbAdminI
            // 
            this.gbAdminI.Controls.Add(this.lbxMotivo);
            this.gbAdminI.Controls.Add(this.tbDNI);
            this.gbAdminI.Controls.Add(this.lbDNI);
            this.gbAdminI.Controls.Add(this.tbPersona);
            this.gbAdminI.Controls.Add(this.lbTipo);
            this.gbAdminI.Controls.Add(this.textBox1);
            this.gbAdminI.Controls.Add(this.lbMotivo);
            this.gbAdminI.Controls.Add(this.btnRegistrar);
            this.gbAdminI.Controls.Add(this.lbPersona);
            this.gbAdminI.Controls.Add(this.lbHora);
            this.gbAdminI.Controls.Add(this.nudMinutos);
            this.gbAdminI.Controls.Add(this.nudHora);
            this.gbAdminI.Location = new System.Drawing.Point(17, 149);
            this.gbAdminI.Name = "gbAdminI";
            this.gbAdminI.Size = new System.Drawing.Size(421, 195);
            this.gbAdminI.TabIndex = 1;
            this.gbAdminI.TabStop = false;
            this.gbAdminI.Text = "Administración de incidentes";
            // 
            // nudNroGuardia
            // 
            this.nudNroGuardia.Location = new System.Drawing.Point(163, 19);
            this.nudNroGuardia.Name = "nudNroGuardia";
            this.nudNroGuardia.Size = new System.Drawing.Size(104, 20);
            this.nudNroGuardia.TabIndex = 0;
            // 
            // nudDesde
            // 
            this.nudDesde.Location = new System.Drawing.Point(163, 45);
            this.nudDesde.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudDesde.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDesde.Name = "nudDesde";
            this.nudDesde.Size = new System.Drawing.Size(49, 20);
            this.nudDesde.TabIndex = 1;
            this.nudDesde.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudDuracion
            // 
            this.nudDuracion.Location = new System.Drawing.Point(163, 71);
            this.nudDuracion.Name = "nudDuracion";
            this.nudDuracion.Size = new System.Drawing.Size(104, 20);
            this.nudDuracion.TabIndex = 2;
            // 
            // nudHasta
            // 
            this.nudHasta.Location = new System.Drawing.Point(218, 45);
            this.nudHasta.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudHasta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHasta.Name = "nudHasta";
            this.nudHasta.Size = new System.Drawing.Size(49, 20);
            this.nudHasta.TabIndex = 3;
            this.nudHasta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbNroGuardia
            // 
            this.lbNroGuardia.AutoSize = true;
            this.lbNroGuardia.Location = new System.Drawing.Point(76, 21);
            this.lbNroGuardia.Name = "lbNroGuardia";
            this.lbNroGuardia.Size = new System.Drawing.Size(64, 13);
            this.lbNroGuardia.TabIndex = 2;
            this.lbNroGuardia.Text = "Nro Guardia";
            // 
            // lbDesde
            // 
            this.lbDesde.AutoSize = true;
            this.lbDesde.Location = new System.Drawing.Point(102, 47);
            this.lbDesde.Name = "lbDesde";
            this.lbDesde.Size = new System.Drawing.Size(38, 13);
            this.lbDesde.TabIndex = 4;
            this.lbDesde.Text = "Desde";
            // 
            // lbDuracion
            // 
            this.lbDuracion.AutoSize = true;
            this.lbDuracion.Location = new System.Drawing.Point(36, 73);
            this.lbDuracion.Name = "lbDuracion";
            this.lbDuracion.Size = new System.Drawing.Size(104, 13);
            this.lbDuracion.TabIndex = 5;
            this.lbDuracion.Text = "Duración en minutos";
            // 
            // btnAsignacion
            // 
            this.btnAsignacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignacion.Location = new System.Drawing.Point(287, 29);
            this.btnAsignacion.Name = "btnAsignacion";
            this.btnAsignacion.Size = new System.Drawing.Size(117, 46);
            this.btnAsignacion.TabIndex = 2;
            this.btnAsignacion.Text = "Asignación de las guardias";
            this.btnAsignacion.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(313, 135);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(91, 44);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar Incidente";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // lbMotivo
            // 
            this.lbMotivo.AutoSize = true;
            this.lbMotivo.Location = new System.Drawing.Point(33, 138);
            this.lbMotivo.Name = "lbMotivo";
            this.lbMotivo.Size = new System.Drawing.Size(39, 13);
            this.lbMotivo.TabIndex = 12;
            this.lbMotivo.Text = "Motivo";
            // 
            // lbPersona
            // 
            this.lbPersona.AutoSize = true;
            this.lbPersona.Location = new System.Drawing.Point(26, 100);
            this.lbPersona.Name = "lbPersona";
            this.lbPersona.Size = new System.Drawing.Size(46, 13);
            this.lbPersona.TabIndex = 11;
            this.lbPersona.Text = "Persona";
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Location = new System.Drawing.Point(42, 66);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(30, 13);
            this.lbHora.TabIndex = 8;
            this.lbHora.Text = "Hora";
            // 
            // nudMinutos
            // 
            this.nudMinutos.Location = new System.Drawing.Point(135, 64);
            this.nudMinutos.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudMinutos.Name = "nudMinutos";
            this.nudMinutos.Size = new System.Drawing.Size(49, 20);
            this.nudMinutos.TabIndex = 10;
            // 
            // nudHora
            // 
            this.nudHora.Location = new System.Drawing.Point(80, 64);
            this.nudHora.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudHora.Name = "nudHora";
            this.nudHora.Size = new System.Drawing.Size(49, 20);
            this.nudHora.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 13;
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(10, 36);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(75, 13);
            this.lbTipo.TabIndex = 14;
            this.lbTipo.Text = "Tipo Incidente";
            // 
            // tbPersona
            // 
            this.tbPersona.Location = new System.Drawing.Point(79, 97);
            this.tbPersona.Name = "tbPersona";
            this.tbPersona.Size = new System.Drawing.Size(100, 20);
            this.tbPersona.TabIndex = 15;
            // 
            // lbDNI
            // 
            this.lbDNI.AutoSize = true;
            this.lbDNI.Location = new System.Drawing.Point(187, 100);
            this.lbDNI.Name = "lbDNI";
            this.lbDNI.Size = new System.Drawing.Size(26, 13);
            this.lbDNI.TabIndex = 16;
            this.lbDNI.Text = "DNI";
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(219, 97);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(100, 20);
            this.tbDNI.TabIndex = 17;
            // 
            // lbxMotivo
            // 
            this.lbxMotivo.FormattingEnabled = true;
            this.lbxMotivo.Location = new System.Drawing.Point(80, 123);
            this.lbxMotivo.Name = "lbxMotivo";
            this.lbxMotivo.Size = new System.Drawing.Size(227, 56);
            this.lbxMotivo.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 495);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbOperaciones);
            this.Controls.Add(this.gbAdmin);
            this.Name = "Form1";
            this.Text = "Actividad 2";
            this.gbAdmin.ResumeLayout(false);
            this.gbOperaciones.ResumeLayout(false);
            this.gbOperaciones.PerformLayout();
            this.gbAdminG.ResumeLayout(false);
            this.gbAdminG.PerformLayout();
            this.gbAdminI.ResumeLayout(false);
            this.gbAdminI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNroGuardia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox gbAdmin;
        public System.Windows.Forms.Button btnListarIncidentes;
        public System.Windows.Forms.Button btnCrearComisaria;
        public System.Windows.Forms.GroupBox gbOperaciones;
        private System.Windows.Forms.Label lbPlaca;
        public System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.GroupBox gbAdminG;
        public System.Windows.Forms.GroupBox gbAdminI;
        private System.Windows.Forms.Label lbDuracion;
        private System.Windows.Forms.Label lbNroGuardia;
        public System.Windows.Forms.NumericUpDown nudNroGuardia;
        public System.Windows.Forms.Label lbDesde;
        public System.Windows.Forms.NumericUpDown nudDesde;
        public System.Windows.Forms.NumericUpDown nudHasta;
        public System.Windows.Forms.NumericUpDown nudDuracion;
        public System.Windows.Forms.Button btnRegistrar;
        public System.Windows.Forms.Button btnAsignacion;
        private System.Windows.Forms.Label lbMotivo;
        public System.Windows.Forms.Label lbPersona;
        private System.Windows.Forms.Label lbHora;
        public System.Windows.Forms.NumericUpDown nudMinutos;
        public System.Windows.Forms.NumericUpDown nudHora;
        public System.Windows.Forms.TextBox tbDNI;
        public System.Windows.Forms.Label lbDNI;
        public System.Windows.Forms.TextBox tbPersona;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.ListBox lbxMotivo;
    }
}

