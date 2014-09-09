using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class EMPLEADOMap : EntityTypeConfiguration<EMPLEADO>
    {
        public EMPLEADOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODEMPLEADO);

            // Properties
            this.Property(t => t.CODEMPLEADO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMEMPLEADO)
                .HasMaxLength(25);

            this.Property(t => t.NOMBRE)
                .HasMaxLength(40);

            this.Property(t => t.APELLIDO)
                .HasMaxLength(40);

            this.Property(t => t.DIRECCION)
                .HasMaxLength(80);

            this.Property(t => t.DOCUMENTOIDENTIDAD)
                .HasMaxLength(20);

            this.Property(t => t.NUMEROIPS)
                .HasMaxLength(25);

            this.Property(t => t.OBSERVACION)
                .HasMaxLength(150);

            this.Property(t => t.TELEFONO)
                .HasMaxLength(25);

            this.Property(t => t.CELULAR)
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("EMPLEADO");
            this.Property(t => t.CODEMPLEADO).HasColumnName("CODEMPLEADO");
            this.Property(t => t.CODCOBRADOR).HasColumnName("CODCOBRADOR");
            this.Property(t => t.CODLIQUIDACION).HasColumnName("CODLIQUIDACION");
            this.Property(t => t.CODCLIENTE).HasColumnName("CODCLIENTE");
            this.Property(t => t.CODVENDEDOR).HasColumnName("CODVENDEDOR");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODDEPARTAMENTO).HasColumnName("CODDEPARTAMENTO");
            this.Property(t => t.CODPROFESION).HasColumnName("CODPROFESION");
            this.Property(t => t.CODTIPOSALARIO).HasColumnName("CODTIPOSALARIO");
            this.Property(t => t.CODCATEGORIA).HasColumnName("CODCATEGORIA");
            this.Property(t => t.CODDIVISION).HasColumnName("CODDIVISION");
            this.Property(t => t.CODCARGO).HasColumnName("CODCARGO");
            this.Property(t => t.CODSEXO).HasColumnName("CODSEXO");
            this.Property(t => t.CODNACIONALIDAD).HasColumnName("CODNACIONALIDAD");
            this.Property(t => t.CODNIVEL).HasColumnName("CODNIVEL");
            this.Property(t => t.CODCIVIL).HasColumnName("CODCIVIL");
            this.Property(t => t.NUMEMPLEADO).HasColumnName("NUMEMPLEADO");
            this.Property(t => t.NOMBRE).HasColumnName("NOMBRE");
            this.Property(t => t.APELLIDO).HasColumnName("APELLIDO");
            this.Property(t => t.DIRECCION).HasColumnName("DIRECCION");
            this.Property(t => t.DOCUMENTOIDENTIDAD).HasColumnName("DOCUMENTOIDENTIDAD");
            this.Property(t => t.FECHANACIMIENTO).HasColumnName("FECHANACIMIENTO");
            this.Property(t => t.CANTIDADHIJOS).HasColumnName("CANTIDADHIJOS");
            this.Property(t => t.FECHAINGRESO).HasColumnName("FECHAINGRESO");
            this.Property(t => t.FECHAINGRESOIPS).HasColumnName("FECHAINGRESOIPS");
            this.Property(t => t.NUMEROIPS).HasColumnName("NUMEROIPS");
            this.Property(t => t.FECHASALIDA).HasColumnName("FECHASALIDA");
            this.Property(t => t.OBSERVACION).HasColumnName("OBSERVACION");
            this.Property(t => t.BONIFICACION).HasColumnName("BONIFICACION");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.TELEFONO).HasColumnName("TELEFONO");
            this.Property(t => t.CELULAR).HasColumnName("CELULAR");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.FOTO).HasColumnName("FOTO");

            // Relationships
            this.HasOptional(t => t.CARGO)
                .WithMany(t => t.EMPLEADOes)
                .HasForeignKey(d => d.CODCARGO);
            this.HasOptional(t => t.CATEGORIA)
                .WithMany(t => t.EMPLEADOes)
                .HasForeignKey(d => d.CODCATEGORIA);
            this.HasOptional(t => t.CLIENTE)
                .WithMany(t => t.EMPLEADOes)
                .HasForeignKey(d => d.CODCLIENTE);
            this.HasOptional(t => t.COBRADOR)
                .WithMany(t => t.EMPLEADOes)
                .HasForeignKey(d => d.CODCOBRADOR);
            this.HasOptional(t => t.DEPARTAMENTOEMPRESA)
                .WithMany(t => t.EMPLEADOes)
                .HasForeignKey(d => d.CODDEPARTAMENTO);
            this.HasOptional(t => t.DIVISIONEMPRESA)
                .WithMany(t => t.EMPLEADOes)
                .HasForeignKey(d => d.CODDIVISION);
            this.HasOptional(t => t.TIPOSALARIO)
                .WithMany(t => t.EMPLEADOes)
                .HasForeignKey(d => d.CODTIPOSALARIO);
            this.HasOptional(t => t.PROFESION)
                .WithMany(t => t.EMPLEADOes)
                .HasForeignKey(d => d.CODPROFESION);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.EMPLEADOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });
            this.HasOptional(t => t.ESTADOCIVIL)
                .WithMany(t => t.EMPLEADOes)
                .HasForeignKey(d => d.CODCIVIL);
            this.HasOptional(t => t.NIVELESTUDIO)
                .WithMany(t => t.EMPLEADOes)
                .HasForeignKey(d => d.CODNIVEL);
            this.HasOptional(t => t.VENDEDOR)
                .WithMany(t => t.EMPLEADOes)
                .HasForeignKey(d => d.CODVENDEDOR);
            this.HasOptional(t => t.TIPOLIQUIDACION)
                .WithMany(t => t.EMPLEADOes)
                .HasForeignKey(d => d.CODLIQUIDACION);
            this.HasOptional(t => t.NACIONALIDAD)
                .WithMany(t => t.EMPLEADOes)
                .HasForeignKey(d => d.CODNACIONALIDAD);
            this.HasOptional(t => t.SEXO)
                .WithMany(t => t.EMPLEADOes)
                .HasForeignKey(d => d.CODSEXO);

        }
    }
}
