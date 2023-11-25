using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Model;

namespace ProyectoFinal.Context;

public partial class ProyectoFinalContext : DbContext
{
    public ProyectoFinalContext()
    {

    }

    public ProyectoFinalContext(DbContextOptions<ProyectoFinalContext> options)
        : base(options)
    {

    }

    public virtual DbSet<AplicarVacuna> AplicarVacunas { get; set; }

    public virtual DbSet<Cabina> Cabinas { get; set; }

    public virtual DbSet<Citum> Citas { get; set; }

    public virtual DbSet<Ciudadano> Ciudadanos { get; set; }

    public virtual DbSet<Comorbilidad> Comorbilidad { get; set; }

    public virtual DbSet<Discapacidad> Discapacidad { get; set; }

    public virtual DbSet<Dosi> Dosis { get; set; }

    public virtual DbSet<EfectoSecundario> EfectosSecundarios { get; set; }

    public virtual DbSet<EnfermedadCronica> EnfermedadesCronicas { get; set; }

    public virtual DbSet<Establecimiento> Establecimientos { get; set; }

    public virtual DbSet<Extranjero> Extranjeros { get; set; }

    public virtual DbSet<Genero> Generos { get; set; }

    public virtual DbSet<Gestor> Gestores { get; set; }

    public virtual DbSet<InicioSesion> InicioSesiones { get; set; }

    public virtual DbSet<InstitucionEsencial> InstitucionesEsenciales { get; set; }

    public virtual DbSet<Menor> Menores { get; set; }

    public virtual DbSet<Nacionalidad> Nacionalidades { get; set; }

    public virtual DbSet<Vacuna> Vacunas { get; set; }

    public virtual DbSet<Vacunador> Vacunadores { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ANDREA; Database=ProyectoFinal_DB; Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AplicarVacuna>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__APLICAR___3214EC271B19E0AF");

            entity.ToTable("APLICAR_VACUNA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Fecha)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fecha");
            entity.Property(e => e.Hora)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("hora");
            entity.Property(e => e.IdCiudadano).HasColumnName("id_ciudadano");
            entity.Property(e => e.IdDosis).HasColumnName("id_dosis");
            entity.Property(e => e.IdEfectoSecundario).HasColumnName("id_efecto_secundario");
            entity.Property(e => e.IdExtranjero).HasColumnName("id_extranjero");
            entity.Property(e => e.IdGestor).HasColumnName("id_gestor");
            entity.Property(e => e.IdMenor).HasColumnName("id_menor");
            entity.Property(e => e.IdVacuna).HasColumnName("id_vacuna");
            entity.Property(e => e.IdVacunador).HasColumnName("id_vacunador");

            entity.HasOne(d => d.IdCiudadanoNavigation).WithMany(p => p.AplicarVacunas)
                .HasForeignKey(d => d.IdCiudadano)
                .HasConstraintName("FK__APLICAR_V__id_ci__778AC167");

            entity.HasOne(d => d.IdDosisNavigation).WithMany(p => p.AplicarVacunas)
                .HasForeignKey(d => d.IdDosis)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__APLICAR_V__id_do__72C60C4A");

            entity.HasOne(d => d.IdEfectoSecundarioNavigation).WithMany(p => p.AplicarVacunas)
                .HasForeignKey(d => d.IdEfectoSecundario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__APLICAR_V__id_ef__74AE54BC");

            entity.HasOne(d => d.IdExtranjeroNavigation).WithMany(p => p.AplicarVacunas)
                .HasForeignKey(d => d.IdExtranjero)
                .HasConstraintName("FK__APLICAR_V__id_ex__797309D9");

            entity.HasOne(d => d.IdGestorNavigation).WithMany(p => p.AplicarVacunas)
                .HasForeignKey(d => d.IdGestor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__APLICAR_V__id_ge__76969D2E");

            entity.HasOne(d => d.IdMenorNavigation).WithMany(p => p.AplicarVacunas)
                .HasForeignKey(d => d.IdMenor)
                .HasConstraintName("FK__APLICAR_V__id_me__787EE5A0");

            entity.HasOne(d => d.IdVacunaNavigation).WithMany(p => p.AplicarVacunas)
                .HasForeignKey(d => d.IdVacuna)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__APLICAR_V__id_va__73BA3083");

            entity.HasOne(d => d.IdVacunadorNavigation).WithMany(p => p.AplicarVacunas)
                .HasForeignKey(d => d.IdVacunador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__APLICAR_V__id_va__75A278F5");
        });

        modelBuilder.Entity<Cabina>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CABINA__3214EC271423249C");

            entity.ToTable("CABINA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("correo_electronico");
            entity.Property(e => e.Direccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(14)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<Citum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CITA__3214EC2784FA9B5E");

            entity.ToTable("CITA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Fecha)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fecha");
            entity.Property(e => e.Hora)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("hora");
            entity.Property(e => e.IdCiudadano).HasColumnName("id_ciudadano");
            entity.Property(e => e.IdEstablecimiento).HasColumnName("id_establecimiento");
            entity.Property(e => e.IdExtranjero).HasColumnName("id_extranjero");
            entity.Property(e => e.IdGestor).HasColumnName("id_gestor");
            entity.Property(e => e.IdMenor).HasColumnName("id_menor");

            entity.HasOne(d => d.IdCiudadanoNavigation).WithMany(p => p.Cita)
                .HasForeignKey(d => d.IdCiudadano)
                .HasConstraintName("FK__CITA__id_ciudada__5BE2A6F2");

            entity.HasOne(d => d.IdEstablecimientoNavigation).WithMany(p => p.Cita)
                .HasForeignKey(d => d.IdEstablecimiento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CITA__id_estable__59FA5E80");

            entity.HasOne(d => d.IdExtranjeroNavigation).WithMany(p => p.Cita)
                .HasForeignKey(d => d.IdExtranjero)
                .HasConstraintName("FK__CITA__id_extranj__5DCAEF64");

            entity.HasOne(d => d.IdGestorNavigation).WithMany(p => p.Cita)
                .HasForeignKey(d => d.IdGestor)
                .HasConstraintName("FK__CITA__id_gestor__5AEE82B9");

            entity.HasOne(d => d.IdMenorNavigation).WithMany(p => p.Cita)
                .HasForeignKey(d => d.IdMenor)
                .HasConstraintName("FK__CITA__id_menor__5CD6CB2B");
        });

        modelBuilder.Entity<Ciudadano>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CIUDADAN__3214EC27FD5442BE");

            entity.ToTable("CIUDADANO");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellidos");
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("correo_electronico");
            entity.Property(e => e.Direccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Dui)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DUI");
            entity.Property(e => e.FechaDeNacimiento)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fecha_de_nacimiento");
            entity.Property(e => e.IdComorbilidad).HasColumnName("id_comorbilidad");
            entity.Property(e => e.IdDiscapacidad).HasColumnName("id_discapacidad");
            entity.Property(e => e.IdEnfermedadCronica).HasColumnName("id_enfermedad_cronica");
            entity.Property(e => e.IdGenero).HasColumnName("id_genero");
            entity.Property(e => e.IdInstitucionEsencial).HasColumnName("id_institucion_esencial");
            entity.Property(e => e.Nombres)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombres");
            entity.Property(e => e.Telefono)
                .HasMaxLength(14)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("telefono");

            entity.HasOne(d => d.IdComorbilidadNavigation).WithMany(p => p.Ciudadanos)
                .HasForeignKey(d => d.IdComorbilidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CIUDADANO__id_co__656C112C");

            entity.HasOne(d => d.IdDiscapacidadNavigation).WithMany(p => p.Ciudadanos)
                .HasForeignKey(d => d.IdDiscapacidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CIUDADANO__id_di__6477ECF3");

            entity.HasOne(d => d.IdEnfermedadCronicaNavigation).WithMany(p => p.Ciudadanos)
                .HasForeignKey(d => d.IdEnfermedadCronica)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CIUDADANO__id_en__68487DD7");

            entity.HasOne(d => d.IdGeneroNavigation).WithMany(p => p.Ciudadanos)
                .HasForeignKey(d => d.IdGenero)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CIUDADANO__id_ge__66603565");

            entity.HasOne(d => d.IdInstitucionEsencialNavigation).WithMany(p => p.Ciudadanos)
                .HasForeignKey(d => d.IdInstitucionEsencial)
                .HasConstraintName("FK__CIUDADANO__id_in__6754599E");
        });

        modelBuilder.Entity<Comorbilidad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__COMORBIL__3214EC27DFDCFAA1");

            entity.ToTable("COMORBILIDAD");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Comorbilidad1)
                .HasMaxLength(14)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("comorbilidad");
        });

        modelBuilder.Entity<Discapacidad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DISCAPAC__3214EC2708A51D93");

            entity.ToTable("DISCAPACIDAD");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Discapacidad1)
                .HasMaxLength(14)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("discapacidad");
        });

        modelBuilder.Entity<Dosi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DOSIS__3214EC27DC857137");

            entity.ToTable("DOSIS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<EfectoSecundario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EFECTO_S__3214EC2726709CD2");

            entity.ToTable("EFECTO_SECUNDARIO");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<EnfermedadCronica>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ENFERMED__3214EC27AA1B85C3");

            entity.ToTable("ENFERMEDAD_CRONICA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Establecimiento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ESTABLEC__3214EC27FA4B5863");

            entity.ToTable("ESTABLECIMIENTO");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Extranjero>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EXTRANJE__3214EC274D1FD1A4");

            entity.ToTable("EXTRANJERO");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellidos");
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("correo_electronico");
            entity.Property(e => e.Direccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.FechaDeNacimiento)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fecha_de_nacimiento");
            entity.Property(e => e.IdComorbilidad).HasColumnName("id_comorbilidad");
            entity.Property(e => e.IdDiscapacidad).HasColumnName("id_discapacidad");
            entity.Property(e => e.IdEnfermedadCronica).HasColumnName("id_enfermedad_cronica");
            entity.Property(e => e.IdGenero).HasColumnName("id_genero");
            entity.Property(e => e.IdNacionalidad).HasColumnName("id_nacionalidad");
            entity.Property(e => e.Nombres)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombres");
            entity.Property(e => e.Pasaporte)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("pasaporte");
            entity.Property(e => e.Telefono)
                .HasMaxLength(14)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("telefono");

            entity.HasOne(d => d.IdComorbilidadNavigation).WithMany(p => p.Extranjeros)
                .HasForeignKey(d => d.IdComorbilidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EXTRANJER__id_co__6EF57B66");

            entity.HasOne(d => d.IdDiscapacidadNavigation).WithMany(p => p.Extranjeros)
                .HasForeignKey(d => d.IdDiscapacidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EXTRANJER__id_di__6E01572D");

            entity.HasOne(d => d.IdEnfermedadCronicaNavigation).WithMany(p => p.Extranjeros)
                .HasForeignKey(d => d.IdEnfermedadCronica)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EXTRANJER__id_en__70DDC3D8");

            entity.HasOne(d => d.IdGeneroNavigation).WithMany(p => p.Extranjeros)
                .HasForeignKey(d => d.IdGenero)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EXTRANJER__id_ge__6FE99F9F");

            entity.HasOne(d => d.IdNacionalidadNavigation).WithMany(p => p.Extranjeros)
                .HasForeignKey(d => d.IdNacionalidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__EXTRANJER__id_na__71D1E811");
        });

        modelBuilder.Entity<Genero>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GENERO__3214EC27F2382ED9");

            entity.ToTable("GENERO");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Genero1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("genero");
        });

        modelBuilder.Entity<Gestor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GESTOR__3214EC27CC696744");

            entity.ToTable("GESTOR");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellidos");
            entity.Property(e => e.Contraseña)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("contraseña");
            entity.Property(e => e.CorreoInstitucional)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("correo_institucional");
            entity.Property(e => e.Direccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Dui)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DUI");
            entity.Property(e => e.FechaDeNacimiento)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fecha_de_nacimiento");
            entity.Property(e => e.IdComorbilidad).HasColumnName("id_comorbilidad");
            entity.Property(e => e.IdDiscapacidad).HasColumnName("id_discapacidad");
            entity.Property(e => e.IdGenero).HasColumnName("id_genero");
            entity.Property(e => e.Nombres)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombres");
            entity.Property(e => e.Telefono)
                .HasMaxLength(14)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("telefono");
            entity.Property(e => e.Usuario)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario");

            entity.HasOne(d => d.IdComorbilidadNavigation).WithMany(p => p.Gestors)
                .HasForeignKey(d => d.IdComorbilidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GESTOR__id_comor__5FB337D6");

            entity.HasOne(d => d.IdDiscapacidadNavigation).WithMany(p => p.Gestors)
                .HasForeignKey(d => d.IdDiscapacidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GESTOR__id_disca__5EBF139D");

            entity.HasOne(d => d.IdGeneroNavigation).WithMany(p => p.Gestors)
                .HasForeignKey(d => d.IdGenero)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GESTOR__id_gener__60A75C0F");
        });

        modelBuilder.Entity<InicioSesion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__INICIO_S__3214EC2793185F38");

            entity.ToTable("INICIO_SESION");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FechaHora)
                .HasColumnType("datetime")
                .HasColumnName("fecha_hora");
            entity.Property(e => e.IdCabina).HasColumnName("id_cabina");
            entity.Property(e => e.IdGestor).HasColumnName("id_gestor");

            entity.HasOne(d => d.IdCabinaNavigation).WithMany(p => p.InicioSesions)
                .HasForeignKey(d => d.IdCabina)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__INICIO_SE__id_ca__7B5B524B");

            entity.HasOne(d => d.IdGestorNavigation).WithMany(p => p.InicioSesions)
                .HasForeignKey(d => d.IdGestor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__INICIO_SE__id_ge__7A672E12");
        });

        modelBuilder.Entity<InstitucionEsencial>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__INSTITUC__3214EC27332FDF74");

            entity.ToTable("INSTITUCION_ESENCIAL");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Menor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MENOR__3214EC273FAB832B");

            entity.ToTable("MENOR");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellidos");
            entity.Property(e => e.CorreoElectronicoResponsable)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("correo_electronico_responsable");
            entity.Property(e => e.DireccionResponsable)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("direccion_responsable");
            entity.Property(e => e.DuiResponsable)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DUI_responsable");
            entity.Property(e => e.FechaDeNacimiento)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fecha_de_nacimiento");
            entity.Property(e => e.IdComorbilidad).HasColumnName("id_comorbilidad");
            entity.Property(e => e.IdDiscapacidad).HasColumnName("id_discapacidad");
            entity.Property(e => e.IdEnfermedadCronica).HasColumnName("id_enfermedad_cronica");
            entity.Property(e => e.IdGenero).HasColumnName("id_genero");
            entity.Property(e => e.IdInstitucionEsencialResponsable).HasColumnName("id_institucion_esencial_responsable");
            entity.Property(e => e.Nombres)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombres");
            entity.Property(e => e.TelefonoResponsable)
                .HasMaxLength(14)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("telefono_responsable");

            entity.HasOne(d => d.IdComorbilidadNavigation).WithMany(p => p.Menors)
                .HasForeignKey(d => d.IdComorbilidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MENOR__id_comorb__6A30C649");

            entity.HasOne(d => d.IdDiscapacidadNavigation).WithMany(p => p.Menors)
                .HasForeignKey(d => d.IdDiscapacidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MENOR__id_discap__693CA210");

            entity.HasOne(d => d.IdEnfermedadCronicaNavigation).WithMany(p => p.Menors)
                .HasForeignKey(d => d.IdEnfermedadCronica)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MENOR__id_enferm__6D0D32F4");

            entity.HasOne(d => d.IdGeneroNavigation).WithMany(p => p.Menors)
                .HasForeignKey(d => d.IdGenero)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MENOR__id_genero__6B24EA82");

            entity.HasOne(d => d.IdInstitucionEsencialResponsableNavigation).WithMany(p => p.Menors)
                .HasForeignKey(d => d.IdInstitucionEsencialResponsable)
                .HasConstraintName("FK__MENOR__id_instit__6C190EBB");
        });

        modelBuilder.Entity<Nacionalidad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NACIONAL__3214EC273E05EA34");

            entity.ToTable("NACIONALIDAD");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nacionalidad1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nacionalidad");
        });

        modelBuilder.Entity<Vacuna>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VACUNA__3214EC2779E30D44");

            entity.ToTable("VACUNA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Vacunador>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VACUNADO__3214EC27165BF41F");

            entity.ToTable("VACUNADOR");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellidos");
            entity.Property(e => e.CorreoInstitucional)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("correo_institucional");
            entity.Property(e => e.Direccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Dui)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("DUI");
            entity.Property(e => e.FechaDeNacimiento)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fecha_de_nacimiento");
            entity.Property(e => e.IdComorbilidad).HasColumnName("id_comorbilidad");
            entity.Property(e => e.IdDiscapacidad).HasColumnName("id_discapacidad");
            entity.Property(e => e.IdGenero).HasColumnName("id_genero");
            entity.Property(e => e.Nombres)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombres");
            entity.Property(e => e.Telefono)
                .HasMaxLength(14)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("telefono");

            entity.HasOne(d => d.IdComorbilidadNavigation).WithMany(p => p.Vacunadors)
                .HasForeignKey(d => d.IdComorbilidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__VACUNADOR__id_co__628FA481");

            entity.HasOne(d => d.IdDiscapacidadNavigation).WithMany(p => p.Vacunadors)
                .HasForeignKey(d => d.IdDiscapacidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__VACUNADOR__id_di__619B8048");

            entity.HasOne(d => d.IdGeneroNavigation).WithMany(p => p.Vacunadors)
                .HasForeignKey(d => d.IdGenero)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__VACUNADOR__id_ge__6383C8BA");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
