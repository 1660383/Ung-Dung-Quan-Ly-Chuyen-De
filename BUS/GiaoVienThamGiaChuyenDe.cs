﻿using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class GiaoVienThamGiaChuyenDe
    {
        /// <summary>
        /// Lấy danh sách chuyên đề mà giáo viên(Đang đang nhập) tham gia bằng mã giáo viên được lưu trong BUS Setting.
        /// </summary>
        /// <returns>Danh sách chuyên đề mà giáo viên tham gia</returns>
        public static List<DTO.GiaoVienThamGiaChuyenDe> LayDsChuyenDeGiaoVienThamGia()
        {
            DTO.GiaoVien gv = BUS.Users.LayThongTinNguoiDung() as DTO.GiaoVien;           
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM GIAOVIEN_THAMGIA_CHUYENDE WHERE MAGV = '{0}'", gv.MaGV);
            DAO.DataProvider.Connect();
            DataTable dt = DAO.DataProvider.GetReader(CommandType.StoredProcedure, "LayDsChuyenDeGiaoVienThamGia",
                new System.Data.SqlClient.SqlParameter { ParameterName = "@MaGV", Value = gv.MaGV, Direction = ParameterDirection.Input });
                //DAO.DataProvider.Select(CommandType.Text, query.ToString());
            DAO.DataProvider.Disconnect();
            List<DTO.GiaoVienThamGiaChuyenDe> dsChuyenDe = null;
            if (dt.Rows.Count > 0)
            {
                dsChuyenDe = new List<DTO.GiaoVienThamGiaChuyenDe>();
                foreach (DataRow row in dt.Rows)
                {
                    DTO.GiaoVienThamGiaChuyenDe chuyenDe = new DTO.GiaoVienThamGiaChuyenDe()
                    {
                        MaChuyenDeGiao = row[0].ToString(),
                        MaGiaoVienThamGia = row[1].ToString().Trim(),
                        MaChuyenDe = row[2].ToString().Trim(),
                        NamHoc = int.Parse(row[3].ToString().Trim()),
                        MaHocKy = row[4].ToString().Trim()
                    };
                    dsChuyenDe.Add(chuyenDe);
                }
            }
            return dsChuyenDe;
        }

        /// <summary>
        /// Lấy 1 chuyên đề mà giáo viên tham dựa vào mã chuyên đề
        /// </summary>
        /// <param name="maChuyenDe"></param>
        /// <returns>Trả về null nếu không tim thấy ngược lại trả về DTO_ChuyenDeGiaoVienThamGia</returns>
        public static DTO.GiaoVienThamGiaChuyenDe LayChuyenDeGiaoVienThamGia(string maChuyenDe)
        {
            DTO.GiaoVien gv = BUS.Users.LayThongTinNguoiDung() as DTO.GiaoVien;
            DTO.GiaoVienThamGiaChuyenDe chuyenDe = null;
            if (gv != null)
            {
                StringBuilder query = new StringBuilder();
                query.AppendFormat("SELECT * FROM GIAOVIEN_THAMGIA_CHUYENDE WHERE MAGV = '{0}' AND MACD = '{1}'", gv.MaGV, maChuyenDe);
                DAO.DataProvider.Connect();
                DataTable dt = DAO.DataProvider.GetReader(CommandType.StoredProcedure, "LayChuyenDeGiaoVienThamGia",
                new System.Data.SqlClient.SqlParameter { ParameterName = "@MaGV", Value = gv.MaGV, Direction = ParameterDirection.Input },
                new System.Data.SqlClient.SqlParameter { ParameterName = "@maChuyenDe", Value = maChuyenDe, Direction = ParameterDirection.Input });
                //DAO.DataProvider.Select(CommandType.Text, query.ToString());
                DAO.DataProvider.Disconnect();               
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        chuyenDe = new DTO.GiaoVienThamGiaChuyenDe()
                        {
                            MaChuyenDeGiao = row[0].ToString(),
                            MaGiaoVienThamGia = row[1].ToString().Trim(),
                            MaChuyenDe = row[2].ToString().Trim(),
                            NamHoc = int.Parse(row[3].ToString().Trim()),
                            MaHocKy = row[4].ToString().Trim()
                        };
                    }
                }
            }
            return chuyenDe;
        }
    }
}
