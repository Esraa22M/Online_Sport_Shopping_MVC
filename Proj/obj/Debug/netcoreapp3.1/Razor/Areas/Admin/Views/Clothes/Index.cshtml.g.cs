#pragma checksum "C:\Users\Asmaa\Downloads\Proj\Proj\Areas\Admin\Views\Clothes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa5077c5555e5c36bbc55da4342ecc8df482293a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Clothes_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Clothes/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa5077c5555e5c36bbc55da4342ecc8df482293a", @"/Areas/Admin/Views/Clothes/Index.cshtml")]
    public class Areas_Admin_Views_Clothes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Proj.Models.Clothes>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Asmaa\Downloads\Proj\Proj\Areas\Admin\Views\Clothes\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Asmaa\Downloads\Proj\Proj\Areas\Admin\Views\Clothes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Asmaa\Downloads\Proj\Proj\Areas\Admin\Views\Clothes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Discrbtion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Asmaa\Downloads\Proj\Proj\Areas\Admin\Views\Clothes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Size));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Asmaa\Downloads\Proj\Proj\Areas\Admin\Views\Clothes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Asmaa\Downloads\Proj\Proj\Areas\Admin\Views\Clothes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Color));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\Asmaa\Downloads\Proj\Proj\Areas\Admin\Views\Clothes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\Asmaa\Downloads\Proj\Proj\Areas\Admin\Views\Clothes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Brand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            \r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 41 "C:\Users\Asmaa\Downloads\Proj\Proj\Areas\Admin\Views\Clothes\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\Asmaa\Downloads\Proj\Proj\Areas\Admin\Views\Clothes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\Users\Asmaa\Downloads\Proj\Proj\Areas\Admin\Views\Clothes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Discrbtion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\Asmaa\Downloads\Proj\Proj\Areas\Admin\Views\Clothes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Size));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\Asmaa\Downloads\Proj\Proj\Areas\Admin\Views\Clothes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "C:\Users\Asmaa\Downloads\Proj\Proj\Areas\Admin\Views\Clothes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Color));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Users\Asmaa\Downloads\Proj\Proj\Areas\Admin\Views\Clothes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "C:\Users\Asmaa\Downloads\Proj\Proj\Areas\Admin\Views\Clothes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Brand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            \r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1760, "\"", 1783, 1);
#nullable restore
#line 66 "C:\Users\Asmaa\Downloads\Proj\Proj\Areas\Admin\Views\Clothes\Index.cshtml"
WriteAttributeValue("", 1775, item.ID, 1775, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1836, "\"", 1859, 1);
#nullable restore
#line 67 "C:\Users\Asmaa\Downloads\Proj\Proj\Areas\Admin\Views\Clothes\Index.cshtml"
WriteAttributeValue("", 1851, item.ID, 1851, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1914, "\"", 1937, 1);
#nullable restore
#line 68 "C:\Users\Asmaa\Downloads\Proj\Proj\Areas\Admin\Views\Clothes\Index.cshtml"
WriteAttributeValue("", 1929, item.ID, 1929, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 71 "C:\Users\Asmaa\Downloads\Proj\Proj\Areas\Admin\Views\Clothes\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Proj.Models.Clothes>> Html { get; private set; }
    }
}
#pragma warning restore 1591