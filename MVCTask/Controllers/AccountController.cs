using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCTask.Models;
using static MVCTask.Models.CheckBoxModel;

namespace MVCTask.Controllers
{
   
    public class AccountController : Controller
    {


        //public string Reg(RegisterClass rc)
        //{
        //    string firstName = rc.FirstName;
        //    string phonenumber = rc.PhoneNumber;
        //    string LastName = rc.LastName;
        //    string Address = rc.Address;
        //    string CompanyName = rc.CompanyName;
        //    Country CountryName = rc.CountryName;
        //    string EmailAddress = rc.EmailAddress;
        //    State StateName = rc.StateName;
        //    City CityName = rc.CityName;
        //    List<CheckBoxModel> Business = rc.Business;
        //    List<CheckBoxModel> Budget = rc.Budget;
        //    return " FirstName : " + firstName + " PhoneNumber : " + phonenumber + " CountryName : " + CountryName + " LastName : " + LastName + " Address : " + Address + " CompanyName : " + CompanyName + " StateName : " + StateName + " CityName : " + CityName + " Business : " + Business + " Budget : " + Budget;

        //}


        //[Route("Home/signup")]
        public IActionResult Signup()
        {
            List<CheckBoxModel> ChkItem = new List<CheckBoxModel>()
        {
          new CheckBoxModel {Value=1,Text="Planning stages/just starting out",IsChecked=false },
          new CheckBoxModel {Value=1,Text="A year or less",IsChecked=false },
          new CheckBoxModel {Value=1,Text="1-2 years in",IsChecked=false },
          new CheckBoxModel {Value=1,Text="2-5 years",IsChecked=false },
          new CheckBoxModel {Value=1,Text="5+" ,IsChecked=false},
        };

            List<CheckBoxModel> chkBgt = new List<CheckBoxModel>()
        {
          new CheckBoxModel {Value=1,Text="$1500-$3000",IsChecked=false },
          new CheckBoxModel {Value=1,Text="$3000-$5000",IsChecked=false },
          new CheckBoxModel {Value=1,Text="$5000-$7500",IsChecked=false },
          new CheckBoxModel {Value=1,Text="$7500-$10000" ,IsChecked=false},
          new CheckBoxModel {Value=1,Text="$10,000+",IsChecked=false },
        };

            RegisterClass ChkItems = new RegisterClass();
            ChkItems.Business = ChkItem;


            RegisterClass ChkBgt = new RegisterClass();
            ChkItems.Budget = chkBgt;
            return View(ChkItems);


        }
        


        public IActionResult Index(RegisterClass register)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in register.Business)
            {
                if (item.IsChecked)
                {

                    sb.Append(item.Text);
                }
            }
            ViewBag.business = sb.ToString();

            StringBuilder sb1 = new StringBuilder();
            foreach (var items in register.Budget)
            {
                if (items.IsChecked)
                {
                    sb1.Append(items.Text + " ");
                }

            }

            ViewBag.budget = sb1.ToString();

            return View(register);
        }
    }
}
