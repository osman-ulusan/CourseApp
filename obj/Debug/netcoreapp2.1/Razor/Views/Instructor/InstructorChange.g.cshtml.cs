#pragma checksum "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorChange.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f7eb625dd2442cab5e634e126b157961c71bef6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Instructor_InstructorChange), @"mvc.1.0.view", @"/Views/Instructor/InstructorChange.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Instructor/InstructorChange.cshtml", typeof(AspNetCore.Views_Instructor_InstructorChange))]
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
#line 2 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorChange.cshtml"
using CourseApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f7eb625dd2442cab5e634e126b157961c71bef6", @"/Views/Instructor/InstructorChange.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad610b7d2a3848e0a114eac888a809c491062391", @"/Views/_ViewImports.cshtml")]
    public class Views_Instructor_InstructorChange : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ValueTuple<Instructor, IEnumerable<Instructor>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Change", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorChange.cshtml"
   int counter = 0;

#line default
#line hidden
            BeginContext(107, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(109, 1585, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8234c5e80d6545e5b8b13ac1f13ffef8", async() => {
                BeginContext(149, 36, true);
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 185, "\"", 208, 1);
#line 7 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorChange.cshtml"
WriteAttributeValue("", 193, Model.Item1.Id, 193, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(209, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
#line 8 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorChange.cshtml"
     foreach (Course course in Model.Item1.Courses)
    {

#line default
#line hidden
                BeginContext(274, 28, true);
                WriteLiteral("        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 302, "\"", 329, 3);
                WriteAttributeValue("", 309, "Courses[", 309, 8, true);
#line 10 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorChange.cshtml"
WriteAttributeValue("", 317, counter, 317, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 325, "].Id", 325, 4, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 330, "\"", 348, 1);
#line 10 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorChange.cshtml"
WriteAttributeValue("", 338, course.Id, 338, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(349, 33, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 382, "\"", 411, 3);
                WriteAttributeValue("", 389, "Courses[", 389, 8, true);
#line 11 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorChange.cshtml"
WriteAttributeValue("", 397, counter, 397, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 405, "].Name", 405, 6, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 412, "\"", 432, 1);
#line 11 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorChange.cshtml"
WriteAttributeValue("", 420, course.Name, 420, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(433, 33, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 466, "\"", 496, 3);
                WriteAttributeValue("", 473, "Courses[", 473, 8, true);
#line 12 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorChange.cshtml"
WriteAttributeValue("", 481, counter, 481, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 489, "].Price", 489, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 497, "\"", 518, 1);
#line 12 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorChange.cshtml"
WriteAttributeValue("", 505, course.Price, 505, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(519, 33, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 552, "\"", 585, 3);
                WriteAttributeValue("", 559, "Courses[", 559, 8, true);
#line 13 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorChange.cshtml"
WriteAttributeValue("", 567, counter, 567, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 575, "].IsActive", 575, 10, true);
                EndWriteAttribute();
                BeginContext(586, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(589, 64, false);
#line 13 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorChange.cshtml"
                                                           Write(Html.Raw(course.IsActive ? "value=\"true\"" : "value=\"false\""));

#line default
#line hidden
                EndContext();
                BeginContext(654, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
                BeginContext(661, 61, true);
                WriteLiteral("        <div class=\"row my-1\">\r\n            <div class=\"col\">");
                EndContext();
                BeginContext(723, 11, false);
#line 16 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorChange.cshtml"
                        Write(course.Name);

#line default
#line hidden
                EndContext();
                BeginContext(734, 37, true);
                WriteLiteral("</div>\r\n            <div class=\"col\">");
                EndContext();
                BeginContext(772, 12, false);
#line 17 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorChange.cshtml"
                        Write(course.Price);

#line default
#line hidden
                EndContext();
                BeginContext(784, 62, true);
                WriteLiteral("</div>\r\n            <div class=\"col\">\r\n                <select");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 846, "\"", 883, 3);
                WriteAttributeValue("", 853, "Courses[", 853, 8, true);
#line 19 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorChange.cshtml"
WriteAttributeValue("", 861, counter, 861, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 869, "].InstructorId", 869, 14, true);
                EndWriteAttribute();
                BeginContext(884, 26, true);
                WriteLiteral(" class=\"form-control\">\r\n\r\n");
                EndContext();
#line 21 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorChange.cshtml"
                     foreach (Instructor i in Model.Item2)
                    {
                        if (course.Instructor == i)
                        {

#line default
#line hidden
                BeginContext(1073, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(1101, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4a1542ee6ba4a6abc8447e71f2aa44c", async() => {
                    BeginContext(1133, 6, false);
#line 25 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorChange.cshtml"
                                                      Write(i.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
#line 25 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorChange.cshtml"
                                        WriteLiteral(i.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1148, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 26 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorChange.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                BeginContext(1234, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(1262, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc658b54e77b46cc83bb3b8d4fe387a3", async() => {
                    BeginContext(1285, 6, false);
#line 29 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorChange.cshtml"
                                             Write(i.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 29 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorChange.cshtml"
                               WriteLiteral(i.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1300, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 30 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorChange.cshtml"
                        }
                    }

#line default
#line hidden
                BeginContext(1352, 65, true);
                WriteLiteral("\r\n                </select>\r\n            </div>\r\n        </div>\r\n");
                EndContext();
#line 36 "C:\Users\Ogle302\source\repos\CourseApp\CourseApp\Views\Instructor\InstructorChange.cshtml"
        counter++;
    }

#line default
#line hidden
                BeginContext(1444, 154, true);
                WriteLiteral("    <div class=\"row mt-2\">\r\n        <div class=\"col text-center\">\r\n            <button Type=\"submit\" class=\"btn btn-success\">Submit</button>\r\n            ");
                EndContext();
                BeginContext(1598, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bead7ee95f6a4b1f9fdf9df016d258a7", async() => {
                    BeginContext(1644, 7, true);
                    WriteLiteral(" Cancel");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1655, 32, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1694, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ValueTuple<Instructor, IEnumerable<Instructor>>> Html { get; private set; }
    }
}
#pragma warning restore 1591