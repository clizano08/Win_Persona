
namespace Persona_UI
{
    partial class frmPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tclPersona = new System.Windows.Forms.TabControl();
            this.tpgPersona = new System.Windows.Forms.TabPage();
            this.dgvPersona = new System.Windows.Forms.DataGridView();
            this.Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpgReporte = new System.Windows.Forms.TabPage();
            this.RrtPersona = new Persona_UI.Reports.ReportPersona();
            this.crvPersona = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ReportPersona1 = new Persona_UI.Reports.ReportPersona();
            this.tclPersona.SuspendLayout();
            this.tpgPersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersona)).BeginInit();
            this.tpgReporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(16, 19);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(158, 63);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(538, 19);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(158, 63);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(721, 19);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(158, 63);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // tclPersona
            // 
            this.tclPersona.Controls.Add(this.tpgPersona);
            this.tclPersona.Controls.Add(this.tpgReporte);
            this.tclPersona.Location = new System.Drawing.Point(1, 4);
            this.tclPersona.Name = "tclPersona";
            this.tclPersona.SelectedIndex = 0;
            this.tclPersona.Size = new System.Drawing.Size(1009, 518);
            this.tclPersona.TabIndex = 3;
            this.tclPersona.SelectedIndexChanged += new System.EventHandler(this.tclPersona_SelectedIndexChanged);
            // 
            // tpgPersona
            // 
            this.tpgPersona.Controls.Add(this.dgvPersona);
            this.tpgPersona.Controls.Add(this.btnRegistrar);
            this.tpgPersona.Controls.Add(this.btnEliminar);
            this.tpgPersona.Controls.Add(this.btnActualizar);
            this.tpgPersona.Location = new System.Drawing.Point(4, 25);
            this.tpgPersona.Name = "tpgPersona";
            this.tpgPersona.Padding = new System.Windows.Forms.Padding(3);
            this.tpgPersona.Size = new System.Drawing.Size(1001, 489);
            this.tpgPersona.TabIndex = 0;
            this.tpgPersona.Text = "Persona";
            this.tpgPersona.UseVisualStyleBackColor = true;
            // 
            // dgvPersona
            // 
            this.dgvPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersona.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificacion,
            this.Nombre,
            this.Correo,
            this.Telefono,
            this.Nacimiento,
            this.Edad});
            this.dgvPersona.Location = new System.Drawing.Point(16, 98);
            this.dgvPersona.Name = "dgvPersona";
            this.dgvPersona.RowHeadersWidth = 51;
            this.dgvPersona.RowTemplate.Height = 24;
            this.dgvPersona.Size = new System.Drawing.Size(979, 385);
            this.dgvPersona.TabIndex = 3;
            // 
            // Identificacion
            // 
            this.Identificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Identificacion.DataPropertyName = "Id";
            this.Identificacion.HeaderText = "Cédula";
            this.Identificacion.MinimumWidth = 6;
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Nacimiento
            // 
            this.Nacimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nacimiento.DataPropertyName = "Nacimiento";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.Nacimiento.DefaultCellStyle = dataGridViewCellStyle1;
            this.Nacimiento.HeaderText = "Nacimiento";
            this.Nacimiento.MinimumWidth = 6;
            this.Nacimiento.Name = "Nacimiento";
            this.Nacimiento.ReadOnly = true;
            // 
            // Edad
            // 
            this.Edad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Edad.DataPropertyName = "Edad";
            this.Edad.HeaderText = "Edad";
            this.Edad.MinimumWidth = 6;
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            // 
            // tpgReporte
            // 
            this.tpgReporte.Controls.Add(this.crvPersona);
            this.tpgReporte.Location = new System.Drawing.Point(4, 25);
            this.tpgReporte.Name = "tpgReporte";
            this.tpgReporte.Padding = new System.Windows.Forms.Padding(3);
            this.tpgReporte.Size = new System.Drawing.Size(1001, 489);
            this.tpgReporte.TabIndex = 1;
            this.tpgReporte.Text = "Reporte";
            this.tpgReporte.UseVisualStyleBackColor = true;
            // 
            // crvPersona
            // 
            this.crvPersona.ActiveViewIndex = 0;
            this.crvPersona.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvPersona.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvPersona.DisplayStatusBar = false;
            this.crvPersona.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvPersona.Location = new System.Drawing.Point(3, 3);
            this.crvPersona.Name = "crvPersona";
            this.crvPersona.ReportSource = this.ReportPersona1;
            this.crvPersona.Size = new System.Drawing.Size(995, 483);
            this.crvPersona.TabIndex = 0;
            this.crvPersona.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 531);
            this.Controls.Add(this.tclPersona);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Personas";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tclPersona.ResumeLayout(false);
            this.tpgPersona.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersona)).EndInit();
            this.tpgReporte.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TabControl tclPersona;
        private System.Windows.Forms.TabPage tpgPersona;
        private System.Windows.Forms.DataGridView dgvPersona;
        private System.Windows.Forms.TabPage tpgReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private Reports.ReportPersona RrtPersona;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvPersona;
        private Reports.ReportPersona ReportPersona1;
    }
}

