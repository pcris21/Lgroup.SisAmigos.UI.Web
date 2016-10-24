using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LGroup.SisAmigos.Entities;
using System.Data.Entity.ModelConfiguration;

namespace LGroup.SisAmigos.DataAccess.Mapping
{
   public sealed class SexoMapping : EntityTypeConfiguration<Sexo> // classe do entity responsavel pelo mapeamento
    {
        //Esta forma de mapear se chama CODE FIRST com FLUENT API
        public SexoMapping()
        {
            ToTable("TB_SEXO");
            HasKey(x => x.Codigo);
            Property(x => x.Codigo).HasColumnName("ID_SEXO")
                                   .HasColumnType("int")
                                   .IsRequired();
            Property(x => x.Descricao).HasColumnName("DS_SEXO")
                                      .HasColumnType("varchar")
                                      .HasMaxLength(9)
                                      .IsRequired();
        }
    }
}
