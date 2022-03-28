using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace cascadingprac.Models
{
    public class userdetail
    {
        public int id { get; set; }


        //[Required(ErrorMessage = "Enter Firstname")]
        public string firstname { get; set; }

         //[Required(ErrorMessage = "Enter lastname")]
        public string lastname { get; set; }

         //[Required(ErrorMessage = "Enter email")]
        public string email { get; set; }

         //[Required(ErrorMessage = "Enter address")]
        public string address { get; set; }


         //[Required(ErrorMessage = "Enter country")]
         public string countryid { get; set; }


         //[Required(ErrorMessage = "Enter state")]
         public string stateid { get; set; }

         //[Required(ErrorMessage = "Enter city")]
        public string cityid { get; set; }

         //[Required(ErrorMessage = "Enter Number")]
        public string number { get; set; }

        public string dob { get; set; }

        public int age { get; set; }

         public SelectList cities { get; set; }
         public SelectList states { get; set; }
         public SelectList countries { get; set;}
    }

    public class ddl 
    {
        public int id { get; set; }
        public string name { get; set; }
    
    }
}