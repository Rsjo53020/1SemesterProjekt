using SemesterProjekt._Unused_GUI_;
using SemesterProjekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProjekt.Services
{
    public class IntelligentRådgivning
    {
        List<string> intelligentRådgivning = new List<string>();

        public void FilterSearchResult(List<string> AiResult)
        {
            AIResult aIResult = new AIResult();
            aIResult.Show();
            
            intelligentRådgivning = AiResult;
        }

    }


}
