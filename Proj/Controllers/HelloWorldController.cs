using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Proj.Controllers
{
    public class HelloWorldController
    {
        public string Index()
        {
            return "This is my default action...";
        }
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}