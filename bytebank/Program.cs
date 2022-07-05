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
                ContaCorrente conta = new(0, 326659);
                conta.Depositar(50);
                Console.WriteLine("Consulta Saldo: " + conta.Saldo);
                Console.WriteLine("-----------------------------------------------------");

                conta.Sacar(500);
                Console.WriteLine("Consulta Saldo: " + conta.Saldo);
                Console.WriteLine("-----------------------------------------------------");

            }
            catch (ArgumentException ex)
            {

                Console.WriteLine("Ocorreu um erro do tipo ArgumentException!\n");
                Console.WriteLine("Erro no parâmetro: " + ex.ParamName);
                Console.WriteLine(ex.StackTrace);
            }
            catch (SaldoInsuficienteException ex)
            {
              
                Console.WriteLine("Exceção do tipo SaldoInsuficienteException: " + ex.Message);
            }
            
            //Console.WriteLine(ContaCorrente.TaxaOperacao);
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("...Finalizando Aplicação...\n");
            Console.WriteLine("===================== By Jimmy ======================");

            Console.ReadLine();
        }
    }
}
