#pragma checksum "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Message\InBox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc9780f4e625f8884c05fa72c0feed8f5f70ce7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_InBox), @"mvc.1.0.view", @"/Views/Message/InBox.cshtml")]
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
#line 1 "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\_ViewImports.cshtml"
using ASP.NET_Core_MVC_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\_ViewImports.cshtml"
using ASP.NET_Core_MVC_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Message\InBox.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc9780f4e625f8884c05fa72c0feed8f5f70ce7a", @"/Views/Message/InBox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07b7318a9bd111c44b50cc28b4ef55f72694f262", @"/Views/_ViewImports.cshtml")]
    public class Views_Message_InBox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message2>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Message\InBox.cshtml"
  
    ViewData["Title"] = "InBox";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Gelen Kutusu</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Konu</th>\r\n        <th>Gönderen</th>\r\n        <th>Tarih</th>\r\n        <th>Mesajı Aç</th>      \r\n    </tr>\r\n");
#nullable restore
#line 20 "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Message\InBox.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <th>");
#nullable restore
#line 23 "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Message\InBox.cshtml"
   Write(item.MessageID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n    <td>");
#nullable restore
#line 24 "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Message\InBox.cshtml"
   Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 25 "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Message\InBox.cshtml"
   Write(item.SenderUser.WriterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 26 "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Message\InBox.cshtml"
    Write(((DateTime)item.MessageDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    \r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 596, "\"", 642, 2);
            WriteAttributeValue("", 603, "/Message/MessageDetails/", 603, 24, true);
#nullable restore
#line 28 "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Message\InBox.cshtml"
WriteAttributeValue("", 627, item.MessageID, 627, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Mesajı Aç</a></td>\r\n</tr>\r\n");
#nullable restore
#line 30 "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Message\InBox.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Blog/BlogAdd\" class=\"btn btn-primary\">Yeni Mesaj Oluştur</a>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message2>> Html { get; private set; }
    }
}
#pragma warning restore 1591
