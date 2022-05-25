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
            resultSearchWithParams.AddRange(_context.BaiDangs.Where(item => item.Mota.Contains(searchParams)).ToList());
            List<BaiDangHomePageDTO> result = new List<BaiDangHomePageDTO>();
            if (resultSearchWithParams.Count > 0)
            {
                int idDanhMucCha = resultSearchWithParams[0].IdDanhMucCha;
                int idDanhMucCon = (int)resultSearchWithParams[0].IdDanhMucCon;
                resultSearchWithParams = new List<BaiDangEntities>();
                if (idDanhMucCha == 0)
                {
                    resultSearchWithParams.AddRange(_context.BaiDangs.Where(item => item.IdDanhMucCon == idDanhMucCon).ToList());
                    result = mapEntitiesToDTO(resultSearchWithParams);
                }
                else
                {
                    resultSearchWithParams.AddRange(_context.BaiDangs.Where(item => item.IdDanhMucCha == idDanhMucCha).ToList());
                    result = mapEntitiesToDTO(resultSearchWithParams);

                }
            }
            return result;
        }
        private List<BaiDangHomePageDTO> mapEntitiesToDTO(List<BaiDangEntities> source)
        {
            List<BaiDangHomePageDTO> result = new List<BaiDangHomePageDTO>();
            foreach (BaiDangEntities entity in source)
            {
                BaiDangHomePageDTO post = new BaiDangHomePageDTO();
                post.Gia = entity.Gia;
                post.TieuDe = entity.TieuDe;
                post.NgayTao = entity.CreatedDate;
                post.ThanhPho = entity.ThanhPho;
                post.TieuDe = entity.TieuDe;
                post.IDBaiDang = entity.IdBaiDang;
                string idHinhAnh = _context.HinhAnhBaiDangs.Where(item => item.IdSanPham == entity.IdBaiDang && item.VideoType == false).First().IdMediaCloud;
                post.IDHinhAnh = idHinhAnh;
                result.Add(post);
            }
            return result;
        }
    }
}
