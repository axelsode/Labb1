using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb1.Entities;

namespace Labb1.Repo
{
    public class AnimalRepo : IAnimalRepo
    {
        private List<Animal> _animals;

        public AnimalRepo()
        {
            _animals = PopulateAnimalData();
        }


        public List<Animal> GetAll()
        {
            return _animals;
        }

        public Animal GetByID(Guid id)
        {
            Animal animal = _animals.Find(x => x.Id == id);
            return animal;

        }


        private List<Animal> PopulateAnimalData()
        {
            return new List<Animal>
            {
                new Animal
                {
                    Id = Guid.NewGuid(),
                    Animal="Frog",
                    Name="Bob"
                },
                new Animal
                {
                    Id = Guid.NewGuid(),
                    Animal="Dog",
                    Name="Pelle"
                },
                new Animal
                {
                    Id = Guid.NewGuid(),
                    Animal="Horse",
                    Name="Lillen"
                },
                new Animal
                {
                    Id = Guid.NewGuid(),
                    Animal="Hamster",
                    Name="Fred"
                },
                new Animal
                {
                    Id = Guid.NewGuid(),
                    Animal="Octopus",
                    Name="Peter"
                }


            };
        }
    }
}
