using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo_WebAPI.Models
{
    public class ThanhVienNhom
    {
        public string MSSV { get; set; }
        public string hoTen { get; set; }
        public string nhiemVu { get; set; }
        public string danhGia { get; set; }
        public ThanhVienNhom()
        {

        }
        public ThanhVienNhom(string mssv, string hoten, string nhiemvu, string danhgia)
        {
            this.MSSV = mssv;
            this.hoTen = hoten;
            this.nhiemVu = nhiemvu;
            this.danhGia = danhgia;
        }
    }
}