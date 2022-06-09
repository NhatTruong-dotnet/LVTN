using STU.LVTN.SERVER.Model;
using STU.LVTN.SERVER.Model.DTO;
using STU.LVTN.SERVER.Provider.BusinessLogic;

namespace STU.LVTN.SERVER.Provider.Handler
{
    public class ThongBaoHandler
    {
        ThongBao thongBaoHelper = new ThongBao();
        private LVTNContext _context = new LVTNContext();
        public async Task<bool> ThongBaoChecked(int IDPost)
        {
            ThongBaoEntities thongBao =_context.ThongBaos.Where(x => x.IDPost == IDPost).FirstOrDefault();
            thongBao.Checked = true;
            if (await thongBaoHelper.UpdateThongBao(thongBao))
                return true;
            return false;
        }
        public async Task<bool> AddThongBao(ThongBaoDTO thongBaoRequest)
        {
            ThongBaoEntities thongBao = new ThongBaoEntities();
            thongBao.Checked = false;
            thongBao.IDPost = thongBaoRequest.IDPost;
            thongBao.Comment = thongBaoRequest.Comment;
            thongBao.TieuDeThongBao = thongBaoRequest.TieuDeThongBao;
            thongBao.SdtNguoiDung = thongBaoRequest.SdtNguoiDung;
            await thongBaoHelper.AddThongBao(thongBao);
            return true;
        }
        public async Task<List<ThongBaoDTO>> GetAllThongBao(string sdt)
        {
            List<ThongBaoEntities> thongBaos =  _context.ThongBaos.OrderByDescending(item => item.IdThongBao).Where(item => item.SdtNguoiDung == sdt).ToList();
            List<ThongBaoDTO> result = new List<ThongBaoDTO>();
            foreach (var item in thongBaos)
            {

                ThongBaoDTO temp = new ThongBaoDTO();
                temp.Checked = item.Checked;
                temp.IDPost = item.IDPost;
                temp.Mota = item.Comment;
                temp.ImageSource = _context.HinhAnhBaiDangs.Where(baiDang => baiDang.IdSanPham == item.IDPost && baiDang.VideoType == false).First().IdMediaCloud;
                temp.TieuDeThongBao = _context.BaiDangs.Where(baiDang => baiDang.IdBaiDang == item.IDPost).First().TieuDe;
                temp.SdtNguoiDung = item.SdtNguoiDung;

                result.Add(temp);
            }
            return result;
        }
    }
}
