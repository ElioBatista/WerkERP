using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class DESPACHOINTERNOMap : EntityTypeConfiguration<DESPACHOINTERNO>
    {
        public DESPACHOINTERNOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODDESPACHOINTERNO);

            // Properties
            this.Property(t => t.CODDESPACHOINTERNO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMDESPACHOINTERNO)
                .IsFixedLength()
                .HasMaxLength(9);

            this.Property(t => t.CONTENIDO)
                .IsFixedLength()
                .HasMaxLength(60);

            this.Property(t => t.FACTURACOMERCIAL)
                .IsFixedLength()
                .HasMaxLength(150);

            this.Property(t => t.TIPOFACTURACOMERCIAL)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.CONOCIMIENTO)
                .IsFixedLength()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DESPACHOINTERNO");
            this.Property(t => t.CODDESPACHOINTERNO).HasColumnName("CODDESPACHOINTERNO");
            this.Property(t => t.NUMDESPACHOINTERNO).HasColumnName("NUMDESPACHOINTERNO");
            this.Property(t => t.CODCONOCIMIENTO).HasColumnName("CODCONOCIMIENTO");
            this.Property(t => t.CODDESPACHANTE).HasColumnName("CODDESPACHANTE");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODCLIENTE).HasColumnName("CODCLIENTE");
            this.Property(t => t.CONTENIDO).HasColumnName("CONTENIDO");
            this.Property(t => t.FECHAINGRESO).HasColumnName("FECHAINGRESO");
            this.Property(t => t.CODTIPOMOVIMIENTO).HasColumnName("CODTIPOMOVIMIENTO");
            this.Property(t => t.FACTURACOMERCIAL).HasColumnName("FACTURACOMERCIAL");
            this.Property(t => t.TIPOFACTURACOMERCIAL).HasColumnName("TIPOFACTURACOMERCIAL");
            this.Property(t => t.TIPOCONOCIMIENTO).HasColumnName("TIPOCONOCIMIENTO");
            this.Property(t => t.DIACTIVO).HasColumnName("DIACTIVO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.CODDOCFACTCOMERCIAL).HasColumnName("CODDOCFACTCOMERCIAL");
            this.Property(t => t.NUMEROFACTURACOMERCIAL).HasColumnName("NUMEROFACTURACOMERCIAL");
            this.Property(t => t.CONOCIMIENTO).HasColumnName("CONOCIMIENTO");
            this.Property(t => t.CODTIPOCONOCIMIENTO).HasColumnName("CODTIPOCONOCIMIENTO");
        }
    }
}
