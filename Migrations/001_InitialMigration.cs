using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rock.Plugin;

namespace com.bricksandmortarstudio.GitEmailTemplateSync.Migrations
{
    [MigrationNumber(1, "1.6.0")]
    public class InitialMigration : Migration
    {
        public override void Up()
        {
            Sql( @"
                CREATE TABLE [dbo].[_com_bricksandmortarstudio_GitEmailTemplateSync_GitFile](
	                [Id] [int] IDENTITY(1,1) NOT NULL,
                    [Service] [nvarchar](100),
                    [ServiceId] [nvarchar](255) NOT NULL,
                    [FilePath] [nvarchar](max) NOT NULL,
                    [Url] [nvarchar](max),
                    [Repo] [nvarchar](255),
                    [Organisation] [nvarchar](255),
                    [Branch] [nvarchar](255),
	                [Guid] [uniqueidentifier] NOT NULL,
	                [CreatedDateTime] [datetime] NULL,
	                [ModifiedDateTime] [datetime] NULL,
	                [CreatedByPersonAliasId] [int] NULL,
	                [ModifiedByPersonAliasId] [int] NULL,
	                [ForeignKey] [nvarchar](50) NULL,
                    [ForeignGuid] [uniqueidentifier] NULL,
                    [ForeignId] [int] NULL,
                 CONSTRAINT [PK__com_bricksandmortarstudio_GitEmailTemplateSync_GitFile] PRIMARY KEY CLUSTERED 
                (
	                [Id] ASC
                )
				WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
				CONSTRAINT [UQ__com_bricksandmortarstudio_GitEmailTemplateSync_REPO_ORG_BRANCH_SERVICE_ID] UNIQUE NONCLUSTERED
				(
					[Service], [ServiceId], [Branch], [Repo], [Organisation]
				)
                ) ON [PRIMARY]

                CREATE TABLE [dbo].[_com_bricksandmortarstudio_.GitEmailTemplateSync_GitAttributeMatch](
	                [Id] [int] IDENTITY(1,1) NOT NULL,
                    [GitFileId] [int] NOT NULL FOREIGN KEY REFERENCES [_com_bricksandmortarstudio_GitEmailTemplateSync_GitFile] (Id),
                    [AttributeId] [int] NOT NULL FOREIGN KEY REFERENCES [Attribute] (Id),
	                [Guid] [uniqueidentifier] NOT NULL,
	                [CreatedDateTime] [datetime] NULL,
	                [ModifiedDateTime] [datetime] NULL,
	                [CreatedByPersonAliasId] [int] NULL,
	                [ModifiedByPersonAliasId] [int] NULL,
	                [ForeignKey] [nvarchar](50) NULL,
                    [ForeignGuid] [uniqueidentifier] NULL,
                    [ForeignId] [int] NULL,
                 CONSTRAINT [PK__com_bricksandmortarstudio_.GitEmailTemplateSync_GitAttributeMatch] PRIMARY KEY CLUSTERED 
                (
	                [Id] ASC
                )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                ) ON [PRIMARY]

				CREATE TABLE [dbo].[_com_bricksandmortarstudio_.GitEmailTemplateSync_GitCommunicationTemplateMatch](
	                [Id] [int] IDENTITY(1,1) NOT NULL,
                    [GitFileId] [int] NOT NULL FOREIGN KEY REFERENCES [_com_bricksandmortarstudio_GitEmailTemplateSync_GitFile] (Id),
                    [CommunicationTemplateId] [int] NOT NULL FOREIGN KEY REFERENCES [CommunicationTemplate] (Id),
	                [Guid] [uniqueidentifier] NOT NULL,
	                [CreatedDateTime] [datetime] NULL,
	                [ModifiedDateTime] [datetime] NULL,
	                [CreatedByPersonAliasId] [int] NULL,
	                [ModifiedByPersonAliasId] [int] NULL,
	                [ForeignKey] [nvarchar](50) NULL,
                    [ForeignGuid] [uniqueidentifier] NULL,
                    [ForeignId] [int] NULL,
                 CONSTRAINT [PK__com_bricksandmortarstudio_.GitEmailTemplateSync_GitCommunicationTemplateMatch] PRIMARY KEY CLUSTERED 
                (
	                [Id] ASC
                )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                ) ON [PRIMARY]

				CREATE TABLE [dbo].[_com_bricksandmortarstudio_.GitEmailTemplateSync_GitSystemEmailTemplateMatch](
	                [Id] [int] IDENTITY(1,1) NOT NULL,
                    [GitFileId] [int] NOT NULL FOREIGN KEY REFERENCES [_com_bricksandmortarstudio_GitEmailTemplateSync_GitFile] (Id),
                    [SystemEmailId] [int] NOT NULL FOREIGN KEY REFERENCES [SystemEmail] (Id),
	                [Guid] [uniqueidentifier] NOT NULL,
	                [CreatedDateTime] [datetime] NULL,
	                [ModifiedDateTime] [datetime] NULL,
	                [CreatedByPersonAliasId] [int] NULL,
	                [ModifiedByPersonAliasId] [int] NULL,
	                [ForeignKey] [nvarchar](50) NULL,
                    [ForeignGuid] [uniqueidentifier] NULL,
                    [ForeignId] [int] NULL,
                 CONSTRAINT [PK__com_bricksandmortarstudio_.GitEmailTemplateSync_GitSystemEmailTemplateMatch] PRIMARY KEY CLUSTERED 
                (
	                [Id] ASC
                )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                ) ON [PRIMARY]


" );
        }


        public override void Down()
        {
            Sql( @"               
                DROP TABLE [dbo].[_com_bricksandmortarstudio_GitEmailTemplateSync_GitFile]
                DROP TABLE [dbo].[_com_bricksandmortarstudio_.GitEmailTemplateSync_GitAttributeMatch]
                DROP TABLE [dbo].[_com_bricksandmortarstudio_.GitEmailTemplateSync_GitCommunicationTemplateMatch]
                DROP TABLE [dbo].[_com_bricksandmortarstudio_.GitEmailTemplateSync_GitSystemEmailTemplateMatch]
                " );
        }
    }
}
