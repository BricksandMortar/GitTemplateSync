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
            Sql(@"
                CREATE TABLE [dbo].[_com_bricksandmortarstudio_GitEmailTemplateSync_GitFile](
	                [Id] [int] IDENTITY(1,1) NOT NULL,
                    [ServiceId] [nvarchar](max) NOT NULL,
                    [FilePath] [nvarchar](max) NOT NULL,
                    [Url] [nvarchar](max) NOT NULL,
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
                )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
                ) ON [PRIMARY]


");
        }


        public override void Down()
        {
            RockMigrationHelper.DeleteFieldType("87C17D4B-D465-4B6B-A5E0-3B18CCE226BC");
            RockMigrationHelper.DeleteEntityType("70F15075-ACEE-4A33-B052-1E45271A9ADF");

            Sql(@"               
                ALTER TABLE [dbo].[_com_bricksandmortarstudio_TheCrossing_VolunteerMembership] DROP CONSTRAINT [FK__com_bricksandmortarstudio_TheCrossing_VolunteerMembership_ModifiedByPersonAliasId]
                ALTER TABLE [dbo].[_com_bricksandmortarstudio_TheCrossing_VolunteerMembership] DROP CONSTRAINT [FK__com_bricksandmortarstudio_TheCrossing_VolunteerMembership_CreatedByPersonAliasId]
                ALTER TABLE [dbo].[_com_bricksandmortarstudio_TheCrossing_VolunteerMembership] DROP CONSTRAINT [FK__com_bricksandmortarstudio_TheCrossing_VolunteerMembership_GroupRole]
                ALTER TABLE [dbo].[_com_bricksandmortarstudio_TheCrossing_VolunteerMembership] DROP CONSTRAINT [FK__com_bricksandmortarstudio_TheCrossing_VolunteerMembership_Group]
                ALTER TABLE [dbo].[_com_bricksandmortarstudio_TheCrossing_VolunteerMembership] DROP CONSTRAINT [FK__com_bricksandmortarstudio_TheCrossing_VolunteerMembership_Person]
                DROP TABLE [dbo].[_com_bricksandmortarstudio_TheCrossing_VolunteerMembership]
                ");
        }
    }
}
