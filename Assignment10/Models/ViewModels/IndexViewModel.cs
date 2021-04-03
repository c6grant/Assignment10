using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment10.Models.ViewModels
{
    public class IndexViewModel
    {

        //Index View Model to filter down to Bowlers, help w/ PageNumbInfo, and Team Name
        
        public List<Bowlers> Bowlers { get; set; }

        public PageNumberingInfo PageNumberingInfo { get; set; }

        public string Team { get; set; }


    }
}
