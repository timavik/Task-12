using Lesson12Dz.Models;

namespace Lesson12Dz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем поставщика новостей
            var provider = new NewsProvider();

            // Создаем клиентов
            var client1 = new Client("Иван");
            var client2 = new Client("Алексей");
            var client3 = new Client("Мария");

            provider.NewsHumor += client1.OnNewsReceived;
            provider.News += client2.OnNewsReceived;
            provider.NewsSport += client2.OnNewsReceived;
            provider.NewsWeather += client3.OnNewsReceived;

            provider.PublishNews("новости", "В стране прошел масштабный митинг.");
            provider.PublishNews("погода", "Завтра ожидается дождь.");
            provider.PublishNews("спорт", "Сборная России выиграла чемпионат мира!");
            provider.PublishNews("юмор", "Колобок повесился");

            
            Console.ReadKey();
        }
    }
}

