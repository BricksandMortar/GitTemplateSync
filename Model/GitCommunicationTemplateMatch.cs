using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Rock.Model;

namespace com.bricksandmortarstudio.GitEmailTemplateSync.Model
{
    [Table( "_com_bricksandmortarstudio_.GitEmailTemplateSync_GitCommunicationTemplateMatch" )]
    [DataContract]
    public class GitCommunicationTemplateMatch : Rock.Data.Model<GitCommunicationTemplateMatch>
    {
        [DataMember]
        public int GitFileId { get; set; }

        [DataMember]
        public int CommunicationTemplateId { get; set; }

        [DataMember]
        public virtual GitFile GitFile { get; set; }

        [DataMember]
        public virtual CommunicationTemplate CommunicationTemplate {get; set; }

        

        #region Entity Configuration


        public partial class GitCommunicationTemplateMatchConfiguration : EntityTypeConfiguration<GitCommunicationTemplateMatch>
        {
            public GitCommunicationTemplateMatchConfiguration()
            {
                this.HasRequired( a => a.CommunicationTemplate ).WithMany().HasForeignKey( a => a.CommunicationTemplateId ).WillCascadeOnDelete( false );
                this.HasRequired( a => a.GitFile ).WithMany().HasForeignKey( a => a.GitFileId ).WillCascadeOnDelete( false );
            }
        }

        #endregion
    }
}
