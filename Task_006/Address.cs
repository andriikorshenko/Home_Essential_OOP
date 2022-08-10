using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Address
    {
        private string? country, city, street, house, apartment;
        private int index;

        public string? Country { get => country; set => country = value; }
        public string? City { get => city; set => city = value; }
        public string? Street { get => street; set => street = value; }
        public string? House { get => house; set => house = value; }
        public string? Apartment { get => apartment; set => apartment = value; }
        public int Index { get => index; set => index = value; }

        public void Show()
        {
            Console.WriteLine($"Страна: {Country}\n" +
                $"Город : {City}\n" +
                $"Улица : {Street}\n" +
                $"Дом : {House}\n" +
                $"Квартира : {Apartment}\n" +
                $"Индекс : {Index}\n");
        }
    }
}
