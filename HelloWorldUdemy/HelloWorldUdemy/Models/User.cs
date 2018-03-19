using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldUdemy.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string ImageUrl
        {
            get { return $"https://picsum.photos/200/200?image={Id}"; }
        }
    }
}
