using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.Crud
{
    public class CaptionViewModel
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public PersonPhoto Photo { get; set; }
        public ICollection<CaptionIcon> Icons { get; set; }

    }
}
