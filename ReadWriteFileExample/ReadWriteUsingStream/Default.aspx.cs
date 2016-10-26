using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace ReadWriteUsingStream
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            var path = Server.MapPath("~/App_Data/data.txt");
            if (!File.Exists(path))
            {
                lblResult.Text = "File không tồn tại";
            }
            else
            {
                var fstream = new FileStream(path, FileMode.Open);
                var streamReader = new StreamReader(fstream);

                var expression = string.Empty;
                var result = string.Empty;
                do
                {
                    expression = streamReader.ReadLine();
                    if (!string.IsNullOrEmpty(expression))
                    {
                        result += expression + " = " + Calculate(expression) + "<br />";
                    }
                } while (!string.IsNullOrEmpty(expression));

                //close stream
                streamReader.Close();
                fstream.Close();

                lblResult.Text = result;
            }
        }

        private double Calculate(string expression)
        {
            double result = 0;
            //identify the operation
            string[] arrayNumber = expression.Split('+');
            string operation = "+";
            if (arrayNumber.Length <= 1)
            {
                arrayNumber = expression.Split('-');
                operation = "-";
            }
            if (arrayNumber.Length <= 1)
            {
                arrayNumber = expression.Split('*');
                operation = "*";
            }
            if (arrayNumber.Length <= 1)
            {
                arrayNumber = expression.Split('/');
                operation = "/";
            }

            //check if has 1 number
            if (arrayNumber.Length == 1)
            {
                result = double.Parse(arrayNumber[0].Trim());
            }
            else //have 2 numbers
            {
                switch (operation)
                {
                    case "+": result = double.Parse(arrayNumber[0].Trim()) +
                        double.Parse(arrayNumber[1].Trim());  
                        break;
                    case "-": result = double.Parse(arrayNumber[0].Trim()) -
                        double.Parse(arrayNumber[1].Trim());  
                        break;
                    case "*": result = double.Parse(arrayNumber[0].Trim()) *
                        double.Parse(arrayNumber[1].Trim());  
                        break;
                    case "/": result = double.Parse(arrayNumber[0].Trim()) /
                        double.Parse(arrayNumber[1].Trim());  
                        break;
                }
            }

            return result;
        }
    }
}