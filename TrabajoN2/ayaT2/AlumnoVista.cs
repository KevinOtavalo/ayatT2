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
using ayaBL;

namespace ayaT2
{
    public partial class AlumnoVista : Form
    {
        public AlumnoVista()
        {
            InitializeComponent();
            CargarAlumnos();//carga los alumnos que ya entan registrados
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {

            //validacion de que no esten vacios
            if (string.IsNullOrWhiteSpace(txb_NombreAlumno.Text))
            {
                MessageBox.Show("El campo Nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (string.IsNullOrWhiteSpace(txb_ApellidoPat.Text))
            {
                MessageBox.Show("El campo Apellido Paterno no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (string.IsNullOrWhiteSpace(txb_ApellidoMat.Text))
            {
                MessageBox.Show("El campo Apellido Materno no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (string.IsNullOrWhiteSpace(txb_Email.Text) || !IsValidEmail(txb_Email.Text))
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //validacion de que no este vacio y que sea un dato valido (int)
            if (string.IsNullOrWhiteSpace(txb_NumeroMatricula.Text) ||
                !int.TryParse(txb_NumeroMatricula.Text, out int numeroMatricula))
            {
                MessageBox.Show("Por favor, ingrese un Número de Matrícula válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            //crea un nuevo objeto para almacenar datos dentro de ellos
            Alumnos nuevoAlumno = new Alumnos
            {   
                NombreAlumno = txb_NombreAlumno.Text,
                ApellidoPatAlumno = txb_ApellidoPat.Text,
                ApellidoMatAlumno = txb_ApellidoMat.Text,
                Email = txb_Email.Text,
                NumeroMatricula = numeroMatricula
            };
            //intentamos ingresar los datos a la base de datos
            if (ayaBL.ayaBL.InsertarAlumno(nuevoAlumno))
            {
                MessageBox.Show("Alumno agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarAlumnos();
            }
            //si ocurre un error lanza un mensaje
            else
            {
                MessageBox.Show("Error al agregar el alumno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //limpia los campos de texto
        private void LimpiarCampos()
        {
            txb_NombreAlumno.Clear();
            txb_ApellidoPat.Clear();
            txb_ApellidoMat.Clear();
            txb_Email.Clear();
            txb_NumeroMatricula.Clear();
        }

       

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        //metodo para cargar los datos de los alumnos dentro de dataGridView
        public void CargarAlumnos()
        {
            List<Alumnos> listaAlumnos = ayaBL.ayaBL.SeleccionarTodosAlumnos();
            dataGridView1.DataSource = listaAlumnos; 
        }

        //metodo para modificar los datos de un alumno
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Alumnos alumnoSeleccionado = (Alumnos)dataGridView1.SelectedRows[0].DataBoundItem;//esto obtiene el alumno seleccionado

                EditarAlumno editarForm = new EditarAlumno(alumnoSeleccionado);//creamos un formulario para la edicion

                if (editarForm.ShowDialog() == DialogResult.OK)
                {
                    CargarAlumnos();//carga la lista actualizada de datos
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un alumno para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //metodo para eliminar un alumno dentro de la base de datos
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) 
            {
                int idAlumno = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["IdAlumno"].Value);

                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este alumno?", "Confirmación", MessageBoxButtons.YesNo);//confirmacion para eliminar

                if (result == DialogResult.Yes)
                {
                    if (ayaBL.ayaBL.EliminarAlumno(idAlumno))
                    {//mensajes de exito
                        MessageBox.Show("Alumno eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarAlumnos();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el alumno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un alumno para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AlumnoVista_Load(object sender, EventArgs e)
        {

        }
    }
}
