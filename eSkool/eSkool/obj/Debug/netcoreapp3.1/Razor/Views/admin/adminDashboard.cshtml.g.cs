#pragma checksum "F:\ESkool\eSkool\eSkool\Views\admin\adminDashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "029a2e964f804131385f636d8324fe3222fa0924"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_admin_adminDashboard), @"mvc.1.0.view", @"/Views/admin/adminDashboard.cshtml")]
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
#line 1 "F:\ESkool\eSkool\eSkool\Views\_ViewImports.cshtml"
using eSkool;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\ESkool\eSkool\eSkool\Views\_ViewImports.cshtml"
using eSkool.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"029a2e964f804131385f636d8324fe3222fa0924", @"/Views/admin/adminDashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bb71ca231d026605b621ec616166762e711b9ad", @"/Views/_ViewImports.cshtml")]
    public class Views_admin_adminDashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ClassSubjectTeacher>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "teacher", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "both", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("adminDashboard"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\ESkool\eSkool\eSkool\Views\admin\adminDashboard.cshtml"
  
    ViewBag.Title = "adminDashboard";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<style>
      #complaint, #books, #leave, #announce, #complaintBox {
        width: 30%;
        padding: 1%;
        margin: 1%;
        font-size: 20px;
        text-align: center;
        color: white;
        background: rgba(0, 0, 0, 0) linear-gradient( -135deg, #4ea5bdd1 0%, #b69cc3 100%) repeat scroll 0 0;
        border-radius: 5px;
        box-shadow: 0 3px 15px 0 rgb(0 0 0 / 10%);
        float: left;
    }
    .modal {
        display: none; /* Hidden by default */
        position: fixed; /* Stay in place */
        z-index: 1; /* Sit on top */
        padding-top: 50px; /* Location of the box */
        left: 0;
        top: 0;
        width: 100%; /* Full width */
        height: 100%; /* Full height */
        border: 1px solid rgb(145 74 140);
        overflow: auto; /* Enable scroll if needed */
        background-color: rgb(0,0,0); /* Fallback color */
        background-color: rgba(0,0,0,0.4); /* Black w/ opacity */
    }
    .modal-body form {
        displa");
            WriteLiteral(@"y: flex;
        flex-direction: column;
        padding: 2%;
    }
    .modal-header {
        background-color: #7b5c9261;
        color: white;
    }
    #duration {
        display: flex;
        justify-content: space-between;
    }

        #duration input {
        
            font-size: 15px;
        }

    #total-days input {
        width: 16%;
    }
        .modal-header h3 {
            font-size: 25px;
            font-style: italic;
            font-family: serif;
        }

    .modal-body input, .modal-body textarea {
        border: none;
        background: #efefef;
        padding: 2%;
    }

        .modal-body form input[type=submit]:hover {
            box-shadow: -6px 6px 0px 0 #22a1b782;
            background: rgb(145 74 140 / 45%);
        }

        .modal-body form input[type=submit] {
            color: #ffffff;
            box-shadow: -6px 6px 0px 0 rgb(145 74 140 / 45%);
            background: #22a1b782;
        }

        .modal-bod");
            WriteLiteral(@"y form div {
            margin-bottom: 2%
        }

    .modal-content {
        background-color: #fefefe;
        margin: auto;
        box-shadow: 0 4px 8px 0 rgb(199 24 161 / 57%), 0 6px 20px 0 #448797;
        border: 1px solid #888;
        width: 50%;
    }

    .dash i {
        background: rgba(255, 255, 255, 0.4) none repeat scroll 0 0;
        border-radius: 50%;
        color: #fff;
        cursor: pointer;
        display: inline-block;
        float: right;
        font-size: 30px;
        line-height: 55px;
        text-align: center;
        width: 55px;
        margin-top: -5px;
    }

    .dash {
        display: flex;
        justify-content: space-evenly;
        flex-wrap: wrap;
      
    }


    }
    #duration label, #total-days label {
        width: 10%;
    }

    #total-days label {
        width: fit-content;
        margin: 2%;
    }
        .dash button {
            border: none;
            background: none;
            color: wh");
            WriteLiteral(@"ite;
            width: 100%;
            margin: 0;
        }

    .dash-links {
        display: flex;
        color: white;
        justify-content: space-between;
        padding: 5%;
    }
    .teachers {
        float: left;
        padding: 2% 3% 0%;
        background: #ffffff none repeat scroll 0 0;
        border-radius: 5px;
        box-shadow: 0 3px 15px 0 #b1aacc;
        width: 35%;
    }
        .teachers p {
            color: #79b1c8;
            margin-bottom: 0%;
            font-style: italic;
            font-size: 15px;
        }
        .teachers p i {
            color: #79b1c8;
            font-size: 30px;
            margin-right:5%;
        }
        .teachers span {
            background: #eeedf4;
            float: left;
            height: 7px;
            margin-top: 5%;
            position: relative;
            width: 100%;
            margin-bottom: 10%;
        }
    .teachers > span.fifty::before {
        width: ");
#nullable restore
#line 166 "F:\ESkool\eSkool\eSkool\Views\admin\adminDashboard.cshtml"
          Write(ViewBag.color);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
    }
    span.purpal:before {
        background: #a389d4;
    }
    .teachers > span::before {
        content: """";
        height: 100%;
        left: 0;
        position: absolute;
        top: 0;
        width: 100%;
        box-shadow: 0 10px 20px 0 rgb(0 0 0 / 30%);
    }
    .teacher-bar{
        display:flex;
        justify-content:space-evenly;
        margin-bottom:2%;
    }
        .dash-links:hover
    {

        background: rgba(255, 255, 255, 0.4) none repeat scroll 0 0;
        text-decoration: none;
        color:white;
    }
    #myChart {
        padding: 2% 0%;
        background: #ffffff none repeat scroll 0 0;
        border-radius: 5px;
        box-shadow: 0 3px 15px 0 #b1aacc;
    }
</style>
");
#nullable restore
#line 199 "F:\ESkool\eSkool\eSkool\Views\admin\adminDashboard.cshtml"
   
     int e = 0, u = 0, m = 0, p = 0, c = 0, b = 0, comp = 0, s = 0, pak = 0, i = 0;

     foreach (var teacher in Model)
     {
         if (teacher.SubjectName.ToUpper() == "ENGLISH")
             e++;
         else if (teacher.SubjectName.ToUpper() == "URDU")
             u++;
         else if (teacher.SubjectName.ToUpper() == "MATH")
             m++;
         else if (teacher.SubjectName.ToUpper() == "SCIENCE")
             s++;
         else if (teacher.SubjectName.ToUpper() == "PAK-STUDY")
             pak++;
         else if (teacher.SubjectName.ToUpper() == "ISLAMIAT")
             i++;
         else if (teacher.SubjectName.ToUpper() == "PHYSICS")
             p++;
         else if (teacher.SubjectName.ToUpper() == "CHEMISTRY")
             c++;
         else if (teacher.SubjectName.ToUpper() == "COMPUTER")
             comp++;
         else if (teacher.SubjectName.ToUpper() == "BIOLOGY")
             b++;

     }
     int[] yValues = { e, u, m, s, pak, i, p, c, comp, b };
     

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "029a2e964f804131385f636d8324fe3222fa092411576", async() => {
                WriteLiteral(@"

    <div class=""teacher-bar"">
        <div class=""teachers"">
            <p> <i class="" fas fa-user-cog""></i> Admin</p>
            <span class=""fifty purpal"" :before></span>

            <p> <i class=""fas fa-chalkboard-teacher""></i>Teachers</p>
            <span class=""fifty purpal""></span>

            <p><i class=""fas fa-user-graduate""></i>Students</p>
            <span class=""fifty purpal""></span>
        </div>

        <canvas id=""myChart"" style="" max-width: 55%; height: 270px; max-height: 270px;""></canvas>

    </div>
    <div class=""dash"">

        <div id=""books"">
            <a class=""dash-links"" href=""/admin/showClasses""><p>Show Classes</p> <i class=""fas fa-angle-double-down""> </i> </a>
        </div>
        <div id=""complaint"">
            <a class=""show-btn dash-links"" href=""/admin/showTeachers""><p>Show teachers</p> <i class=""fas fa-chalkboard-teacher""></i></a>
        </div>
        <div id=""complaintBox"">
            <a class=""show-btn dash-links"" href=""/admin/compl");
                WriteLiteral(@"aintBox""><p>Complaint Box</p></a>
        </div>
        <div id=""leave"">
            <a class=""show-leave dash-links"" href=""/admin/showStudents""><p>Show students</p><i class=""fas fa-user-graduate""></i></a>
        </div>

        <div id=""announce"">
            <button class=""show-btn dash-links"" onclick=""announceModal()""><p>Announce</p> <i class=""fas fa-exclamation-circle""></i> </button>
        </div>

    </div>


    <div id=""announceModal"" class=""modal"">

        <!-- Modal content -->
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h3>Post Announcements</h3>
                <button class=""leave-close"" onclick=""closeAnnounce()""> &times; </button>
");
                WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"modal-body\">\r\n\r\n              \r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "029a2e964f804131385f636d8324fe3222fa092413834", async() => {
                    WriteLiteral("\r\n                    <div>\r\n                        <label for=\"name\">Name:</label>\r\n                        <input type=\"text\" style=\" width: 40%;\" id=\"name\" name=\"name\"");
                    BeginWriteAttribute("placeholder", " placeholder=\"", 8225, "\"", 8256, 1);
#nullable restore
#line 286 "F:\ESkool\eSkool\eSkool\Views\admin\adminDashboard.cshtml"
WriteAttributeValue("", 8239, ViewBag.username, 8239, 17, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" disabled />\r\n                        <label for=\"reason\" style=\"margin-left:2%;\"> To: </label>\r\n                        <select id=\"reason\" style=\" width: 35%; padding: 2%; border: none; background: #efefef;\" name=\"reason\">\r\n                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "029a2e964f804131385f636d8324fe3222fa092414939", async() => {
                        WriteLiteral("Teacher ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "029a2e964f804131385f636d8324fe3222fa092416257", async() => {
                        WriteLiteral("Students ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "029a2e964f804131385f636d8324fe3222fa092417576", async() => {
                        WriteLiteral("Both");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"
                        </select>
                    </div>
                    <p style=""color:gray;"">Anouncement will be displayed : <br /></p>
                    <div id=""duration"">

                        <label for=""from"">From:</label>
                        <input type=""date"" id=""from"" name=""from"" onchange=""calculateDuration();"" required>
                        <label for=""to"">To:</label>
                        <input type=""date"" id=""to"" name=""to"" onchange=""calculateDuration();"" checked required>
                        <label for=""event"">Add to events </label>
                        <input type=""checkbox"" style=""height:25px; width:25px;"" id=""event"" name=""event"" />
                    </div>
                  

                    <label for=""txt""> Content : </label>
                    <input type=""text"" id=""txt"" name=""txt"" style=""height:80px; margin-bottom:2%;"" required>


                    <input type=""submit"" style="" width: 30%; margin: auto;"">
                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onload", 22, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6038, "return", 6038, 6, true);
            AddHtmlAttributeValue(" ", 6044, "openChart([", 6045, 12, true);
#nullable restore
#line 230 "F:\ESkool\eSkool\eSkool\Views\admin\adminDashboard.cshtml"
AddHtmlAttributeValue("", 6056, e, 6056, 2, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 6058, ",", 6058, 1, true);
#nullable restore
#line 230 "F:\ESkool\eSkool\eSkool\Views\admin\adminDashboard.cshtml"
AddHtmlAttributeValue(" ", 6059, u, 6060, 2, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 6062, ",", 6062, 1, true);
#nullable restore
#line 230 "F:\ESkool\eSkool\eSkool\Views\admin\adminDashboard.cshtml"
AddHtmlAttributeValue(" ", 6063, m, 6064, 2, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 6066, ",", 6066, 1, true);
#nullable restore
#line 230 "F:\ESkool\eSkool\eSkool\Views\admin\adminDashboard.cshtml"
AddHtmlAttributeValue(" ", 6067, s, 6068, 2, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 6070, ",", 6070, 1, true);
#nullable restore
#line 230 "F:\ESkool\eSkool\eSkool\Views\admin\adminDashboard.cshtml"
AddHtmlAttributeValue(" ", 6071, pak, 6072, 4, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 6076, ",", 6076, 1, true);
#nullable restore
#line 230 "F:\ESkool\eSkool\eSkool\Views\admin\adminDashboard.cshtml"
AddHtmlAttributeValue(" ", 6077, i, 6078, 2, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 6080, ",", 6080, 1, true);
#nullable restore
#line 230 "F:\ESkool\eSkool\eSkool\Views\admin\adminDashboard.cshtml"
AddHtmlAttributeValue(" ", 6081, p, 6082, 2, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 6084, ",", 6084, 1, true);
#nullable restore
#line 230 "F:\ESkool\eSkool\eSkool\Views\admin\adminDashboard.cshtml"
AddHtmlAttributeValue(" ", 6085, c, 6086, 2, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 6088, ",", 6088, 1, true);
#nullable restore
#line 230 "F:\ESkool\eSkool\eSkool\Views\admin\adminDashboard.cshtml"
AddHtmlAttributeValue(" ", 6089, comp, 6090, 5, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 6095, ",", 6095, 1, true);
#nullable restore
#line 230 "F:\ESkool\eSkool\eSkool\Views\admin\adminDashboard.cshtml"
AddHtmlAttributeValue(" ", 6096, b, 6097, 2, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 6099, "]);", 6099, 3, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ClassSubjectTeacher>> Html { get; private set; }
    }
}
#pragma warning restore 1591
