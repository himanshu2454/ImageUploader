#pragma checksum "D:\himanshu.chouhan\miscellaneous\DataTransformUtility\ImageUploader\ImageUploader\Views\Home\ImageInventory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8aa04928966f68624349615014b05b89aa6577b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ImageInventory), @"mvc.1.0.view", @"/Views/Home/ImageInventory.cshtml")]
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
#line 1 "D:\himanshu.chouhan\miscellaneous\DataTransformUtility\ImageUploader\ImageUploader\Views\_ViewImports.cshtml"
using ImageUploader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\himanshu.chouhan\miscellaneous\DataTransformUtility\ImageUploader\ImageUploader\Views\_ViewImports.cshtml"
using ImageUploader.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8aa04928966f68624349615014b05b89aa6577b1", @"/Views/Home/ImageInventory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d477e3580a0c6cd35aecfdabde279e309b57011f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ImageInventory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">ImageInvetory</h1>\r\n    <p>Requirement - 2</p>\r\n    <p>Inventory of Time sorted file With Search option.</p>\r\n</div>\r\n\r\n");
#nullable restore
#line 7 "D:\himanshu.chouhan\miscellaneous\DataTransformUtility\ImageUploader\ImageUploader\Views\Home\ImageInventory.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        Find by Employee Name: ");
#nullable restore
#line 10 "D:\himanshu.chouhan\miscellaneous\DataTransformUtility\ImageUploader\ImageUploader\Views\Home\ImageInventory.cshtml"
                          Write(Html.TextBox("SearchString"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <input type=\"submit\" value=\"Search\" />\r\n    </p>\r\n");
#nullable restore
#line 13 "D:\himanshu.chouhan\miscellaneous\DataTransformUtility\ImageUploader\ImageUploader\Views\Home\ImageInventory.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Name\r\n            </th>\r\n            <th>\r\n                TimeAdded\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 27 "D:\himanshu.chouhan\miscellaneous\DataTransformUtility\ImageUploader\ImageUploader\Views\Home\ImageInventory.cshtml"
         foreach (var item in ViewBag.ImageList)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 31 "D:\himanshu.chouhan\miscellaneous\DataTransformUtility\ImageUploader\ImageUploader\Views\Home\ImageInventory.cshtml"
               Write(item.ImageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 34 "D:\himanshu.chouhan\miscellaneous\DataTransformUtility\ImageUploader\ImageUploader\Views\Home\ImageInventory.cshtml"
               Write(item.TimeAdded);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 38 "D:\himanshu.chouhan\miscellaneous\DataTransformUtility\ImageUploader\ImageUploader\Views\Home\ImageInventory.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
