using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class TIPOGASTODETMap : EntityTypeConfiguration<TIPOGASTODET>
    {
        public TIPOGASTODETMap()
        {
            // Primary Key
            this.HasKey(t => t.CODTIPOGASTODET);

            // Properties
            this.Property(t => t.CODTIPOGASTODET)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMTIPOGASTODET)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.DESTIPOGASTODET)
                .IsFixedLength()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TIPOGASTODET");
            this.Property(t => t.CODTIPOGASTO).HasColumnName("CODTIPOGASTO");
            this.Property(t => t.CODTIPOGASTODET).HasColumnName("CODTIPOGASTODET");
            this.Property(t => t.NUMTIPOGASTODET).HasColumnName("NUMTIPOGASTODET");
            this.Property(t => t.PREDETERMINADO).HasColumnName("PREDETERMINADO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.DESTIPOGASTODET).HasColumnName("DESTIPOGASTODET");
            this.Property(t => t.CODPLANCUENTA).HasColumnName("CODPLANCUENTA");

            // Relationships
            this.HasOptional(t => t.PLANCUENTA)
                .WithMany(t => t.TIPOGASTODETs)
                .HasForeignKey(d => d.CODPLANCUENTA);
            this.HasRequired(t => t.TIPOGASTO)
                .WithMany(t => t.TIPOGASTODETs)
                .HasForeignKey(d => d.CODTIPOGASTO);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.TIPOGASTODETs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
