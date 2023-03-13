namespace Pessoa.Imposto;

class PessoaJuridica : Pessoa
{
    public int NumeroFuncionarios { get; set; }

    public PessoaJuridica(string nome, double ganhoAno, int funcionarios)
        :base(nome, ganhoAno)
    {
        NumeroFuncionarios = funcionarios;
    }

    public override double Imposto()
    {
        if(NumeroFuncionarios > 10)
            return GanhoAnual * 0.14;

        return GanhoAnual * 0.16;
    }
}