using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class TIPOMOVIMIENTOMap : EntityTypeConfiguration<TIPOMOVIMIENTO>
    {
        public TIPOMOVIMIENTOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODTIPOMOVIMIENTO);

            // Properties
            this.Property(t => t.CODTIPOMOVIMIENTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMTIPOMOVIMIENTO)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESTIPOMOVIMIENTO)
                .IsFixedLength()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("TIPOMOVIMIENTO");
            this.Property(t => t.CODTIPOMOVIMIENTO).HasColumnName("CODTIPOMOVIMIENTO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMTIPOMOVIMIENTO).HasColumnName("NUMTIPOMOVIMIENTO");
            this.Property(t => t.DESTIPOMOVIMIENTO).HasColumnName("DESTIPOMOVIMIENTO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
        }
    }
}
