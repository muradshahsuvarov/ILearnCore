#pragma checksum "C:\University\BSC Thesis\ILearnCore\Views\User\OpenChat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d98bd6b057d993a46de8aa522bc6a1d63720c039"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_OpenChat), @"mvc.1.0.view", @"/Views/User/OpenChat.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d98bd6b057d993a46de8aa522bc6a1d63720c039", @"/Views/User/OpenChat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"907e38622cfb845b4eee5255df780c43d411cd46", @"/Views/_ViewImports.cshtml")]
    public class Views_User_OpenChat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ILearnCoreV19.Areas.Identity.Data.ApplicationUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Message.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w3-left w3-circle w3-margin-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:26px; position:relative;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\University\BSC Thesis\ILearnCore\Views\User\OpenChat.cshtml"
  
    ViewData["Title"] = "Chat";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link href=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<script src=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js""></script>
<script src=""//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
<!------ Include the above in your HEAD tag ---------->


<html>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d98bd6b057d993a46de8aa522bc6a1d63720c0395110", async() => {
                WriteLiteral("\r\n\r\n    <link href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.css\" type=\"text/css\" rel=\"stylesheet\"\r\n\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d98bd6b057d993a46de8aa522bc6a1d63720c0396222", async() => {
                WriteLiteral(@"
    <div class=""container"">
        <div class=""messaging"">
            <div class=""inbox_msg"">
                <div class=""inbox_people"">
                    <div class=""headind_srch"">
                        <div class=""recent_heading"">
                            <h4>Recent</h4>
                        </div>
                        <div class=""srch_bar"">
                            <div class=""stylish-input-group"">
                                <input type=""text"" class=""search-bar"" placeholder=""Search"">
                                <span class=""input-group-addon"">
                                    <button type=""button""> <i class=""fa fa-search"" aria-hidden=""true""></i> </button>
                                </span>
                            </div>
                        </div>
                    </div>
                    <div class=""inbox_chat"">
                        <div class=""chat_list active_chat"">
                            <div class=""chat_people"">
             ");
                WriteLiteral(@"                   <div class=""chat_img""> <img src=""https://ptetutorials.com/images/user-profile.png"" alt=""sunil""> </div>
                                <div class=""chat_ib"">
                                    <h5>Sunil Rajput <span class=""chat_date"">Dec 25</span></h5>
                                    <p>
                                        Test, which is a new approach to have all solutions
                                        astrology under one roof.
                                    </p>
                                </div>
                            </div>
                        </div>
                        <div class=""chat_list"">
                            <div class=""chat_people"">
                                <div class=""chat_img""> <img src=""https://ptetutorials.com/images/user-profile.png"" alt=""sunil""> </div>
                                <div class=""chat_ib"">
                                    <h5>Sunil Rajput <span class=""chat_date"">Dec 25</span></h5>
      ");
                WriteLiteral(@"                              <p>
                                        Test, which is a new approach to have all solutions
                                        astrology under one roof.
                                    </p>
                                </div>
                            </div>
                        </div>
                        <div class=""chat_list"">
                            <div class=""chat_people"">
                                <div class=""chat_img""> <img src=""https://ptetutorials.com/images/user-profile.png"" alt=""sunil""> </div>
                                <div class=""chat_ib"">
                                    <h5>Sunil Rajput <span class=""chat_date"">Dec 25</span></h5>
                                    <p>
                                        Test, which is a new approach to have all solutions
                                        astrology under one roof.
                                    </p>
                                </div>
    ");
                WriteLiteral(@"                        </div>
                        </div>
                        <div class=""chat_list"">
                            <div class=""chat_people"">
                                <div class=""chat_img""> <img src=""https://ptetutorials.com/images/user-profile.png"" alt=""sunil""> </div>
                                <div class=""chat_ib"">
                                    <h5>Sunil Rajput <span class=""chat_date"">Dec 25</span></h5>
                                    <p>
                                        Test, which is a new approach to have all solutions
                                        astrology under one roof.
                                    </p>
                                </div>
                            </div>
                        </div>
                        <div class=""chat_list"">
                            <div class=""chat_people"">
                                <div class=""chat_img""> <img src=""https://ptetutorials.com/images/user-profile.png");
                WriteLiteral(@""" alt=""sunil""> </div>
                                <div class=""chat_ib"">
                                    <h5>Sunil Rajput <span class=""chat_date"">Dec 25</span></h5>
                                    <p>
                                        Test, which is a new approach to have all solutions
                                        astrology under one roof.
                                    </p>
                                </div>
                            </div>
                        </div>
                        <div class=""chat_list"">
                            <div class=""chat_people"">
                                <div class=""chat_img""> <img src=""https://ptetutorials.com/images/user-profile.png"" alt=""sunil""> </div>
                                <div class=""chat_ib"">
                                    <h5>Sunil Rajput <span class=""chat_date"">Dec 25</span></h5>
                                    <p>
                                        Test, which is a new appr");
                WriteLiteral(@"oach to have all solutions
                                        astrology under one roof.
                                    </p>
                                </div>
                            </div>
                        </div>
                        <div class=""chat_list"">
                            <div class=""chat_people"">
                                <div class=""chat_img""> <img src=""https://ptetutorials.com/images/user-profile.png"" alt=""sunil""> </div>
                                <div class=""chat_ib"">
                                    <h5>Sunil Rajput <span class=""chat_date"">Dec 25</span></h5>
                                    <p>
                                        Test, which is a new approach to have all solutions
                                        astrology under one roof.
                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>
        ");
                WriteLiteral(@"        </div>
                <div class=""mesgs"">
                    <div class=""msg_history"">
                        <div class=""incoming_msg"">
                            <div class=""incoming_msg_img""> <img src=""https://ptetutorials.com/images/user-profile.png"" alt=""sunil""> </div>
                            <div class=""received_msg"">
                                <div class=""received_withd_msg"">
                                    <p>
                                        Test which is a new approach to have all
                                        solutions
                                    </p>
                                    <span class=""time_date""> 11:01 AM    |    June 9</span>
                                </div>
                            </div>
                        </div>
                        <div class=""outgoing_msg"">
                            <div class=""sent_msg"">
                                <p>
                                    Test which is a ");
                WriteLiteral(@"new approach to have all
                                    solutions
                                </p>
                                <span class=""time_date""> 11:01 AM    |    June 9</span>
                            </div>
                        </div>
                        <div class=""incoming_msg"">
                            <div class=""incoming_msg_img""> <img src=""https://ptetutorials.com/images/user-profile.png"" alt=""sunil""> </div>
                            <div class=""received_msg"">
                                <div class=""received_withd_msg"">
                                    <p>Test, which is a new approach to have</p>
                                    <span class=""time_date""> 11:01 AM    |    Yesterday</span>
                                </div>
                            </div>
                        </div>
                        <div class=""outgoing_msg"">
                            <div class=""sent_msg"">
                                <p>Apollo University");
                WriteLiteral(@", Delhi, India Test</p>
                                <span class=""time_date""> 11:01 AM    |    Today</span>
                            </div>
                        </div>
                        <div class=""incoming_msg"">
                            <div class=""incoming_msg_img""> <img src=""https://ptetutorials.com/images/user-profile.png"" alt=""sunil""> </div>
                            <div class=""received_msg"">
                                <div class=""received_withd_msg"">
                                    <p>
                                        We work directly with our designers and suppliers,
                                        and sell direct to you, which means quality, exclusive
                                        products, at a price anyone can afford.
                                    </p>
                                    <span class=""time_date""> 11:01 AM    |    Today</span>
                                </div>
                            </div>
         ");
                WriteLiteral(@"               </div>
                    </div>
                    <div class=""type_msg"">
                        <div class=""input_msg_write"">
                            <input type=""text"" class=""write_msg"" placeholder=""Type a message"" />
                            <button class=""msg_send_btn"" type=""button""> ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d98bd6b057d993a46de8aa522bc6a1d63720c03916539", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</button>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ILearnCoreV19.Areas.Identity.Data.ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
