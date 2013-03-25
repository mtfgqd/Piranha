﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Piranha.Areas.Manager.Views.SiteTree
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Piranha.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.4.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/SiteTree/Edit.cshtml")]
    public partial class Edit : System.Web.Mvc.WebViewPage<Piranha.Areas.Manager.Models.SiteTreeEditModel>
    {
        public Edit()
        {
        }
        public override void Execute()
        {
DefineSection("Head", () => {

WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteAttribute("src", Tuple.Create(" src=\"", 106), Tuple.Create("\"", 184)
            
            #line 3 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 112), Tuple.Create<System.Object, System.Int32>(Url.Content("~/r.ashx/piranha/areas/manager/content/js/jquery.form.js")
            
            #line default
            #line hidden
, 112), false)
);

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteAttribute("src", Tuple.Create(" src=\"", 231), Tuple.Create("\"", 319)
            
            #line 4 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 237), Tuple.Create<System.Object, System.Int32>(Url.Content("~/r.ashx/piranha/areas/manager/content/js/jquery.regiontemplate.js")
            
            #line default
            #line hidden
, 237), false)
);

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteAttribute("src", Tuple.Create(" src=\"", 366), Tuple.Create("\"", 442)
            
            #line 5 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 372), Tuple.Create<System.Object, System.Int32>(Url.Content("~/r.ashx/piranha/areas/manager/content/js/ext/json2.js")
            
            #line default
            #line hidden
, 372), false)
);

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        /**\r\n         * This var is needed by the regiontemplate script.\r\n    " +
"     */\r\n        var templateid = \'");

            
            #line 10 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                     Write(Model.Template.Id);

            
            #line default
            #line hidden
WriteLiteral("\';\r\n    </script>\r\n");

});

DefineSection("Toolbar", () => {

WriteLiteral("\r\n");

            
            #line 14 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
Write(Html.Partial("Partial/Tabs"));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"toolbar\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n        <ul>\r\n            <li><a");

WriteLiteral(" class=\"save submit\"");

WriteLiteral(">");

            
            #line 18 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                                  Write(Piranha.Resources.Global.ToolbarSave);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 19 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
            
            
            #line default
            #line hidden
            
            #line 19 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
             if (Model.CanDelete && Model.Id != Piranha.Config.DefaultSiteTreeId) {

            
            #line default
            #line hidden
WriteLiteral("            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 948), Tuple.Create("\"", 999)
            
            #line 20 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 955), Tuple.Create<System.Object, System.Int32>(Url.Action("delete", new { id = Model.Id })
            
            #line default
            #line hidden
, 955), false)
);

WriteLiteral(" class=\"delete\"");

WriteLiteral(">");

            
            #line 20 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                                                                                 Write(Piranha.Resources.Global.ToolbarDelete);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 21 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1099), Tuple.Create("\"", 1138)
            
            #line 22 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 1106), Tuple.Create<System.Object, System.Int32>(Url.Action("index", "sitetree")
            
            #line default
            #line hidden
, 1106), false)
);

WriteLiteral(" class=\"back\"");

WriteLiteral(">");

            
            #line 22 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                                                                   Write(Piranha.Resources.Global.ToolbarBack);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1219), Tuple.Create("\"", 1268)
            
            #line 23 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
, Tuple.Create(Tuple.Create("", 1226), Tuple.Create<System.Object, System.Int32>(Url.Action("edit", new { id = Model.Id })
            
            #line default
            #line hidden
, 1226), false)
);

WriteLiteral(" class=\"refresh\"");

WriteLiteral(">");

            
            #line 23 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                                                                                Write(Piranha.Resources.Global.ToolbarReload);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n        </ul>\r\n        <div");

WriteLiteral(" class=\"clear\"");

WriteLiteral("></div>\r\n    </div>\r\n</div>\r\n");

});

            
            #line 29 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
   Html.BeginForm() ; 
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 30 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
Write(Html.HiddenFor(m => m.Id));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 31 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
Write(Html.HiddenFor(m => m.NamespaceId));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 32 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
Write(Html.HiddenFor(m => m.CanDelete));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"grid_12\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"box\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"title\"");

WriteLiteral("><h2>");

            
            #line 35 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                          Write(Piranha.Resources.Global.Information);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n        <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n            <ul");

WriteLiteral(" class=\"form\"");

WriteLiteral(">\r\n                <li>\r\n\r\n");

WriteLiteral("                    ");

            
            #line 40 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
               Write(Html.LabelFor(m => m.InternalId, Piranha.Resources.Global.InternalId));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

            
            #line 42 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 42 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                         if (Model.Id != Piranha.Config.DefaultSiteTreeId) {
                        
            
            #line default
            #line hidden
            
            #line 43 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                   Write(Html.TextBoxFor(m => m.InternalId));

            
            #line default
            #line hidden
            
            #line 43 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                                                           
                        } else {
                        
            
            #line default
            #line hidden
            
            #line 45 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                   Write(Html.TextBoxFor(m => m.InternalId, new { @disabled = true }));

            
            #line default
            #line hidden
            
            #line 45 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                                                                                     
                        
            
            #line default
            #line hidden
            
            #line 46 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                   Write(Html.HiddenFor(m => m.InternalId));

            
            #line default
            #line hidden
            
            #line 46 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                                                          
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </div>\r\n");

WriteLiteral("                    ");

            
            #line 49 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
               Write(Html.ValidationMessageFor(m => m.InternalId));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </li>\r\n                <li>\r\n");

WriteLiteral("                    ");

            
            #line 52 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
               Write(Html.LabelFor(m => m.Name, Piranha.Resources.Global.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 54 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                   Write(Html.TextBoxFor(m => m.Name));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                    ");

            
            #line 55 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
               Write(Html.ValidationMessageFor(m => m.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </li>\r\n                <li>\r\n");

WriteLiteral("                    ");

            
            #line 58 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
               Write(Html.LabelFor(m => m.Description, Piranha.Resources.Global.Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 60 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                   Write(Html.TextAreaFor(m => m.Description));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n   " +
" <div");

WriteLiteral(" class=\"box main-content content-editor\"");

WriteLiteral(">\r\n        <table>\r\n            <tr>\r\n                <td");

WriteLiteral(" class=\"tools\"");

WriteLiteral(">\r\n                    <ul>\r\n                        <li");

WriteLiteral(" class=\"btn-settings active\"");

WriteLiteral("><a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-id=\"pnl-settings\"");

WriteLiteral(">");

            
            #line 70 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                                                                                      Write(Piranha.Resources.Global.Settings);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n                        <li");

WriteLiteral(" class=\"btn-regions\"");

WriteLiteral("><a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" data-id=\"pnl-regions\"");

WriteLiteral(">");

            
            #line 71 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                                                                             Write(Piranha.Resources.Global.Regions);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n                    </ul>\r\n                </td>\r\n                <td>" +
"\r\n                    <div");

WriteLiteral(" id=\"pnl-settings\"");

WriteLiteral(" class=\"main\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"title\"");

WriteLiteral("><h2>");

            
            #line 76 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                                          Write(Piranha.Resources.Global.Settings);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n                        <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n                            <ul");

WriteLiteral(" class=\"form\"");

WriteLiteral(">\r\n                                <li>\r\n");

WriteLiteral("                                    ");

            
            #line 80 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                               Write(Html.LabelFor(m => m.HostNames, Piranha.Resources.SiteTree.HostNames));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                                        ");

            
            #line 82 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                                   Write(Html.TextBoxFor(m => m.HostNames));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                                </li>\r\n                                <l" +
"i>\r\n");

WriteLiteral("                                    ");

            
            #line 85 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                               Write(Html.LabelFor(m => m.Template.Preview, Piranha.Resources.Page.HtmlPreview));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                                        ");

            
            #line 87 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                                   Write(Html.TextAreaFor(m => m.Template.Preview, new { @rows = 6 }));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                                </li>\r\n                            </ul>\r" +
"\n                        </div>\r\n                    </div>\r\n                   " +
" <div");

WriteLiteral(" id=\"pnl-regions\"");

WriteLiteral(" class=\"main hidden\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"title\"");

WriteLiteral("><h2>");

            
            #line 93 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                                          Write(Piranha.Resources.Global.Regions);

            
            #line default
            #line hidden
WriteLiteral("</h2></div>\r\n                        <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n                            <table");

WriteLiteral(" class=\"list region-editor\"");

WriteLiteral(">\r\n                                <tbody>\r\n                                    <" +
"tr>\r\n                                        <th>");

            
            #line 98 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                                       Write(Piranha.Resources.Global.Name);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                        <th>");

            
            #line 99 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                                       Write(Piranha.Resources.Global.InternalId);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                        <th>");

            
            #line 100 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                                       Write(Piranha.Resources.Global.Type);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                        <th></th>\r\n                       " +
"             </tr>\r\n");

WriteLiteral("                                    ");

            
            #line 103 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                               Write(Html.EditorFor(m => m.Regions));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    <tr");

WriteLiteral(" class=\"dark\"");

WriteLiteral(">\r\n                                        <td");

WriteLiteral(" class=\"form\"");

WriteLiteral(">\r\n                                            <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n                                                <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"newregionName\"");

WriteLiteral(" /></div>\r\n                                        </td>\r\n                       " +
"                 <td");

WriteLiteral(" class=\"form\"");

WriteLiteral(">\r\n                                            <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n                                                <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"newregionInternalId\"");

WriteLiteral(" /></div>\r\n                                        </td>\r\n                       " +
"                 <td");

WriteLiteral(" class=\"form\"");

WriteLiteral(">\r\n                                            <div");

WriteLiteral(" class=\"input\"");

WriteLiteral(">\r\n");

WriteLiteral("                                                ");

            
            #line 115 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                                           Write(Html.DropDownList("newregionType",
                                                    new SelectList(Model.RegionTypes, "Type", "Name")));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                                        </td>\r\n                          " +
"              <td");

WriteLiteral(" class=\"buttons four\"");

WriteLiteral(">\r\n                                            <button");

WriteLiteral(" id=\"btnAddRegion\"");

WriteLiteral(" class=\"btn marg-big\"");

WriteLiteral(">");

            
            #line 119 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
                                                                                      Write(Piranha.Resources.Global.Add);

            
            #line default
            #line hidden
WriteLiteral(@"</button>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </td>
            </tr>
        </table>
    </div>
</div>
");

            
            #line 131 "..\..\Areas\Manager\Views\SiteTree\Edit.cshtml"
   Html.EndForm() ; 
            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591