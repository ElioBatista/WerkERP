using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class HACIENDAMap : EntityTypeConfiguration<HACIENDA>
    {
        public HACIENDAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODHACIENDA);

            // Properties
            this.Property(t => t.CODHACIENDA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DESHACIENDA)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.RAZONSOCIAL)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.NOMBRES)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.REPRESENTANTE)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.CONTADOR)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.CONTADORRUC)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.FORMNUM)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.ORDENNUM)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.RUC)
                .IsFixedLength()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("HACIENDA");
            this.Property(t => t.CODHACIENDA).HasColumnName("CODHACIENDA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.DESHACIENDA).HasColumnName("DESHACIENDA");
            this.Property(t => t.RAZONSOCIAL).HasColumnName("RAZONSOCIAL");
            this.Property(t => t.NOMBRES).HasColumnName("NOMBRES");
            this.Property(t => t.REPRESENTANTE).HasColumnName("REPRESENTANTE");
            this.Property(t => t.CONTADOR).HasColumnName("CONTADOR");
            this.Property(t => t.CONTADORRUC).HasColumnName("CONTADORRUC");
            this.Property(t => t.FORMNUM).HasColumnName("FORMNUM");
            this.Property(t => t.ORDENNUM).HasColumnName("ORDENNUM");
            this.Property(t => t.RUC).HasColumnName("RUC");
            this.Property(t => t.DESDEI).HasColumnName("DESDEI");
            this.Property(t => t.DESDEII).HasColumnName("DESDEII");
            this.Property(t => t.HASTAI).HasColumnName("HASTAI");
            this.Property(t => t.HASTAII).HasColumnName("HASTAII");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasMany(t => t.VARPATRIMONIOs)
                .WithMany(t => t.HACIENDAs)
                .Map(m =>
                    {
                        m.ToTable("PATRIHACIENDA");
                        m.MapLeftKey("CODHACIENDA");
                        m.MapRightKey("CODVARPATRIMONIO");
                    });

            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.HACIENDAs)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.HACIENDAs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
