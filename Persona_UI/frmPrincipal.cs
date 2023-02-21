
using Persona_EL;
using Persona_LN;
using Persona_UI.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persona_UI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void FillGrid()
        {
            PersonaLN personaLN = new PersonaLN();
            dgvPersona.DataSource = personaLN.GetAllPersona();

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            FillGrid();
        }
        #region RefreshGrid
        private void AddPersonaEventHandler(object sender, frmRegistrar.UpdateEventArgs args)
        {
            FillGrid();
        }
        private void UpdatePersonaEventHandler(object sender, frmUpdate.UpdateEventArgs args)
        {
            FillGrid();
        }
        #endregion
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistrar frm = new frmRegistrar(this);
            frm.UpdateEventHandler += AddPersonaEventHandler;
            frm.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            PersonaLN personaLN = new PersonaLN();
            Persona persona = new Persona();
            string id = "";
            //Extraer valor dgv
            if (dgvPersona.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvPersona.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvPersona.Rows[selectedRowIndex];
                id = Convert.ToString(selectedRow.Cells["Identificacion"].Value);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un persona", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            persona = personaLN.GetPersonaById(id);

            //Extraer valor MessageBox
            DialogResult result = MessageBox.Show("Seguro desea eliminar?", "Eliminar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                personaLN.DeletePersona(persona.Id);
                MessageBox.Show("Persona eliminada correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillGrid();
            }
            //else
            //{
            //    MessageBox.Show("Ha ocurrido un error al eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            PersonaLN personaLN = new PersonaLN();
            Persona persona = new Persona();
            string id = "";
            //Extraer valor dgv
            if (dgvPersona.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dgvPersona.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvPersona.Rows[selectedRowIndex];
                id = Convert.ToString(selectedRow.Cells["Identificacion"].Value);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un persona", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            persona = personaLN.GetPersonaById(id);

            frmUpdate frm = new frmUpdate(this);
            frm.persona = persona;
            frm.UpdateEventHandler += UpdatePersonaEventHandler;
            frm.ShowDialog();
        }

        private void tclPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Mantener Actualizado el reporte
            List<Persona> lista = new List<Persona>();
            PersonaLN personaLN = new PersonaLN();
            lista = personaLN.GetAllPersona();
            //Instancia Reporte
            ReportPersona report = new ReportPersona();
            report.SetDataSource(lista);
            //Pasar a la herramienta
            crvPersona.ReportSource = report;
            
        }
    }
}
