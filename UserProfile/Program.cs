namespace UserProfile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Как Вас зовут? ");
            var name = Console.ReadLine();
            Console.Write("Ваш возвраст? ");
            var age = int.Parse(Console.ReadLine());
            Console.Write("Ваша дата рождения?");
            var bDay = Console.ReadLine();

            Console.WriteLine("\tВаши данные:\n \t Имя: {0} \n \t Возраст: {1} \n \t Дата Рождения : {2}", name, age, bDay);
         }
    }
}