using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace GdExcel
{
    class Database
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=sistema;SslMode=none";
            MySqlConnection connection = new MySqlConnection(sql);
            try
            {
                connection.Open();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("ERRO DE CONEXÃO \n" + e.Message, "Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return connection;
        }

        public static void MostrarProcurar(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection mySqlConnection = GetConnection();
            MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dgv.DataSource = dataTable;
            mySqlConnection.Close();
        }
    }
}
