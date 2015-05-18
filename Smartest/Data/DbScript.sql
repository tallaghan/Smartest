USE [Smartest]
GO
/****** Object:  Table [dbo].[Challenges]    Script Date: 05/18/2015 15:32:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Challenges](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Challenger] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Challenges] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Challenges] ON
INSERT [dbo].[Challenges] ([Id], [Challenger]) VALUES (1, N'mduffy')
SET IDENTITY_INSERT [dbo].[Challenges] OFF
/****** Object:  Table [dbo].[Games]    Script Date: 05/18/2015 15:32:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Games](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ChallengeId] [int] NOT NULL,
	[Opponent] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Games] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Games_Challenges]    Script Date: 05/18/2015 15:32:05 ******/
ALTER TABLE [dbo].[Games]  WITH CHECK ADD  CONSTRAINT [FK_Games_Challenges] FOREIGN KEY([ChallengeId])
REFERENCES [dbo].[Challenges] ([Id])
GO
ALTER TABLE [dbo].[Games] CHECK CONSTRAINT [FK_Games_Challenges]
GO
