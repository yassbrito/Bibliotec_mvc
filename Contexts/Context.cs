using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bibliotec.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Bibliotec.Contexts
{
     public class Contexts : DbContext
    {
        public Contexts(){


        }

        public Contexts (DbContextOptions<Contexts> options) : base
        (options){


        }
    //configuring --> possui as configuraçao da conexao do banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            //colocar as informacoes do banco
            if(!optionsBuilder.IsConfigured){
                //a string da conexao do banco  de dados: Data Soure => Nome do servidor do banco de dados
                //initial catalog => nome do banco de dados
                //user id e password => informacoes de acesso ao servidor do banco de dados
                
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-QS05JTF\\SQLEXPRESS; Initial Catalog = Bibliotec_mvc; User Id=sa; Password=123; Integrated Security=true; TrustServerCertificate = true");
            }
        }

        //as referencias das nossas tabelas no banco de dados:
        public DbSet<Categoria> Categoria {get; set;}
        public DbSet<Curso> Curso {get; set;}
        public DbSet<Usuario> Usuario {get; set;}
        public DbSet<LivroCategoria> LivroCategoria {get; set;}
        public DbSet<LivroReserva> LivroReserva {get; set;}
        
    }
    
}