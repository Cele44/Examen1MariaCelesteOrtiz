using Empresa.Bss;
using Empresa.Modelos;
using Empresa.Vista.PersonaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa.Vista.EmpleadoVistas
{
    public partial class EmpleadoInsertarVista : Form
    {
        public EmpleadoInsertarVista()
        {
            InitializeComponent();
        }

        public static int IdPersonaSeleccionada = 0;
        PersonaBss bss = new PersonaBss();
        private void button3_Click_1(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bss.ObtenerIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
            }
        }

        EmpleadoBss bsse = new EmpleadoBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.IdPersona = IdPersonaSeleccionada;
            empleado.Puesto = textBox2.Text;
            empleado.Salario = Convert.ToDecimal(textBox3.Text);
            empleado.FechaContratacion = dateTimePicker1.Value;
            bsse.InsertarEmpleadoBss(empleado);
            MessageBox.Show("Empleado registrado");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        
    }
}
