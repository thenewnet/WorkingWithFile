using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReadWriteFileExample
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (fupFile.HasFile)
            {
                var extension = Path.GetExtension(fupFile.FileName).ToLower();
                if (!extension.Equals(".txt") && !extension.Equals(".xml"))
                {
                    lblResult.Text = "Only allow txt or xml file";
                    lblResult.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    //save file
                    string path = Server.MapPath("~/Uploads/");
                    fupFile.SaveAs(path + "/" + fupFile.FileName);
                    lblResult.Text = "Successfullly";
                }
            }
            else
            {
                lblResult.Text = "Please choose file.";
                    lblResult.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}