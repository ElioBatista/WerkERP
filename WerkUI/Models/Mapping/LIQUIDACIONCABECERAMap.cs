using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class LIQUIDACIONCABECERAMap : EntityTypeConfiguration<LIQUIDACIONCABECERA>
    {
        public LIQUIDACIONCABECERAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODLIQUIDACION);

            // Properties
            this.Property(t => t.CODLIQUIDACION)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("LIQUIDACIONCABECERA");
            this.Property(t => t.CODLIQUIDACION).HasColumnName("CODLIQUIDACION");
            this.Property(t => t.CODDESPACHO).HasColumnName("CODDESPACHO");
            this.Property(t => t.CODDESPACHOINTERNO).HasColumnName("CODDESPACHOINTERNO");
            this.Property(t => t.NUMLIQUIDACION).HasColumnName("NUMLIQUIDACION");
            this.Property(t => t.FECHALIQUIDACION).HasColumnName("FECHALIQUIDACION");
            this.Property(t => t.IMPORTETOTAL).HasColumnName("IMPORTETOTAL");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.ESTADO).HasColumnName("ESTADO");
            this.Property(t => t.FECHACIERRE).HasColumnName("FECHACIERRE");
            this.Property(t => t.IMPORTEIVAGASTOS).HasColumnName("IMPORTEIVAGASTOS");
            this.Property(t => t.IMPORTEIVAHONORARIOS).HasColumnName("IMPORTEIVAHONORARIOS");
            this.Property(t => t.PORRETENCIONIVA).HasColumnName("PORRETENCIONIVA");
            this.Property(t => t.RETIVAGASTOS).HasColumnName("RETIVAGASTOS");
            this.Property(t => t.RETIVAHONORARIOS).HasColumnName("RETIVAHONORARIOS");
        }
    }
}
