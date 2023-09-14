using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Epicode_S3_L4_BackEnd
{
    public class Rubrica
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Indirizzo { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public Rubrica() { }

        public Rubrica(int id, string nome, string cognome, string indirizzo, string telefono, string email)
        {
            Id = id;
            Nome = nome;
            Cognome = cognome;
            Indirizzo = indirizzo;
            Telefono = telefono;
            Email = email;
        }
    }
}