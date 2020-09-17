using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.CSharpPrepCourse.Console
{
    public interface IOutput
    {
        void Write(string text);
        void WriteLine(string text);
    }
}
