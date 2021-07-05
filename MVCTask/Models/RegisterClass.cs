using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using static MVCTask.Models.CheckBoxModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCTask.Models
{
    public class RegisterClass : CheckBoxModel
    {
        [Required(ErrorMessage = "Please Enter FirstName")]
        [Display(Name = "First Name*")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Phone Number is Required")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        [Display(Name = "Phone #")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please Enter LastName")]
        [Display(Name = "Last Name*")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please Enter Address")]
        [Display(Name = "Address (number + street)*")] 
        public string Address { get; set; }

        [Required(ErrorMessage = "Please Select Company Name")]
        [Display(Name = "Company's Name*")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Please Select Country Name")]
        [Display(Name = "Country Name*")]
        public Country CountryName { get; set; }

        [Required(ErrorMessage = "Please Enter EmailAddress")]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Incorrect Email Format")]
        [Display(Name = "Email Address*")]
        public string EmailAddress { get; set; }


        [Required(ErrorMessage = "Please Select State Name")]
        [Display(Name = "State/province*")]
        public State StateName { get; set; }

        [Required(ErrorMessage = "Please Current Website Name")]
        [Display(Name = "Current Website (if applicable)")]
        public string WebsiteName { get; set; }

        [Required(ErrorMessage = "Please Select City Name")]
        [Display(Name = "City Name*")]
        public City CityName { get; set; }

        [Display(Name = "How long have you been in business?*")]
        public List<CheckBoxModel> Business { get; set; }

        [Display(Name = "What's your total design budget?*")]
        public List<CheckBoxModel> Budget { get; set; }

        //[Display(Name = "Service")]
        //public bool Service { get; set; }
    }

    public enum Country
    {
        India,
        USA,
        UK
    }

    public enum State
    {
        Telangana,
        Andhrapradesh,
        Florida,
        Texas,
        Scotland,
        Whales
    }

    public enum City
    {
        Hyderabad,
        Vizag,
        Miami,
        Dallas,
        Aberdeen,
        Newport
    }

    
}
