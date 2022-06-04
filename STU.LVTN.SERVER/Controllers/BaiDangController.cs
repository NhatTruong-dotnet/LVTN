using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using STU.LVTN.SERVER.Model.DTO;
using STU.LVTN.SERVER.Model.DTO.BaiDangBatDongSan;
using STU.LVTN.SERVER.Model.DTO.BaiDangXeCo;
using STU.LVTN.SERVER.Model.DTO.DoAnThucPham;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;
using STU.LVTN.SERVER.Model.DTO.DoDungVanPhong;
using STU.LVTN.SERVER.Model.DTO.DoGiaDung.BanGhe;
using STU.LVTN.SERVER.Model.DTO.DoGiaDung.Bep;
using STU.LVTN.SERVER.Model.DTO.DoGiaDung.DenCayCanhNoiThat;
using STU.LVTN.SERVER.Model.DTO.DoGiaDung.Giuong;
using STU.LVTN.SERVER.Model.DTO.DoGiaDung.Quat;
using STU.LVTN.SERVER.Model.DTO.DoGiaDung.ThietBiVeSinh;
using STU.LVTN.SERVER.Model.DTO.DoGiaDung.TuKe;
using STU.LVTN.SERVER.Model.DTO.GiaiTri;
using STU.LVTN.SERVER.Model.DTO.GiaiTri.DoSuuTam;
using STU.LVTN.SERVER.Model.DTO.GiaiTri.NhacCu;
using STU.LVTN.SERVER.Model.DTO.MeVaBe;
using STU.LVTN.SERVER.Model.DTO.ThoiTrang;
using STU.LVTN.SERVER.Model.DTO.ThuCung;
using STU.LVTN.SERVER.Model.DTO.TuLanh.MayGiat;
using STU.LVTN.SERVER.Model.DTO.TuLanh.MayLanh;
using STU.LVTN.SERVER.Model.DTO.TuLanh.TuLanh;
using STU.LVTN.SERVER.Model.DTO.ViecLam;
using STU.LVTN.SERVER.Provider.Handler;

namespace STU.LVTN.SERVER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaiDangController : ControllerBase
    {
        BaiDangHandler baiDangHandler;
        private readonly IMapper _mapper;
        ThongBaoHandler thongBaoHandler;
        public BaiDangController(IMapper mapper)
        {
            _mapper = mapper;
            baiDangHandler = new BaiDangHandler(_mapper);
            thongBaoHandler = new ThongBaoHandler();
        }

        [HttpGet("renderHomepage/{lastestSubCategories?}")]
        public async Task<ActionResult<List<BaiDangHomePageDTO>>> RenderHomePage(int lastestSubCategories = 0)
        {
            return await baiDangHandler.RenderHomePage(lastestSubCategories);
        }

        [HttpGet("mySold")]
        public async Task<ActionResult<List<BaiDangHomePageDTO>>> MySoldPost(string soDienThoai)
        {
            return await baiDangHandler.GetSoldPostBySoDienThoai(soDienThoai);
        }

        [HttpGet("detail/{idPost?}")]
        public async Task<ActionResult<Dictionary<string, Dictionary<string, string>>>> GetPostByID(int idPost = 1)
        {
            return Ok(baiDangHandler.GetPostByID(idPost));
        }
        #region Create Handler
        #region BatDongSan Handler
        [HttpPost("batDongSanCC/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostBatDongSanCC(BaiDangBatDongSanCC_DTO baiDangCC_Request)
        {
            baiDangCC_Request.SdtNguoiBan = baiDangCC_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangBatDongSanCC(baiDangCC_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangCC_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("batDongSanNhaO/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostBatDongSanNhaO(BaiDangBatDongSanNhaO_DTO baiDangCC_Request)
        {
            baiDangCC_Request.SdtNguoiBan = baiDangCC_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangBatDongSanNhaO(baiDangCC_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = User.Identity.Name;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("batDongSanDat/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostBatDongSanDat(BaiDangBatDongSanDat_DTO baiDangCC_Request)
        {
            baiDangCC_Request.SdtNguoiBan = baiDangCC_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangBatDongSanDat(baiDangCC_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = User.Identity.Name;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("batDongSanVanPhong/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostBatDongSanVanPhong(BaiDangBatDongSanVanPhong_DTO baiDangCC_Request)
        {
            baiDangCC_Request.SdtNguoiBan = baiDangCC_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangBatDongSanVanPhong(baiDangCC_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = User.Identity.Name;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("batDongSanPhongTro/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostBatDongSanPhongTro(BaiDangBatDongSanPhongTro_DTO baiDangCC_Request)
        {
            baiDangCC_Request.SdtNguoiBan = baiDangCC_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangBatDongSanPhongTro(baiDangCC_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = User.Identity.Name;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        #endregion

        #region XeCo Handler
        [HttpPost("xeCoOto/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostXeCoOto(BaiDangXeCoOto_DTO baiDangOTo_Request)
        {
            baiDangOTo_Request.SdtNguoiBan = baiDangOTo_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangXeCoOTo(baiDangOTo_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = User.Identity.Name;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("xeCoXeMay/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostXeCoXeMay(BaiDangXeCoXeMay_DTO baiDangXeMay_Request)
        {
            baiDangXeMay_Request.SdtNguoiBan = baiDangXeMay_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangXeCoXeMay(baiDangXeMay_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = User.Identity.Name;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("xeCoXeTai/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostXeCoXeTai(BaiDangXeCoXeTai_DTO baiDangXeTai_Request)
        {
            baiDangXeTai_Request.SdtNguoiBan = baiDangXeTai_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangXeCoXeTai(baiDangXeTai_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = User.Identity.Name;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("xeCoXeDien/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostXeCoXeDien(BaiDangXeCoXeDien_DTO baiDangXeDien_Request)
        {
            baiDangXeDien_Request.SdtNguoiBan = baiDangXeDien_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangXeCoXeDien(baiDangXeDien_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = User.Identity.Name;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("xeCoXeDap/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostXeCoXeDap(BaiDangXeCoXeDap_DTO baiDangXeDap_Request)
        {
            baiDangXeDap_Request.SdtNguoiBan = baiDangXeDap_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangXeCoXeDap(baiDangXeDap_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = User.Identity.Name;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("xeCoPhuongTienKhac/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostXeCoPhuongTienKhac(BaiDangXeCoPhuongTienKhac_DTO baiDangPhuongTienKhac_Request)
        {
            baiDangPhuongTienKhac_Request.SdtNguoiBan = baiDangPhuongTienKhac_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangXeCoPhuongTienKhac(baiDangPhuongTienKhac_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = User.Identity.Name;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("xeCoPhuTungXe/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostXeCoPhuTungXe(BaiDangXeCoPhuTungXe_DTO baiDangPhuTungXe_Request)
        {
            baiDangPhuTungXe_Request.SdtNguoiBan = baiDangPhuTungXe_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangXeCoPhuTungKhac(baiDangPhuTungXe_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = User.Identity.Name;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }
        #endregion

        #region DoDienTu Handler
        [HttpPost("doDienTuDienThoai/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostDoDienTuDienThoai(BaiDangDoDienTuDienThoai_DTO baiDangDienThoai_Request)
        {
            baiDangDienThoai_Request.SdtNguoiBan = baiDangDienThoai_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangDoDienTuDienThoai(baiDangDienThoai_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = User.Identity.Name;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("doDienTuLaptop/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostDoDienTuLaptop(BaiDangDoDienTuLaptop_DTO baiDangLaptop_Request)
        {
            baiDangLaptop_Request.SdtNguoiBan = baiDangLaptop_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangDoDienTuLaptop(baiDangLaptop_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = User.Identity.Name;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("doDienTuLinhKien/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostDoDienTuLinhKien(BaiDangDoDienTuLinhKien_DTO baiDangLinhKien_Request)
        {
            baiDangLinhKien_Request.SdtNguoiBan = baiDangLinhKien_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangDoDienTuLinhKien(baiDangLinhKien_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangLinhKien_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("doDienTuMayAnh/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostDoDienTuMayAnh(BaiDangDoDienTuMayAnh_DTO baiDangMayAnh_Request)
        {
            baiDangMayAnh_Request.SdtNguoiBan = baiDangMayAnh_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangDoDienTuMayAnh(baiDangMayAnh_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangMayAnh_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("doDienTuMayTinhBang/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostDoDienTuMayTinhBang(BaiDangDoDienTuMayTinhBang_DTO baiDangMayTinhBang_Request)
        {
            baiDangMayTinhBang_Request.SdtNguoiBan = baiDangMayTinhBang_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangDoDienTuMayTinhBang(baiDangMayTinhBang_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangMayTinhBang_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("doDienTuMayTinhDeBan/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostDoDienTuMayTinhDeBan(BaiDangDoDienTuMayTinhDeBan_DTO baiDangMayTinhDeBan_Request)
        {
            baiDangMayTinhDeBan_Request.SdtNguoiBan = baiDangMayTinhDeBan_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangDoDienTuMayTinhDeBan(baiDangMayTinhDeBan_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangMayTinhDeBan_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("doDienTuPhuKien/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostDoDienTuPhuKien(BaiDangDoDienTuPhuKien_DTO baiDangPhuKien_Request)
        {
            baiDangPhuKien_Request.SdtNguoiBan = baiDangPhuKien_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangDoDienTuPhuKien(baiDangPhuKien_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangPhuKien_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("doDienTuThietBiDeoThongMinh/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostDoDienTuThietBiDeoThongMinh(BaiDangDoDienTuThietBiDeoThongMinh_DTO baiDangThietBiDeoThongMinh_Request)
        {
            baiDangThietBiDeoThongMinh_Request.SdtNguoiBan = baiDangThietBiDeoThongMinh_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangDoDienTuThietBiDeoThongMinh(baiDangThietBiDeoThongMinh_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangThietBiDeoThongMinh_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("doDienTuTivi/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostDoDienTuTivi(BaiDangDoDienTuTivi_DTO baiDangTivi_Request)
        {
            baiDangTivi_Request.SdtNguoiBan = baiDangTivi_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangDoDienTuTivi(baiDangTivi_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangTivi_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }
        #endregion

        #region ViecLam Handler
        [HttpPost("viecLam/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostViecLam(BaiDangViecLamDTO baiDangViecLam_Request)
        {
            baiDangViecLam_Request.SdtNguoiBan = baiDangViecLam_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangViecLam(baiDangViecLam_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangViecLam_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }
        #endregion

        #region ThuCung Handler
        [HttpPost("thuCungChim/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostThuCungChim(BaiDangThuCungChim_DTO baiDangThuCungChim_Request)
        {
            baiDangThuCungChim_Request.SdtNguoiBan = baiDangThuCungChim_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangThuCungChim(baiDangThuCungChim_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangThuCungChim_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("thuCungCho/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostThuCungCho(BaiDangThuCungCho_DTO baiDangThuCungCho_Request)
        {
            baiDangThuCungCho_Request.SdtNguoiBan = baiDangThuCungCho_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangThuCungCho(baiDangThuCungCho_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangThuCungCho_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("thuCungGaMeoThuCungKhac/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostThuCungGaMeoThuCungKhac(BaiDangThuCungGaMeoThuCungKhac_DTO baiDangThuCungGaMeoThuCungKhac_Request)
        {
            baiDangThuCungGaMeoThuCungKhac_Request.SdtNguoiBan = baiDangThuCungGaMeoThuCungKhac_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangThuCungGaMeoThuCungKhac(baiDangThuCungGaMeoThuCungKhac_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangThuCungGaMeoThuCungKhac_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }
        #endregion

        #region DoAnThucPham Handler
        [HttpPost("doAnThucPham/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostDoAnThucPham(BaiDangDoAnThucPham_DTO baiDangDoAnThucPham_Request)
        {
            baiDangDoAnThucPham_Request.SdtNguoiBan = baiDangDoAnThucPham_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangDoAnThucPham(baiDangDoAnThucPham_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangDoAnThucPham_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }
        #endregion

        #region BaiDangTuLanh Handler
        [HttpPost("baiDangTuLanh/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostTuLanh(BaiDangTuLanhTL_DTO baiDangTuLanh_Request)
        {
            baiDangTuLanh_Request.SdtNguoiBan = baiDangTuLanh_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangTuLanh(baiDangTuLanh_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangTuLanh_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("baiDangMayGiat/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostMayGiat(BaiDangTuLanhMayGiat_DTO baiDangMayGiat_Request)
        {
            baiDangMayGiat_Request.SdtNguoiBan = User.Identity.Name;
            if (await baiDangHandler.AddBaiDangMayGiat(baiDangMayGiat_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = User.Identity.Name;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("baiDangMayLanh/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostMayLanh(BaiDangTuLanhMayLanh_DTO baiDangMayLanh_Request)
        {
            baiDangMayLanh_Request.SdtNguoiBan = User.Identity.Name;
            if (await baiDangHandler.AddBaiDangMayLanh(baiDangMayLanh_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = User.Identity.Name;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }
        #endregion

        #region BaiDangDoGiaDung Handler
        [HttpPost("baiDangDoGiaDungBanGhe/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostBanGhe(BaiDangDoGiaDungBanGhe_DTO baiDangBanGhe_Request)
        {
            baiDangBanGhe_Request.SdtNguoiBan = User.Identity.Name;
            if (await baiDangHandler.AddBaiDangDoGiaDungBanGhe(baiDangBanGhe_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = User.Identity.Name;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("baiDangDoGiaDungBep/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostBep(BaiDangDoGiaDungBep_DTO baiDangBep_Request)
        {
            baiDangBep_Request.SdtNguoiBan = User.Identity.Name;
            if (await baiDangHandler.AddBaiDangDoGiaDungBep(baiDangBep_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = User.Identity.Name;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("baiDangDoGiaDungDenCayCanhNoiThat/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostDenCayCanhNoiThat(BaiDangDoGiaDungDenCayCanhNoiThat_DTO baiDangDenCayCanhNoiThat_Request)
        {
            baiDangDenCayCanhNoiThat_Request.SdtNguoiBan = User.Identity.Name;
            if (await baiDangHandler.AddBaiDangDoGiaDungDenCayCanhNoiThat(baiDangDenCayCanhNoiThat_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = User.Identity.Name;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("baiDangDoGiaDungGiuong/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostGiuong(BaiDangDoGiaDungGiuong_DTO baiDangGiuong_Request)
        {
            baiDangGiuong_Request.SdtNguoiBan = User.Identity.Name;
            if (await baiDangHandler.AddBaiDangDoGiaDungGiuong(baiDangGiuong_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = User.Identity.Name;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("baiDangDoGiaDungQuat/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostQuat(BaiDangDoGiaDungQuat_DTO baiDangQuat_Request)
        {
            baiDangQuat_Request.SdtNguoiBan = User.Identity.Name;
            if (await baiDangHandler.AddBaiDangDoGiaDungQuat(baiDangQuat_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = User.Identity.Name;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("baiDangDoGiaDungThietBiVeSinh/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostThietBiVeSinh(BaiDangDoGiaDungThietBiVeSinh_DTO baiDangThietBiVeSinh_Request)
        {
            baiDangThietBiVeSinh_Request.SdtNguoiBan = User.Identity.Name;
            if (await baiDangHandler.AddBaiDangDoGiaDungThietBiVeSinh(baiDangThietBiVeSinh_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = User.Identity.Name;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("baiDangDoGiaDungTuKe/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostTuKe(BaiDangDoGiaDungTuKe_DTO baiDangTuKe_Request)
        {
            baiDangTuKe_Request.SdtNguoiBan = User.Identity.Name;
            if (await baiDangHandler.AddBaiDangDoGiaDungTuKe(baiDangTuKe_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = User.Identity.Name;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }
        #endregion

        #region MevaBe Handler
        [HttpPost("baiDangMeVaBe/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostMeVaBe(BaiDangMeVaBe_DTO baiDangMeVabe_Request)
        {
            baiDangMeVabe_Request.SdtNguoiBan = User.Identity.Name;
            if (await baiDangHandler.AddBaiDangMeVaBe(baiDangMeVabe_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = User.Identity.Name;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }
        #endregion

        #region ThoiTrang Handler
        [HttpPost("baiDangThoiTrang/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostThoiTrang(BaiDangThoiTrang_DTO baiDangThoiTrang_Request)
        {
            baiDangThoiTrang_Request.SdtNguoiBan = User.Identity.Name;
            if (await baiDangHandler.AddBaiDangThoiTrang(baiDangThoiTrang_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = User.Identity.Name;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }
        #endregion

        #region GiaiTri Handler
        [HttpPost("baiDangGiaiTri/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostGiaiTri(BaiDangGiaiTri_DTO baiDangGiaiTri_Request)
        {
            baiDangGiaiTri_Request.SdtNguoiBan = User.Identity.Name;
            if (await baiDangHandler.AddBaiDangGiaiTri(baiDangGiaiTri_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = User.Identity.Name;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("baiDangGiaiTriDoSuuTam/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostGiaiTriDoSuuTam(BaiDangGiaiTriDoSuuTam_DTO baiDangGiaiTriDoSuuTam_Request)
        {
            baiDangGiaiTriDoSuuTam_Request.SdtNguoiBan = User.Identity.Name;
            if (await baiDangHandler.AddBaiDangGiaiTriDoSuuTam(baiDangGiaiTriDoSuuTam_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = User.Identity.Name;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("baiDangGiaiTriNhacCu/newPost")]
        public async Task<ActionResult<bool>> newPostGiaiTriNhacCu(BaiDangGiaiTriDoNhacCu_DTO baiDangGiaiTriDoNhacCu_Request)
        {
            baiDangGiaiTriDoNhacCu_Request.SdtNguoiBan = User.Identity.Name;
            if (await baiDangHandler.AddBaiDangGiaiTriNhacCu(baiDangGiaiTriDoNhacCu_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = User.Identity.Name;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }
        #endregion

        #region DoDungVanPhong Handler
        [HttpPost("baiDangDoDungVanPhong/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostDoDungVanPhong(BaiDangDoDungVanPhong_DTO baiDangDoDungVanPhong_Request)
        {
            baiDangDoDungVanPhong_Request.SdtNguoiBan = User.Identity.Name;
            if (await baiDangHandler.AddBaiDangDoDungVanPhong(baiDangDoDungVanPhong_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = User.Identity.Name;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }
        #endregion

        #endregion

        [HttpPost("checkedNotifications")]
        public async Task<ActionResult> CheckedNotifycations(int idPost = 1)
        {
            if (await thongBaoHandler.ThongBaoChecked(idPost))
                return Ok(true);
            return BadRequest();
        }

        [HttpPost("sendApproveResult/{resultApprove?}/{IDPost?}")]
        public async Task<ActionResult> SendApproveResult(bool resultApprove, int IDPost )
        {
            if (await baiDangHandler.SendApproveResult(resultApprove, IDPost))
                return Ok(true);
            return BadRequest();
        }
    }
}
