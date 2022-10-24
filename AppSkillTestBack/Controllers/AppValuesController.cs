using App_Back.Provider;
using App_Front.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App_Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppValuesController : ControllerBase
    {
        private readonly IAppService _Provider;

        public AppValuesController(IAppService Provider)
        {
            _Provider = Provider;
        }

        [HttpGet]
        [Route("GetLocation")]
        public IActionResult GetLocation()
        {
            var model = _Provider.GetLocation();

            return Ok(model);
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult Post([FromBody] CreateEditViewModel model)
        {

            if (model is null)
            {
                return BadRequest("Data is null.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            //var data = new ();

            //data.Code = model.Code;
            //data.Name = model.Name;
            //data.IsActive = model.IsActive;
            //data.Description = model.Description;
            //data.CreatedBy = ClaimIdentity.CurrentUserID;
            //data.CreatedDate = DateTime.Now;

            //_provider.Add(data);
            return Ok("");
        }

    }
}
