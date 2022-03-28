using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cascadingprac.Models;

namespace cascadingprac.Controllers
{
    public class dropdownController : Controller
    {
        //
        // GET: /dropdown/
        usercascadEntities2 ts = new usercascadEntities2();
        public JsonResult GetstateBycountryId(int countryid)
        {
            List<states1> li = new List<states1>();
            var lblstate = ts.states1.Where(x => x.countryid == countryid).ToList();
            userdetail ud = new userdetail();
            ud.states = new SelectList(lblstate, "stateid", "statename");
            return Json(ud.states, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetcityBystateid(int stateid)
        {
            List<city2> li = new List<city2>();
            var lblcity = ts.city2.Where(x => x.stateid == stateid).ToList();
            userdetail us = new userdetail();
            us.cities = new SelectList(lblcity, "cityid", "cityname");
            return Json(us.cities, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public ActionResult Create(userdetail ud)
        {
            List<ddl> ddl = new List<Models.ddl>()
            {
                new ddl
                {
                    id=0,
                    name="Please Select"
                }
            };

            var countrylist = ts.countries.ToList();
            ud.countries = new SelectList(countrylist, "countryid", "countryname");
            var statelist = ts.states1.ToList();
            ud.states = new SelectList(ddl, "id", "name");
            var citylist = ts.city2.ToList();
            ud.cities = new SelectList(ddl, "id", "name");

            try
            {
                var t = ts.empstates.Where(x => x.email == ud.email).SingleOrDefault();
                if (t == null)
                {
                    empstate u = new empstate();
                    u.id = ud.id;
                    u.firstname = ud.firstname;
                    u.lastname = ud.lastname;
                    u.email = ud.email;
                    u.address = ud.address;
                    u.countryid = Convert.ToInt32(ud.countryid);
                    u.stateid = Convert.ToInt32(ud.stateid);
                    u.cityid = Convert.ToInt32(ud.cityid);

                    u.number = ud.number;
                    u.dob = Convert.ToDateTime(ud.dob);
                    u.age = ud.age;
                    ts.empstates.AddObject(u);
                    ts.SaveChanges();
                    bool msg = false;
                    return Json(msg);
                }
                else {
                    bool msg = true;
                    return Json(msg);
                }
                //return RedirectToAction("Index");
            }
            catch
            {
                bool msg = true;
                return Json(msg);

                //return View(ud);
            }
        }



    



    }
}
