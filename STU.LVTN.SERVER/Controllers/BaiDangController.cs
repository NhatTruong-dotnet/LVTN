using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using STU.LVTN.SERVER.Model.DTO;
using STU.LVTN.SERVER.Model.DTO.BaiDangBatDongSan;
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

        [HttpPost("batDongSanCC/newPost")]
        public async Task<ActionResult<bool>> newPostBatDongSanCC(BaiDangBatDongSanCC_DTO baiDangCC_Request)
        {
            if (await baiDangHandler.AddBaiDangBatDongSanCC(baiDangCC_Request))
            {
                return Ok();
            }
            return BadRequest();
        }

    }
}
