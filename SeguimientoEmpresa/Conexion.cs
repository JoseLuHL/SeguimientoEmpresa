using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeguimientoEmpresa
{
    public class Conexion
    {
        SqlConnection SqlConnection;
        string cadena = "Data Source=DESKTOP-26KMVBP\\SQLEXPRESS;Initial Catalog=seguimiento_empresa;Integrated Security=True";
        public Conexion()
        {
            if (SqlConnection != null)
                SqlConnection = new SqlConnection(cadena);

            if (SqlConnection.State == System.Data.ConnectionState.Closed)
                SqlConnection.Open();
        }

        public SqlCommand ComandoSql(string sql)
        {
            var command = new SqlCommand(sql, this.SqlConnection);
            return command;
        }

        public DataTable DataAdapter(string sql)
        {
            DataTable table = new DataTable();
            var adaptador = new SqlDataAdapter(sql, this.SqlConnection);
            adaptador.Fill(table);
            return table;
        }
    }
}
