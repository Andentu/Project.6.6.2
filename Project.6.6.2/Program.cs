

namespace Project_6_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class Pen // Класс
    {
        public string color; // Инициализации переменных
        public int cost;

        public Pen () //Конструктор без параметров
        {
            color = "Черный";
            cost = 100;
        }
        public Pen (string PenColor, int PenCost) //С двумя параметрами
        {
            color = PenColor;
            cost = PenCost;
        }
    }
}