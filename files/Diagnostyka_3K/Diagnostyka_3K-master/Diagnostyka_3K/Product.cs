// ## zadanie diagnostyczne

// aplikacja konsolowa w c# prosty katalog produktów

// klasa produkt: nazwa, cena, kategoria
// lista kilku produktów w kolekcji
// wypisanie wszystkich na ekran
// wypisanie tylko tych tańszych niż podana kwota
// posortowane po cenie

using System;
using System.Collections.Generic;
using System.Text;

namespace Diagnostyka
{
    class Product
    {
        public string name;
        public float price;
        public string category;

        // konstruktor inicjuje obiekt wartościami przekazanymi jako argumenty
        public Product(string name, float price, string category)
        {
            this.name = name;
            this.price = price;
            this.category = category;
        }
    }
}
// float jest zapisywana w komputerze binarnie 1.5 = 15 * 10⁻2

