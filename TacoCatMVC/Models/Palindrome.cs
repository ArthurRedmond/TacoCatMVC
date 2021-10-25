using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TacoCatMVC.Models
{
    public class Palindrome
    {
        public string InputWord { get; set; }
        public string RevWord { get; set; }
        public bool IsPalendrome { get; set; }
        public string Message { get; set; }
    }
}
