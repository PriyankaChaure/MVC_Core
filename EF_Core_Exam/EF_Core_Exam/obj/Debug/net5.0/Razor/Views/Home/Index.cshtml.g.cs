#pragma checksum "C:\Ankit\MVC_Core\EF_Core_Exam\EF_Core_Exam\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b4797434dfd31b27da0b0c9c0d630fbd8a09a2b2d995715c7f1185b674c3a0e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"b4797434dfd31b27da0b0c9c0d630fbd8a09a2b2d995715c7f1185b674c3a0e7", @"/Views/Home/Index.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EF_Core_Exam.Models.abcmVM>>
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Ankit\MVC_Core\EF_Core_Exam\EF_Core_Exam\Views\Home\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4797434dfd31b27da0b0c9c0d630fbd8a09a2b2d995715c7f1185b674c3a0e73094", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4797434dfd31b27da0b0c9c0d630fbd8a09a2b2d995715c7f1185b674c3a0e74177", async() => {
                WriteLiteral("\r\n<p>\r\n\r\n</p>\r\n<table class=\"table\" border=\"1\">\r\n    <thead>\r\n        <tr>\r\n\r\n\r\n                <th>\r\n                    ");
#nullable restore
#line 24 "C:\Ankit\MVC_Core\EF_Core_Exam\EF_Core_Exam\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.SrNo));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 27 "C:\Ankit\MVC_Core\EF_Core_Exam\EF_Core_Exam\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model=>model.brandname));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Ankit\MVC_Core\EF_Core_Exam\EF_Core_Exam\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalNoOfParts));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Ankit\MVC_Core\EF_Core_Exam\EF_Core_Exam\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalPartAmount));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\Ankit\MVC_Core\EF_Core_Exam\EF_Core_Exam\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MinimumPrice));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 39 "C:\Ankit\MVC_Core\EF_Core_Exam\EF_Core_Exam\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MaximumPrice));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </th>\r\n            \r\n            \r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 46 "C:\Ankit\MVC_Core\EF_Core_Exam\EF_Core_Exam\Views\Home\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 49 "C:\Ankit\MVC_Core\EF_Core_Exam\EF_Core_Exam\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.SrNo));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 52 "C:\Ankit\MVC_Core\EF_Core_Exam\EF_Core_Exam\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem=>item.brandname));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Ankit\MVC_Core\EF_Core_Exam\EF_Core_Exam\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TotalNoOfParts));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Ankit\MVC_Core\EF_Core_Exam\EF_Core_Exam\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TotalPartAmount));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Ankit\MVC_Core\EF_Core_Exam\EF_Core_Exam\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MinimumPrice));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "C:\Ankit\MVC_Core\EF_Core_Exam\EF_Core_Exam\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MaximumPrice));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n           \r\n        </tr>\r\n");
#nullable restore
#line 68 "C:\Ankit\MVC_Core\EF_Core_Exam\EF_Core_Exam\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EF_Core_Exam.Models.abcmVM>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
