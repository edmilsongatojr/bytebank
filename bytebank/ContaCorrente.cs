// using _05_ByteBank;

using bytebank;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        public static double TaxaOperacao { get; private set; }
        public static int TotalDeContasCriadas { get; private set; }


        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            private set
            {
                if (value <= 0)
                {
                    return;
                }

                _agencia = value;
            }
        }
        public int Numero { get;}

        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            private set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }


        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            //TaxaOperacao = 30 / TotalDeContasCriadas;
            if (agencia <= 0)
            {
                throw new ArgumentException("O Argumento agencia deve ser maior que Zero!", nameof(agencia));
            }
            if (numero <= 0)
            {
                throw new ArgumentException("O Argumento numero deve ser maior que Zero!", nameof(numero));
            }
            TotalDeContasCriadas++;
        }


        public void  Sacar(double valor)
        {
            if (_saldo < valor)
            {
                throw new SaldoInsuficienteException("Saldo Insuficiente para o saque no valor de: R$" + valor);
            }

            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
