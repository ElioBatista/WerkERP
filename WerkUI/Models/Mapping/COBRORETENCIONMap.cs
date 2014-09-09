using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class COBRORETENCIONMap : EntityTypeConfiguration<COBRORETENCION>
    {
        public COBRORETENCIONMap()
        {
            // Primary Key
            this.HasKey(t => t.CODCOMPRARETEN);

            // Properties
            this.Property(t => t.CODCOMPRARETEN)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CONCEPTO)
                .IsFixedLength()
                .HasMaxLength(60);

            this.Property(t => t.RESPONSABLE)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.RUCCI)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.NUMCOMPRARETEN)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("COBRORETENCION");
            this.Property(t => t.CODCOMPRARETEN).HasColumnName("CODCOMPRARETEN");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.FECHA).HasColumnName("FECHA");
            this.Property(t => t.CONCEPTO).HasColumnName("CONCEPTO");
            this.Property(t => t.VALORRENTA).HasColumnName("VALORRENTA");
            this.Property(t => t.VALORRENTA2).HasColumnName("VALORRENTA2");
            this.Property(t => t.VALORIVA).HasColumnName("VALORIVA");
            this.Property(t => t.MONTO).HasColumnName("MONTO");
            this.Property(t => t.BASE).HasColumnName("BASE");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.RESPONSABLE).HasColumnName("RESPONSABLE");
            this.Property(t => t.RUCCI).HasColumnName("RUCCI");
            this.Property(t => t.NUMCOMPRARETEN).HasColumnName("NUMCOMPRARETEN");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODCLIENTE).HasColumnName("CODCLIENTE");

            // Relationships
            this.HasOptional(t => t.CLIENTE)
                .WithMany(t => t.COBRORETENCIONs)
                .HasForeignKey(d => d.CODCLIENTE);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.COBRORETENCIONs)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.COBRORETENCIONs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
