
using System;
using System.Linq;

using Rock.Data;

namespace com.bricksandmortarstudio.GitEmailTemplateSync.Model
{
    /// <summary>
    /// GitFile Service class
    /// </summary>
    public partial class GitFileService : Service<GitFile>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GitFileService"/> class
        /// </summary>
        /// <param name="context">The context.</param>
        public GitFileService(RockContext context) : base(context)
        {
        }
    }

    /// <summary>
    /// Generated Extension Methods
    /// </summary>
    public static partial class GitFileExtensionMethods
    {
        /// <summary>
        /// Clones this GitFile object to a new GitFile object
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="deepCopy">if set to <c>true</c> a deep copy is made. If false, only the basic entity properties are copied.</param>
        /// <returns></returns>
        public static GitFile Clone( this GitFile source, bool deepCopy )
        {
            if (deepCopy)
            {
                return source.Clone() as GitFile;
            }
            else
            {
                var target = new GitFile();
                target.CopyPropertiesFrom( source );
                return target;
            }
        }

        /// <summary>
        /// Copies the properties from another GitFile object to this GitFile object
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="source">The source.</param>
        public static void CopyPropertiesFrom( this GitFile target, GitFile source )
        {
            target.Id = source.Id;
            target.FilePath = source.FilePath;
            target.ForeignGuid = source.ForeignGuid;
            target.ForeignKey = source.ForeignKey;
            target.ServiceId = source.ServiceId;
            target.Url = source.Url;
            target.CreatedDateTime = source.CreatedDateTime;
            target.ModifiedDateTime = source.ModifiedDateTime;
            target.CreatedByPersonAliasId = source.CreatedByPersonAliasId;
            target.ModifiedByPersonAliasId = source.ModifiedByPersonAliasId;
            target.Guid = source.Guid;
            target.ForeignId = source.ForeignId;

        }
    }
}
