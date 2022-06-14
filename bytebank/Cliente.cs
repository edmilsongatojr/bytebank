namespace bytebank.Titular
{
    public class Cliente
    {
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value == null)
                {

                }
                else
                {
                    _nome = value;
                }
            }
        }
        public string Cpf { get; set; }
        public string Profissao { get; set; }

    }
}
