using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Epicode_S3_L4_BackEnd
{
    public partial class Default1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string fileName = "";
            if (UpFoto.HasFile)
            {
                fileName = UpFoto.FileName;
                UpFoto.SaveAs(Server.MapPath($"/Content/img/{UpFoto.FileName}"));
            }

            string connectionString = ConfigurationManager.ConnectionStrings["Rubrica"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand
                    {
                        Connection = conn,
                        CommandText = "INSERT INTO RUBRICA VALUES (@Nome, @Cognome, @Indirizzo, @Telefono, @Email, @Foto)"
                    };
                    cmd.Parameters.AddWithValue("@Nome", TextNome.Text);
                    cmd.Parameters.AddWithValue("@Cognome", TextCognome.Text);
                    cmd.Parameters.AddWithValue("@Indirizzo", TextIndirizzo.Text);
                    cmd.Parameters.AddWithValue("@Telefono", TextTelefono.Text);
                    cmd.Parameters.AddWithValue("@Email", TextEmail.Text);
                    cmd.Parameters.AddWithValue("@Foto", fileName);

                    int inserimentoEffettuato = cmd.ExecuteNonQuery();

                    if (inserimentoEffettuato > 0)
                    {
                        Label1.Text = "Inserimento effettuato con successo."; 
                    }
                    else
                    {
                        Label1.Text = "Nessuna riga inserita nel database.";
                    }
                }
                catch (Exception)
                {
                    Label1.Text = "Errore durante l'inserimento dei dati.";
                }
            }
        }
    }
}