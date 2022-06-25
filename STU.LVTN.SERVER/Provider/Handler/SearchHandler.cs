using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using STU.LVTN.SERVER.Model.DTO;
using STU.LVTN.SERVER.Provider.BusinessLogic;

namespace STU.LVTN.SERVER.Provider.Handler
{
    public class SearchHandler
    {
        private readonly IMapper _mapper;
        Search searchHelper;
        public SearchHandler(IMapper mapper)
        {
            _mapper = mapper;
            searchHelper = new Search(_mapper);
        }
        public async Task<List<BaiDangHomePageDTO>> Search(string searchParams = "")
        {
            return searchHelper.SearchLogic(searchParams);
        }
        public async Task<List<BaiDangHomePageDTO>> Filter(int idDanhMucCha, int idDanhMucCon, string? queryString )
        {
            return searchHelper.Filter(idDanhMucCha, idDanhMucCon, queryString);
        }
    }
}
