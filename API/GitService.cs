using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.bricksandmortarstudio.GitEmailTemplateSync.Model;

namespace com.bricksandmortarstudio.GitEmailTemplateSync
{
    public interface GitService
    {
        IEnumerable<GitFile> UpdateGitFiles();
        
    }
}
