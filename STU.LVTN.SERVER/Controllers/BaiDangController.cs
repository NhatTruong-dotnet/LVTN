using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using STU.LVTN.SERVER.Model;
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
                thongBao.SdtNguoiDung = baiDangCC_Request.SdtNguoiBan;
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
                thongBao.SdtNguoiDung = baiDangCC_Request.SdtNguoiBan;
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
                thongBao.SdtNguoiDung = baiDangCC_Request.SdtNguoiBan;
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
                thongBao.SdtNguoiDung = baiDangCC_Request.SdtNguoiBan;
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
                thongBao.SdtNguoiDung = baiDangOTo_Request.SdtNguoiBan;
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
                thongBao.SdtNguoiDung = baiDangXeTai_Request.SdtNguoiBan;
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
                thongBao.SdtNguoiDung = baiDangXeDien_Request.SdtNguoiBan;
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
                thongBao.SdtNguoiDung = baiDangXeDap_Request.SdtNguoiBan;
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
                thongBao.SdtNguoiDung = baiDangPhuongTienKhac_Request.SdtNguoiBan;
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
                thongBao.SdtNguoiDung = baiDangPhuTungXe_Request.SdtNguoiBan;
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
                thongBao.SdtNguoiDung = baiDangDienThoai_Request.SdtNguoiBan;
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
                thongBao.SdtNguoiDung = baiDangLaptop_Request.SdtNguoiBan;
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
            baiDangMayGiat_Request.SdtNguoiBan = baiDangMayGiat_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangMayGiat(baiDangMayGiat_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangMayGiat_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("baiDangMayLanh/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostMayLanh(BaiDangTuLanhMayLanh_DTO baiDangMayLanh_Request)
        {
            baiDangMayLanh_Request.SdtNguoiBan = baiDangMayLanh_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangMayLanh(baiDangMayLanh_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangMayLanh_Request.SdtNguoiBan;
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
            baiDangBanGhe_Request.SdtNguoiBan = baiDangBanGhe_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangDoGiaDungBanGhe(baiDangBanGhe_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangBanGhe_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("baiDangDoGiaDungBep/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostBep(BaiDangDoGiaDungBep_DTO baiDangBep_Request)
        {
            baiDangBep_Request.SdtNguoiBan = baiDangBep_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangDoGiaDungBep(baiDangBep_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangBep_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("baiDangDoGiaDungDenCayCanhNoiThat/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostDenCayCanhNoiThat(BaiDangDoGiaDungDenCayCanhNoiThat_DTO baiDangDenCayCanhNoiThat_Request)
        {
            baiDangDenCayCanhNoiThat_Request.SdtNguoiBan = baiDangDenCayCanhNoiThat_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangDoGiaDungDenCayCanhNoiThat(baiDangDenCayCanhNoiThat_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangDenCayCanhNoiThat_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("baiDangDoGiaDungGiuong/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostGiuong(BaiDangDoGiaDungGiuong_DTO baiDangGiuong_Request)
        {
            baiDangGiuong_Request.SdtNguoiBan = baiDangGiuong_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangDoGiaDungGiuong(baiDangGiuong_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangGiuong_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("baiDangDoGiaDungQuat/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostQuat(BaiDangDoGiaDungQuat_DTO baiDangQuat_Request)
        {
            baiDangQuat_Request.SdtNguoiBan = baiDangQuat_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangDoGiaDungQuat(baiDangQuat_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangQuat_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("baiDangDoGiaDungThietBiVeSinh/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostThietBiVeSinh(BaiDangDoGiaDungThietBiVeSinh_DTO baiDangThietBiVeSinh_Request)
        {
            baiDangThietBiVeSinh_Request.SdtNguoiBan = baiDangThietBiVeSinh_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangDoGiaDungThietBiVeSinh(baiDangThietBiVeSinh_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangThietBiVeSinh_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("baiDangDoGiaDungTuKe/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostTuKe(BaiDangDoGiaDungTuKe_DTO baiDangTuKe_Request)
        {
            baiDangTuKe_Request.SdtNguoiBan = baiDangTuKe_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangDoGiaDungTuKe(baiDangTuKe_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangTuKe_Request.SdtNguoiBan;
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
            baiDangMeVabe_Request.SdtNguoiBan = baiDangMeVabe_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangMeVaBe(baiDangMeVabe_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangMeVabe_Request.SdtNguoiBan;
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
            baiDangThoiTrang_Request.SdtNguoiBan = baiDangThoiTrang_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangThoiTrang(baiDangThoiTrang_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangThoiTrang_Request.SdtNguoiBan;
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
            baiDangGiaiTri_Request.SdtNguoiBan = baiDangGiaiTri_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangGiaiTri(baiDangGiaiTri_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangGiaiTri_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("baiDangGiaiTriDoSuuTam/newPost"), Authorize]
        public async Task<ActionResult<bool>> newPostGiaiTriDoSuuTam(BaiDangGiaiTriDoSuuTam_DTO baiDangGiaiTriDoSuuTam_Request)
        {
            baiDangGiaiTriDoSuuTam_Request.SdtNguoiBan = baiDangGiaiTriDoSuuTam_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangGiaiTriDoSuuTam(baiDangGiaiTriDoSuuTam_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangGiaiTriDoSuuTam_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("baiDangGiaiTriNhacCu/newPost")]
        public async Task<ActionResult<bool>> newPostGiaiTriNhacCu(BaiDangGiaiTriDoNhacCu_DTO baiDangGiaiTriDoNhacCu_Request)
        {
            baiDangGiaiTriDoNhacCu_Request.SdtNguoiBan = baiDangGiaiTriDoNhacCu_Request.SdtNguoiBan;
            if (await baiDangHandler.AddBaiDangGiaiTriNhacCu(baiDangGiaiTriDoNhacCu_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangGiaiTriDoNhacCu_Request.SdtNguoiBan;
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
            baiDangDoDungVanPhong_Request.SdtNguoiBan = baiDangDoDungVanPhong_Request.SdtNguoiBan;
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

        #region Update Hanlder
        #region BatDongSan Handler
        [HttpPut("batDongSanCC/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostBatDongSanCC(BaiDangBatDongSanCC_DTO baiDangCC_Request)
        {
            baiDangCC_Request.SdtNguoiBan = baiDangCC_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangBatDongSanCC(baiDangCC_Request))
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

        [HttpPut("batDongSanNhaO/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostBatDongSanNhaO(BaiDangBatDongSanNhaO_DTO baiDangCC_Request)
        {
            baiDangCC_Request.SdtNguoiBan = baiDangCC_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangBatDongSanNhaO(baiDangCC_Request))
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

        [HttpPut("batDongSanDat/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostBatDongSanDat(BaiDangBatDongSanDat_DTO baiDangCC_Request)
        {
            baiDangCC_Request.SdtNguoiBan = baiDangCC_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangBatDongSanDat(baiDangCC_Request))
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

        [HttpPut("batDongSanVanPhong/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostBatDongSanVanPhong(BaiDangBatDongSanVanPhong_DTO baiDangCC_Request)
        {
            baiDangCC_Request.SdtNguoiBan = baiDangCC_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangBatDongSanVanPhong(baiDangCC_Request))
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

        [HttpPut("batDongSanPhongTro/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostBatDongSanPhongTro(BaiDangBatDongSanPhongTro_DTO baiDangCC_Request)
        {
            baiDangCC_Request.SdtNguoiBan = baiDangCC_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangBatDongSanPhongTro(baiDangCC_Request))
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

        #endregion

        #region XeCo Handler
        [HttpPut("xeCoOto/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostXeCoOto(BaiDangXeCoOto_DTO baiDangOTo_Request)
        {
            baiDangOTo_Request.SdtNguoiBan = baiDangOTo_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangXeCoOTo(baiDangOTo_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangOTo_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut("xeCoXeMay/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostXeCoXeMay(BaiDangXeCoXeMay_DTO baiDangXeMay_Request)
        {
            baiDangXeMay_Request.SdtNguoiBan = baiDangXeMay_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangXeCoXeMay(baiDangXeMay_Request))
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

        [HttpPut("xeCoXeTai/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostXeCoXeTai(BaiDangXeCoXeTai_DTO baiDangXeTai_Request)
        {
            baiDangXeTai_Request.SdtNguoiBan = baiDangXeTai_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangXeCoXeTai(baiDangXeTai_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangXeTai_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut("xeCoXeDien/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostXeCoXeDien(BaiDangXeCoXeDien_DTO baiDangXeDien_Request)
        {
            baiDangXeDien_Request.SdtNguoiBan = baiDangXeDien_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangXeCoXeDien(baiDangXeDien_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangXeDien_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut("xeCoXeDap/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostXeCoXeDap(BaiDangXeCoXeDap_DTO baiDangXeDap_Request)
        {
            baiDangXeDap_Request.SdtNguoiBan = baiDangXeDap_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangXeCoXeDap(baiDangXeDap_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangXeDap_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut("xeCoPhuongTienKhac/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostXeCoPhuongTienKhac(BaiDangXeCoPhuongTienKhac_DTO baiDangPhuongTienKhac_Request)
        {
            baiDangPhuongTienKhac_Request.SdtNguoiBan = baiDangPhuongTienKhac_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangXeCoPhuongTienKhac(baiDangPhuongTienKhac_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangPhuongTienKhac_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut("xeCoPhuTungXe/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostXeCoPhuTungXe(BaiDangXeCoPhuTungXe_DTO baiDangPhuTungXe_Request)
        {
            baiDangPhuTungXe_Request.SdtNguoiBan = baiDangPhuTungXe_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangXeCoPhuTungKhac(baiDangPhuTungXe_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangPhuTungXe_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }
        #endregion

        #region DoDienTu Handler
        [HttpPut("doDienTuDienThoai/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostDoDienTuDienThoai(BaiDangDoDienTuDienThoai_DTO baiDangDienThoai_Request)
        {
            baiDangDienThoai_Request.SdtNguoiBan = baiDangDienThoai_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangDoDienTuDienThoai(baiDangDienThoai_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangDienThoai_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut("doDienTuLaptop/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostDoDienTuLaptop(BaiDangDoDienTuLaptop_DTO baiDangLaptop_Request)
        {
            baiDangLaptop_Request.SdtNguoiBan = baiDangLaptop_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangDoDienTuLaptop(baiDangLaptop_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangLaptop_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("doDienTuLinhKien/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostDoDienTuLinhKien(BaiDangDoDienTuLinhKien_DTO baiDangLinhKien_Request)
        {
            baiDangLinhKien_Request.SdtNguoiBan = baiDangLinhKien_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangDoDienTuLinhKien(baiDangLinhKien_Request))
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

        [HttpPost("doDienTuMayAnh/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostDoDienTuMayAnh(BaiDangDoDienTuMayAnh_DTO baiDangMayAnh_Request)
        {
            baiDangMayAnh_Request.SdtNguoiBan = baiDangMayAnh_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangDoDienTuMayAnh(baiDangMayAnh_Request))
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

        [HttpPut("doDienTuMayTinhBang/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostDoDienTuMayTinhBang(BaiDangDoDienTuMayTinhBang_DTO baiDangMayTinhBang_Request)
        {
            baiDangMayTinhBang_Request.SdtNguoiBan = baiDangMayTinhBang_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangDoDienTuMayTinhBang(baiDangMayTinhBang_Request))
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

        [HttpPut("doDienTuMayTinhDeBan/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostDoDienTuMayTinhDeBan(BaiDangDoDienTuMayTinhDeBan_DTO baiDangMayTinhDeBan_Request)
        {
            baiDangMayTinhDeBan_Request.SdtNguoiBan = baiDangMayTinhDeBan_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangDoDienTuMayTinhDeBan(baiDangMayTinhDeBan_Request))
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

        [HttpPut("doDienTuPhuKien/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostDoDienTuPhuKien(BaiDangDoDienTuPhuKien_DTO baiDangPhuKien_Request)
        {
            baiDangPhuKien_Request.SdtNguoiBan = baiDangPhuKien_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangDoDienTuPhuKien(baiDangPhuKien_Request))
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

        [HttpPut("doDienTuThietBiDeoThongMinh/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostDoDienTuThietBiDeoThongMinh(BaiDangDoDienTuThietBiDeoThongMinh_DTO baiDangThietBiDeoThongMinh_Request)
        {
            baiDangThietBiDeoThongMinh_Request.SdtNguoiBan = baiDangThietBiDeoThongMinh_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangDoDienTuThietBiDeoThongMinh(baiDangThietBiDeoThongMinh_Request))
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

        [HttpPut("doDienTuTivi/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostDoDienTuTivi(BaiDangDoDienTuTivi_DTO baiDangTivi_Request)
        {
            baiDangTivi_Request.SdtNguoiBan = baiDangTivi_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangDoDienTuTivi(baiDangTivi_Request))
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
        [HttpPut("viecLam/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostViecLam(BaiDangViecLamDTO baiDangViecLam_Request)
        {
            baiDangViecLam_Request.SdtNguoiBan = baiDangViecLam_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangViecLam(baiDangViecLam_Request))
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
        [HttpPut("thuCungChim/newPost"), Authorize]
        public async Task<ActionResult<bool>> updatePostThuCungChim(BaiDangThuCungChim_DTO baiDangThuCungChim_Request)
        {
            baiDangThuCungChim_Request.SdtNguoiBan = baiDangThuCungChim_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangThuCungChim(baiDangThuCungChim_Request))
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

        [HttpPut("thuCungCho/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostThuCungCho(BaiDangThuCungCho_DTO baiDangThuCungCho_Request)
        {
            baiDangThuCungCho_Request.SdtNguoiBan = baiDangThuCungCho_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangThuCungCho(baiDangThuCungCho_Request))
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

        [HttpPut("thuCungGaMeoThuCungKhac/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostThuCungGaMeoThuCungKhac(BaiDangThuCungGaMeoThuCungKhac_DTO baiDangThuCungGaMeoThuCungKhac_Request)
        {
            baiDangThuCungGaMeoThuCungKhac_Request.SdtNguoiBan = baiDangThuCungGaMeoThuCungKhac_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangThuCungGaMeoThuCungKhac(baiDangThuCungGaMeoThuCungKhac_Request))
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
        [HttpPut("doAnThucPham/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostDoAnThucPham(BaiDangDoAnThucPham_DTO baiDangDoAnThucPham_Request)
        {
            baiDangDoAnThucPham_Request.SdtNguoiBan = baiDangDoAnThucPham_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangDoAnThucPham(baiDangDoAnThucPham_Request))
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
        [HttpPut("baiDangTuLanh/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostTuLanh(BaiDangTuLanhTL_DTO baiDangTuLanh_Request)
        {
            baiDangTuLanh_Request.SdtNguoiBan = baiDangTuLanh_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangTuLanh(baiDangTuLanh_Request))
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

        [HttpPut("baiDangMayGiat/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostMayGiat(BaiDangTuLanhMayGiat_DTO baiDangMayGiat_Request)
        {
            baiDangMayGiat_Request.SdtNguoiBan = baiDangMayGiat_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangMayGiat(baiDangMayGiat_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangMayGiat_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut("baiDangMayLanh/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostMayLanh(BaiDangTuLanhMayLanh_DTO baiDangMayLanh_Request)
        {
            baiDangMayLanh_Request.SdtNguoiBan = baiDangMayLanh_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangMayLanh(baiDangMayLanh_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangMayLanh_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }
        #endregion

        #region BaiDangDoGiaDung Handler
        [HttpPut("baiDangDoGiaDungBanGhe/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostBanGhe(BaiDangDoGiaDungBanGhe_DTO baiDangBanGhe_Request)
        {
            baiDangBanGhe_Request.SdtNguoiBan = baiDangBanGhe_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangDoGiaDungBanGhe(baiDangBanGhe_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangBanGhe_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut("baiDangDoGiaDungBep/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostBep(BaiDangDoGiaDungBep_DTO baiDangBep_Request)
        {
            baiDangBep_Request.SdtNguoiBan = baiDangBep_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangDoGiaDungBep(baiDangBep_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangBep_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut("baiDangDoGiaDungDenCayCanhNoiThat/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostDenCayCanhNoiThat(BaiDangDoGiaDungDenCayCanhNoiThat_DTO baiDangDenCayCanhNoiThat_Request)
        {
            baiDangDenCayCanhNoiThat_Request.SdtNguoiBan = baiDangDenCayCanhNoiThat_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangDoGiaDungDenCayCanhNoiThat(baiDangDenCayCanhNoiThat_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangDenCayCanhNoiThat_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut("baiDangDoGiaDungGiuong/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostGiuong(BaiDangDoGiaDungGiuong_DTO baiDangGiuong_Request)
        {
            baiDangGiuong_Request.SdtNguoiBan = baiDangGiuong_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangDoGiaDungGiuong(baiDangGiuong_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangGiuong_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut("baiDangDoGiaDungQuat/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostQuat(BaiDangDoGiaDungQuat_DTO baiDangQuat_Request)
        {
            baiDangQuat_Request.SdtNguoiBan = baiDangQuat_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangDoGiaDungQuat(baiDangQuat_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangQuat_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut("baiDangDoGiaDungThietBiVeSinh/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostThietBiVeSinh(BaiDangDoGiaDungThietBiVeSinh_DTO baiDangThietBiVeSinh_Request)
        {
            baiDangThietBiVeSinh_Request.SdtNguoiBan = baiDangThietBiVeSinh_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangDoGiaDungThietBiVeSinh(baiDangThietBiVeSinh_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangThietBiVeSinh_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut("baiDangDoGiaDungTuKe/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostTuKe(BaiDangDoGiaDungTuKe_DTO baiDangTuKe_Request)
        {
            baiDangTuKe_Request.SdtNguoiBan = baiDangTuKe_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangDoGiaDungTuKe(baiDangTuKe_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangTuKe_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }
        #endregion

        #region MevaBe Handler
        [HttpPut("baiDangMeVaBe/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostMeVaBe(BaiDangMeVaBe_DTO baiDangMeVabe_Request)
        {
            baiDangMeVabe_Request.SdtNguoiBan = baiDangMeVabe_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangMeVaBe(baiDangMeVabe_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangMeVabe_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }
        #endregion

        #region ThoiTrang Handler
        [HttpPut("baiDangThoiTrang/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostThoiTrang(BaiDangThoiTrang_DTO baiDangThoiTrang_Request)
        {
            baiDangThoiTrang_Request.SdtNguoiBan = baiDangThoiTrang_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangThoiTrang(baiDangThoiTrang_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangThoiTrang_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }
        #endregion

        #region GiaiTri Handler
        [HttpPut("baiDangGiaiTri/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostGiaiTri(BaiDangGiaiTri_DTO baiDangGiaiTri_Request)
        {
            baiDangGiaiTri_Request.SdtNguoiBan = baiDangGiaiTri_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangGiaiTri(baiDangGiaiTri_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangGiaiTri_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut("baiDangGiaiTriDoSuuTam/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostGiaiTriDoSuuTam(BaiDangGiaiTriDoSuuTam_DTO baiDangGiaiTriDoSuuTam_Request)
        {
            baiDangGiaiTriDoSuuTam_Request.SdtNguoiBan = baiDangGiaiTriDoSuuTam_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangGiaiTriDoSuuTam(baiDangGiaiTriDoSuuTam_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangGiaiTriDoSuuTam_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut("baiDangGiaiTriNhacCu/updatePost")]
        public async Task<ActionResult<bool>> updatePostGiaiTriNhacCu(BaiDangGiaiTriDoNhacCu_DTO baiDangGiaiTriDoNhacCu_Request)
        {
            baiDangGiaiTriDoNhacCu_Request.SdtNguoiBan = baiDangGiaiTriDoNhacCu_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangGiaiTriNhacCu(baiDangGiaiTriDoNhacCu_Request))
            {
                ThongBaoDTO thongBao = new ThongBaoDTO();
                thongBao.Checked = false;
                thongBao.IDPost = baiDangHandler.NumberOfPost();
                thongBao.TieuDeThongBao = "Bạn có một bài đăng cần được phê duyệt";
                thongBao.SdtNguoiDung = baiDangGiaiTriDoNhacCu_Request.SdtNguoiBan;
                await thongBaoHandler.AddThongBao(thongBao);
                return Ok();
            }
            return BadRequest();
        }
        #endregion

        #region DoDungVanPhong Handler
        [HttpPut("baiDangDoDungVanPhong/updatePost"), Authorize]
        public async Task<ActionResult<bool>> updatePostDoDungVanPhong(BaiDangDoDungVanPhong_DTO baiDangDoDungVanPhong_Request)
        {
            baiDangDoDungVanPhong_Request.SdtNguoiBan = baiDangDoDungVanPhong_Request.SdtNguoiBan;
            if (await baiDangHandler.UpdateBaiDangDoDungVanPhong(baiDangDoDungVanPhong_Request))
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

        #region GetDetailForUpdate
        #region BatDongSan Handler
        [HttpGet("batDongSanCC/preflight"), Authorize]
        public async Task<ActionResult<BaiDangBatDongSanCC_DTO>> preflightPostBatDongSanCC(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangBatDongSanCC(IdPost);
        }

        [HttpGet("batDongSanDat/preflight"), Authorize]
        public async Task<ActionResult<BaiDangBatDongSanDat_DTO>> preflightPostBatDongSanDat(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangBatDongSanDat(IdPost);
        }

        [HttpGet("batDongSanNhaO/preflight"), Authorize]
        public async Task<ActionResult<BaiDangBatDongSanNhaO_DTO>> preflightPostBatDongSanNhaO(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangBatDongSanNhaO(IdPost);
        }

        [HttpGet("batDongSanPhongTro/preflight"), Authorize]
        public async Task<ActionResult<BaiDangBatDongSanPhongTro_DTO>> preflightPostBatDongSanPhongTro(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangBatDongSanPhongTro(IdPost);
        }

        [HttpGet("batDongSanVanPhong/preflight"), Authorize]
        public async Task<ActionResult<BaiDangBatDongSanVanPhong_DTO>> preflightPostBatDongSanVanPhong(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangBatDongSanVanPhong(IdPost);
        }
        #endregion

        #region XeCo Handler
        [HttpGet("xeCoOto/preflight"), Authorize]
        public async Task<ActionResult<BaiDangXeCoOto_DTO>> preflightPostXeCoOto(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangXeCoOTo(IdPost);
        }

        [HttpGet("xeCoXeMay/preflight"), Authorize]
        public async Task<ActionResult<BaiDangXeCoXeMay_DTO>> preflightPostXeCoXeMay(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangXeCoXeMay(IdPost);
        }

        [HttpGet("xeCoXeTai/preflight"), Authorize]
        public async Task<ActionResult<BaiDangXeCoXeTai_DTO>> preflightPostXeCoXeTai(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangXeCoXeTai(IdPost);
        }

        [HttpGet("xeCoXeDien/preflight"), Authorize]
        public async Task<ActionResult<BaiDangXeCoXeDien_DTO>> preflightPostXeCoXeDien(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangXeCoXeDien(IdPost);
        }

        [HttpGet("xeCoXeDap/preflight"), Authorize]
        public async Task<ActionResult<BaiDangXeCoXeDap_DTO>> preflightPostXeCoXeDap(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangXeCoXeDap(IdPost);
        }

        [HttpGet("xeCoPhuongTienKhac/preflight"), Authorize]
        public async Task<ActionResult<BaiDangXeCoPhuongTienKhac_DTO>> preflightPostXeCoPhuongTienKhac(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangXeCoPhuongTienKhac(IdPost);
        }

        [HttpGet("xeCoPhuTungXe/preflight"), Authorize]
        public async Task<ActionResult<BaiDangXeCoPhuTungXe_DTO>> preflightPostXeCoPhuTungXe(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangXeCoPhuTungKhac(IdPost);
        }
        #endregion

        #region DoDienTu Handler
        [HttpGet("doDienTuDienThoai/preflight"), Authorize]
        public async Task<ActionResult<BaiDangDoDienTuDienThoai_DTO>> preflightPostDoDienTuDienThoai(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangDoDienTuDienThoai(IdPost);
        }

        [HttpGet("doDienTuLaptop/preflight"), Authorize]
        public async Task<ActionResult<BaiDangDoDienTuLaptop_DTO>> preflightPostDoDienTuLaptop(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangDoDienTuLaptop(IdPost);
        }

        [HttpGet("doDienTuLinhKien/preflight"), Authorize]
        public async Task<ActionResult<BaiDangDoDienTuLinhKien_DTO>> preflightPostDoDienTuLinhKien(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangDoDienTuLinhKien(IdPost);
        }

        [HttpGet("doDienTuMayAnh/preflight"), Authorize]
        public async Task<ActionResult<BaiDangDoDienTuMayAnh_DTO>> preflightPostDoDienTuMayAnh(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangDoDienTuMayAnh(IdPost);
        }

        [HttpGet("doDienTuMayTinhBang/preflight"), Authorize]
        public async Task<ActionResult<BaiDangDoDienTuMayTinhBang_DTO>> preflightPostDoDienTuMayTinhBang(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangDoDienTuMayTinhBang(IdPost);
        }

        [HttpGet("doDienTuMayTinhDeBan/preflight"), Authorize]
        public async Task<ActionResult<BaiDangDoDienTuMayTinhDeBan_DTO>> preflightPostDoDienTuMayTinhDeBan(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangDoDienTuMayTinhDeBan(IdPost);
        }

        [HttpGet("doDienTuPhuKien/preflight"), Authorize]
        public async Task<ActionResult<BaiDangDoDienTuPhuKien_DTO>> preflightPostDoDienTuPhuKien(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangDoDienTuPhuKien(IdPost);
        }

        [HttpGet("doDienTuThietBiDeoThongMinh/preflight"), Authorize]
        public async Task<ActionResult<BaiDangDoDienTuThietBiDeoThongMinh_DTO>> preflightPostDoDienTuThietBiDeoThongMinh(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangDoDienTuThietBiDeoThongMinh(IdPost);
        }

        [HttpGet("doDienTuTivi/preflight"), Authorize]
        public async Task<ActionResult<BaiDangDoDienTuTivi_DTO>> preflightPostDoDienTuTivi(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangDoDienTuTivi(IdPost);
        }
        #endregion

        #region ViecLam Handler
        [HttpGet("viecLam/preflight"), Authorize]
        public async Task<ActionResult<BaiDangViecLamDTO>> preflightPostViecLam(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangViecLam(IdPost);
        }
        #endregion

        #region ThuCung Handler
        [HttpGet("thuCungChim/preflight"), Authorize]
        public async Task<ActionResult<BaiDangThuCungChim_DTO>> preflightPostThuCungChim( int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangThuCungChim(IdPost);
        }

        [HttpGet("thuCungCho/preflight"), Authorize]
        public async Task<ActionResult<BaiDangThuCungCho_DTO>> preflightPostThuCungCho(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangThuCungCho(IdPost);
        }

        [HttpGet("thuCungGaMeoThuCungKhac/preflight"), Authorize]
        public async Task<ActionResult<BaiDangThuCungGaMeoThuCungKhac_DTO>> preflightPostThuCungGaMeoThuCungKhac(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangThuCungGaMeoThuCungKhac(IdPost);
        }
        #endregion

        #region DoAnThucPham Handler
        [HttpGet("doAnThucPham/preflight"), Authorize]
        public async Task<ActionResult<BaiDangDoAnThucPham_DTO>> preflightPostDoAnThucPham(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangDoAnThucPham(IdPost);
        }
        #endregion

        #region BaiDangTuLanh Handler
        [HttpGet("baiDangTuLanh/preflight"), Authorize]
        public async Task<ActionResult<BaiDangTuLanhTL_DTO>> preflightPostTuLanh(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangTuLanh(IdPost);
        }

        [HttpGet("baiDangMayGiat/preflight"), Authorize]
        public async Task<ActionResult<BaiDangTuLanhMayGiat_DTO>> preflightPostMayGiat(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangMayGiat(IdPost);
        }

        [HttpGet("baiDangMayLanh/preflight"), Authorize]
        public async Task<ActionResult<BaiDangTuLanhMayLanh_DTO>> preflightPostMayLanh(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangMayLanh(IdPost);
        }
        #endregion

        #region BaiDangDoGiaDung Handler
        [HttpGet("baiDangDoGiaDungBanGhe/preflight"), Authorize]
        public async Task<ActionResult<BaiDangDoGiaDungBanGhe_DTO>> preflightPostBanGhe(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangDoGiaDungBanGhe(IdPost);
        }

        [HttpGet("baiDangDoGiaDungBep/preflight"), Authorize]
        public async Task<ActionResult<BaiDangDoGiaDungBep_DTO>> preflightPostBep(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangDoGiaDungBep(IdPost);
        }

        [HttpGet("baiDangDoGiaDungDenCayCanhNoiThat/preflight"), Authorize]
        public async Task<ActionResult<BaiDangDoGiaDungDenCayCanhNoiThat_DTO>> preflightPostDenCayCanhNoiThat(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangDoGiaDungDenCayCanhNoiThat(IdPost);
        }

        [HttpGet("baiDangDoGiaDungGiuong/preflight"), Authorize]
        public async Task<ActionResult<BaiDangDoGiaDungGiuong_DTO>> preflightPostGiuong(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangDoGiaDungGiuong(IdPost);
        }

        [HttpGet("baiDangDoGiaDungQuat/preflight"), Authorize]
        public async Task<ActionResult<BaiDangDoGiaDungQuat_DTO>> preflightPostQuat( int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangDoGiaDungQuat(IdPost);
        }

        [HttpGet("baiDangDoGiaDungThietBiVeSinh/preflight"), Authorize]
        public async Task<ActionResult<BaiDangDoGiaDungThietBiVeSinh_DTO>> preflightPostThietBiVeSinh(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangDoGiaDungThietBiVeSinh(IdPost);
        }

        [HttpGet("baiDangDoGiaDungTuKe/preflight"), Authorize]
        public async Task<ActionResult<BaiDangDoGiaDungTuKe_DTO>> preflightPostTuKe(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangDoGiaDungTuKe(IdPost);
        }
        #endregion

        #region MevaBe Handler
        [HttpGet("baiDangMeVaBe/preflight"), Authorize]
        public async Task<ActionResult<BaiDangMeVaBe_DTO>> preflightPostMeVaBe(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangMeVaBe(IdPost);
        }
        #endregion

        #region ThoiTrang Handler
        [HttpGet("baiDangThoiTrang/preflight"), Authorize]
        public async Task<ActionResult<BaiDangThoiTrang_DTO>> preflightostThoiTrang(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangThoiTrang(IdPost);
        }
        #endregion

        #region GiaiTri Handler
        [HttpGet("baiDangGiaiTri/preflight"), Authorize]
        public async Task<ActionResult<BaiDangGiaiTri_DTO>> preflightPostGiaiTri(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangGiaiTri(IdPost);
        }

        [HttpGet("baiDangGiaiTriDoSuuTam/preflight"), Authorize]
        public async Task<ActionResult<BaiDangGiaiTriDoSuuTam_DTO>> preflightPostGiaiTriDoSuuTam( int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangGiaiTriDoSuuTam(IdPost);
        }

        [HttpGet("baiDangGiaiTriNhacCu/preflight")]
        public async Task<ActionResult<BaiDangGiaiTriDoNhacCu_DTO>> preflightPostGiaiTriNhacCu(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangGiaiTriNhacCu(IdPost);
        }
        #endregion

        #region DoDungVanPhong Handler
        [HttpGet("baiDangDoDungVanPhong/preflight"), Authorize]
        public async Task<ActionResult<BaiDangDoDungVanPhong_DTO>> preflightPostDoDungVanPhong(int IdPost)
        {
            return await baiDangHandler.PreflightBaiDangDoDungVanPhong(IdPost);
        }
        #endregion
        #endregion
        [HttpPost("checkedNotifications/{idPost?}")]
        public async Task<ActionResult> CheckedNotifycations(int idPost = 1)
        {
            if (await thongBaoHandler.ThongBaoChecked(idPost))
                return Ok(true);
            return BadRequest();
        }

        [HttpGet("notifications/{sdt?}")]
        public async Task<List<ThongBaoDTO>> GetAllNotifcations(string sdt)
        {
            return await thongBaoHandler.GetAllThongBao(sdt);
        }
        [HttpPost("sendApproveResult")]
        public async Task<ActionResult> SendApproveResult(ApproveResultDTO approveResult )
        {
            if (await baiDangHandler.SendApproveResult(approveResult))
                return Ok(true);
            return BadRequest();
        }

        [HttpGet("admin/posts"), Authorize]
        public async Task<ActionResult<List<Admin_PostDTO>>> GetAllPost()
        {
            try
            {
                return Ok( baiDangHandler.GetAllPost());
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
       
        [HttpPost("admin/posts/active"), Authorize]
        public async Task<ActionResult<bool>> SetActiveStatus(bool status, int IdPost)
        {
            try
            {
                return Ok(baiDangHandler.SetActiveStatus(status,IdPost));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

    }
}
