using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Repositories;
using Entidades.Modelos;

namespace Negocio.Servicies
{
    public class RegistroBL
    {
        
        private RegistroDAL dal = new RegistroDAL();

        public List<registro> Listar()
        {
            return dal.Listar();
        }

        //here other things


        
    }
}
