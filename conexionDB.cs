using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusData
{
    public class conexionDB
    {
        private string user;
        private string dataBase;
        private static conexionDB con = null;

        private conexionDB()
        {
            this.dataBase = "dbBusData";
            this.user = "DESKTOP-00KJCV2";
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = "Server = " + this.user + "; database = " + this.dataBase + " ; integrated security = true";
                conexion.Open();
            }
            catch (Exception ex)
            {
                conexion = null;
                throw ex;
            }
            return conexion;
        }
        public static conexionDB getInstancia()
        {
            if (con == null)
            {
                con = new conexionDB();
            }
            return con;
        }
    }
}
