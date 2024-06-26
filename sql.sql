USE [master]
GO
/****** Object:  Database [ApiAdvise]    Script Date: 01/04/2024 08:40:16 ******/
CREATE DATABASE [ApiAdvise]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ApiAdvise', FILENAME = N'/var/opt/mssql/data/ApiAdvise.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ApiAdvise_log', FILENAME = N'/var/opt/mssql/data/ApiAdvise_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [ApiAdvise] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ApiAdvise].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ApiAdvise] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ApiAdvise] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ApiAdvise] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ApiAdvise] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ApiAdvise] SET ARITHABORT OFF 
GO
ALTER DATABASE [ApiAdvise] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ApiAdvise] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ApiAdvise] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ApiAdvise] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ApiAdvise] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ApiAdvise] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ApiAdvise] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ApiAdvise] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ApiAdvise] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ApiAdvise] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ApiAdvise] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ApiAdvise] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ApiAdvise] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ApiAdvise] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ApiAdvise] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ApiAdvise] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [ApiAdvise] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ApiAdvise] SET RECOVERY FULL 
GO
ALTER DATABASE [ApiAdvise] SET  MULTI_USER 
GO
ALTER DATABASE [ApiAdvise] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ApiAdvise] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ApiAdvise] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ApiAdvise] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ApiAdvise] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ApiAdvise] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ApiAdvise', N'ON'
GO
ALTER DATABASE [ApiAdvise] SET QUERY_STORE = ON
GO
ALTER DATABASE [ApiAdvise] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ApiAdvise]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 01/04/2024 08:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 01/04/2024 08:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [varchar](100) NOT NULL,
	[ClaimType] [varchar](100) NULL,
	[ClaimValue] [varchar](100) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 01/04/2024 08:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [varchar](100) NOT NULL,
	[Name] [varchar](256) NULL,
	[NormalizedName] [varchar](256) NULL,
	[ConcurrencyStamp] [varchar](100) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 01/04/2024 08:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [varchar](100) NOT NULL,
	[ClaimType] [varchar](100) NULL,
	[ClaimValue] [varchar](100) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 01/04/2024 08:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [varchar](100) NOT NULL,
	[ProviderKey] [varchar](100) NOT NULL,
	[ProviderDisplayName] [varchar](100) NULL,
	[UserId] [varchar](100) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 01/04/2024 08:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [varchar](100) NOT NULL,
	[RoleId] [varchar](100) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 01/04/2024 08:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [varchar](100) NOT NULL,
	[UserName] [varchar](256) NULL,
	[NormalizedUserName] [varchar](256) NULL,
	[Email] [varchar](256) NULL,
	[NormalizedEmail] [varchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [varchar](100) NULL,
	[SecurityStamp] [varchar](100) NULL,
	[ConcurrencyStamp] [varchar](100) NULL,
	[PhoneNumber] [varchar](100) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 01/04/2024 08:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [varchar](100) NOT NULL,
	[LoginProvider] [varchar](100) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Value] [varchar](100) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Corretores]    Script Date: 01/04/2024 08:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Corretores](
	[Id] [uniqueidentifier] NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[Telefone] [varchar](20) NOT NULL,
	[Status] [bit] NOT NULL,
	[DataCriacao] [datetime2](7) NOT NULL,
	[Deletado] [bit] NOT NULL,
 CONSTRAINT [PK_Corretores] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CorretorInquilinoContatos]    Script Date: 01/04/2024 08:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CorretorInquilinoContatos](
	[Id] [uniqueidentifier] NOT NULL,
	[DescricaoContato] [varchar](200) NOT NULL,
	[CorretorId] [uniqueidentifier] NOT NULL,
	[InquilinoId] [uniqueidentifier] NOT NULL,
	[DataCriacao] [datetime2](7) NOT NULL,
	[Deletado] [bit] NOT NULL,
 CONSTRAINT [PK_CorretorInquilinoContatos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CorretorProprietarioContatos]    Script Date: 01/04/2024 08:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CorretorProprietarioContatos](
	[Id] [uniqueidentifier] NOT NULL,
	[DescricaoContato] [varchar](200) NOT NULL,
	[ProprietarioId] [uniqueidentifier] NOT NULL,
	[CorretorId] [uniqueidentifier] NOT NULL,
	[DataCriacao] [datetime2](7) NOT NULL,
	[Deletado] [bit] NOT NULL,
 CONSTRAINT [PK_CorretorProprietarioContatos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Enderecos]    Script Date: 01/04/2024 08:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Enderecos](
	[Id] [uniqueidentifier] NOT NULL,
	[ImovelId] [uniqueidentifier] NOT NULL,
	[Logradouro] [varchar](200) NOT NULL,
	[Numero] [varchar](50) NOT NULL,
	[Complemento] [varchar](250) NULL,
	[Cep] [varchar](8) NOT NULL,
	[Bairro] [varchar](100) NOT NULL,
	[Cidade] [varchar](100) NOT NULL,
	[Estado] [varchar](50) NOT NULL,
	[DataCriacao] [datetime2](7) NOT NULL,
	[Deletado] [bit] NOT NULL,
 CONSTRAINT [PK_Enderecos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Imoveis]    Script Date: 01/04/2024 08:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Imoveis](
	[Id] [uniqueidentifier] NOT NULL,
	[QtdeQuartos] [int] NOT NULL,
	[QtdeBanheiros] [int] NOT NULL,
	[QtdeVagasGaragem] [int] NOT NULL,
	[TipoImovel] [int] NOT NULL,
	[PosicaoSolar] [int] NOT NULL,
	[Valor] [decimal](18, 2) NOT NULL,
	[Observacoes] [varchar](500) NULL,
	[Status] [bit] NOT NULL,
	[ProprietarioId] [uniqueidentifier] NOT NULL,
	[DataCriacao] [datetime2](7) NOT NULL,
	[Deletado] [bit] NOT NULL,
 CONSTRAINT [PK_Imoveis] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InquilinoImovelLocacoes]    Script Date: 01/04/2024 08:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InquilinoImovelLocacoes](
	[Id] [uniqueidentifier] NOT NULL,
	[DataEntrada] [datetime2](7) NOT NULL,
	[DataSaida] [datetime2](7) NULL,
	[AtendimentoCorretorId] [uniqueidentifier] NOT NULL,
	[InquilinoId] [uniqueidentifier] NOT NULL,
	[ImovelId] [uniqueidentifier] NOT NULL,
	[DataCriacao] [datetime2](7) NOT NULL,
	[Deletado] [bit] NOT NULL,
 CONSTRAINT [PK_InquilinoImovelLocacoes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inquilinos]    Script Date: 01/04/2024 08:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inquilinos](
	[Id] [uniqueidentifier] NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[Telefone] [varchar](20) NOT NULL,
	[Status] [bit] NOT NULL,
	[DataCriacao] [datetime2](7) NOT NULL,
	[Deletado] [bit] NOT NULL,
 CONSTRAINT [PK_Inquilinos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proprietarios]    Script Date: 01/04/2024 08:40:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proprietarios](
	[Id] [uniqueidentifier] NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[Telefone] [varchar](20) NOT NULL,
	[Status] [bit] NOT NULL,
	[DataCriacao] [datetime2](7) NOT NULL,
	[Deletado] [bit] NOT NULL,
 CONSTRAINT [PK_Proprietarios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 01/04/2024 08:40:17 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 01/04/2024 08:40:17 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 01/04/2024 08:40:17 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 01/04/2024 08:40:17 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 01/04/2024 08:40:17 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 01/04/2024 08:40:17 ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 01/04/2024 08:40:17 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CorretorInquilinoContatos_CorretorId]    Script Date: 01/04/2024 08:40:17 ******/
CREATE NONCLUSTERED INDEX [IX_CorretorInquilinoContatos_CorretorId] ON [dbo].[CorretorInquilinoContatos]
(
	[CorretorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CorretorInquilinoContatos_InquilinoId]    Script Date: 01/04/2024 08:40:17 ******/
CREATE NONCLUSTERED INDEX [IX_CorretorInquilinoContatos_InquilinoId] ON [dbo].[CorretorInquilinoContatos]
(
	[InquilinoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CorretorProprietarioContatos_CorretorId]    Script Date: 01/04/2024 08:40:17 ******/
CREATE NONCLUSTERED INDEX [IX_CorretorProprietarioContatos_CorretorId] ON [dbo].[CorretorProprietarioContatos]
(
	[CorretorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CorretorProprietarioContatos_ProprietarioId]    Script Date: 01/04/2024 08:40:17 ******/
CREATE NONCLUSTERED INDEX [IX_CorretorProprietarioContatos_ProprietarioId] ON [dbo].[CorretorProprietarioContatos]
(
	[ProprietarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Enderecos_ImovelId]    Script Date: 01/04/2024 08:40:17 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Enderecos_ImovelId] ON [dbo].[Enderecos]
(
	[ImovelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Imoveis_ProprietarioId]    Script Date: 01/04/2024 08:40:17 ******/
CREATE NONCLUSTERED INDEX [IX_Imoveis_ProprietarioId] ON [dbo].[Imoveis]
(
	[ProprietarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_InquilinoImovelLocacoes_AtendimentoCorretorId]    Script Date: 01/04/2024 08:40:17 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_InquilinoImovelLocacoes_AtendimentoCorretorId] ON [dbo].[InquilinoImovelLocacoes]
(
	[AtendimentoCorretorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_InquilinoImovelLocacoes_ImovelId]    Script Date: 01/04/2024 08:40:17 ******/
CREATE NONCLUSTERED INDEX [IX_InquilinoImovelLocacoes_ImovelId] ON [dbo].[InquilinoImovelLocacoes]
(
	[ImovelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_InquilinoImovelLocacoes_InquilinoId]    Script Date: 01/04/2024 08:40:17 ******/
CREATE NONCLUSTERED INDEX [IX_InquilinoImovelLocacoes_InquilinoId] ON [dbo].[InquilinoImovelLocacoes]
(
	[InquilinoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[CorretorInquilinoContatos]  WITH CHECK ADD  CONSTRAINT [FK_CorretorInquilinoContatos_Corretores_CorretorId] FOREIGN KEY([CorretorId])
REFERENCES [dbo].[Corretores] ([Id])
GO
ALTER TABLE [dbo].[CorretorInquilinoContatos] CHECK CONSTRAINT [FK_CorretorInquilinoContatos_Corretores_CorretorId]
GO
ALTER TABLE [dbo].[CorretorInquilinoContatos]  WITH CHECK ADD  CONSTRAINT [FK_CorretorInquilinoContatos_Inquilinos_InquilinoId] FOREIGN KEY([InquilinoId])
REFERENCES [dbo].[Inquilinos] ([Id])
GO
ALTER TABLE [dbo].[CorretorInquilinoContatos] CHECK CONSTRAINT [FK_CorretorInquilinoContatos_Inquilinos_InquilinoId]
GO
ALTER TABLE [dbo].[CorretorProprietarioContatos]  WITH CHECK ADD  CONSTRAINT [FK_CorretorProprietarioContatos_Corretores_CorretorId] FOREIGN KEY([CorretorId])
REFERENCES [dbo].[Corretores] ([Id])
GO
ALTER TABLE [dbo].[CorretorProprietarioContatos] CHECK CONSTRAINT [FK_CorretorProprietarioContatos_Corretores_CorretorId]
GO
ALTER TABLE [dbo].[CorretorProprietarioContatos]  WITH CHECK ADD  CONSTRAINT [FK_CorretorProprietarioContatos_Proprietarios_ProprietarioId] FOREIGN KEY([ProprietarioId])
REFERENCES [dbo].[Proprietarios] ([Id])
GO
ALTER TABLE [dbo].[CorretorProprietarioContatos] CHECK CONSTRAINT [FK_CorretorProprietarioContatos_Proprietarios_ProprietarioId]
GO
ALTER TABLE [dbo].[Enderecos]  WITH CHECK ADD  CONSTRAINT [FK_Enderecos_Imoveis_ImovelId] FOREIGN KEY([ImovelId])
REFERENCES [dbo].[Imoveis] ([Id])
GO
ALTER TABLE [dbo].[Enderecos] CHECK CONSTRAINT [FK_Enderecos_Imoveis_ImovelId]
GO
ALTER TABLE [dbo].[Imoveis]  WITH CHECK ADD  CONSTRAINT [FK_Imoveis_Proprietarios_ProprietarioId] FOREIGN KEY([ProprietarioId])
REFERENCES [dbo].[Proprietarios] ([Id])
GO
ALTER TABLE [dbo].[Imoveis] CHECK CONSTRAINT [FK_Imoveis_Proprietarios_ProprietarioId]
GO
ALTER TABLE [dbo].[InquilinoImovelLocacoes]  WITH CHECK ADD  CONSTRAINT [FK_InquilinoImovelLocacoes_CorretorInquilinoContatos_AtendimentoCorretorId] FOREIGN KEY([AtendimentoCorretorId])
REFERENCES [dbo].[CorretorInquilinoContatos] ([Id])
GO
ALTER TABLE [dbo].[InquilinoImovelLocacoes] CHECK CONSTRAINT [FK_InquilinoImovelLocacoes_CorretorInquilinoContatos_AtendimentoCorretorId]
GO
ALTER TABLE [dbo].[InquilinoImovelLocacoes]  WITH CHECK ADD  CONSTRAINT [FK_InquilinoImovelLocacoes_Imoveis_ImovelId] FOREIGN KEY([ImovelId])
REFERENCES [dbo].[Imoveis] ([Id])
GO
ALTER TABLE [dbo].[InquilinoImovelLocacoes] CHECK CONSTRAINT [FK_InquilinoImovelLocacoes_Imoveis_ImovelId]
GO
ALTER TABLE [dbo].[InquilinoImovelLocacoes]  WITH CHECK ADD  CONSTRAINT [FK_InquilinoImovelLocacoes_Inquilinos_InquilinoId] FOREIGN KEY([InquilinoId])
REFERENCES [dbo].[Inquilinos] ([Id])
GO
ALTER TABLE [dbo].[InquilinoImovelLocacoes] CHECK CONSTRAINT [FK_InquilinoImovelLocacoes_Inquilinos_InquilinoId]
GO
USE [master]
GO
ALTER DATABASE [ApiAdvise] SET  READ_WRITE 
GO
