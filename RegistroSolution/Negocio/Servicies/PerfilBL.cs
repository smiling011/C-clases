using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Repositories;
using Entidades.Modelos;

namespace Negocio.Servicies
{
    public class PerfilBL

    {
        private PerfilDAL dal = new PerfilDAL();

        public List<perfil> Listar()
        {
            return dal.Listar();
        }
    }
}
