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
            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Rubrica"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("SELECT * FROM rubrica", conn);
            SqlDataReader sqlDataReader;

            conn.Open();

            List<Rubrica> listaClienti = new List<Rubrica>();

            sqlDataReader = cmd.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Rubrica cliente = new Rubrica();

                cliente.Nome = sqlDataReader["Nome"].ToString();
                cliente.Cognome = sqlDataReader["Cognome"].ToString();
                cliente.Indirizzo = sqlDataReader["Indirizzo"].ToString();
                cliente.Telefono = sqlDataReader["Telefono"].ToString();
                cliente.Email = sqlDataReader["Email"].ToString();
                listaClienti.Add(cliente);
            }

            conn.Close();

            // Assegna la listaClienti come DataSource del Repeater
            Repeater1.DataSource = listaClienti;
            Repeater1.DataBind();
        }

    }
}