using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cascadingprac.Models;
using System.Data;

namespace cascadingprac.Controllers
{
    public class HomeController : Controller
    {
        usercascadEntities2 ts = new usercascadEntities2();
        //
        // GET: /Home/

        public ActionResult Index()
        {
            DataTable d = new DataTable();
            var db = ts.empstates.ToList();
            List<userdetail> li = new List<userdetail>();
            foreach (var i in db) 
            {
                userdetail ud = new userdetail();
                ud.id = i.id;
                ud.firstname = i.firstname;
                ud.lastname = i.lastname;
                ud.email = i.email;
                ud.address = i.address;
                ud.countryid = ts.countries.Where(x => x.countryid == i.countryid).SingleOrDefault().countryname;
                ud.stateid = ts.states1.Where(x => x.stateid == i.stateid).SingleOrDefault().statename;
                ud.cityid = ts.city2.Where(x => x.cityid== i.cityid).SingleOrDefault().cityname;
                ud.number = i.number;
                ud.dob =i.dob.ToString();
                ud.age = i.age;
                li.Add(ud);
            }
            return View(li);
        }

        //
        // GET: /Home/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Home/Create

        public ActionResult Create()
        {
            List<ddl> ddl = new List<Models.ddl>()
            {
                new ddl
                {
                    id=0,
                    name="Please select"
                }
            };
            userdetail ud = new userdetail();
            var countrylist = ts.countries.ToList();
            ud.countries = new SelectList(countrylist, "countryid", "countryname");

            var statelist = ts.states1.ToList();
            ud.states = new SelectList(ddl, "id", "name");

            var citylist = ts.city2.ToList();
            ud.cities = new SelectList(ddl, "id", "name");
            return View(ud);
        } 

        
         //POST: /Home/Create

        //[HttpPost]
        //public ActionResult Create(userdetail ud)
        //{
        //    List<ddl> ddl = new List<Models.ddl>()
        //    {
        //        new ddl
        //        {
        //            id=0,
        //            name="Please Select"
        //        }
        //    };

        //    var countrylist = ts.countries.ToList();
        //    ud.countries = new SelectList(countrylist, "countryid", "countryname");
        //    var statelist = ts.states1.ToList();
        //    ud.states = new SelectList(ddl, "id", "name");
        //    var citylist = ts.city2.ToList();
        //    ud.cities = new SelectList(ddl, "id", "name");
        //    try
        //    {
        //        empstate u = new empstate();
        //        u.id = ud.id;
        //        u.firstname = ud.firstname;
        //        u.lastname = ud.lastname;
        //        u.email = ud.email;
        //        u.address = ud.address;
        //        u.countryid = Convert.ToInt32(ud.countryid);
        //        u.stateid = Convert.ToInt32(ud.stateid);
        //        u.cityid = Convert.ToInt32(ud.cityid);
        //        u.number = ud.number;
        //        ts.empstates.AddObject(u);
        //        ts.SaveChanges();
        //        bool msg = false;
        //        return Json(msg);
        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        bool msg = true;
        //        return Json(msg);
        //        return View(ud);
        //    }
        //}
        
        
         //GET: /Home/Edit/5
 
        public ActionResult Edit(int id=0)
        {
            userdetail us = new userdetail();

            var t = ts.empstates.Where(x => x.id == id).SingleOrDefault();
            var countrylist = ts.countries.ToList();
            us.countries = new SelectList(countrylist, "countryid", "countryname");

            var statelist = ts.states1.Where(x => x.countryid==t.countryid).ToList();
            us.states = new SelectList(statelist, "stateid", "statename");

            var citylist = ts.city2.Where(x => x.stateid == t.stateid).ToList();
            us.cities = new SelectList(citylist,"cityid","cityname");
            
            us.id = t.id;
            us.firstname = t.firstname;
            us.lastname = t.lastname;
            us.email = t.email;
            us.address = t.address;
            us.countryid = t.countryid.ToString();
            us.stateid = t.stateid.ToString();
            us.cityid = t.cityid.ToString();
            us.number = t.number;
            us.dob = t.dob.ToString();
            us.age = t.age;
            return View(us);
        }

        
         //POST: /Home/Edit/5

        [HttpPost]
        public ActionResult Edit( userdetail uf)
        {
            
            var countrylist = ts.countries.ToList();
            uf.countries = new SelectList(countrylist, "countryid", "countryname");
            var statelist = ts.states1.ToList();
            uf.states = new SelectList(statelist,"stateid","statename");
            var citylist = ts.city2.ToList();
            uf.cities = new SelectList(citylist, "cityid", "cityname");
            try
            {

                // TODO: Add update logic here
                var t = ts.empstates.Where(x => x.id == uf.id).SingleOrDefault();
                t.id = uf.id;
                t.firstname = uf.firstname;
                t.lastname = uf.lastname;
                t.email = uf.email;
                t.address = uf.address;
                t.countryid = Convert.ToInt32(uf.countryid);
                t.stateid = Convert.ToInt32(uf.stateid);
                t.cityid = Convert.ToInt32(uf.cityid);
                t.number = uf.number;
                t.dob =Convert.ToDateTime(uf.dob);
                t.age = uf.age;
                ts.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(uf);
            }
        }

        
         //GET: /Home/Delete/5
 
        public ActionResult Delete(int id)
        {
            var t = ts.empstates.Where(x => x.id == id).SingleOrDefault();
            ts.DeleteObject(t);
            ts.SaveChanges();
            return RedirectToAction("Index");
        }

        
        // POST: /Home/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

      

        public ActionResult test() 
        {
            return View();
        }

        public string GetEmailId(string email) { 
           usercascadEntities2 ts = new usercascadEntities2();
            var t = ts.empstates.Where(x=>x.email==email).FirstOrDefault();
            if (t != null)
            {
                return "1";
            }
            else
            {
                return "0";
            }
        
        }
   
    }
}
