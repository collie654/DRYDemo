using DRYDemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DryDemoLibraryTest
{
    /// <summary>
    /// using tests is extremely convenient because it allows you to create test cases with one copy and paste, find the error very quickly, and begin fixing it.
    /// 
    /// This fits into DRY because we're not repeating a bunch of tests over and over again to find a bug. We create it once and simply run it.
    /// 
    /// * Dont put code in the code behind. You can always generalize it to the point where you don't need to know exactly which button or output is being used.
    /// * Be putting your code into a library. A .NET Standard(Core) Library. Allows you to use all c# platforms.
    ///         * config file won't fit in there, create 2 libraries: Standard library and a seperate library so it can be used accross windows, just not accross mac, linux, IOS or android etc.
    /// </summary>
    public class EmployeePRocessorTest
    {
        [Theory]
        [InlineData("Timothy", "Corey", "TimoCore")]
        [InlineData("Tim", "Corey", "TimXCore")]
        [InlineData("Tim", "Co", "TimXCoXX")]
        public void GenerateEmployeeId_ShouldCalculate(string firstName, string lastName, string expectedStart)
        {
            // Arrange
            EmployeeProcessor processor = new();

            // Act
            string actualStart = processor.GenerateEmployeeID(firstName, lastName).Substring(0, expectedStart.Length);

            // Assert
            Assert.Equal(expectedStart, actualStart);
        }
    }
}
