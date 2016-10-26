using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReadWriteXml
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FileHelper.Path = Server.MapPath("~/App_Data/Data.xml");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            var student = new Student(txtId.Text, txtName.Text, txtPhone.Text, float.Parse(txtMark1.Text), float.Parse(txtMark2.Text));
            

            lblResult.Text = FileHelper.WriteDataToFile(student);
        }

        protected void btnReadFromFile_Click(object sender, EventArgs e)
        {
            lblResult.Text = FileHelper.ReadDataFromFile();
        }
    }
}