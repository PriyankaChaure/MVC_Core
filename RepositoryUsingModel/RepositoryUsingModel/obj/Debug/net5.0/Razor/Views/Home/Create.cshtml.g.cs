#pragma checksum "C:\Ankit\MVC_Core\RepositoryUsingModel\RepositoryUsingModel\Views\Home\Create.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "99409e739c4888a6d122c7a5285633810adce99aa107061916b03cb542562503"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Create), @"mvc.1.0.view", @"/Views/Home/Create.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Ankit\MVC_Core\RepositoryUsingModel\RepositoryUsingModel\Views\_ViewImports.cshtml"
using RepositoryUsingModel.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Ankit\MVC_Core\RepositoryUsingModel\RepositoryUsingModel\Views\_ViewImports.cshtml"
using RepositoryUsingModel.Repositories;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"99409e739c4888a6d122c7a5285633810adce99aa107061916b03cb542562503", @"/Views/Home/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4ec19f0b3f8e404530143b88a6d2cdce3e681b6cc173e7854b6d2b2d4431fa5e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Customer>
    #nullable disable
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Ankit\MVC_Core\RepositoryUsingModel\RepositoryUsingModel\Views\Home\Create.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99409e739c4888a6d122c7a5285633810adce99aa107061916b03cb5425625033666", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Create</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99409e739c4888a6d122c7a5285633810adce99aa107061916b03cb5425625034750", async() => {
                WriteLiteral("\r\n   <div>\r\n       <h2>Create form</h2>\r\n       <h4>Count is:");
#nullable restore
#line 17 "C:\Ankit\MVC_Core\RepositoryUsingModel\RepositoryUsingModel\Views\Home\Create.cshtml"
               Write(xyz.getcount());

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n");
#nullable restore
#line 18 "C:\Ankit\MVC_Core\RepositoryUsingModel\RepositoryUsingModel\Views\Home\Create.cshtml"
        using(Html.BeginForm())
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div>\r\n                ");
#nullable restore
#line 21 "C:\Ankit\MVC_Core\RepositoryUsingModel\RepositoryUsingModel\Views\Home\Create.cshtml"
           Write(Html.LabelFor(p=>p.customername));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div>");
#nullable restore
#line 22 "C:\Ankit\MVC_Core\RepositoryUsingModel\RepositoryUsingModel\Views\Home\Create.cshtml"
                Write(Html.EditorFor(p=>p.customername));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n            </div>\r\n            <div>\r\n                ");
#nullable restore
#line 25 "C:\Ankit\MVC_Core\RepositoryUsingModel\RepositoryUsingModel\Views\Home\Create.cshtml"
           Write(Html.LabelFor(p => p.customeraddress));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div>");
#nullable restore
#line 26 "C:\Ankit\MVC_Core\RepositoryUsingModel\RepositoryUsingModel\Views\Home\Create.cshtml"
                Write(Html.EditorFor(p => p.customeraddress));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n            </div>\r\n            <div>\r\n                ");
#nullable restore
#line 29 "C:\Ankit\MVC_Core\RepositoryUsingModel\RepositoryUsingModel\Views\Home\Create.cshtml"
           Write(Html.LabelFor(p => p.customeremailid));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div>");
#nullable restore
#line 30 "C:\Ankit\MVC_Core\RepositoryUsingModel\RepositoryUsingModel\Views\Home\Create.cshtml"
                Write(Html.EditorFor(p => p.customeremailid));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n            </div>\r\n            <div>\r\n                ");
#nullable restore
#line 33 "C:\Ankit\MVC_Core\RepositoryUsingModel\RepositoryUsingModel\Views\Home\Create.cshtml"
           Write(Html.LabelFor(p => p.customerphone));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div>");
#nullable restore
#line 34 "C:\Ankit\MVC_Core\RepositoryUsingModel\RepositoryUsingModel\Views\Home\Create.cshtml"
                Write(Html.EditorFor(p => p.customerphone));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n            </div>\r\n            <div>\r\n                ");
#nullable restore
#line 37 "C:\Ankit\MVC_Core\RepositoryUsingModel\RepositoryUsingModel\Views\Home\Create.cshtml"
           Write(Html.LabelFor(p => p.customercreditlimit));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div>");
#nullable restore
#line 38 "C:\Ankit\MVC_Core\RepositoryUsingModel\RepositoryUsingModel\Views\Home\Create.cshtml"
                Write(Html.EditorFor(p => p.customercreditlimit));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n            </div>\r\n            <div>\r\n               <input type=\"submit\" value=\"Create\"/>\r\n            </div>\r\n");
#nullable restore
#line 43 "C:\Ankit\MVC_Core\RepositoryUsingModel\RepositoryUsingModel\Views\Home\Create.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public CustInterface xyz { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Customer> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
