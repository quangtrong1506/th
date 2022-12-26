using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using API_Web_1.Models;

namespace API_Web_1.Controllers
{
    public class ThemNVController : ApiController
    {
        CSDLModel db = new CSDLModel();
        [HttpPost]
        public bool themSV([FromBody] NV nv)
        {
            try
            {
                db.NV.Add(nv);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi o day: " + ex.Message);
                return false;
            }
        }
    }
}