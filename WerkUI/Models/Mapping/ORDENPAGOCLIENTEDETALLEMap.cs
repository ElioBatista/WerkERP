using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ORDENPAGOCLIENTEDETALLEMap : EntityTypeConfiguration<ORDENPAGOCLIENTEDETALLE>
    {
        public ORDENPAGOCLIENTEDETALLEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODORDENPAGOCLIENTE, t.CODDESPACHOINTERNO, t.SECUENCIA });

            // Properties
            this.Property(t => t.CODORDENPAGOCLIENTE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODDESPACHOINTERNO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SECUENCIA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OBSERVACION)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("ORDENPAGOCLIENTEDETALLE");
            this.Property(t => t.CODORDENPAGOCLIENTE).HasColumnName("CODORDENPAGOCLIENTE");
            this.Property(t => t.CODDESPACHOINTERNO).HasColumnName("CODDESPACHOINTERNO");
            this.Property(t => t.SECUENCIA).HasColumnName("SECUENCIA");
            this.Property(t => t.CODTIPOPAGO).HasColumnName("CODTIPOPAGO");
            this.Property(t => t.CODDEBITO).HasColumnName("CODDEBITO");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.CODPROPOSITO).HasColumnName("CODPROPOSITO");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.NUMEROTALON).HasColumnName("NUMEROTALON");
            this.Property(t => t.FECHAPRESENTACION).HasColumnName("FECHAPRESENTACION");
            this.Property(t => t.FECHARETIRO).HasColumnName("FECHARETIRO");
            this.Property(t => t.IMPORTEACEPTADO).HasColumnName("IMPORTEACEPTADO");
            this.Property(t => t.CODVENTA).HasColumnName("CODVENTA");
            this.Property(t => t.OBSERVACION).HasColumnName("OBSERVACION");

            // Relationships
            this.HasOptional(t => t.DEBITO)
                .WithMany(t => t.ORDENPAGOCLIENTEDETALLEs)
                .HasForeignKey(d => d.CODDEBITO);
            this.HasOptional(t => t.DEBITO1)
                .WithMany(t => t.ORDENPAGOCLIENTEDETALLEs1)
                .HasForeignKey(d => d.CODDEBITO);
            this.HasRequired(t => t.DESPACHOINTERNO)
                .WithMany(t => t.ORDENPAGOCLIENTEDETALLEs)
                .HasForeignKey(d => d.CODDESPACHOINTERNO);
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.ORDENPAGOCLIENTEDETALLEs)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasRequired(t => t.ORDENPAGOCLIENTE)
                .WithMany(t => t.ORDENPAGOCLIENTEDETALLEs)
                .HasForeignKey(d => d.CODORDENPAGOCLIENTE);
            this.HasOptional(t => t.PROPOSITOCHEQUE)
                .WithMany(t => t.ORDENPAGOCLIENTEDETALLEs)
                .HasForeignKey(d => d.CODPROPOSITO);
            this.HasOptional(t => t.TIPOPAGO)
                .WithMany(t => t.ORDENPAGOCLIENTEDETALLEs)
                .HasForeignKey(d => d.CODTIPOPAGO);

        }
    }
}
