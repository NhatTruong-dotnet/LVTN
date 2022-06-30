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

        public  List<BaiDangHomePageDTO> FilterStatus(int statusFilter, string sdt)
        {
            switch (statusFilter)
            {
                case 0:
                     return  searchHelper.GetAllBaiDang(sdt);
                    break;
                case 1:
                    return searchHelper.GetBaiDangApprove(sdt);
                    break;
                case 2:
                    return searchHelper.GetBaiDangApprove(sdt);
                    break;
                case 3:
                    return searchHelper.GetBaiDangNotReviewed(sdt);
                    break;
                case 4:
                    return searchHelper.GetBaiDangReject(sdt);
                    break;
                case 5:
                    return searchHelper.GetBaiDangDeactive(sdt);
                    break;
                default:
                    return new List<BaiDangHomePageDTO>();
                    break;
            }
        }
    }
}
