using bytebank.Titular;

namespace bytebank
{
    public class ContaCorrente
    {
        private Cliente _titular;
        public Cliente Titular
        {
            get { return _titular; }
            set
            {
                if (_titular != value)
                {

                }
                else { _titular = value; }
            }
        }
        private string _conta;
        public string Conta
        {
            get
            {
                return _conta;
            }
            set
            {
                if (value==null)
                {

                }
                else
                {
                    _conta = value;
                }
            }
        }

        private int _numero_agencia;
        public int Numero_agencia
        {
            get
            {
                return _numero_agencia;
            }
            set
            {
                if (value <= 0)
                {
                    
                }
                else
                {
                    _numero_agencia = value;
                }
            }
        }

        private string _nome_agencia;
        public string Nome_Agencia
        {
            get
            {
                return _nome_agencia;
            }
            set
            {
                if (value==null)
                {

                }
                else
                {
                    _nome_agencia = value;
                }
            }
        }

        private double saldo;
        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    saldo = value;
                }
            }
        }

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

        public ContaCorrente(Cliente titular, string nome_agencia, int numero_agencia, string conta)
        {
            Titular = titular;
            Nome_Agencia = nome_agencia;
            Numero_agencia = numero_agencia;
            Conta = conta;
            TotalDeContasCriadas++;
        }

        public static int TotalDeContasCriadas { get; set; }

    }
}