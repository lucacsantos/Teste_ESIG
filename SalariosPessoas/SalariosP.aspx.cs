using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SalariosPessoas
{
    public partial class SalariosP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                _ = CarregarTodosSalariosAsync();
            }
        }
        protected async void btn_Calcular(object sender, EventArgs e)
        {
            await CarregarTodosSalariosAsync();

        }
        private async Task CarregarTodosSalariosAsync()
        {
            string connec = @"Data Source=localhost;Initial Catalog=ESIG;Integrated Security=True; User ID= sa; Password=lucas2407;";
            
            using (SqlConnection conn = new SqlConnection(connec))
            {
                await conn.OpenAsync();

                using (SqlCommand command = new SqlCommand("proce_pessoa_salario", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        salariosGrid.DataSource = dataTable;
                        salariosGrid.DataBind();
                    }
                }
            }
        }
    }
}