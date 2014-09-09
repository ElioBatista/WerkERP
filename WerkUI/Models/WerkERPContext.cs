using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using WerkUI.Models.Mapping;

namespace WerkUI.Models
{
    public class WerkERPContext : DbContext
    {
        static WerkERPContext()
        {
            Database.SetInitializer<WerkERPContext>(null);
        }

		public WerkERPContext()
			: base("Name=WerkERPContext")
		{
		}

        public DbSet<ConfiguracionRegional> ConfiguracionRegionals { get; set; }
        public DbSet<Idioma> Idiomas { get; set; }
        public DbSet<Moneda> Monedas { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Parametro> Parametros { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<ConceptosMarcado> ConceptosMarcados { get; set; }
        public DbSet<FacturaDetalle> FacturaDetalles { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<TipoFactura> TipoFacturas { get; set; }
        public DbSet<LiquidacionDetalle> LiquidacionDetalles { get; set; }
        public DbSet<Liquidacione> Liquidaciones { get; set; }
        public DbSet<ParametrosBusqueda> ParametrosBusquedas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<CLIENTE> CLIENTES { get; set; }
        public DbSet<CONCEPTOSLIQUIDACION> CONCEPTOSLIQUIDACIONs { get; set; }
        public DbSet<DESPACHANTE> DESPACHANTEs { get; set; }
        public DbSet<DESPACHO> DESPACHOes { get; set; }
        public DbSet<DESPACHOINTERNO> DESPACHOINTERNOes { get; set; }
        public DbSet<EMPRESA> EMPRESAs { get; set; }
        public DbSet<LIQUIDACION> LIQUIDACIONs { get; set; }
        public DbSet<LIQUIDACIONCABECERA> LIQUIDACIONCABECERAs { get; set; }
        public DbSet<TIPOCLIENTE> TIPOCLIENTEs { get; set; }
        public DbSet<USUARIO1> USUARIOs1 { get; set; }
        public DbSet<V_LIQUIDACIONES> V_LIQUIDACIONES { get; set; }
        public DbSet<VENDEDOR> VENDEDORs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ConfiguracionRegionalMap());
            modelBuilder.Configurations.Add(new IdiomaMap());
            modelBuilder.Configurations.Add(new MonedaMap());
            modelBuilder.Configurations.Add(new PaisMap());
            modelBuilder.Configurations.Add(new ParametroMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new ConceptosMarcadoMap());
            modelBuilder.Configurations.Add(new FacturaDetalleMap());
            modelBuilder.Configurations.Add(new FacturaMap());
            modelBuilder.Configurations.Add(new TipoFacturaMap());
            modelBuilder.Configurations.Add(new LiquidacionDetalleMap());
            modelBuilder.Configurations.Add(new LiquidacioneMap());
            modelBuilder.Configurations.Add(new ParametrosBusquedaMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new CLIENTEMap());
            modelBuilder.Configurations.Add(new CONCEPTOSLIQUIDACIONMap());
            modelBuilder.Configurations.Add(new DESPACHANTEMap());
            modelBuilder.Configurations.Add(new DESPACHOMap());
            modelBuilder.Configurations.Add(new DESPACHOINTERNOMap());
            modelBuilder.Configurations.Add(new EMPRESAMap());
            modelBuilder.Configurations.Add(new LIQUIDACIONMap());
            modelBuilder.Configurations.Add(new LIQUIDACIONCABECERAMap());
            modelBuilder.Configurations.Add(new TIPOCLIENTEMap());
            modelBuilder.Configurations.Add(new USUARIO1Map());
            modelBuilder.Configurations.Add(new V_LIQUIDACIONESMap());
            modelBuilder.Configurations.Add(new VENDEDORMap());
        }
    }
}
