using ProjetoCallCenter.Domain.Entities;
using ProjetoCallCenter.Infra.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProjetoCallCenter.Models.Infra.Data
{
    public class DBProjetoCallCenter : DbContext, IDisposable
    {
        public DBProjetoCallCenter()
            :base("DBProjetoCallCenterDDD")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new AtendimentoConfiguration());
            modelBuilder.Configurations.Add(new CredencialConfiguration());
            modelBuilder.Configurations.Add(new CredorConfiguration());
            modelBuilder.Configurations.Add(new DevedorConfiguration());
            modelBuilder.Configurations.Add(new DividaConfiguration());
            modelBuilder.Configurations.Add(new LogConfiguration());
            modelBuilder.Configurations.Add(new NegociacaoConfiguration());
            modelBuilder.Configurations.Add(new ParcelaConfiguration());
            modelBuilder.Configurations.Add(new PerfilNegociacaoConfiguration());
            modelBuilder.Configurations.Add(new SegmentacaoConfiguration());
            modelBuilder.Configurations.Add(new StatusConfiguration());
            modelBuilder.Configurations.Add(new TelefoneConfiguration());
            modelBuilder.Configurations.Add(new TipoCredencialConfiguration());
            modelBuilder.Configurations.Add(new UsuarioConfiguration());


            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<TipoCredencial> TipoCredencial { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Credencial> Credencial { get; set; }
        public DbSet<Log> Log { get; set; }
        public DbSet<Credor> Credor { get; set; }
        public DbSet<PerfilNegociacao> PerfilNegociacao { get; set; }
        public DbSet<Segmentacao> Segmentacao { get; set; }
        public DbSet<Devedor> Devedor { get; set; }
        public DbSet<Telefone> Telefone { get; set; }
        public DbSet<Divida> Divida { get; set; }
        public DbSet<Atendimento> Atendimento { get; set; }
        public DbSet<Negociacao> Negociacao { get; set; }
        public DbSet<Parcela> Parcela { get; set; }
    }
}