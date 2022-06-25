using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using STU.LVTN.SERVER.Model.DTO;
using STU.LVTN.SERVER.Provider.Handler;

namespace STU.LVTN.SERVER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilterController : ControllerBase
    {
        private readonly IMapper _mapper;
        SearchHandler searchHandler;
        public FilterController(IMapper mapper)
        {
            _mapper = mapper;
            searchHandler = new SearchHandler(_mapper);
        }
        [HttpGet("{idDanhMucCha}/{idDanhMucCon?}/{queryString?}")]
        public async Task<ActionResult<List<BaiDangHomePageDTO>>> Filter(int idDanhMucCha, int idDanhMucCon = -1, string? queryString = "null")
        {
            return await searchHandler.Filter(idDanhMucCha, idDanhMucCon, queryString);
        }
    }
}
