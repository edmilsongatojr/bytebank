namespace bytebank
{
    public class ContaCorrente
    {
       
        public string conta;
        public int numero_agencia;
        public string nome_agencia;
        public double saldo;

        public bool Sacar(double valor)
        {
            if (saldo < valor || valor < 0)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                return true;
            }
        }

        public bool Depositar(double valor)
        {
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo += valor;
                return true;
            }
        }

        public bool Transferir(double valor, ContaCorrente xDestino)
        {
            if (saldo < valor || valor < 0)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                xDestino.saldo += valor;
                return true;
            }
        }
    }
}