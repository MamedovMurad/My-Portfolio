using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.Crud
{
    public class CaptionPhotoViewModel
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public string Photo { get; set; }
        public ICollection<Info> Infos { get; set; }
        public ICollection<CaptionViewModel> Captions { get; set; }
    }
}
