using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LGroup.SisAmigos.Entities;

namespace LGroup.SisAmigos.DataAccess.Mapping
{
  public sealed class ClienteMapping : EntityTypeConfiguration<Cliente>
    {
        public ClienteMapping()
        {
            ToTable("TB_CLIENTE");
            HasKey(x => x.Codigo);

            Property(x => x.Codigo).HasColumnName("ID_CLIENTE")
                                   .HasColumnType("int")
                                   .IsRequired();

            Property(x => x.Nome).HasColumnName("NM_CLIENTE")
                                 .HasColumnType("varchar")
                                 .HasMaxLength(50)
                                 .IsRequired();

            Property(x => x.Email).HasColumnName("DS_EMAIL")
                                  .HasColumnType("varchar")
                                  .HasMaxLength(50)
                                  .IsRequired();

            Property(x => x.Telefone).HasColumnName("NR_TELEFONE")
                                     .HasColumnType("varchar")
                                     .HasMaxLength(15)
                                     .IsRequired();

            Property(x => x.DataNascimento).HasColumnName("DT_NASCIMENTO")
                                           .HasColumnType("date")
                                           .IsRequired();

            Property(x => x.CodigoSexo).HasColumnName("ID_SEXO")
                                       .HasColumnType("int")
                                       .IsRequired();    

        }
    }
}
