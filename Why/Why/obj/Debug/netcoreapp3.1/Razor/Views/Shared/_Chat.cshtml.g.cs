#pragma checksum "D:\GitHub\WhyGit\Why\Why\Views\Shared\_Chat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "777ae1bc4529e7b28feef0f31c7155e3404d8c37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Chat), @"mvc.1.0.view", @"/Views/Shared/_Chat.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"777ae1bc4529e7b28feef0f31c7155e3404d8c37", @"/Views/Shared/_Chat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86890f158a3ad25a31c6e6e723c3db84a2fee873", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Chat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/css/chat.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "777ae1bc4529e7b28feef0f31c7155e3404d8c374107", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"initial-scale=1, maximum-scale=1, user-scalable=no, width=device-width\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "777ae1bc4529e7b28feef0f31c7155e3404d8c374516", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 5 "D:\GitHub\WhyGit\Why\Why\Views\Shared\_Chat.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "777ae1bc4529e7b28feef0f31c7155e3404d8c377224", async() => {
                WriteLiteral("\r\n\r\n    <div id=\"frame\">\r\n        <div id=\"sidepanel\">\r\n            \r\n            <div id=\"search\">\r\n                <label");
                BeginWriteAttribute("for", " for=\"", 374, "\"", 380, 0);
                EndWriteAttribute();
                WriteLiteral(@"><i class=""fa fa-search"" aria-hidden=""true""></i></label>
                <input type=""text"" placeholder=""Search contacts..."" />
            </div>
            <div id=""contacts"">
                <ul>
                    <li class=""contact"">
                        <div class=""wrap"">
                            <span class=""contact-status online""></span>
                            <img src=""http://emilcarlsson.se/assets/louislitt.png""");
                BeginWriteAttribute("alt", " alt=\"", 827, "\"", 833, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                            <div class=""meta"">
                                <p class=""name"">Louis Litt</p>
                                <p class=""preview"">You just got LITT up, Mike.</p>
                            </div>
                        </div>
                    </li>
                    <li class=""contact active"">
                        <div class=""wrap"">
                            <span class=""contact-status busy""></span>
                            <img src=""http://emilcarlsson.se/assets/harveyspecter.png""");
                BeginWriteAttribute("alt", " alt=\"", 1380, "\"", 1386, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                            <div class=""meta"">
                                <p class=""name"">Harvey Specter</p>
                                <p class=""preview"">Wrong. You take the gun, or you pull out a bigger one. Or, you call their bluff. Or, you do any one of a hundred and forty six other things.</p>
                            </div>
                        </div>
                    </li>
                    <li class=""contact"">
                        <div class=""wrap"">
                            <span class=""contact-status away""></span>
                            <img src=""http://emilcarlsson.se/assets/rachelzane.png""");
                BeginWriteAttribute("alt", " alt=\"", 2040, "\"", 2046, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                            <div class=""meta"">
                                <p class=""name"">Rachel Zane</p>
                                <p class=""preview"">I was thinking that we could have chicken tonight, sounds good?</p>
                            </div>
                        </div>
                    </li>
                    <li class=""contact"">
                        <div class=""wrap"">
                            <span class=""contact-status online""></span>
                            <img src=""http://emilcarlsson.se/assets/donnapaulsen.png""");
                BeginWriteAttribute("alt", " alt=\"", 2624, "\"", 2630, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                            <div class=""meta"">
                                <p class=""name"">Donna Paulsen</p>
                                <p class=""preview"">Mike, I know everything! I'm Donna..</p>
                            </div>
                        </div>
                    </li>
                    <li class=""contact"">
                        <div class=""wrap"">
                            <span class=""contact-status busy""></span>
                            <img src=""http://emilcarlsson.se/assets/jessicapearson.png""");
                BeginWriteAttribute("alt", " alt=\"", 3183, "\"", 3189, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                            <div class=""meta"">
                                <p class=""name"">Jessica Pearson</p>
                                <p class=""preview"">Have you finished the draft on the Hinsenburg deal?</p>
                            </div>
                        </div>
                    </li>
                    <li class=""contact"">
                        <div class=""wrap"">
                            <span class=""contact-status""></span>
                            <img src=""http://emilcarlsson.se/assets/haroldgunderson.png""");
                BeginWriteAttribute("alt", " alt=\"", 3755, "\"", 3761, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                            <div class=""meta"">
                                <p class=""name"">Harold Gunderson</p>
                                <p class=""preview"">Thanks Mike! :)</p>
                            </div>
                        </div>
                    </li>
                    <li class=""contact"">
                        <div class=""wrap"">
                            <span class=""contact-status""></span>
                            <img src=""http://emilcarlsson.se/assets/danielhardman.png""");
                BeginWriteAttribute("alt", " alt=\"", 4290, "\"", 4296, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                            <div class=""meta"">
                                <p class=""name"">Daniel Hardman</p>
                                <p class=""preview"">We'll meet again, Mike. Tell Jessica I said 'Hi'.</p>
                            </div>
                        </div>
                    </li>
                    <li class=""contact"">
                        <div class=""wrap"">
                            <span class=""contact-status busy""></span>
                            <img src=""http://emilcarlsson.se/assets/katrinabennett.png""");
                BeginWriteAttribute("alt", " alt=\"", 4863, "\"", 4869, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                            <div class=""meta"">
                                <p class=""name"">Katrina Bennett</p>
                                <p class=""preview"">I've sent you the files for the Garrett trial.</p>
                            </div>
                        </div>
                    </li>
                    <li class=""contact"">
                        <div class=""wrap"">
                            <span class=""contact-status""></span>
                            <img src=""http://emilcarlsson.se/assets/charlesforstman.png""");
                BeginWriteAttribute("alt", " alt=\"", 5430, "\"", 5436, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                            <div class=""meta"">
                                <p class=""name"">Charles Forstman</p>
                                <p class=""preview"">Mike, this isn't over.</p>
                            </div>
                        </div>
                    </li>
                    <li class=""contact"">
                        <div class=""wrap"">
                            <span class=""contact-status""></span>
                            <img src=""http://emilcarlsson.se/assets/jonathansidwell.png""");
                BeginWriteAttribute("alt", " alt=\"", 5974, "\"", 5980, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                            <div class=""meta"">
                                <p class=""name"">Jonathan Sidwell</p>
                                <p class=""preview""><span>You:</span> That's bullshit. This deal is solid.</p>
                            </div>
                        </div>
                    </li>
                </ul>
            </div>
            <div id=""bottom-bar"">
                <button id=""addcontact""><i class=""fa fa-user-plus fa-fw"" aria-hidden=""true""></i> <span>Add contact</span></button>
                <button id=""settings""><i class=""fa fa-cog fa-fw"" aria-hidden=""true""></i> <span>Settings</span></button>
            </div>
        </div>
        <div class=""content"">
            <div class=""contact-profile"">
                <img src=""http://emilcarlsson.se/assets/harveyspecter.png""");
                BeginWriteAttribute("alt", " alt=\"", 6825, "\"", 6831, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                <p>Harvey Specter</p>
                <div class=""social-media"">
                    <i class=""fa fa-facebook"" aria-hidden=""true""></i>
                    <i class=""fa fa-twitter"" aria-hidden=""true""></i>
                    <i class=""fa fa-instagram"" aria-hidden=""true""></i>
                </div>
            </div>
            <div class=""messages"">
                <ul>
                    <li class=""sent"">
                        <img src=""http://emilcarlsson.se/assets/mikeross.png""");
                BeginWriteAttribute("alt", " alt=\"", 7351, "\"", 7357, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        <p>How the hell am I supposed to get a jury to believe you when I am not even sure that I do?!</p>
                    </li>
                    <li class=""replies"">
                        <img src=""http://emilcarlsson.se/assets/harveyspecter.png""");
                BeginWriteAttribute("alt", " alt=\"", 7638, "\"", 7644, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        <p>When you're backed against the wall, break the god damn thing down.</p>
                    </li>
                    <li class=""replies"">
                        <img src=""http://emilcarlsson.se/assets/harveyspecter.png""");
                BeginWriteAttribute("alt", " alt=\"", 7901, "\"", 7907, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <p>Excuses don\'t win championships.</p>\r\n                    </li>\r\n                    <li class=\"sent\">\r\n                        <img src=\"http://emilcarlsson.se/assets/mikeross.png\"");
                BeginWriteAttribute("alt", " alt=\"", 8121, "\"", 8127, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <p>Oh yeah, did Michael Jordan tell you that?</p>\r\n                    </li>\r\n                    <li class=\"replies\">\r\n                        <img src=\"http://emilcarlsson.se/assets/harveyspecter.png\"");
                BeginWriteAttribute("alt", " alt=\"", 8359, "\"", 8365, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <p>No, I told him that.</p>\r\n                    </li>\r\n                    <li class=\"replies\">\r\n                        <img src=\"http://emilcarlsson.se/assets/harveyspecter.png\"");
                BeginWriteAttribute("alt", " alt=\"", 8575, "\"", 8581, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <p>What are your choices when someone puts a gun to your head?</p>\r\n                    </li>\r\n                    <li class=\"sent\">\r\n                        <img src=\"http://emilcarlsson.se/assets/mikeross.png\"");
                BeginWriteAttribute("alt", " alt=\"", 8822, "\"", 8828, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        <p>What are you talking about? You do what they say or they shoot you.</p>
                    </li>
                    <li class=""replies"">
                        <img src=""http://emilcarlsson.se/assets/harveyspecter.png""");
                BeginWriteAttribute("alt", " alt=\"", 9085, "\"", 9091, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        <p>Wrong. You take the gun, or you pull out a bigger one. Or, you call their bluff. Or, you do any one of a hundred and forty six other things.</p>
                    </li>
                </ul>
            </div>
            <div class=""message-input"">
                <div class=""wrap"">
                    <input type=""text"" placeholder=""Write your message..."" />
                    <i class=""fa fa-paperclip attachment"" aria-hidden=""true""></i>
                    <button class=""submit""><i class=""fa fa-paper-plane"" aria-hidden=""true""></i></button>
                </div>
            </div>
        </div>
    </div>
    ");
#nullable restore
#line 182 "D:\GitHub\WhyGit\Why\Why\Views\Shared\_Chat.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <script src=\"/js/Chat.js\"></script>\r\n\r\n    ");
#nullable restore
#line 185 "D:\GitHub\WhyGit\Why\Why\Views\Shared\_Chat.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
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
