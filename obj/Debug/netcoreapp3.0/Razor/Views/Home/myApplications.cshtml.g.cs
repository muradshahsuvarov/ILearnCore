#pragma checksum "C:\Users\Murad\Desktop\University\SeventhSemester\Subjects\BSc Thesis\ILearnCoreV21 (WORKS)\ILearnCore\Views\Home\myApplications.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad0e10dc4196b63f5ecc0b3810801e206fb32d21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_myApplications), @"mvc.1.0.view", @"/Views/Home/myApplications.cshtml")]
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
#line 1 "C:\Users\Murad\Desktop\University\SeventhSemester\Subjects\BSc Thesis\ILearnCoreV21 (WORKS)\ILearnCore\Views\_ViewImports.cshtml"
using ILearnCoreV19;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Murad\Desktop\University\SeventhSemester\Subjects\BSc Thesis\ILearnCoreV21 (WORKS)\ILearnCore\Views\_ViewImports.cshtml"
using ILearnCoreV19.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad0e10dc4196b63f5ecc0b3810801e206fb32d21", @"/Views/Home/myApplications.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"907e38622cfb845b4eee5255df780c43d411cd46", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_myApplications : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Murad\Desktop\University\SeventhSemester\Subjects\BSc Thesis\ILearnCoreV21 (WORKS)\ILearnCore\Views\Home\myApplications.cshtml"
  
    ViewData["Title"] = "Applications";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
div class=""jumbotron"" style=""background-color:#00F3FF"">
<div class=""container"">
    <li>Physics - John Doe</li>
    <button type=""button"" class=""btn btn-success"" style=""width:200px"" data-toggle=""modal"" data-target=""#details-modal-1"">Details</button>
    <div class=""modal"" role=""dialog"" id=""details-modal-1"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h2>Details</h2>
                </div>
                <div class=""modal-body"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad0e10dc4196b63f5ecc0b3810801e206fb32d214340", async() => {
                WriteLiteral(@"
                        <div class=""form-group"">
                            <p>Class Name - Physics</p>
                        </div>
                        <div class=""form-group"">
                            <p>Time Table: </p>
                            <p>Monday: 8AM - 10AM</p>
                            <p>Tuesday: 8AM - 10AM</p>
                            <p>Wednesday: 8AM - 10AM</p>
                            <p>Thurday: 8AM - 10AM</p>
                            <p>Friday: 10AM - 13AM</p>
                            <p>Payment - Approved</p>
                            <p>Period: 1 month</p>
                            <p>Start Date: 2020/06/01</p>
                            <p>End Date: 2020/06/30</p>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Close</button>
                </div>
            </div>
        </div>
    </div>
</div>
</div>
<div class=""jumbotron"">
    <div class=""container"">
        <li>Calculus 2 - Rita Smidt</li>
        <button type=""button"" class=""btn btn-success"" style=""width:200px"" data-toggle=""modal"" data-target=""#details-modal-2"">Details</button>
        <div class=""modal"" role=""dialog"" id=""details-modal-2"">
            <div class=""modal-dialog"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h2>Details</h2>
                    </div>
                    <div class=""modal-body"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad0e10dc4196b63f5ecc0b3810801e206fb32d217238", async() => {
                WriteLiteral(@"
                            <div class=""form-group"">
                                <p>Class Name - Calculus 2</p>
                            </div>
                            <div class=""form-group"">
                                <p>Time Table: </p>
                                <p>Monday: 10AM - 12AM</p>
                                <p>Tuesday: 10AM - 12AM</p>
                                <p>Wednesday: 10AM - 12AM</p>
                                <p>Thurday: 10AM - 12AM</p>
                                <p>Friday: 10AM - 12AM</p>
                                <p>Payment - Approved</p>
                                <p>Period: 1 month</p>
                                <p>Start Date: 2020/06/01</p>
                                <p>End Date: 2020/06/30</p>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Close</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""jumbotron"" style=""background-color:#00F3FF"">
    <div class=""container"">
        <li>C++ - Bill Gates</li>
        <button type=""button"" class=""btn btn-success"" style=""width:200px"" data-toggle=""modal"" data-target=""#details-modal-3"">Details</button>
        <div class=""modal"" role=""dialog"" id=""details-modal-3"">
            <div class=""modal-dialog"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h2>Details</h2>
                    </div>
                    <div class=""modal-body"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad0e10dc4196b63f5ecc0b3810801e206fb32d2110267", async() => {
                WriteLiteral(@"
                            <div class=""form-group"">
                                <p>Class Name - C++</p>
                            </div>
                            <div class=""form-group"">
                                <p>Time Table: </p>
                                <p>Monday: 12AM - 14PM</p>
                                <p>Tuesday: 12AM - 14PM</p>
                                <p>Wednesday: 12AM - 14PM</p>
                                <p>Thurday: 12AM - 14PM</p>
                                <p>Friday: 12AM - 14PM</p>
                                <p>Payment - Approved</p>
                                <p>Period: 1 month</p>
                                <p>Start Date: 2020/06/01</p>
                                <p>End Date: 2020/06/30</p>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Close</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""jumbotron"">
    <div class=""container"">
        <li>Space Ship Engineering - Tony Stark</li>
        <button type=""button"" class=""btn btn-success"" style=""width:200px"" data-toggle=""modal"" data-target=""#details-modal-4"">Details</button>
        <div class=""modal"" role=""dialog"" id=""details-modal-4"">
            <div class=""modal-dialog"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h2>Edit</h2>
                    </div>
                    <div class=""modal-body"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad0e10dc4196b63f5ecc0b3810801e206fb32d2113271", async() => {
                WriteLiteral(@"
                            <div class=""form-group"">
                                <p>Class Name - Space Ship Engineering</p>
                            </div>
                            <div class=""form-group"">
                                <p>Time Table: </p>
                                <p>Monday: 14PM - 16PM</p>
                                <p>Tuesday: 14PM - 16PM</p>
                                <p>Wednesday: 14PM - 16PM</p>
                                <p>Thurday: 14PM - 16PM</p>
                                <p>Friday: 14PM - 16PM</p>
                                <p>Payment - Approved</p>
                                <p>Period: 1 month</p>
                                <p>Start Date: 2020/06/01</p>
                                <p>End Date: 2020/06/30</p>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Close</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""jumbotron"">
    <div class=""container"">
        <li>Batman - Judo - Bruce Wayne</li>
        <button type=""button"" class=""btn btn-success"" style=""width:200px"" data-toggle=""modal"" data-target=""#details-modal-5"">Details</button>
        <div class=""modal"" role=""dialog"" id=""details-modal-5"">
            <div class=""modal-dialog"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h2>Edit</h2>
                    </div>
                    <div class=""modal-body"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad0e10dc4196b63f5ecc0b3810801e206fb32d2116286", async() => {
                WriteLiteral(@"
                            <div class=""form-group"">
                                <p>Class Name - Space Ship Engineering</p>
                            </div>
                            <div class=""form-group"">
                                <p>Time Table: </p>
                                <p>Monday: 00:35AM - 03:40AM</p>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Close</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>



");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
