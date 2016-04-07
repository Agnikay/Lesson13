using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Code
{
    public class Generator
    {
        public void Generate(int a)
        {
            if (a != 42)
            {
                throw new Not42Exception();
            }

            throw new Exception("Everything is ok");
        }
    }
}
