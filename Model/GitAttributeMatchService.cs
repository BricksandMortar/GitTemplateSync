using System;
using System.Linq;

using Rock.Data;

namespace com.bricksandmortarstudio.GitEmailTemplateSync.Model
{
    /// <summary>
    /// GitAttributeMatch Service class
    /// </summary>
    public partial class GitAttributeMatchService : Service<GitAttributeMatch>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GitAttributeMatchService"/> class
        /// </summary>
        /// <param name="context">The context.</param>
        public GitAttributeMatchService(RockContext context) : base(context)
        {
        }
    }

    /// <summary>
    /// Generated Extension Methods
    /// </summary>
    public static partial class GitAttributeMatchExtensionMethods
    {
        /// <summary>
        /// Clones this GitAttributeMatch object to a new GitAttributeMatch object
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="deepCopy">if set to <c>true</c> a deep copy is made. If false, only the basic entity properties are copied.</param>
        /// <returns></returns>
        public static GitAttributeMatch Clone( this GitAttributeMatch source, bool deepCopy )
        {
            if (deepCopy)
            {
                return source.Clone() as GitAttributeMatch;
            }
            else
            {
                var target = new GitAttributeMatch();
                target.CopyPropertiesFrom( source );
                return target;
            }
        }

        /// <summary>
        /// Copies the properties from another GitAttributeMatch object to this GitAttributeMatch object
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="source">The source.</param>
        public static void CopyPropertiesFrom( this GitAttributeMatch target, GitAttributeMatch source )
        {
            target.Id = source.Id;
            target.AttributeId = source.AttributeId;
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
