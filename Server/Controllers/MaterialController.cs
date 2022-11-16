using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NWSInventaire.Server.Data;
using NWSInventaire.Server.Repository;

namespace NWSInventaire.Server.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class MaterialController : ControllerBase
    {

        private readonly ILogger<MaterialController> _logger;
        private readonly MaterialRepository Materials;

        public MaterialController(ILogger<MaterialController> logger, MaterialRepository mRepository)
        {
            _logger = logger;
            Materials = mRepository;
        }

        [HttpGet("GetAllStudent")]
        public string GetAllStudent()
        {
            Console.WriteLine("Call AllStudent Function");
            return Materials.GetAllStudent();
        }

        [HttpGet("testMig")]
        public string testMig()
        {
            return Materials.TestMigration();
        }

    }
}
