using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12Dz.Models
{
    class Client
    {
        private string _name;

        public Client(string name)
        {
            _name = name;
        }

        public void OnNewsReceived(object sender, NewsEventArgs e)
        {
            Console.WriteLine($"{_name} получил новость в категории '{e.Category}': {e.News}");
        }
    }
}