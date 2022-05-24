using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO;

namespace STU.LVTN.SERVER.Provider.BusinessLogic
{
    public class Search
    {
        private readonly IMapper _mapper;
        private LVTNContext _context = new LVTNContext();
        public Search(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<BaiDangHomePageDTO> SearchLogic(string searchParams = "")
        {
            List<BaiDangEntities> resultSearchWithParams = _context.BaiDangs.Where(item => item.TieuDe.Contains(searchParams)).ToList();
            List<BaiDangHomePageDTO> mapped = _mapper.Map<List<BaiDangHomePageDTO>>(resultSearchWithParams);
            return mapped;
        }
    }
}
