using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuriDeDate.Models.Car
{
    public class Car : IBuilderCar
    {

        private int _id;
        private string _model;
        private string _marca;
        private int _year;

        public Car(int id, string model, string marca, int year)
        {
            _id = id;
            _model = model;
            _marca = marca;
            _year = year;
        }

        public int getId()
        {
           return _id;
        }

        public void setId(int id)
        {
            _id = id;
        }

        public string getModel()
        {
            return _model;
        }

        public void setModel(string model)
        {
            _model = model;
        }

        public string getMarca()
        {
            return _marca;
        }

        public void setMarca(string marca)
        {
            _marca = marca;
        }

        public int getYear()
        {
            return _year;
        }

        public void setYear(int year)
        {
            _year = year;
        }

        public Car Id(int id)
        {
            this._id = id;
            return this;
        }

        public Car Marca(string marca)
        {
            this._marca = marca;
            return this;
        }

        public Car Year(int year)
        {
            this._year = year;
            return this;
        }

        public Car Model(string model)
        {
            this._model = model;
            return this;
        }

        public string descriere()
        {
            string t = "";

            t += $"Id {_id.ToString()} \n";
            t += $"Marca {_marca.ToString()} \n";
            t += $"Model {_model.ToString()} \n";
            t += $"Year {_year.ToString()} \n";

            return t;
        }

        public override string ToString()
        {
            return descriere();
        }

    }
}
