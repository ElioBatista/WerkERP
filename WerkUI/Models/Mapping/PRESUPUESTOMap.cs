using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class PRESUPUESTOMap : EntityTypeConfiguration<PRESUPUESTO>
    {
        public PRESUPUESTOMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODPRESUPUESTO, t.CODANHO });

            // Properties
            this.Property(t => t.CODPRESUPUESTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODANHO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PRESUPUESTO");
            this.Property(t => t.CODPRESUPUESTO).HasColumnName("CODPRESUPUESTO");
            this.Property(t => t.CODANHO).HasColumnName("CODANHO");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.MES1).HasColumnName("MES1");
            this.Property(t => t.MES2).HasColumnName("MES2");
            this.Property(t => t.MES3).HasColumnName("MES3");
            this.Property(t => t.MES4).HasColumnName("MES4");
            this.Property(t => t.MES5).HasColumnName("MES5");
            this.Property(t => t.MES6).HasColumnName("MES6");
            this.Property(t => t.MES7).HasColumnName("MES7");
            this.Property(t => t.MES8).HasColumnName("MES8");
            this.Property(t => t.MES9).HasColumnName("MES9");
            this.Property(t => t.MES10).HasColumnName("MES10");
            this.Property(t => t.MES11).HasColumnName("MES11");
            this.Property(t => t.MES12).HasColumnName("MES12");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.PRESUPUESTOes)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.PRESUPUESTOes)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.PRESUPUESTOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
