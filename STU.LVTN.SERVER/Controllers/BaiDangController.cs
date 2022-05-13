using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using STU.LVTN.SERVER.Model.DTO;
using STU.LVTN.SERVER.Model.DTO.BaiDangBatDongSan;
using STU.LVTN.SERVER.Model.DTO.BaiDangXeCo;
using STU.LVTN.SERVER.Model.DTO.DoDienTu;
using STU.LVTN.SERVER.Model.DTO.ThuCung;
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

        public BaiDangController(IMapper mapper)
        {
            _mapper = mapper;
            baiDangHandler = new BaiDangHandler(_mapper);
        }

        [HttpGet("renderHomepage/{lastestSubCategories?}")]
        public async Task<ActionResult<List<BaiDangHomePageDTO>>> RenderHomePage(int lastestSubCategories = 0)
        {
            return await baiDangHandler.RenderHomePage(lastestSubCategories);
        }

        [HttpGet("mySold"), Authorize]
        public async Task<ActionResult<List<BaiDangHomePageDTO>>> MySoldPost()
        {
            var soDienThoai = User.Identity.Name;
            return await baiDangHandler.GetSoldPostBySoDienThoai(soDienThoai);
        }

        #region BatDongSan Handler
        [HttpPost("batDongSanCC/newPost")]
        public async Task<ActionResult<bool>> newPostBatDongSanCC(BaiDangBatDongSanCC_DTO baiDangCC_Request)
        {
            if (await baiDangHandler.AddBaiDangBatDongSanCC(baiDangCC_Request))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("batDongSanNhaO/newPost")]
        public async Task<ActionResult<bool>> newPostBatDongSanNhaO(BaiDangBatDongSanNhaO_DTO baiDangCC_Request)
        {
            if (await baiDangHandler.AddBaiDangBatDongSanNhaO(baiDangCC_Request))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("batDongSanDat/newPost")]
        public async Task<ActionResult<bool>> newPostBatDongSanDat(BaiDangBatDongSanDat_DTO baiDangCC_Request)
        {
            if (await baiDangHandler.AddBaiDangBatDongSanDat(baiDangCC_Request))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("batDongSanVanPhong/newPost")]
        public async Task<ActionResult<bool>> newPostBatDongSanVanPhong(BaiDangBatDongSanVanPhong_DTO baiDangCC_Request)
        {
            if (await baiDangHandler.AddBaiDangBatDongSanVanPhong(baiDangCC_Request))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("batDongSanPhongTro/newPost")]
        public async Task<ActionResult<bool>> newPostBatDongSanPhongTro(BaiDangBatDongSanPhongTro_DTO baiDangCC_Request)
        {
            if (await baiDangHandler.AddBaiDangBatDongSanPhongTro(baiDangCC_Request))
            {
                return Ok();
            }
            return BadRequest();
        }

        #endregion

        #region XeCo Handler
        [HttpPost("xeCoOto/newPost")]
        public async Task<ActionResult<bool>> newPostXeCoOto(BaiDangXeCoOto_DTO baiDangOTo_Request)
        {
            if (await baiDangHandler.AddBaiDangXeCoOTo(baiDangOTo_Request))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("xeCoXeMay/newPost")]
        public async Task<ActionResult<bool>> newPostXeCoXeMay(BaiDangXeCoXeMay_DTO baiDangXeMay_Request)
        {
            if (await baiDangHandler.AddBaiDangXeCoXeMay(baiDangXeMay_Request))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("xeCoXeTai/newPost")]
        public async Task<ActionResult<bool>> newPostXeCoXeTai(BaiDangXeCoXeTai_DTO baiDangXeTai_Request)
        {
            if (await baiDangHandler.AddBaiDangXeCoXeTai(baiDangXeTai_Request))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("xeCoXeDien/newPost")]
        public async Task<ActionResult<bool>> newPostXeCoXeDien(BaiDangXeCoXeDien_DTO baiDangXeDien_Request)
        {
            if (await baiDangHandler.AddBaiDangXeCoXeDien(baiDangXeDien_Request))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("xeCoXeDap/newPost")]
        public async Task<ActionResult<bool>> newPostXeCoXeDap(BaiDangXeCoXeDap_DTO baiDangXeDap_Request)
        {
            if (await baiDangHandler.AddBaiDangXeCoXeDap(baiDangXeDap_Request))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("xeCoPhuongTienKhac/newPost")]
        public async Task<ActionResult<bool>> newPostXeCoPhuongTienKhac(BaiDangXeCoPhuongTienKhac_DTO baiDangPhuongTienKhac_Request)
        {
            if (await baiDangHandler.AddBaiDangXeCoPhuongTienKhac(baiDangPhuongTienKhac_Request))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("xeCoPhuTungXe/newPost")]
        public async Task<ActionResult<bool>> newPostXeCoPhuTungXe(BaiDangXeCoPhuTungXe_DTO baiDangPhuTungXe_Request)
        {
            if (await baiDangHandler.AddBaiDangXeCoPhuTungKhac(baiDangPhuTungXe_Request))
            {
                return Ok();
            }
            return BadRequest();
        }
        #endregion

        #region DoDienTu Handler
        [HttpPost("doDienTuDienThoai/newPost")]
        public async Task<ActionResult<bool>> newPostDoDienTuDienThoai(BaiDangDoDienTuDienThoai_DTO baiDangDienThoai_Request)
        {
            if (await baiDangHandler.AddBaiDangDoDienTuDienThoai(baiDangDienThoai_Request))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("doDienTuLaptop/newPost")]
        public async Task<ActionResult<bool>> newPostDoDienTuLaptop(BaiDangDoDienTuLaptop_DTO baiDangLaptop_Request)
        {
            if (await baiDangHandler.AddBaiDangDoDienTuLaptop(baiDangLaptop_Request))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("doDienTuLinhKien/newPost")]
        public async Task<ActionResult<bool>> newPostDoDienTuLinhKien(BaiDangDoDienTuLinhKien_DTO baiDangLinhKien_Request)
        {
            if (await baiDangHandler.AddBaiDangDoDienTuLinhKien(baiDangLinhKien_Request))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("doDienTuMayAnh/newPost")]
        public async Task<ActionResult<bool>> newPostDoDienTuMayAnh(BaiDangDoDienTuMayAnh_DTO baiDangMayAnh_Request)
        {
            if (await baiDangHandler.AddBaiDangDoDienTuMayAnh(baiDangMayAnh_Request))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("doDienTuMayTinhBang/newPost")]
        public async Task<ActionResult<bool>> newPostDoDienTuMayTinhBang(BaiDangDoDienTuMayTinhBang_DTO baiDangMayTinhBang_Request)
        {
            if (await baiDangHandler.AddBaiDangDoDienTuMayTinhBang(baiDangMayTinhBang_Request))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("doDienTuMayTinhDeBan/newPost")]
        public async Task<ActionResult<bool>> newPostDoDienTuMayTinhDeBan(BaiDangDoDienTuMayTinhDeBan_DTO baiDangMayTinhDeBan_Request)
        {
            if (await baiDangHandler.AddBaiDangDoDienTuMayTinhDeBan(baiDangMayTinhDeBan_Request))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("doDienTuPhuKien/newPost")]
        public async Task<ActionResult<bool>> newPostDoDienTuPhuKien(BaiDangDoDienTuPhuKien_DTO baiDangPhuKien_Request)
        {
            if (await baiDangHandler.AddBaiDangDoDienTuPhuKien(baiDangPhuKien_Request))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("doDienTuThietBiDeoThongMinh/newPost")]
        public async Task<ActionResult<bool>> newPostDoDienTuThietBiDeoThongMinh(BaiDangDoDienTuThietBiDeoThongMinh_DTO baiDangThietBiDeoThongMinh_Request)
        {
            if (await baiDangHandler.AddBaiDangDoDienTuThietBiDeoThongMinh(baiDangThietBiDeoThongMinh_Request))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("doDienTuTivi/newPost")]
        public async Task<ActionResult<bool>> newPostDoDienTuTivi(BaiDangDoDienTuTivi_DTO baiDangTivi_Request)
        {
            if (await baiDangHandler.AddBaiDangDoDienTuTivi(baiDangTivi_Request))
            {
                return Ok();
            }
            return BadRequest();
        }
        #endregion

        #region ViecLam Handler
        [HttpPost("viecLam/newPost")]
        public async Task<ActionResult<bool>> newPostViecLam(BaiDangViecLamDTO baiDangViecLam_Request)
        {
            if (await baiDangHandler.AddBaiDangViecLam(baiDangViecLam_Request))
            {
                return Ok();
            }
            return BadRequest();
        }
        #endregion

        #region ThuCung Handler
        [HttpPost("thuCungChim/newPost")]
        public async Task<ActionResult<bool>> newPostThuCungChim(BaiDangThuCungChim_DTO baiDangThuCungChim_Request)
        {
            if (await baiDangHandler.AddBaiDangThuCungChim(baiDangThuCungChim_Request))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("thuCungCho/newPost")]
        public async Task<ActionResult<bool>> newPostThuCungCho(BaiDangThuCungCho_DTO baiDangThuCungCho_Request)
        {
            if (await baiDangHandler.AddBaiDangThuCungCho(baiDangThuCungCho_Request))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("thuCungGaMeoThuCungKhac/newPost")]
        public async Task<ActionResult<bool>> newPostThuCungGaMeoThuCungKhac(BaiDangThuCungGaMeoThuCungKhac_DTO baiDangThuCungGaMeoThuCungKhac_Request)
        {
            if (await baiDangHandler.AddBaiDangThuCungGaMeoThuCungKhac(baiDangThuCungGaMeoThuCungKhac_Request))
            {
                return Ok();
            }
            return BadRequest();
        }
        #endregion
    }
}
