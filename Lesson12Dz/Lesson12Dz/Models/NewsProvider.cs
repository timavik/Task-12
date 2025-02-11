using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Lesson12Dz.Models
{

    class NewsProvider
    {
        
        public event MyEventHandler NewsSport;
        public event MyEventHandler NewsHumor;
        public event MyEventHandler News;
        public event MyEventHandler NewsWeather;
        public event MyEventHandler NewsIncidents;


        // Метод для публикации новости
        public void PublishNews(string category, string news)
        {
            Console.WriteLine($"Новая новость в категории '{category}': {news}");

            // Создаем аргументы события
            var eventArgs = new NewsEventArgs(category, news);

            if (category == "спорт" & NewsSport != null)
                NewsSport(this, eventArgs);

            if (category == "юмор" & NewsHumor != null)
                NewsHumor(this, eventArgs);

            if (category == "новости" & News != null)
                News(this, eventArgs);

            if (category == "погода" & NewsWeather != null)
                NewsWeather(this, eventArgs);

            if (category == "проишествия" & NewsIncidents != null)
                NewsIncidents(this, eventArgs);


        }
    }
}