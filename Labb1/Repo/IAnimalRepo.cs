using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labb1.Entities;

namespace Labb1.Repo
{
    public interface IAnimalRepo
    {
        List<Animal> GetAll();

        Animal GetByID(int id);
    }
}
