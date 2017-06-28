using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.bricksandmortarstudio.GitEmailTemplateSync.Model;
using RestSharp;

namespace com.bricksandmortarstudio.GitEmailTemplateSync
{
    public class Github : GitService
    {
        RestClient _client = new RestClient( "https://api.github.com" );


        public IEnumerable<GitFile> UpdateGitFiles()
        {
            throw new NotImplementedException();
        }
    }
}
