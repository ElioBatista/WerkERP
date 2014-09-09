using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class EMPRESAMap : EntityTypeConfiguration<EMPRESA>
    {
        public EMPRESAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODEMPRESA);

            // Properties
            this.Property(t => t.CODEMPRESA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NOMFANTASIA)
                .IsFixedLength()
                .HasMaxLength(80);

            this.Property(t => t.NOMCONTRIBUYENTE)
                .IsFixedLength()
                .HasMaxLength(80);

            this.Property(t => t.RUCCONTRIBUYENTE)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.DESEMPRESA)
                .IsFixedLength()
                .HasMaxLength(80);

            this.Property(t => t.DIRECCION)
                .IsFixedLength()
                .HasMaxLength(80);

            this.Property(t => t.TELEFONO)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.EMAIL)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.NUMREGPATRONAL)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.NOMREPRESENTANTE)
                .IsFixedLength()
                .HasMaxLength(80);

            this.Property(t => t.RUCREPRESENTANTE)
                .IsFixedLength()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("EMPRESA");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.USUGRA).HasColumnName("USUGRA");
            this.Property(t => t.NOMFANTASIA).HasColumnName("NOMFANTASIA");
            this.Property(t => t.NOMCONTRIBUYENTE).HasColumnName("NOMCONTRIBUYENTE");
            this.Property(t => t.RUCCONTRIBUYENTE).HasColumnName("RUCCONTRIBUYENTE");
            this.Property(t => t.DESEMPRESA).HasColumnName("DESEMPRESA");
            this.Property(t => t.DIRECCION).HasColumnName("DIRECCION");
            this.Property(t => t.TELEFONO).HasColumnName("TELEFONO");
            this.Property(t => t.EMAIL).HasColumnName("EMAIL");
            this.Property(t => t.NUMREGPATRONAL).HasColumnName("NUMREGPATRONAL");
            this.Property(t => t.RETENTOR).HasColumnName("RETENTOR");
            this.Property(t => t.NOMREPRESENTANTE).HasColumnName("NOMREPRESENTANTE");
            this.Property(t => t.RUCREPRESENTANTE).HasColumnName("RUCREPRESENTANTE");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
        }
    }
}
