using Empresa.Bss;
using Empresa.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Empresa.Vista.EmpleadoVistas
{
    public partial class EmpleadoEditarVista : Form
    {
        int idx = 0;
        Empleado m = new Empleado();
        EmpleadoBss bss = new EmpleadoBss();
        public EmpleadoEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void EmpleadoEditarVista_Load(object sender, EventArgs e)
        {
            m = bss.ObtenerIdEBss(idx);
            textBox1.Text = m.IdPersona.ToString();
            textBox2.Text = m.Puesto;
            textBox3.Text = m.Salario.ToString();
            dateTimePicker1.Value = m.FechaContratacion;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            m.IdPersona= Convert.ToInt32(textBox1.Text);
            m.Puesto = textBox2.Text;
            m.Salario = Convert.ToDecimal(textBox3.Text);
            m.FechaContratacion = dateTimePicker1.Value;

            bss.EditarEmpleadoBss(m);
            MessageBox.Show("Datos actulizados");
        }
    }
}
