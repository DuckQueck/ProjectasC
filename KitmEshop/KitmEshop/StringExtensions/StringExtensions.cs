using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitmEshop.StringExtensions
{
    public static class StringExtensions
    {
        public static string UrlName(this Type controller)
        {
            var name = controller.Name;
            return name.EndsWith("Controller") ? name.Substring(0, name.Length - 10) : name;
        }
    }
}
