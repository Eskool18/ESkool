#pragma checksum "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\markAttendence.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ca6be27874e9cae6758b09bfe8aac0aebd9c93e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_markAttendence), @"mvc.1.0.view", @"/Views/Teacher/markAttendence.cshtml")]
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
#line 1 "D:\fyp\ESkool\eSkool\eSkool\Views\_ViewImports.cshtml"
using eSkool;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\fyp\ESkool\eSkool\eSkool\Views\_ViewImports.cshtml"
using eSkool.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ca6be27874e9cae6758b09bfe8aac0aebd9c93e", @"/Views/Teacher/markAttendence.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bb71ca231d026605b621ec616166762e711b9ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_markAttendence : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<eSkool.Models.Student>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Teacher/uploadAttendence"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Teacher/updateAttendence"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding:20px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\markAttendence.cshtml"
  
    ViewBag.Title = "Dashboard ";
    Layout = "~/Views/Shared/_TeacherLayout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ca6be27874e9cae6758b09bfe8aac0aebd9c93e4710", async() => {
                WriteLiteral(@"
    <script>

        function showMarkTable() {
            document.getElementById(""attendence-box"").style.display = 'block'
           
        }
        function showEditTable() {
            document.getElementById(""attendence-box-edit"").style.display = 'block'
    

        }

    </script>

    <h1> Attendence Daily </h1>

    <div class=""description_box"" style=""display:flex;padding:20px"">
        <div class=""className-box"" style=""display:flex;margin:20px"">
               <p style=""font-weight:bolder;margin:15px 15px 10px 10px;font-size:25px"">Class</p>
                <div style=""border: 2px solid lightgrey; border-radius: 10px;"">
               <p style=""color: lightgrey; margin:15px 10px 0px 10px "">--");
#nullable restore
#line 30 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\markAttendence.cshtml"
                                                                    Write(ViewBag.className);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" <sup>th</sup></p>
                </div>
        </div>
        <div class=""date-box"" style=""display:flex;margin:20px;"">
            <p style=""font-weight:bolder;margin:15px 15px 10px 10px;font-size:25px"">Date</p>
            <div style=""border: 2px solid lightgrey; border-radius: 10px;"">
                <p style=""color: lightgrey;margin:15px 10px 0px 10px""> ");
#nullable restore
#line 36 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\markAttendence.cshtml"
                                                                  Write(DateTime.Today);

#line default
#line hidden
#nullable disable
                WriteLiteral(".\\/p>\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 40 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\markAttendence.cshtml"
          
            if (ViewBag.attendenceMarked)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div>\r\n                    <input type=\"button\" class=\"btn btn-danger\" value=\"Update Attendence\" id=\"edit\" onclick=\"showEditTable()\" style=\"margin:30px\"/>\r\n                </div>\r\n");
#nullable restore
#line 46 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\markAttendence.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div>\r\n                    <input type=\"button\" class=\"btn btn-info\" value=\"Mark Attendence\" id=\"Mark\" onclick=\"showMarkTable()\" />\r\n                </div>\r\n");
#nullable restore
#line 52 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\markAttendence.cshtml"
            }
        

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    </div>\r\n    <div class=\"attendence-box\" id=\"attendence-box\" style=\"display:none\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ca6be27874e9cae6758b09bfe8aac0aebd9c93e7901", async() => {
                    WriteLiteral(@"
            <table class=""table-bordered table-dark"">
                <thead class=""thead-dark"">
                    <tr>
                        <th>Roll#</th>
                        <th>Student Name</th>
                        <th>Father Name</th>
                        <th>Mark Attendence  </th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 70 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\markAttendence.cshtml"
                         foreach (var Student in Model)
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 73 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\markAttendence.cshtml"
                               Write(Student.RollNumber);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                <td> ");
#nullable restore
#line 74 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\markAttendence.cshtml"
                                Write(Student.StudentName);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 75 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\markAttendence.cshtml"
                               Write(Student.FatherName);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                <td>\r\n                                    <div");
                    BeginWriteAttribute("id", " id=\"", 2810, "\"", 2833, 1);
#nullable restore
#line 77 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\markAttendence.cshtml"
WriteAttributeValue("", 2815, Student.StudentId, 2815, 18, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                        <input type=\"radio\" class=\"custom-radio\" value=\"1\"");
                    BeginWriteAttribute("name", " name=", 2927, "", 2951, 1);
#nullable restore
#line 78 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\markAttendence.cshtml"
WriteAttributeValue("", 2933, Student.StudentId, 2933, 18, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" checked required style=\"padding:10px\"/> Present\r\n                                        <input type=\"radio\" class=\"custom-radio\" value=\"-1\"");
                    BeginWriteAttribute("name", " name=", 3092, "", 3116, 1);
#nullable restore
#line 79 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\markAttendence.cshtml"
WriteAttributeValue("", 3098, Student.StudentId, 3098, 18, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("   required style=\"padding:10px\" /> Absent\r\n                                        <input type=\"radio\" class=\"custom-radio\" value=\"0\"");
                    BeginWriteAttribute("name", " name=", 3250, "", 3274, 1);
#nullable restore
#line 80 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\markAttendence.cshtml"
WriteAttributeValue("", 3256, Student.StudentId, 3256, 18, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("  required style=\"padding:10px\"/> Leave\r\n                                    </div>\r\n                                </td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 85 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\markAttendence.cshtml"
                        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n            <input style=\"margin-top:15px\" type=\"submit\" class=\"btn btn-success\" />\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n    </div>\r\n\r\n    <div class=\"attendence-box\" id=\"attendence-box-edit\" style=\"display:none\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ca6be27874e9cae6758b09bfe8aac0aebd9c93e13476", async() => {
                    WriteLiteral(@"
            <table class=""table-bordered table-danger table-hover"">
                <thead class=""thead-dark"">
                    <tr >
                        <th>Roll#</th>
                        <th>Student Name</th>
                        <th>Father Name</th>
                        <th>Mark Attendence  </th>
                    </tr>
                </thead>
                <tbody >
");
#nullable restore
#line 109 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\markAttendence.cshtml"
                         foreach (var Student in Model)
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 112 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\markAttendence.cshtml"
                               Write(Student.RollNumber);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                <td> ");
#nullable restore
#line 113 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\markAttendence.cshtml"
                                Write(Student.StudentName);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 114 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\markAttendence.cshtml"
                               Write(Student.FatherName);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</td>\r\n                                <td>\r\n                                    <div>\r\n");
#nullable restore
#line 117 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\markAttendence.cshtml"
                                           var i = 0;
                                            foreach (var attendence in ViewBag.attendenceList)
                                            {
                                                if (Student.StudentId == attendence.StudentId)
                                                {
                                                    if (attendence.AttendenceStatus == 1)
                                                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                                        <input type=\"radio\" class=\"custom-radio\" value=\"1\"");
                    BeginWriteAttribute("name", " name=", 5198, "", 5222, 1);
#nullable restore
#line 124 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\markAttendence.cshtml"
WriteAttributeValue("", 5204, Student.StudentId, 5204, 18, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" checked required style=\"padding:10px\" /><i>Present</i>\r\n");
#nullable restore
#line 125 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\markAttendence.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                                        <input type=\"radio\" class=\"custom-radio\" value=\"1\"");
                    BeginWriteAttribute("name", " name=", 5553, "", 5577, 1);
#nullable restore
#line 128 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\markAttendence.cshtml"
WriteAttributeValue("", 5559, Student.StudentId, 5559, 18, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" required style=\"padding:10px\" /><i>Present</i>\r\n");
#nullable restore
#line 129 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\markAttendence.cshtml"
                                                    }
                                                    if (attendence.AttendenceStatus == -1)
                                                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                                        <input type=\"radio\" class=\"custom-radio\" value=\"-1\"");
                    BeginWriteAttribute("name", " name=", 5935, "", 5959, 1);
#nullable restore
#line 132 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\markAttendence.cshtml"
WriteAttributeValue("", 5941, Student.StudentId, 5941, 18, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" checked required style=\"padding:10px\" /><i>Absent</i>\r\n");
#nullable restore
#line 133 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\markAttendence.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                                        <input type=\"radio\" class=\"custom-radio\" value=\"-1\"");
                    BeginWriteAttribute("name", " name=", 6290, "", 6314, 1);
#nullable restore
#line 136 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\markAttendence.cshtml"
WriteAttributeValue("", 6296, Student.StudentId, 6296, 18, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" required style=\"padding:10px\" /><i>Absent</i>\r\n");
#nullable restore
#line 137 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\markAttendence.cshtml"
                                                    }
                                                    if (attendence.AttendenceStatus == 0)
                                                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                                        <input type=\"radio\" class=\"custom-radio\" value=\"0\"");
                    BeginWriteAttribute("name", " name=", 6669, "", 6693, 1);
#nullable restore
#line 140 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\markAttendence.cshtml"
WriteAttributeValue("", 6675, Student.StudentId, 6675, 18, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" checked required style=\"padding:10px\" /><i>Leave</i>\r\n");
#nullable restore
#line 141 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\markAttendence.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                                        <input type=\"radio\" class=\"custom-radio\" value=\"0\"");
                    BeginWriteAttribute("name", " name=", 7022, "", 7046, 1);
#nullable restore
#line 144 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\markAttendence.cshtml"
WriteAttributeValue("", 7028, Student.StudentId, 7028, 18, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" required style=\"padding:10px\" /><i>Leave</i>\r\n");
#nullable restore
#line 145 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\markAttendence.cshtml"
                                                    }
                                                    break;
                                                }
                                                i++;

                                            }
                                        

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                      \r\n                                    </div>\r\n                                </td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 157 "D:\fyp\ESkool\eSkool\eSkool\Views\Teacher\markAttendence.cshtml"
                        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n            <input type=\"submit\" style=\"margin-top:15px\" class=\"btn btn-success\" />\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<eSkool.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
