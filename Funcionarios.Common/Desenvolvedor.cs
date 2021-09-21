namespace Funcionarios.Common
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string cpf) : base(3000, cpf)
        {

        }
        public override void AumentarSalario()
        {
            Salario *= 1.45;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.20;
        }
        
    }
}