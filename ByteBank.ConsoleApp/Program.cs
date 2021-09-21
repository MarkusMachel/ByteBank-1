using System;
using Funcionarios.Common;
using Sistema.Sistema;


namespace ByteBank.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();
            //UsarSistema();
            Console.ReadLine();
        }

        private static void TestaInnerException()
        {
            try 
            {
                ContaCorrente conta = new ContaCorrente(10, 10);
                conta.Depositar(100);
                // Console.WriteLine(conta.Saldo);
                conta.Sacar(90);

                ContaCorrente conta2 = new ContaCorrente(21,56);
                conta2.Transferir(1000, conta);

                // Console.WriteLine(ContaCorrente.TaxaOperacao);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("erro capturado no parâmetro: " + ex.ParamName);
                Console.WriteLine(ex.Message);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (OperacaoFincanceiraException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();
            Diretor roberta = new Diretor(5000, "159.753.398-04");
            IAutenticavel lira = new Diretor(5555,"2345");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = ("123456");

            sistemaInterno.Logar(parceiro, "123456");

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");
        }
        
        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Funcionario roberta = new Diretor(5000, "159.753.398-04");
            roberta.Nome = "Roberta";

            Funcionario igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            Funcionario camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";

            Funcionario andre = new Desenvolvedor("656.646.214-85");
            andre.Nome = "André";


            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(andre);


            Console.WriteLine("Total de bonificações do mês " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
