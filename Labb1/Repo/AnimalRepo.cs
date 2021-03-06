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

        public Animal GetByID(int id)
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
                    Id = 1,
                    Animaltype="Frog",
                    Name="Bob"
                },
                new Animal
                {
                    Id = 2,
                    Animaltype="Dog",
                    Name="Pelle"
                },
                new Animal
                {
                    Id = 3,
                    Animaltype="Horse",
                    Name="Lillen"
                },
                new Animal
                {
                    Id = 4,
                    Animaltype="Hamster",
                    Name="Fred"
                },
                new Animal
                {
                    Id = 5,
                    Animaltype="Octopus",
                    Name="Peter"
                }


            };
        }
    }
}
