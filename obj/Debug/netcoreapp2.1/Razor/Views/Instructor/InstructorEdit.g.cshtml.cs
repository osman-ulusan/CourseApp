#pragma checksum "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04fafc5fd74dce6826a27c48c5de50f0e38e6450"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Instructor_InstructorEdit), @"mvc.1.0.view", @"/Views/Instructor/InstructorEdit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Instructor/InstructorEdit.cshtml", typeof(AspNetCore.Views_Instructor_InstructorEdit))]
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
#line 1 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\_ViewImports.cshtml"
using CourseApp;

#line default
#line hidden
#line 2 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\_ViewImports.cshtml"
using CourseApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04fafc5fd74dce6826a27c48c5de50f0e38e6450", @"/Views/Instructor/InstructorEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad610b7d2a3848e0a114eac888a809c491062391", @"/Views/_ViewImports.cshtml")]
    public class Views_Instructor_InstructorEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Instructor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorEdit.cshtml"
   int counter = 0; 

#line default
#line hidden
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(44, 1238, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4d9114ed21c41f297d327a21bb3c8a4", async() => {
                BeginContext(82, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(88, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "642bc24c06ab4baeb804421570713017", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 5 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(124, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(130, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f2fb9595e1114c51909155c3b862393e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 6 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorEdit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(168, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 8 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorEdit.cshtml"
     foreach (var course in Model.Courses)
    {

#line default
#line hidden
                BeginContext(223, 64, true);
                WriteLiteral("        <div class=\"row my-2\">\r\n            <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 287, "\"", 314, 3);
                WriteAttributeValue("", 294, "Courses[", 294, 8, true);
#line 11 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorEdit.cshtml"
WriteAttributeValue("", 302, counter, 302, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 310, "].Id", 310, 4, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 315, "\"", 333, 1);
#line 11 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorEdit.cshtml"
WriteAttributeValue("", 323, course.Id, 323, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(334, 37, true);
                WriteLiteral(" />\r\n            <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 371, "\"", 404, 3);
                WriteAttributeValue("", 378, "Courses[", 378, 8, true);
#line 12 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorEdit.cshtml"
WriteAttributeValue("", 386, counter, 386, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 394, "].IsActive", 394, 10, true);
                EndWriteAttribute();
                BeginContext(405, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(408, 64, false);
#line 12 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorEdit.cshtml"
                                                               Write(Html.Raw(course.IsActive ? "value=\"true\"" : "value=\"false\""));

#line default
#line hidden
                EndContext();
                BeginContext(473, 58, true);
                WriteLiteral(" />\r\n            <input type=\"hidden\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 531, "\"", 560, 3);
                WriteAttributeValue("", 538, "Courses[", 538, 8, true);
#line 13 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorEdit.cshtml"
WriteAttributeValue("", 546, counter, 546, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 554, "].Name", 554, 6, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 561, "\"", 581, 1);
#line 13 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorEdit.cshtml"
WriteAttributeValue("", 569, course.Name, 569, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(582, 58, true);
                WriteLiteral(" />\r\n            <input type=\"hidden\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 640, "\"", 670, 3);
                WriteAttributeValue("", 647, "Courses[", 647, 8, true);
#line 14 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorEdit.cshtml"
WriteAttributeValue("", 655, counter, 655, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 663, "].Price", 663, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 671, "\"", 692, 1);
#line 14 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorEdit.cshtml"
WriteAttributeValue("", 679, course.Price, 679, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(693, 72, true);
                WriteLiteral(" />\r\n\r\n            <div class=\"col\">\r\n                <input type=\"text\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 765, "\"", 794, 3);
                WriteAttributeValue("", 772, "Courses[", 772, 8, true);
#line 17 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorEdit.cshtml"
WriteAttributeValue("", 780, counter, 780, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 788, "].Name", 788, 6, true);
                EndWriteAttribute();
                BeginContext(795, 111, true);
                WriteLiteral(" class=\"form-control\" />\r\n            </div>\r\n            <div class=\"col\">\r\n                <input type=\"text\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 906, "\"", 936, 3);
                WriteAttributeValue("", 913, "Courses[", 913, 8, true);
#line 20 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorEdit.cshtml"
WriteAttributeValue("", 921, counter, 921, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 929, "].Price", 929, 7, true);
                EndWriteAttribute();
                BeginContext(937, 62, true);
                WriteLiteral(" class=\"form-control\" />\r\n            </div>\r\n        </div>\r\n");
                EndContext();
#line 23 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorEdit.cshtml"

        counter++;
    }

#line default
#line hidden
                BeginContext(1028, 158, true);
                WriteLiteral("\r\n\r\n    <div class=\"row mt-2\">\r\n        <div class=\"col text-center\">\r\n            <button Type=\"submit\" class=\"btn btn-success\">Submit</button>\r\n            ");
                EndContext();
                BeginContext(1186, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9023ea4f33a4e3dbb1b9d325f8d11c1", async() => {
                    BeginContext(1232, 7, true);
                    WriteLiteral(" Cancel");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1243, 32, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1282, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Instructor> Html { get; private set; }
    }
}
#pragma warning restore 1591
