#pragma checksum "C:\University\BSC Thesis\ILearnCore\Views\User\OpenChat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15fa6ceb26b6a6bd7e74ec11d3bcac5dd1e47e2a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15fa6ceb26b6a6bd7e74ec11d3bcac5dd1e47e2a", @"/Views/User/OpenChat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"907e38622cfb845b4eee5255df780c43d411cd46", @"/Views/_ViewImports.cshtml")]
    public class Views_User_OpenChat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ILearnCoreV19.Areas.Identity.Data.ApplicationMessage>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-begin", new global::Microsoft.AspNetCore.Html.HtmlString("clearInputField"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-complete", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-failure", new global::Microsoft.AspNetCore.Html.HtmlString("alert(\'Fail\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-success", new global::Microsoft.AspNetCore.Html.HtmlString("sendMessage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("POST"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/signalr/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery-unobtrusive-ajax.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/chat.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signrReqHandler.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\University\BSC Thesis\ILearnCore\Views\User\OpenChat.cshtml"
  
    ViewData["Title"] = "Home Page";
    var userName = User.Identity.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"jumbotron bg-light\">\r\n    <h2 class=\"text-center text-primary\">\r\n        <i class=\"fab fa-facebook-messenger\"></i>&nbsp; Public Talk\r\n    </h2>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\" id=\"chat\">\r\n");
#nullable restore
#line 14 "C:\University\BSC Thesis\ILearnCore\Views\User\OpenChat.cshtml"
             if (Model != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\University\BSC Thesis\ILearnCore\Views\User\OpenChat.cshtml"
                 foreach (var message in Model.OrderBy(m => m.When))
                {
                    string containerClass, timePosition, textAlign, contcolor, offset;
                    if (userName == message.UserName)
                    {
                        containerClass = "container darker";
                        timePosition = "time-right text-light";
                        textAlign = "text-right text-white";
                        contcolor = "bg-primary";
                        offset = "col-md-6 offset-md-6";
                    }
                    else
                    {
                        containerClass = "container";
                        timePosition = "time-left";
                        textAlign = "text-left";
                        contcolor = "bg-light";
                        offset = "";
                    }

     

                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\University\BSC Thesis\ILearnCore\Views\User\OpenChat.cshtml"
                     if ((message.UserName == "muradshahsuvarov@gmail.com" && message.ReceiverName == "dmitrydunayev@gmail.com")
                     || (message.UserName == "dmitrydunayev@gmail.com" && message.ReceiverName == "muradshahsuvarov@gmail.com"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"row\">\r\n                            <div");
            BeginWriteAttribute("class", " class=\"", 1696, "\"", 1711, 1);
#nullable restore
#line 42 "C:\University\BSC Thesis\ILearnCore\Views\User\OpenChat.cshtml"
WriteAttributeValue("", 1704, offset, 1704, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <div");
            BeginWriteAttribute("class", " class=\"", 1751, "\"", 1785, 2);
#nullable restore
#line 43 "C:\University\BSC Thesis\ILearnCore\Views\User\OpenChat.cshtml"
WriteAttributeValue("", 1759, containerClass, 1759, 15, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\University\BSC Thesis\ILearnCore\Views\User\OpenChat.cshtml"
WriteAttributeValue(" ", 1774, contcolor, 1775, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\r\n                                    <p");
            BeginWriteAttribute("class", " class=\"", 1831, "\"", 1856, 2);
            WriteAttributeValue("", 1839, "sender", 1839, 6, true);
#nullable restore
#line 46 "C:\University\BSC Thesis\ILearnCore\Views\User\OpenChat.cshtml"
WriteAttributeValue(" ", 1845, textAlign, 1846, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 46 "C:\University\BSC Thesis\ILearnCore\Views\User\OpenChat.cshtml"
                                                            Write(message.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p");
            BeginWriteAttribute("class", " class=\"", 1919, "\"", 1937, 1);
#nullable restore
#line 47 "C:\University\BSC Thesis\ILearnCore\Views\User\OpenChat.cshtml"
WriteAttributeValue("", 1927, textAlign, 1927, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 47 "C:\University\BSC Thesis\ILearnCore\Views\User\OpenChat.cshtml"
                                                     Write(message.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <span");
            BeginWriteAttribute("class", " class=\"", 1999, "\"", 2020, 1);
#nullable restore
#line 48 "C:\University\BSC Thesis\ILearnCore\Views\User\OpenChat.cshtml"
WriteAttributeValue("", 2007, timePosition, 2007, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 48 "C:\University\BSC Thesis\ILearnCore\Views\User\OpenChat.cshtml"
                                                           Write(message.When.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 53 "C:\University\BSC Thesis\ILearnCore\Views\User\OpenChat.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\University\BSC Thesis\ILearnCore\Views\User\OpenChat.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\University\BSC Thesis\ILearnCore\Views\User\OpenChat.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n        <div class=\"col-md-12\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15fa6ceb26b6a6bd7e74ec11d3bcac5dd1e47e2a13851", async() => {
                WriteLiteral("\r\n\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15fa6ceb26b6a6bd7e74ec11d3bcac5dd1e47e2a14130", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 67 "C:\University\BSC Thesis\ILearnCore\Views\User\OpenChat.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                <div class=""form-group"">
                    <input name=""Text"" class=""form-control"" id=""messageText"" />
                </div>
                <div class=""form-group"">
                    <input type=""submit"" value=""Send"" id=""submitButton"" class=""btn"" />
                </div>
                <input type=""hidden""");
                BeginWriteAttribute("value", " value=\"", 3022, "\"", 3039, 1);
#nullable restore
#line 74 "C:\University\BSC Thesis\ILearnCore\Views\User\OpenChat.cshtml"
WriteAttributeValue("", 3030, userName, 3030, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"username\" />\r\n\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 82 "C:\University\BSC Thesis\ILearnCore\Views\User\OpenChat.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n    const userName = \"");
#nullable restore
#line 85 "C:\University\BSC Thesis\ILearnCore\Views\User\OpenChat.cshtml"
                 Write(ViewBag.CurrentUserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n    </script>\r\n");
#nullable restore
#line 87 "C:\University\BSC Thesis\ILearnCore\Views\User\OpenChat.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15fa6ceb26b6a6bd7e74ec11d3bcac5dd1e47e2a19037", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15fa6ceb26b6a6bd7e74ec11d3bcac5dd1e47e2a20137", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15fa6ceb26b6a6bd7e74ec11d3bcac5dd1e47e2a21237", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15fa6ceb26b6a6bd7e74ec11d3bcac5dd1e47e2a22338", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ILearnCoreV19.Areas.Identity.Data.ApplicationMessage>> Html { get; private set; }
    }
}
#pragma warning restore 1591
