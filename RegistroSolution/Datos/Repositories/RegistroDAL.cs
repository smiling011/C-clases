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
    public class RegistroDAL
    {
        string conexion = ConfigurationManager
            .ConnectionStrings["ConexionBD"].ConnectionString;

        public List<registro> Listar()
        {
            
            {
                List<registro> lista = new List<registro>();
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    SqlCommand cmd = new SqlCommand(
                        "SELECT * FROM registro", con);

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        lista.Add(new registro
                        {
                            idregistro = (int)dr["idregistro"],
                            nombre = dr["nombre"].ToString(),
                            apellido = dr["apellido"].ToString(),
                            numero = (int)dr["numero"],
                            correo = dr["correo"].ToString()
                        });
                    }

                    return lista;
                }

            }
        }
    }
}
