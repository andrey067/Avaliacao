using AvaliacaoEntrevistaAudrey2.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoEntrevistaAudrey2.Models
{
    public class Equipamento
    {
        //PK
        public int Id { get; set; }

        public string IdentificadorEquipamento { get; set; }

        public string UfOrigem { get; set; }

        public string UfDestino { get; set; }

        public bool SentidoVia { get; set; }
        
        //Enum com as 3 opcoes do select  
        public  SentidoLeitura sentidoLeitura { get; set; }

        public bool Situacao { get; set; }

    }
}
