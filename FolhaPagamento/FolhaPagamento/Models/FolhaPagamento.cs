namespace API.Models;

public class Folha{

    public Folha(){
        Id = Guid.NewGuid().ToString();
        calculoSalario();
    }
    
    public void calculoSalario(){
         salarioBruto = valor * quantidade;  
    }

    public string Id { get; set; }
    public float? valor { get; set; }
    public int? quantidade { get; set; }
    public int? mes { get; set; }
    public int? ano { get; set; }
    public float? salarioBruto { get; set; }
    public float? impostoIrrf { get; set; }
    public float? impostoInss  { get; set; }
    public float? impostoFgts {get; set; }
    public float? salarioLiquido { get; set; }
}
