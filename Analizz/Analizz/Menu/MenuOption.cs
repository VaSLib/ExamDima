using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Analizz.Menu;

namespace Analizz.Menu
{
    internal class MenuOption
    {
        public string? Title { get; set; }
        public Action? Action { get; set; }
    }
}
