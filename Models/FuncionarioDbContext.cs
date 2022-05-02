using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Web.API.Token.Authentication.Models
{
    public class FuncionarioDbContext : DbContext
    {
        public FuncionarioDbContext() : base("name=FuncionarioDbContext") { }

        public virtual DbSet<Funcionario> Funcionarios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
    }
}