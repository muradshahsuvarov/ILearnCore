#pragma checksum "C:\University\BSC Thesis\ILearnCore\Views\User\GetApplications.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "672a4669b8f6cb7fd3486d93e105c32eec7f24d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_GetApplications), @"mvc.1.0.view", @"/Views/User/GetApplications.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\University\BSC Thesis\ILearnCore\Views\_ViewImports.cshtml"
using ILearnCoreV19;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\University\BSC Thesis\ILearnCore\Views\_ViewImports.cshtml"
using ILearnCoreV19.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\University\BSC Thesis\ILearnCore\Views\User\GetApplications.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"672a4669b8f6cb7fd3486d93e105c32eec7f24d7", @"/Views/User/GetApplications.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"907e38622cfb845b4eee5255df780c43d411cd46", @"/Views/_ViewImports.cshtml")]
    public class Views_User_GetApplications : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ILearnCoreV19.Areas.Identity.Data.ApplicationEvent>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\University\BSC Thesis\ILearnCore\Views\User\GetApplications.cshtml"
  
    ViewData["Title"] = "ListOfEvents";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"
<table class=""table"">
    <tr>
        <th>
            owner
        </th>
        <th>
            text
        </th>
        <th>
            description
        </th>
        <th>
            start_date
        </th>
        <th>
            end_date
        </th>
        <th></th>
    </tr>

");
#nullable restore
#line 36 "C:\University\BSC Thesis\ILearnCore\Views\User\GetApplications.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\University\BSC Thesis\ILearnCore\Views\User\GetApplications.cshtml"
           Write(Html.DisplayFor(modelItem => item.userId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\University\BSC Thesis\ILearnCore\Views\User\GetApplications.cshtml"
           Write(Html.DisplayFor(modelItem => item.text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\University\BSC Thesis\ILearnCore\Views\User\GetApplications.cshtml"
           Write(Html.DisplayFor(modelItem => item.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\University\BSC Thesis\ILearnCore\Views\User\GetApplications.cshtml"
           Write(Html.DisplayFor(modelItem => item.start_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\University\BSC Thesis\ILearnCore\Views\User\GetApplications.cshtml"
           Write(Html.DisplayFor(modelItem => item.end_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 55 "C:\University\BSC Thesis\ILearnCore\Views\User\GetApplications.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ILearnCoreV19.Areas.Identity.Data.ApplicationEvent>> Html { get; private set; }
    }
}
#pragma warning restore 1591
