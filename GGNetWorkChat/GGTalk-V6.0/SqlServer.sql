use GGTalk
go
CREATE TABLE [GGUser] (
	[UserID] [varchar] (50) NOT NULL ,
	[PasswordMD5] [varchar] (100) NOT NULL ,
	[Name] [nvarchar] (50) NOT NULL ,
	[Friends] [nvarchar] (4000) NOT NULL ,  
	[Signature] [nvarchar] (100) NOT NULL ,
	[HeadImageIndex] [int] NOT NULL ,
	[HeadImageData] [image] NULL ,
	[Groups] [varchar] (1000) NOT NULL ,
	[CreateTime] [datetime] NOT NULL ,
	[DefaultFriendCatalog] [nvarchar] (20) NOT NULL ,
	[Version] [int] NOT NULL ,
	CONSTRAINT [PK_OrayUser] PRIMARY KEY  CLUSTERED 
	(
		[UserID]
	)  ON [PRIMARY] 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [GGGroup] (
	[GroupID] [varchar] (20) NOT NULL ,
	[Name] [nvarchar] (20) NOT NULL ,
	[CreatorID] [varchar] (20) NOT NULL ,
	[Announce] [nvarchar] (200) NOT NULL ,
	[Members] [nvarchar] (4000) NOT NULL ,
	[CreateTime] [datetime] NOT NULL ,
	[Version] [int] NOT NULL ,
	CONSTRAINT [PK_OrayGroup] PRIMARY KEY  CLUSTERED 
	(
		[GroupID]
	)  ON [PRIMARY] 
) ON [PRIMARY]
GO

CREATE TABLE [ChatMessageRecord] (
	[AutoID] [bigint] IDENTITY (1, 1) NOT NULL ,
	[SpeakerID] [varchar] (20) NOT NULL ,
	[AudienceID] [varchar] (20) NOT NULL ,
	[IsGroupChat] [bit] NOT NULL ,
	[Content] [image] NOT NULL ,
	[OccureTime] [datetime] NOT NULL ,
	CONSTRAINT [PK_ChatMessageRecord] PRIMARY KEY  CLUSTERED 
	(
		[AutoID]
	)  ON [PRIMARY] 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE  INDEX [IX_ChatMessageRecord] ON [dbo].[ChatMessageRecord]([SpeakerID], [AudienceID], [OccureTime]) ON [PRIMARY]
GO

 CREATE  INDEX [IX_ChatMessageRecord_1] ON [dbo].[ChatMessageRecord]([AudienceID], [OccureTime]) ON [PRIMARY]
GO