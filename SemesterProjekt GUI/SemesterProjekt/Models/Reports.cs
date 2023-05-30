using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProjekt.Models
{
    public class Reports
    {
        private DateTime Date { get; set; }
        /// <summary>
        /// Constructor 
        /// </summary>
        public Reports(DateTime date)
        {
            this.Date = date;
        }
    }
}
