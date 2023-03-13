namespace Pessoa.Imposto;

class PessoaFisica : Pessoa
{
    public double GastosSaude { get; set; }


    public PessoaFisica(string nome, double ganhoAno, double gastosSaude)
        :base (nome, ganhoAno)
    {
        GastosSaude = gastosSaude;
    }

    public override double Imposto()
    {
        if (GanhoAnual < 20000)
        {
            return GanhoAnual * 0.15;  
        }
        else
        {
            return (GanhoAnual * 0.25) - (GastosSaude * 0.5);
        }
    }

}