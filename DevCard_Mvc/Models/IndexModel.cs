using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace DevCard_Mvc.Models
{
    public class IndexModel
    {
        public List<Project>Projects { set; get; }
        public List<Article> Articles { get; set; }
        
    }
}
