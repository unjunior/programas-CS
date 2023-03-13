namespace Pessoa.Imposto;
using Heranca3;
abstract class Pessoa
{
    public string Nome { get; set; }
    public double GanhoAnual { get; set; }

    public Pessoa(string nome, double ganhoAno)
    {
        Nome = nome;
        GanhoAnual = ganhoAno;
    }

    abstract public double Imposto();

}