namespace Heranca3;

using System.Globalization;
using Pessoa.Imposto;
class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Entre com o numero de pessoas para pagamento de imposto: ");
        var n = int.Parse(Console.ReadLine());

        var lista = new List<Pessoa>();

        for(var i=1; i<=n; i++)
        {
            System.Console.WriteLine($"Dados #{i}");
            System.Console.Write("Pessoa fisica ou pessoa juridica? (F/J): ");
            var opcao = char.Parse(Console.ReadLine().ToUpper());
            System.Console.Write("Nome: ");
            var nome = Console.ReadLine();
            System.Console.Write("Ganho Anual ");
            var ganhoAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(opcao == 'F')
            {
                System.Console.Write("Quanto gastou com saúde? ");
                var saude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lista.Add(new PessoaFisica(nome, ganhoAnual, saude));
            }

            if(opcao == 'J')
            {
                System.Console.Write("Quantos funcionários na empresa? ");
                var funcionarios = int.Parse(Console.ReadLine());
                lista.Add(new PessoaJuridica(nome, ganhoAnual, funcionarios));
            }
        }
        System.Console.WriteLine("IMPOSTOS PAGOS:");
        
        foreach (var item in lista)
        {
            System.Console.WriteLine(item.Nome +": R$"+item.Imposto().ToString("F2", CultureInfo.InvariantCulture));

        }       
        
        double total = 0.0;
        foreach(var item in lista)
        {
            total += item.Imposto();
        }
        System.Console.WriteLine("TOTAL DE IMPOSTO: R$"+total.ToString("F2", CultureInfo.InvariantCulture));

    }
}
