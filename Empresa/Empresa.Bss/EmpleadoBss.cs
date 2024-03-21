using Empresa.Dal;
using Empresa.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Bss
{
    public class EmpleadoBss
    {
        EmpleadoDal dal = new EmpleadoDal();
        public DataTable ListarEmpleadoBss()
        {
            return dal.ListarEmpleadoDal();
        }

        public void InsertarEmpleadoBss(Empleado empleado)
        {
            dal.InsertarEmpleadoDal(empleado);
        }
        public Empleado ObtenerIdEBss(int id)
        {
            return dal.ObtenerEmpleadoId(id);
        }
        public void EditarEmpleadoBss(Empleado e)
        {
            dal.EditarEmpleadoDal(e);
        }
        public void EliminarEmpleadoBss(int id)
        {
            dal.EliminarEmpleadoDal(id);
        }
    }
}
