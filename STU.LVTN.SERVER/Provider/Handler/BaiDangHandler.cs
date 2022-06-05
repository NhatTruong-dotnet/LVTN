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
            baiDangHelper = new BaiDang(_mapper);
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
            postDictionary.Add("gia", post.Gia.ToString());
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
                #endregion
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
    }


}
