using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Title of Post:");
            var title = Console.ReadLine();
            Console.WriteLine("Enter Description of Post:");
            var Description = Console.ReadLine();
            var post1 = new Post(title , Description);
            
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine(post1.title);
                Console.WriteLine(post1.description);
                Console.WriteLine("Time That Post Created: " + post1.created);
                Console.WriteLine("Number Of Votes: " + post1.numberOfVotes);
                Console.WriteLine();
                var input = Console.ReadLine().ToLower();

                if (input == "like")
                    post1.UpVoting();

                else if (input == "dislike")
                    post1.DownVoting();
                if (input == "edit title")
                {
                    title = Console.ReadLine();
                }
                else if (input == "edit description")
                {
                    Description = Console.ReadLine();
                }
            }
        }
    }
}
