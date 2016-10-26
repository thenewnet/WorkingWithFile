using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace ReadWriteFile1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (fupFile.HasFiles) // fupFile.PostedFiles.Count > 0
            {
               

                var extension = Path.GetExtension(fupFile.FileName).ToLower();
                if (!extension.Equals(".txt") && !extension.Equals(".xml"))
                {
                    lblResult.Text = "Chương trình chỉ cho phép làm việc với file xml hoặc txt";
                    lblResult.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    var path = Server.MapPath("~/App_Data/");
                    //fupFile.SaveAs(path + fupFile.FileName);
                    var fstream = new FileStream(Path.GetFullPath(fupFile.FileName), FileMode.Open);
                    var streamReader = new StreamReader(fstream);

                    var results = string.Empty;
                    var expression = string.Empty;

                    do
                    {
                        expression = streamReader.ReadLine();
                        if (!string.IsNullOrEmpty(expression))
                        {
                            results += expression + " = " + Calculate(expression) + "<br />";
                        }
                    } while (!string.IsNullOrEmpty(expression));

                    lblResult.Text = results;
                    lblResult.ForeColor = System.Drawing.Color.Blue;
                }
            }
            else
            {
                lblResult.Text = "Bạn vui lòng chọn file để thực hiện";
                lblResult.ForeColor = System.Drawing.Color.Red;
            }
        }

        private string Calculate(string expression)
        {
            string result = string.Empty;
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
                result = arrayNumber[0].Trim();
            }
            else //have 2 numbers
            {
                switch (operation)
                {
                    case "+":
                        {
                            double number1;
                            var check1 = double.TryParse(arrayNumber[0].Trim(), out number1);
                            if (!check1)
                            {
                                number1 = 0;
                            }
                            
                            double number2;
                            var check2 = double.TryParse(arrayNumber[1].Trim(), out number2);
                            if (!check2)
                            {
                                number2 = 0;
                            }

                            result = (number1 + number2).ToString();
                            break;
                        }
                    case "-":
                        {
                            double number1;
                            var check1 = double.TryParse(arrayNumber[0].Trim(), out number1);
                            if (!check1)
                            {
                                number1 = 0;
                            }

                            double number2;
                            var check2 = double.TryParse(arrayNumber[1].Trim(), out number2);
                            if (!check2)
                            {
                                number2 = 0;
                            }

                            result = (number1 - number2).ToString();
                            break;
                        }
                    case "*":
                        {
                            double number1;
                            var check1 = double.TryParse(arrayNumber[0].Trim(), out number1);
                            if (!check1)
                            {
                                number1 = 0;
                            }

                            double number2;
                            var check2 = double.TryParse(arrayNumber[1].Trim(), out number2);
                            if (!check2)
                            {
                                number2 = 0;
                            }

                            result = (number1 * number2).ToString();
                            break;
                        }
                    case "/":
                        {
                            double number1;
                            var check1 = double.TryParse(arrayNumber[0].Trim(), out number1);
                            if (!check1)
                            {
                                number1 = 0;
                            }

                            double number2;
                            var check2 = double.TryParse(arrayNumber[1].Trim(), out number2);
                            if (!check2)
                            {
                                result = "Lỗi chia cho 0";
                            }
                            else
                            {
                                result = (number1 / number2).ToString();
                            }
                            break;
                        }
                }
            }

            return result;
        }
    }
}