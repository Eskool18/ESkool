#pragma checksum "D:\fyp\ESkool\eSkool\eSkool\Views\admin\showClasses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b7165bb54c0c18cf9df68a56b45521c269329ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_admin_showClasses), @"mvc.1.0.view", @"/Views/admin/showClasses.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b7165bb54c0c18cf9df68a56b45521c269329ff", @"/Views/admin/showClasses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bb71ca231d026605b621ec616166762e711b9ad", @"/Views/_ViewImports.cshtml")]
    public class Views_admin_showClasses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserInfo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\fyp\ESkool\eSkool\eSkool\Views\admin\showClasses.cshtml"
  
    ViewBag.Title = "showClasses";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .class-div {
        color: whitesmoke;
        box-shadow: 0px 10px 10px 0 rgb(39 155 176 / 42%), 0 15px 30px 0 rgb(145 73 139 / 60%);
        width: 29%;
        background-color: #7b5c9261;
        margin: 2%;
    }

    .class-detail {
        text-align: center;
        width: 100%;
        padding: 5%;
    }

    .class-banner {
        width: 18%;
        color: #22a1b782;
        font-weight: bolder;
        text-align: center;
        border-left: 3px #75b1c6;
        border-left-style: outset;
        background: white;
    }

    .show-btn {
        /* font-weight: 600; */
        color: #ffffff;
        width: 90%;
        box-shadow: -6px 6px 0px 0 rgb(145 74 140 / 45%);
        font-size: 18px;
        border: none;
        padding: 2%;
        /* border: 1px solid #7b5c92d9; */
        background: #22a1b782;
    }

        .show-btn:hover {
            /*   box-shadow: 0px 20px 80px 0 rgb(38 157 178 / 62%);*/
            box-shadow: -6px 6px 0p");
            WriteLiteral(@"x 0 #22a1b782;
            background: rgb(145 74 140 / 45%);
        }


    .class-card {
        display: flex;
        height: 100%;
        flex-direction: row;
    }

    .add-class {
        text-align: center;
        width: 20%;
        height: 10%;
        background: #75b1c65c;
        border: 2px dashed #269cb2;
        padding: 5%;
        margin: 2%;
    }

        .add-class i {
            color: #22a0b6;
            font-size: 40px;
        }

    .cards-container {
        display: flex;
        flex-wrap: wrap;
        flex-direction: row;
    }

    .modal {
        display: none; /* Hidden by default */
        position: fixed; /* Stay in place */
        z-index: 1; /* Sit on top */
        padding-top: 100px; /* Location of the box */
        left: 0;
        top: 0;
        width: 100%; /* Full width */
        height: 100%; /* Full height */
        border: 1px solid rgb(145 74 140);
        overflow: auto; /* Enable scroll if needed */
     ");
            WriteLiteral(@"   background-color: rgb(0,0,0); /* Fallback color */
        background-color: rgba(0,0,0,0.4); /* Black w/ opacity */
    }

    /* Modal Content */
    .modal-content {
        background-color: #fefefe;
        margin: auto;
        box-shadow: 0 4px 8px 0 rgb(199 24 161 / 57%), 0 6px 20px 0 #448797;
        border: 1px solid #888;
        width: 50%;
    }

    /* The Close Button */
    .close {
        color: white;
        float: right;
        font-size: 30px;
        font-weight: bold;
    }

    .modal-header {
        background-color: #7b5c9261;
        color: white;
    }

        .modal-header h3 {
            font-size: 25px;
            font-style: italic;
            font-family: serif;
        }

    .close:hover,
    .close:focus {
        color: rgb(145 74 140);
        font-weight: bolder;
        text-decoration: none;
        cursor: pointer;
    }
</style>
<div class=""cards-container"">

    <div class=""class-div"">
        <div class=""class-ca");
            WriteLiteral(@"rd"">
            <div class=""class-banner"">
                <p>
                    9<br />T<br />H
                </p>
            </div>
            <div class=""class-detail"">
                <p>
                    Teacher : Ma'am Maira Malik
                </p>
                <p>
                    Students : 40
                </p>
                <button class=""show-btn"" onclick=""popModal();""> Show </button>
            </div>
        </div>
    </div>
    <div class=""class-div"">
        <div class=""class-card"">
            <div class=""class-banner"">
                <p>
                    10 <br />T<br />H
                </p>
            </div>
            <div class=""class-detail"">
                <p>
                    Teacher : Sir Ali Iftikhar
                </p>
                <p>
                    Students : 45
                </p>
                <button class=""show-btn"" onclick=""popModal();""> Show </button>
            </div>
        </div>
    </div>");
            WriteLiteral(@"
    <div class=""class-div"">
        <div class=""class-card"">
            <div class=""class-banner"">
                <p>
                    11 <br />T<br />H
                </p>
            </div>
            <div class=""class-detail"">
                <p>
                    Teacher : Sir Farooq
                </p>
                <p>
                    Students : 50
                </p>
                <button class=""show-btn"" onclick=""popModal();""> Show </button>

            </div>
        </div>
    </div>

    <div class=""add-class"">
        <a href=""/admin/addClass"">
            <i class=""fa fa-plus""></i>
        </a>
    </div>

</div>
<div id=""myModal"" class=""modal"">

    <!-- Modal content -->
    <div class=""modal-content"">
        <div class=""modal-header"">
            <h3>Class 9<sup>th </sup></h3>

            <button class=""close"" onclick=""closeModal()""> &times; </button>


        </div>
        <div class=""modal-body"">
            <p>List of Students");
            WriteLiteral(": </p>\r\n");
#nullable restore
#line 207 "D:\fyp\ESkool\eSkool\eSkool\Views\admin\showClasses.cshtml"
              
                foreach (var Student in Model)
                {
                    if (Student.Role == "S")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p id=\"s1\">");
#nullable restore
#line 212 "D:\fyp\ESkool\eSkool\eSkool\Views\admin\showClasses.cshtml"
                              Write(Student.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 213 "D:\fyp\ESkool\eSkool\eSkool\Views\admin\showClasses.cshtml"
                    }
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UserInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
