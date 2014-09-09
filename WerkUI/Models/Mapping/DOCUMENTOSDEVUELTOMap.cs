using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class DOCUMENTOSDEVUELTOMap : EntityTypeConfiguration<DOCUMENTOSDEVUELTO>
    {
        public DOCUMENTOSDEVUELTOMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODCOMPROBANTE, t.NUMEROPLANILLA, t.CODVENTA });

            // Properties
            this.Property(t => t.CODCOMPROBANTE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMEROPLANILLA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODVENTA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("DOCUMENTOSDEVUELTOS");
            this.Property(t => t.CODCOMPROBANTE).HasColumnName("CODCOMPROBANTE");
            this.Property(t => t.NUMEROPLANILLA).HasColumnName("NUMEROPLANILLA");
            this.Property(t => t.CODVENTA).HasColumnName("CODVENTA");
            this.Property(t => t.CODCOMPROBANTE_ENTREGA).HasColumnName("CODCOMPROBANTE_ENTREGA");
            this.Property(t => t.NUMEROPLANILLA_ENTREGA).HasColumnName("NUMEROPLANILLA_ENTREGA");
            this.Property(t => t.CODCOBRADOR).HasColumnName("CODCOBRADOR");
            this.Property(t => t.FECHAPLANILLA).HasColumnName("FECHAPLANILLA");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.COBRADOR)
                .WithMany(t => t.DOCUMENTOSDEVUELTOS)
                .HasForeignKey(d => d.CODCOBRADOR);
            this.HasRequired(t => t.TIPOCOMPROBANTE)
                .WithMany(t => t.DOCUMENTOSDEVUELTOS)
                .HasForeignKey(d => d.CODCOMPROBANTE);
            this.HasOptional(t => t.TIPOCOMPROBANTE1)
                .WithMany(t => t.DOCUMENTOSDEVUELTOS1)
                .HasForeignKey(d => d.CODCOMPROBANTE_ENTREGA);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.DOCUMENTOSDEVUELTOS)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });
            this.HasRequired(t => t.VENTA)
                .WithMany(t => t.DOCUMENTOSDEVUELTOS)
                .HasForeignKey(d => d.CODVENTA);

        }
    }
}
