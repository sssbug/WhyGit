#pragma checksum "D:\Github\WhyGit\Why\Why\Views\Admin\Info.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe5892b40a847f8c169074841849825c238ef0a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Info), @"mvc.1.0.view", @"/Views/Admin/Info.cshtml")]
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
#line 1 "D:\Github\WhyGit\Why\Why\Views\_ViewImports.cshtml"
using Why;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Github\WhyGit\Why\Why\Views\_ViewImports.cshtml"
using Why.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe5892b40a847f8c169074841849825c238ef0a8", @"/Views/Admin/Info.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86890f158a3ad25a31c6e6e723c3db84a2fee873", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Info : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Github\WhyGit\Why\Why\Views\Admin\Info.cshtml"
  
    ViewData["Title"] = "Info";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h6>");
#nullable restore
#line 7 "D:\Github\WhyGit\Why\Why\Views\Admin\Info.cshtml"
Write(ViewBag.userName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n<h6>");
#nullable restore
#line 8 "D:\Github\WhyGit\Why\Why\Views\Admin\Info.cshtml"
Write(ViewBag.userLast);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n<h6>");
#nullable restore
#line 9 "D:\Github\WhyGit\Why\Why\Views\Admin\Info.cshtml"
Write(ViewBag.userMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n\r\n");
#nullable restore
#line 11 "D:\Github\WhyGit\Why\Why\Views\Admin\Info.cshtml"
 if (ViewBag.userCount != null)
{
    //<a class="btn btn-dark" id="btn" asp-controller="Chat" asp-action="Index" asp-route-userEmail="@ViewBag.userMail">Chat</a>

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"hidden\" id=\"txtOtherUser\"");
            BeginWriteAttribute("value", " value=\"", 384, "\"", 409, 1);
#nullable restore
#line 14 "D:\Github\WhyGit\Why\Why\Views\Admin\Info.cshtml"
WriteAttributeValue("", 392, ViewBag.userMail, 392, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"txtUser\"");
            BeginWriteAttribute("value", " value=\"", 452, "\"", 478, 1);
#nullable restore
#line 15 "D:\Github\WhyGit\Why\Why\Views\Admin\Info.cshtml"
WriteAttributeValue("", 460, ViewBag.userCount, 460, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"txtMainUser\"");
            BeginWriteAttribute("value", " value=\"", 525, "\"", 554, 1);
#nullable restore
#line 16 "D:\Github\WhyGit\Why\Why\Views\Admin\Info.cshtml"
WriteAttributeValue("", 533, ViewBag.userMainName, 533, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"txtOtherUserName\"");
            BeginWriteAttribute("value", " value=\"", 606, "\"", 631, 1);
#nullable restore
#line 17 "D:\Github\WhyGit\Why\Why\Views\Admin\Info.cshtml"
WriteAttributeValue("", 614, ViewBag.userName, 614, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 18 "D:\Github\WhyGit\Why\Why\Views\Admin\Info.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
