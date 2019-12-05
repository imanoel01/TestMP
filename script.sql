USE [master]
GO
/****** Object:  Database [MPDb]    Script Date: 12/5/2019 9:42:04 AM ******/
CREATE DATABASE [MPDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MPDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\MPDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MPDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\MPDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [MPDb] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MPDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MPDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MPDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MPDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MPDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MPDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [MPDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MPDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MPDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MPDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MPDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MPDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MPDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MPDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MPDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MPDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MPDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MPDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MPDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MPDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MPDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MPDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MPDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MPDb] SET RECOVERY FULL 
GO
ALTER DATABASE [MPDb] SET  MULTI_USER 
GO
ALTER DATABASE [MPDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MPDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MPDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MPDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MPDb] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MPDb', N'ON'
GO
ALTER DATABASE [MPDb] SET QUERY_STORE = OFF
GO
USE [MPDb]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [MPDb]
GO
/****** Object:  Table [dbo].[Belief]    Script Date: 12/5/2019 9:42:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Belief](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[DateCreated] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Belief] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MP_Type]    Script Date: 12/5/2019 9:42:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MP_Type](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[DateCreated] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_MP_Type] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MPBioData]    Script Date: 12/5/2019 9:42:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MPBioData](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Firstname] [nvarchar](50) NOT NULL,
	[Secondname] [nvarchar](50) NOT NULL,
	[Belief] [int] NOT NULL,
	[Residence] [int] NOT NULL,
	[MP_Type] [int] NOT NULL,
	[DateCreated] [datetime2](7) NOT NULL,
	[LastUpdated] [datetime2](7) NULL,
 CONSTRAINT [PK_MPBioData] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Residence]    Script Date: 12/5/2019 9:42:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Residence](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[DateCreated] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Residence] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Belief] ADD  CONSTRAINT [DF_Belief_DateCreated]  DEFAULT (getdate()) FOR [DateCreated]
GO
ALTER TABLE [dbo].[MP_Type] ADD  CONSTRAINT [DF_MP_Type_DateCreated]  DEFAULT (getdate()) FOR [DateCreated]
GO
ALTER TABLE [dbo].[MPBioData] ADD  CONSTRAINT [DF_MPBioData_DateCreated]  DEFAULT (getdate()) FOR [DateCreated]
GO
ALTER TABLE [dbo].[Residence] ADD  CONSTRAINT [DF_Residence_DateCreated]  DEFAULT (getdate()) FOR [DateCreated]
GO
/****** Object:  StoredProcedure [dbo].[createMp]    Script Date: 12/5/2019 9:42:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[createMp] @firstname nvarchar(50), @secondname nvarchar(50), @belief  int,@mptype int,@residence int, @ret nvarchar(50) out

as

begin

if not exists (select * from MPBioData where Firstname=@firstname and Secondname=@secondname )

begin
insert into MPBioData(Firstname,Secondname,MP_Type,Belief,Residence,DateCreated)
values(@firstname,@secondname,@mptype,@belief,@residence,getdate())

set @ret=1

end
else
begin
set @ret=0
end
end



GO
/****** Object:  StoredProcedure [dbo].[deleteMP]    Script Date: 12/5/2019 9:42:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[deleteMP] @id int, @ret int out

as 
begin

if	exists(select * from MPBioData where id=@id)

	begin

		delete from MPBioData where id=@id
		set @ret=1
	end
else
	begin
		set @ret=0
	end
end
GO
/****** Object:  StoredProcedure [dbo].[getBelief]    Script Date: 12/5/2019 9:42:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[getBelief]

as
begin
select id,name from Belief order by id asc

end




GO
/****** Object:  StoredProcedure [dbo].[getMp_Type]    Script Date: 12/5/2019 9:42:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getMp_Type]

as
begin
select id,name from MP_Type order by id asc

end




GO
/****** Object:  StoredProcedure [dbo].[getResidence]    Script Date: 12/5/2019 9:42:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[getResidence]

as
begin
select id,name from Residence order by id asc

end




GO
/****** Object:  StoredProcedure [dbo].[MPSearch]    Script Date: 12/5/2019 9:42:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure[dbo].[MPSearch] --'emm'
@searchvalue nvarchar(50)

as
begin

select distinct a.Id, a.Firstname,a.Secondname, b.Name as Belief, c.Name as Residence,d.Name as [Mp Type],a.DateCreated,a.LastUpdated
 from
 MPBioData as a
 left join belief b on a.Belief=b.Id
 left join residence  c on a.Residence=c.Id
left join  MP_Type d on a.MP_Type=d.Id 
 where (a.firstname like ''+@searchvalue+'%' or a.Secondname like ''+@searchvalue+'%' )
end


GO
/****** Object:  StoredProcedure [dbo].[UpdateMp]    Script Date: 12/5/2019 9:42:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UpdateMp] @id int, @firstname nvarchar(50), @secondname nvarchar(50),
@residence int,@belief int ,@ret int out

as

begin

if exists(select * from MPBioData where Id=@id)

	begin
	if exists(select * from Residence where id=@residence ) 
	if exists(select * from belief where id=@belief)
	
		update MPBioData
		SET 
		Firstname=@firstname,Secondname=@secondname,Residence=@residence,Belief=@belief,LastUpdated=GETDATE()
		where id=@id
		set @ret=1

	end
else
begin

	set @ret=0
end
end

GO
USE [master]
GO
ALTER DATABASE [MPDb] SET  READ_WRITE 
GO
