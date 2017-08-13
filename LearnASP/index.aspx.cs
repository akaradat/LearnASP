using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PassGenWithCS;
using System.IO;

namespace LearnASP
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bt_summit_Click(object sender, EventArgs e)
        {

            string fileEx = Path.GetExtension(file_up.FileName);

            if(fileEx.ToLower() != ".txt")
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Only files with .txt";
            }
            else
            {
                int size = file_up.PostedFile.ContentLength;
                if (size > 2097152)
                {
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                    lblMessage.Text = "File size cannot be greater than 2 MB";
                }
                else
                {
                    if(txt_check.Text!="" && txt_code.Text != "")
                    {
                        file_up.SaveAs(@"D:\Programming\C#\Upload\" + file_up.FileName);
                        string str = File.ReadAllText(@"d:\programming\C#\Upload\" + file_up.FileName);
                        CheckEn ce = new CheckEn(str, txt_code.Text, txt_check.Text);
                        string stren = ce.StartEn();
                        File.WriteAllText(@"d:\programming\c#\out.txt", stren);
                        lblMessage.ForeColor = System.Drawing.Color.Green;
                        lblMessage.Text = "Success";
                    }
                    else
                    {
                        lblMessage.ForeColor = System.Drawing.Color.Red;
                        lblMessage.Text = "Please enter Mode and Order";
                    }
                    
                }
            }


            

            

        }

        
    }
}