using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Demo_WebAPI.Models;

namespace Demo_WebAPI.Controllers
{
    public class ThongTinNhomController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IEnumerable<ThanhVienNhom> Get()
        {
            string nhiemVuHao = "";
            string nhiemVuVuong = "";
            string nhiemVuVinh = "";
            string nhiemVuThanh = "";
            string nhiemVuQuynh = "";
            ThanhVienNhom tv1 = new ThanhVienNhom("", "Hào", nhiemVuHao, "100%");
            ThanhVienNhom tv2 = new ThanhVienNhom("", "Quỳnh", nhiemVuVuong, "100%");
            ThanhVienNhom tv3 = new ThanhVienNhom("", "Vĩnh", nhiemVuVinh, "100%");
            ThanhVienNhom tv4 = new ThanhVienNhom("", "Thành", nhiemVuThanh, "100%");
            ThanhVienNhom tv5 = new ThanhVienNhom("", "Vương", nhiemVuQuynh, "100%");
            List<ThanhVienNhom> listThanhVien = new List<ThanhVienNhom>();
            listThanhVien.Add(tv1);
            listThanhVien.Add(tv2);
            listThanhVien.Add(tv3);
            listThanhVien.Add(tv4);
            listThanhVien.Add(tv5);
            return listThanhVien.ToList();
        }
    }
}
