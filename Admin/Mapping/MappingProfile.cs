using Admin.Models.Crud;
using AutoMapper;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Mapping
{
    public class MappingProfile:Profile
    { 
        public MappingProfile()
        {
            CreateMap<Caption, CaptionViewModel>();
            CreateMap<PersonPhoto, CaptionPhotoViewModel>();

        }
    }
}
