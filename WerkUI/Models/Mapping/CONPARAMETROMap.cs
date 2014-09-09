using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CONPARAMETROMap : EntityTypeConfiguration<CONPARAMETRO>
    {
        public CONPARAMETROMap()
        {
            // Primary Key
            this.HasKey(t => t.CODCONPARAMETRO);

            // Properties
            this.Property(t => t.CODCONPARAMETRO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FIN)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.PERIODOMES)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.FORMULARIONRO)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.NROORDEN2)
                .IsFixedLength()
                .HasMaxLength(15);

            this.Property(t => t.NOMEMPRESA)
                .IsFixedLength()
                .HasMaxLength(80);

            this.Property(t => t.NOMCONTADOR)
                .IsFixedLength()
                .HasMaxLength(80);

            this.Property(t => t.RUCREPRESENTANTE)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.RUCCONTRIBUYENTE)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.RUCCONTADOR)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.INICIO)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("CONPARAMETRO");
            this.Property(t => t.CODCONPARAMETRO).HasColumnName("CODCONPARAMETRO");
            this.Property(t => t.CUENTAIVADEBE).HasColumnName("CUENTAIVADEBE");
            this.Property(t => t.CUENTAIVAHABER).HasColumnName("CUENTAIVAHABER");
            this.Property(t => t.CUENTACOMPRA).HasColumnName("CUENTACOMPRA");
            this.Property(t => t.CUENTAVENTA).HasColumnName("CUENTAVENTA");
            this.Property(t => t.CUENTARESULTADO).HasColumnName("CUENTARESULTADO");
            this.Property(t => t.FIN).HasColumnName("FIN");
            this.Property(t => t.PERIODOMES).HasColumnName("PERIODOMES");
            this.Property(t => t.CUENTAREVALUO).HasColumnName("CUENTAREVALUO");
            this.Property(t => t.CUENTADEPRECIACION).HasColumnName("CUENTADEPRECIACION");
            this.Property(t => t.CUENTADEPREACUMULADA).HasColumnName("CUENTADEPREACUMULADA");
            this.Property(t => t.CUENTATEMPORAL1).HasColumnName("CUENTATEMPORAL1");
            this.Property(t => t.CUENTATEMPORAL2).HasColumnName("CUENTATEMPORAL2");
            this.Property(t => t.CUENTATEMPORAL3).HasColumnName("CUENTATEMPORAL3");
            this.Property(t => t.CUENTATEMPORAL4).HasColumnName("CUENTATEMPORAL4");
            this.Property(t => t.FORMULARIONRO).HasColumnName("FORMULARIONRO");
            this.Property(t => t.NROORDEN2).HasColumnName("NROORDEN2");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODMODELO).HasColumnName("CODMODELO");
            this.Property(t => t.NOMEMPRESA).HasColumnName("NOMEMPRESA");
            this.Property(t => t.NOMCONTADOR).HasColumnName("NOMCONTADOR");
            this.Property(t => t.RUCREPRESENTANTE).HasColumnName("RUCREPRESENTANTE");
            this.Property(t => t.RUCCONTRIBUYENTE).HasColumnName("RUCCONTRIBUYENTE");
            this.Property(t => t.RUCCONTADOR).HasColumnName("RUCCONTADOR");
            this.Property(t => t.INICIO).HasColumnName("INICIO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.ULTIMOASIENTO).HasColumnName("ULTIMOASIENTO");
            this.Property(t => t.mes).HasColumnName("mes");
            this.Property(t => t.CUENTAVENTAEXENTA).HasColumnName("CUENTAVENTAEXENTA");
            this.Property(t => t.CUENTAVENTAGRAVADA).HasColumnName("CUENTAVENTAGRAVADA");

            // Relationships
            this.HasOptional(t => t.MODELO)
                .WithMany(t => t.CONPARAMETROes)
                .HasForeignKey(d => d.CODMODELO);
            this.HasOptional(t => t.PLANCUENTA)
                .WithMany(t => t.CONPARAMETROes)
                .HasForeignKey(d => d.CUENTADEPRECIACION);
            this.HasOptional(t => t.PLANCUENTA1)
                .WithMany(t => t.CONPARAMETROes1)
                .HasForeignKey(d => d.CUENTATEMPORAL1);
            this.HasOptional(t => t.PLANCUENTA2)
                .WithMany(t => t.CONPARAMETROes2)
                .HasForeignKey(d => d.CUENTATEMPORAL3);
            this.HasOptional(t => t.PLANCUENTA3)
                .WithMany(t => t.CONPARAMETROes3)
                .HasForeignKey(d => d.CUENTAREVALUO);
            this.HasOptional(t => t.PLANCUENTA4)
                .WithMany(t => t.CONPARAMETROes4)
                .HasForeignKey(d => d.CUENTAVENTAEXENTA);
            this.HasOptional(t => t.PLANCUENTA5)
                .WithMany(t => t.CONPARAMETROes5)
                .HasForeignKey(d => d.CUENTAVENTAGRAVADA);
            this.HasOptional(t => t.PLANCUENTA6)
                .WithMany(t => t.CONPARAMETROes6)
                .HasForeignKey(d => d.CUENTAIVADEBE);
            this.HasOptional(t => t.PLANCUENTA7)
                .WithMany(t => t.CONPARAMETROes7)
                .HasForeignKey(d => d.CUENTACOMPRA);
            this.HasOptional(t => t.PLANCUENTA8)
                .WithMany(t => t.CONPARAMETROes8)
                .HasForeignKey(d => d.CUENTAVENTA);
            this.HasOptional(t => t.PLANCUENTA9)
                .WithMany(t => t.CONPARAMETROes9)
                .HasForeignKey(d => d.CUENTAIVAHABER);
            this.HasOptional(t => t.PLANCUENTA10)
                .WithMany(t => t.CONPARAMETROes10)
                .HasForeignKey(d => d.CUENTATEMPORAL4);
            this.HasOptional(t => t.PLANCUENTA11)
                .WithMany(t => t.CONPARAMETROes11)
                .HasForeignKey(d => d.CUENTATEMPORAL2);
            this.HasOptional(t => t.PLANCUENTA12)
                .WithMany(t => t.CONPARAMETROes12)
                .HasForeignKey(d => d.CUENTADEPREACUMULADA);
            this.HasOptional(t => t.PLANCUENTA13)
                .WithMany(t => t.CONPARAMETROes13)
                .HasForeignKey(d => d.CUENTARESULTADO);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.CONPARAMETROes)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.CONPARAMETROes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
