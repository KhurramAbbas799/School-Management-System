#pragma checksum "C:\Users\Haier\Desktop\asp.net core mvc\SchoolManagementSystem\Views\Timing\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcfc4980d648236b5e773a7111936fdcd68ac2f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Timing_List), @"mvc.1.0.view", @"/Views/Timing/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcfc4980d648236b5e773a7111936fdcd68ac2f9", @"/Views/Timing/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7d07f01e3c07cc979b1fe4cd526aeaff34bec21", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Timing_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SchoolManagementSystem.Models.Timing>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Haier\Desktop\asp.net core mvc\SchoolManagementSystem\Views\Timing\List.cshtml"
  
	ViewData["Title"] = "List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table>\r\n\r\n\t<tr>\r\n\r\n\t\t<th>Id</th>\r\n\t\t<th>Name</th>\r\n\r\n\t</tr>\r\n\r\n\r\n");
#nullable restore
#line 16 "C:\Users\Haier\Desktop\asp.net core mvc\SchoolManagementSystem\Views\Timing\List.cshtml"
     for (int i = 0; i < Model.Count; i++)
	{


#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<tr>\r\n\r\n\t\t\t<td>");
#nullable restore
#line 21 "C:\Users\Haier\Desktop\asp.net core mvc\SchoolManagementSystem\Views\Timing\List.cshtml"
           Write(Model[i].TimingId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t<td>");
#nullable restore
#line 22 "C:\Users\Haier\Desktop\asp.net core mvc\SchoolManagementSystem\Views\Timing\List.cshtml"
           Write(Model[i].TimingName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t<td> <a");
            BeginWriteAttribute("href", " href=\"", 289, "\"", 345, 1);
#nullable restore
#line 23 "C:\Users\Haier\Desktop\asp.net core mvc\SchoolManagementSystem\Views\Timing\List.cshtml"
WriteAttributeValue("", 296, Url.Action("Delete", new{Id=@Model[i].TimingId}), 296, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">  Delete</a>  </td>\r\n\t\t\t<td>\r\n\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 383, "\"", 460, 1);
#nullable restore
#line 25 "C:\Users\Haier\Desktop\asp.net core mvc\SchoolManagementSystem\Views\Timing\List.cshtml"
WriteAttributeValue("", 390, Url.Action("Index", new{@Model[i].TimingId,
		@Model[i].TimingName}), 390, 70, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Edit</a>\r\n\t\t\t</td>\r\n\t\t\t \r\n\t\t</tr>\r\n");
#nullable restore
#line 30 "C:\Users\Haier\Desktop\asp.net core mvc\SchoolManagementSystem\Views\Timing\List.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SchoolManagementSystem.Models.Timing>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
