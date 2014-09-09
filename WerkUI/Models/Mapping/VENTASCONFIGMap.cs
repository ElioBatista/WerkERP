using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class VENTASCONFIGMap : EntityTypeConfiguration<VENTASCONFIG>
    {
        public VENTASCONFIGMap()
        {
            // Primary Key
            this.HasKey(t => t.CODCONFIG);

            // Properties
            this.Property(t => t.CODCONFIG)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VENTASCONFIG");
            this.Property(t => t.CODCONFIG).HasColumnName("CODCONFIG");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.VENCIMIENTOFACTURA).HasColumnName("VENCIMIENTOFACTURA");
            this.Property(t => t.PORCIENTODESCUENTO).HasColumnName("PORCIENTODESCUENTO");
            this.Property(t => t.CONTROLLIMITE).HasColumnName("CONTROLLIMITE");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.MODIFICAPRECIO).HasColumnName("MODIFICAPRECIO");
            this.Property(t => t.STOCKNEGATIVO).HasColumnName("STOCKNEGATIVO");
            this.Property(t => t.SIMCARD).HasColumnName("SIMCARD");
            this.Property(t => t.TARJETAS).HasColumnName("TARJETAS");
            this.Property(t => t.ESN).HasColumnName("ESN");
            this.Property(t => t.CLIENTE).HasColumnName("CLIENTE");
            this.Property(t => t.CARGAEXPRES).HasColumnName("CARGAEXPRES");
            this.Property(t => t.MANOOBRA).HasColumnName("MANOOBRA");
            this.Property(t => t.RANGOCOMPROBANTE).HasColumnName("RANGOCOMPROBANTE");
            this.Property(t => t.RANGOTICKET).HasColumnName("RANGOTICKET");
            this.Property(t => t.PRODUCTODESCUENTO).HasColumnName("PRODUCTODESCUENTO");

            // Relationships
            this.HasOptional(t => t.CLIENTE1)
                .WithMany(t => t.VENTASCONFIGs)
                .HasForeignKey(d => d.CLIENTE);
            this.HasOptional(t => t.LINEA)
                .WithMany(t => t.VENTASCONFIGs)
                .HasForeignKey(d => d.SIMCARD);
            this.HasOptional(t => t.LINEA1)
                .WithMany(t => t.VENTASCONFIGs1)
                .HasForeignKey(d => d.TARJETAS);
            this.HasOptional(t => t.LINEA2)
                .WithMany(t => t.VENTASCONFIGs2)
                .HasForeignKey(d => d.ESN);
            this.HasOptional(t => t.PRODUCTO)
                .WithMany(t => t.VENTASCONFIGs)
                .HasForeignKey(d => d.PRODUCTODESCUENTO);

        }
    }
}
