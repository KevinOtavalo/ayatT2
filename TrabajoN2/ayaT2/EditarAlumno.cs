using ayaBOL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ayaBL;

namespace ayaT2
{
    public partial class EditarAlumno : Form
    {
        private Alumnos alumno; //variable que usaremos para guardar la informacion de alumno
        public EditarAlumno(Alumnos alumno)
        {
            InitializeComponent();
            this.alumno = alumno;//Asigna el objeto Alumnos recibido a la variable de clase
            CargarDatosAlumno();//Al cargar el form ya apareceran los datos del alumno a editar
        }

        //validacion de que el email tiene el formato correcto
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
        //rellena con los datos del alumno seleccionado
        private void CargarDatosAlumno()
        {
            txb_NombreAlumno.Text = alumno.NombreAlumno;
            txb_ApellidoPat.Text = alumno.ApellidoPatAlumno;
            txb_ApellidoMat.Text = alumno.ApellidoMatAlumno;
            txb_Email.Text = alumno.Email;
            txb_NumeroMatricula.Text = alumno.NumeroMatricula.ToString();
        }

        //boton para guardar los cambios realizados
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //validacion de que no esten vacios los datos
            if (string.IsNullOrWhiteSpace(txb_NombreAlumno.Text) ||
           string.IsNullOrWhiteSpace(txb_ApellidoPat.Text) ||
           string.IsNullOrWhiteSpace(txb_ApellidoMat.Text) ||
           string.IsNullOrWhiteSpace(txb_Email.Text) ||
           !IsValidEmail(txb_Email.Text) ||
           !int.TryParse(txb_NumeroMatricula.Text, out int numeroMatricula))//validacion de que es un "int"
            {
                MessageBox.Show("Por favor, completa todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            alumno.NombreAlumno = txb_NombreAlumno.Text;
            alumno.ApellidoPatAlumno = txb_ApellidoPat.Text;
            alumno.ApellidoMatAlumno = txb_ApellidoMat.Text;
            alumno.Email = txb_Email.Text;
            alumno.NumeroMatricula = numeroMatricula;

            ayaBL.ayaBL.ModificarAlumno(alumno);

            MessageBox.Show("Los datos del alumno se han actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); 
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            
                this.Close(); 
            
        }
    }
}
