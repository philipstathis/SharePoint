using System;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using System.IO;
using Microsoft.SharePoint.Administration;

namespace ApplicationPage.Layouts.ApplicationPage
{
    public partial class AddSolution : LayoutsPageBase
    {
        public static string fileName = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SafeDelete(Server.MapPath("~/") + fileName);
                fileName = null;
            }
            status.Text = null;
        }
        protected void ReUploadRFP(object sender, EventArgs e)
        {
            try
            {
                rfplabel.Visible = false;
                uploadnewrfp.Visible = false;
                SafeDelete(Server.MapPath("~/") + fileName);
                RFPFile.Visible = true;
                Uploadrfpbtn.Visible = true;
            }
            catch (Exception ex)
            {
                status.Text = ex.Message;
            }
        }
        protected void UploadRFP(object sender, EventArgs e)
        {
            try
            {
                fileName = Path.GetFileName(RFPFile.FileName);
                if (!String.Equals(fileName.Substring(fileName.LastIndexOf(".")), ".wsp", StringComparison.OrdinalIgnoreCase))
                    throw new Exception("This is not a wsp file");
                RFPFile.SaveAs(Server.MapPath("~/") + fileName);
                rfplabel.Text = fileName + " has been succesfully uploaded";
                RFPFile.Visible = false;
                Uploadrfpbtn.Visible = false;
                rfplabel.Visible = true;
                uploadnewrfp.Visible = true;
            }
            catch (Exception ex)
            {
                status.Text = ex.Message;
            }
        }
        protected void AddingSolution(object sender, EventArgs e)
        {
            try
            {
                SPSolution solutionadded = SPFarm.Local.Solutions.Add(Server.MapPath("~/") + fileName);
                SPFarm.Local.Solutions.Ensure(solutionadded);
                status.Text = fileName + " has been added to the solution store";
                SafeDelete(Server.MapPath("~/") + fileName);
            }
            catch (Exception ex)
            {
                status.Text = ex.Message;
            }
        }
        private void SafeDelete(string p)
        {
            try
            {
                File.Delete(Server.MapPath("~/") + fileName);
            }
            catch
            {
                //Nothing to Delete
            }
        }
    }
}
