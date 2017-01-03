using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    interface IGradeble
    {
        int Grade100 { get; set; }
        int Grade5 { get; }
        string GradeFive { get; }
        int PrintGrade();

    }
}
