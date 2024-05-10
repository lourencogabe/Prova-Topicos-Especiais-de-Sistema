using Microsoft.EntityFrameworkCore;

namespace API.Models;

public class AppDataContext : DbContext{
    public DbSet<Funcionario> TabelaFuncionario { get; set; }
    public DbSet<Folha> TabelaFolha { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        optionsBuilder.UseSqlite("Data Source=app.db");
    }
}