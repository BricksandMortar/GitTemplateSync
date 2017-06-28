using System.Collections.Generic;
using com.bricksandmortarstudio.GitEmailTemplateSync.Model;

namespace com.bricksandmortarstudio.GitEmailTemplateSync.API
{
    public interface IGitService
    {
        IEnumerable<GitFile> UpdateGitFiles();
        
    }
}
