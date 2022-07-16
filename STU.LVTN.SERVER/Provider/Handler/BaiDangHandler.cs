using AutoMapper;
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
using STU.LVTN.SERVER.Provider.BusinessLogic;

namespace STU.LVTN.SERVER.Provider.Handler
{
    public class BaiDangHandler
    {
        BaiDang baiDangHelper;
        private readonly IMapper _mapper;
        private readonly LVTNContext ctx;
        BaiDangBatDongSan baiDangBatDongSanHelper;
        BaiDangXeCo baiDangXeCoHelper;
        BaiDangDoDienTu baiDangDoDienTuHelper;
        BaiDangViecLam baiDangViecLamHelper;
        BaiDangThuCung baiDangThuCungHelper;
        BaiDangDoAnThucPham baiDangDoAnThucPhamHelper;
        BaiDangTuLanh baiDangTuLanhHelper;
        BaiDangDoGiaDung baiDangDoGiaDungHelper;
        BaiDangMeVaBe baiDangMeVaBeHelper;
        BaiDangThoiTrang baiDangThoiTrangHelper;
        BaiDangGiaiTri baiDangGiaiTriHelper;
        BaiDangDoDungVanPhong baiDangDoDungVanPhongHelper;
        HinhAnh_BaiDang hinhAnhBaiDangHelper;
        ThongBao thongBaoHelper;
        public BaiDangHandler(IMapper mapper)
        {
            _mapper = mapper;
            baiDangHelper = new BaiDang(_mapper, ctx);
            baiDangBatDongSanHelper = new BaiDangBatDongSan();
            baiDangXeCoHelper = new BaiDangXeCo();
            baiDangDoDienTuHelper = new BaiDangDoDienTu();
            baiDangViecLamHelper = new BaiDangViecLam();
            baiDangThuCungHelper = new BaiDangThuCung();
            baiDangDoAnThucPhamHelper = new BaiDangDoAnThucPham();
            baiDangTuLanhHelper = new BaiDangTuLanh();
            baiDangDoGiaDungHelper = new BaiDangDoGiaDung();
            baiDangMeVaBeHelper = new BaiDangMeVaBe();
            baiDangThoiTrangHelper = new BaiDangThoiTrang();
            baiDangGiaiTriHelper = new BaiDangGiaiTri();
            baiDangDoDungVanPhongHelper = new BaiDangDoDungVanPhong();
            hinhAnhBaiDangHelper = new HinhAnh_BaiDang();
            thongBaoHelper = new ThongBao();
        }
        public async Task<List<BaiDangHomePageDTO>> RenderHomePage(int lastestSubCategories)
        {
            return await baiDangHelper.RenderHomePage(lastestSubCategories);
        }

        public async Task<List<BaiDangHomePageDTO>> GetSoldPostBySoDienThoai(string soDienThoai)
        {
            return await baiDangHelper.GetSoldPostBySoDienThoai(soDienThoai);
        }

        public async Task<Dictionary<string, Dictionary<string, string>>> GetPostByID(int IDPost)
        {
            BaiDangEntities post = await baiDangHelper.GetPostByID(IDPost);
            Dictionary<string, Dictionary<string, string>> result = new Dictionary<string, Dictionary<string, string>>();
            int idDanhMucSanPham = post.IdDanhMucCha;
            int? idDanhMucBaiDang = post.IdDanhMucCon;
            #region BaiDang global
            Dictionary<string, string> postDictionary = new Dictionary<string, string>();
            postDictionary.Add("tieuDe", post.TieuDe);
            postDictionary.Add("IsReviewed", post.isReviewed.ToString());
            postDictionary.Add("moTa", post.Mota);
            postDictionary.Add("gia", String.Format("{0:n0}", double.Parse(post.Gia.ToString())) );
            postDictionary.Add("sdt", post.SdtNguoiBan);
            postDictionary.Add("idDanhMuc", post.IdDanhMucCon.ToString());
            postDictionary.Add("khuVuc", post.PhuongXa + ", " + post.QuanHuyen + ", " + post.ThanhPho);
            result.Add("BaiDang", postDictionary);
            #endregion
            switch (idDanhMucBaiDang)
            {
                #region BatDongSan
                case 13:
                    Dictionary<string, string> detailCC = baiDangBatDongSanHelper.getPost_CC_ByID(post.IdBaiDangChiTiet);
                    //detailCC.Add("Giá/m2: ", post.Gia.ToString());
                    result.Add("detail", detailCC);
                    break;
                case 14:
                    Dictionary<string, string> detailNhaO = baiDangBatDongSanHelper.getPost_NhaO_ByID(post.IdBaiDangChiTiet);
                    // detailNhaO.Add("Giá/m2: ", post.Gia.ToString());
                    result.Add("detail", detailNhaO);
                    break;
                case 15:
                    Dictionary<string, string> detailDat = baiDangBatDongSanHelper.getPost_Dat_ByID(post.IdBaiDangChiTiet);
                    // detailDat.Add("Giá/m2: ", post.Gia.ToString());
                    result.Add("detail", detailDat);
                    break;
                case 16:
                    Dictionary<string, string> detailMatBangKinhDoanh = baiDangBatDongSanHelper.getPost_VanPhong_ByID(post.IdBaiDangChiTiet);
                    // detailMatBangKinhDoanh.Add("Giá/m2: ", post.Gia.ToString());
                    result.Add("detail", detailMatBangKinhDoanh);
                    break;
                case 17:
                    Dictionary<string, string> detailPhongTro = baiDangBatDongSanHelper.getPost_VanPhong_ByID(post.IdBaiDangChiTiet);
                    // detailPhongTro.Add("Giá/m2: ", post.Gia.ToString());
                    result.Add("detail", detailPhongTro);
                    break;
                #endregion

                #region XeCo
                case 18:
                    Dictionary<string, string> detailXeOto = baiDangXeCoHelper.getPost_XeOto_ByID(post.IdBaiDangChiTiet);
                    result.Add("detail", detailXeOto);
                    break;
                case 19:
                    Dictionary<string, string> detailXeMay = baiDangXeCoHelper.getPost_XeMay_ByID(post.IdBaiDangChiTiet);
                    result.Add("detail", detailXeMay);
                    break;
                case 20:
                    Dictionary<string, string> detailXeTai = baiDangXeCoHelper.getPost_XeTai_ByID(post.IdBaiDangChiTiet);
                    result.Add("detail", detailXeTai);
                    break;
                case 21:
                    Dictionary<string, string> detailXeDien = baiDangXeCoHelper.getPost_XeDien_ByID(post.IdBaiDangChiTiet);
                    result.Add("detail", detailXeDien);
                    break;
                case 22:
                    Dictionary<string, string> detailXeDap = baiDangXeCoHelper.getPost_XeDap_ByID(post.IdBaiDangChiTiet);
                    result.Add("detail", detailXeDap);
                    break;
                case 23:
                    Dictionary<string, string> detailPhuongTienKhac = baiDangXeCoHelper.getPost_PhuongTienKhac_ByID(post.IdBaiDangChiTiet);
                    result.Add("detail", detailPhuongTienKhac);
                    break;
                case 24:
                    Dictionary<string, string> detailPhuTungXe = baiDangXeCoHelper.getPost_PhuTungXe_ByID(post.IdBaiDangChiTiet);
                    result.Add("detail", detailPhuTungXe);
                    break;
                #endregion

                #region DoDienTu
                case 25:
                    Dictionary<string, string> detailDienThoai = baiDangDoDienTuHelper.getPost_DienThoai_ByID(post.IdBaiDangChiTiet);
                    result.Add("detail", detailDienThoai);
                    break;
                case 26:
                    Dictionary<string, string> detailMayTinhBang = baiDangDoDienTuHelper.getPost_MayTinhBang_ByID(post.IdBaiDangChiTiet);
                    result.Add("detail", detailMayTinhBang);
                    break;
                case 27:
                    Dictionary<string, string> detailLaptop = baiDangDoDienTuHelper.getPost_Laptop_ByID(post.IdBaiDangChiTiet);
                    result.Add("detail", detailLaptop);
                    break;
                case 28:
                    Dictionary<string, string> detailMayTinhDeBan = baiDangDoDienTuHelper.getPost_MayTinhDeBan_ByID(post.IdBaiDangChiTiet);
                    result.Add("detail", detailMayTinhDeBan);
                    break;
                case 29:
                    Dictionary<string, string> detailMayAnhMayQuay = baiDangDoDienTuHelper.getPost_MayAnhMayQuayOngKinh_ByID(post.IdBaiDangChiTiet);
                    result.Add("detail", detailMayAnhMayQuay);
                    break;
                case 30:
                    Dictionary<string, string> detailTiviAmThanh = baiDangDoDienTuHelper.getPost_TiviAmThanh_ByID(post.IdBaiDangChiTiet);
                    result.Add("detail", detailTiviAmThanh);
                    break;
                case 31:
                    Dictionary<string, string> detailThietBiDeoThongMinh = baiDangDoDienTuHelper.getPost_ThietBiDeoThongMinh_ByID(post.IdBaiDangChiTiet);
                    result.Add("detail", detailThietBiDeoThongMinh);
                    break;
                case 32:
                    Dictionary<string, string> detailPhuKien = baiDangDoDienTuHelper.getPost_PhuKien_ByID(post.IdBaiDangChiTiet);
                    result.Add("detail", detailPhuKien);
                    break;
                case 33:
                    Dictionary<string, string> detailLinhKien = baiDangDoDienTuHelper.getPost_LinhKien_ByID(post.IdBaiDangChiTiet);
                    result.Add("detail", detailLinhKien);
                    break;
                #endregion

                #region ViecLam
                case 4:
                    Dictionary<string, string> detailViecLam = baiDangViecLamHelper.getPost_ViecLam_ByID(post.IdBaiDangChiTiet);
                    result.Add("detail", detailViecLam);
                    break;
                #endregion

                #region ThuCung
                case 34:
                case 37:
                case 38:
                    Dictionary<string, string> detailThuCung = baiDangThuCungHelper.getPost_ThuCungGaMeoThuCungKhac_ByID(post.IdBaiDangChiTiet);
                    result.Add("detail", detailThuCung);
                    break;
                case 36:
                    Dictionary<string, string> detailThuCungChim = baiDangThuCungHelper.getPost_ThuCungChim_ByID(post.IdBaiDangChiTiet);
                    result.Add("detail", detailThuCungChim);
                    break;
                case 35:
                    Dictionary<string, string> detailThuCungCho = baiDangThuCungHelper.getPost_ThuCungCho_ByID(post.IdBaiDangChiTiet);
                    result.Add("detail", detailThuCungCho);
                    break;
                #endregion

                #region DoAn ThucPham
                case 6:
                    Dictionary<string, string> detailDoAn = baiDangDoAnThucPhamHelper.getPost_DoAn_ByID(post.IdBaiDangChiTiet);
                    result.Add("detail", detailDoAn);
                    break;
                #endregion

                #region TuLanh
                case 40:
                    Dictionary<string, string> detailTuLanh = baiDangTuLanhHelper.getPost_TuLanh_ByID(post.IdBaiDangChiTiet);
                    result.Add("detail", detailTuLanh);
                    break;
                case 41:
                    Dictionary<string, string> detailMayLanhMayDieuHoa = baiDangTuLanhHelper.getPost_MayLanhDieuHoa_ByID(post.IdBaiDangChiTiet);
                    result.Add("detail", detailMayLanhMayDieuHoa);
                    break;
                case 42:
                    Dictionary<string, string> detailMayGiat = baiDangTuLanhHelper.getPost_MayGiat_ByID(post.IdBaiDangChiTiet);
                    result.Add("detail", detailMayGiat);
                    break;
                #endregion

                #region DoGiaDung
                case 43:
                    Dictionary<string, string> detailBanGhe = baiDangDoGiaDungHelper.getPost_BanGhe_ByID(post.IdBaiDangChiTiet);
                    result.Add("detail", detailBanGhe);
                    break;
                case 44:
                    Dictionary<string, string> detailTuKe = baiDangDoGiaDungHelper.getPost_TuKe_ByID(post.IdBaiDangChiTiet);
                    result.Add("detail", detailTuKe);
                    break;
                case 45:
                    Dictionary<string, string> detailGiuong = baiDangDoGiaDungHelper.getPost_Giuong_ByID(post.IdBaiDangChiTiet);
                    result.Add("detail", detailGiuong);
                    break;
                case 46:
                    Dictionary<string, string> detailBep = baiDangDoGiaDungHelper.getPost_Bep_ByID(post.IdBaiDangChiTiet);
                    result.Add("detail", detailBep);
                    break;
                case 48:
                    Dictionary<string, string> detailQuat = baiDangDoGiaDungHelper.getPost_Quat_ByID(post.IdBaiDangChiTiet);
                    result.Add("detail", detailQuat);
                    break;
                case 49:
                case 50:
                case 52:
                    Dictionary<string, string> detailDenCayCanhNoiThat = baiDangDoGiaDungHelper.getPost_DenCayCanhNoiThat_ByID(post.IdBaiDangChiTiet);
                    result.Add("detail", detailDenCayCanhNoiThat);
                    break;
                case 51:
                    Dictionary<string, string> detailThietBiVeSinh = baiDangDoGiaDungHelper.getPost_ThietBiVeSinh_ByID(post.IdBaiDangChiTiet);
                    result.Add("detail", detailThietBiVeSinh);
                    break;
                #endregion

                #region MevaBe
                case 9:
                    Dictionary<string, string> detailMeVaBe = baiDangMeVaBeHelper.getPost_MeVaBe_ByID(post.IdBaiDangChiTiet);
                    result.Add("detail", detailMeVaBe);
                    break;
                #endregion

                #region ThoiTrang
                case 53:
                case 54:
                case 55:
                case 56:
                case 57:
                case 58:
                    Dictionary<string, string> detailThoiTrang = baiDangThoiTrangHelper.getPost_ThoiTrang_ByID(post.IdBaiDangChiTiet);
                    result.Add("detail", detailThoiTrang);
                    break;
                #endregion

                #region GiaiTri
                case 60:
                case 61:
                case 63:
                case 64:
                    Dictionary<string, string> detailGiaiTri = baiDangGiaiTriHelper.getPost_SachDoTheThaoThietBiChoiGameSoThichKhac_ByID(post.IdBaiDangChiTiet);
                    result.Add("detail", detailGiaiTri);
                    break;
                case 59:
                    Dictionary<string, string> detailNhacCu = baiDangGiaiTriHelper.getPost_NhacCu_ByID(post.IdBaiDangChiTiet);
                    result.Add("detail", detailNhacCu);
                    break;
                case 62:
                    Dictionary<string, string> detailDoSuuTam = baiDangGiaiTriHelper.getPost_DoSuuTam_ByID(post.IdBaiDangChiTiet);
                    result.Add("detail", detailDoSuuTam);
                    break;
                #endregion

                #region DoDungVanPhong
                case 65:
                case 66:
                    Dictionary<string, string> detailDoDung = baiDangDoDungVanPhongHelper.getPost_ThoiTrang_ByID(post.IdBaiDangChiTiet);
                    result.Add("detail", detailDoDung);
                    break;
                #endregion
                default:
                    break;
            }

            Dictionary<string, string> hinhAnhDictionary = new Dictionary<string, string>();
            Dictionary<string, string> videoDictionary = new Dictionary<string, string>();
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(IDPost);
            for (int i = 1; i <= hinhAnhBaiDang.Count; i++)
            {

                if (!(bool)hinhAnhBaiDang[i - 1].VideoType)
                    hinhAnhDictionary.Add(i.ToString(), hinhAnhBaiDang[i - 1].IdMediaCloud.ToString());
                else
                    videoDictionary.Add((videoDictionary.Count + 1).ToString(), hinhAnhBaiDang[i - 1].IdMediaCloud.ToString());

            }
            result.Add("HinhAnh", hinhAnhDictionary);
            result.Add("Video", videoDictionary);

            return result;
        }

        public async Task<bool> SendApproveResult(ApproveResultDTO approveResult)
        {
            return await baiDangHelper.SendApproveResult(approveResult);
        }
        public async Task<List<Admin_PostDTO>> GetAllPost()
        {
            return baiDangHelper.GetAllPost();
        }
        public async Task<bool> SetActiveStatus(bool status, int IdPost)
        {
            if (status)
            {
                return baiDangHelper.ActivePost(IdPost);
            }
            else
            {
                return baiDangHelper.DeActivePost(IdPost);
            }

        }
        public int NumberOfPost()
        {
            return baiDangHelper.NumberOfPost();
        }
        #region Create

        #region BaiDangBatDongSan
        public async Task<bool> AddBaiDangBatDongSanCC(BaiDangBatDongSanCC_DTO baiDangRequest)
        {
            BaiDangBatDongSanEntities baiDangBatDongSanCC = _mapper.Map<BaiDangBatDongSanEntities>(baiDangRequest);
            int lastIDPost = baiDangBatDongSanHelper.AddBaiDang(baiDangBatDongSanCC);

            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public async Task<bool> AddBaiDangBatDongSanNhaO(BaiDangBatDongSanNhaO_DTO baiDangRequest)
        {
            BaiDangBatDongSanEntities baiDangBatDongSanCC = _mapper.Map<BaiDangBatDongSanEntities>(baiDangRequest);
            int lastIDPost = baiDangBatDongSanHelper.AddBaiDang(baiDangBatDongSanCC);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public async Task<bool> AddBaiDangBatDongSanDat(BaiDangBatDongSanDat_DTO baiDangRequest)
        {
            BaiDangBatDongSanEntities baiDangBatDongSanCC = _mapper.Map<BaiDangBatDongSanEntities>(baiDangRequest);
            int lastIDPost = baiDangBatDongSanHelper.AddBaiDang(baiDangBatDongSanCC);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public async Task<bool> AddBaiDangBatDongSanVanPhong(BaiDangBatDongSanVanPhong_DTO baiDangRequest)
        {
            BaiDangBatDongSanEntities baiDangBatDongSanCC = _mapper.Map<BaiDangBatDongSanEntities>(baiDangRequest);
            int lastIDPost = baiDangBatDongSanHelper.AddBaiDang(baiDangBatDongSanCC);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public async Task<bool> AddBaiDangBatDongSanPhongTro(BaiDangBatDongSanPhongTro_DTO baiDangRequest)
        {
            BaiDangBatDongSanEntities baiDangBatDongSanCC = _mapper.Map<BaiDangBatDongSanEntities>(baiDangRequest);
            int lastIDPost = baiDangBatDongSanHelper.AddBaiDang(baiDangBatDongSanCC);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        #endregion

        #region BaiDangXeCo
        public async Task<bool> AddBaiDangXeCoOTo(BaiDangXeCoOto_DTO baiDangRequest)
        {
            BaiDangXeCoEntities baiDangXeCoOto = _mapper.Map<BaiDangXeCoEntities>(baiDangRequest);
            int lastIDPost = baiDangXeCoHelper.AddBaiDang(baiDangXeCoOto);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public async Task<bool> AddBaiDangXeCoXeMay(BaiDangXeCoXeMay_DTO baiDangRequest)
        {
            BaiDangXeCoEntities baiDangXeCoOto = _mapper.Map<BaiDangXeCoEntities>(baiDangRequest);
            int lastIDPost = baiDangXeCoHelper.AddBaiDang(baiDangXeCoOto);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public async Task<bool> AddBaiDangXeCoXeTai(BaiDangXeCoXeTai_DTO baiDangRequest)
        {
            BaiDangXeCoEntities baiDangXeCoOto = _mapper.Map<BaiDangXeCoEntities>(baiDangRequest);
            int lastIDPost = baiDangXeCoHelper.AddBaiDang(baiDangXeCoOto);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public async Task<bool> AddBaiDangXeCoXeDien(BaiDangXeCoXeDien_DTO baiDangRequest)
        {
            BaiDangXeCoEntities baiDangXeCoOto = _mapper.Map<BaiDangXeCoEntities>(baiDangRequest);
            int lastIDPost = baiDangXeCoHelper.AddBaiDang(baiDangXeCoOto);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                {
                    HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                    hinhAnhRequest.IdSanPham = lastIDPost;
                    hinhAnhRequest.IdMediaCloud = item.id;
                    if (item.type.Contains("video"))
                        hinhAnhRequest.VideoType = true;
                    else
                        hinhAnhRequest.VideoType = false;
                    hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                }
                BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                return await baiDangHelper.AddBaiDang(baiDangGlobal);
            }
        }
        public async Task<bool> AddBaiDangXeCoXeDap(BaiDangXeCoXeDap_DTO baiDangRequest)
        {
            BaiDangXeCoEntities baiDangXeCoOto = _mapper.Map<BaiDangXeCoEntities>(baiDangRequest);
            int lastIDPost = baiDangXeCoHelper.AddBaiDang(baiDangXeCoOto);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public async Task<bool> AddBaiDangXeCoPhuongTienKhac(BaiDangXeCoPhuongTienKhac_DTO baiDangRequest)
        {
            BaiDangXeCoEntities baiDangXeCoOto = _mapper.Map<BaiDangXeCoEntities>(baiDangRequest);
            int lastIDPost = baiDangXeCoHelper.AddBaiDang(baiDangXeCoOto);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public async Task<bool> AddBaiDangXeCoPhuTungKhac(BaiDangXeCoPhuTungXe_DTO baiDangRequest)
        {
            BaiDangXeCoEntities baiDangXeCoOto = _mapper.Map<BaiDangXeCoEntities>(baiDangRequest);
            int lastIDPost = baiDangXeCoHelper.AddBaiDang(baiDangXeCoOto);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        #endregion

        #region BaiDangDoDienTu
        public async Task<bool> AddBaiDangDoDienTuDienThoai(BaiDangDoDienTuDienThoai_DTO baiDangRequest)
        {
            BaiDangDoDienTuEntities baiDangDoDienTuDienThoai = _mapper.Map<BaiDangDoDienTuEntities>(baiDangRequest);
            int lastIDPost = baiDangDoDienTuHelper.AddBaiDang(baiDangDoDienTuDienThoai);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public async Task<bool> AddBaiDangDoDienTuLaptop(BaiDangDoDienTuLaptop_DTO baiDangRequest)
        {
            BaiDangDoDienTuEntities baiDangDoDienTuDienThoai = _mapper.Map<BaiDangDoDienTuEntities>(baiDangRequest);
            int lastIDPost = baiDangDoDienTuHelper.AddBaiDang(baiDangDoDienTuDienThoai);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public async Task<bool> AddBaiDangDoDienTuLinhKien(BaiDangDoDienTuLinhKien_DTO baiDangRequest)
        {
            BaiDangDoDienTuEntities baiDangDoDienTuDienThoai = _mapper.Map<BaiDangDoDienTuEntities>(baiDangRequest);
            int lastIDPost = baiDangDoDienTuHelper.AddBaiDang(baiDangDoDienTuDienThoai);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public async Task<bool> AddBaiDangDoDienTuMayAnh(BaiDangDoDienTuMayAnh_DTO baiDangRequest)
        {
            BaiDangDoDienTuEntities baiDangDoDienTuDienThoai = _mapper.Map<BaiDangDoDienTuEntities>(baiDangRequest);
            int lastIDPost = baiDangDoDienTuHelper.AddBaiDang(baiDangDoDienTuDienThoai);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public async Task<bool> AddBaiDangDoDienTuMayTinhBang(BaiDangDoDienTuMayTinhBang_DTO baiDangRequest)
        {
            BaiDangDoDienTuEntities baiDangDoDienTuDienThoai = _mapper.Map<BaiDangDoDienTuEntities>(baiDangRequest);
            int lastIDPost = baiDangDoDienTuHelper.AddBaiDang(baiDangDoDienTuDienThoai);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public async Task<bool> AddBaiDangDoDienTuMayTinhDeBan(BaiDangDoDienTuMayTinhDeBan_DTO baiDangRequest)
        {
            BaiDangDoDienTuEntities baiDangDoDienTuDienThoai = _mapper.Map<BaiDangDoDienTuEntities>(baiDangRequest);
            int lastIDPost = baiDangDoDienTuHelper.AddBaiDang(baiDangDoDienTuDienThoai);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public async Task<bool> AddBaiDangDoDienTuPhuKien(BaiDangDoDienTuPhuKien_DTO baiDangRequest)
        {
            BaiDangDoDienTuEntities baiDangDoDienTuDienThoai = _mapper.Map<BaiDangDoDienTuEntities>(baiDangRequest);
            int lastIDPost = baiDangDoDienTuHelper.AddBaiDang(baiDangDoDienTuDienThoai);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public async Task<bool> AddBaiDangDoDienTuThietBiDeoThongMinh(BaiDangDoDienTuThietBiDeoThongMinh_DTO baiDangRequest)
        {
            BaiDangDoDienTuEntities baiDangDoDienTuDienThoai = _mapper.Map<BaiDangDoDienTuEntities>(baiDangRequest);
            int lastIDPost = baiDangDoDienTuHelper.AddBaiDang(baiDangDoDienTuDienThoai);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public async Task<bool> AddBaiDangDoDienTuTivi(BaiDangDoDienTuTivi_DTO baiDangRequest)
        {
            BaiDangDoDienTuEntities baiDangDoDienTuDienThoai = _mapper.Map<BaiDangDoDienTuEntities>(baiDangRequest);
            int lastIDPost = baiDangDoDienTuHelper.AddBaiDang(baiDangDoDienTuDienThoai);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        #endregion

        #region BaiDangViecLam
        public async Task<bool> AddBaiDangViecLam(BaiDangViecLamDTO baiDangRequest)
        {
            BaiDangViecLamEntities baiDangViecLam = _mapper.Map<BaiDangViecLamEntities>(baiDangRequest);
            int lastIDPost = baiDangViecLamHelper.AddBaiDang(baiDangViecLam);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        #endregion

        #region BaiDangThuCung
        public async Task<bool> AddBaiDangThuCungChim(BaiDangThuCungChim_DTO baiDangRequest)
        {
            BaiDangThuCungEntities baiDangThuCung = _mapper.Map<BaiDangThuCungEntities>(baiDangRequest);
            int lastIDPost = baiDangThuCungHelper.AddBaiDang(baiDangThuCung);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public async Task<bool> AddBaiDangThuCungCho(BaiDangThuCungCho_DTO baiDangRequest)
        {
            BaiDangThuCungEntities baiDangThuCung = _mapper.Map<BaiDangThuCungEntities>(baiDangRequest);
            int lastIDPost = baiDangThuCungHelper.AddBaiDang(baiDangThuCung);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public async Task<bool> AddBaiDangThuCungGaMeoThuCungKhac(BaiDangThuCungGaMeoThuCungKhac_DTO baiDangRequest)
        {
            BaiDangThuCungEntities baiDangThuCung = _mapper.Map<BaiDangThuCungEntities>(baiDangRequest);
            int lastIDPost = baiDangThuCungHelper.AddBaiDang(baiDangThuCung);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        #endregion

        #region BaiDangDoAnThucPham
        public async Task<bool> AddBaiDangDoAnThucPham(BaiDangDoAnThucPham_DTO baiDangRequest)
        {
            BaiDangDoAnThucPhamEntities baiDangThucPham = _mapper.Map<BaiDangDoAnThucPhamEntities>(baiDangRequest);
            int lastIDPost = baiDangDoAnThucPhamHelper.AddBaiDang(baiDangThucPham);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        #endregion

        #region BaiDangTuLanh
        public async Task<bool> AddBaiDangTuLanh(BaiDangTuLanhTL_DTO baiDangRequest)
        {
            BaiDangTuLanhEntities baiDangTuLanh = _mapper.Map<BaiDangTuLanhEntities>(baiDangRequest);
            int lastIDPost = baiDangTuLanhHelper.AddBaiDang(baiDangTuLanh);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public async Task<bool> AddBaiDangMayGiat(BaiDangTuLanhMayGiat_DTO baiDangRequest)
        {
            BaiDangTuLanhEntities baiDangMayGiat = _mapper.Map<BaiDangTuLanhEntities>(baiDangRequest);
            int lastIDPost = baiDangTuLanhHelper.AddBaiDang(baiDangMayGiat);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

        }

        public async Task<bool> AddBaiDangMayLanh(BaiDangTuLanhMayLanh_DTO baiDangRequest)
        {
            BaiDangTuLanhEntities baiDangMayLanh = _mapper.Map<BaiDangTuLanhEntities>(baiDangRequest);
            int lastIDPost = baiDangTuLanhHelper.AddBaiDang(baiDangMayLanh);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        #endregion

        #region BaiDang DoGiaDung
        public async Task<bool> AddBaiDangDoGiaDungBanGhe(BaiDangDoGiaDungBanGhe_DTO baiDangRequest)
        {
            BaiDangDoGiaDungEntities baiDangBanGhe = _mapper.Map<BaiDangDoGiaDungEntities>(baiDangRequest);
            int lastIDPost = baiDangDoGiaDungHelper.AddBaiDang(baiDangBanGhe);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public async Task<bool> AddBaiDangDoGiaDungBep(BaiDangDoGiaDungBep_DTO baiDangRequest)
        {
            BaiDangDoGiaDungEntities baiDangBep = _mapper.Map<BaiDangDoGiaDungEntities>(baiDangRequest);
            int lastIDPost = baiDangDoGiaDungHelper.AddBaiDang(baiDangBep);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public async Task<bool> AddBaiDangDoGiaDungDenCayCanhNoiThat(BaiDangDoGiaDungDenCayCanhNoiThat_DTO baiDangRequest)
        {
            BaiDangDoGiaDungEntities baiDangDenCayCanhNoiThat = _mapper.Map<BaiDangDoGiaDungEntities>(baiDangRequest);
            int lastIDPost = baiDangDoGiaDungHelper.AddBaiDang(baiDangDenCayCanhNoiThat);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

        }
        public async Task<bool> AddBaiDangDoGiaDungGiuong(BaiDangDoGiaDungGiuong_DTO baiDangRequest)
        {
            BaiDangDoGiaDungEntities baiDangGiuong = _mapper.Map<BaiDangDoGiaDungEntities>(baiDangRequest);
            int lastIDPost = baiDangDoGiaDungHelper.AddBaiDang(baiDangGiuong);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

        }
        public async Task<bool> AddBaiDangDoGiaDungQuat(BaiDangDoGiaDungQuat_DTO baiDangRequest)
        {
            BaiDangDoGiaDungEntities baiDangQuat = _mapper.Map<BaiDangDoGiaDungEntities>(baiDangRequest);
            int lastIDPost = baiDangDoGiaDungHelper.AddBaiDang(baiDangQuat);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

        }
        public async Task<bool> AddBaiDangDoGiaDungThietBiVeSinh(BaiDangDoGiaDungThietBiVeSinh_DTO baiDangRequest)
        {
            BaiDangDoGiaDungEntities baiDangThietBiVeSinh = _mapper.Map<BaiDangDoGiaDungEntities>(baiDangRequest);
            int lastIDPost = baiDangDoGiaDungHelper.AddBaiDang(baiDangThietBiVeSinh);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

        }
        public async Task<bool> AddBaiDangDoGiaDungTuKe(BaiDangDoGiaDungTuKe_DTO baiDangRequest)
        {
            BaiDangDoGiaDungEntities baiDangTuKe = _mapper.Map<BaiDangDoGiaDungEntities>(baiDangRequest);
            int lastIDPost = baiDangDoGiaDungHelper.AddBaiDang(baiDangTuKe);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

        }
        #endregion

        #region BaiDang MeVaBe
        public async Task<bool> AddBaiDangMeVaBe(BaiDangMeVaBe_DTO baiDangRequest)
        {
            BaiDangMeVaBeEntities baiDangMeVaBe = _mapper.Map<BaiDangMeVaBeEntities>(baiDangRequest);
            int lastIDPost = baiDangMeVaBeHelper.AddBaiDang(baiDangMeVaBe);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        #endregion

        #region BaiDang ThoiTrang
        public async Task<bool> AddBaiDangThoiTrang(BaiDangThoiTrang_DTO baiDangRequest)
        {
            BaiDangThoiTrangEntities baiDangThoiTrang = _mapper.Map<BaiDangThoiTrangEntities>(baiDangRequest);
            int lastIDPost = baiDangThoiTrangHelper.AddBaiDang(baiDangThoiTrang);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        #endregion

        #region BaiDang GiaiTri
        public async Task<bool> AddBaiDangGiaiTri(BaiDangGiaiTri_DTO baiDangRequest)
        {
            BaiDangGiaiTriEntities baiDangGiaiTri = _mapper.Map<BaiDangGiaiTriEntities>(baiDangRequest);
            int lastIDPost = baiDangGiaiTriHelper.AddBaiDang(baiDangGiaiTri);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public async Task<bool> AddBaiDangGiaiTriNhacCu(BaiDangGiaiTriDoNhacCu_DTO baiDangRequest)
        {
            BaiDangGiaiTriEntities baiDangGiaiTri = _mapper.Map<BaiDangGiaiTriEntities>(baiDangRequest);
            int lastIDPost = baiDangGiaiTriHelper.AddBaiDang(baiDangGiaiTri);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public async Task<bool> AddBaiDangGiaiTriDoSuuTam(BaiDangGiaiTriDoSuuTam_DTO baiDangRequest)
        {
            BaiDangGiaiTriEntities baiDangGiaiTri = _mapper.Map<BaiDangGiaiTriEntities>(baiDangRequest);
            int lastIDPost = baiDangGiaiTriHelper.AddBaiDang(baiDangGiaiTri);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        #endregion

        #region BaiDang DoDungVanPhong
        public async Task<bool> AddBaiDangDoDungVanPhong(BaiDangDoDungVanPhong_DTO baiDangRequest)
        {
            BaiDangDoDungVanPhongEntities baiDangDoDungVanPhong = _mapper.Map<BaiDangDoDungVanPhongEntities>(baiDangRequest);
            int lastIDPost = baiDangDoDungVanPhongHelper.AddBaiDang(baiDangDoDungVanPhong);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.AddBaiDang(baiDangGlobal);
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = baiDangHelper.NumberOfPost();
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        #endregion
        #endregion

        #region Update
        #region BaiDangBatDongSan
        public async Task<bool> UpdateBaiDangBatDongSanCC(BaiDangBatDongSanCC_DTO baiDangRequest)
        {
            BaiDangBatDongSanEntities baiDangBatDongSanCC = _mapper.Map<BaiDangBatDongSanEntities>(baiDangRequest);
            baiDangBatDongSanCC.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangBatDongSanHelper.UpdateBaiDang(baiDangBatDongSanCC);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public async Task<bool> UpdateBaiDangBatDongSanNhaO(BaiDangBatDongSanNhaO_DTO baiDangRequest)
        {
            BaiDangBatDongSanEntities baiDangBatDongSanCC = _mapper.Map<BaiDangBatDongSanEntities>(baiDangRequest);
            baiDangBatDongSanCC.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangBatDongSanHelper.UpdateBaiDang(baiDangBatDongSanCC);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }
                    
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public async Task<bool> UpdateBaiDangBatDongSanDat(BaiDangBatDongSanDat_DTO baiDangRequest)
        {
            BaiDangBatDongSanEntities baiDangBatDongSanCC = _mapper.Map<BaiDangBatDongSanEntities>(baiDangRequest);
            baiDangBatDongSanCC.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangBatDongSanHelper.UpdateBaiDang(baiDangBatDongSanCC);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public async Task<bool> UpdateBaiDangBatDongSanVanPhong(BaiDangBatDongSanVanPhong_DTO baiDangRequest)
        {
            BaiDangBatDongSanEntities baiDangBatDongSanCC = _mapper.Map<BaiDangBatDongSanEntities>(baiDangRequest);
            baiDangBatDongSanCC.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangBatDongSanHelper.UpdateBaiDang(baiDangBatDongSanCC);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public async Task<bool> UpdateBaiDangBatDongSanPhongTro(BaiDangBatDongSanPhongTro_DTO baiDangRequest)
        {
            BaiDangBatDongSanEntities baiDangBatDongSanCC = _mapper.Map<BaiDangBatDongSanEntities>(baiDangRequest);
            baiDangBatDongSanCC.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangBatDongSanHelper.UpdateBaiDang(baiDangBatDongSanCC);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        #endregion

        #region BaiDangXeCo
        public async Task<bool> UpdateBaiDangXeCoOTo(BaiDangXeCoOto_DTO baiDangRequest)
        {
            BaiDangXeCoEntities baiDangXeCoOto = _mapper.Map<BaiDangXeCoEntities>(baiDangRequest);
            baiDangXeCoOto.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangXeCoHelper.UpdateBaiDang(baiDangXeCoOto);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public async Task<bool> UpdateBaiDangXeCoXeMay(BaiDangXeCoXeMay_DTO baiDangRequest)
        {
            BaiDangXeCoEntities baiDangXeCoOto = _mapper.Map<BaiDangXeCoEntities>(baiDangRequest);
            baiDangXeCoOto.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangXeCoHelper.UpdateBaiDang(baiDangXeCoOto);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public async Task<bool> UpdateBaiDangXeCoXeTai(BaiDangXeCoXeTai_DTO baiDangRequest)
        {
            BaiDangXeCoEntities baiDangXeCoOto = _mapper.Map<BaiDangXeCoEntities>(baiDangRequest);
            baiDangXeCoOto.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangXeCoHelper.UpdateBaiDang(baiDangXeCoOto);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public async Task<bool> UpdateBaiDangXeCoXeDien(BaiDangXeCoXeDien_DTO baiDangRequest)
        {
            BaiDangXeCoEntities baiDangXeCoOto = _mapper.Map<BaiDangXeCoEntities>(baiDangRequest);
            baiDangXeCoOto.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangXeCoHelper.UpdateBaiDang(baiDangXeCoOto);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public async Task<bool> UpdateBaiDangXeCoXeDap(BaiDangXeCoXeDap_DTO baiDangRequest)
        {
            BaiDangXeCoEntities baiDangXeCoOto = _mapper.Map<BaiDangXeCoEntities>(baiDangRequest);
            baiDangXeCoOto.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangXeCoHelper.UpdateBaiDang(baiDangXeCoOto);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public async Task<bool> UpdateBaiDangXeCoPhuongTienKhac(BaiDangXeCoPhuongTienKhac_DTO baiDangRequest)
        {
            BaiDangXeCoEntities baiDangXeCoOto = _mapper.Map<BaiDangXeCoEntities>(baiDangRequest);
            baiDangXeCoOto.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangXeCoHelper.UpdateBaiDang(baiDangXeCoOto);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public async Task<bool> UpdateBaiDangXeCoPhuTungKhac(BaiDangXeCoPhuTungXe_DTO baiDangRequest)
        {
            BaiDangXeCoEntities baiDangXeCoOto = _mapper.Map<BaiDangXeCoEntities>(baiDangRequest);
            baiDangXeCoOto.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangXeCoHelper.UpdateBaiDang(baiDangXeCoOto);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        #endregion

        #region BaiDangDoDienTu
        public async Task<bool> UpdateBaiDangDoDienTuDienThoai(BaiDangDoDienTuDienThoai_DTO baiDangRequest)
        {
            BaiDangDoDienTuEntities baiDangDoDienTuDienThoai = _mapper.Map<BaiDangDoDienTuEntities>(baiDangRequest);
            baiDangDoDienTuDienThoai.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangDoDienTuHelper.UpdateBaiDang(baiDangDoDienTuDienThoai);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public async Task<bool> UpdateBaiDangDoDienTuLaptop(BaiDangDoDienTuLaptop_DTO baiDangRequest)
        {
            BaiDangDoDienTuEntities baiDangDoDienTuDienThoai = _mapper.Map<BaiDangDoDienTuEntities>(baiDangRequest);
            baiDangDoDienTuDienThoai.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangDoDienTuHelper.UpdateBaiDang(baiDangDoDienTuDienThoai);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public async Task<bool> UpdateBaiDangDoDienTuLinhKien(BaiDangDoDienTuLinhKien_DTO baiDangRequest)
        {
            BaiDangDoDienTuEntities baiDangDoDienTuDienThoai = _mapper.Map<BaiDangDoDienTuEntities>(baiDangRequest);
            baiDangDoDienTuDienThoai.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangDoDienTuHelper.UpdateBaiDang(baiDangDoDienTuDienThoai);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public async Task<bool> UpdateBaiDangDoDienTuMayAnh(BaiDangDoDienTuMayAnh_DTO baiDangRequest)
        {
            BaiDangDoDienTuEntities baiDangDoDienTuDienThoai = _mapper.Map<BaiDangDoDienTuEntities>(baiDangRequest);
            baiDangDoDienTuDienThoai.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangDoDienTuHelper.UpdateBaiDang(baiDangDoDienTuDienThoai);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public async Task<bool> UpdateBaiDangDoDienTuMayTinhBang(BaiDangDoDienTuMayTinhBang_DTO baiDangRequest)
        {
            BaiDangDoDienTuEntities baiDangDoDienTuDienThoai = _mapper.Map<BaiDangDoDienTuEntities>(baiDangRequest);
            baiDangDoDienTuDienThoai.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangDoDienTuHelper.UpdateBaiDang(baiDangDoDienTuDienThoai);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public async Task<bool> UpdateBaiDangDoDienTuMayTinhDeBan(BaiDangDoDienTuMayTinhDeBan_DTO baiDangRequest)
        {
            BaiDangDoDienTuEntities baiDangDoDienTuDienThoai = _mapper.Map<BaiDangDoDienTuEntities>(baiDangRequest);
            baiDangDoDienTuDienThoai.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangDoDienTuHelper.UpdateBaiDang(baiDangDoDienTuDienThoai);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public async Task<bool> UpdateBaiDangDoDienTuPhuKien(BaiDangDoDienTuPhuKien_DTO baiDangRequest)
        {
            BaiDangDoDienTuEntities baiDangDoDienTuDienThoai = _mapper.Map<BaiDangDoDienTuEntities>(baiDangRequest);
            baiDangDoDienTuDienThoai.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangDoDienTuHelper.UpdateBaiDang(baiDangDoDienTuDienThoai);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public async Task<bool> UpdateBaiDangDoDienTuThietBiDeoThongMinh(BaiDangDoDienTuThietBiDeoThongMinh_DTO baiDangRequest)
        {
            BaiDangDoDienTuEntities baiDangDoDienTuDienThoai = _mapper.Map<BaiDangDoDienTuEntities>(baiDangRequest);
            baiDangDoDienTuDienThoai.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangDoDienTuHelper.UpdateBaiDang(baiDangDoDienTuDienThoai);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public async Task<bool> UpdateBaiDangDoDienTuTivi(BaiDangDoDienTuTivi_DTO baiDangRequest)
        {
            BaiDangDoDienTuEntities baiDangDoDienTuDienThoai = _mapper.Map<BaiDangDoDienTuEntities>(baiDangRequest);
            baiDangDoDienTuDienThoai.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangDoDienTuHelper.UpdateBaiDang(baiDangDoDienTuDienThoai);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        #endregion

        #region BaiDangViecLam
        public async Task<bool> UpdateBaiDangViecLam(BaiDangViecLamDTO baiDangRequest)
        {
            BaiDangViecLamEntities baiDangViecLam = _mapper.Map<BaiDangViecLamEntities>(baiDangRequest);
            baiDangViecLam.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangViecLamHelper.UpdateBaiDang(baiDangViecLam);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        #endregion

        #region BaiDangThuCung
        public async Task<bool> UpdateBaiDangThuCungChim(BaiDangThuCungChim_DTO baiDangRequest)
        {
            BaiDangThuCungEntities baiDangThuCung = _mapper.Map<BaiDangThuCungEntities>(baiDangRequest);
            baiDangThuCung.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangThuCungHelper.UpdateBaiDang(baiDangThuCung);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public async Task<bool> UpdateBaiDangThuCungCho(BaiDangThuCungCho_DTO baiDangRequest)
        {
            BaiDangThuCungEntities baiDangThuCung = _mapper.Map<BaiDangThuCungEntities>(baiDangRequest);
            baiDangThuCung.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangThuCungHelper.UpdateBaiDang(baiDangThuCung);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public async Task<bool> UpdateBaiDangThuCungGaMeoThuCungKhac(BaiDangThuCungGaMeoThuCungKhac_DTO baiDangRequest)
        {
            BaiDangThuCungEntities baiDangThuCung = _mapper.Map<BaiDangThuCungEntities>(baiDangRequest);
            baiDangThuCung.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangThuCungHelper.UpdateBaiDang(baiDangThuCung);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        #endregion

        #region BaiDangDoAnThucPham
        public async Task<bool> UpdateBaiDangDoAnThucPham(BaiDangDoAnThucPham_DTO baiDangRequest)
        {
            BaiDangDoAnThucPhamEntities baiDangThucPham = _mapper.Map<BaiDangDoAnThucPhamEntities>(baiDangRequest);
            baiDangThucPham.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangDoAnThucPhamHelper.UpdateBaiDang(baiDangThucPham);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        #endregion

        #region BaiDangTuLanh
        public async Task<bool> UpdateBaiDangTuLanh(BaiDangTuLanhTL_DTO baiDangRequest)
        {
            BaiDangTuLanhEntities baiDangTuLanh = _mapper.Map<BaiDangTuLanhEntities>(baiDangRequest);
            baiDangTuLanh.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangTuLanhHelper.UpdateBaiDang(baiDangTuLanh);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public async Task<bool> UpdateBaiDangMayGiat(BaiDangTuLanhMayGiat_DTO baiDangRequest)
        {
            BaiDangTuLanhEntities baiDangTuLanh = _mapper.Map<BaiDangTuLanhEntities>(baiDangRequest);
            baiDangTuLanh.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangTuLanhHelper.UpdateBaiDang(baiDangTuLanh);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

        }

        public async Task<bool> UpdateBaiDangMayLanh(BaiDangTuLanhMayLanh_DTO baiDangRequest)
        {
            BaiDangTuLanhEntities baiDangTuLanh = _mapper.Map<BaiDangTuLanhEntities>(baiDangRequest);
            baiDangTuLanh.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangTuLanhHelper.UpdateBaiDang(baiDangTuLanh);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        #endregion

        #region BaiDang DoGiaDung
        public async Task<bool> UpdateBaiDangDoGiaDungBanGhe(BaiDangDoGiaDungBanGhe_DTO baiDangRequest)
        {
            BaiDangDoGiaDungEntities baiDangBanGhe = _mapper.Map<BaiDangDoGiaDungEntities>(baiDangRequest);
            baiDangBanGhe.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangDoGiaDungHelper.UpdateBaiDang(baiDangBanGhe);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public async Task<bool> UpdateBaiDangDoGiaDungBep(BaiDangDoGiaDungBep_DTO baiDangRequest)
        {
            BaiDangDoGiaDungEntities baiDangBanGhe = _mapper.Map<BaiDangDoGiaDungEntities>(baiDangRequest);
            baiDangBanGhe.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangDoGiaDungHelper.UpdateBaiDang(baiDangBanGhe);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public async Task<bool> UpdateBaiDangDoGiaDungDenCayCanhNoiThat(BaiDangDoGiaDungDenCayCanhNoiThat_DTO baiDangRequest)
        {
            BaiDangDoGiaDungEntities baiDangBanGhe = _mapper.Map<BaiDangDoGiaDungEntities>(baiDangRequest);
            baiDangBanGhe.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangDoGiaDungHelper.UpdateBaiDang(baiDangBanGhe);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

        }
        public async Task<bool> UpdateBaiDangDoGiaDungGiuong(BaiDangDoGiaDungGiuong_DTO baiDangRequest)
        {
            BaiDangDoGiaDungEntities baiDangBanGhe = _mapper.Map<BaiDangDoGiaDungEntities>(baiDangRequest);
            baiDangBanGhe.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangDoGiaDungHelper.UpdateBaiDang(baiDangBanGhe);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

        }
        public async Task<bool> UpdateBaiDangDoGiaDungQuat(BaiDangDoGiaDungQuat_DTO baiDangRequest)
        {
            BaiDangDoGiaDungEntities baiDangBanGhe = _mapper.Map<BaiDangDoGiaDungEntities>(baiDangRequest);
            baiDangBanGhe.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangDoGiaDungHelper.UpdateBaiDang(baiDangBanGhe);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

        }
        public async Task<bool> UpdateBaiDangDoGiaDungThietBiVeSinh(BaiDangDoGiaDungThietBiVeSinh_DTO baiDangRequest)
        {
            BaiDangDoGiaDungEntities baiDangBanGhe = _mapper.Map<BaiDangDoGiaDungEntities>(baiDangRequest);
            baiDangBanGhe.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangDoGiaDungHelper.UpdateBaiDang(baiDangBanGhe);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

        }
        public async Task<bool> UpdateBaiDangDoGiaDungTuKe(BaiDangDoGiaDungTuKe_DTO baiDangRequest)
        {
            BaiDangDoGiaDungEntities baiDangBanGhe = _mapper.Map<BaiDangDoGiaDungEntities>(baiDangRequest);
            baiDangBanGhe.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangDoGiaDungHelper.UpdateBaiDang(baiDangBanGhe);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

        }
        #endregion

        #region BaiDang MeVaBe
        public async Task<bool> UpdateBaiDangMeVaBe(BaiDangMeVaBe_DTO baiDangRequest)
        {
            BaiDangMeVaBeEntities baiDangMeVaBe = _mapper.Map<BaiDangMeVaBeEntities>(baiDangRequest);
            baiDangMeVaBe.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangMeVaBeHelper.UpdateBaiDang(baiDangMeVaBe);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        #endregion

        #region BaiDang ThoiTrang
        public async Task<bool> UpdateBaiDangThoiTrang(BaiDangThoiTrang_DTO baiDangRequest)
        {
            BaiDangThoiTrangEntities baiDangThoiTrang = _mapper.Map<BaiDangThoiTrangEntities>(baiDangRequest);
            baiDangThoiTrang.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangThoiTrangHelper.UpdateBaiDang(baiDangThoiTrang);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        #endregion

        #region BaiDang GiaiTri
        public async Task<bool> UpdateBaiDangGiaiTri(BaiDangGiaiTri_DTO baiDangRequest)
        {
            BaiDangGiaiTriEntities baiDangGiaiTri = _mapper.Map<BaiDangGiaiTriEntities>(baiDangRequest);
            baiDangGiaiTri.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangGiaiTriHelper.UpdateBaiDang(baiDangGiaiTri);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public async Task<bool> UpdateBaiDangGiaiTriNhacCu(BaiDangGiaiTriDoNhacCu_DTO baiDangRequest)
        {
            BaiDangGiaiTriEntities baiDangGiaiTri = _mapper.Map<BaiDangGiaiTriEntities>(baiDangRequest);
            baiDangGiaiTri.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangGiaiTriHelper.UpdateBaiDang(baiDangGiaiTri);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public async Task<bool> UpdateBaiDangGiaiTriDoSuuTam(BaiDangGiaiTriDoSuuTam_DTO baiDangRequest)
        {
            BaiDangGiaiTriEntities baiDangGiaiTri = _mapper.Map<BaiDangGiaiTriEntities>(baiDangRequest);
            baiDangGiaiTri.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangGiaiTriHelper.UpdateBaiDang(baiDangGiaiTri);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        #endregion

        #region BaiDang DoDungVanPhong
        public async Task<bool> UpdateBaiDangDoDungVanPhong(BaiDangDoDungVanPhong_DTO baiDangRequest)
        {
            BaiDangDoDungVanPhongEntities baiDangDoDungVanPhong = _mapper.Map<BaiDangDoDungVanPhongEntities>(baiDangRequest);
            baiDangDoDungVanPhong.IdBaiDang = baiDangHelper.GetPostDetailID((int)baiDangRequest.IdBaiDang);
            int lastIDPost = baiDangDoDungVanPhongHelper.UpdateBaiDang(baiDangDoDungVanPhong);
            if (lastIDPost == -1)
            {
                return false;
            }
            else
            {
                try
                {
                    BaiDangEntities baiDangGlobal = _mapper.Map<BaiDangEntities>(baiDangRequest);
                    baiDangGlobal.IdBaiDangChiTiet = lastIDPost;
                    await baiDangHelper.UpdateBaiDang(baiDangGlobal);
                    List<HinhAnhBaiDangEntities> hinhAnhExist = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(baiDangGlobal.IdBaiDang);
                    int[] idxExist = new int[baiDangRequest.hinhAnh_BaiDangs.Count];
                    foreach (var itemImg in hinhAnhExist)
                    {
                        hinhAnhBaiDangHelper.RemoveHinhAnh(itemImg);
                    }
                    foreach (var item in baiDangRequest.hinhAnh_BaiDangs)
                    {
                        HinhAnhBaiDangEntities hinhAnhRequest = new HinhAnhBaiDangEntities();
                        hinhAnhRequest.IdSanPham = (int)baiDangRequest.IdBaiDang;
                        hinhAnhRequest.IdMediaCloud = item.id;
                        if (item.type.Contains("video"))
                            hinhAnhRequest.VideoType = true;
                        else
                            hinhAnhRequest.VideoType = false;
                        hinhAnhBaiDangHelper.AddHinhAnh(hinhAnhRequest);

                    }

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        #endregion

        #region PrefightForUpdate

        #region BatDongSan
        public async Task<BaiDangBatDongSanCC_DTO> PreflightBaiDangBatDongSanCC(int ID)
        {
            BaiDangBatDongSanCC_DTO result = new BaiDangBatDongSanCC_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangBatDongSanEntities detailBaiDang = baiDangBatDongSanHelper.getPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangBatDongSanCC_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();
            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }

        public async Task<BaiDangBatDongSanDat_DTO> PreflightBaiDangBatDongSanDat(int ID)
        {
            BaiDangBatDongSanDat_DTO result = new BaiDangBatDongSanDat_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangBatDongSanEntities detailBaiDang = baiDangBatDongSanHelper.getPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangBatDongSanDat_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();
            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }

        public async Task<BaiDangBatDongSanNhaO_DTO> PreflightBaiDangBatDongSanNhaO(int ID)
        {
            BaiDangBatDongSanNhaO_DTO result = new BaiDangBatDongSanNhaO_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangBatDongSanEntities detailBaiDang = baiDangBatDongSanHelper.getPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangBatDongSanNhaO_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();
            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }

        public async Task<BaiDangBatDongSanPhongTro_DTO> PreflightBaiDangBatDongSanPhongTro(int ID)
        {
            BaiDangBatDongSanPhongTro_DTO result = new BaiDangBatDongSanPhongTro_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangBatDongSanEntities detailBaiDang = baiDangBatDongSanHelper.getPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangBatDongSanPhongTro_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();
            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }

        public async Task<BaiDangBatDongSanVanPhong_DTO> PreflightBaiDangBatDongSanVanPhong(int ID)
        {
            BaiDangBatDongSanVanPhong_DTO result = new BaiDangBatDongSanVanPhong_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangBatDongSanEntities detailBaiDang = baiDangBatDongSanHelper.getPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangBatDongSanVanPhong_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();
            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }
        #endregion

        #region XeCo
        public async Task<BaiDangXeCoOto_DTO> PreflightBaiDangXeCoOTo(int ID)
        {
            BaiDangXeCoOto_DTO result = new BaiDangXeCoOto_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangXeCoEntities detailBaiDang = baiDangXeCoHelper.getPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangXeCoOto_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();
            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }

        public async Task<BaiDangXeCoXeMay_DTO> PreflightBaiDangXeCoXeMay(int ID)
        {
            BaiDangXeCoXeMay_DTO result = new BaiDangXeCoXeMay_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangXeCoEntities detailBaiDang = baiDangXeCoHelper.getPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangXeCoXeMay_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();
            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }

        public async Task<BaiDangXeCoXeTai_DTO> PreflightBaiDangXeCoXeTai(int ID)
        {
            BaiDangXeCoXeTai_DTO result = new BaiDangXeCoXeTai_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangXeCoEntities detailBaiDang = baiDangXeCoHelper.getPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangXeCoXeTai_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();
            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }

        public async Task<BaiDangXeCoXeDien_DTO> PreflightBaiDangXeCoXeDien(int ID)
        {
            BaiDangXeCoXeDien_DTO result = new BaiDangXeCoXeDien_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangXeCoEntities detailBaiDang = baiDangXeCoHelper.getPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangXeCoXeDien_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();
            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }

        public async Task<BaiDangXeCoXeDap_DTO> PreflightBaiDangXeCoXeDap(int ID)
        {
            BaiDangXeCoXeDap_DTO result = new BaiDangXeCoXeDap_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangXeCoEntities detailBaiDang = baiDangXeCoHelper.getPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangXeCoXeDap_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();
            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }

        public async Task<BaiDangXeCoPhuongTienKhac_DTO> PreflightBaiDangXeCoPhuongTienKhac(int ID)
        {
            BaiDangXeCoPhuongTienKhac_DTO result = new BaiDangXeCoPhuongTienKhac_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangXeCoEntities detailBaiDang = baiDangXeCoHelper.getPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangXeCoPhuongTienKhac_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();
            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }

        public async Task<BaiDangXeCoPhuTungXe_DTO> PreflightBaiDangXeCoPhuTungKhac(int ID)
        {
            BaiDangXeCoPhuTungXe_DTO result = new BaiDangXeCoPhuTungXe_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangXeCoEntities detailBaiDang = baiDangXeCoHelper.getPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangXeCoPhuTungXe_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();
            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }
        #endregion

        #region BaiDangDoDienTu
        public async Task<BaiDangDoDienTuDienThoai_DTO> PreflightBaiDangDoDienTuDienThoai(int ID)
        {
            BaiDangDoDienTuDienThoai_DTO result = new BaiDangDoDienTuDienThoai_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangDoDienTuEntities detailBaiDang = baiDangDoDienTuHelper.GetPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangDoDienTuDienThoai_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();
            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }

        public async Task<BaiDangDoDienTuLaptop_DTO> PreflightBaiDangDoDienTuLaptop(int ID)
        {
            BaiDangDoDienTuLaptop_DTO result = new BaiDangDoDienTuLaptop_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangDoDienTuEntities detailBaiDang = baiDangDoDienTuHelper.GetPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangDoDienTuLaptop_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();
            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }

        public async Task<BaiDangDoDienTuLinhKien_DTO> PreflightBaiDangDoDienTuLinhKien(int ID)
        {
            BaiDangDoDienTuLinhKien_DTO result = new BaiDangDoDienTuLinhKien_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangDoDienTuEntities detailBaiDang = baiDangDoDienTuHelper.GetPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangDoDienTuLinhKien_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();
            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }

        public async Task<BaiDangDoDienTuMayAnh_DTO> PreflightBaiDangDoDienTuMayAnh(int ID)
        {
            BaiDangDoDienTuMayAnh_DTO result = new BaiDangDoDienTuMayAnh_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangDoDienTuEntities detailBaiDang = baiDangDoDienTuHelper.GetPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangDoDienTuMayAnh_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();
            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }

        public async Task<BaiDangDoDienTuMayTinhBang_DTO> PreflightBaiDangDoDienTuMayTinhBang(int ID)
        {
            BaiDangDoDienTuMayTinhBang_DTO result = new BaiDangDoDienTuMayTinhBang_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangDoDienTuEntities detailBaiDang = baiDangDoDienTuHelper.GetPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangDoDienTuMayTinhBang_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();
            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }

        public async Task<BaiDangDoDienTuMayTinhDeBan_DTO> PreflightBaiDangDoDienTuMayTinhDeBan(int ID)
        {
            BaiDangDoDienTuMayTinhDeBan_DTO result = new BaiDangDoDienTuMayTinhDeBan_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangDoDienTuEntities detailBaiDang = baiDangDoDienTuHelper.GetPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangDoDienTuMayTinhDeBan_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();
            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }

        public async Task<BaiDangDoDienTuPhuKien_DTO> PreflightBaiDangDoDienTuPhuKien(int ID)
        {
            BaiDangDoDienTuPhuKien_DTO result = new BaiDangDoDienTuPhuKien_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangDoDienTuEntities detailBaiDang = baiDangDoDienTuHelper.GetPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangDoDienTuPhuKien_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();
            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }

        public async Task<BaiDangDoDienTuThietBiDeoThongMinh_DTO> PreflightBaiDangDoDienTuThietBiDeoThongMinh(int ID)
        {
            BaiDangDoDienTuThietBiDeoThongMinh_DTO result = new BaiDangDoDienTuThietBiDeoThongMinh_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangDoDienTuEntities detailBaiDang = baiDangDoDienTuHelper.GetPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangDoDienTuThietBiDeoThongMinh_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();
            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }

        public async Task<BaiDangDoDienTuTivi_DTO> PreflightBaiDangDoDienTuTivi(int ID)
        {
            BaiDangDoDienTuTivi_DTO result = new BaiDangDoDienTuTivi_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangDoDienTuEntities detailBaiDang = baiDangDoDienTuHelper.GetPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangDoDienTuTivi_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();
            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }

        #endregion

        #region BaiDangViecLam
        public async Task<BaiDangViecLamDTO> PreflightBaiDangViecLam(int ID)
        {
            BaiDangViecLamDTO result = new BaiDangViecLamDTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangViecLamEntities detailBaiDang = baiDangViecLamHelper.GetPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangViecLamDTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();
            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }
        #endregion

        #region BaiDangThuCung
        public async Task<BaiDangThuCungChim_DTO> PreflightBaiDangThuCungChim(int ID)
        {
            BaiDangThuCungChim_DTO result = new BaiDangThuCungChim_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangThuCungEntities detailBaiDang = baiDangThuCungHelper.GetPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangThuCungChim_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();
            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }

        public async Task<BaiDangThuCungCho_DTO> PreflightBaiDangThuCungCho(int ID)
        {
            BaiDangThuCungCho_DTO result = new BaiDangThuCungCho_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangThuCungEntities detailBaiDang = baiDangThuCungHelper.GetPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangThuCungCho_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();

            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }

        public async Task<BaiDangThuCungGaMeoThuCungKhac_DTO> PreflightBaiDangThuCungGaMeoThuCungKhac(int ID)
        {
            BaiDangThuCungGaMeoThuCungKhac_DTO result = new BaiDangThuCungGaMeoThuCungKhac_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangThuCungEntities detailBaiDang = baiDangThuCungHelper.GetPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangThuCungGaMeoThuCungKhac_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();

            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }

        #endregion

        #region BaiDangDoAnThucPham
        public async Task<BaiDangDoAnThucPham_DTO> PreflightBaiDangDoAnThucPham(int ID)
        {
            BaiDangDoAnThucPham_DTO result = new BaiDangDoAnThucPham_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangDoAnThucPhamEntities detailBaiDang = baiDangDoAnThucPhamHelper.GetPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangDoAnThucPham_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();

            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }
        #endregion

        #region BaiDangTuLanh
        public async Task<BaiDangTuLanhTL_DTO> PreflightBaiDangTuLanh(int ID)
        {
            BaiDangTuLanhTL_DTO result = new BaiDangTuLanhTL_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangTuLanhEntities detailBaiDang = baiDangTuLanhHelper.GetPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangTuLanhTL_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();

            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }

        public async Task<BaiDangTuLanhMayGiat_DTO> PreflightBaiDangMayGiat(int ID)
        {
            BaiDangTuLanhMayGiat_DTO result = new BaiDangTuLanhMayGiat_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangTuLanhEntities detailBaiDang = baiDangTuLanhHelper.GetPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangTuLanhMayGiat_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();

            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;

        }

        public async Task<BaiDangTuLanhMayLanh_DTO> PreflightBaiDangMayLanh(int ID)
        {
            BaiDangTuLanhMayLanh_DTO result = new BaiDangTuLanhMayLanh_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangTuLanhEntities detailBaiDang = baiDangTuLanhHelper.GetPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangTuLanhMayLanh_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();

            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }
        #endregion

        #region BaiDang DoGiaDung
        public async Task<BaiDangDoGiaDungBanGhe_DTO> PreflightBaiDangDoGiaDungBanGhe(int ID)
        {
            BaiDangDoGiaDungBanGhe_DTO result = new BaiDangDoGiaDungBanGhe_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangDoGiaDungEntities detailBaiDang = baiDangDoGiaDungHelper.GetPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangDoGiaDungBanGhe_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();

            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }
        public async Task<BaiDangDoGiaDungBep_DTO> PreflightBaiDangDoGiaDungBep(int ID)
        {
            BaiDangDoGiaDungBep_DTO result = new BaiDangDoGiaDungBep_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangDoGiaDungEntities detailBaiDang = baiDangDoGiaDungHelper.GetPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangDoGiaDungBep_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();

            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }
        public async Task<BaiDangDoGiaDungDenCayCanhNoiThat_DTO> PreflightBaiDangDoGiaDungDenCayCanhNoiThat(int ID)
        {
            BaiDangDoGiaDungDenCayCanhNoiThat_DTO result = new BaiDangDoGiaDungDenCayCanhNoiThat_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangDoGiaDungEntities detailBaiDang = baiDangDoGiaDungHelper.GetPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangDoGiaDungDenCayCanhNoiThat_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();

            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;

        }
        public async Task<BaiDangDoGiaDungGiuong_DTO> PreflightBaiDangDoGiaDungGiuong(int ID)
        {
            BaiDangDoGiaDungGiuong_DTO result = new BaiDangDoGiaDungGiuong_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangDoGiaDungEntities detailBaiDang = baiDangDoGiaDungHelper.GetPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangDoGiaDungGiuong_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();

            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }
        public async Task<BaiDangDoGiaDungQuat_DTO> PreflightBaiDangDoGiaDungQuat(int ID)
        {
            BaiDangDoGiaDungQuat_DTO result = new BaiDangDoGiaDungQuat_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangDoGiaDungEntities detailBaiDang = baiDangDoGiaDungHelper.GetPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangDoGiaDungQuat_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();

            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }
        public async Task<BaiDangDoGiaDungThietBiVeSinh_DTO> PreflightBaiDangDoGiaDungThietBiVeSinh(int ID)
        {
            BaiDangDoGiaDungThietBiVeSinh_DTO result = new BaiDangDoGiaDungThietBiVeSinh_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangDoGiaDungEntities detailBaiDang = baiDangDoGiaDungHelper.GetPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangDoGiaDungThietBiVeSinh_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();

            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }
        public async Task<BaiDangDoGiaDungTuKe_DTO> PreflightBaiDangDoGiaDungTuKe(int ID)
        {
            BaiDangDoGiaDungTuKe_DTO result = new BaiDangDoGiaDungTuKe_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangDoGiaDungEntities detailBaiDang = baiDangDoGiaDungHelper.GetPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangDoGiaDungTuKe_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();

            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }
        #endregion

        #region BaiDang MeVaBe
        public async Task<BaiDangMeVaBe_DTO> PreflightBaiDangMeVaBe(int ID)
        {
            BaiDangMeVaBe_DTO result = new BaiDangMeVaBe_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangMeVaBeEntities detailBaiDang = baiDangMeVaBeHelper.GetPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangMeVaBe_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();

            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }
        #endregion

        #region BaiDang ThoiTrang
        public async Task<BaiDangThoiTrang_DTO> PreflightBaiDangThoiTrang(int ID)
        {
            BaiDangThoiTrang_DTO result = new BaiDangThoiTrang_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangThoiTrangEntities detailBaiDang = baiDangThoiTrangHelper.GetPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangThoiTrang_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();

            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }
        #endregion

        #region BaiDang GiaiTri
        public async Task<BaiDangGiaiTri_DTO> PreflightBaiDangGiaiTri(int ID)
        {
            BaiDangGiaiTri_DTO result = new BaiDangGiaiTri_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangGiaiTriEntities detailBaiDang = baiDangGiaiTriHelper.GetPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangGiaiTri_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();

            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }
        public async Task<BaiDangGiaiTriDoNhacCu_DTO> PreflightBaiDangGiaiTriNhacCu(int ID)
        {
            BaiDangGiaiTriDoNhacCu_DTO result = new BaiDangGiaiTriDoNhacCu_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangGiaiTriEntities detailBaiDang = baiDangGiaiTriHelper.GetPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangGiaiTriDoNhacCu_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();

            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }
        public async Task<BaiDangGiaiTriDoSuuTam_DTO> PreflightBaiDangGiaiTriDoSuuTam(int ID)
        {
            BaiDangGiaiTriDoSuuTam_DTO result = new BaiDangGiaiTriDoSuuTam_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangGiaiTriEntities detailBaiDang = baiDangGiaiTriHelper.GetPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangGiaiTriDoSuuTam_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();

            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }
        #endregion

        #region BaiDang DoDungVanPhong
        public async Task<BaiDangDoDungVanPhong_DTO> PreflightBaiDangDoDungVanPhong(int ID)
        {
            BaiDangDoDungVanPhong_DTO result = new BaiDangDoDungVanPhong_DTO();
            BaiDangEntities baiDang = await baiDangHelper.GetPostByID(ID);
            BaiDangDoDungVanPhongEntities detailBaiDang = baiDangDoDungVanPhongHelper.GetPostByID((int)baiDang.IdBaiDangChiTiet);
            List<HinhAnhBaiDangEntities> hinhAnhBaiDang = await hinhAnhBaiDangHelper.getHinhAnhBaiDangByIDPost(ID);
            result = _mapper.Map<BaiDangDoDungVanPhong_DTO>(detailBaiDang);
            result.IdBaiDang = baiDang.IdBaiDang;
            result.IdBaiDangChiTiet = baiDang.IdBaiDangChiTiet;
            result.IdDanhMucCha = baiDang.IdDanhMucCha;
            result.IdDanhMucCon = baiDang.IdDanhMucCon;
            result.TieuDe = baiDang.TieuDe;
            result.Mota = baiDang.Mota;
            result.ThanhPho = baiDang.ThanhPho;
            result.QuanHuyen = baiDang.QuanHuyen;
            result.PhuongXa = baiDang.PhuongXa;
            result.DiaChiCuThe = result.DiaChiCuThe == null ? null : result.DiaChiCuThe;
            result.isReviewed = baiDang.isReviewed;
            result.Gia = baiDang.Gia;
            result.CaNhan = baiDang.CaNhan;
            result.hinhAnh_BaiDangs = new List<HinhAnh_BaiDangDTO>();

            foreach (var item in hinhAnhBaiDang)
            {
                HinhAnh_BaiDangDTO temp = new HinhAnh_BaiDangDTO();
                temp.type = (item.VideoType == true ? "video" : "png");
                temp.id = item.IdMediaCloud;
                result.hinhAnh_BaiDangs.Add(temp);
            }
            return result;
        }
        #endregion
        #endregion
        #endregion
    }


}
