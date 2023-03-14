using System.Drawing;

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
        public string color; //Инициализация переменных
        public int cost;
        public Pen() // Первый конструктор. Без параметров, при этом поля переменных заполняются определенными значениями
        {
            color = "Черный";
            cost = 100;
        }

        public Pen(string penColor, int penCost) // Второй конструктор. С параметрами. При этом значения получают из конструктора
        {
            color = penColor;
            cost = penCost;
        }
    }
}