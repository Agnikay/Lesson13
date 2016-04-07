using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Code
{
    public class NewPersonEventArgs : EventArgs
    {
        public string Name { set; get; }
        public DateTime Arrived { set; get; }
    }
}
