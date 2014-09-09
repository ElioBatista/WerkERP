using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class DESPACHODETALLEMap : EntityTypeConfiguration<DESPACHODETALLE>
    {
        public DESPACHODETALLEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODDESPACHO, t.SECUENCIAINTERNA });

            // Properties
            this.Property(t => t.CODDESPACHO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SECUENCIAINTERNA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MARCA)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.NUMERO)
                .IsFixedLength()
                .HasMaxLength(15);

            this.Property(t => t.CANTIDADBULTO)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("DESPACHODETALLE");
            this.Property(t => t.CODDESPACHO).HasColumnName("CODDESPACHO");
            this.Property(t => t.SECUENCIAINTERNA).HasColumnName("SECUENCIAINTERNA");
            this.Property(t => t.MARCA).HasColumnName("MARCA");
            this.Property(t => t.NUMERO).HasColumnName("NUMERO");
            this.Property(t => t.CANTIDADBULTO).HasColumnName("CANTIDADBULTO");
            this.Property(t => t.VALMONEDAEXT).HasColumnName("VALMONEDAEXT");
            this.Property(t => t.FACTORCAMBIO).HasColumnName("FACTORCAMBIO");
            this.Property(t => t.VALORGUARANI).HasColumnName("VALORGUARANI");
            this.Property(t => t.VALORFOB).HasColumnName("VALORFOB");
            this.Property(t => t.VALORIMPONIBLE).HasColumnName("VALORIMPONIBLE");
            this.Property(t => t.CODBULTO).HasColumnName("CODBULTO");

            // Relationships
            this.HasOptional(t => t.BULTO)
                .WithMany(t => t.DESPACHODETALLEs)
                .HasForeignKey(d => d.CODBULTO);
            this.HasRequired(t => t.DESPACHO)
                .WithMany(t => t.DESPACHODETALLEs)
                .HasForeignKey(d => d.CODDESPACHO);

        }
    }
}
