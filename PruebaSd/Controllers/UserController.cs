using Microsoft.AspNetCore.Mvc;
using Prueba.UnitOfWork;

namespace PruebaSd.Controllers
{
   
        [Route("api/User")]
        public class UserController : Controller
        {
            private readonly IUnitOfWork _unitOfWork;
            public UserController(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }

            [HttpGet]
            public IActionResult GetCostumer()
            {
                return Ok(_unitOfWork.Usuario.GetList());
            }

            [HttpGet]
            [Route("{id:int}")]
            public IActionResult GetById(int id)
            {
                return Ok(_unitOfWork.Usuario.GetById(id));
            }

        }
}
