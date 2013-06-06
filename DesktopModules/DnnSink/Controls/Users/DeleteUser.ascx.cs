using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DotNetNuke.Entities.Users;

namespace Christoc.Modules.DnnSink.Controls.Users
{
    public partial class DeleteUser : DnnSinkModuleBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        private void DeleteAUser(int userId)
        {

            var user = UserController.GetUserById(PortalId, userId);
            UserController.DeleteUser(ref user, false, false);
            UserController.RemoveUser(user);
        }
    }
}