using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuriDeDate.Models.Car
{
    public interface IBuilderCar
    {

        Car Id(int id);

        Car Marca(string marca);

        Car Model(string model);

        Car Year(int year);


    }
}
