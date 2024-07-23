CREATE DATABASE [Products]
GO
USE [Products]
GO
CREATE TABLE [dbo].[Products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Description] [nvarchar](255) NULL,
	[Price] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO



INSERT INTO [dbo].[Products]
           ([Name]
           ,[Description]
           ,[Price])
     VALUES
           ('Producto A'
           , 'Descripcion Producto A'
           ,9)
GO

INSERT INTO [dbo].[Products]
           ([Name]
           ,[Description]
           ,[Price])
     VALUES
           ('Producto B'
           , 'Descripcion Producto B'
           ,10)
GO
INSERT INTO [dbo].[Products]
           ([Name]
           ,[Description]
           ,[Price])
     VALUES
           ('Producto C'
           , 'Descripcion Producto C'
           ,11)
GO