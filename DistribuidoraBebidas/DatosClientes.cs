using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace DistribuidoraBebidas
{
    internal class DatosClientes
    {
        public string IdCliente { set; get; }
        public string NombreCliente { set; get; }
        public string IdCedula { set; get; }
        public string Telefono { set; get; }
        public string Direccion { set; get; }
        public string Fecha { set; get; }

        public List<DatosClientes> TodosLosClientes()
        {
            List<DatosClientes> listaDatos = new List<DatosClientes>();
            ConexionBD conexion = new ConexionBD();

            using (SqlConnection connect = conexion.ObtenerConexion())
            {
                connect.Open();

                string selectData = "SELECT IdCliente, NombreCliente, IdCedula, Telefono, Direccion, Fecha FROM Clientes";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        DatosClientes cData = new DatosClientes();
                        cData.IdCliente = reader["IdCliente"].ToString();
                        cData.NombreCliente = reader["NombreCliente"].ToString();
                        cData.IdCedula = reader["IdCedula"].ToString();
                        cData.Telefono = reader["Telefono"].ToString();
                        cData.Direccion = reader["Direccion"].ToString();
                        cData.Fecha = reader["Fecha"].ToString();

                        listaDatos.Add(cData);
                    }
                }
            }
            return listaDatos;
        }
    }
}