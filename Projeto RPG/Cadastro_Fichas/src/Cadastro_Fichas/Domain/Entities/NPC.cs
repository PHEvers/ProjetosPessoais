namespace Cadastro_Fichas.Domain.Entities
{
    public class NPC : Base
    {
        public int NPCId { get; set; }
        public string Descricao { get; set; }
        public string Voz { get; set; }
        public string Cidade { get; set; }
        public string Missao { get; set; }
        public string Familia { get; set; }

    }
}
