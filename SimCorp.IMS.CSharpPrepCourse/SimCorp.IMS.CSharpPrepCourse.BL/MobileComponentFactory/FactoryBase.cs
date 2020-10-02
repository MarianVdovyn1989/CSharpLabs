using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.CSharpPrepCourse.BL.MobileComponentFactory
{
    public abstract class FactoryBase : IFactory
    {
        IOutput Output;
        public FactoryBase(IOutput output)
        {
            Output = output;
        }
        public int SelectComponentIndex()
        {
            while (true)
            {
                Console.WriteLine(BuildHeaderSelector());

                var OptionBuilder = BuildComponentsSelector();
                //IOutput
                Console.Write(OptionBuilder);

                var line = Console.ReadLine();
                Exception Ex = null;
                int Index = 0;
                try
                {
                    //convert to integer
                    var index = int.Parse(line);
                    //check that int value is within the specified range of current method
                    //method inherited from abstract class - not unique
                    Index = ValidateUserInputIndex(index, OptionBuilder);
                    return Index;
                }
                catch (ArgumentException ex)
                {
                    Output.WriteLine(ex.Message);
                    Ex = ex;
                }
                catch (FormatException ex)
                {
                    Output.WriteLine(ex.Message);
                    Ex = ex;
                }
                finally
                {
                    Output.WriteLine(ConsoleOutput.ReturnSelectedOption(OptionBuilder, Ex, Index) + "\n");
                }
            }
        }
        private int ValidateUserInputIndex(int index, StringBuilder OptionBuilder)
        {
            int LastOption = OptionBuilder.ToString().Split('\n').Length - 2;

            if (index > 0 && index < LastOption)
                return index;
            else
                throw new ArgumentException($"Invalid {nameof(index)}");
        }
        public abstract FactoryOutput Create(int userInput);
        public abstract StringBuilder BuildComponentsSelector();
        public abstract StringBuilder BuildHeaderSelector();
    }
}
