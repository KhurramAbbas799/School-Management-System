#pragma checksum "C:\Users\Haier\Desktop\asp.net core mvc\SchoolManagementSystem\Views\Student\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b6d7c60076f8b3895e65ac0520659641a392357"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_List), @"mvc.1.0.view", @"/Views/Student/List.cshtml")]
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
#line 1 "C:\Users\Haier\Desktop\asp.net core mvc\SchoolManagementSystem\Views\_ViewImports.cshtml"
using SchoolManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Haier\Desktop\asp.net core mvc\SchoolManagementSystem\Views\_ViewImports.cshtml"
using SchoolManagementSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b6d7c60076f8b3895e65ac0520659641a392357", @"/Views/Student/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7d07f01e3c07cc979b1fe4cd526aeaff34bec21", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SchoolManagementSystem.Models.Student>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Haier\Desktop\asp.net core mvc\SchoolManagementSystem\Views\Student\List.cshtml"
  
	ViewData["Title"] = "List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table>\r\n\r\n\t<tr>\r\n\r\n\t\t<th>Id</th>\r\n\t\t<th>Name</th>\r\n\t\t<th>Age</th>\r\n        <th>Email</th>\r\n\t\t<th>Contact</th>\r\n\t\t<th>FatherName</th>\r\n\t\t<th>Gender</th>\r\n        <th>Actions</th>\r\n\t</tr>\r\n\r\n\r\n");
#nullable restore
#line 21 "C:\Users\Haier\Desktop\asp.net core mvc\SchoolManagementSystem\Views\Student\List.cshtml"
 for (int i = 0; i < Model.Count; i++)
	{


#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<tr>\r\n\r\n\t\t\t<td>");
#nullable restore
#line 26 "C:\Users\Haier\Desktop\asp.net core mvc\SchoolManagementSystem\Views\Student\List.cshtml"
           Write(Model[i].StudentId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\t\t\t<td>");
#nullable restore
#line 27 "C:\Users\Haier\Desktop\asp.net core mvc\SchoolManagementSystem\Views\Student\List.cshtml"
           Write(Model[i].StudentName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\t\t\t<td>");
#nullable restore
#line 28 "C:\Users\Haier\Desktop\asp.net core mvc\SchoolManagementSystem\Views\Student\List.cshtml"
           Write(Model[i].StudentAge);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\t\t\t<td>");
#nullable restore
#line 29 "C:\Users\Haier\Desktop\asp.net core mvc\SchoolManagementSystem\Views\Student\List.cshtml"
           Write(Model[i].StudentEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\t\t\t<td>");
#nullable restore
#line 30 "C:\Users\Haier\Desktop\asp.net core mvc\SchoolManagementSystem\Views\Student\List.cshtml"
           Write(Model[i].StudentContact);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\t\t\t<td>");
#nullable restore
#line 31 "C:\Users\Haier\Desktop\asp.net core mvc\SchoolManagementSystem\Views\Student\List.cshtml"
           Write(Model[i].FatherName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\t\t\t<td>");
#nullable restore
#line 32 "C:\Users\Haier\Desktop\asp.net core mvc\SchoolManagementSystem\Views\Student\List.cshtml"
           Write(Model[i].Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\t\t\t\r\n\t\t\t<td> <a");
            BeginWriteAttribute("href", " href=\"", 601, "\"", 658, 1);
#nullable restore
#line 34 "C:\Users\Haier\Desktop\asp.net core mvc\SchoolManagementSystem\Views\Student\List.cshtml"
WriteAttributeValue("", 608, Url.Action("Delete", new{id=@Model[i].StudentId}), 608, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\tDelete</a>  </td>\r\n\t\t\t\r\n\t\t\t<td> <a");
            BeginWriteAttribute("href", " href=\"", 700, "\"", 906, 1);
#nullable restore
#line 37 "C:\Users\Haier\Desktop\asp.net core mvc\SchoolManagementSystem\Views\Student\List.cshtml"
WriteAttributeValue("", 707, Url.Action("Index", new{@Model[i].StudentId, 
				@Model[i].StudentName, @Model[i].StudentAge, 
				@Model[i].StudentEmail, @Model[i].StudentContact,
				@Model[i].FatherName, @Model[i].Gender }), 707, 199, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Edit  </a>  </td>\r\n\t\t\r\n\t\t\t</tr>\r\n");
#nullable restore
#line 43 "C:\Users\Haier\Desktop\asp.net core mvc\SchoolManagementSystem\Views\Student\List.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SchoolManagementSystem.Models.Student>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
