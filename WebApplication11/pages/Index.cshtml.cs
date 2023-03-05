using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;

namespace WebApplication11.pages
{
    /* public class IndexModel : PageModel
     {
         public string Message { get; }
         public IndexModel()
         {
             Message = "Hello world!";
         }
         public string PrintTime()=>DateTime.Now.ToShortTimeString();
     }*/
    /*  public class IndexModel:PageModel
       {
           public string Message1 { get; private set; } = "";
           public void OnGet(Human[] human)
           {
               string result = "";
               foreach (Human humanItem in human)
               {
                   result = $"{result} {humanItem.name};";
               }
               Message1 = result;
           }
       }
       public record class Human(string name,int age); */
    public class IndexModel : PageModel
    {
        public string Message1 { get; private set; } = "";
       /* public void OnGet(Dictionary<string, string> map)
        {
            string result = "";
            foreach (var item in map)
            {
                result = $"{result} {item.Key} - {item.Value}";
            }
            Message1 = result;
        }*/
       public void OnGet()
        {
            string name = Request.Query["name"];
            string age = Request.Query["age"];
            Message1 = $"Name: {name} Age: {age}";
        }
    }
    public record class Human(string name, int age);
}
