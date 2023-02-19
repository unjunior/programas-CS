using System.Collections.Generic;
using PagamentosFunc.entidades;
using System.Globalization;

List<Funcionario> func = new List<Funcionario>();

System.Console.Write("Digite o numero de funcionários: ");
int n = int.Parse(Console.ReadLine());

for(int i=1; i<=n; i++)
{   
    System.Console.WriteLine($"Funcionário #{i} dados:");
    System.Console.Write("O funcionário é terceirizado? ");
    char escolha = char.Parse(Console.ReadLine());
    System.Console.Write("Digite o nome do funcionário: ");
    string nome = Console.ReadLine();
    System.Console.Write("Digite a quantidade de horas: ");
    int horas = int.Parse(Console.ReadLine());
    System.Console.Write("Valor por hora: ");
    double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    
    
    if (escolha == 's')
    {
        System.Console.Write("Valor Adicional: ");
        double adicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        func.Add(new FuncionarioTerceirizado(nome, horas, valorHora, adicional));

    }
    else
    {
        func.Add(new Funcionario(nome, horas, valorHora));
    }
}

System.Console.WriteLine("PAGAMENTOS:");

foreach(Funcionario item in func)
{
    System.Console.WriteLine(item.Nome + "- $" + item.Pagamento().ToString("F2"), CultureInfo.InvariantCulture);
}  