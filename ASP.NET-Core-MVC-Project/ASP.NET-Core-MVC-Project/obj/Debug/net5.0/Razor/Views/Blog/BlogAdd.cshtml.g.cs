#pragma checksum "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Blog\BlogAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89a8c9f18437da4c9dfdfdded38f8a38e344cfef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogAdd), @"mvc.1.0.view", @"/Views/Blog/BlogAdd.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89a8c9f18437da4c9dfdfdded38f8a38e344cfef", @"/Views/Blog/BlogAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07b7318a9bd111c44b50cc28b4ef55f72694f262", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Blog\BlogAdd.cshtml"
  
    ViewData["Title"] = "BlogAdd";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Yeni Blog Girişi</h1>\r\n\r\n<br />\r\n\r\n");
#nullable restore
#line 11 "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Blog\BlogAdd.cshtml"
 using (Html.BeginForm("BlogAdd", "Blog", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Blog Başlığı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Blog\BlogAdd.cshtml"
Write(Html.TextBoxFor(x => x.BlogTitle, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Blog\BlogAdd.cshtml"
Write(Html.ValidationMessageFor(x => x.BlogTitle, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 17 "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Blog Görseli"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Blog\BlogAdd.cshtml"
Write(Html.TextBoxFor(x => x.BlogImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Blog\BlogAdd.cshtml"
Write(Html.ValidationMessageFor(x => x.BlogImage, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 21 "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Blog Küçük Görsel"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Blog\BlogAdd.cshtml"
Write(Html.TextBoxFor(x => x.BlogThumbNailImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Blog\BlogAdd.cshtml"
Write(Html.ValidationMessageFor(x => x.BlogThumbNailImage, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 25 "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Blog Kategori"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Blog\BlogAdd.cshtml"
Write(Html.DropDownListFor(x=>x.CategoryId,(List<SelectListItem>)ViewBag.cv,new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 28 "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Blog\BlogAdd.cshtml"
Write(Html.Label("Blog İçeriği"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Blog\BlogAdd.cshtml"
Write(Html.TextAreaFor(x => x.BlogContent,10,3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Blog\BlogAdd.cshtml"
Write(Html.ValidationMessageFor(x => x.BlogContent, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-info\"> Postu Kaydet</button>\r\n");
#nullable restore
#line 33 "C:\Users\Onur\OneDrive\Belgeler\GitHub\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\ASP.NET-Core-MVC-Project\Views\Blog\BlogAdd.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591