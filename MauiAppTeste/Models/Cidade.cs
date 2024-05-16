using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppTeste.Models
{
    public class Cidade
    {
        public int id_cidade { get; set; }

        public string descricao { get; set; }

        public string uf { get; set; }

        public int codigo_ibg { get; set; }

        public string ddd { get; set; }
    }
}
