using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PassGenWithCS;
using System.IO;
using System.Data;

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


            //if (FileUpload1.HasFile)
            //{
            //    string fileName = FileUpload1.FileName;
            //    FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Data/") + fileName);
            //}

            if (fileEx.ToLower() != ".txt" && fileEx != ".Encrypt")
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
                    if((txt_check.Text.ToLower()=="e"|| txt_check.Text.ToLower() == "d") && txt_code.Text != "")
                    {
                        file_up.PostedFile.SaveAs(Server.MapPath("~/Data/") + file_up.FileName);
                        string str = File.ReadAllText(Server.MapPath("~/Data/") + file_up.FileName);
                        CheckEn ce = new CheckEn(str, txt_code.Text, txt_check.Text);
                        string stren = ce.StartEn();
                        string fileout = "";
                        if (txt_check.Text.ToLower() == "e"|| txt_check.Text.ToLower() == "encrypt")
                        {
                            //fileout = "Encrypt" + file_up.FileName;
                            fileout = file_up.FileName.Replace("txt", "Encrypt");
                            File.WriteAllText(Server.MapPath("~/Data/") + fileout , stren);
                            lb_download.Text = fileout;
                        }
                        else if (txt_check.Text.ToLower() == "d" || txt_check.Text.ToLower() == "decrypt")
                        {
                            fileout = file_up.FileName.Replace("Encrypt", "txt");
                            File.WriteAllText(Server.MapPath("~/Data/") + fileout, stren);
                            lb_download.Text = fileout;
                        }

                        lblMessage.ForeColor = System.Drawing.Color.Green;
                        lblMessage.Text = "Success";
                        txt_view.Text = File.ReadAllText(Server.MapPath("~/Data/") + fileout);
                        File.Delete(Server.MapPath("~/Data/") + file_up.FileName);
                        bt_download.Enabled = true;

                       
                    }
                    else
                    {
                        lblMessage.ForeColor = System.Drawing.Color.Red;
                        lblMessage.Text = "Please enter Mode and Order";
                    }
                    
                }
            }


            

            

        }



        protected void bt_download_Click(object sender, EventArgs e)
        {
            bt_download.Enabled = false;
            

            Response.Clear();
            Response.ContentType = "application/octet-stream";
            Response.AppendHeader("Content-Disposition", "filename=" + lb_download.Text);
            Response.AddHeader("Content-Length", "2097152");
            Response.TransmitFile(Server.MapPath("~/Data/") + lb_download.Text);
            Response.End();

            //bt_download.Enabled = false;
            //File.Delete(Server.MapPath("~/Data/") + lb_download.Text);
        }

        
    }
}