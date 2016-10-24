using System;

namespace LGroup.SisAmigos.Entities
{
    public sealed class Cliente :Base.BaseEntities
    {

        public String Nome { get; set; }
        public String Email { get; set; }
        public String Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public int CodigoSexo { get; set; }
    }
}

