using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class SUELDOSTIPOMOVEMPLEADOMap : EntityTypeConfiguration<SUELDOSTIPOMOVEMPLEADO>
    {
        public SUELDOSTIPOMOVEMPLEADOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODDETALLE);

            // Properties
            this.Property(t => t.CODDETALLE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("SUELDOSTIPOMOVEMPLEADO");
            this.Property(t => t.CODDETALLE).HasColumnName("CODDETALLE");
            this.Property(t => t.CODTIPOMOV).HasColumnName("CODTIPOMOV");
            this.Property(t => t.CODEMPLEADO).HasColumnName("CODEMPLEADO");
            this.Property(t => t.FECHAINICIO).HasColumnName("FECHAINICIO");
            this.Property(t => t.FECHAVENCIMIENTO).HasColumnName("FECHAVENCIMIENTO");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.CODIVA).HasColumnName("CODIVA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");

            // Relationships
            this.HasOptional(t => t.EMPLEADO)
                .WithMany(t => t.SUELDOSTIPOMOVEMPLEADOes)
                .HasForeignKey(d => d.CODEMPLEADO);
            this.HasOptional(t => t.IVA)
                .WithMany(t => t.SUELDOSTIPOMOVEMPLEADOes)
                .HasForeignKey(d => d.CODIVA);
            this.HasOptional(t => t.TIPOMOVIMIENTOSUELDO)
                .WithMany(t => t.SUELDOSTIPOMOVEMPLEADOes)
                .HasForeignKey(d => d.CODTIPOMOV);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.SUELDOSTIPOMOVEMPLEADOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
