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
    public partial class EditarAsignatura : Form
    {
        private Asignatura asignatura;//variable que usaremos para guardar la informacion de asignatura
        public EditarAsignatura(Asignatura asignatura)
        {
            InitializeComponent();
            this.asignatura = asignatura;
            CargarDatosAsignatura();//metodo para cargar los datos de la asignatura seleccionada

        }
        //agrega los datos a el textbox para la edicion
        private void CargarDatosAsignatura()
        {
            txb_NombreAsignatura.Text = asignatura.NombreAsignatura;
            txb_Creditos.Text = asignatura.Creditos.ToString();
        }
        //guarda los datos modificados
        private void btn_Guardar_Click(object sender, EventArgs e)

        {//validacion para que no este vacio
            if (string.IsNullOrWhiteSpace(txb_NombreAsignatura.Text) ||
           !int.TryParse(txb_Creditos.Text, out int Creditos))

            {
                MessageBox.Show("Por favor, completa todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            asignatura.NombreAsignatura = txb_NombreAsignatura.Text;
            asignatura.Creditos = int.Parse(txb_Creditos.Text);

            ayaBL.ayaBL.ModificarAsignatura(asignatura);


            MessageBox.Show("Los datos del alumno se han actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }


        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
