using System.Reflection.Metadata.Ecma335;

namespace Cadastro_Fichas.Domain.Entities
{
    public class Base
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Raça { get; set; }
        public string? Classe { get; set; }
        public int PontoVida{ get; set; }
        public int Iniciativa { get; set; }
        public int ClasseArmadura { get; set; }
        public string Condição { get; set; }

        #region Status base
        public int For { get; set; }
        public int Des { get; set; }
        public int Con { get; set; }
        public int Int { get; set; }
        public int Sab { get; set; }
        public int Car { get; set; }
        #endregion
    }
}
