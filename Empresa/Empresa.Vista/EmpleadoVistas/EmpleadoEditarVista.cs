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
        Empleado e = new Empleado();
        EmpleadoBss bss = new EmpleadoBss();
        public EmpleadoEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void EmpleadoEditarVista_Load(object sender, EventArgs e)
        {
            e = bss.ObtenerIdEBss(idx);
            
        }
    }
}
