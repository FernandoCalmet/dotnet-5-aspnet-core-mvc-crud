#pragma checksum "D:\Github\FernandoCalmet\CS-ASPNET-Core-MVC-CRUD\aspnet-core-mvc-crud\Areas\Identity\Pages\Account\_StatusMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "208c399a696aaa50823353d094c7e4fbbc6f11cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account__StatusMessage), @"mvc.1.0.view", @"/Areas/Identity/Pages/Account/_StatusMessage.cshtml")]
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
#line 1 "D:\Github\FernandoCalmet\CS-ASPNET-Core-MVC-CRUD\aspnet-core-mvc-crud\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Github\FernandoCalmet\CS-ASPNET-Core-MVC-CRUD\aspnet-core-mvc-crud\Areas\Identity\Pages\_ViewImports.cshtml"
using aspnet_core_mvc_crud.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Github\FernandoCalmet\CS-ASPNET-Core-MVC-CRUD\aspnet-core-mvc-crud\Areas\Identity\Pages\_ViewImports.cshtml"
using aspnet_core_mvc_crud.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Github\FernandoCalmet\CS-ASPNET-Core-MVC-CRUD\aspnet-core-mvc-crud\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using aspnet_core_mvc_crud.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"208c399a696aaa50823353d094c7e4fbbc6f11cf", @"/Areas/Identity/Pages/Account/_StatusMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2d09752e28af3ddf3a4d4b3d25cded5764623b6", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42bcc0adcbfcdbcdb204ded3df00cadd558b3cf0", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account__StatusMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\Github\FernandoCalmet\CS-ASPNET-Core-MVC-CRUD\aspnet-core-mvc-crud\Areas\Identity\Pages\Account\_StatusMessage.cshtml"
 if (!String.IsNullOrEmpty(Model))
{
    var statusMessageClass = Model.StartsWith("Error") ? "danger" : "success";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div");
            BeginWriteAttribute("class", " class=\"", 135, "\"", 192, 4);
            WriteAttributeValue("", 143, "alert", 143, 5, true);
            WriteAttributeValue(" ", 148, "alert-", 149, 7, true);
#nullable restore
#line 6 "D:\Github\FernandoCalmet\CS-ASPNET-Core-MVC-CRUD\aspnet-core-mvc-crud\Areas\Identity\Pages\Account\_StatusMessage.cshtml"
WriteAttributeValue("", 155, statusMessageClass, 155, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 174, "alert-dismissible", 175, 18, true);
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\n    <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\n    ");
#nullable restore
#line 8 "D:\Github\FernandoCalmet\CS-ASPNET-Core-MVC-CRUD\aspnet-core-mvc-crud\Areas\Identity\Pages\Account\_StatusMessage.cshtml"
Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>");
#nullable restore
#line 9 "D:\Github\FernandoCalmet\CS-ASPNET-Core-MVC-CRUD\aspnet-core-mvc-crud\Areas\Identity\Pages\Account\_StatusMessage.cshtml"
      }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
