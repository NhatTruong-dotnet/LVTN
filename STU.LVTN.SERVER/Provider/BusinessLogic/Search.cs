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
                post.NgayTao = entity.CreatedDate.ToString();
                post.ThanhPho = entity.ThanhPho;
                post.TieuDe = entity.TieuDe;
                post.IDBaiDang = entity.IdBaiDang;
                string idHinhAnh = _context.HinhAnhBaiDangs.Where(item => item.IdSanPham == entity.IdBaiDang && item.VideoType == false).First().IdMediaCloud;
                post.IDHinhAnh = idHinhAnh;
                result.Add(post);
            }
            return result;
        }
        public List<BaiDangHomePageDTO> Filter(int idDanhMucCha, int idDanhMucCon, string? queryString)
        {
            List<BaiDangHomePageDTO> result = new List<BaiDangHomePageDTO>();
            List<BaiDangEntities> source = new List<BaiDangEntities>();
            List<BaiDangEntities> filter = new List<BaiDangEntities>();
            string[] queryParams = queryString == "null" ? Array.Empty<string>() : queryString.Split(';');
            queryParams = queryParams.Where(item => item != "").ToArray();
            source = _context.BaiDangs.Where(baiDang => baiDang.AnTin == false && baiDang.TrangThai == true && baiDang.IdDanhMucCha == idDanhMucCha).ToList();
            filter = _context.BaiDangs.Where(baiDang => baiDang.AnTin == false && baiDang.TrangThai == true && baiDang.IdDanhMucCha == idDanhMucCha).ToList();
            if (queryParams.Length > 0)
            {
                filter = new List<BaiDangEntities>();
                foreach (var item in queryParams)
                {
                    bool queryLocation = false;
                    foreach (var baiDang in source)
                    {
                        if (baiDang.ThanhPho.Contains(item)
                            || baiDang.QuanHuyen.Contains(item)
                            || baiDang.PhuongXa.Contains(item))
                            if (!filter.Contains(baiDang))
                            {
                                filter.Add(baiDang);
                                queryLocation = true;
                            }
                    }
                    if (queryLocation)
                    {
                        int indexToRemove = Array.IndexOf(queryParams, item);
                        queryParams = queryParams.Where((val, idx) => idx != indexToRemove).ToArray();
                    }
                }
            }
            if (idDanhMucCon != -1)
            {
                if (queryParams.Length > 0)
                {
                    source = source.Where(baiDang => baiDang.IdDanhMucCon == idDanhMucCon).ToList();

                    switch (idDanhMucCon)
                    {
                        case 13:
                            foreach (var item in queryParams)
                            {
                                foreach (var baiDangEntities in source)
                                {
                                    BaiDangBatDongSanEntities baiDangBatDongSanDetail = _context.BaiDangBatDongSans.Where(baiDangDetail =>
                                        baiDangDetail.IdBaiDang == baiDangEntities.IdBaiDangChiTiet).First();
                                    if (item == "Đã bàn giao" || item == "Chưa bàn giao")
                                    {
                                        if (baiDangBatDongSanDetail.CcChuaBanGiao == (item == "Đã bàn giao" ? true : false))
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                    }
                                    else
                                    {
                                        int number = 0;
                                        Int32.TryParse(item, out number);
                                        if (baiDangBatDongSanDetail.CcMaCan != null && (baiDangBatDongSanDetail.CcMaCan.Contains(item))
                                            || (baiDangBatDongSanDetail.CcBlock != null && baiDangBatDongSanDetail.CcBlock.Contains(item))
                                            || (baiDangBatDongSanDetail.CcTangSo != null && baiDangBatDongSanDetail.CcTangSo.Contains(item))
                                            || baiDangBatDongSanDetail.CcLoaiHinh.Contains(item)
                                            || baiDangBatDongSanDetail.CcSoPhongNgu == number
                                            || (baiDangBatDongSanDetail.CcBanCong != null && baiDangBatDongSanDetail.CcBanCong.Contains(item))
                                            || (baiDangBatDongSanDetail.CcGiayToPhapLy != null && baiDangBatDongSanDetail.CcGiayToPhapLy.Contains(item))
                                            || (baiDangBatDongSanDetail.CcHuongCuaChinh != null && baiDangBatDongSanDetail.CcHuongCuaChinh.Contains(item))
                                            || (baiDangBatDongSanDetail.CcTinhTrangNoiThat != null && baiDangBatDongSanDetail.CcTinhTrangNoiThat.Contains(item)))
                                        {
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                        }
                                    }

                                }

                            }
                            break;
                        case 14:
                            foreach (var item in queryParams)
                            {
                                foreach (var baiDangEntities in source)
                                {
                                    BaiDangBatDongSanEntities baiDangBatDongSanDetail = _context.BaiDangBatDongSans.Where(baiDangDetail =>
                                        baiDangDetail.IdBaiDang == baiDangEntities.IdBaiDangChiTiet).First();
                                    if (item == "Hẻm xe hơi" && baiDangBatDongSanDetail.NhaOHemXeHoi != null)
                                    {
                                        if (baiDangBatDongSanDetail.NhaOHemXeHoi == (item == "Hẻm xe hơi" ? true : false))
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                    }
                                    else if (item == "Nở hậu" && baiDangBatDongSanDetail.NhaONoHau != null)
                                    {
                                        if (baiDangBatDongSanDetail.NhaONoHau == (item == "Nở hậu" ? true : false))
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                    }
                                    else
                                    {
                                        int number = 0;
                                        Int32.TryParse(item, out number);
                                        if (baiDangBatDongSanDetail.NhaOLoaiHinh.Contains(item)
                                            || (baiDangBatDongSanDetail.NhaOGiayToPhapLy != null && baiDangBatDongSanDetail.NhaOGiayToPhapLy.Contains(item))
                                            || baiDangBatDongSanDetail.NhaOSoPhongNgu == number
                                            || (baiDangBatDongSanDetail.NhaOSoPhongVeSinh != null && baiDangBatDongSanDetail.NhaOSoPhongVeSinh == number)
                                            || (baiDangBatDongSanDetail.NhaOTongSoTang != null && baiDangBatDongSanDetail.NhaOTongSoTang == number)
                                            || (baiDangBatDongSanDetail.NhaOChieuDai != null &&
                                                    (baiDangBatDongSanDetail.NhaOChieuDai < number + 1 && baiDangBatDongSanDetail.NhaOChieuDai > number - 1))
                                            || (baiDangBatDongSanDetail.NhaOChieuNgang != null &&
                                                    (baiDangBatDongSanDetail.NhaOChieuNgang < number + 1 && baiDangBatDongSanDetail.NhaOChieuNgang > number - 1))
                                          )
                                        {
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                        }
                                    }

                                }

                            }
                            break;
                        case 15:
                            foreach (var item in queryParams)
                            {
                                foreach (var baiDangEntities in source)
                                {
                                    BaiDangBatDongSanEntities baiDangBatDongSanDetail = _context.BaiDangBatDongSans.Where(baiDangDetail =>
                                        baiDangDetail.IdBaiDang == baiDangEntities.IdBaiDangChiTiet).First();
                                    if (item == "Hẻm xe hơi" && baiDangBatDongSanDetail.DatHemXeHoi != null)
                                    {
                                        if (baiDangBatDongSanDetail.DatHemXeHoi == (item == "Hẻm xe hơi" ? true : false))
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                    }
                                    else if (item == "Nở hậu" && baiDangBatDongSanDetail.DatNoHau != null)
                                    {
                                        if (baiDangBatDongSanDetail.DatNoHau == (item == "Nở hậu" ? true : false))
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                    }
                                    else if (item == "Mặt tiền" && baiDangBatDongSanDetail.DatMatTien != null)
                                    {
                                        if (baiDangBatDongSanDetail.DatMatTien == (item == "Mặt tiền" ? true : false))
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                    }
                                    else
                                    {
                                        int number = 0;
                                        Int32.TryParse(item, out number);
                                        if (baiDangBatDongSanDetail.DatLoaiHinhDat.Contains(item)
                                            || (baiDangBatDongSanDetail.DatHuongDat != null && baiDangBatDongSanDetail.DatHuongDat.Contains(item))
                                            || (baiDangBatDongSanDetail.DatChieuDai != null &&
                                                    (baiDangBatDongSanDetail.DatChieuDai < number + 1 && baiDangBatDongSanDetail.DatChieuDai > number - 1))
                                            || (baiDangBatDongSanDetail.DatChieuNgang != null &&
                                                    (baiDangBatDongSanDetail.DatChieuNgang < number + 1 && baiDangBatDongSanDetail.DatChieuNgang > number - 1))
                                            || (baiDangBatDongSanDetail.DatGiayToPhapLy != null && baiDangBatDongSanDetail.DatGiayToPhapLy == item)
                                          )
                                        {
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                        }
                                    }

                                }

                            }
                            break;
                        case 16:
                            foreach (var item in queryParams)
                            {
                                foreach (var baiDangEntities in source)
                                {
                                    BaiDangBatDongSanEntities baiDangBatDongSanDetail = _context.BaiDangBatDongSans.Where(baiDangDetail =>
                                        baiDangDetail.IdBaiDang == baiDangEntities.IdBaiDangChiTiet).First();

                                    int number = 0;
                                    Int32.TryParse(item, out number);
                                    if (baiDangBatDongSanDetail.VanPhongLoaiHinhVanPhong.Contains(item)
                                        || (baiDangBatDongSanDetail.VanPhongHuongCuaChinh != null && baiDangBatDongSanDetail.VanPhongHuongCuaChinh.Contains(item))
                                        || (baiDangBatDongSanDetail.VanPhongGiayToPhapLy != null && baiDangBatDongSanDetail.VanPhongGiayToPhapLy == item)
                                      )
                                    {
                                        if (!filter.Contains(baiDangEntities))
                                            filter.Add(baiDangEntities);
                                    }

                                }

                            }
                            break;
                        case 17:
                            foreach (var item in queryParams)
                            {
                                foreach (var baiDangEntities in source)
                                {
                                    BaiDangBatDongSanEntities baiDangBatDongSanDetail = _context.BaiDangBatDongSans.Where(baiDangDetail =>
                                        baiDangDetail.IdBaiDang == baiDangEntities.IdBaiDangChiTiet).First();

                                    int number = 0;
                                    Int32.TryParse(item, out number);
                                    if (
                                        (baiDangBatDongSanDetail.PhongTroSoTienCoc != null && baiDangBatDongSanDetail.PhongTroSoTienCoc == number)
                                        || (baiDangBatDongSanDetail.PhongTroTinhTrangNoiThat != null && baiDangBatDongSanDetail.PhongTroTinhTrangNoiThat == item)
                                      )
                                    {
                                        if (!filter.Contains(baiDangEntities))
                                            filter.Add(baiDangEntities);
                                    }

                                }

                            }
                            break;
                        case 18:
                            foreach (var item in queryParams)
                            {
                                foreach (var baiDangEntities in source)
                                {
                                    BaiDangXeCoEntities baiDangXeCoDetail = _context.BaiDangXeCos.Where(baiDangDetail =>
                                        baiDangDetail.IdBaiDang == baiDangEntities.IdBaiDangChiTiet).First();
                                    if (item == "Đã sử dụng")
                                    {
                                        if (baiDangXeCoDetail.DaSuDung == (item == "Đã sử dụng" ? true : false))
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                    }
                                    else
                                    {
                                        int number = 0;
                                        Int32.TryParse(item, out number);
                                        if (baiDangXeCoDetail.OtoNhieuLieu == item
                                            || ((baiDangXeCoDetail.SoKmDaDi < number + 150 && baiDangXeCoDetail.SoKmDaDi > number - 150))
                                            || (baiDangXeCoDetail.MauSac != null && baiDangXeCoDetail.MauSac.Contains(item))
                                            || (baiDangXeCoDetail.Xuatxu != null && baiDangXeCoDetail.Xuatxu.Contains(item))
                                            || baiDangXeCoDetail.Nam == item
                                            || baiDangXeCoDetail.HangXe == item
                                            || (baiDangXeCoDetail.OtoKieuDang != null && baiDangXeCoDetail.OtoKieuDang.Contains(item))
                                            || baiDangXeCoDetail.OtoHopSo == item
                                            || (baiDangXeCoDetail.OtoSocho != null && baiDangXeCoDetail.OtoSocho == number)
                                            || (baiDangXeCoDetail.OtoDongXe != null && baiDangXeCoDetail.OtoDongXe.Contains(item))

                                          )
                                        {
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                        }
                                    }

                                }

                            }
                            break;
                        case 19:
                            foreach (var item in queryParams)
                            {
                                foreach (var baiDangEntities in source)
                                {
                                    BaiDangXeCoEntities baiDangXeCoDetail = _context.BaiDangXeCos.Where(baiDangDetail =>
                                        baiDangDetail.IdBaiDang == baiDangEntities.IdBaiDangChiTiet).First();
                                    if (item == "Đã sử dụng")
                                    {
                                        if (baiDangXeCoDetail.DaSuDung == (item == "Đã sử dụng" ? true : false))
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                    }
                                    else
                                    {
                                        int number = 0;
                                        Int32.TryParse(item, out number);
                                        if (baiDangXeCoDetail.OtoNhieuLieu == item
                                            || ((baiDangXeCoDetail.SoKmDaDi < number + 150 && baiDangXeCoDetail.SoKmDaDi > number - 150))
                                            || (baiDangXeCoDetail.MauSac != null && baiDangXeCoDetail.MauSac.Contains(item))
                                            || (baiDangXeCoDetail.Xuatxu != null && baiDangXeCoDetail.Xuatxu.Contains(item))
                                            || baiDangXeCoDetail.Nam == item
                                            || baiDangXeCoDetail.HangXe == item
                                            || (baiDangXeCoDetail.XeMayDungtich != null && baiDangXeCoDetail.XeMayDungtich == item)
                                            || (baiDangXeCoDetail.XeMayDongXe != null && baiDangXeCoDetail.XeMayDongXe.Contains(item))
                                            || (baiDangXeCoDetail.XeMayLoaiXe != null && baiDangXeCoDetail.XeMayLoaiXe.Contains(item))

                                          )
                                        {
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                        }
                                    }

                                }

                            }
                            break;
                        case 20:
                            foreach (var item in queryParams)
                            {
                                foreach (var baiDangEntities in source)
                                {
                                    BaiDangXeCoEntities baiDangXeCoDetail = _context.BaiDangXeCos.Where(baiDangDetail =>
                                        baiDangDetail.IdBaiDang == baiDangEntities.IdBaiDangChiTiet).First();
                                    if (item == "Đã sử dụng")
                                    {
                                        if (baiDangXeCoDetail.DaSuDung == (item == "Đã sử dụng" ? true : false))
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                    }
                                    else
                                    {
                                        int number = 0;
                                        Int32.TryParse(item, out number);
                                        if (
                                            ((baiDangXeCoDetail.SoKmDaDi < number + 150 && baiDangXeCoDetail.SoKmDaDi > number - 150))
                                            || (baiDangXeCoDetail.MauSac != null && baiDangXeCoDetail.MauSac.Contains(item))
                                            || (baiDangXeCoDetail.Xuatxu != null && baiDangXeCoDetail.Xuatxu.Contains(item))
                                            || baiDangXeCoDetail.Nam == item
                                            || baiDangXeCoDetail.HangXe == item
                                            || (baiDangXeCoDetail.XeTaiNhieuLieu != null && baiDangXeCoDetail.XeTaiNhieuLieu == item)
                                            || (baiDangXeCoDetail.XeTaiTrongTai != null && baiDangXeCoDetail.XeTaiTrongTai.Contains(item))
                                            || (baiDangXeCoDetail.XeTaiXuatXu != null && baiDangXeCoDetail.XeTaiXuatXu.Contains(item))

                                          )
                                        {
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                        }
                                    }

                                }

                            }
                            break;
                        case 21:
                            foreach (var item in queryParams)
                            {
                                foreach (var baiDangEntities in source)
                                {
                                    BaiDangXeCoEntities baiDangXeCoDetail = _context.BaiDangXeCos.Where(baiDangDetail =>
                                        baiDangDetail.IdBaiDang == baiDangEntities.IdBaiDangChiTiet).First();
                                    if (item == "Đã sử dụng")
                                    {
                                        if (baiDangXeCoDetail.DaSuDung == (item == "Đã sử dụng" ? true : false))
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                    }
                                    else if (item == "Đã sử dụng")
                                    {
                                        if (baiDangXeCoDetail.XeDienDaSuDung == (item == "Đã sử dụng" ? true : false))
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                    }
                                    else
                                    {
                                        int number = 0;
                                        Int32.TryParse(item, out number);
                                        if (

                                            (baiDangXeCoDetail.MauSac != null && baiDangXeCoDetail.MauSac.Contains(item))
                                            || (baiDangXeCoDetail.Xuatxu != null && baiDangXeCoDetail.Xuatxu.Contains(item))
                                            || baiDangXeCoDetail.HangXe == item
                                            || (baiDangXeCoDetail.XeDienBaoHanh != null && baiDangXeCoDetail.XeDienBaoHanh == item)
                                            || (baiDangXeCoDetail.XeDienDongCo != null && baiDangXeCoDetail.XeDienDongCo.Contains(item))
                                            || (baiDangXeCoDetail.XeDienLoaiXe != null && baiDangXeCoDetail.XeDienLoaiXe.Contains(item))

                                          )
                                        {
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                        }
                                    }

                                }

                            }
                            break;
                        case 22:
                            foreach (var item in queryParams)
                            {
                                foreach (var baiDangEntities in source)
                                {
                                    BaiDangXeCoEntities baiDangXeCoDetail = _context.BaiDangXeCos.Where(baiDangDetail =>
                                        baiDangDetail.IdBaiDang == baiDangEntities.IdBaiDangChiTiet).First();
                                    if (item == "Đã sử dụng")
                                    {
                                        if (baiDangXeCoDetail.DaSuDung == (item == "Đã sử dụng" ? true : false))
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                    }
                                    else if (item == "Đã sử dụng")
                                    {
                                        if (baiDangXeCoDetail.XeDapDaSuDung == (item == "Đã sử dụng" ? true : false))
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                    }
                                    else
                                    {
                                        int number = 0;
                                        Int32.TryParse(item, out number);
                                        if (
                                            (baiDangXeCoDetail.MauSac != null && baiDangXeCoDetail.MauSac.Contains(item))
                                            || (baiDangXeCoDetail.Xuatxu != null && baiDangXeCoDetail.Xuatxu.Contains(item))
                                            || baiDangXeCoDetail.HangXe == item
                                            || (baiDangXeCoDetail.XeDapBaoHang != null && baiDangXeCoDetail.XeDapBaoHang == item)
                                            || (baiDangXeCoDetail.XeDapChatLuongKhung != null && baiDangXeCoDetail.XeDapChatLuongKhung.Contains(item))
                                            || (baiDangXeCoDetail.XeDapKichThuocKhung != null && baiDangXeCoDetail.XeDapKichThuocKhung.Contains(item))
                                            || (baiDangXeCoDetail.XeDapLoaiXe != null && baiDangXeCoDetail.XeDapLoaiXe.Contains(item))

                                          )
                                        {
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                        }
                                    }

                                }

                            }
                            break;
                        case 23:
                            foreach (var item in queryParams)
                            {
                                foreach (var baiDangEntities in source)
                                {
                                    BaiDangXeCoEntities baiDangXeCoDetail = _context.BaiDangXeCos.Where(baiDangDetail =>
                                        baiDangDetail.IdBaiDang == baiDangEntities.IdBaiDangChiTiet).First();
                                    if (item == "Đã sử dụng")
                                    {
                                        if (baiDangXeCoDetail.DaSuDung == (item == "Đã sử dụng" ? true : false))
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                    }
                                    else
                                    {
                                        int number = 0;
                                        Int32.TryParse(item, out number);
                                        if (
                                            (baiDangXeCoDetail.PhuongTienKhacLoaiXeChuyenDung != null && baiDangXeCoDetail.PhuongTienKhacLoaiXeChuyenDung.Contains(item))
                                            || (baiDangXeCoDetail.PhuongTienKhacNhienLieu != null && baiDangXeCoDetail.PhuongTienKhacNhienLieu.Contains(item))
                                            || (baiDangXeCoDetail.PhuongTienKhacSoChoXeKhachXeBuyt != null && baiDangXeCoDetail.PhuongTienKhacSoChoXeKhachXeBuyt == item)
                                          )
                                        {
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                        }
                                    }

                                }

                            }
                            break;
                        case 24:
                            foreach (var item in queryParams)
                            {
                                foreach (var baiDangEntities in source)
                                {
                                    BaiDangXeCoEntities baiDangXeCoDetail = _context.BaiDangXeCos.Where(baiDangDetail =>
                                        baiDangDetail.IdBaiDang == baiDangEntities.IdBaiDangChiTiet).First();
                                    if (item == "Đã sử dụng")
                                    {
                                        if (baiDangXeCoDetail.DaSuDung == (item == "Đã sử dụng" ? true : false))
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                    }
                                    else
                                    {
                                        int number = 0;
                                        Int32.TryParse(item, out number);
                                        if (
                                            (baiDangXeCoDetail.PhuTungXeLoaiPhuTung != null && baiDangXeCoDetail.PhuTungXeLoaiPhuTung.Contains(item))
                                          )
                                        {
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                        }
                                    }

                                }

                            }
                            break;
                        case 25:
                            foreach (var item in queryParams)
                            {
                                foreach (var baiDangEntities in source)
                                {
                                    BaiDangDoDienTuEntities baiDangDoDienTuDetail = _context.BaiDangDoDienTus.Where(baiDangDetail =>
                                        baiDangDetail.IdBaiDang == baiDangEntities.IdBaiDangChiTiet).First();
                                    if (item == "Còn bảo hành")
                                    {
                                        if (baiDangDoDienTuDetail.BaoHanh == (item == "Còn bảo hành" ? true : false))
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                    }
                                    else
                                    {
                                        int number = 0;
                                        Int32.TryParse(item, out number);
                                        if (
                                            baiDangDoDienTuDetail.DienThoaiHang == item
                                            || baiDangDoDienTuDetail.DienThoaiDongMay == item
                                            || baiDangDoDienTuDetail.TinhTrang == item
                                            || (baiDangDoDienTuDetail.DienThoaiDungLuong != null && baiDangDoDienTuDetail.DienThoaiDungLuong.Contains(item))
                                            || (baiDangDoDienTuDetail.DienThoaiMauSac != null && baiDangDoDienTuDetail.DienThoaiMauSac.Contains(item))
                                          )
                                        {
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                        }
                                    }

                                }

                            }
                            break;
                        case 26:
                            foreach (var item in queryParams)
                            {
                                foreach (var baiDangEntities in source)
                                {
                                    BaiDangDoDienTuEntities baiDangDoDienTuDetail = _context.BaiDangDoDienTus.Where(baiDangDetail =>
                                        baiDangDetail.IdBaiDang == baiDangEntities.IdBaiDangChiTiet).First();
                                    if (item == "Còn bảo hành")
                                    {
                                        if (baiDangDoDienTuDetail.BaoHanh == (item == "Còn bảo hành" ? true : false))
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                    }
                                    else if (item == "Quốc tế")
                                    {
                                        if (baiDangDoDienTuDetail.MayTinhBangQuocTe == (item == "Quốc tế" ? true : false))
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                    }
                                    else if (item == "Có")
                                    {
                                        if (baiDangDoDienTuDetail.MayTinhBang4g == (item == "Có" ? true : false))
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                    }
                                    else
                                    {
                                        int number = 0;
                                        Int32.TryParse(item, out number);
                                        if (
                                            baiDangDoDienTuDetail.MayTinhBangHang == item
                                            || baiDangDoDienTuDetail.MayTinhBangDongMay == item
                                            || baiDangDoDienTuDetail.TinhTrang == item
                                            || (baiDangDoDienTuDetail.MayTinhBangKichCoManHinh != null && baiDangDoDienTuDetail.MayTinhBangKichCoManHinh.Contains(item))
                                            || (baiDangDoDienTuDetail.MayTinhBangDungLuong != null && baiDangDoDienTuDetail.MayTinhBangDungLuong.Contains(item))
                                          )
                                        {
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                        }
                                    }

                                }

                            }
                            break;
                        case 27:
                            foreach (var item in queryParams)
                            {
                                foreach (var baiDangEntities in source)
                                {
                                    BaiDangDoDienTuEntities baiDangDoDienTuDetail = _context.BaiDangDoDienTus.Where(baiDangDetail =>
                                        baiDangDetail.IdBaiDang == baiDangEntities.IdBaiDangChiTiet).First();
                                    if (item == "Còn bảo hành")
                                    {
                                        if (baiDangDoDienTuDetail.BaoHanh == (item == "Còn bảo hành" ? true : false))
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                    }
                                    else if (item == "HDD")
                                    {
                                        if (baiDangDoDienTuDetail.LaptopHdd == (item == "HDD" ? true : false))
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                    }
                                    else
                                    {
                                        int number = 0;
                                        Int32.TryParse(item, out number);
                                        if (
                                            baiDangDoDienTuDetail.LaptopHang == item
                                            || baiDangDoDienTuDetail.LaptopDongMay == item
                                            || baiDangDoDienTuDetail.TinhTrang == item
                                            || (baiDangDoDienTuDetail.LaptopBoViXuly != null && baiDangDoDienTuDetail.LaptopBoViXuly.Contains(item))
                                            || (baiDangDoDienTuDetail.LaptopRam != null && baiDangDoDienTuDetail.LaptopRam.Contains(item))
                                            || (baiDangDoDienTuDetail.LaptopOcung != null && baiDangDoDienTuDetail.LaptopOcung.Contains(item))
                                            || (baiDangDoDienTuDetail.LaptopCardManHinh != null && baiDangDoDienTuDetail.LaptopCardManHinh.Contains(item))
                                            || (baiDangDoDienTuDetail.LaptopKichCoManHinh != null && baiDangDoDienTuDetail.LaptopKichCoManHinh.Contains(item))
                                          )
                                        {
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                        }
                                    }

                                }

                            }
                            break;
                        case 28:
                            foreach (var item in queryParams)
                            {
                                foreach (var baiDangEntities in source)
                                {
                                    BaiDangDoDienTuEntities baiDangDoDienTuDetail = _context.BaiDangDoDienTus.Where(baiDangDetail =>
                                        baiDangDetail.IdBaiDang == baiDangEntities.IdBaiDangChiTiet).First();
                                    if (item == "Còn bảo hành")
                                    {
                                        if (baiDangDoDienTuDetail.BaoHanh == (item == "Còn bảo hành" ? true : false))
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                    }
                                    else if (item == "HDD")
                                    {
                                        if (baiDangDoDienTuDetail.MayTinhDeBanHdd == (item == "HDD" ? true : false))
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                    }
                                    else
                                    {
                                        int number = 0;
                                        Int32.TryParse(item, out number);
                                        if (
                                            baiDangDoDienTuDetail.TinhTrang == item
                                            || (baiDangDoDienTuDetail.MayTinhDeBanBoViXuly != null && baiDangDoDienTuDetail.MayTinhDeBanBoViXuly.Contains(item))
                                            || (baiDangDoDienTuDetail.MayTinhDeBanRam != null && baiDangDoDienTuDetail.MayTinhDeBanRam.Contains(item))
                                            || (baiDangDoDienTuDetail.MayTinhDeBanOcung != null && baiDangDoDienTuDetail.MayTinhDeBanOcung.Contains(item))
                                            || (baiDangDoDienTuDetail.MayTinhDeBanCardManHinh != null && baiDangDoDienTuDetail.MayTinhDeBanCardManHinh.Contains(item))
                                            || (baiDangDoDienTuDetail.MayTinhDeBanKichCoManHinh != null && baiDangDoDienTuDetail.MayTinhDeBanKichCoManHinh.Contains(item))
                                          )
                                        {
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                        }
                                    }

                                }

                            }
                            break;
                        case 29:
                            foreach (var item in queryParams)
                            {
                                foreach (var baiDangEntities in source)
                                {
                                    BaiDangDoDienTuEntities baiDangDoDienTuDetail = _context.BaiDangDoDienTus.Where(baiDangDetail =>
                                        baiDangDetail.IdBaiDang == baiDangEntities.IdBaiDangChiTiet).First();
                                    if (item == "Còn bảo hành")
                                    {
                                        if (baiDangDoDienTuDetail.BaoHanh == (item == "Còn bảo hành" ? true : false))
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                    }
                                    
                                    else
                                    {
                                        int number = 0;
                                        Int32.TryParse(item, out number);
                                        if (
                                            baiDangDoDienTuDetail.TinhTrang == item
                                            || baiDangDoDienTuDetail.MayAnhTinhTrang == item
                                            || (baiDangDoDienTuDetail.MayAnhThietBi != null && baiDangDoDienTuDetail.MayAnhThietBi.Contains(item))
                                            || (baiDangDoDienTuDetail.ThietBiDongMay != null && baiDangDoDienTuDetail.ThietBiDongMay.Contains(item))
                                          )
                                        {
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                        }
                                    }

                                }

                            }
                            break;
                        case 30:
                            foreach (var item in queryParams)
                            {
                                foreach (var baiDangEntities in source)
                                {
                                    BaiDangDoDienTuEntities baiDangDoDienTuDetail = _context.BaiDangDoDienTus.Where(baiDangDetail =>
                                        baiDangDetail.IdBaiDang == baiDangEntities.IdBaiDangChiTiet).First();
                                    if (item == "Còn bảo hành")
                                    {
                                        if (baiDangDoDienTuDetail.BaoHanh == (item == "Còn bảo hành" ? true : false))
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                    }

                                    else
                                    {
                                        int number = 0;
                                        Int32.TryParse(item, out number);
                                        if (
                                            baiDangDoDienTuDetail.TiviHang == item
                                            || (baiDangDoDienTuDetail.TiviTinhTrang != null && baiDangDoDienTuDetail.TiviTinhTrang.Contains(item))
                                            || (baiDangDoDienTuDetail.TinhTrang != null && baiDangDoDienTuDetail.TinhTrang.Contains(item))
                                            || (baiDangDoDienTuDetail.TiviThietBi != null && baiDangDoDienTuDetail.TiviThietBi.Contains(item))
                                          )
                                        {
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                        }
                                    }

                                }

                            }
                            break;
                        case 31:
                            foreach (var item in queryParams)
                            {
                                foreach (var baiDangEntities in source)
                                {
                                    BaiDangDoDienTuEntities baiDangDoDienTuDetail = _context.BaiDangDoDienTus.Where(baiDangDetail =>
                                        baiDangDetail.IdBaiDang == baiDangEntities.IdBaiDangChiTiet).First();
                                    if (item == "Còn bảo hành")
                                    {
                                        if (baiDangDoDienTuDetail.BaoHanh == (item == "Còn bảo hành" ? true : false))
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                    }

                                    else
                                    {
                                        int number = 0;
                                        Int32.TryParse(item, out number);
                                        if (
                                            baiDangDoDienTuDetail.ThietBiDeoThongMinhHang == item
                                            || (baiDangDoDienTuDetail.ThietBiDeoThongMinhThietBi != null && baiDangDoDienTuDetail.ThietBiDeoThongMinhThietBi.Contains(item))
                                            || (baiDangDoDienTuDetail.TinhTrang != null && baiDangDoDienTuDetail.TinhTrang.Contains(item))
                                            || (baiDangDoDienTuDetail.ThietBiDeoThongMinhTinhTrang != null && baiDangDoDienTuDetail.ThietBiDeoThongMinhTinhTrang.Contains(item))
                                          )
                                        {
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                        }
                                    }

                                }

                            }
                            break;
                        case 32:
                            foreach (var item in queryParams)
                            {
                                foreach (var baiDangEntities in source)
                                {
                                    BaiDangDoDienTuEntities baiDangDoDienTuDetail = _context.BaiDangDoDienTus.Where(baiDangDetail =>
                                        baiDangDetail.IdBaiDang == baiDangEntities.IdBaiDangChiTiet).First();
                                    if (item == "Còn bảo hành")
                                    {
                                        if (baiDangDoDienTuDetail.BaoHanh == (item == "Còn bảo hành" ? true : false))
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                    }

                                    else
                                    {
                                        int number = 0;
                                        Int32.TryParse(item, out number);
                                        if (
                                            baiDangDoDienTuDetail.PhuKienLoaiPhuKien == item
                                            || (baiDangDoDienTuDetail.PhuKienThietBi != null && baiDangDoDienTuDetail.PhuKienThietBi.Contains(item))
                                            || (baiDangDoDienTuDetail.TinhTrang != null && baiDangDoDienTuDetail.TinhTrang.Contains(item))
                                            || (baiDangDoDienTuDetail.PhuKienTinhTrang != null && baiDangDoDienTuDetail.PhuKienTinhTrang.Contains(item))
                                          )
                                        {
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                        }
                                    }

                                }

                            }
                            break;
                        case 33:
                            foreach (var item in queryParams)
                            {
                                foreach (var baiDangEntities in source)
                                {
                                    BaiDangDoDienTuEntities baiDangDoDienTuDetail = _context.BaiDangDoDienTus.Where(baiDangDetail =>
                                        baiDangDetail.IdBaiDang == baiDangEntities.IdBaiDangChiTiet).First();
                                    if (item == "Còn bảo hành")
                                    {
                                        if (baiDangDoDienTuDetail.BaoHanh == (item == "Còn bảo hành" ? true : false))
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                    }

                                    else
                                    {
                                        int number = 0;
                                        Int32.TryParse(item, out number);
                                        if (
                                            baiDangDoDienTuDetail.LinhKienLoaiPhuKien == item
                                            || (baiDangDoDienTuDetail.LinhKienThietBi != null && baiDangDoDienTuDetail.LinhKienThietBi.Contains(item))
                                            || (baiDangDoDienTuDetail.TinhTrang != null && baiDangDoDienTuDetail.TinhTrang.Contains(item))
                                            || (baiDangDoDienTuDetail.LinhKienTinhTrang != null && baiDangDoDienTuDetail.LinhKienTinhTrang.Contains(item))
                                          )
                                        {
                                            if (!filter.Contains(baiDangEntities))
                                                filter.Add(baiDangEntities);
                                        }
                                    }

                                }

                            }
                            break;
                    }
                }
                else
                {
                    filter = source.Where(baiDang => baiDang.IdDanhMucCon == idDanhMucCon).ToList();
                }
            }

            foreach (BaiDangEntities entity in filter)
            {
                BaiDangHomePageDTO post = new BaiDangHomePageDTO();
                post.Gia = entity.Gia;
                post.TieuDe = entity.TieuDe;
                post.NgayTao = entity.CreatedDate.ToString();
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
