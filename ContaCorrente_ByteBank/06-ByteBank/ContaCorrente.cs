using _06_ByteBank;

namespace _06_ByteBank
{
    public class ContaCorrente
    {
        private Cliente _titular;
        private int _agencia;
        private int _numero;
        private double _saldo = 100;

        public Cliente Titular {get; set;}
        public int Agencia { get; set; }
        public int Numero { get; set; }

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0) 
                {
                    return;
                }
                _saldo = value;
            }
        }

        
        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                return true;
            }
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
            else
            {
                _saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }

        


    }
}

