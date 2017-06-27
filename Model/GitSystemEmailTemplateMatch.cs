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
    [Table( "_com_bricksandmortarstudio_.GitEmailTemplateSync_GitSystemEmailTemplateMatch" )]
    [DataContract]
    public class GitSystemEmailTemplateMatch : Rock.Data.Model<GitSystemEmailTemplateMatch>
    {
        [DataMember]
        public int GitFileId { get; set; }

        [DataMember]
        public int SystemEmailId { get; set; }

        [DataMember]
        public virtual GitFile GitFile { get; set; }

        [DataMember]
        public virtual SystemEmail SystemEmail {get; set; }

        

        #region Entity Configuration


        public partial class GitSystemEmailTemplateMatchConfiguration : EntityTypeConfiguration<GitSystemEmailTemplateMatch>
        {
            public GitSystemEmailTemplateMatchConfiguration()
            {
                this.HasRequired( a => a.SystemEmail ).WithMany().HasForeignKey( a => a.SystemEmailId ).WillCascadeOnDelete( false );
                this.HasRequired( a => a.GitFile ).WithMany().HasForeignKey( a => a.GitFileId ).WillCascadeOnDelete( false );
            }
        }

        #endregion
    }
}
