using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Admin.Models.Crud;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositeries.ContentRepositories;

namespace Admin.Controllers
{
    [TypeFilter(typeof(Auth))]
    public class SkillController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IMapper _mapper;
        private readonly IContentRepository _contentRepository;
        public SkillController(IMapper mapper, IContentRepository contentRepository)
        {
            _mapper = mapper;
            _contentRepository = contentRepository;
        }
        public IActionResult Index()
        {
            var list = _contentRepository.GetSkill();
            var model = _mapper.Map<IEnumerable<SkillValue>, IEnumerable<SkillViewModel>>(list);
            return View(model);
        }
    }
}