#pragma checksum "D:\GitHub\WhyGit\Why\Why\Views\Chat\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7628065cdc2c92a8436bba1f889b1cef76228eb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chat_Index), @"mvc.1.0.view", @"/Views/Chat/Index.cshtml")]
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
#line 1 "D:\GitHub\WhyGit\Why\Why\Views\_ViewImports.cshtml"
using Why;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub\WhyGit\Why\Why\Views\_ViewImports.cshtml"
using Why.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7628065cdc2c92a8436bba1f889b1cef76228eb8", @"/Views/Chat/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86890f158a3ad25a31c6e6e723c3db84a2fee873", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Chat_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\GitHub\WhyGit\Why\Why\Views\Chat\Index.cshtml"
  
    ViewData["Title"] = "Chat";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\" style=\"padding-top:80px\">\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col-md-6\">\r\n            \r\n            <input type=\"hidden\" id=\"txtOtherUser\"");
            BeginWriteAttribute("value", " value=\"", 259, "\"", 291, 1);
#nullable restore
#line 11 "D:\GitHub\WhyGit\Why\Why\Views\Chat\Index.cshtml"
WriteAttributeValue("", 267, ViewBag.chatSecondUsers, 267, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <input type=\"hidden\" id=\"txtFirstUser\"");
            BeginWriteAttribute("value", " value=\"", 347, "\"", 373, 1);
#nullable restore
#line 12 "D:\GitHub\WhyGit\Why\Why\Views\Chat\Index.cshtml"
WriteAttributeValue("", 355, ViewBag.userCount, 355, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <input type=\"hidden\" id=\"txtUser\"");
            BeginWriteAttribute("value", " value=\"", 424, "\"", 453, 1);
#nullable restore
#line 13 "D:\GitHub\WhyGit\Why\Why\Views\Chat\Index.cshtml"
WriteAttributeValue("", 432, ViewBag.UserIdentity, 432, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" /><br />
            <span>Enter Your Message</span><br />
            <textarea rows=""10"" cols=""50"" id=""txtMessage""></textarea><br />
            <button type=""submit"" id=""btnSend"" class=""btn btn-info"">Send Message</button>
        </div>

        <div class=""col-md-6"">
            <h3>Message list</h3>
            <ul id=""list"" class=""alert alert-info"">
            </ul>
        </div>

    </div>
</div>

<script src=""/lib/jquery/dist/jquery.js""></script>
<script src=""/lib/jquery/dist/jquery.min.js""></script>

<script src=""/js/signalr/dist/browser/signalr.js""></script>
<script type=""text/javascript"">






</script>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        //var connection = new signalR.HubConnectionBuilder().withUrl(""/chatHub"").build();

        //connection.on(""ReceiveMessage"", function(fromUser, message) {
        //    var msg = fromUser + "": "" + message;
        //    var li = document.createElement(""li"");
        //    li.textContent = msg;
        //    $(""#list"").prepend(li);

        //});



        $(""#btnSend"").click(x => {
            var OtherUser = $(""#txtOtherUser"").val();
            var FirstUser = $(""#txtFirstUser"").val();
            var fromUser = $(""#txtUser"").val();
            var Userss = FirstUser + OtherUser;
            var message = $(""#txtMessage"").val();

            var msg = fromUser + "": "" + message;
            var li = document.createElement(""li"");
            li.textContent = msg;
            $(""#list"").prepend(li);

            let mess = $(""#txtMessage"").val();
            $.ajax({
                contentType: ""application/json"",
                dataType: ""json"",
        ");
                WriteLiteral(@"        type: ""get"",
                url: ""/Chat/ChatCounter/"",
                data: { msg: mess,Users: Userss, first: FirstUser, second: OtherUser},
                success: function(func) {
                    console.log(func);
                }

            });


        });

    </script>
    ");
            }
            );
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
