using DRYDemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// It's yelling at us because this is a .NET 4.7.2 WinForm application and the rest of this project is created in .NET 5 (.NET Core). Ignore it or replace it later with a .NET Core WinForm App
/// </summary>
namespace WinFormUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void generateEmployeeIdButton_Click(object sender, EventArgs e)
        {
            /*
             * string employeeId = $@"{ firstNameText.Text.Substring(0, 4) }{ lastNameText.Text.Substring(0, 4) }{ DateTime.Now.Millisecond }";
             *      you see repetition with the substring calls. If you wanted to, you could break that part into a method but really you already have, it's called substring.
             *      putting it into another method does not help.
             *      
             * What if you wanted to add multiple new employees? You don't want to add them one at a time. Now you have to repeat yourself
             * DRY is about looking ahead and knowing you will have repetition, so you solve the problem early.
             * 
             *      You can create a method.
             */
            EmployeeProcessor processor = new EmployeeProcessor();
            employeeIdText.Text = processor.GenerateEmployeeID(firstNameText.Text, lastNameText.Text);
        }

        // allows us to not repeat ourselves if we're not using the same form. because we're not assuming where the data comes from or where it is going. 
        // for example, if your boss says he wants to switch from WinForms to WPF...
        // we should create a class library. >>> See DRYDemoLibrary
    }
}
