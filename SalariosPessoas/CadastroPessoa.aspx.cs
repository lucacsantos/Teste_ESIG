using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SalariosPessoas
{
    public partial class CadastroPessoa : System.Web.UI.Page
    {
        protected async Task Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                await CargosAsync();
            }
        }

        private async Task CargosAsync()
        {
            string connec = @"Data Source=localhost;Initial Catalog=ESIG;Integrated Security=True; User ID= sa; Password=lucas2407;";

            using (SqlConnection conn = new SqlConnection(connec))
            {
                await conn.OpenAsync();

                using (SqlCommand command = new SqlCommand("SELECT ID, Nome FROM Cargo", conn))
                {
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        dCargos.DataSource = reader;
                        dCargos.DataTextField = "Nome";
                        dCargos.DataTextField = "ID";
                        dCargos.DataBind();
                    }
                }
            }
            dCargos.Items.Insert(0, new ListItem("Selecione", "0"));
        }
        protected async void btn_Salvar(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            int cargoId = int.Parse(dCargos.SelectedValue);
            string cidade = txtCidade.Text.Trim();
            string email = txtEmail.Text.Trim();
            string cep = txtCEP.Text.Trim();
            string endereco = txtEndereco.Text.Trim();
            string pais = txtPais.Text.Trim();
            string usuario = txtUsuario.Text.Trim();
            string telefone = txtTelefone.Text.Trim();
            string dataNacimento = textDataNascimento.Text.Trim();

            if (string.IsNullOrEmpty(nome) || cargoId == 0)
            {
                lblMensagem.Text = "Preencha todos os campos.";
                lblMensagem.ForeColor = Color.Red;
                return;
            }

            string connec = @"Data Source=localhost;Initial Catalog=ESIG;Integrated Security=True; User ID= sa; Password=lucas2407;";
            using (SqlConnection conn = new SqlConnection(connec))
            {
                await conn.OpenAsync();

                string query = "INSERT INTO Pessoa (Nome, Cidade, Email, CEP, Endereco, Pais, Usuario, Telefone, Data_Nascimento, Cargo_ID)" +
                    "VALUES (@Nome, @Cidade, @Email, @CEP, @Endereco, @Pais, @Usuario, @Telefone, @DataNascimento, @CargoID)";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Nome", nome);
                    command.Parameters.AddWithValue("@CargoID", cargoId);
                    command.Parameters.AddWithValue("@Cidade", cidade);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@CEP", cep);
                    command.Parameters.AddWithValue("@Pais", pais);
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@Telefone", telefone);
                    command.Parameters.AddWithValue("@DataNascimento", dataNacimento);
                    await command.ExecuteNonQueryAsync();
                }
            }
        }
    }
}