namespace ProjetoCallCenter.Infra.Data.Migrations
{
    using Domain.Entities;
    using Models.Infra.Data;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<DBProjetoCallCenter>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DBProjetoCallCenter context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Usuario.AddOrUpdate(
                new Usuario {
                    UsuarioId = 1,
                    Nome = "Administrador",
                    Email = "Admin@admin.com.br",
                    Credencial = new Credencial { NomeUsuario = "admin",
                        UsuarioId = 1,
                        Senha = "admin",
                        StatusId = 1,
                        TipoCredencialId = 1,
                        TipoCredencial =  new TipoCredencial { TipoCredencialId = 1, Descricao = "Administrador" },
                        Status = new Status { StatusId = 1, Descricao = "Privado", Tipo = "Usuario" }
                    }
                }

            );
            context.Status.AddOrUpdate(
                new Status { Descricao = "Ativo", Tipo = "Usuario" },
                new Status { Descricao = "Inativo", Tipo = "Usuario" }
                );
            context.TipoCredencial.AddOrUpdate(
                new TipoCredencial { Descricao = "Gerente" },
                new TipoCredencial { Descricao = "Supervisor" },
                new TipoCredencial { Descricao = "Operador" }
                );
            context.Devedor.AddOrUpdate(
                new Devedor {
                    CPF = 17783010881,
                    Nome = "RICARDO DA SILVA",
                    Logradouro = "R CLARO MACHADO DE OLIVEIRA NETO",
                    Numero = 186,
                    Complemento = "",
                    Bairro = "JARDIM VENEZA",
                    Cidade = "MOGI DAS CRUZES",
                    UF = "SP",
                    CEP = "08715-545",
                    Telefones = new List<Telefone>()
                    {
                        new Telefone { Descricao="11-4799-6928", Tipo = "Residencial"},
                        new Telefone { Descricao="11-94746-6130",Tipo = "Outros"}
                    },
                    Dividas = new List<Divida>() {
                        new Divida{
                            Arquivo = "Extra.txt",
                            Contrato = "71377",
                            Data = new System.DateTime(2010,04,11),
                            Valor = decimal.Parse("410.99"),
                            DataImportacao = new System.DateTime(2017,08,22),
                            CredorId = 1
                        }
                    }
                }
                );

        }
    }
}
