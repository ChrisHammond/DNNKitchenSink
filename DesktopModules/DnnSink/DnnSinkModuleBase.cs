/*
' Copyright (c) 2010 Christoc.com
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

namespace Christoc.Modules.DnnSink
{

    public class DnnSinkModuleBase : DotNetNuke.Entities.Modules.PortalModuleBase
    {
        //with this base class you can provide any custom properties and methods that all your controls can access here, you can also access all the DNN 
        // methods and properties available off of portalmodulebase such as TabId, UserId, UserInfo, etc.

        public string FolderName
        {
            get
            {
                var qs = Request.QueryString["fn"];
                if (qs != null)
                    return qs.ToString();
                return string.Empty;
            }
        }

        public string ControlName
        {
            get
            {
                var qs = Request.QueryString["cn"];
                if (qs != null)
                    return qs.ToString();
                return string.Empty;
            }
        }


    }

}
