using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API_Web_1.Models;

namespace API_Web_1.Controllers
{
    public class SuaNVController : ApiController
    {
        CSDLModel db = new CSDLModel();
        [HttpPut]
        public bool suaNV([FromBody] NV nv)
        {
            try
            {
                NV sv = db.NV.SingleOrDefault(x => x.MNV == nv.MNV);
                if (sv != null)
                {
                    sv.TenNV = nv.TenNV;
                    sv.HSLuong = nv.HSLuong;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi o day: " + ex.Message);
                return false;
            }
        }
    }
}
