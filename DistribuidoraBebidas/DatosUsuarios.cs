using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace DistribuidoraBebidas
{
    internal class DatosUsuarios
    {
        public string IdUsuario { set; get; }
        public string NombreUsuario { set; get; }
        public string Contrasena { set; get; }
        public string Cargo { set; get; }
        public string Estado { set; get; }
        public string Fecha { set; get; }

        public List<DatosUsuarios> TodosLosUsuarios()
        {
            List<DatosUsuarios> listaDatos = new List<DatosUsuarios>();

            ConexionBD conexion = new ConexionBD();

            using (SqlConnection connect = conexion.ObtenerConexion())
            {
                connect.Open();

                string selectData = "SELECT IdUsuario, NombreUsuario, Contraseña, Cargo, Estado, Fecha FROM Usuarios";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        DatosUsuarios uData = new DatosUsuarios();
                        uData.IdUsuario = reader["IdUsuario"].ToString();
                        uData.NombreUsuario = reader["NombreUsuario"].ToString();
                        uData.Contrasena = reader["Contraseña"].ToString();
                        uData.Cargo = reader["Cargo"].ToString();
                        uData.Estado = reader["Estado"].ToString();
                        uData.Fecha = reader["Fecha"].ToString();

                        listaDatos.Add(uData);
                    }
                }
            }
            return listaDatos;
        }
    }
}