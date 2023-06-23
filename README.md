# UploadArquivosAsp.netCore
Projeto tem como exemplo como cadastrar arquivos de uma aplicação asp.net core no banco de dados sql server.
  
#Youtube : https://www.youtube.com/watch?v=iw2TZ4n1-uI  
  
  
##Sql

CREATE TABLE dbo.Arquivos(
Id int IDENTITY(1,1) NOT NULL,
Descricao nvarchar(150) NOT NULL,
ContentType nvarchar(50) NOT NULL,
Dados varbinary(max) NULL,
 CONSTRAINT [PK_Imagens] PRIMARY KEY CLUSTERED
(
[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
