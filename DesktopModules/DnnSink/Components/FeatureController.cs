/*
' Copyright (c) 2011 Christoc.com
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

using System.Collections.Generic;
//using System.Xml;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Services.Search;

namespace Christoc.Modules.DnnSink.Components
{

    /// -----------------------------------------------------------------------------
    /// <summary>
    /// The Controller class for DnnSink
    /// </summary>
    /// -----------------------------------------------------------------------------

    //uncomment the interfaces to add the support.
    public class FeatureController //: IPortable, ISearchable, IUpgradeable
    {


        #region Optional Interfaces

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// ExportModule implements the IPortable ExportModule Interface
        /// </summary>
        /// <param name="ModuleID">The Id of the module to be exported</param>
        /// -----------------------------------------------------------------------------
        public string ExportModule(int ModuleID)
        {
            //string strXML = "";

            //List<DnnSinkInfo> colDnnSinks = GetDnnSinks(ModuleID);
            //if (colDnnSinks.Count != 0)
            //{
            //    strXML += "<DnnSinks>";

            //    foreach (DnnSinkInfo objDnnSink in colDnnSinks)
            //    {
            //        strXML += "<DnnSink>";
            //        strXML += "<content>" + DotNetNuke.Common.Utilities.XmlUtils.XMLEncode(objDnnSink.Content) + "</content>";
            //        strXML += "</DnnSink>";
            //    }
            //    strXML += "</DnnSinks>";
            //}

            //return strXML;

            throw new System.NotImplementedException("The method or operation is not implemented.");
        }

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// ImportModule implements the IPortable ImportModule Interface
        /// </summary>
        /// <param name="ModuleID">The Id of the module to be imported</param>
        /// <param name="Content">The content to be imported</param>
        /// <param name="Version">The version of the module to be imported</param>
        /// <param name="UserId">The Id of the user performing the import</param>
        /// -----------------------------------------------------------------------------
        public void ImportModule(int ModuleID, string Content, string Version, int UserID)
        {
            //XmlNode xmlDnnSinks = DotNetNuke.Common.Globals.GetContent(Content, "DnnSinks");
            //foreach (XmlNode xmlDnnSink in xmlDnnSinks.SelectNodes("DnnSink"))
            //{
            //    DnnSinkInfo objDnnSink = new DnnSinkInfo();
            //    objDnnSink.ModuleId = ModuleID;
            //    objDnnSink.Content = xmlDnnSink.SelectSingleNode("content").InnerText;
            //    objDnnSink.CreatedByUser = UserID;
            //    AddDnnSink(objDnnSink);
            //}

            throw new System.NotImplementedException("The method or operation is not implemented.");
        }

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// GetSearchItems implements the ISearchable Interface
        /// </summary>
        /// <param name="ModInfo">The ModuleInfo for the module to be Indexed</param>
        /// -----------------------------------------------------------------------------
        public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        {
            //SearchItemInfoCollection SearchItemCollection = new SearchItemInfoCollection();

            //List<DnnSinkInfo> colDnnSinks = GetDnnSinks(ModInfo.ModuleID);

            //foreach (DnnSinkInfo objDnnSink in colDnnSinks)
            //{
            //    SearchItemInfo SearchItem = new SearchItemInfo(ModInfo.ModuleTitle, objDnnSink.Content, objDnnSink.CreatedByUser, objDnnSink.CreatedDate, ModInfo.ModuleID, objDnnSink.ItemId.ToString(), objDnnSink.Content, "ItemId=" + objDnnSink.ItemId.ToString());
            //    SearchItemCollection.Add(SearchItem);
            //}

            //return SearchItemCollection;

            throw new System.NotImplementedException("The method or operation is not implemented.");
        }

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// UpgradeModule implements the IUpgradeable Interface
        /// </summary>
        /// <param name="Version">The current version of the module</param>
        /// -----------------------------------------------------------------------------
        public string UpgradeModule(string Version)
        {
            throw new System.NotImplementedException("The method or operation is not implemented.");
        }

        #endregion

    }

}
