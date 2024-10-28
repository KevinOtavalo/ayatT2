using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ayaBOL;

namespace ayaT2
{
    public partial class AsignaturaVista : Form
    {
        public AsignaturaVista()
        {
            InitializeComponent();
            CargarAsignaturas();//carga los datos que ya estan en la base de datos al iniciar el form
        }

        //limpia los textos
        private void LimpiarCamposAsignatura()
        {
            txb_NombreAsignatura.Clear();
            txb_Creditos.Clear();
        }

        //carga los datos que ya estan en la base de datos dentro de el dataGridView
        private void CargarAsignaturas()
        {
            List<Asignatura> listaAsignaturas = ayaBL.ayaBL.SeleccionarTodasAsignaturas();
            dataGridView1.DataSource = listaAsignaturas;
        }
        //metodo para guardar las asignatura en la base de datos
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //verifica que no este vacio
            if (string.IsNullOrWhiteSpace(txb_NombreAsignatura.Text))
            {
                MessageBox.Show("El campo Nombre de Asignatura no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txb_Creditos.Text) || !int.TryParse(txb_Creditos.Text, out int creditos))
            {
                MessageBox.Show("Ingrese una cantidad de créditos válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //crea un objeto y le agrega datos
            Asignatura nuevaAsignatura = new Asignatura
            {
                NombreAsignatura = txb_NombreAsignatura.Text,
                Creditos = creditos
            };
            if (ayaBL.ayaBL.InsertarAsignatura(nuevaAsignatura))
            {
                MessageBox.Show("Asignatura guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarAsignaturas();
                LimpiarCamposAsignatura();
            }
            else
            {
                MessageBox.Show("Error al guardar la asignatura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //metodo para modificar los datos de la asignatura
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Asignatura asignaturaSeleccionado = (Asignatura)dataGridView1.SelectedRows[0].DataBoundItem;

                EditarAsignatura editarFormulario = new EditarAsignatura(asignaturaSeleccionado);

                if (editarFormulario.ShowDialog() == DialogResult.OK)
                {
                    CargarAsignaturas();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un alumno para editar.","Advertencia", MessageBoxButtons.OK);
            }
        }
        //metodo para eliminar una asignatura dentro de la base de datos
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var seleccion = dataGridView1.SelectedRows[0].DataBoundItem;

                if (seleccion is Asignatura asignaturaSeleccionada)
                {
                    var resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar esta asignatura?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        ayaBL.ayaBL.EliminarAsignatura(asignaturaSeleccionada.CodAsignatura);
                        MessageBox.Show("Asignatura eliminada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CargarAsignaturas();
                    }
                }
                else
                {
                    MessageBox.Show("El tipo de dato seleccionado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una asignatura para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
