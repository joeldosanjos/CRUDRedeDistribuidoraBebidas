USE [redebebidas]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[ClienteId] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Cpf] [varchar](14) NOT NULL,
	[TelefoneTipo] [varchar](20) NOT NULL,
	[TelefoneNumero] [varchar](20) NOT NULL,
	[EnderecoTipo] [varchar](20) NOT NULL,
	[Cep] [varchar](9) NOT NULL,
	[Estado] [varchar](2) NOT NULL,
	[Cidade] [varchar](30) NOT NULL,
	[Bairro] [varchar](30) NOT NULL,
	[Logradouro] [varchar](40) NOT NULL,
	[EnderecoNumero] [varchar](5) NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[ClienteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
