using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CAJACIERREMap : EntityTypeConfiguration<CAJACIERRE>
    {
        public CAJACIERREMap()
        {
            // Primary Key
            this.HasKey(t => t.NUMCIERRE);

            // Properties
            this.Property(t => t.NUMCIERRE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("CAJACIERRE");
            this.Property(t => t.NUMCIERRE).HasColumnName("NUMCIERRE");
            this.Property(t => t.NUMCAJA).HasColumnName("NUMCAJA");
            this.Property(t => t.CODCOBRADOR).HasColumnName("CODCOBRADOR");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.FECAPERTURA).HasColumnName("FECAPERTURA");
            this.Property(t => t.FECCIERRE).HasColumnName("FECCIERRE");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.CAJA)
                .WithMany(t => t.CAJACIERREs)
                .HasForeignKey(d => d.NUMCAJA);
            this.HasOptional(t => t.COBRADOR)
                .WithMany(t => t.CAJACIERREs)
                .HasForeignKey(d => d.CODCOBRADOR);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.CAJACIERREs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
