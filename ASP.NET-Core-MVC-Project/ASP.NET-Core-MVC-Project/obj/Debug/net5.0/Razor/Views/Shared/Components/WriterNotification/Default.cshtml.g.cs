#pragma checksum "E:\source\repos\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Shared\Components\WriterNotification\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0be0fcc9adac8891b3be69cd971a8947ffa1c85e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterNotification_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterNotification/Default.cshtml")]
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
#line 1 "E:\source\repos\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\_ViewImports.cshtml"
using ASP.NET_Core_MVC_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\source\repos\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\_ViewImports.cshtml"
using ASP.NET_Core_MVC_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\source\repos\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Shared\Components\WriterNotification\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0be0fcc9adac8891b3be69cd971a8947ffa1c85e", @"/Views/Shared/Components/WriterNotification/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07b7318a9bd111c44b50cc28b4ef55f72694f262", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_WriterNotification_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Notification>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"dropdown-menu dropdown-menu-right navbar-dropdown preview-list\" aria-labelledby=\"notificationDropdown\">\r\n    <h6 class=\"p-3 mb-0\">Bildirimler</h6>\r\n");
#nullable restore
#line 5 "E:\source\repos\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Shared\Components\WriterNotification\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"dropdown-divider\"></div>\r\n    <a class=\"dropdown-item preview-item\">\r\n        <div class=\"preview-thumbnail\">\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 400, "\"", 431, 1);
#nullable restore
#line 10 "E:\source\repos\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Shared\Components\WriterNotification\Default.cshtml"
WriteAttributeValue("", 408, item.NotificationColor, 408, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <i");
            BeginWriteAttribute("class", " class=\"", 453, "\"", 489, 1);
#nullable restore
#line 11 "E:\source\repos\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Shared\Components\WriterNotification\Default.cshtml"
WriteAttributeValue("", 461, item.NotificationTypeSymbol, 461, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n            </div>\r\n        </div>\r\n        <div class=\"preview-item-content d-flex align-items-start flex-column justify-content-center\">\r\n            <h6 class=\"preview-subject font-weight-normal mb-1\">");
#nullable restore
#line 15 "E:\source\repos\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Shared\Components\WriterNotification\Default.cshtml"
                                                           Write(item.NotificationType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <p class=\"text-gray ellipsis mb-0\"> ");
#nullable restore
#line 16 "E:\source\repos\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Shared\Components\WriterNotification\Default.cshtml"
                                           Write(item.NotificationDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
        </div>
    </a>
    <div class=""dropdown-divider""></div>
    <a class=""dropdown-item preview-item"">
        <div class=""preview-thumbnail"">
            <div class=""preview-icon bg-warning"">
                <i class=""mdi mdi-settings""></i>
            </div>
        </div>
        <div class=""preview-item-content d-flex align-items-start flex-column justify-content-center"">
            <h6 class=""preview-subject font-weight-normal mb-1"">Settings</h6>
            <p class=""text-gray ellipsis mb-0""> Update dashboard </p>
        </div>
    </a>
    <div class=""dropdown-divider""></div>
    <a class=""dropdown-item preview-item"">
        <div class=""preview-thumbnail"">
            <div class=""preview-icon bg-info"">
                <i class=""mdi mdi-link-variant""></i>
            </div>
        </div>
        <div class=""preview-item-content d-flex align-items-start flex-column justify-content-center"">
            <h6 class=""preview-subject font-weight-normal mb-1"">Launch Admin</");
            WriteLiteral("h6>\r\n            <p class=\"text-gray ellipsis mb-0\"> New admin wow! </p>\r\n        </div>\r\n    </a>\r\n");
#nullable restore
#line 43 "E:\source\repos\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Shared\Components\WriterNotification\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"dropdown-divider\"></div>\r\n    <h6 class=\"p-3 mb-0 text-center\">See all notifications</h6>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Notification>> Html { get; private set; }
    }
}
#pragma warning restore 1591
