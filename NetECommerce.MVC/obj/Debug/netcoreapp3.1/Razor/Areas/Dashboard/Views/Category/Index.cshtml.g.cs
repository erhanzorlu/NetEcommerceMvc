#pragma checksum "C:\Users\zorlu\source\repos\Yeni klasör\30.01\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "352b48115b0944c6c3b3c48d3ba76ff08cb5dfdb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Dashboard_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Dashboard/Views/Category/Index.cshtml")]
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
#line 1 "C:\Users\zorlu\source\repos\Yeni klasör\30.01\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\_ViewImports.cshtml"
using NetECommerce.MVC.Areas.Dashboard.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"352b48115b0944c6c3b3c48d3ba76ff08cb5dfdb", @"/Areas/Dashboard/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ff37823e2fdc5f1807043ec89e778419631d58b", @"/Areas/Dashboard/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Dashboard_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NetECommerce.Entity.Entity.Category>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\zorlu\source\repos\Yeni klasör\30.01\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Category";
    Layout = "~/Views/Shared/_DashboardLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "C:\Users\zorlu\source\repos\Yeni klasör\30.01\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Category\Index.cshtml"
 if (TempData["result"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-info alert-dismissible mt-2\">\r\n        <span>");
#nullable restore
#line 11 "C:\Users\zorlu\source\repos\Yeni klasör\30.01\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Category\Index.cshtml"
         Write(TempData["result"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n");
#nullable restore
#line 13 "C:\Users\zorlu\source\repos\Yeni klasör\30.01\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Category\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card mb-4 mt-2\">\r\n    <div class=\"card-header\">\r\n        <div class=\"d-flex justify-content-between\">\r\n            <h3>");
#nullable restore
#line 17 "C:\Users\zorlu\source\repos\Yeni klasör\30.01\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Category\Index.cshtml"
           Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "352b48115b0944c6c3b3c48d3ba76ff08cb5dfdb5736", async() => {
                WriteLiteral("New Category");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
    <div class=""card-body"">
        <table class=""table table-hover"">
            <thead>
                <tr>
                    <th>#</th>
                    <th>Category Name</th>
                    <th>Description</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 32 "C:\Users\zorlu\source\repos\Yeni klasör\30.01\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Category\Index.cshtml"
                  
                    if (Model.Count == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td colspan=\"4\">\r\n                                <span>Herhangi bir kategori eklenmemiş</span>\r\n                            </td>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 41 "C:\Users\zorlu\source\repos\Yeni klasör\30.01\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Category\Index.cshtml"
                    }

                    {
                        foreach (var category in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                            <td>");
#nullable restore
#line 47 "C:\Users\zorlu\source\repos\Yeni klasör\30.01\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Category\Index.cshtml"
                           Write(category.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 48 "C:\Users\zorlu\source\repos\Yeni klasör\30.01\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Category\Index.cshtml"
                           Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                             <td>");
#nullable restore
#line 49 "C:\Users\zorlu\source\repos\Yeni klasör\30.01\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Category\Index.cshtml"
                            Write(category.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                             <td>\r\n                              <a class=\"btn btn-sm btn-warning\"");
            BeginWriteAttribute("href", " href=\"", 1667, "\"", 1713, 2);
            WriteAttributeValue("", 1674, "/Dashboard/Category/Update/", 1674, 27, true);
#nullable restore
#line 51 "C:\Users\zorlu\source\repos\Yeni klasör\30.01\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Category\Index.cshtml"
WriteAttributeValue("", 1701, category.Id, 1701, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Update</a> \r\n                        |\r\n                                    <a class=\"btn btn-sm btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1823, "\"", 1869, 2);
            WriteAttributeValue("", 1830, "/Dashboard/Category/Delete/", 1830, 27, true);
#nullable restore
#line 53 "C:\Users\zorlu\source\repos\Yeni klasör\30.01\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Category\Index.cshtml"
WriteAttributeValue("", 1857, category.Id, 1857, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                             </td>\r\n                            </tr>\n");
#nullable restore
#line 56 "C:\Users\zorlu\source\repos\Yeni klasör\30.01\NetECommerce\NetECommerce.MVC\Areas\Dashboard\Views\Category\Index.cshtml"
                        }
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NetECommerce.Entity.Entity.Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
