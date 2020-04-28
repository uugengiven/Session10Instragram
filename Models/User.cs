using System;
using System.Collections.Generic;

namespace Instagrames.Models
{
    public class User 
    {
        public int Id {get;set;}
        public string Username {get;set;}
        public string DisplayName{get;set;}
        public string Password {get;set;}

        public List<Post> Posts {get;set;}
    }
}