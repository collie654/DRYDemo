using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// One of the nice things about class libraries, is that it can easily be put into other projects. This was written in the DRYDemoLibrary project.
/// </summary>
namespace DRYDemoLibrary
{
    public class EmployeeProcessor
    {
        // because of my test cases, i've learned that this line:
        //                                          string employeeId = $@"{ firstName.Substring(0,4) }{ lastName.Substring(0,4) }{ DateTime.Now.Millisecond }";
        // causes an index out of bound exception if either name is too short. I will create a new method to solve this.
        public string GenerateEmployeeID(string firstName, string lastName)
        {
            string employeeId = $@"{ GetPartOfName(firstName, 4) }{ GetPartOfName(lastName, 4) }{ DateTime.Now.Millisecond }";
            return employeeId;
        }

        // i'm adding number of characters here because we may want to change the length of name parts later down the line, it's more robust.
        private string GetPartOfName(string name, int numberOfCharacters)
        {
            string output = name;

            if (name.Length > numberOfCharacters)
            {
                output = name.Substring(0, numberOfCharacters);
            }
            else
            {
                do
                {
                    output += "X";
                } while (output.Length < 4);
            }

            return output;
        }
    }
}
