using AvaliacaoEntrevistaAudrey2.Models.Enums;
using LojaVirtual.Libraries.Lang;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoEntrevistaAudrey2.Models
{
    public class Equipamento
    {
        //PK
        public int Id { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(4, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E002")]
        public string Nome { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(4, ErrorMessageResourceType = typeof(Mensagem), ErrorMessageResourceName = "MSG_E002")]
        public string IdentificadorEquipamento { get; set; }

        public Estados UfOrigem { get; set; }

        public Estados UfDestino { get; set; }

        public bool SentidoVia { get; set; }
        
        //Enum com as 3 opcoes do select  
        public  SentidoLeitura sentidoLeitura { get; set; }

        public Situacao Situacao { get; set; }

    }
}
