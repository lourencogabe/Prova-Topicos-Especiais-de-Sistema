using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace API.Models;


public class Funcionario{
    public int? funcionarioId { get; set; }
    public string? nome { get; set;}
    public string? cpf { get; set; }

    public Funcionario(int Id,string Nome, string Cpf){
        funcionarioId=Id;
        nome = Nome;
        cpf = Cpf;
    }

    public Funcionario(){
    }
}

