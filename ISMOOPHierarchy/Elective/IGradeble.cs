using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elective
{
    interface IGradeble
    {
        byte Grade100 { get; set; }
        byte Grade5 { get; }
        string GradeFive { get; }
        int PrintGrade();

    }
}
