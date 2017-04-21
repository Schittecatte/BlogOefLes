using BlogOefLes.Models;
using System.Collections.Generic;

namespace BlogOefLes.Core
{
    public static class Database
    {
        public static IList<Person> Home { get; set; }

        public static void Initialize()
        {
            Home = new List<Person>
            {
                new Person()
            };
        }
    }
}