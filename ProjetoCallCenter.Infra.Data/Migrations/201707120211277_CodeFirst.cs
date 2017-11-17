namespace ProjetoCallCenter.Infra.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class CodeFirst : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Atendimento",
                c => new
                    {
                        AtendimentoId = c.Int(nullable: false, identity: true),
                        UsuarioId = c.Int(nullable: false),
                        StatusId = c.Int(nullable: false),
                        DividaId = c.Int(nullable: false),
                        Descricao = c.String(nullable: false, maxLength: 100, unicode: false),
                        Data = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AtendimentoId)
                .ForeignKey("dbo.Divida", t => t.DividaId)
                .ForeignKey("dbo.Status", t => t.StatusId)
                .ForeignKey("dbo.Usuario", t => t.UsuarioId)
                .Index(t => t.UsuarioId)
                .Index(t => t.StatusId)
                .Index(t => t.DividaId);
            
            CreateTable(
                "dbo.Divida",
                c => new
                    {
                        DividaId = c.Int(nullable: false, identity: true),
                        DevedorId = c.Int(nullable: false),
                        CredorId = c.Int(nullable: false),
                        Contrato = c.String(nullable: false, maxLength: 100, unicode: false),
                        Data = c.DateTime(nullable: false),
                        Valor = c.Decimal(nullable: false, storeType: "money"),
                        Arquivo = c.String(nullable: false, maxLength: 100, unicode: false),
                        DataImportacao = c.DateTime(nullable: false),
                        StatusId = c.Int(nullable: false),
                        DataAtendimento = c.DateTime(),
                        OperadorAtendimento = c.Int(),
                    })
                .PrimaryKey(t => t.DividaId)
                .ForeignKey("dbo.Credor", t => t.CredorId)
                .ForeignKey("dbo.Devedor", t => t.DevedorId)
                .ForeignKey("dbo.Status", t => t.StatusId)
                .Index(t => t.DevedorId)
                .Index(t => new { t.CredorId, t.Contrato }, unique: true, name: "UN_Divida_Credor_Contrato")
                .Index(t => t.StatusId);
            
            CreateTable(
                "dbo.Credor",
                c => new
                    {
                        CredorId = c.Int(nullable: false, identity: true),
                        CNPJ = c.String(nullable: false, maxLength: 100, unicode: false),
                        RazaoSocial = c.String(nullable: false, maxLength: 100, unicode: false),
                        NomeFantasia = c.String(nullable: false, maxLength: 100, unicode: false),
                        Responsavel = c.String(nullable: false, maxLength: 100, unicode: false),
                        Telefone = c.String(nullable: false, maxLength: 100, unicode: false),
                        Email = c.String(nullable: false, maxLength: 100, unicode: false),
                        Logradouro = c.String(nullable: false, maxLength: 100, unicode: false),
                        Numero = c.Int(nullable: false),
                        Complemento = c.String(maxLength: 100, unicode: false),
                        Bairro = c.String(nullable: false, maxLength: 100, unicode: false),
                        Cidade = c.String(nullable: false, maxLength: 100, unicode: false),
                        UF = c.String(nullable: false, maxLength: 100, unicode: false),
                        CEP = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.CredorId)
                .Index(t => t.CNPJ, unique: true);
            
            CreateTable(
                "dbo.Devedor",
                c => new
                    {
                        DevedorId = c.Int(nullable: false, identity: true),
                        CPF = c.Long(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        Logradouro = c.String(nullable: false, maxLength: 100, unicode: false),
                        Numero = c.Int(nullable: false),
                        Complemento = c.String(maxLength: 100, unicode: false),
                        Bairro = c.String(nullable: false, maxLength: 100, unicode: false),
                        Cidade = c.String(nullable: false, maxLength: 100, unicode: false),
                        UF = c.String(nullable: false, maxLength: 100, unicode: false),
                        CEP = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.DevedorId)
                .Index(t => t.CPF, unique: true);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        StatusId = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 100, unicode: false),
                        Tipo = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.StatusId);
            
            CreateTable(
                "dbo.Negociacao",
                c => new
                    {
                        AtendimentoId = c.Int(nullable: false),
                        ValorCorrigido = c.Decimal(nullable: false, storeType: "money"),
                        ValorNegociado = c.Decimal(nullable: false, storeType: "money"),
                        Data = c.DateTime(nullable: false),
                        Status = c.String(maxLength: 100, unicode: false),
                        Email = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.AtendimentoId)
                .ForeignKey("dbo.Atendimento", t => t.AtendimentoId)
                .Index(t => t.AtendimentoId);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        UsuarioId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        Email = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.UsuarioId)
                .Index(t => t.Email, unique: true);
            
            CreateTable(
                "dbo.Credencial",
                c => new
                    {
                        UsuarioId = c.Int(nullable: false),
                        NomeUsuario = c.String(nullable: false, maxLength: 100, unicode: false),
                        Senha = c.String(nullable: false, maxLength: 100, unicode: false),
                        TipoCredencialId = c.Int(nullable: false),
                        StatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UsuarioId)
                .ForeignKey("dbo.Status", t => t.StatusId)
                .ForeignKey("dbo.TipoCredencial", t => t.TipoCredencialId)
                .ForeignKey("dbo.Usuario", t => t.UsuarioId)
                .Index(t => t.UsuarioId)
                .Index(t => t.NomeUsuario, unique: true)
                .Index(t => t.TipoCredencialId)
                .Index(t => t.StatusId);
            
            CreateTable(
                "dbo.TipoCredencial",
                c => new
                    {
                        TipoCredencialId = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.TipoCredencialId);
            
            CreateTable(
                "dbo.Log",
                c => new
                    {
                        LogId = c.Int(nullable: false, identity: true),
                        UsuarioId = c.Int(nullable: false),
                        Acao = c.String(nullable: false, maxLength: 100, unicode: false),
                        Data = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.LogId)
                .ForeignKey("dbo.Usuario", t => t.UsuarioId)
                .Index(t => t.UsuarioId);
            
            CreateTable(
                "dbo.Parcela",
                c => new
                    {
                        AtendimentoId = c.Int(nullable: false),
                        Numero = c.Int(nullable: false),
                        Valor = c.Double(nullable: false),
                        Vencimento = c.DateTime(nullable: false),
                        ValorPagamento = c.Double(),
                        DataPagamento = c.DateTime(),
                    })
                .PrimaryKey(t => new { t.AtendimentoId, t.Numero })
                .ForeignKey("dbo.Negociacao", t => t.AtendimentoId)
                .Index(t => t.AtendimentoId);
            
            CreateTable(
                "dbo.PerfilNegociacao",
                c => new
                    {
                        PerfilNegociacaoId = c.Int(nullable: false, identity: true),
                        CredorId = c.Int(nullable: false),
                        AtrasoDe = c.Int(nullable: false),
                        AtrasoAte = c.Int(nullable: false),
                        MaximoParcela = c.Int(nullable: false),
                        Juros = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Multa = c.Decimal(nullable: false, precision: 18, scale: 2),
                        JurosPorParcela = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DescontoValorPrincipal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DescontoEncargos = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValorMinimoEntrada = c.Decimal(nullable: false, storeType: "money"),
                        ValorMinimoParcela = c.Decimal(nullable: false, storeType: "money"),
                        Tipo = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.PerfilNegociacaoId)
                .ForeignKey("dbo.Credor", t => t.CredorId)
                .Index(t => t.CredorId);
            
            CreateTable(
                "dbo.Segmentacao",
                c => new
                    {
                        SegmentacaoId = c.Int(nullable: false, identity: true),
                        UsuarioId = c.Int(nullable: false),
                        CredorId = c.Int(nullable: false),
                        DiaEmAtrasoDe = c.Int(nullable: false),
                        DiaEmAtrasoAte = c.Int(nullable: false),
                        ValorDividaDe = c.Decimal(nullable: false, storeType: "money"),
                        ValorDividaAte = c.Decimal(nullable: false, storeType: "money"),
                    })
                .PrimaryKey(t => t.SegmentacaoId)
                .ForeignKey("dbo.Credor", t => t.CredorId)
                .ForeignKey("dbo.Usuario", t => t.UsuarioId)
                .Index(t => t.UsuarioId)
                .Index(t => t.CredorId);
            
            CreateTable(
                "dbo.Telefone",
                c => new
                    {
                        TelefoneId = c.Int(nullable: false, identity: true),
                        DevedorId = c.Int(nullable: false),
                        Tipo = c.String(nullable: false, maxLength: 100, unicode: false),
                        Descricao = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.TelefoneId)
                .ForeignKey("dbo.Devedor", t => t.DevedorId)
                .Index(t => t.DevedorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Telefone", "DevedorId", "dbo.Devedor");
            DropForeignKey("dbo.Segmentacao", "UsuarioId", "dbo.Usuario");
            DropForeignKey("dbo.Segmentacao", "CredorId", "dbo.Credor");
            DropForeignKey("dbo.PerfilNegociacao", "CredorId", "dbo.Credor");
            DropForeignKey("dbo.Parcela", "AtendimentoId", "dbo.Negociacao");
            DropForeignKey("dbo.Log", "UsuarioId", "dbo.Usuario");
            DropForeignKey("dbo.Atendimento", "UsuarioId", "dbo.Usuario");
            DropForeignKey("dbo.Credencial", "UsuarioId", "dbo.Usuario");
            DropForeignKey("dbo.Credencial", "TipoCredencialId", "dbo.TipoCredencial");
            DropForeignKey("dbo.Credencial", "StatusId", "dbo.Status");
            DropForeignKey("dbo.Atendimento", "StatusId", "dbo.Status");
            DropForeignKey("dbo.Negociacao", "AtendimentoId", "dbo.Atendimento");
            DropForeignKey("dbo.Atendimento", "DividaId", "dbo.Divida");
            DropForeignKey("dbo.Divida", "StatusId", "dbo.Status");
            DropForeignKey("dbo.Divida", "DevedorId", "dbo.Devedor");
            DropForeignKey("dbo.Divida", "CredorId", "dbo.Credor");
            DropIndex("dbo.Telefone", new[] { "DevedorId" });
            DropIndex("dbo.Segmentacao", new[] { "CredorId" });
            DropIndex("dbo.Segmentacao", new[] { "UsuarioId" });
            DropIndex("dbo.PerfilNegociacao", new[] { "CredorId" });
            DropIndex("dbo.Parcela", new[] { "AtendimentoId" });
            DropIndex("dbo.Log", new[] { "UsuarioId" });
            DropIndex("dbo.Credencial", new[] { "StatusId" });
            DropIndex("dbo.Credencial", new[] { "TipoCredencialId" });
            DropIndex("dbo.Credencial", new[] { "NomeUsuario" });
            DropIndex("dbo.Credencial", new[] { "UsuarioId" });
            DropIndex("dbo.Usuario", new[] { "Email" });
            DropIndex("dbo.Negociacao", new[] { "AtendimentoId" });
            DropIndex("dbo.Devedor", new[] { "CPF" });
            DropIndex("dbo.Credor", new[] { "CNPJ" });
            DropIndex("dbo.Divida", new[] { "StatusId" });
            DropIndex("dbo.Divida", "UN_Divida_Credor_Contrato");
            DropIndex("dbo.Divida", new[] { "DevedorId" });
            DropIndex("dbo.Atendimento", new[] { "DividaId" });
            DropIndex("dbo.Atendimento", new[] { "StatusId" });
            DropIndex("dbo.Atendimento", new[] { "UsuarioId" });
            DropTable("dbo.Telefone");
            DropTable("dbo.Segmentacao");
            DropTable("dbo.PerfilNegociacao");
            DropTable("dbo.Parcela");
            DropTable("dbo.Log");
            DropTable("dbo.TipoCredencial");
            DropTable("dbo.Credencial");
            DropTable("dbo.Usuario");
            DropTable("dbo.Negociacao");
            DropTable("dbo.Status");
            DropTable("dbo.Devedor");
            DropTable("dbo.Credor");
            DropTable("dbo.Divida");
            DropTable("dbo.Atendimento");
        }
    }
}
