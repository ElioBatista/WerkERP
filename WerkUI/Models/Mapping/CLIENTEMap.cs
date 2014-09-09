using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CLIENTEMap : EntityTypeConfiguration<CLIENTE>
    {
        public CLIENTEMap()
        {
            // Primary Key
            this.HasKey(t => t.CODCLIENTE);

            // Properties
            this.Property(t => t.CODCLIENTE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMCLIENTE)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.NOMBRE)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.APELLIDO)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.NUMCEDULA)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.RUC)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.DIRECCION)
                .IsFixedLength()
                .HasMaxLength(80);

            this.Property(t => t.TELEFONO)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.CELULAR)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.FAX)
                .IsFixedLength()
                .HasMaxLength(25);

            this.Property(t => t.EMAIL)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.WEB)
                .IsFixedLength()
                .HasMaxLength(150);

            this.Property(t => t.OBSERVACION)
                .IsFixedLength()
                .HasMaxLength(200);

            this.Property(t => t.CONDICIONVENTA)
                .IsFixedLength()
                .HasMaxLength(100);

            this.Property(t => t.DIRENVIO)
                .IsFixedLength()
                .HasMaxLength(80);

            this.Property(t => t.CODIGOCOMISION)
                .HasMaxLength(50);

            this.Property(t => t.NUMEROTOL)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CLIENTES");
            this.Property(t => t.CODCLIENTE).HasColumnName("CODCLIENTE");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODPLANCUENTA).HasColumnName("CODPLANCUENTA");
            this.Property(t => t.CODZONA).HasColumnName("CODZONA");
            this.Property(t => t.CODCOBRADOR).HasColumnName("CODCOBRADOR");
            this.Property(t => t.CODVENDEDOR).HasColumnName("CODVENDEDOR");
            this.Property(t => t.CODTIPOCLIENTE).HasColumnName("CODTIPOCLIENTE");
            this.Property(t => t.NUMCLIENTE).HasColumnName("NUMCLIENTE");
            this.Property(t => t.NOMBRE).HasColumnName("NOMBRE");
            this.Property(t => t.APELLIDO).HasColumnName("APELLIDO");
            this.Property(t => t.NUMCEDULA).HasColumnName("NUMCEDULA");
            this.Property(t => t.RUC).HasColumnName("RUC");
            this.Property(t => t.DIRECCION).HasColumnName("DIRECCION");
            this.Property(t => t.TELEFONO).HasColumnName("TELEFONO");
            this.Property(t => t.CELULAR).HasColumnName("CELULAR");
            this.Property(t => t.FAX).HasColumnName("FAX");
            this.Property(t => t.EMAIL).HasColumnName("EMAIL");
            this.Property(t => t.WEB).HasColumnName("WEB");
            this.Property(t => t.LIMCREDITO).HasColumnName("LIMCREDITO");
            this.Property(t => t.FECHAINGRESO).HasColumnName("FECHAINGRESO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.PORCENTAJE).HasColumnName("PORCENTAJE");
            this.Property(t => t.OBSERVACION).HasColumnName("OBSERVACION");
            this.Property(t => t.DIASVENCIMIENTO).HasColumnName("DIASVENCIMIENTO");
            this.Property(t => t.CONDICIONVENTA).HasColumnName("CONDICIONVENTA");
            this.Property(t => t.DIRENVIO).HasColumnName("DIRENVIO");
            this.Property(t => t.CLIENTEEXENTO).HasColumnName("CLIENTEEXENTO");
            this.Property(t => t.CODIGOCOMISION).HasColumnName("CODIGOCOMISION");
            this.Property(t => t.NUMEROTOL).HasColumnName("NUMEROTOL");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.FECHANACIMIENTO).HasColumnName("FECHANACIMIENTO");
            this.Property(t => t.CODEJECUTIVOCTA).HasColumnName("CODEJECUTIVOCTA");
            this.Property(t => t.CODCIRCUITO).HasColumnName("CODCIRCUITO");
            this.Property(t => t.PORRETENCIONIVA).HasColumnName("PORRETENCIONIVA");
            this.Property(t => t.IVAGASTOS).HasColumnName("IVAGASTOS");
            this.Property(t => t.IVAHONORARIOS).HasColumnName("IVAHONORARIOS");
        }
    }
}
