using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace com.bricksandmortarstudio.GitEmailTemplateSync.Model
{
    [Table( "_com_bricksandmortarstudio_.GitEmailTemplateSync_GitAttributeMatch" )]
    [DataContract]
    public class GitAttributeMatch : Rock.Data.Model<GitAttributeMatch>
    {
        [DataMember]
        public int GitFileId { get; set; }

        [DataMember]
        public int AttributeId { get; set; }

        [DataMember]
        public virtual GitFile GitFile { get; set; }

        [DataMember]
        public virtual Attribute Attribute {get; set; }

        

        #region Entity Configuration


        public partial class GitAttributeMatchConfiguration : EntityTypeConfiguration<GitAttributeMatch>
        {
            public GitAttributeMatchConfiguration()
            {
                this.HasRequired( a => a.Attribute ).WithMany().HasForeignKey( a => a.AttributeId ).WillCascadeOnDelete( false );
                this.HasRequired( a => a.GitFile ).WithMany().HasForeignKey( a => a.GitFileId ).WillCascadeOnDelete( false );
            }
        }

        #endregion
    }
}
