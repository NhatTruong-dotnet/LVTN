using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using STU.LVTN.SERVER.Model.DTO;
using STU.LVTN.SERVER.Model.DTO.BaiDangBatDongSan;
using STU.LVTN.SERVER.Model.DTO.BaiDangXeCo;
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
    }
}
