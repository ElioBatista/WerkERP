using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class AUDITORIAMOVIMIENTOMap : EntityTypeConfiguration<AUDITORIAMOVIMIENTO>
    {
        public AUDITORIAMOVIMIENTOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODIGO);

            // Properties
            this.Property(t => t.CODIGO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MOVIMIENTO)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.SUCURSAL)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.COMPROBANTE)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.NUMERO)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.MONEDA)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.COTIZACION1)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.COTIZACION2)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.FECHAMOVIMIENTO)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.FECHAPROCESO)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.OBSERVACION)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.IMPORTE)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.DETALLE)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.USUARIO)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.NIVEL)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("AUDITORIAMOVIMIENTOS");
            this.Property(t => t.CODIGO).HasColumnName("CODIGO");
            this.Property(t => t.EMPRESA).HasColumnName("EMPRESA");
            this.Property(t => t.MOVIMIENTO).HasColumnName("MOVIMIENTO");
            this.Property(t => t.SUCURSAL).HasColumnName("SUCURSAL");
            this.Property(t => t.COMPROBANTE).HasColumnName("COMPROBANTE");
            this.Property(t => t.NUMERO).HasColumnName("NUMERO");
            this.Property(t => t.MONEDA).HasColumnName("MONEDA");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.FECHAMOVIMIENTO).HasColumnName("FECHAMOVIMIENTO");
            this.Property(t => t.FECHAPROCESO).HasColumnName("FECHAPROCESO");
            this.Property(t => t.OBSERVACION).HasColumnName("OBSERVACION");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.DETALLE).HasColumnName("DETALLE");
            this.Property(t => t.FECHA).HasColumnName("FECHA");
            this.Property(t => t.USUARIO).HasColumnName("USUARIO");
            this.Property(t => t.NIVEL).HasColumnName("NIVEL");
            this.Property(t => t.INSERTAR).HasColumnName("INSERTAR");
            this.Property(t => t.MODIFICAR).HasColumnName("MODIFICAR");
            this.Property(t => t.ELIMINAR).HasColumnName("ELIMINAR");

            // Relationships
            this.HasRequired(t => t.EMPRESA1)
                .WithMany(t => t.AUDITORIAMOVIMIENTOS)
                .HasForeignKey(d => d.EMPRESA);

        }
    }
}
