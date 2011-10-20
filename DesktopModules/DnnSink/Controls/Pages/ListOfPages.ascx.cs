using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DotNetNuke.Entities.Tabs;
using DotNetNuke.Entities.Modules;

namespace DotNetNuke.Modules.DnnSink.Controls.Pages
{
    public partial class ListOfPages : PortalModuleBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListOfTopLevelPages();
        }

        public void ListOfTopLevelPages()
        {
            var tabs = TabController.GetTabsByParent(-1, PortalId);
            foreach (var t in tabs)
            {
                if (t.IsVisible)
                {
                    txtListOfPages.Text += t.TabName;
                    txtListOfPages.Text += "/n";
                }
            }
                
        }
    }
}