namespace Cadastro_Fichas.Domain.Entities
{
    public class Jogador : Base
    {
        public int JogadorId { get; set; }
        public string NomeJogador { get;set; }
        public string Ambicao { get; set; }
        public string Alinhamento{ get; set; }
        public int Gold { get; set; }
        public string Origen { get; set; }
        public int Level { get; set; }




    }
}
