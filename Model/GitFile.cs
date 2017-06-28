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
    [Table( "_com_bricksandmortarstudio_GitEmailTemplateSync_GitFile" )]
    [DataContract]
    public class GitFile : Rock.Data.Model<GitFile>
    {
        /// <summary>
        /// The unique identifier for a given file provided by the GitService (i.e. sha for Github)
        /// </summary>
        [DataMember]
        public string ServiceId { get; set; }

        /// <summary>
        /// The service this file is provided by 
        /// </summary>
        [DataMember]
        public string Service { get; set; }

        [DataMember]
        public string FilePath { get; set; }

        [DataMember]
        public string Branch { get; set; }

        [DataMember]
        public string Repo { get; set; }

        [DataMember]
        public string Organisation { get; set; }

        [DataMember]
        public string Url { get; set; }

        #region Entity Configuration


        public partial class GitFileConfiguration : EntityTypeConfiguration<GitFile>
        {
            public GitFileConfiguration()
            {
            }
        }

        #endregion


    }
}
