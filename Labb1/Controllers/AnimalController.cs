using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb1.Entities;
using Labb1.Repo;
using Microsoft.AspNetCore.Mvc;

namespace Labb1.Controllers
{
    [ApiController]
    [Route("animal")]

    public class AnimalController : ControllerBase
    {
        private readonly IAnimalRepo _repo;

        public AnimalController(IAnimalRepo repo)
        {
            _repo = repo;
        }

        //GET /api/animal
        [HttpGet]
        [Route("")]
        public List<Animal> GetAnimals()
        {
            List<Animal> animals = _repo.GetAll();
            return animals;
        }


        //GET /api/animal/:id
        [HttpGet]
        [Route("{{id}}")]
        public Animal GetAnimalByID(Guid id)
        {
            return _repo.GetByID(id);
        }
    }

}