
using System;
using System.Linq;

using Rock.Data;

namespace com.bricksandmortarstudio.GitEmailTemplateSync.Model
{
    /// <summary>
    /// GitCommunicationTemplateMatch Service class
    /// </summary>
    public partial class GitCommunicationTemplateMatchService : Service<GitCommunicationTemplateMatch>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GitCommunicationTemplateMatchService"/> class
        /// </summary>
        /// <param name="context">The context.</param>
        public GitCommunicationTemplateMatchService(RockContext context) : base(context)
        {
        }
    }

    /// <summary>
    /// Generated Extension Methods
    /// </summary>
    public static partial class GitCommunicationTemplateMatchExtensionMethods
    {
        /// <summary>
        /// Clones this GitCommunicationTemplateMatch object to a new GitCommunicationTemplateMatch object
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="deepCopy">if set to <c>true</c> a deep copy is made. If false, only the basic entity properties are copied.</param>
        /// <returns></returns>
        public static GitCommunicationTemplateMatch Clone( this GitCommunicationTemplateMatch source, bool deepCopy )
        {
            if (deepCopy)
            {
                return source.Clone() as GitCommunicationTemplateMatch;
            }
            else
            {
                var target = new GitCommunicationTemplateMatch();
                target.CopyPropertiesFrom( source );
                return target;
            }
        }

        /// <summary>
        /// Copies the properties from another GitCommunicationTemplateMatch object to this GitCommunicationTemplateMatch object
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="source">The source.</param>
        public static void CopyPropertiesFrom( this GitCommunicationTemplateMatch target, GitCommunicationTemplateMatch source )
        {
            target.Id = source.Id;
            target.CommunicationTemplateId = source.CommunicationTemplateId;
            target.ForeignGuid = source.ForeignGuid;
            target.ForeignKey = source.ForeignKey;
            target.GitFileId = source.GitFileId;
            target.CreatedDateTime = source.CreatedDateTime;
            target.ModifiedDateTime = source.ModifiedDateTime;
            target.CreatedByPersonAliasId = source.CreatedByPersonAliasId;
            target.ModifiedByPersonAliasId = source.ModifiedByPersonAliasId;
            target.Guid = source.Guid;
            target.ForeignId = source.ForeignId;

        }
    }
}
