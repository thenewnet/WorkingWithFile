using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.IO;

namespace ReadWriteXml
{
    public static class FileHelper
    {
        public static string Path { get; set; }
        public static string WriteDataToFile(Student student){
            try
            {
                var data = new XmlDocument();
                XmlElement root;
                //check if exist write file else create file
                if (File.Exists(FileHelper.Path)) 
                {
                    data.Load(Path);
                    root = data.DocumentElement;
                }else
                {
                    root = data.CreateElement("StudentsList");
                    data.AppendChild(root);
                }

                XmlElement newNode = data.CreateElement("Student");
                newNode.SetAttribute("Id", student.Id);
                newNode.SetAttribute("Name", student.Name);
                newNode.SetAttribute("Phone", student.Phone);
                newNode.SetAttribute("Mark1", student.Mark1.ToString());
                newNode.SetAttribute("Mark2", student.Mark2.ToString());

                root.AppendChild(newNode);
                data.Save(Path);
                return "Successfully";
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }

        public static string ReadDataFromFile()
        {
            var result = string.Empty;
            if (!File.Exists(Path))
            {
                return "Error: Not have students list";
            }
            else
            {
                var data = new XmlDocument();
                data.Load(Path);
                var root = data.DocumentElement;

                //get node Student
                var studentNodes = root.GetElementsByTagName("Student");
                var count = 0;
                //loop on list results
                foreach (XmlNode node in studentNodes)
                {
                    if (node.NodeType == XmlNodeType.Element)
	                {
		                count++;
                        result += count.ToString();
                        result += " Mã: " + node.Attributes["Id"].Value + "<br />";
                        result += " Tên: " + node.Attributes["Name"].Value + "<br />";
                        result += " Điện thoại: " + node.Attributes["Phone"].Value + "<br />";
                        result += " Điểm 1: " + node.Attributes["Mark1"].Value + "<br />";
                        result += " Điểm 2: " + node.Attributes["Mark2"].Value + "<br />";
	                }
                    
                }

                return result;
            }
        }
    }
}