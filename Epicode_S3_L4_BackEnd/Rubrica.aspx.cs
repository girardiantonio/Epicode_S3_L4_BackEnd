using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Reflection.Emit;

namespace Epicode_S3_L4_BackEnd
{
    public partial class Rubrica1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadContacts();
            }
        }

        private void LoadContacts()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Rubrica"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM rubrica", conn);
                SqlDataReader sqlDataReader;

                conn.Open();

                List<Rubrica> listaClienti = new List<Rubrica>();

                sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Rubrica cliente = new Rubrica();

                    cliente.Id = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Id"));
                    cliente.Nome = sqlDataReader["Nome"].ToString();
                    cliente.Cognome = sqlDataReader["Cognome"].ToString();
                    cliente.Indirizzo = sqlDataReader["Indirizzo"].ToString();
                    cliente.Telefono = sqlDataReader["Telefono"].ToString();
                    cliente.Email = sqlDataReader["Email"].ToString();
                    listaClienti.Add(cliente);
                }

                conn.Close();

                Repeater1.DataSource = listaClienti;
                Repeater1.DataBind();
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            LoadContacts();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string idContatto = button.CommandArgument;

            string connectionString = ConfigurationManager.ConnectionStrings["Rubrica"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM rubrica WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", idContatto);
                int eliminazioneEffettuata = cmd.ExecuteNonQuery();
                conn.Close();

                if (eliminazioneEffettuata > 0)
                {
                    Response.Write("Contatto eliminato con successo.");
                    LoadContacts();
                }
                else
                {
                    Response.Write("Nessun contatto trovato con l'ID specificato.");
                }
            }
            Response.Redirect("Rubrica.aspx");
        }
    }
}