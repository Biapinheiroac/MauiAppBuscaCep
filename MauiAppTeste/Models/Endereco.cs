using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppTeste.Models
{
    public class Endereco
    {
        public int id_logradouro { get; set; }

        public int id_cidade { get; set; }

        public string tipo { get; set; }

        public int descricao { get; set; }

        public string uf { get; set; }

        public int complemento { get; set; }

        public string descricao_sem_numero { get; set; }

        public string descricao_cidade { get; set; }

        public int codigo_cidade_ibge { get; set; }

        public string descricao_bairro { get; set; }

        public object rows { get; set; }

        public int CEP { get; set; }

        public string UF { get; set; }  
    }
}
