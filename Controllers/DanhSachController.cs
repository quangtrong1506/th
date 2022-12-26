using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using API_Web_1.Models;

namespace API_Web_1.Controllers
{
    public class DanhSachController : ApiController
    {
        CSDLModel db = new CSDLModel();

        // GET: DanhSach
        [HttpGet]
        public List<NV> DanhSach()
        {
            return db.NV.ToList();
        }
    }
}