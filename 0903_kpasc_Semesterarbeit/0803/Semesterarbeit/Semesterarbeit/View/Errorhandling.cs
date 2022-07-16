using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semesterarbeit.View
{
    public static class Errorhandling
    {
        //Static string array with individual error messages
        private static string[] errorResponse = new string[]
        {
            "No input data has been found." + Environment.NewLine + "Let's create some new contacts!",
            "Some mandatory fields are missing or do have a wrong input!",
            "Please select a search attribute to search on!"
        };

        //Static method 
        public static string ReturnErrorResponse(int i)
        {
            string message = errorResponse[i];
            return message;
        }

    }
}
