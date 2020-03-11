# Programacion3Capas
``
CREATE DATABASE [db_almacen]

USE [db_almacen]

CREATE TABLE [dbo].[c_typeProduct](
	[id_typeProduct] [int] IDENTITY(1,1) NOT NULL,
	[flddescription] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_c_typeProduct] PRIMARY KEY CLUSTERED 
(
	[id_typeProduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE [dbo].[product](
	[id_product] [int] IDENTITY(1,1) NOT NULL,
	[fldname] [nvarchar](500) NOT NULL,
	[fldprice] [decimal](18, 2) NOT NULL,
	[flddateOn] [datetime] NOT NULL,
	[fldactive] [bit] NOT NULL,
	[id_fktypeProduct] [int] NOT NULL,
 CONSTRAINT [PK_product] PRIMARY KEY CLUSTERED 
(
	[id_product] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
``
