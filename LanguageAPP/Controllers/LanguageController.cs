using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LanguageAPP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        public LanguageController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        // GET: api/<LanguageController>
        [HttpGet]
        public string Get(string lng)
        {
            var folderDetails = _hostingEnvironment.ContentRootPath+"\\Resources\\Languages\\";
            string filename = "";
            if (lng == "EN")
                filename = "EN.json";
            else if(lng == "GU")
                filename = "GU.json";
            else
                filename = "EN.json";
            var JSON = System.IO.File.ReadAllText(folderDetails+filename);
            //dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(JSON);
            return JSON;
        }

        // GET api/<LanguageController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
    }
}
