using System;
using System.Collections;
using Microsoft.SharePoint;
using Microsoft.SharePoint.UserCode;
using System.Runtime.InteropServices;

namespace SPDCustomWorkflowActions
{
    [Guid("3193f9d9-0aef-4770-866e-b2a7eb9e6945")]
    public class CreateSiteAction
    {
        public static Hashtable CreateSite(SPUserCodeWorkflowContext context, string siteName)
        {
            Hashtable results = new Hashtable();
            try
            {
                using (SPSite site = new SPSite(context.SiteUrl))
                {
                    SPWeb web = site.OpenWeb(context.WebUrl);
                        web.Webs.Add(
                            siteName,
                            "Trip Report: " + siteName,
                            string.Empty,
                            1033,
                            "STS",
                            false,
                            false);
                }
                //results["success"] = true;
                results["exception"] = string.Empty;
            }
            catch (Exception e)
            {
                results = new Hashtable();
                results["exception"] = e.Message;
                //results["success"] = false;
            }

            return results;
        }
    }
}
