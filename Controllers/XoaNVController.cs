using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using API_Web_1.Models;

namespace API_Web_1.Controllers
{
    public class XoaNVController : ApiController
    {
        CSDLModel db = new CSDLModel();

        // GET: DanhSach
        [HttpDelete]
        public bool XoaNV(String maNV)
        {
            NV sv = db.NV.SingleOrDefault(x => x.MNV == maNV);
            if (sv != null)
            {
                db.NV.Remove(sv);
                db.SaveChanges();
                return true;
            }
            return false;
        }

    }

}
