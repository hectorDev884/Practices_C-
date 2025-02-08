using Microsoft.Data.SqlClient;
using System.Data;

namespace HMTC_Practica21
{
    public partial class frmPractica21 : Form
    {
        public frmPractica21()
        {
            InitializeComponent();
        }

        private void frmPractica21_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=.;Initial Catalog=SistemaPedidos;" +
                "Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            string query = "SELECT * FROM Clientes";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgvDatos.DataSource = dataTable;

            connection.Close();
        }
    }
}
