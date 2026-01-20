using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Entidades.Modelos;

namespace Datos.Repositories
{
    public class PerfilDAL
    {
        string conexion = ConfigurationManager
            .ConnectionStrings["ConexionBD"].ConnectionString;

        public List<perfil> Listar()
        {

            {
                List<perfil> lista = new List<perfil>();
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    SqlCommand cmd = new SqlCommand(
                        "SELECT * FROM perfil", con);

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        lista.Add(new perfil
                        {
                            idperfil = (int)dr["idperfil"],
                            idregistro = (int)dr["idregistro"],
                            descripcion = dr["descripcion"].ToString()

                        });
                    }

                    return lista;
                }

            }
        }
    }
}
