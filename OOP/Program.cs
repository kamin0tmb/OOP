using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            NoteBook noteBook = new NoteBook();
            Console.WriteLine("Характеристики ноутбука: {0}", noteBook.NameProduct());

            var caseNoteBook = new CaseNoteBook();
            var caseShop = caseNoteBook.noteBook.model;
            Console.WriteLine("Наименование сумки для ноутбука: {0}", caseNoteBook.ChangeCase(caseShop));


        }
    }
    abstract class Delivery
    {
        public string Address;
    }

    abstract class Product
    {
        public string manufacturer;
        public string model;
        public int year;

        public virtual string NameProduct() 
        {
            return "производитель:" + manufacturer + "модель:" + model + "год выпуска:" + year;
        }
        
    }

    class NoteBook : Product
    {
        public int cores; 
        protected string diagonal; 

        public NoteBook() 
        {
            manufacturer = "HP";
            model = "250 G7";
            year = 2022;
            cores = 2;
            diagonal = "15,6";
        }
        public int Cores
        {
            get
            {
                return cores;
            }
            set
            {
                if (value == 2 || value == 4 || value == 6 || value == 8)
                {
                    Console.WriteLine("Количество ядер может быть только 2, 4, 6 или 8");
                }
                else cores = value;
            }
        }

        public override string NameProduct()
        {
            return "производитель: " + manufacturer + " модель: " + model + " год выпуска: " + year + " количество ядер процессора: " + cores + " диагональ дисплея: " + diagonal;
        }
    }

    class CaseNoteBook
    {
        public NoteBook noteBook;
        public CaseNoteBook()
        {
            noteBook = new NoteBook();
        }
        public string ChangeCase(string model)
        {
            switch (noteBook.model)
            {
                case "250 G7":
                    return "case156";
                case "245 G8":
                    return "case14";
                case "elite dragonfly g2":
                    return "case133";
            }
            return "Сумка для данной модели отсутствует в продаже";
        }
    }



    class Order<TDelivery, TNoteBook, TCaseNoteBook>
        where TDelivery : Delivery
        where TNoteBook : NoteBook
        where TCaseNoteBook : CaseNoteBook
    {
        public TDelivery Delivery;
        public TNoteBook NoteBook;
        public TCaseNoteBook CaseNoteBook;


        public int Number;

        public string Description;

        public void DisplayAddress(TDelivery Delivery)
        {
            Console.WriteLine("Адрес доставки" + Delivery);
        }

        public void DisplayProduct()
        {
            Console.WriteLine("Товар: " + NoteBook.NameProduct());
        }
    }
}