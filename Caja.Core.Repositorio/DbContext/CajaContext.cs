using Caja.Core.Entidades;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Caja.Core.Repositorio
{
    public partial class CajaContext : DbContext
    {
        public CajaContext()
        {
        }

        public CajaContext(DbContextOptions<CajaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Activacionesno> Activacionesno { get; set; }
        public virtual DbSet<Auditoria> Auditoria { get; set; }
        public virtual DbSet<Auditoriahistoria> Auditoriahistoria { get; set; }
        public virtual DbSet<Auditoriaimpresion> Auditoriaimpresion { get; set; }
        public virtual DbSet<Ciudades> Ciudades { get; set; }
        public virtual DbSet<Cartones> Cartones { get; set; }
        public virtual DbSet<CartonJuego> CartonJuego { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<ClienteModulo> Clientesmodulos { get; set; }
        public virtual DbSet<Conceptogastos> Conceptogastos { get; set; }
        public virtual DbSet<Conceptoingresos> Conceptoingresos { get; set; }
        public virtual DbSet<Configuracion> Configuracion { get; set; }
        public virtual DbSet<Configuracionreportepdf> Configuracionreportepdf { get; set; }
        public virtual DbSet<Definicionmonedas> Definicionmonedas { get; set; }
        public virtual DbSet<Directoriobalotasvirtuales> Directoriobalotasvirtuales { get; set; }
        public virtual DbSet<Empresas> Empresas { get; set; }
        public virtual DbSet<Estadobalotasuerte> Estadobalotasuerte { get; set; }
        public virtual DbSet<Estadoconsultacartones> Estadoconsultacartones { get; set; }
        public virtual DbSet<Estadorondafigura> Estadorondafigura { get; set; }
        public virtual DbSet<Figurasacumuladas> Figurasacumuladas { get; set; }
        public virtual DbSet<Flujocaja> Flujocaja { get; set; }
        public virtual DbSet<Gastosgenerales> Gastosgenerales { get; set; }
        public virtual DbSet<Gastosprogramacionjuegos> Gastosprogramacionjuegos { get; set; }
        public virtual DbSet<Historicoflujocaja> Historicoflujocaja { get; set; }
        public virtual DbSet<Ingresosgenerales> Ingresosgenerales { get; set; }
        public virtual DbSet<Ingresosprogramacionjuegos> Ingresosprogramacionjuegos { get; set; }
        public virtual DbSet<Juegos> Juegos { get; set; }
        public virtual DbSet<Juegosbalotasfinales> Juegosbalotasfinales { get; set; }
        public virtual DbSet<Juegosbalotasuerte> Juegosbalotasuerte { get; set; }
        public virtual DbSet<Listablas> Listablas { get; set; }
        public virtual DbSet<Menus> Menus { get; set; }
        public virtual DbSet<Modopagobalota> Modopagobalota { get; set; }
        public virtual DbSet<Modulos> Modulos { get; set; }
        public virtual DbSet<Nominadescuentos> Nominadescuentos { get; set; }
        public virtual DbSet<Numerosmemorama> Numerosmemorama { get; set; }
        public virtual DbSet<Paises> Paises { get; set; }
        public virtual DbSet<Palabrasahorcado> Palabrasahorcado { get; set; }
        public virtual DbSet<Parametrosgenerales> Parametrosgenerales { get; set; }
        public virtual DbSet<Perfiles> Perfiles { get; set; }
        public virtual DbSet<Perfilesusuario> Perfilesusuario { get; set; }
        public virtual DbSet<Perfilpermisos> Perfilpermisos { get; set; }
        public virtual DbSet<Plenoautomatico> Plenoautomatico { get; set; }
        public virtual DbSet<Porcentajepremios> Porcentajepremios { get; set; }
        public virtual DbSet<Programaciondevolucioncodigobarras> Programaciondevolucioncodigobarras { get; set; }
        public virtual DbSet<Programacionjuegos> Programacionjuegos { get; set; }
        public virtual DbSet<Programacionjuegosdineros> Programacionjuegosdineros { get; set; }
        public virtual DbSet<Programacionjuegosfiguras> Programacionjuegosfiguras { get; set; }
        public virtual DbSet<Programacionjuegoshojasdevueltas> Programacionjuegoshojasdevueltas { get; set; }
        public virtual DbSet<Recaudodetalles> Recaudodetalles { get; set; }
        public virtual DbSet<Recaudofaltantes> Recaudofaltantes { get; set; }
        public virtual DbSet<Recaudototales> Recaudototales { get; set; }
        public virtual DbSet<Rondas> Rondas { get; set; }
        public virtual DbSet<Rondascartonesregistrados> Rondascartonesregistrados { get; set; }
        public virtual DbSet<Rondasfiguras> Rondasfiguras { get; set; }
        public virtual DbSet<Rondashistoriaconsulta> Rondashistoriaconsulta { get; set; }
        public virtual DbSet<Rondashistoriafinal> Rondashistoriafinal { get; set; }
        public virtual DbSet<Rondashistorialmovimientos> Rondashistorialmovimientos { get; set; }
        public virtual DbSet<Rondasseries> Rondasseries { get; set; }
        public virtual DbSet<Sencillo> Sencillo { get; set; }
        public virtual DbSet<Seriecuartorombos100000> Seriecuartorombos100000 { get; set; }
        public virtual DbSet<Serieimprimir> Serieimprimir { get; set; }
        public virtual DbSet<Serieimprimirlinea> Serieimprimirlinea { get; set; }
        public virtual DbSet<Serieprimerarombos20000> Serieprimerarombos20000 { get; set; }
        public virtual DbSet<Seriequintarombos30000> Seriequintarombos30000 { get; set; }
        public virtual DbSet<Seriesegundarombos20000> Seriesegundarombos20000 { get; set; }
        public virtual DbSet<Serietelebingo100000> Serietelebingo100000 { get; set; }
        public virtual DbSet<Serietelebingo120000> Serietelebingo120000 { get; set; }
        public virtual DbSet<Serietercerarombos50000> Serietercerarombos50000 { get; set; }
        public virtual DbSet<SolicitudesVendedores> SolicitudesVendedores { get; set; }
        public virtual DbSet<Tiposrelacion> Tiposrelacion { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Vconsultalistadocartonesdevueltos> Vconsultalistadocartonesdevueltos { get; set; }
        public virtual DbSet<Vendedores> Vendedores { get; set; }
        public virtual DbSet<Vendedorescobrocartones> Vendedorescobrocartones { get; set; }
        public virtual DbSet<Vendedorescuentascobrar> Vendedorescuentascobrar { get; set; }
        public virtual DbSet<Vendedoreshojas> Vendedoreshojas { get; set; }
        public virtual DbSet<Vendedoresmodulos> Vendedoresmodulos { get; set; }
        public virtual DbSet<Vendedorespagoanticipados> Vendedorespagoanticipados { get; set; }
        public virtual DbSet<Vendedoresreferencias> Vendedoresreferencias { get; set; }
        public virtual DbSet<Vendedoresresumen> Vendedoresresumen { get; set; }
        public virtual DbSet<Vgastosgenerales> Vgastosgenerales { get; set; }
        public virtual DbSet<Vgastosprogramacionjuego> Vgastosprogramacionjuego { get; set; }
        public virtual DbSet<Vingresosgenerales> Vingresosgenerales { get; set; }
        public virtual DbSet<Vingresosprogramacionjuego> Vingresosprogramacionjuego { get; set; }
        public virtual DbSet<Vperfilpermisos> Vperfilpermisos { get; set; }
        public virtual DbSet<Vprogramacionjuegovendedores> Vprogramacionjuegovendedores { get; set; }
        public virtual DbSet<Vrondasseries> Vrondasseries { get; set; }
        public virtual DbSet<Vvendedoresentregacartones> Vvendedoresentregacartones { get; set; }
        public virtual DbSet<Vvendedoresprogramacion> Vvendedoresprogramacion { get; set; }
        //public virtual DbSet<FiguraPA> FiguraPlenoAutomatico { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activacionesno>(entity =>
            {
                entity.HasKey(e => e.IdActivacion)
                    .HasName("PRIMARY");

                entity.ToTable("activacionesno");

                entity.HasIndex(e => e.IdEmpresa, "FK_activacion_IdEmpresa");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.Activacionesno)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_activacion_IdEmpresa");
            });

            modelBuilder.Entity<Auditoria>(entity =>
            {
                entity.HasKey(e => e.IdAuditoria)
                    .HasName("PRIMARY");

                entity.ToTable("auditoria");

                entity.Property(e => e.Accion)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.RegistroAnterior).IsRequired();

                entity.Property(e => e.RegistroNuevo).IsRequired();

                entity.Property(e => e.Tabla)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Auditoriahistoria>(entity =>
            {
                entity.HasKey(e => e.IdAuditoriaHistoria)
                    .HasName("PRIMARY");

                entity.ToTable("auditoriahistoria");

                entity.Property(e => e.Estado)
                    .HasMaxLength(1)
                    .IsFixedLength(true);

                entity.Property(e => e.ValorAnterior)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ValorNuevo)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Auditoriaimpresion>(entity =>
            {
                entity.ToTable("auditoriaimpresion");

                entity.Property(e => e.CodigoBarras).HasColumnType("bit(1)");

                entity.Property(e => e.Linea1)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Linea2)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Linea3)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<Cartones>(entity =>
            {
                entity.HasKey(e => e.IdCarton)
                   .HasName("PRIMARY");

                entity.ToTable("cartones");

                entity.HasIndex(e => e.IdJuego, "idx_cartones_IdJuego");
                entity.HasIndex(e => e.IdSerie, "idx_cartones_IdSerie");
                entity.HasIndex(e => e.IdCliente, "idx_cartones_IdCliente");
                entity.HasIndex(e => e.Idvendedor, "idx_cartones_IdVendedor");

                entity.HasOne(c => c.IdJuegoNavigation)
                    .WithMany(j => j.Cartones)
                    .HasForeignKey(d => d.IdJuego)
                    .HasConstraintName("FK_Cartones_IdJuego");


                entity.Property(e => e.Estado).HasDefaultValueSql("'A'")
                    .IsRequired()
                    .HasMaxLength(30);

            });

            modelBuilder.Entity<CartonJuego>(entity =>
            {
                entity.HasKey(e => e.IdCarton)
                   .HasName("PRIMARY");


                entity.HasIndex(e => e.IdJuego, "idx_cartones_IdJuego");
                entity.HasIndex(e => e.IdSerie, "idx_cartones_IdSerie");
                entity.HasIndex(e => e.IdCliente, "idx_cartones_IdCliente");
                entity.HasIndex(e => e.Idvendedor, "idx_cartones_IdVendedor");


                entity.Property(e => e.Estado).HasDefaultValueSql("'A'")
                    .IsRequired()
                    .HasMaxLength(30);

            });

            modelBuilder.Entity<Ciudades>(entity =>
            {
                entity.HasKey(e => e.IdCiudad)
                    .HasName("PRIMARY");

                entity.ToTable("ciudades");

                entity.HasIndex(e => e.IdPais, "FK_Ciudades_IdPais");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.Ciudades)
                    .HasForeignKey(d => d.IdPais)
                    .HasConstraintName("FK_Ciudades_IdPais");
            });

            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PRIMARY");

                entity.ToTable("clientes");

                entity.Property(e => e.IdVendedor).HasDefaultValueSql("'0'");

                entity.Property(e => e.Barrio)
                    .HasMaxLength(50);

                entity.Property(e => e.Celular)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ClienteModulo>(entity =>
            {
                entity.HasKey(e => e.IdClienteModulo)
                    .HasName("PRIMARY");

                entity.ToTable("clientesmodulos");

                entity.HasIndex(e => e.IdCliente, "FK_ClientesModulos_IdCliente");

                entity.HasIndex(e => e.IdModulo, "FK_ClientesModulos_IdModulo");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'A'")
                    .IsFixedLength(true);

                entity.Property(e => e.IdJuegoFin).HasColumnType("int");

                entity.Property(e => e.IdJuegoInicio).HasColumnType("int");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Clientesmodulos)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK_ClientesModulos_IdCliente");

                entity.HasOne(d => d.IdModuloNavigation)
                    .WithMany(p => p.Clientesmodulos)
                    .HasForeignKey(d => d.IdModulo)
                    .HasConstraintName("FK_ClientesModulos_IdModulo");
            });

            modelBuilder.Entity<Conceptogastos>(entity =>
            {
                entity.HasKey(e => e.IdConceptoGasto)
                    .HasName("PRIMARY");

                entity.ToTable("conceptogastos");

                entity.Property(e => e.Descripcion).HasMaxLength(100);
            });

            modelBuilder.Entity<Conceptoingresos>(entity =>
            {
                entity.HasKey(e => e.IdConceptoIngreso)
                    .HasName("PRIMARY");

                entity.ToTable("conceptoingresos");

                entity.Property(e => e.Descripcion).HasMaxLength(100);
            });

            modelBuilder.Entity<Configuracion>(entity =>
            {
                entity.HasKey(e => e.IdConfiguracion)
                    .HasName("PRIMARY");

                entity.ToTable("configuracion");

                entity.Property(e => e.Estado)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'A'")
                    .IsFixedLength(true);

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Configuracionreportepdf>(entity =>
            {
                entity.HasKey(e => e.IdConfiguracionReportePdf)
                    .HasName("PRIMARY");

                entity.ToTable("configuracionreportepdf");

                entity.HasIndex(e => e.IdConfiguracionReportePdf, "FK_ConfiguracionReportePdf_IdConfiguracionReportePdf");

                entity.Property(e => e.Habilitado).HasDefaultValueSql("'1'");

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.Property(e => e.NombreArchivoRpt).HasMaxLength(100);
            });

            modelBuilder.Entity<Definicionmonedas>(entity =>
            {
                entity.HasKey(e => e.IdDefinicionMoneda)
                    .HasName("PRIMARY");

                entity.ToTable("definicionmonedas");

                entity.Property(e => e.Moneda)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Directoriobalotasvirtuales>(entity =>
            {
                entity.ToTable("directoriobalotasvirtuales");

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Empresas>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa)
                    .HasName("PRIMARY");

                entity.ToTable("empresas");

                entity.Property(e => e.Ciudad).HasMaxLength(50);

                entity.Property(e => e.Direccion).HasMaxLength(255);

                entity.Property(e => e.Nit)
                    .HasMaxLength(20)
                    .HasColumnName("NIT");

                entity.Property(e => e.NombreEmpresa)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Pais).HasMaxLength(50);

                entity.Property(e => e.Prefijo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Telefono).HasMaxLength(50);
            });

            modelBuilder.Entity<Estadobalotasuerte>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("estadobalotasuerte");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Estadoconsultacartones>(entity =>
            {
                entity.HasKey(e => e.IdEstadoConsultaCartones)
                    .HasName("PRIMARY");

                entity.ToTable("estadoconsultacartones");

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Estadorondafigura>(entity =>
            {
                entity.HasKey(e => e.IdEstadoRondaFigura)
                    .HasName("PRIMARY");

                entity.ToTable("estadorondafigura");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Figurasacumuladas>(entity =>
            {
                entity.HasKey(e => e.IdFiguraAcumulada)
                    .HasName("PRIMARY");

                entity.ToTable("figurasacumuladas");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'A'")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Flujocaja>(entity =>
            {
                entity.HasKey(e => e.IdFlujoCaja)
                    .HasName("PRIMARY");

                entity.ToTable("flujocaja");

                entity.HasIndex(e => e.IdProgramacionJuego, "FK_FlujoCaja_IdProgramacionJuego");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'A'")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdProgramacionJuegoNavigation)
                    .WithMany(p => p.Flujocaja)
                    .HasForeignKey(d => d.IdProgramacionJuego)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FlujoCaja_IdProgramacionJuego");
            });

            modelBuilder.Entity<Gastosgenerales>(entity =>
            {
                entity.HasKey(e => e.IdGastoGeneral)
                    .HasName("PRIMARY");

                entity.ToTable("gastosgenerales");

                entity.HasIndex(e => e.IdConceptoGasto, "FK_GastosGenerales_IdConceptoGasto");

                entity.HasIndex(e => e.IdUsuario, "FK_GastosGenerales_IdUsuario");

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'A'")
                    .IsFixedLength(true);

                entity.Property(e => e.Mes).HasColumnType("tinyint");

                entity.Property(e => e.OrigenPago)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'C'")
                    .IsFixedLength(true);

                entity.Property(e => e.Socio).HasMaxLength(50);

                entity.HasOne(d => d.IdConceptoGastoNavigation)
                    .WithMany(p => p.Gastosgenerales)
                    .HasForeignKey(d => d.IdConceptoGasto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GastosGenerales_IdConceptoGasto");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Gastosgenerales)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GastosGenerales_IdUsuario");
            });

            modelBuilder.Entity<Gastosprogramacionjuegos>(entity =>
            {
                entity.HasKey(e => e.IdGastoJuego)
                    .HasName("PRIMARY");

                entity.ToTable("gastosprogramacionjuegos");

                entity.HasIndex(e => e.IdConceptoGasto, "FK_GastosProgramacionJuegos_IdConceptoGasto");

                entity.HasIndex(e => e.IdProgramacionJuego, "FK_GastosProgramacionJuegos_IdProgramacionJuego");

                entity.HasIndex(e => e.IdUsuario, "FK_GastosProgramacionJuegos_IdUsuario");

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'A'")
                    .IsFixedLength(true);

                entity.Property(e => e.Socio).HasMaxLength(50);

                entity.HasOne(d => d.IdConceptoGastoNavigation)
                    .WithMany(p => p.Gastosprogramacionjuegos)
                    .HasForeignKey(d => d.IdConceptoGasto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GastosProgramacionJuegos_IdConceptoGasto");

                entity.HasOne(d => d.IdProgramacionJuegoNavigation)
                    .WithMany(p => p.Gastosprogramacionjuegos)
                    .HasForeignKey(d => d.IdProgramacionJuego)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GastosProgramacionJuegos_IdProgramacionJuego");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Gastosprogramacionjuegos)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GastosProgramacionJuegos_IdUsuario");
            });

            modelBuilder.Entity<Historicoflujocaja>(entity =>
            {
                entity.HasKey(e => e.IdHistoricoFlujoCaja)
                    .HasName("PRIMARY");

                entity.ToTable("historicoflujocaja");

                entity.HasIndex(e => e.IdUsuario, "FK_GHistoricoFlujoCaja_IdUsuario");

                entity.Property(e => e.Accion).HasMaxLength(50);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'A'")
                    .IsFixedLength(true);

                entity.Property(e => e.Mes).HasColumnType("tinyint");

                entity.Property(e => e.OrigenPago)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'C'")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Historicoflujocaja)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HistoricoFlujoCaja_IdUsuario");
            });

            modelBuilder.Entity<Ingresosgenerales>(entity =>
            {
                entity.HasKey(e => e.IdIngresoGeneral)
                    .HasName("PRIMARY");

                entity.ToTable("ingresosgenerales");

                entity.HasIndex(e => e.IdConceptoIngreso, "FK_IngresosGenerales_IdConceptoIngreso");

                entity.HasIndex(e => e.IdUsuario, "FK_IngresosGenerales_IdUsuario");

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'A'")
                    .IsFixedLength(true);

                entity.Property(e => e.Mes).HasColumnType("tinyint");

                entity.Property(e => e.OrigenPago)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'C'")
                    .IsFixedLength(true);

                entity.Property(e => e.Socio).HasMaxLength(50);

                entity.HasOne(d => d.IdConceptoIngresoNavigation)
                    .WithMany(p => p.Ingresosgenerales)
                    .HasForeignKey(d => d.IdConceptoIngreso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IngresosGenerales_IdConceptoIngreso");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Ingresosgenerales)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IngresosGenerales_IdUsuario");
            });

            modelBuilder.Entity<Ingresosprogramacionjuegos>(entity =>
            {
                entity.HasKey(e => e.IdIngresoJuego)
                    .HasName("PRIMARY");

                entity.ToTable("ingresosprogramacionjuegos");

                entity.HasIndex(e => e.IdConceptoIngreso, "FK_IngresosProgramacionJuegos_IdConceptoIngreso");

                entity.HasIndex(e => e.IdProgramacionJuego, "FK_IngresosProgramacionJuegos_IdProgramacionJuego");

                entity.HasIndex(e => e.IdUsuario, "FK_IngresosProgramacionJuegos_IdUsuario");

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'A'")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdConceptoIngresoNavigation)
                    .WithMany(p => p.Ingresosprogramacionjuegos)
                    .HasForeignKey(d => d.IdConceptoIngreso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IngresosProgramacionJuegos_IdConceptoIngreso");

                entity.HasOne(d => d.IdProgramacionJuegoNavigation)
                    .WithMany(p => p.Ingresosprogramacionjuegos)
                    .HasForeignKey(d => d.IdProgramacionJuego)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IngresosProgramacionJuegos_IdProgramacionJuego");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Ingresosprogramacionjuegos)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IngresosProgramacionJuegos_IdUsuario");
            });

            modelBuilder.Entity<Juegos>(entity =>
            {
                entity.HasKey(e => e.IdJuego).HasName("PRIMARY");
                    
                entity.ToTable("juegos");

                entity.HasIndex(e => e.IdEmpresa, "FK_juegos_IdEmpresa");

                entity.Property(e => e.Terminado)
                    .HasMaxLength(1)
                    .IsFixedLength(true);

                entity.HasMany(d => d.Programacionjuegos)
                .WithOne(p => p.IdJuegoNavigation)
                .HasForeignKey(d => d.IdJuego);

                entity.HasOne(d => d.Configuracion)
                .WithOne(p => p.IdJuegoNavigation)
                .HasForeignKey<Configuracion>(d => d.NumeroJuego);

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.Juegos)
                    .HasForeignKey(d => d.IdEmpresa)
                    .HasConstraintName("FK_juegos_IdEmpresa");
            });

            modelBuilder.Entity<Juegosbalotasfinales>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("juegosbalotasfinales");
            });

            modelBuilder.Entity<Juegosbalotasuerte>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("juegosbalotasuerte");

                entity.Property(e => e.IdEstadoBalotaSuerte).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Listablas>(entity =>
            {
                entity.HasKey(e => e.IdLisTablas)
                    .HasName("PRIMARY");

                entity.ToTable("listablas");

                entity.Property(e => e.Defecto)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.Fabrica).HasMaxLength(100);

                entity.Property(e => e.Simbolo).HasMaxLength(1);

                entity.Property(e => e.SqlConsulta).HasMaxLength(255);

                entity.Property(e => e.Tabla).HasMaxLength(50);

                entity.Property(e => e.Visible)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Menus>(entity =>
            {
                entity.HasKey(e => e.IdMenu)
                    .HasName("PRIMARY");

                entity.ToTable("menus");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NombreMenu)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Modopagobalota>(entity =>
            {
                entity.ToTable("modopagobalota");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Modulos>(entity =>
            {
                entity.HasKey(e => e.IdModulo)
                    .HasName("PRIMARY");

                entity.ToTable("modulos");

                entity.Property(e => e.Serie1)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Serie2)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Serie3)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Serie4)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Serie5)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Serie6)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<Nominadescuentos>(entity =>
            {
                entity.HasKey(e => e.IdNominaDescuento)
                    .HasName("PRIMARY");

                entity.ToTable("nominadescuentos");

                entity.HasIndex(e => e.IdProgramacionJuego, "FK_NominaDescuentos_IdProgramacionJuego");

                entity.HasIndex(e => e.IdUsuario, "FK_NominaDescuentos_IdUsuario");

                entity.Property(e => e.Cobrado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'N'")
                    .IsFixedLength(true);

                entity.Property(e => e.Concepto)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'A'")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdProgramacionJuegoNavigation)
                    .WithMany(p => p.Nominadescuentos)
                    .HasForeignKey(d => d.IdProgramacionJuego)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NominaDescuentos_IdProgramacionJuego");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Nominadescuentos)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NominaDescuentos_IdUsuario");
            });

            modelBuilder.Entity<Numerosmemorama>(entity =>
            {
                entity.ToTable("numerosmemorama");
            });

            modelBuilder.Entity<Paises>(entity =>
            {
                entity.HasKey(e => e.IdPais)
                    .HasName("PRIMARY");

                entity.ToTable("paises");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Palabrasahorcado>(entity =>
            {
                entity.HasKey(e => e.Palabra)
                    .HasName("PRIMARY");

                entity.ToTable("palabrasahorcado");

                entity.Property(e => e.Palabra).HasMaxLength(11);

                entity.Property(e => e.Pista)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<Parametrosgenerales>(entity =>
            {
                entity.HasKey(e => e.IdParametrosGenerales)
                    .HasName("PRIMARY");

                entity.ToTable("parametrosgenerales");

                entity.HasComment("Configuracion general de la aplicacion");

                entity.Property(e => e.IdParametrosGenerales).HasColumnName("IdParametros_Generales");

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.Referencia).HasMaxLength(255);

                entity.Property(e => e.Valor).HasMaxLength(255);
            });

            modelBuilder.Entity<Perfiles>(entity =>
            {
                entity.HasKey(e => e.IdPerfil)
                    .HasName("PRIMARY");

                entity.ToTable("perfiles");

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.EsVisible).HasDefaultValueSql("'0'");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<Perfilesusuario>(entity =>
            {
                entity.HasKey(e => new { e.IdPerfil, e.IdUsuario })
                    .HasName("PRIMARY");

                entity.ToTable("perfilesusuario");
            });

            modelBuilder.Entity<Perfilpermisos>(entity =>
            {
                entity.HasKey(e => e.IdPerfilPermisos)
                    .HasName("PRIMARY");

                entity.ToTable("perfilpermisos");

                entity.HasIndex(e => e.IdMenu, "FK_perfilpermisos_IdMenu");

                entity.HasIndex(e => e.IdPerfil, "FK_perfilpermisos_IdPerfil");

                entity.Property(e => e.Eliminacion).HasColumnType("bit(1)");

                entity.Property(e => e.Escritura).HasColumnType("bit(1)");

                entity.Property(e => e.Habilitado)
                    .IsRequired()
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Lectura).HasColumnType("bit(1)");

                entity.HasOne(d => d.IdMenuNavigation)
                    .WithMany(p => p.Perfilpermisos)
                    .HasForeignKey(d => d.IdMenu)
                    .HasConstraintName("FK_perfilpermisos_IdMenu");

                entity.HasOne(d => d.IdPerfilNavigation)
                    .WithMany(p => p.Perfilpermisos)
                    .HasForeignKey(d => d.IdPerfil)
                    .HasConstraintName("FK_perfilpermisos_IdPerfil");
            });

            modelBuilder.Entity<Plenoautomatico>(entity =>
            {
                entity.HasKey(e => e.IdPlenoAutomatico)
                    .HasName("PRIMARY");

                entity.ToTable("plenoautomatico");

                entity.Property(e => e.EsSencillo)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.F01).HasColumnName("f01");

                entity.Property(e => e.F02).HasColumnName("f02");

                entity.Property(e => e.F03).HasColumnName("f03");

                entity.Property(e => e.F04).HasColumnName("f04");

                entity.Property(e => e.F05).HasColumnName("f05");

                entity.Property(e => e.F06).HasColumnName("f06");

                entity.Property(e => e.F07).HasColumnName("f07");

                entity.Property(e => e.F08).HasColumnName("f08");

                entity.Property(e => e.F09).HasColumnName("f09");

                entity.Property(e => e.F10).HasColumnName("f10");

                entity.Property(e => e.F11).HasColumnName("f11");

                entity.Property(e => e.F12).HasColumnName("f12");

                entity.Property(e => e.F13).HasColumnName("f13");

                entity.Property(e => e.F14).HasColumnName("f14");

                entity.Property(e => e.F15).HasColumnName("f15");

                entity.Property(e => e.F16).HasColumnName("f16");

                entity.Property(e => e.F17).HasColumnName("f17");

                entity.Property(e => e.F18).HasColumnName("f18");

                entity.Property(e => e.F19).HasColumnName("f19");

                entity.Property(e => e.F20).HasColumnName("f20");

                //entity.Property(e => e.F21).HasColumnName("f21");

                //entity.Property(e => e.F22).HasColumnName("f22");

                //entity.Property(e => e.F23).HasColumnName("f23");

                //entity.Property(e => e.F24).HasColumnName("f24");

                //entity.Property(e => e.F25).HasColumnName("f25");

                entity.Property(e => e.Modaenable).HasColumnName("modaenable");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.Property(e => e.Record)
                    .HasColumnType("decimal(4,0)")
                    .HasColumnName("record");
            });

            modelBuilder.Entity<Porcentajepremios>(entity =>
            {
                entity.HasKey(e => e.IdPorcentajePremio)
                    .HasName("PRIMARY");

                entity.ToTable("porcentajepremios");

                entity.HasIndex(e => e.IdUsuario, "FK_PorcentajesPremios_IdUsuario");

                entity.Property(e => e.Estado)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'A'")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Porcentajepremios)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK_PorcentajesPremios_IdUsuario");
            });

            modelBuilder.Entity<Programaciondevolucioncodigobarras>(entity =>
            {
                entity.HasKey(e => e.IdDevolucionCodigoBarra)
                    .HasName("PRIMARY");

                entity.ToTable("programaciondevolucioncodigobarras");

                entity.HasIndex(e => e.IdProgramacionJuego, "FK_ProgramacionDevolucionCodigoBarras_IdProgramacionJuego");

                entity.HasIndex(e => e.IdVendedor, "FK_ProgramacionDevolucionCodigoBarras_IdVendedor");

                entity.Property(e => e.HojaCarton).HasMaxLength(20);

                entity.HasOne(d => d.IdProgramacionJuegoNavigation)
                    .WithMany(p => p.Programaciondevolucioncodigobarras)
                    .HasForeignKey(d => d.IdProgramacionJuego)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProgramacionDevolucionCodigoBarras_IdProgramacionJuego");

                entity.HasOne(d => d.IdVendedorNavigation)
                    .WithMany(p => p.Programaciondevolucioncodigobarras)
                    .HasForeignKey(d => d.IdVendedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProgramacionDevolucionCodigoBarras_IdVendedor");
            });

            modelBuilder.Entity<Programacionjuegos>(entity =>
            {
                entity.HasKey(e => e.IdProgramacionJuego)
                    .HasName("PRIMARY");

                entity.ToTable("programacionjuegos");

                entity.HasIndex(e => e.IdJuego, "FK_ProgramacionJuegos_IdJuego");

                entity.HasIndex(e => e.IdSerie, "FK_ProgramacionJuegos_IdSerie");

                entity.Property(e => e.CartonFinal).HasDefaultValueSql("'1'");

                entity.Property(e => e.CartonInicial).HasDefaultValueSql("'1'");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'A'")
                    .IsFixedLength(true);

                entity.Property(e => e.HojaFinal).HasDefaultValueSql("'1'");

                entity.Property(e => e.HojaInicial).HasDefaultValueSql("'1'");

                entity.HasOne(d => d.IdJuegoNavigation);

                entity.HasOne(d => d.IdSerieNavigation)
                    .WithMany(p => p.Programacionjuegos)
                    .HasForeignKey(d => d.IdSerie)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProgramacionJuegos_IdSerie");
            });

            modelBuilder.Entity<Programacionjuegosdineros>(entity =>
            {
                entity.HasKey(e => e.IdProgramacionJuegoDinero)
                    .HasName("PRIMARY");

                entity.ToTable("programacionjuegosdineros");

                entity.HasIndex(e => e.IdProgramacionJuego, "FK_ProgramacionJuegosDineros_IdProgramacionJuego");

                entity.Property(e => e.CerradoBanco)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'A'")
                    .IsFixedLength(true);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'A'")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdProgramacionJuegoNavigation)
                    .WithMany(p => p.Programacionjuegosdineros)
                    .HasForeignKey(d => d.IdProgramacionJuego)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProgramacionJuegosDineros_IdProgramacionJuego");
            });

            modelBuilder.Entity<Programacionjuegosfiguras>(entity =>
            {
                entity.HasKey(e => e.IdProgramacionJuegoFigura)
                    .HasName("PRIMARY");

                entity.ToTable("programacionjuegosfiguras");

                entity.HasIndex(e => e.IdPlenoAutomatico, "FK_ProgramacionJuegosFiguras_IdPlenoAutomatico");

                entity.HasIndex(e => e.IdProgramacionJuego, "FK_ProgramacionJuegosFiguras_IdProgramacionJuego");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'A'")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdPlenoAutomaticoNavigation)
                    .WithMany(p => p.Programacionjuegosfiguras)
                    .HasForeignKey(d => d.IdPlenoAutomatico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProgramacionJuegosFiguras_IdPlenoAutomatico");

                entity.HasOne(d => d.IdProgramacionJuegoNavigation)
                    .WithMany(p => p.Programacionjuegosfiguras)
                    .HasForeignKey(d => d.IdProgramacionJuego)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProgramacionJuegosFiguras_IdProgramacionJuego");
            });

            modelBuilder.Entity<Programacionjuegoshojasdevueltas>(entity =>
            {
                entity.HasKey(e => e.IdProgramacionJuegoHojaDevuelta)
                    .HasName("PRIMARY");

                entity.ToTable("programacionjuegoshojasdevueltas");

                entity.HasIndex(e => e.IdProgramacionJuego, "FK_ProgramacionJuegosHojasDevueltas_IdProgramacionJuego");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'A'")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdProgramacionJuegoNavigation)
                    .WithMany(p => p.Programacionjuegoshojasdevueltas)
                    .HasForeignKey(d => d.IdProgramacionJuego)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProgramacionJuegosHojasDevueltas_IdProgramacionJuego");
            });

            modelBuilder.Entity<Recaudodetalles>(entity =>
            {
                entity.HasKey(e => e.IdRecaudoDetalle)
                    .HasName("PRIMARY");

                entity.ToTable("recaudodetalles");

                entity.HasIndex(e => e.IdDefinicionMoneda, "FK_RecaudoDetalles_IdDefinicionMoneda");

                entity.HasIndex(e => e.IdProgramacionJuego, "FK_RecaudoDetalles_IdProgramacionJuego");

                entity.HasIndex(e => e.IdUsuario, "FK_RecaudoDetalles_IdUsuario");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'A'")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdDefinicionMonedaNavigation)
                    .WithMany(p => p.Recaudodetalles)
                    .HasForeignKey(d => d.IdDefinicionMoneda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecaudoDetalles_IdDefinicionMoneda");

                entity.HasOne(d => d.IdProgramacionJuegoNavigation)
                    .WithMany(p => p.Recaudodetalles)
                    .HasForeignKey(d => d.IdProgramacionJuego)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecaudoDetalles_IdProgramacionJuego");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Recaudodetalles)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecaudoDetalles_IdUsuario");
            });

            modelBuilder.Entity<Recaudofaltantes>(entity =>
            {
                entity.HasKey(e => e.IdRecaudoFaltante)
                    .HasName("PRIMARY");

                entity.ToTable("recaudofaltantes");

                entity.HasIndex(e => e.IdProgramacionJuego, "FK_RecaudoFaltantes_IdProgramacionJuego");

                entity.HasIndex(e => e.IdUsuario, "FK_RecaudoFaltantes_IdUsuario");

                entity.HasIndex(e => e.IdVendedor, "FK_RecaudoFaltantes_IdVendedor");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'A'")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdProgramacionJuegoNavigation)
                    .WithMany(p => p.Recaudofaltantes)
                    .HasForeignKey(d => d.IdProgramacionJuego)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecaudoFaltantes_IdProgramacionJuego");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Recaudofaltantes)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecaudoFaltantes_IdUsuario");

                entity.HasOne(d => d.IdVendedorNavigation)
                    .WithMany(p => p.Recaudofaltantes)
                    .HasForeignKey(d => d.IdVendedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecaudoFaltantes_IdVendedor");
            });

            modelBuilder.Entity<Recaudototales>(entity =>
            {
                entity.HasKey(e => e.IdRecaudoTotal)
                    .HasName("PRIMARY");

                entity.ToTable("recaudototales");

                entity.HasIndex(e => e.IdProgramacionJuego, "FK_RecaudoTotales_IdProgramacionJuego");

                entity.HasIndex(e => e.IdUsuario, "FK_RecaudoTotales_IdUsuario");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'A'")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdProgramacionJuegoNavigation)
                    .WithMany(p => p.Recaudototales)
                    .HasForeignKey(d => d.IdProgramacionJuego)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecaudoTotales_IdProgramacionJuego");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Recaudototales)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecaudoTotales_IdUsuario");
            });

            modelBuilder.Entity<Rondas>(entity =>
            {
                entity.HasKey(e => e.IdRonda)
                    .HasName("PRIMARY");

                entity.ToTable("rondas");

                entity.HasIndex(e => e.IdJuego, "FK_ronda_IdJuego");

                entity.Property(e => e.Estado)
                    .HasMaxLength(1)
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdJuegoNavigation)
                    .WithMany(p => p.Rondas)
                    .HasForeignKey(d => d.IdJuego)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ronda_IdJuego");
            });

            modelBuilder.Entity<Rondascartonesregistrados>(entity =>
            {
                entity.HasKey(e => e.IdCartonesRegistrados)
                    .HasName("PRIMARY");

                entity.ToTable("rondascartonesregistrados");

                entity.Property(e => e.Estado)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'A'");

                entity.Property(e => e.NumeroCartonFinal).HasDefaultValueSql("'0'");

                entity.Property(e => e.NumeroCartonInicial).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Rondasfiguras>(entity =>
            {
                entity.HasKey(e => e.IdFiguraRonda)
                    .HasName("PRIMARY");

                entity.ToTable("rondasfiguras");

                entity.HasIndex(e => e.IdPlenoAutomatico, "FK_figurasronda_IdPlenoAutomatico");

                entity.HasIndex(e => e.IdRonda, "FK_figurasronda_IdRonda");

                entity.Property(e => e.EsSencillo)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.MarcadaNoVendida)
                    .IsRequired()
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.MarcadaVendida)
                    .IsRequired()
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.TipoFigura)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'P'")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdRondaNavigation)
                    .WithMany(p => p.Rondasfiguras)
                    .HasForeignKey(d => d.IdRonda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_figurasronda_IdRonda");
            });

            modelBuilder.Entity<Rondashistoriaconsulta>(entity =>
            {
                entity.HasKey(e => e.IdHistoriaConsulta)
                    .HasName("PRIMARY");

                entity.ToTable("rondashistoriaconsulta");

                entity.Property(e => e.Automatico).HasColumnType("bit(1)");

                entity.Property(e => e.Barrio).HasMaxLength(50);

                entity.Property(e => e.CantoGanador).HasColumnType("bit(1)");

                entity.Property(e => e.Celular).HasMaxLength(20);

                entity.Property(e => e.Cliente).HasMaxLength(150);

                entity.Property(e => e.EsSencillo)
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.EstadoConsulta).HasDefaultValueSql("'1'");

                entity.Property(e => e.Modulo).HasMaxLength(50);

                entity.Property(e => e.Premio).HasDefaultValueSql("'0'");

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<Rondashistoriafinal>(entity =>
            {
                entity.HasKey(e => e.Idhistoriafinal)
                    .HasName("PRIMARY");

                entity.ToTable("rondashistoriafinal");

                entity.Property(e => e.Balota).HasDefaultValueSql("'0'");

                entity.Property(e => e.Estado)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'A'");

                entity.Property(e => e.IdRonda)
                    .HasColumnName("idRonda")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Rondashistorialmovimientos>(entity =>
            {
                entity.HasKey(e => e.IdHistorialMovimiento)
                    .HasName("PRIMARY");

                entity.ToTable("rondashistorialmovimientos");

                entity.HasIndex(e => e.IdFiguraRonda, "FK_rondashistorialmovimientos_IdFiguraRonda");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("longtext");

                entity.HasOne(d => d.IdFiguraRondaNavigation)
                    .WithMany(p => p.Rondashistorialmovimientos)
                    .HasForeignKey(d => d.IdFiguraRonda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_rondashistorialmovimientos_IdFiguraRonda");
            });

            modelBuilder.Entity<Rondasseries>(entity =>
            {
                entity.HasKey(e => e.IdSerieRonda)
                    .HasName("PRIMARY");

                entity.ToTable("rondasseries");

                entity.Property(e => e.Barrio).HasMaxLength(50);

                entity.Property(e => e.Celular).HasMaxLength(20);

                entity.Property(e => e.Cliente).HasMaxLength(150);

                entity.Property(e => e.Modulo).HasMaxLength(50);

                entity.Property(e => e.Simbolo)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<Sencillo>(entity =>
            {
                entity.HasKey(e => e.IdSencillo)
                    .HasName("PRIMARY");

                entity.ToTable("sencillo");

                entity.Property(e => e.F01).HasColumnName("f01");

                entity.Property(e => e.F02).HasColumnName("f02");

                entity.Property(e => e.F03).HasColumnName("f03");

                entity.Property(e => e.F04).HasColumnName("f04");

                entity.Property(e => e.F05).HasColumnName("f05");

                entity.Property(e => e.F06).HasColumnName("f06");

                entity.Property(e => e.F07).HasColumnName("f07");

                entity.Property(e => e.F08).HasColumnName("f08");

                entity.Property(e => e.F09).HasColumnName("f09");

                entity.Property(e => e.F10).HasColumnName("f10");

                entity.Property(e => e.F11).HasColumnName("f11");

                entity.Property(e => e.F12).HasColumnName("f12");

                entity.Property(e => e.F13).HasColumnName("f13");

                entity.Property(e => e.F14).HasColumnName("f14");

                entity.Property(e => e.F15).HasColumnName("f15");

                entity.Property(e => e.F16).HasColumnName("f16");

                entity.Property(e => e.F17).HasColumnName("f17");

                entity.Property(e => e.F18).HasColumnName("f18");

                entity.Property(e => e.F19).HasColumnName("f19");

                entity.Property(e => e.F20).HasColumnName("f20");

                entity.Property(e => e.F21).HasColumnName("f21");

                entity.Property(e => e.F22).HasColumnName("f22");

                entity.Property(e => e.F23).HasColumnName("f23");

                entity.Property(e => e.F24).HasColumnName("f24");

                entity.Property(e => e.F25).HasColumnName("f25");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Seriecuartorombos100000>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PRIMARY");

                entity.ToTable("seriecuartorombos100000");
            });

            modelBuilder.Entity<Serieimprimir>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("serieimprimir");

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.P1)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.P10)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.P11)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.P12)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.P13)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.P14)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.P15)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.P16)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.P17)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.P18)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.P19)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.P2)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.P20)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.P21)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.P22)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.P23)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.P24)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.P25)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.P3)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.P4)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.P5)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.P6)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.P7)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.P8)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.P9)
                    .IsRequired()
                    .HasMaxLength(2);
            });

            modelBuilder.Entity<Serieimprimirlinea>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("serieimprimirlinea");

                entity.Property(e => e.CodigoBarras).HasColumnType("bit(1)");

                entity.Property(e => e.Linea1)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Linea2)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Linea3)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Serieprimerarombos20000>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PRIMARY");

                entity.ToTable("serieprimerarombos20000");
            });

            modelBuilder.Entity<Seriequintarombos30000>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PRIMARY");

                entity.ToTable("seriequintarombos30000");
            });

            modelBuilder.Entity<Seriesegundarombos20000>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PRIMARY");

                entity.ToTable("seriesegundarombos20000");
            });

            modelBuilder.Entity<Serietelebingo100000>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PRIMARY");

                entity.ToTable("serietelebingo100000");
            });

            modelBuilder.Entity<Serietelebingo120000>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PRIMARY");

                entity.ToTable("serietelebingo120000");
            });

            modelBuilder.Entity<Serietercerarombos50000>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PRIMARY");

                entity.ToTable("serietercerarombos50000");
            });

            modelBuilder.Entity<SolicitudesVendedores>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudVendedor)
                    .HasName("PRIMARY");

                entity.ToTable("solicitudesvendedores");

                entity.HasIndex(e => e.IdVendedor, "FK_SolicitudesVendedores_IdVendedor");

                entity.HasIndex(e => e.IdJuego, "FK_SolicitudesVendedores_IdJuego");

                entity.Property(e => e.TipoSolicitud)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength(true);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength(true);

            });

            modelBuilder.Entity<Tiposrelacion>(entity =>
            {
                entity.HasKey(e => e.IdTipoRelacion)
                    .HasName("PRIMARY");

                entity.ToTable("tiposrelacion");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PRIMARY");

                entity.ToTable("usuarios");

                entity.Property(e => e.Autenticado).HasColumnType("bit(1)");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ClaveAjustes)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.EsSocio)
                    .IsRequired()
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength(true);

                entity.Property(e => e.JustificacionBloqueo).HasMaxLength(500);

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModificaPremios)
                    .IsRequired()
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.NombreCompleto)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<Vconsultalistadocartonesdevueltos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vconsultalistadocartonesdevueltos");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("''")
                    .IsFixedLength(true);

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Vendedores>(entity =>
            {
                entity.HasKey(e => e.IdVendedor)
                    .HasName("PRIMARY");

                entity.ToTable("vendedores");

                entity.HasIndex(e => e.IdCiudad, "FK_Vendedores_IdCiudad");

                entity.HasIndex(e => e.IdUsuarioCreacion, "FK_Vendedores_IdUsuario");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Celular)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Documento)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'A'")
                    .IsFixedLength(true);

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.IdCiudadNavigation)
                    .WithMany(p => p.Vendedores)
                    .HasForeignKey(d => d.IdCiudad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vendedores_IdCiudad");

                entity.HasOne(d => d.IdUsuarioCreacionNavigation)
                    .WithMany(p => p.Vendedores)
                    .HasForeignKey(d => d.IdUsuarioCreacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vendedores_IdUsuario");
            });

            modelBuilder.Entity<Vendedorescobrocartones>(entity =>
            {
                entity.HasKey(e => e.IdVendedorCobroCarton)
                    .HasName("PRIMARY");

                entity.ToTable("vendedorescobrocartones");

                entity.HasIndex(e => e.IdProgramacionJuego, "FK_VendedoresCobroCartones_IdProgramacionJuego");

                entity.HasIndex(e => e.IdVendedor, "FK_VendedoresCobroCartones_IdVendedor");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'A'")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdProgramacionJuegoNavigation)
                    .WithMany(p => p.Vendedorescobrocartones)
                    .HasForeignKey(d => d.IdProgramacionJuego)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VendedoresCobroCartones_IdProgramacionJuego");

                entity.HasOne(d => d.IdVendedorNavigation)
                    .WithMany(p => p.Vendedorescobrocartones)
                    .HasForeignKey(d => d.IdVendedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VendedoresCobroCartones_IdVendedor");
            });

            modelBuilder.Entity<Vendedorescuentascobrar>(entity =>
            {
                entity.HasKey(e => e.IdVendedorCuentaCobrar)
                    .HasName("PRIMARY");

                entity.ToTable("vendedorescuentascobrar");

                entity.HasIndex(e => e.IdProgramacionJuego, "FK_VendedoresCuentasCobrar_IdProgramacionJuego");

                entity.HasIndex(e => e.IdVendedor, "FK_VendedoresCuentasCobrar_IdVendedor");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'A'")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdProgramacionJuegoNavigation)
                    .WithMany(p => p.Vendedorescuentascobrar)
                    .HasForeignKey(d => d.IdProgramacionJuego)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VendedoresCuentasCobrar_IdProgramacionJuego");

                entity.HasOne(d => d.IdVendedorNavigation)
                    .WithMany(p => p.Vendedorescuentascobrar)
                    .HasForeignKey(d => d.IdVendedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VendedoresCuentasCobrar_IdVendedor");
            });

            modelBuilder.Entity<Vendedoreshojas>(entity =>
            {
                entity.HasKey(e => e.IdVendedorHoja)
                    .HasName("PRIMARY");

                entity.ToTable("vendedoreshojas");

                entity.HasIndex(e => e.IdProgramacionJuego, "FK_VendedoresHojas_IdProgramacionJuego");

                entity.HasIndex(e => e.IdVendedor, "FK_VendedoresHojas_IdVendedor");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'A'")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdProgramacionJuegoNavigation)
                    .WithMany(p => p.Vendedoreshojas)
                    .HasForeignKey(d => d.IdProgramacionJuego)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VendedoresHojas_IdProgramacionJuego");

                entity.HasOne(d => d.IdVendedorNavigation)
                    .WithMany(p => p.Vendedoreshojas)
                    .HasForeignKey(d => d.IdVendedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VendedoresHojas_IdVendedor");
            });

            modelBuilder.Entity<Vendedoresmodulos>(entity =>
            {
                entity.HasKey(e => e.IdVendedorModulo)
                    .HasName("PRIMARY");

                entity.ToTable("vendedoresmodulos");

                entity.HasIndex(e => e.IdClienteModulo, "FK_VendedoresModulos_IdClienteModulo");

                entity.HasIndex(e => e.IdProgramacionJuego, "FK_VendedoresModulos_IdProgramacionJuego");

                entity.HasIndex(e => e.IdVendedor, "FK_VendedoresModulos_IdVendedor");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'A'")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdClienteModuloNavigation)
                    .WithMany(p => p.Vendedoresmodulos)
                    .HasForeignKey(d => d.IdClienteModulo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VendedoresModulos_IdClienteModulo");

                entity.HasOne(d => d.IdProgramacionJuegoNavigation)
                    .WithMany(p => p.Vendedoresmodulos)
                    .HasForeignKey(d => d.IdProgramacionJuego)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VendedoresModulos_IdProgramacionJuego");

                entity.HasOne(d => d.IdVendedorNavigation)
                    .WithMany(p => p.Vendedoresmodulos)
                    .HasForeignKey(d => d.IdVendedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VendedoresModulos_IdVendedor");
            });

            modelBuilder.Entity<Vendedorespagoanticipados>(entity =>
            {
                entity.HasKey(e => e.IdVendedorPagoAnticipado)
                    .HasName("PRIMARY");

                entity.ToTable("vendedorespagoanticipados");

                entity.HasIndex(e => e.IdUsuario, "FK_VendedoresPagoAnticipados_IdUsuario");

                entity.HasIndex(e => e.IdVendedor, "FK_VendedoresPagoAnticipados_IdVendedor");

                entity.HasIndex(e => e.IdProgramacionJuego, "FK_VendedoresPagoAnticipadoss_IdProgramacionJuego");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'A'")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdProgramacionJuegoNavigation)
                    .WithMany(p => p.Vendedorespagoanticipados)
                    .HasForeignKey(d => d.IdProgramacionJuego)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VendedoresPagoAnticipados_IdProgramacionJuego");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Vendedorespagoanticipados)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VendedoresPagoAnticipados_IdUsuario");

                entity.HasOne(d => d.IdVendedorNavigation)
                    .WithMany(p => p.Vendedorespagoanticipados)
                    .HasForeignKey(d => d.IdVendedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VendedoresPagoAnticipados_IdVendedor");
            });

            modelBuilder.Entity<Vendedoresreferencias>(entity =>
            {
                entity.HasKey(e => e.IdVendedorReferencia)
                    .HasName("PRIMARY");

                entity.ToTable("vendedoresreferencias");

                entity.HasIndex(e => e.IdCiudad, "FK_VendedoresReferencias_IdCiudad");

                entity.HasIndex(e => e.IdTipoRelacion, "FK_VendedoresReferencias_IdTipoRelacion");

                entity.HasIndex(e => e.IdUsuarioCreacion, "FK_VendedoresReferencias_IdUsuario");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Celular)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Documento)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.IdCiudadNavigation)
                    .WithMany(p => p.Vendedoresreferencias)
                    .HasForeignKey(d => d.IdCiudad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VendedoresReferencias_IdCiudad");

                entity.HasOne(d => d.IdTipoRelacionNavigation)
                    .WithMany(p => p.Vendedoresreferencias)
                    .HasForeignKey(d => d.IdTipoRelacion)
                    .HasConstraintName("FK_VendedoresReferencias_IdTipoRelacion");

                entity.HasOne(d => d.IdUsuarioCreacionNavigation)
                    .WithMany(p => p.Vendedoresreferencias)
                    .HasForeignKey(d => d.IdUsuarioCreacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VendedoresReferencias_IdUsuario");
            });

            modelBuilder.Entity<Vendedoresresumen>(entity =>
            {
                entity.HasKey(e => e.IdVendedorResumen)
                    .HasName("PRIMARY");

                entity.ToTable("vendedoresresumen");

                entity.HasIndex(e => e.IdProgramacionJuego, "FK_VendedoresResumen_IdProgramacionJuego");

                entity.HasIndex(e => e.IdVendedor, "FK_VendedoresResumen_IdVendedor");

                entity.Property(e => e.Cobrado).HasColumnType("tinyint");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'A'")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdProgramacionJuegoNavigation)
                    .WithMany(p => p.Vendedoresresumen)
                    .HasForeignKey(d => d.IdProgramacionJuego)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VendedoresResumen_IdProgramacionJuego");

                entity.HasOne(d => d.IdVendedorNavigation)
                    .WithMany(p => p.Vendedoresresumen)
                    .HasForeignKey(d => d.IdVendedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VendedoresResumen_IdVendedor");
            });

            modelBuilder.Entity<Vgastosgenerales>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vgastosgenerales");

                entity.Property(e => e.Concepto).HasMaxLength(100);

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'A'")
                    .IsFixedLength(true);

                entity.Property(e => e.Mes).HasColumnType("tinyint");

                entity.Property(e => e.NombreUsuario)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.OrigenPago)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'C'")
                    .IsFixedLength(true);

                entity.Property(e => e.Socio).HasMaxLength(50);
            });

            modelBuilder.Entity<Vgastosprogramacionjuego>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vgastosprogramacionjuego");

                entity.Property(e => e.Concepto).HasMaxLength(100);

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'A'")
                    .IsFixedLength(true);

                entity.Property(e => e.NombreUsuario)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Socio).HasMaxLength(50);
            });

            modelBuilder.Entity<Vingresosgenerales>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vingresosgenerales");

                entity.Property(e => e.Concepto).HasMaxLength(100);

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'A'")
                    .IsFixedLength(true);

                entity.Property(e => e.Mes).HasColumnType("tinyint");

                entity.Property(e => e.NombreUsuario)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.OrigenPago)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'C'")
                    .IsFixedLength(true);

                entity.Property(e => e.Socio).HasMaxLength(50);
            });

            modelBuilder.Entity<Vingresosprogramacionjuego>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vingresosprogramacionjuego");

                entity.Property(e => e.Concepto).HasMaxLength(100);

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("'A'")
                    .IsFixedLength(true);

                entity.Property(e => e.NombreUsuario)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<Vperfilpermisos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vperfilpermisos");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Eliminacion).HasColumnType("bit(1)");

                entity.Property(e => e.Escritura).HasColumnType("bit(1)");

                entity.Property(e => e.Habilitado)
                    .IsRequired()
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("b'0'");

                entity.Property(e => e.Lectura).HasColumnType("bit(1)");

                entity.Property(e => e.NombreMenu)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NombrePerfil)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<Vprogramacionjuegovendedores>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vprogramacionjuegovendedores");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Celular)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Documento)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Vrondasseries>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vrondasseries");

                entity.Property(e => e.Simbolo)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Tabla)
                    .HasMaxLength(50)
                    .HasColumnName("tabla");
            });

            modelBuilder.Entity<Vvendedoresentregacartones>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vvendedoresentregacartones");

                entity.Property(e => e.Apellidos).HasMaxLength(50);

                entity.Property(e => e.Codigo).HasMaxLength(5);

                entity.Property(e => e.IdProgramacionJuego).HasMaxLength(11);

                entity.Property(e => e.Nombres).HasMaxLength(50);

                entity.Property(e => e.SumaDeNumeroHoja)
                    .IsRequired()
                    .HasMaxLength(21)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Vvendedoresprogramacion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vvendedoresprogramacion");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Celular)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Cobrado).HasColumnType("tinyint");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Documento)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.NombreCompleto)
                    .IsRequired()
                    .HasMaxLength(101)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
