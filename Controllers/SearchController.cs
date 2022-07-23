using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO;
using STU.LVTN.SERVER.Provider.Handler;

namespace STU.LVTN.SERVER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController
    {
        private readonly IMapper _mapper;
        private LVTNContext _context = new LVTNContext();
        SearchHandler searchHandler ;
        public SearchController(IMapper mapper)
        {
            _mapper = mapper;
            searchHandler = new SearchHandler(_mapper);
        }
        [HttpGet("{searchParams}")]
        public async Task<ActionResult<List<BaiDangHomePageDTO>>> SearchPost(string searchParams = "")
        {
            return await searchHandler.Search(searchParams);
        }
        [HttpGet("{idDanhMucCha}/{idDanhMucCon?}/{queryString?}")]
        public async Task<ActionResult<List<BaiDangHomePageDTO>>> Filter(int idDanhMucCha, int idDanhMucCon = -1, string? queryString = "null")
        {
            return await searchHandler.Filter(idDanhMucCha, idDanhMucCon, queryString);
        }
    }
}
