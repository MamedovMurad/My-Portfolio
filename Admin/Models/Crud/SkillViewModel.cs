using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.Crud
{
    public class SkillViewModel
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public string Logo { get; set; }

        public string Title { get; set; }

        public string Detail { get; set; }
    }
}
