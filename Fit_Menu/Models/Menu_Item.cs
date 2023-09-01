using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fit_Menu.Models
{
    public class Menu_Item
    {
        public int Id { get; set; }
        public string item_name { get; set; }
        public DateTime CreatedAt { get; set; }

        //        public List<string> MenuItems { get; set; }
    }
}
