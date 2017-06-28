
using System;
using System.Linq;

using Rock.Data;

namespace com.bricksandmortarstudio.GitEmailTemplateSync.Model
{
    /// <summary>
    /// GitSystemEmailTemplateMatch Service class
    /// </summary>
    public partial class GitSystemEmailTemplateMatchService : Service<GitSystemEmailTemplateMatch>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GitSystemEmailTemplateMatchService"/> class
        /// </summary>
        /// <param name="context">The context.</param>
        public GitSystemEmailTemplateMatchService(RockContext context) : base(context)
        {
        }
    }

    /// <summary>
    /// Generated Extension Methods
    /// </summary>
    public static partial class GitSystemEmailTemplateMatchExtensionMethods
    {
        /// <summary>
        /// Clones this GitSystemEmailTemplateMatch object to a new GitSystemEmailTemplateMatch object
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="deepCopy">if set to <c>true</c> a deep copy is made. If false, only the basic entity properties are copied.</param>
        /// <returns></returns>
        public static GitSystemEmailTemplateMatch Clone( this GitSystemEmailTemplateMatch source, bool deepCopy )
        {
            if (deepCopy)
            {
                return source.Clone() as GitSystemEmailTemplateMatch;
            }
            else
            {
                var target = new GitSystemEmailTemplateMatch();
                target.CopyPropertiesFrom( source );
                return target;
            }
        }

        /// <summary>
        /// Copies the properties from another GitSystemEmailTemplateMatch object to this GitSystemEmailTemplateMatch object
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="source">The source.</param>
        public static void CopyPropertiesFrom( this GitSystemEmailTemplateMatch target, GitSystemEmailTemplateMatch source )
        {
            target.Id = source.Id;
            target.ForeignGuid = source.ForeignGuid;
            target.ForeignKey = source.ForeignKey;
            target.GitFileId = source.GitFileId;
            target.SystemEmailId = source.SystemEmailId;
            target.CreatedDateTime = source.CreatedDateTime;
            target.ModifiedDateTime = source.ModifiedDateTime;
            target.CreatedByPersonAliasId = source.CreatedByPersonAliasId;
            target.ModifiedByPersonAliasId = source.ModifiedByPersonAliasId;
            target.Guid = source.Guid;
            target.ForeignId = source.ForeignId;

        }
    }
}
