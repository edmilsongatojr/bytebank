namespace bytebank
{
    public class LetiorDeArquivo
    {

        public string Arquivo { get; }

        public LetiorDeArquivo(string arquivo)
        {
            Arquivo = arquivo;
            Console.WriteLine("Abrindo arquivo: " + arquivo);
        }

        public  string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha...");
            return "Linha do Arquivo";
        }

        public void Fechar()
        {
            Console.WriteLine("Fechado Arquivo.");
        }
    }
}
