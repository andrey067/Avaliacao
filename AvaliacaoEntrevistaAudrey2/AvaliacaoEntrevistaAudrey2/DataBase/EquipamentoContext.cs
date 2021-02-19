using AvaliacaoEntrevistaAudrey2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoEntrevistaAudrey2.DataBase
{
    public class EquipamentoContext : DbContext
    {

        //ORM - EF para mapear Objetos
        public EquipamentoContext(DbContextOptions<EquipamentoContext> options) : base(options) 
        { 
        
        
        }

        public DbSet<Equipamento> Equipamentos { get; set; }

        public DbSet<Estados> Estados { get; set; }

    }
}
