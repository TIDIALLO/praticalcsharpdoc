//using contact.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace contact.pages;

public class ContactModel : PageModel{

    [BindProperty]
    public ContactMod Contact{get;set;} 


    public void OnGet(){
        
    }

    public void OnPost(){
        // if (!ModelState.IsValid)
        // {
        //     return Page();
        // }
        // return RedirectToPage("./Index");
        Contact = new ContactMod();
        Contact.FirstName = Request.FirstName
        //@ViewData['']
    }

    public class ContactMod
    {
        public int Id{get;set;}

        [Required, StringLength(25)]
        [Display(Name = "Your first name")] 
        public string FirstName{get;set;}

        [Required, StringLength(25)]
        [Display(Name = "Your last name")] 
        public string LastName{get;set;}

        [Required]
        [EmailAddress]
        public string Email{get;set;}
        
        [Phone]
        [Display(Name = "Phone number")] 
        public string PhoneNumber{get;set;}
    }
}