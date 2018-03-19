using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldUdemy.Models
{
    public class Activity
    {
        public int UserId { get; set; }
        public string Description { get; set; }

        public string ImageUrl
        {
            get { return $"https://picsum.photos/100/100?image={UserId}"; }
        }
    }
}
