using Persona_EL;
using Persona_LN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persona_UI
{
    public partial class frmUpdate : Form
    {
        public Persona persona { get; set; }
        public frmUpdate(frmPrincipal frmPrincipal)
        {
            InitializeComponent();
        }
        #region RefreshGrid
        public delegate void UpdateDelegate(object serder, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }
        public void RefreshGrid()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }
        #endregion
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string Id = mtbIdentificacion.Text;
            string Nombre = txtNombre.Text;
            string Correo = txtCorreo.Text;
            string Telefono = mtbTelefono.Text;
            DateTime Nacimiento = dtpNacimiento.Value;

            if (String.IsNullOrEmpty(Id))
            {
                MessageBox.Show("El campo Cédula esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(Nombre))
            {
                MessageBox.Show("El campo Nombre esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(Correo))
            {
                MessageBox.Show("El campo Correo esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(Correo, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                MessageBox.Show("El campo Correo no es valido", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(Telefono))
            {
                MessageBox.Show("El campo Teléfono esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Nacimiento == null)
            {
                MessageBox.Show("El campo Fecha Nacimiento esta vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DateTime.Compare(Nacimiento, DateTime.Now) >= 0 && PersonaLN.ValidadeYear(Nacimiento) == false)
            {
                MessageBox.Show("Fecha invalida, No puedes agregar Personas menores a 1 año.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            PersonaLN personaLN = new PersonaLN();
            var persona = PersonaFactory.AddPersona(Id, Nombre, Correo, Telefono, Nacimiento);

            if (personaLN.SavePersona(persona) == null)
            {
                MessageBox.Show("Ha ocurrido un error al guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Persona actualizada correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clean();
                RefreshGrid();
                this.Dispose();
            }
        }
        private void Clean()
        {
            mtbIdentificacion.Clear();
            txtNombre.Clear();
            txtCorreo.Clear();
            mtbTelefono.Clear();
            dtpNacimiento.Value = DateTime.Now;
        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {
            mtbIdentificacion.Text = persona.Id;
            txtNombre.Text = persona.Nombre;
            txtCorreo.Text = persona.Correo;
            mtbTelefono.Text = persona.Telefono;
            dtpNacimiento.Value = persona.Nacimiento;
        }
    }
}
