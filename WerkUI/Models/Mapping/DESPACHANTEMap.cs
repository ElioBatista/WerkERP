using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class DESPACHANTEMap : EntityTypeConfiguration<DESPACHANTE>
    {
        public DESPACHANTEMap()
        {
            // Primary Key
            this.HasKey(t => t.CODDESPACHANTE);

            // Properties
            this.Property(t => t.CODDESPACHANTE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMDESPACHANTE)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.NOMBRE)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.APELLIDO)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.RUC)
                .IsFixedLength()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("DESPACHANTE");
            this.Property(t => t.CODDESPACHANTE).HasColumnName("CODDESPACHANTE");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMDESPACHANTE).HasColumnName("NUMDESPACHANTE");
            this.Property(t => t.NOMBRE).HasColumnName("NOMBRE");
            this.Property(t => t.APELLIDO).HasColumnName("APELLIDO");
            this.Property(t => t.RUC).HasColumnName("RUC");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
        }
    }
}
