using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace advise.webapi.infrastructure.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(100)", nullable: false),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(100)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "varchar(100)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "varchar(100)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(100)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar(100)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Corretores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Telefone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deletado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corretores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Inquilinos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Telefone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deletado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inquilinos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proprietarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Telefone = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deletado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proprietarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "varchar(100)", nullable: false),
                    ClaimType = table.Column<string>(type: "varchar(100)", nullable: true),
                    ClaimValue = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "varchar(100)", nullable: false),
                    ClaimType = table.Column<string>(type: "varchar(100)", nullable: true),
                    ClaimValue = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(100)", nullable: false),
                    ProviderKey = table.Column<string>(type: "varchar(100)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "varchar(100)", nullable: true),
                    UserId = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(100)", nullable: false),
                    RoleId = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(100)", nullable: false),
                    LoginProvider = table.Column<string>(type: "varchar(100)", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false),
                    Value = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CorretorInquilinoContatos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DescricaoContato = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    CorretorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InquilinoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deletado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorretorInquilinoContatos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CorretorInquilinoContatos_Corretores_CorretorId",
                        column: x => x.CorretorId,
                        principalTable: "Corretores",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CorretorInquilinoContatos_Inquilinos_InquilinoId",
                        column: x => x.InquilinoId,
                        principalTable: "Inquilinos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CorretorProprietarioContatos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DescricaoContato = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    ProprietarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CorretorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deletado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorretorProprietarioContatos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CorretorProprietarioContatos_Corretores_CorretorId",
                        column: x => x.CorretorId,
                        principalTable: "Corretores",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CorretorProprietarioContatos_Proprietarios_ProprietarioId",
                        column: x => x.ProprietarioId,
                        principalTable: "Proprietarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Imoveis",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QtdeQuartos = table.Column<int>(type: "int", nullable: false),
                    QtdeBanheiros = table.Column<int>(type: "int", nullable: false),
                    QtdeVagasGaragem = table.Column<int>(type: "int", nullable: false),
                    TipoImovel = table.Column<int>(type: "int", nullable: false),
                    PosicaoSolar = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Observacoes = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    ProprietarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deletado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imoveis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Imoveis_Proprietarios_ProprietarioId",
                        column: x => x.ProprietarioId,
                        principalTable: "Proprietarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImovelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Logradouro = table.Column<string>(type: "varchar(200)", nullable: false),
                    Numero = table.Column<string>(type: "varchar(50)", nullable: false),
                    Complemento = table.Column<string>(type: "varchar(250)", nullable: true),
                    Cep = table.Column<string>(type: "varchar(8)", nullable: false),
                    Bairro = table.Column<string>(type: "varchar(100)", nullable: false),
                    Cidade = table.Column<string>(type: "varchar(100)", nullable: false),
                    Estado = table.Column<string>(type: "varchar(50)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deletado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enderecos_Imoveis_ImovelId",
                        column: x => x.ImovelId,
                        principalTable: "Imoveis",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InquilinoImovelLocacoes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataSaida = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AtendimentoCorretorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InquilinoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImovelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deletado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InquilinoImovelLocacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InquilinoImovelLocacoes_CorretorInquilinoContatos_AtendimentoCorretorId",
                        column: x => x.AtendimentoCorretorId,
                        principalTable: "CorretorInquilinoContatos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InquilinoImovelLocacoes_Imoveis_ImovelId",
                        column: x => x.ImovelId,
                        principalTable: "Imoveis",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InquilinoImovelLocacoes_Inquilinos_InquilinoId",
                        column: x => x.InquilinoId,
                        principalTable: "Inquilinos",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Corretores",
                columns: new[] { "Id", "DataCriacao", "Deletado", "Nome", "Status", "Telefone" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2024, 3, 31, 16, 23, 26, 147, DateTimeKind.Local).AddTicks(5966), false, "João Silva", true, "123456789" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 3, 31, 16, 23, 26, 147, DateTimeKind.Local).AddTicks(5975), false, "Maria Souza", true, "987654321" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 3, 31, 16, 23, 26, 147, DateTimeKind.Local).AddTicks(5978), false, "Pedro Santos", true, "555555555" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2024, 3, 31, 16, 23, 26, 147, DateTimeKind.Local).AddTicks(5981), false, "Ana Oliveira", true, "999999999" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2024, 3, 31, 16, 23, 26, 147, DateTimeKind.Local).AddTicks(5984), false, "Carlos Fernandes", true, "777777777" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2024, 3, 31, 16, 23, 26, 147, DateTimeKind.Local).AddTicks(5989), false, "Mariana Lima", true, "444444444" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2024, 3, 31, 16, 23, 26, 147, DateTimeKind.Local).AddTicks(5997), false, "Rafaela Almeida", true, "888888888" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2024, 3, 31, 16, 23, 26, 147, DateTimeKind.Local).AddTicks(5999), false, "Lucas Costa", true, "666666666" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2024, 3, 31, 16, 23, 26, 147, DateTimeKind.Local).AddTicks(6002), false, "Fernanda Carvalho", true, "333333333" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2024, 3, 31, 16, 23, 26, 147, DateTimeKind.Local).AddTicks(6006), false, "Gabriel Martins", true, "111111111" }
                });

            migrationBuilder.InsertData(
                table: "Inquilinos",
                columns: new[] { "Id", "DataCriacao", "Deletado", "Nome", "Status", "Telefone" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000011"), new DateTime(2024, 3, 31, 16, 23, 26, 149, DateTimeKind.Local).AddTicks(4255), false, "José Pereira", true, "111111111" },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new DateTime(2024, 3, 31, 16, 23, 26, 149, DateTimeKind.Local).AddTicks(4275), false, "Ana Paula", true, "222222222" },
                    { new Guid("00000000-0000-0000-0000-000000000013"), new DateTime(2024, 3, 31, 16, 23, 26, 149, DateTimeKind.Local).AddTicks(4278), false, "Luiz Santos", true, "333333333" },
                    { new Guid("00000000-0000-0000-0000-000000000014"), new DateTime(2024, 3, 31, 16, 23, 26, 149, DateTimeKind.Local).AddTicks(4281), false, "Mariana Oliveira", true, "444444444" },
                    { new Guid("00000000-0000-0000-0000-000000000015"), new DateTime(2024, 3, 31, 16, 23, 26, 149, DateTimeKind.Local).AddTicks(4284), false, "Pedro Henrique", true, "555555555" },
                    { new Guid("00000000-0000-0000-0000-000000000016"), new DateTime(2024, 3, 31, 16, 23, 26, 149, DateTimeKind.Local).AddTicks(4289), false, "Carla Silva", true, "666666666" },
                    { new Guid("00000000-0000-0000-0000-000000000017"), new DateTime(2024, 3, 31, 16, 23, 26, 149, DateTimeKind.Local).AddTicks(4292), false, "Rafaela Lima", true, "777777777" },
                    { new Guid("00000000-0000-0000-0000-000000000018"), new DateTime(2024, 3, 31, 16, 23, 26, 149, DateTimeKind.Local).AddTicks(4294), false, "Gustavo Costa", true, "888888888" },
                    { new Guid("00000000-0000-0000-0000-000000000019"), new DateTime(2024, 3, 31, 16, 23, 26, 149, DateTimeKind.Local).AddTicks(4297), false, "Fernanda Souza", true, "999999999" },
                    { new Guid("00000000-0000-0000-0000-000000000020"), new DateTime(2024, 3, 31, 16, 23, 26, 149, DateTimeKind.Local).AddTicks(4303), false, "Lucas Martins", true, "000000000" }
                });

            migrationBuilder.InsertData(
                table: "Proprietarios",
                columns: new[] { "Id", "DataCriacao", "Deletado", "Nome", "Status", "Telefone" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000021"), new DateTime(2024, 3, 31, 16, 23, 26, 149, DateTimeKind.Local).AddTicks(6169), false, "José da Silva", true, "111111111" },
                    { new Guid("00000000-0000-0000-0000-000000000022"), new DateTime(2024, 3, 31, 16, 23, 26, 149, DateTimeKind.Local).AddTicks(6180), false, "Ana Oliveira", true, "222222222" },
                    { new Guid("00000000-0000-0000-0000-000000000023"), new DateTime(2024, 3, 31, 16, 23, 26, 149, DateTimeKind.Local).AddTicks(6184), false, "Luiz Pereira", true, "333333333" },
                    { new Guid("00000000-0000-0000-0000-000000000024"), new DateTime(2024, 3, 31, 16, 23, 26, 149, DateTimeKind.Local).AddTicks(6187), false, "Mariana Santos", true, "444444444" },
                    { new Guid("00000000-0000-0000-0000-000000000025"), new DateTime(2024, 3, 31, 16, 23, 26, 149, DateTimeKind.Local).AddTicks(6190), false, "Pedro Oliveira", true, "555555555" },
                    { new Guid("00000000-0000-0000-0000-000000000026"), new DateTime(2024, 3, 31, 16, 23, 26, 149, DateTimeKind.Local).AddTicks(6195), false, "Carla Pereira", true, "666666666" },
                    { new Guid("00000000-0000-0000-0000-000000000027"), new DateTime(2024, 3, 31, 16, 23, 26, 149, DateTimeKind.Local).AddTicks(6198), false, "Rafaela Lima", true, "777777777" },
                    { new Guid("00000000-0000-0000-0000-000000000028"), new DateTime(2024, 3, 31, 16, 23, 26, 149, DateTimeKind.Local).AddTicks(6206), false, "Gustavo Costa", true, "888888888" },
                    { new Guid("00000000-0000-0000-0000-000000000029"), new DateTime(2024, 3, 31, 16, 23, 26, 149, DateTimeKind.Local).AddTicks(6209), false, "Fernanda Souza", true, "999999999" },
                    { new Guid("00000000-0000-0000-0000-000000000030"), new DateTime(2024, 3, 31, 16, 23, 26, 149, DateTimeKind.Local).AddTicks(6212), false, "Lucas Martins", true, "000000000" }
                });

            migrationBuilder.InsertData(
                table: "CorretorInquilinoContatos",
                columns: new[] { "Id", "CorretorId", "DataCriacao", "Deletado", "DescricaoContato", "InquilinoId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2024, 3, 31, 16, 23, 26, 147, DateTimeKind.Local).AddTicks(4670), false, "Renovação do contrato de locação", new Guid("00000000-0000-0000-0000-000000000017") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2024, 3, 31, 16, 23, 26, 147, DateTimeKind.Local).AddTicks(4693), false, "Discussão sobre prazo de entrega", new Guid("00000000-0000-0000-0000-000000000013") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2024, 3, 31, 16, 23, 26, 147, DateTimeKind.Local).AddTicks(4698), false, "Agendamento de vistoria no imóvel", new Guid("00000000-0000-0000-0000-000000000016") },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2024, 3, 31, 16, 23, 26, 147, DateTimeKind.Local).AddTicks(4702), false, "Esclarecimento de dúvidas sobre o contrato", new Guid("00000000-0000-0000-0000-000000000015") },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2024, 3, 31, 16, 23, 26, 147, DateTimeKind.Local).AddTicks(4706), false, "Pedido de reparos no imóvel", new Guid("00000000-0000-0000-0000-000000000019") },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2024, 3, 31, 16, 23, 26, 147, DateTimeKind.Local).AddTicks(4713), false, "Negociação do valor do aluguel", new Guid("00000000-0000-0000-0000-000000000014") },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2024, 3, 31, 16, 23, 26, 147, DateTimeKind.Local).AddTicks(4717), false, "Agendamento de visita ao imóvel", new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2024, 3, 31, 16, 23, 26, 147, DateTimeKind.Local).AddTicks(4732), false, "Reclamação sobre problemas no imóvel", new Guid("00000000-0000-0000-0000-000000000018") },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 3, 31, 16, 23, 26, 147, DateTimeKind.Local).AddTicks(4735), false, "Confirmação de pagamento do aluguel", new Guid("00000000-0000-0000-0000-000000000020") }
                });

            migrationBuilder.InsertData(
                table: "CorretorProprietarioContatos",
                columns: new[] { "Id", "CorretorId", "DataCriacao", "Deletado", "DescricaoContato", "ProprietarioId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2024, 3, 31, 16, 23, 26, 147, DateTimeKind.Local).AddTicks(9691), false, "Solicitação de autorização para reparos no imóvel", new Guid("00000000-0000-0000-0000-000000000028") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 3, 31, 16, 23, 26, 147, DateTimeKind.Local).AddTicks(9703), false, "Atualização sobre visitas ao imóvel para venda", new Guid("00000000-0000-0000-0000-000000000023") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2024, 3, 31, 16, 23, 26, 147, DateTimeKind.Local).AddTicks(9710), false, "Informações sobre propostas de aluguel recebidas", new Guid("00000000-0000-0000-0000-000000000025") },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2024, 3, 31, 16, 23, 26, 147, DateTimeKind.Local).AddTicks(9715), false, "Negociação de comissão sobre venda de imóvel", new Guid("00000000-0000-0000-0000-000000000022") },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2024, 3, 31, 16, 23, 26, 147, DateTimeKind.Local).AddTicks(9726), false, "Solicitação de documentos para declaração de imposto de renda", new Guid("00000000-0000-0000-0000-000000000030") },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2024, 3, 31, 16, 23, 26, 147, DateTimeKind.Local).AddTicks(9732), false, "Agendamento de reunião para revisão de contrato de locação", new Guid("00000000-0000-0000-0000-000000000026") },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2024, 3, 31, 16, 23, 26, 147, DateTimeKind.Local).AddTicks(9737), false, "Confirmação de pagamento de aluguel", new Guid("00000000-0000-0000-0000-000000000029") },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2024, 3, 31, 16, 23, 26, 147, DateTimeKind.Local).AddTicks(9742), false, "Feedback sobre interessados em compra de imóvel", new Guid("00000000-0000-0000-0000-000000000027") },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 3, 31, 16, 23, 26, 147, DateTimeKind.Local).AddTicks(9747), false, "Discussão sobre estratégias de marketing para aluguel", new Guid("00000000-0000-0000-0000-000000000024") }
                });

            migrationBuilder.InsertData(
                table: "Imoveis",
                columns: new[] { "Id", "DataCriacao", "Deletado", "Observacoes", "PosicaoSolar", "ProprietarioId", "QtdeBanheiros", "QtdeQuartos", "QtdeVagasGaragem", "Status", "TipoImovel", "Valor" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2024, 3, 31, 16, 23, 26, 148, DateTimeKind.Local).AddTicks(7276), false, "Apartamento compacto no centro da cidade.", 1, new Guid("00000000-0000-0000-0000-000000000022"), 1, 2, 1, true, 2, 200000m },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 3, 31, 16, 23, 26, 148, DateTimeKind.Local).AddTicks(7301), false, "Casa com acabamento de alto padrão.", 0, new Guid("00000000-0000-0000-0000-000000000023"), 2, 3, 2, true, 1, 350000m },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2024, 3, 31, 16, 23, 26, 148, DateTimeKind.Local).AddTicks(7306), false, "Casa espaçosa com área de lazer.", 2, new Guid("00000000-0000-0000-0000-000000000024"), 3, 4, 2, true, 1, 400000m },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2024, 3, 31, 16, 23, 26, 148, DateTimeKind.Local).AddTicks(7311), false, "Apartamento simples próximo ao metrô.", 3, new Guid("00000000-0000-0000-0000-000000000025"), 1, 1, 0, true, 2, 150000m },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2024, 3, 31, 16, 23, 26, 148, DateTimeKind.Local).AddTicks(7316), false, "Casa aconchegante em condomínio fechado.", 0, new Guid("00000000-0000-0000-0000-000000000026"), 2, 3, 2, true, 1, 300000m },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(2024, 3, 31, 16, 23, 26, 148, DateTimeKind.Local).AddTicks(7322), false, "Apartamento bem localizado próximo a comércios.", 1, new Guid("00000000-0000-0000-0000-000000000027"), 1, 2, 1, true, 2, 180000m },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(2024, 3, 31, 16, 23, 26, 148, DateTimeKind.Local).AddTicks(7326), false, "Casa ampla em condomínio fechado.", 3, new Guid("00000000-0000-0000-0000-000000000028"), 3, 4, 2, true, 1, 400000m },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2024, 3, 31, 16, 23, 26, 148, DateTimeKind.Local).AddTicks(7329), false, "Apartamento próximo ao parque.", 1, new Guid("00000000-0000-0000-0000-000000000029"), 1, 2, 1, true, 2, 180000m },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(2024, 3, 31, 16, 23, 26, 148, DateTimeKind.Local).AddTicks(7333), false, "Apartamento com ótima vista.", 0, new Guid("00000000-0000-0000-0000-000000000030"), 1, 2, 1, true, 2, 210000m },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(2024, 3, 31, 16, 23, 26, 148, DateTimeKind.Local).AddTicks(7342), false, "Casa com acabamento de alto padrão.", 2, new Guid("00000000-0000-0000-0000-000000000021"), 2, 3, 2, true, 1, 350000m }
                });

            migrationBuilder.InsertData(
                table: "Enderecos",
                columns: new[] { "Id", "Bairro", "Cep", "Cidade", "Complemento", "DataCriacao", "Deletado", "Estado", "ImovelId", "Logradouro", "Numero" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), "Bela Vista", "01310100", "São Paulo", null, new DateTime(2024, 3, 31, 16, 23, 26, 148, DateTimeKind.Local).AddTicks(1092), false, "SP", new Guid("00000000-0000-0000-0000-000000000001"), "Av. Paulista", "1000" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "Jardins", "01426000", "São Paulo", null, new DateTime(2024, 3, 31, 16, 23, 26, 148, DateTimeKind.Local).AddTicks(1103), false, "SP", new Guid("00000000-0000-0000-0000-000000000002"), "Rua Oscar Freire", "500" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "Copacabana", "22021001", "Rio de Janeiro", null, new DateTime(2024, 3, 31, 16, 23, 26, 148, DateTimeKind.Local).AddTicks(1108), false, "RJ", new Guid("00000000-0000-0000-0000-000000000003"), "Av. Atlântica", "1500" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), "Consolação", "01304001", "São Paulo", null, new DateTime(2024, 3, 31, 16, 23, 26, 148, DateTimeKind.Local).AddTicks(1117), false, "SP", new Guid("00000000-0000-0000-0000-000000000004"), "Rua Augusta", "800" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), "Consolação", "01301000", "São Paulo", null, new DateTime(2024, 3, 31, 16, 23, 26, 148, DateTimeKind.Local).AddTicks(1121), false, "SP", new Guid("00000000-0000-0000-0000-000000000005"), "Rua da Consolação", "200" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), "Jardim América", "01430000", "São Paulo", null, new DateTime(2024, 3, 31, 16, 23, 26, 148, DateTimeKind.Local).AddTicks(1126), false, "SP", new Guid("00000000-0000-0000-0000-000000000006"), "Av. Brasil", "300" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), "Centro", "20071000", "Rio de Janeiro", null, new DateTime(2024, 3, 31, 16, 23, 26, 148, DateTimeKind.Local).AddTicks(1130), false, "RJ", new Guid("00000000-0000-0000-0000-000000000007"), "Av. Presidente Vargas", "100" },
                    { new Guid("00000000-0000-0000-0000-000000000008"), "Jardim das Flores", "30123456", "Belo Horizonte", null, new DateTime(2024, 3, 31, 16, 23, 26, 148, DateTimeKind.Local).AddTicks(1134), false, "MG", new Guid("00000000-0000-0000-0000-000000000008"), "Rua das Flores", "700" },
                    { new Guid("00000000-0000-0000-0000-000000000009"), "Praia de Iracema", "60060000", "Fortaleza", null, new DateTime(2024, 3, 31, 16, 23, 26, 148, DateTimeKind.Local).AddTicks(1138), false, "CE", new Guid("00000000-0000-0000-0000-000000000009"), "Av. Beira Mar", "2000" },
                    { new Guid("00000000-0000-0000-0000-000000000010"), "Moinhos de Vento", "90570000", "Porto Alegre", null, new DateTime(2024, 3, 31, 16, 23, 26, 148, DateTimeKind.Local).AddTicks(1143), false, "RS", new Guid("00000000-0000-0000-0000-000000000010"), "Rua Padre Chagas", "900" }
                });

            migrationBuilder.InsertData(
                table: "InquilinoImovelLocacoes",
                columns: new[] { "Id", "AtendimentoCorretorId", "DataCriacao", "DataEntrada", "DataSaida", "Deletado", "ImovelId", "InquilinoId" },
                values: new object[,]
                {
                    { new Guid("055f517a-4886-49f5-86ff-d8f509bd61d3"), new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 15, 52, 53, 78, DateTimeKind.Local), new DateTime(2024, 3, 31, 15, 52, 53, 78, DateTimeKind.Local), false, new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000015") },
                    { new Guid("5779fadd-ba8e-4914-b682-efd8a78473d9"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 15, 52, 53, 78, DateTimeKind.Local), new DateTime(2024, 3, 31, 15, 52, 53, 78, DateTimeKind.Local), false, new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("a0472edf-2d7a-4a14-b262-ca8dc44042af"), new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 15, 52, 53, 78, DateTimeKind.Local), new DateTime(2024, 3, 31, 15, 52, 53, 78, DateTimeKind.Local), false, new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000016") },
                    { new Guid("b57450c3-fa55-4928-9833-5035dd2c9cf5"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 15, 52, 53, 78, DateTimeKind.Local), new DateTime(2024, 3, 31, 15, 52, 53, 78, DateTimeKind.Local), false, new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("bd8c34d6-20fd-4503-979d-054b7a19a240"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 15, 52, 53, 78, DateTimeKind.Local), new DateTime(2024, 3, 31, 15, 52, 53, 78, DateTimeKind.Local), false, new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000014") },
                    { new Guid("e3937f88-6995-4797-8512-bd3565df1a5a"), new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 31, 15, 52, 53, 78, DateTimeKind.Local), new DateTime(2024, 3, 31, 15, 52, 53, 78, DateTimeKind.Local), false, new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000013") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CorretorInquilinoContatos_CorretorId",
                table: "CorretorInquilinoContatos",
                column: "CorretorId");

            migrationBuilder.CreateIndex(
                name: "IX_CorretorInquilinoContatos_InquilinoId",
                table: "CorretorInquilinoContatos",
                column: "InquilinoId");

            migrationBuilder.CreateIndex(
                name: "IX_CorretorProprietarioContatos_CorretorId",
                table: "CorretorProprietarioContatos",
                column: "CorretorId");

            migrationBuilder.CreateIndex(
                name: "IX_CorretorProprietarioContatos_ProprietarioId",
                table: "CorretorProprietarioContatos",
                column: "ProprietarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Enderecos_ImovelId",
                table: "Enderecos",
                column: "ImovelId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Imoveis_ProprietarioId",
                table: "Imoveis",
                column: "ProprietarioId");

            migrationBuilder.CreateIndex(
                name: "IX_InquilinoImovelLocacoes_AtendimentoCorretorId",
                table: "InquilinoImovelLocacoes",
                column: "AtendimentoCorretorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InquilinoImovelLocacoes_ImovelId",
                table: "InquilinoImovelLocacoes",
                column: "ImovelId");

            migrationBuilder.CreateIndex(
                name: "IX_InquilinoImovelLocacoes_InquilinoId",
                table: "InquilinoImovelLocacoes",
                column: "InquilinoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CorretorProprietarioContatos");

            migrationBuilder.DropTable(
                name: "Enderecos");

            migrationBuilder.DropTable(
                name: "InquilinoImovelLocacoes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CorretorInquilinoContatos");

            migrationBuilder.DropTable(
                name: "Imoveis");

            migrationBuilder.DropTable(
                name: "Corretores");

            migrationBuilder.DropTable(
                name: "Inquilinos");

            migrationBuilder.DropTable(
                name: "Proprietarios");
        }
    }
}
