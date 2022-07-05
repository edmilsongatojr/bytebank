using bytebank;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================== Byte Bank =====================\n");
            Console.WriteLine("...Iniciando Aplicação...");
            Console.WriteLine("-----------------------------------------------------");

            try
            {
                ContaCorrente conta = new(52, 326659);
                ContaCorrente conta2 = new(325, 15311);
                conta.Depositar(50);
                Console.WriteLine("Consulta Saldo: " + conta.Saldo);
                Console.WriteLine("-----------------------------------------------------");

                conta.Sacar(10);
                Console.WriteLine("Consulta Saldo: " + conta.Saldo);
                Console.WriteLine("-----------------------------------------------------");

                conta.Transferir(500, conta2);
                Console.WriteLine("Consulta Saldo: " + conta.Saldo);
                Console.WriteLine("-----------------------------------------------------");


            }
            catch (ArgumentException ex)
            {

                Console.WriteLine("Ocorreu um erro do tipo ArgumentException!\n");
                Console.WriteLine("Erro no parâmetro: " + ex.ParamName);
               // Console.WriteLine(ex.StackTrace);
            }
            catch (OperacaoFinanceiraException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("\nInformações da INNER EXCEPTION (Exceção Interna)");
                Console.WriteLine(ex.InnerException.Message);
                Console.WriteLine(ex.InnerException.StackTrace);
            }
            
            //Console.WriteLine(ContaCorrente.TaxaOperacao);
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("...Finalizando Aplicação...\n");
            Console.WriteLine("===================== By Jimmy ======================");

            Console.ReadLine();
        }
    }
}
