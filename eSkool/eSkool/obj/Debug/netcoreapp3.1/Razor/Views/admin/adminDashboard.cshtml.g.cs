#pragma checksum "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\admin\adminDashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdd4534c47113eeb8626b10a02fde84319c4bd22"
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
#line 1 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\_ViewImports.cshtml"
using eSkool;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\_ViewImports.cshtml"
using eSkool.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdd4534c47113eeb8626b10a02fde84319c4bd22", @"/Views/admin/adminDashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bb71ca231d026605b621ec616166762e711b9ad", @"/Views/_ViewImports.cshtml")]
    public class Views_admin_adminDashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ClassSubjectTeacher>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\admin\adminDashboard.cshtml"
  
    ViewBag.Title = "adminDashboard";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<style>
      #complaint, #books, #leave {
        width: 30%;
        padding: 4%;
        font-size: 20px;
        text-align: center;
        color: white;
        background: rgba(0, 0, 0, 0) linear-gradient( -135deg, #4ea5bdd1 0%, #b69cc3 100%) repeat scroll 0 0;
        border-radius: 5px;
        box-shadow: 0 3px 15px 0 rgb(0 0 0 / 10%);
        float: left;
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
    }

        .dash button {
            border: none;
            background: none;
            color: white;
            width: 100%;
            margin: 0;
        }

    .dash-links");
            WriteLiteral(@" {
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
#line 83 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\admin\adminDashboard.cshtml"
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
#line 116 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\admin\adminDashboard.cshtml"
   
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdd4534c47113eeb8626b10a02fde84319c4bd227493", async() => {
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
        <div id=""leave"">
            <a class=""show-leave dash-links"" href=""/admin/showStuden");
                WriteLiteral("ts\"><p>Show students</p><i class=\"fas fa-user-graduate\"></i></a>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onload", 22, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3906, "return", 3906, 6, true);
            AddHtmlAttributeValue(" ", 3912, "openChart([", 3913, 12, true);
#nullable restore
#line 147 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\admin\adminDashboard.cshtml"
AddHtmlAttributeValue("", 3924, e, 3924, 2, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3926, ",", 3926, 1, true);
#nullable restore
#line 147 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\admin\adminDashboard.cshtml"
AddHtmlAttributeValue(" ", 3927, u, 3928, 2, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3930, ",", 3930, 1, true);
#nullable restore
#line 147 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\admin\adminDashboard.cshtml"
AddHtmlAttributeValue(" ", 3931, m, 3932, 2, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3934, ",", 3934, 1, true);
#nullable restore
#line 147 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\admin\adminDashboard.cshtml"
AddHtmlAttributeValue(" ", 3935, s, 3936, 2, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3938, ",", 3938, 1, true);
#nullable restore
#line 147 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\admin\adminDashboard.cshtml"
AddHtmlAttributeValue(" ", 3939, pak, 3940, 4, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3944, ",", 3944, 1, true);
#nullable restore
#line 147 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\admin\adminDashboard.cshtml"
AddHtmlAttributeValue(" ", 3945, i, 3946, 2, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3948, ",", 3948, 1, true);
#nullable restore
#line 147 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\admin\adminDashboard.cshtml"
AddHtmlAttributeValue(" ", 3949, p, 3950, 2, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3952, ",", 3952, 1, true);
#nullable restore
#line 147 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\admin\adminDashboard.cshtml"
AddHtmlAttributeValue(" ", 3953, c, 3954, 2, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3956, ",", 3956, 1, true);
#nullable restore
#line 147 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\admin\adminDashboard.cshtml"
AddHtmlAttributeValue(" ", 3957, comp, 3958, 5, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3963, ",", 3963, 1, true);
#nullable restore
#line 147 "F:\Desktop\Sem 7\Fyp\eSkool\eSkool\Views\admin\adminDashboard.cshtml"
AddHtmlAttributeValue(" ", 3964, b, 3965, 2, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3967, "]);", 3967, 3, true);
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
