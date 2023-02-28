using Backend_TestedProject.Contract.Specification;
using Backend_TestedProject.Infrastruchers.Models.Specifications;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Backend_TestedProject.Controllers
{
   // [Microsoft.AspNetCore.Mvc.Route("api/Specification")]
    [Microsoft.AspNetCore.Mvc.ApiController]
    [Microsoft.AspNetCore.Mvc.Produces(System.Net.Mime.MediaTypeNames.Application.Json)]

    public class SpecificationController : Controller
    {
        private readonly ISpecificationRepository _SpecificationRepository;
        public SpecificationController(ISpecificationRepository SpecificationRepository) : base()
        {
            this._SpecificationRepository = SpecificationRepository;
        }
        [HttpPost("api/Specification/AddSpecifcation")]
     
        public async Task<ActionResult<List<Specifications>>> AddSpecifcation( Specifications modelEvent)
        {
            //modelEvent.Id = null;
           // modelEvent.Id = null;
            // modelEvent.R_AccessRef = null;
            try
            {
                this._SpecificationRepository.Add(modelEvent);
                return Ok();
            }
            catch (Exception ex)
            {
                string x = ex.Message;

            }

            var List = this._SpecificationRepository.GetAll().ToList();
            return List;
        }
        [HttpPost("FindEvent/{id}")]
      



        public Microsoft.AspNetCore.Mvc.ActionResult<Specifications >
            FindEvent(int id)
        {


            var Find = this._SpecificationRepository.Get(id);

            return Find;

        }
        [HttpPost("DeleteItem/{id}")]
      
        public async Task<ActionResult<List<Specifications>>> DeleteSpecifications(int id)
        {

            if (id != null)
            {
                this._SpecificationRepository.Delete(id);
            }
            var list = this._SpecificationRepository.GetAll().ToList();
            return list;
        }
        

        [HttpPost("GetSpecificationItems")]
        public async Task<ActionResult<List<Specifications>>> GetSpecificationItems()
        {
            var list =this._SpecificationRepository.GetAll().ToList();

            return list;
        }
        [HttpPost("updateSpecificationsItem/{id}")]
     
        public async
                System.Threading.Tasks.Task
                 <Microsoft.AspNetCore.Mvc.ActionResult<List<Specifications>>>
           UpdateEvent(int id, Specifications item)
        {



            if (id != null && item != null)
            {
                try
                {
                    this._SpecificationRepository.Update(id, item);
                }
                catch (Exception ex)
                {
                    string cc = ex.Message;

                    throw;
                }

                //  eventRepository.Delete(id);
            }
            var list = this._SpecificationRepository.GetAll().ToList();

            return list;


        }
    }
}
