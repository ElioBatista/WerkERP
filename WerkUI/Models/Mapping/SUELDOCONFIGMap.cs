using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class SUELDOCONFIGMap : EntityTypeConfiguration<SUELDOCONFIG>
    {
        public SUELDOCONFIGMap()
        {
            // Primary Key
            this.HasKey(t => t.CODCONFIG);

            // Properties
            this.Property(t => t.CODCONFIG)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("SUELDOCONFIG");
            this.Property(t => t.CODCONFIG).HasColumnName("CODCONFIG");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.HORASLABORALES).HasColumnName("HORASLABORALES");
            this.Property(t => t.DIASLABORALES).HasColumnName("DIASLABORALES");
            this.Property(t => t.MOVI1).HasColumnName("MOVI1");
            this.Property(t => t.MOVI2).HasColumnName("MOVI2");
            this.Property(t => t.MOVI3).HasColumnName("MOVI3");
            this.Property(t => t.MOVI4).HasColumnName("MOVI4");
            this.Property(t => t.MOVI5).HasColumnName("MOVI5");
            this.Property(t => t.MOVI6).HasColumnName("MOVI6");
            this.Property(t => t.MOVI7).HasColumnName("MOVI7");
            this.Property(t => t.MOVI8).HasColumnName("MOVI8");
            this.Property(t => t.MOVI9).HasColumnName("MOVI9");
            this.Property(t => t.MOVI10).HasColumnName("MOVI10");
            this.Property(t => t.MOVI11).HasColumnName("MOVI11");
            this.Property(t => t.MOVI12).HasColumnName("MOVI12");
            this.Property(t => t.MOVI13).HasColumnName("MOVI13");
            this.Property(t => t.MOVI14).HasColumnName("MOVI14");
            this.Property(t => t.MOVI15).HasColumnName("MOVI15");
            this.Property(t => t.MOVI16).HasColumnName("MOVI16");
            this.Property(t => t.MOVI17).HasColumnName("MOVI17");
            this.Property(t => t.MOVI18).HasColumnName("MOVI18");
            this.Property(t => t.MOVI19).HasColumnName("MOVI19");
            this.Property(t => t.MOVI20).HasColumnName("MOVI20");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
        }
    }
}
