#pragma checksum "C:\Users\pc\Desktop\BartuBlog\BartuBlog\WebUI\Areas\admin\Views\Bloglar\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a83143384ef910b0a29a258a1272e25bc9680fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_admin_Views_Bloglar_Index), @"mvc.1.0.view", @"/Areas/admin/Views/Bloglar/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a83143384ef910b0a29a258a1272e25bc9680fd", @"/Areas/admin/Views/Bloglar/Index.cshtml")]
    #nullable restore
    public class Areas_admin_Views_Bloglar_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\pc\Desktop\BartuBlog\BartuBlog\WebUI\Areas\admin\Views\Bloglar\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/admin/Views/_Shareds/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-sm-12"">
        <div class=""white-box"">
            <h3 class=""box-title"">Basic Table</h3>
            <p class=""text-muted"">Add class <code>.table</code></p>
            <div class=""table-responsive"">
                <a href=""/Admin/Bloglar/Insert"" class=""btn btn-primary"">Yeni Ekle</a>
                <table class=""table text-nowrap"">
                    <thead>
                        <tr>
                            <th class=""border-top-0"">#</th>
                            <th class=""border-top-0"">Blog Adı</th>
                            <th class=""border-top-0"">Yayın Tarihi</th>
                            <th class=""border-top-0"">İşlemleri</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 24 "C:\Users\pc\Desktop\BartuBlog\BartuBlog\WebUI\Areas\admin\Views\Bloglar\Index.cshtml"
                         foreach (var item in Model.Data)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 27 "C:\Users\pc\Desktop\BartuBlog\BartuBlog\WebUI\Areas\admin\Views\Bloglar\Index.cshtml"
                               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 28 "C:\Users\pc\Desktop\BartuBlog\BartuBlog\WebUI\Areas\admin\Views\Bloglar\Index.cshtml"
                               Write(item.BlogName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 29 "C:\Users\pc\Desktop\BartuBlog\BartuBlog\WebUI\Areas\admin\Views\Bloglar\Index.cshtml"
                               Write(item.ReleaseDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                <td>
                                    <a href=""#"" class=""btn btn-info"">Yorumlar</a>
                                    <a href=""#"" class=""btn btn-info"">Okunmalar</a>
                                    <a href=""#"" class=""btn btn-primary"">Düzenle</a>
                                    <a href=""#"" class=""btn btn-danger"">Sil</a>

                                </td>

                            </tr>
");
#nullable restore
#line 39 "C:\Users\pc\Desktop\BartuBlog\BartuBlog\WebUI\Areas\admin\Views\Bloglar\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
