using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Honcizek.DAL.Models
{
    public partial class honcizekContext : DbContext
    {
        public honcizekContext()
        {
        }

        public honcizekContext(DbContextOptions<honcizekContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Localidades> Localidades { get; set; }
        public virtual DbSet<Paises> Paises { get; set; }
        public virtual DbSet<PartesDeTrabajo> PartesDeTrabajo { get; set; }
        public virtual DbSet<Provincias> Provincias { get; set; }
        public virtual DbSet<Proyectos> Proyectos { get; set; }
        public virtual DbSet<ProyectosParticipantes> ProyectosParticipantes { get; set; }
        public virtual DbSet<Suscripciones> Suscripciones { get; set; }
        public virtual DbSet<Tareas> Tareas { get; set; }
        public virtual DbSet<Tickets> Tickets { get; set; }
        public virtual DbSet<Trabajos> Trabajos { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=root;database=honcizek");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.ToTable("clientes");

                entity.HasIndex(e => e.LocalidadId)
                    .HasName("FK_clientes_localidades");

                entity.HasIndex(e => e.Login)
                    .HasName("login")
                    .IsUnique();

                entity.HasIndex(e => e.PaisId)
                    .HasName("FK_clientes_paises");

                entity.HasIndex(e => e.ProvinciaId)
                    .HasName("FK_clientes_provincias");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Apellidos)
                    .HasColumnName("apellidos")
                    .HasMaxLength(250);

                entity.Property(e => e.Clave)
                    .HasColumnName("clave")
                    .HasMaxLength(100);

                entity.Property(e => e.Cp)
                    .HasColumnName("cp")
                    .HasMaxLength(10);

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasMaxLength(250);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(150);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnName("fecha_registro")
                    .HasColumnType("date");

                entity.Property(e => e.LocalidadId)
                    .HasColumnName("localidad_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Login)
                    .HasColumnName("login")
                    .HasMaxLength(50);

                entity.Property(e => e.Movil)
                    .HasColumnName("movil")
                    .HasMaxLength(50);

                entity.Property(e => e.Nifcif)
                    .HasColumnName("nifcif")
                    .HasMaxLength(20);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(250);

                entity.Property(e => e.Observaciones).HasColumnName("observaciones");

                entity.Property(e => e.PaisId)
                    .HasColumnName("pais_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProvinciaId)
                    .HasColumnName("provincia_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RazonSocial)
                    .HasColumnName("razon_social")
                    .HasMaxLength(250);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(50);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasColumnType("enum('Empresa','Persona')")
                    .HasDefaultValueSql("'Empresa'");

                entity.HasOne(d => d.Localidad)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.LocalidadId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_clientes_localidades");

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.PaisId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_clientes_paises");

                entity.HasOne(d => d.Provincia)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.ProvinciaId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_clientes_provincias");
            });

            modelBuilder.Entity<Localidades>(entity =>
            {
                entity.ToTable("localidades");

                entity.HasIndex(e => e.ProvinciaId)
                    .HasName("FK_localidades_provincias");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ProvinciaId)
                    .HasColumnName("provincia_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Provincia)
                    .WithMany(p => p.Localidades)
                    .HasForeignKey(d => d.ProvinciaId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("provincia_id");
            });

            modelBuilder.Entity<Paises>(entity =>
            {
                entity.ToTable("paises");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(80)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<PartesDeTrabajo>(entity =>
            {
                entity.ToTable("partes_de_trabajo");

                entity.HasIndex(e => e.AgenteId)
                    .HasName("partes_usuarios");

                entity.HasIndex(e => e.TicketId)
                    .HasName("partes_tickets");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AgenteId)
                    .HasColumnName("agente_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContactoNombre)
                    .IsRequired()
                    .HasColumnName("contacto_nombre")
                    .HasMaxLength(250);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.Hora)
                    .IsRequired()
                    .HasColumnName("hora")
                    .HasMaxLength(10);

                entity.Property(e => e.Horas)
                    .HasColumnName("horas")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Minutos)
                    .HasColumnName("minutos")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(150);

                entity.Property(e => e.TicketId)
                    .HasColumnName("ticket_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Tiempo)
                    .HasColumnName("tiempo")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Agente)
                    .WithMany(p => p.PartesDeTrabajo)
                    .HasForeignKey(d => d.AgenteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("partes_usuarios");

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.PartesDeTrabajo)
                    .HasForeignKey(d => d.TicketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("partes_tickets");
            });

            modelBuilder.Entity<Provincias>(entity =>
            {
                entity.ToTable("provincias");

                entity.HasIndex(e => e.PaisId)
                    .HasName("provincias_pais");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre");

                entity.Property(e => e.PaisId)
                    .HasColumnName("pais_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.Provincias)
                    .HasForeignKey(d => d.PaisId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("provincias_pais");
            });

            modelBuilder.Entity<Proyectos>(entity =>
            {
                entity.ToTable("proyectos");

                entity.HasIndex(e => e.ClienteId)
                    .HasName("cliente_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClienteId)
                    .HasColumnName("cliente_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.DescripcionDesarrollo).HasColumnName("descripcion_desarrollo");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasColumnType("enum('Pendiente','En curso','Finalizado')");

                entity.Property(e => e.Fase)
                    .IsRequired()
                    .HasColumnName("fase")
                    .HasColumnType("enum('Analisis','Diseño','Maquetacion','Desarrollo','Pruebas internas','Pruebas cliente','Implantacion')")
                    .HasDefaultValueSql("'Analisis'");

                entity.Property(e => e.FechaFinPrevista)
                    .HasColumnName("fecha_fin_prevista")
                    .HasColumnType("date");

                entity.Property(e => e.FechaFinReal)
                    .HasColumnName("fecha_fin_real")
                    .HasColumnType("date");

                entity.Property(e => e.FechaInicio)
                    .HasColumnName("fecha_inicio")
                    .HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnName("fecha_registro")
                    .HasColumnType("date");

                entity.Property(e => e.HorasInternasPrevistas)
                    .HasColumnName("horas_internas_previstas")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(250);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasColumnType("enum('Cliente','Interno')");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Proyectos)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cliente_id");
            });

            modelBuilder.Entity<ProyectosParticipantes>(entity =>
            {
                entity.ToTable("proyectos_participantes");

                entity.HasIndex(e => e.ProyectoId)
                    .HasName("proyecto_id");

                entity.HasIndex(e => e.UsuarioId)
                    .HasName("usuario_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProyectoId)
                    .HasColumnName("proyecto_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UsuarioId)
                    .HasColumnName("usuario_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Proyecto)
                    .WithMany(p => p.ProyectosParticipantes)
                    .HasForeignKey(d => d.ProyectoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("proyecto_id");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.ProyectosParticipantes)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("usuario_id");
            });

            modelBuilder.Entity<Suscripciones>(entity =>
            {
                entity.ToTable("suscripciones");

                entity.HasIndex(e => e.AgenteId)
                    .HasName("FK_suscripciones_usuarios");

                entity.HasIndex(e => e.ClienteId)
                    .HasName("cliente_id");

                entity.HasIndex(e => e.ProyectoId)
                    .HasName("suscripciones_proyectos");

                entity.HasIndex(e => e.Tipo)
                    .HasName("sucripciones_servicios");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AgenteId)
                    .HasColumnName("agente_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClienteId)
                    .HasColumnName("cliente_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FechaDesde)
                    .HasColumnName("fecha_desde")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHasta)
                    .HasColumnName("fecha_hasta")
                    .HasColumnType("date");

                entity.Property(e => e.Observaciones).HasColumnName("observaciones");

                entity.Property(e => e.Periodicidad)
                    .IsRequired()
                    .HasColumnName("periodicidad")
                    .HasColumnType("enum('Anual','Mensual','Trimestral','Semestral','Abierta')");

                entity.Property(e => e.PrecioAlta)
                    .HasColumnName("precio_alta")
                    .HasColumnType("decimal(12,2)");

                entity.Property(e => e.PrecioPeriodo)
                    .HasColumnName("precio_periodo")
                    .HasColumnType("decimal(12,2)");

                entity.Property(e => e.ProyectoId)
                    .HasColumnName("proyecto_id")
                    .HasColumnType("int(11)")
                    .HasComment("Se debe permitir NULL ya que no siempre habrá un proyecto asociado a una suscripción");

                entity.Property(e => e.Renovacion)
                    .HasColumnName("renovacion")
                    .HasColumnType("int(1)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasColumnType("enum('Y','N')")
                    .HasDefaultValueSql("'Y'");

                entity.HasOne(d => d.Agente)
                    .WithMany(p => p.Suscripciones)
                    .HasForeignKey(d => d.AgenteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_suscripciones_usuarios");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Suscripciones)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("suscripciones_clientes");

                entity.HasOne(d => d.Proyecto)
                    .WithMany(p => p.Suscripciones)
                    .HasForeignKey(d => d.ProyectoId)
                    .HasConstraintName("suscripciones_proyectos");
            });

            modelBuilder.Entity<Tareas>(entity =>
            {
                entity.ToTable("tareas");

                entity.HasIndex(e => e.ClienteId)
                    .HasName("FK_tareas_clientes");

                entity.HasIndex(e => e.TrabajoId)
                    .HasName("trabajo_id");

                entity.HasIndex(e => e.UsuarioId)
                    .HasName("tareas_usuarios");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClienteId)
                    .HasColumnName("cliente_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasColumnType("enum('Pendiente','En curso','Finalizada')");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasColumnType("date");

                entity.Property(e => e.HorasPrevistas)
                    .HasColumnName("horas_previstas")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MinutosPrevistos)
                    .HasColumnName("minutos_previstos")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(250);

                entity.Property(e => e.TiempoPrevisto)
                    .HasColumnName("tiempo_previsto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TrabajoId)
                    .HasColumnName("trabajo_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UsuarioId)
                    .HasColumnName("usuario_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Tareas)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tareas_clientes");

                entity.HasOne(d => d.Trabajo)
                    .WithMany(p => p.Tareas)
                    .HasForeignKey(d => d.TrabajoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("trabajo_id");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Tareas)
                    .HasForeignKey(d => d.UsuarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tareas_usuarios");
            });

            modelBuilder.Entity<Tickets>(entity =>
            {
                entity.ToTable("tickets");

                entity.HasIndex(e => e.AgenteId)
                    .HasName("FK_tickets_usuarios");

                entity.HasIndex(e => e.ClienteId)
                    .HasName("FK_tickets_clientes");

                entity.HasIndex(e => e.SuscripcionId)
                    .HasName("tickets_suscripciones");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AgenteId)
                    .HasColumnName("agente_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClienteId)
                    .HasColumnName("cliente_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContactoNombre)
                    .IsRequired()
                    .HasColumnName("contacto_nombre")
                    .HasMaxLength(250);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasColumnType("enum('Pendiente','En proceso','Finalizado','Cancelado')");

                entity.Property(e => e.FechaFinalizacion)
                    .HasColumnName("fecha_finalizacion")
                    .HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnName("fecha_registro")
                    .HasColumnType("date");

                entity.Property(e => e.HoraFinalizacion)
                    .HasColumnName("hora_finalizacion")
                    .HasMaxLength(50);

                entity.Property(e => e.HoraRegistro)
                    .IsRequired()
                    .HasColumnName("hora_registro")
                    .HasMaxLength(50);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(250);

                entity.Property(e => e.SuscripcionId)
                    .HasColumnName("suscripcion_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Agente)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.AgenteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tickets_usuarios");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tickets_clientes");

                entity.HasOne(d => d.Suscripcion)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.SuscripcionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tickets_suscripciones");
            });

            modelBuilder.Entity<Trabajos>(entity =>
            {
                entity.ToTable("trabajos");

                entity.HasIndex(e => e.ProyectoId)
                    .HasName("trabajos_proyectos");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(250);

                entity.Property(e => e.ProyectoId)
                    .HasColumnName("proyecto_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Proyecto)
                    .WithMany(p => p.Trabajos)
                    .HasForeignKey(d => d.ProyectoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("trabajos_proyectos");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.ToTable("usuarios");

                entity.HasIndex(e => e.Login)
                    .HasName("login")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Apellidos)
                    .HasColumnName("apellidos")
                    .HasMaxLength(45);

                entity.Property(e => e.Clave)
                    .HasColumnName("clave")
                    .HasMaxLength(100);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100);

                entity.Property(e => e.Login)
                    .HasColumnName("login")
                    .HasMaxLength(45);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(100);

                entity.Property(e => e.Puesto)
                    .HasColumnName("puesto")
                    .HasColumnType("enum('Administrador','Programador','Cliente')");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
