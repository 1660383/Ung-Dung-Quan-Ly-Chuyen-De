using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;
namespace BUS
{
    public class KetQua
    {
        public static List<DTO.KetQua> LayDanhSachKetQua()
        {
            List<DTO.KetQua> lkq = new List<DTO.KetQua>();
            DataTable dt;
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM KETQUA");
            DataProvider.Connect();
            dt =
            //DataProvider.GetReader(CommandType.StoredProcedure, "LayDanhSachKetQua",null);
            DataProvider.Select(CommandType.Text, query.ToString());
            DataProvider.Disconnect();
            foreach (DataRow row in dt.Rows)
            {
                DTO.KetQua kq = new DTO.KetQua(row[0].ToString(), row[1].ToString(),(int)row[2], row[3].ToString(), row[4].ToString(),(Decimal)row[5]);
                lkq.Add(kq);
            }
            return lkq;
        }
        public static int SoMonDauCuaSinhVien(string masv)
        {
            DataTable dt;
            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT * FROM KETQUA kq where kq.MASV= '{0}'",masv);
            DataProvider.Connect();
            dt = DataProvider.GetReader(CommandType.StoredProcedure, "SoMonDauCuaSinhVien",
                new System.Data.SqlClient.SqlParameter { ParameterName = "@masv",Direction = ParameterDirection.Input,Value = masv}); 

                //DataProvider.Select(CommandType.Text, query.ToString());
                    DataProvider.Disconnect();
            return dt.Rows.Count;
        }
        //public static List<DTO_KetQua> LayDanhSachKetQuaTheoMaSinhVien(string masv)
        //{
        //    List<DTO_KetQua> lkq = new List<DTO_KetQua>();
        //    DataTable dt;
        //    StringBuilder query = new StringBuilder();
        //    query.AppendFormat("SELECT * FROM KETQUA kq where kq.MASV ='{0}'",masv);
        //    DAO_DataProvider.Connect();
        //    dt = DAO_DataProvider.Select(CommandType.Text, query.ToString());
        //    DAO_DataProvider.Disconnect();

        //    foreach (DataRow row in dt.Rows)
        //    {
        //        DTO_KetQua kq = new DTO_KetQua(row[0].ToString(), row[1].ToString(), (int)row[2], row[3].ToString(), row[4].ToString(), (Decimal)row[5]);
        //        lkq.Add(kq);
        //    }
        //    return lkq;
        //}
        public static DataTable LayDanhSachKetQuaTheoMaSinhVien(string masv)
        {
            List<DTO.KetQua> lkq = new List<DTO.KetQua>();
            DataTable dt;
            StringBuilder query = new StringBuilder();
            
            query.AppendFormat("SELECT (select cd.TENCD from CHUYENDE cd where cd.MACD = kq.MACD) N'Tên  Chuyên Đề',kq.MAHK,kq.Nam,kq.Diem FROM KETQUA kq where kq.MASV ='{0}'", masv);
            DataProvider.Connect();
            dt = DataProvider.GetReader(CommandType.StoredProcedure, "LayDanhSachKetQuaTheoMaSinhVien",
                new System.Data.SqlClient.SqlParameter
                {
                    ParameterName = "@masv",
                    Direction = ParameterDirection.Input,
                    Value = masv
                });
                //DataProvider.Select(CommandType.Text, query.ToString());
            DataProvider.Disconnect();
            return dt;
        }

        public static DataTable LayDanhSachKetQua(string masv, string tensv, string macd, string mahk, string nam)
        {
            List<DTO.KetQua> lkq = new List<DTO.KetQua>();
            DataTable dt;

            DataProvider.Connect();
            dt = DataProvider.GetReader(CommandType.StoredProcedure, "LayDanhSachKetQuaTimKiem",
                new System.Data.SqlClient.SqlParameter
                {
                    ParameterName = "@masv",
                    Direction = ParameterDirection.Input,
                    Value = masv
                },
                new System.Data.SqlClient.SqlParameter
                {
                    ParameterName = "@tensv",
                    Direction = ParameterDirection.Input,
                    Value = tensv
                },
                new System.Data.SqlClient.SqlParameter
                {
                    ParameterName = "@macd",
                    Direction = ParameterDirection.Input,
                    Value = macd
                },
                new System.Data.SqlClient.SqlParameter
                {
                    ParameterName = "@mahk",
                    Direction = ParameterDirection.Input,
                    Value = mahk
                },
                new System.Data.SqlClient.SqlParameter
                {
                    ParameterName = "@nam",
                    Direction = ParameterDirection.Input,
                    Value = nam
                }

                );
            //DataProvider.Select(CommandType.Text, layCauTruyVanChung(masv,tensv,macd,mahk,nam).ToString());
            DataProvider.Disconnect();
            return dt;
        }
        private static StringBuilder layCauTruyVanConbobox(string macd,string mahk,string nam)
        {
            StringBuilder query = new StringBuilder(); 
            if(macd !="" && mahk!="" && nam!="")
            {
                query.AppendFormat("SELECT kq.MASV N'Mã Sinh Viên',(select cd.TENCD from CHUYENDE cd where cd.MACD = kq.MACD) N'Tên  Chuyên Đề',kq.MAHK N'Học Kỳ',kq.Nam N'Năm Học',kq.Diem N'Điểm'  FROM KETQUA kq where kq.MACD = '{0}' and kq.NAM = {1} and kq.MAHK = '{2}' ", macd, nam, mahk);
            }else
            {
                if(macd != "" && mahk!="")
                {
                    query.AppendFormat("SELECT kq.MASV N'Mã Sinh Viên',(select cd.TENCD from CHUYENDE cd where cd.MACD = kq.MACD) N'Tên  Chuyên Đề',kq.MAHK N'Học Kỳ',kq.Nam N'Năm Học',kq.Diem N'Điểm' FROM KETQUA kq where kq.MACD = '{0}' and kq.MAHK = '{1}' ", macd, mahk);
                }else if(macd !="" && nam !="")
                {
                    query.AppendFormat("SELECT kq.MASV N'Mã Sinh Viên',(select cd.TENCD from CHUYENDE cd where cd.MACD = kq.MACD) N'Tên  Chuyên Đề',kq.MAHK N'Học Kỳ',kq.Nam N'Năm Học',kq.Diem N'Điểm' FROM KETQUA kq where kq.MACD = '{0}' and kq.NAM = {1} ", macd, nam);
                }else if(mahk !="" && nam !="")
                {
                    query.AppendFormat("SELECT kq.MASV N'Mã Sinh Viên',(select cd.TENCD from CHUYENDE cd where cd.MACD = kq.MACD) N'Tên  Chuyên Đề',kq.MAHK N'Học Kỳ',kq.Nam N'Năm Học',kq.Diem N'Điểm' FROM KETQUA kq where kq.NAM = {0} and kq.MAHK = '{1}' ", nam, mahk);
                }else
                {
                    if (macd != "")
                    {
                        query.AppendFormat("SELECT kq.MASV N'Mã Sinh Viên',(select cd.TENCD from CHUYENDE cd where cd.MACD = kq.MACD) N'Tên  Chuyên Đề',kq.MAHK N'Học Kỳ',kq.Nam N'Năm Học',kq.Diem N'Điểm' FROM KETQUA kq where kq.MACD = '{0}'", macd);
                    }
                    else if(mahk!="")
                    {
                        query.AppendFormat("SELECT kq.MASV N'Mã Sinh Viên',(select cd.TENCD from CHUYENDE cd where cd.MACD = kq.MACD) N'Tên  Chuyên Đề',kq.MAHK N'Học Kỳ',kq.Nam N'Năm Học',kq.Diem N'Điểm' FROM KETQUA kq where kq.MAHK = '{0}'", mahk);
                    }
                    else if(nam!="")
                    {
                        query.AppendFormat("SELECT kq.MASV N'Mã Sinh Viên',(select cd.TENCD from CHUYENDE cd where cd.MACD = kq.MACD) N'Tên  Chuyên Đề',kq.MAHK N'Học Kỳ',kq.Nam N'Năm Học',kq.Diem N'Điểm' FROM KETQUA kq where kq.NAM = {0}", nam);
                    }
                    else
                    {
                        query.AppendFormat("SELECT kq.MASV N'Mã Sinh Viên',(select cd.TENCD from CHUYENDE cd where cd.MACD = kq.MACD) N'Tên  Chuyên Đề',kq.MAHK N'Học Kỳ',kq.Nam N'Năm Học',kq.Diem N'Điểm' FROM KETQUA kq where 1=1  ");
                    }
                }
            }
            return query;
            
        }
        private static StringBuilder layCauTruyVanChung(string masv,string tensv,string macd, string mahk, string nam)
        {
            StringBuilder query = new StringBuilder();
            if (masv == "" && tensv == "" && macd == "" && mahk == "" && nam == "")
            {
                query.AppendFormat(layCauTruyVanConbobox(macd, mahk, nam) + "and 1>2");
            }
            else
            {
                if (masv != "" && tensv != "")
                {
                    query.AppendFormat(layCauTruyVanConbobox(macd, mahk, nam) + " and kq.MASV = '{0}' and kq.MASV in (select sv.MASV from SINHVIEN sv where sv.TENSV = N'{1}')", masv, tensv);
                }
                else
                {
                    if (masv != "")
                    {
                        query.AppendFormat(layCauTruyVanConbobox(macd, mahk, nam) + " and kq.MASV = '{0}'", masv);
                    }
                    else if (tensv != "")
                    {
                        query.AppendFormat(layCauTruyVanConbobox(macd, mahk, nam) + " and kq.MASV in (select sv.MASV from SINHVIEN sv where sv.TENSV = N'{0}')", tensv);
                        Console.WriteLine(query.ToString());
                    }
                    else
                    {
                        query.AppendFormat(layCauTruyVanConbobox(macd, mahk, nam) + "");
                    }
                }
            }
            Console.WriteLine(query.ToString());
            return query;
        }


    }
}

