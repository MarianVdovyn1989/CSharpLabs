using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.CSharpPrepCourse.BL.MobileComponentFactory
{
    public interface IFactory
    {
        FactoryOutput Create(int userInput);
    }
}
