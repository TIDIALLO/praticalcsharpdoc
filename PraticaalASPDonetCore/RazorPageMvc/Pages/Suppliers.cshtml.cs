using Microsoft.AspNetCore.Mvc.RazorPages; // PageModel

namespace RazorPageMvc.Web.Page;

public class SuppliersModel: PageModel{
    
    public IEnumerable<string>? Suppliers { get; set; }

    public void OnGet(){
        ViewData["Title"] = " Suppliers";
        Suppliers = new[]{"Alpha Co", "Beta Limited", "Gamma Corp"};
    }

}