#pragma checksum "C:\Users\Khoa Cao\source\repos\WebApplication1\WebApplication1\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5140d2217a141bea53867e470c022b22c8581005"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "C:\Users\Khoa Cao\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "C:\Users\Khoa Cao\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5140d2217a141bea53867e470c022b22c8581005", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sidebar-brand d-flex align-items-center justify-content-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BusBooking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Invoices", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Table", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 37, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(37, 1394, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "495fd0eb165041e0907579a439fed23b", async() => {
                BeginContext(43, 1381, true);
                WriteLiteral(@"

    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <meta name=""description"" content="""">
    <meta name=""author"" content="""">

    <title>SB Admin 2 - Dashboard</title>

    <!-- Custom fonts for this template-->
    <link href=""/vendor/fontawesome-free/css/all.min.css"" rel=""stylesheet"" type=""text/css"">

    <link href=""https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i"" rel=""stylesheet"">


    <!-- Custom styles for this template-->
    <link href=""//cdn.datatables.net/1.10.22/css/jquery.dataTables.min.css"" rel=""stylesheet"" type=""text/css"">


    <link href=""/css/sb-admin-2.min.css"" rel=""stylesheet"">
    <link href=""/vendor/datatables/dataTables.bootstrap4.min.css"" rel=""stylesheet"">
    <!-- Favicons -->
    <link type=""image/x-icon"" href=""/assets/img/favicon.png"" rel=""icon"">

    <!-- Bootstrap CSS");
                WriteLiteral(@" -->
    <link rel=""stylesheet"" href=""/assets/css/bootstrap.min.css"">

    <!-- Fontawesome CSS -->
    <link rel=""stylesheet"" href=""/assets/plugins/fontawesome/css/fontawesome.min.css"">
    <link rel=""stylesheet"" href=""/assets/plugins/fontawesome/css/all.min.css"">

    <!-- Main CSS -->
    <link rel=""stylesheet"" href=""/assets/css/style.css"">

");
                EndContext();
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
            EndContext();
            BeginContext(1431, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1435, 8272, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebed99e0386242d09c83ce214d4deece", async() => {
                BeginContext(1455, 241, true);
                WriteLiteral("\r\n\r\n    <!-- Page Wrapper -->\r\n    <div id=\"wrapper\">\r\n\r\n        <!-- Sidebar -->\r\n        <ul class=\"navbar-nav bg-gradient-primary sidebar sidebar-dark accordion\" id=\"accordionSidebar\">\r\n\r\n            <!-- Sidebar - Brand -->\r\n            ");
                EndContext();
                BeginContext(1696, 368, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "280d3d96a2c34cc0804fd775c5a5b8c5", async() => {
                    BeginContext(1823, 237, true);
                    WriteLiteral("\r\n                <div class=\"sidebar-brand-icon rotate-n-15\">\r\n                    <i class=\"fas fa-laugh-wink\"></i>\r\n                </div>\r\n                <div class=\"sidebar-brand-text mx-3\">SB Admin <sup>2</sup></div>\r\n            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2064, 184, true);
                WriteLiteral("\r\n\r\n            <!-- Divider -->\r\n            <hr class=\"sidebar-divider my-0\">\r\n\r\n            <!-- Nav Item - Dashboard -->\r\n            <li class=\"nav-item active\">\r\n                ");
                EndContext();
                BeginContext(2248, 211, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d00dffe30cc4ec696251f772705c629", async() => {
                    BeginContext(2326, 129, true);
                    WriteLiteral("\r\n                    <i class=\"fas fa-fw fa-tachometer-alt\"></i>\r\n                    <span>Bus Booking</span>\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2459, 3729, true);
                WriteLiteral(@"
            </li>

            <!-- Divider -->
            <hr class=""sidebar-divider"">

            <!-- Heading -->
            <div class=""sidebar-heading"">
                Interface
            </div>

            <!-- Nav Item - Pages Collapse Menu -->
            <li class=""nav-item"">
                <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseTwo"" aria-expanded=""true"" aria-controls=""collapseTwo"">
                    <i class=""fas fa-fw fa-cog""></i>
                    <span>Components</span>
                </a>
                <div id=""collapseTwo"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionSidebar"">
                    <div class=""bg-white py-2 collapse-inner rounded"">
                        <h6 class=""collapse-header"">Custom Components:</h6>
                        <a class=""collapse-item"" href=""buttons.html"">Buttons</a>
                        <a class=""collapse-item"" href=""cards.html"">Cards</a>
             ");
                WriteLiteral(@"       </div>
                </div>
            </li>

            <!-- Nav Item - Utilities Collapse Menu -->
            <li class=""nav-item"">
                <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseUtilities"" aria-expanded=""true"" aria-controls=""collapseUtilities"">
                    <i class=""fas fa-fw fa-wrench""></i>
                    <span>Utilities</span>
                </a>
                <div id=""collapseUtilities"" class=""collapse"" aria-labelledby=""headingUtilities"" data-parent=""#accordionSidebar"">
                    <div class=""bg-white py-2 collapse-inner rounded"">
                        <h6 class=""collapse-header"">Custom Utilities:</h6>
                        <a class=""collapse-item"" href=""utilities-color.html"">Colors</a>
                        <a class=""collapse-item"" href=""utilities-border.html"">Borders</a>
                        <a class=""collapse-item"" href=""utilities-animation.html"">Animations</a>
                        <a");
                WriteLiteral(@" class=""collapse-item"" href=""utilities-other.html"">Other</a>
                    </div>
                </div>
            </li>

            <!-- Divider -->
            <hr class=""sidebar-divider"">

            <!-- Heading -->
            <div class=""sidebar-heading"">
                Addons
            </div>

            <!-- Nav Item - Pages Collapse Menu -->
            <li class=""nav-item"">
                <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapsePages"" aria-expanded=""true"" aria-controls=""collapsePages"">
                    <i class=""fas fa-fw fa-folder""></i>
                    <span>Pages</span>
                </a>
                <div id=""collapsePages"" class=""collapse"" aria-labelledby=""headingPages"" data-parent=""#accordionSidebar"">
                    <div class=""bg-white py-2 collapse-inner rounded"">
                        <h6 class=""collapse-header"">Login Screens:</h6>
                        <a class=""collapse-item"" href=""login.h");
                WriteLiteral(@"tml"">Login</a>
                        <a class=""collapse-item"" href=""register.html"">Register</a>
                        <a class=""collapse-item"" href=""forgot-password.html"">Forgot Password</a>
                        <div class=""collapse-divider""></div>
                        <h6 class=""collapse-header"">Other Pages:</h6>
                        <a class=""collapse-item"" href=""404.html"">404 Page</a>
                        <a class=""collapse-item"" href=""blank.html"">Blank Page</a>
                    </div>
                </div>
            </li>

            <!-- Nav Item - Charts -->
            <li class=""nav-item"">
                ");
                EndContext();
                BeginContext(6188, 203, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a739023bd8fd43daa77dad79d05d1233", async() => {
                    BeginContext(6265, 122, true);
                    WriteLiteral("\r\n                    <i class=\"fas fa-fw fa-chart-area\"></i>\r\n                    <span>Invoices</span>\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6391, 114, true);
                WriteLiteral("\r\n            </li>\r\n\r\n            <!-- Nav Item - Tables -->\r\n            <li class=\"nav-item\">\r\n                ");
                EndContext();
                BeginContext(6505, 196, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd87d6f1ad544d31a94c89849bc0f84a", async() => {
                    BeginContext(6578, 119, true);
                    WriteLiteral("\r\n                    <i class=\"fas fa-fw fa-table\"></i>\r\n                    <span>Car Tables</span>\r\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6701, 387, true);
                WriteLiteral(@"
            </li>

            <!-- Divider -->
            <hr class=""sidebar-divider d-none d-md-block"">

            <!-- Sidebar Toggler (Sidebar) -->
            <div class=""text-center d-none d-md-inline"">
                <button class=""rounded-circle border-0"" id=""sidebarToggle""></button>
            </div>

        </ul>
        <!-- End of Sidebar -->

        ");
                EndContext();
                BeginContext(7089, 12, false);
#line 163 "C:\Users\Khoa Cao\source\repos\WebApplication1\WebApplication1\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(7101, 238, true);
                WriteLiteral("\r\n\r\n\r\n\r\n    </div>\r\n    <!-- End of Content Wrapper -->\r\n    <!-- End of Page Wrapper -->\r\n    <!-- Scroll to Top Button-->\r\n    <a class=\"scroll-to-top rounded\" href=\"#page-top\">\r\n        <i class=\"fas fa-angle-up\"></i>\r\n    </a>\r\n\r\n    ");
                EndContext();
                BeginContext(7340, 30, false);
#line 175 "C:\Users\Khoa Cao\source\repos\WebApplication1\WebApplication1\Views\Shared\_Layout.cshtml"
Write(Html.Partial("_PartialFooter"));

#line default
#line hidden
                EndContext();
                BeginContext(7370, 2330, true);
                WriteLiteral(@"

    <!-- Logout Modal-->
    <div class=""modal fade"" id=""logoutModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Ready to Leave?</h5>
                    <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">×</span>
                    </button>
                </div>
                <div class=""modal-body"">Select ""Logout"" below if you are ready to end your current session.</div>
                <div class=""modal-footer"">
                    <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Cancel</button>
                    <a class=""btn btn-primary"" href=""login.html"">Logout</a>
                </div>
            </div>
        </div>
    </div>

    <!-- B");
                WriteLiteral(@"ootstrap core JavaScript-->
    <script src=""/vendor/jquery/jquery.min.js""></script>
    <script src=""/vendor/bootstrap/js/bootstrap.bundle.min.js""></script>

    <!-- Core plugin JavaScript-->
    <script src=""/Contentvendor/jquery-easing/jquery.easing.min.js""></script>
    <script type=""text/javascript"" src=""//cdn.datatables.net/1.10.22/js/jquery.dataTables.min.js""></script>
    <!-- Custom scripts for all pages-->
    <script src=""js/sb-admin-2.min.js""></script>

    <!-- Page level plugins -->
    <script src=""/vendor/chart.js/Chart.min.js""></script>
    <script src=""/vendor/datatables/jquery.dataTables.min.js""></script>
    <script src=""/vendor/datatables/dataTables.bootstrap4.min.js""></script>
    <!-- Page level custom scripts -->
    <script src=""/js/demo/datatables-demo.js""></script>
    <script src=""/js/demo/chart-area-demo.js""></script>
    <script src=""/js/demo/chart-pie-demo.js""></script>
    <!-- jQuery -->
    <script src=""assets/js/jquery.min.js""></script>

    <!-- Bootst");
                WriteLiteral(@"rap Core JS -->
    <script src=""/assets/js/popper.min.js""></script>
    <script src=""/assets/js/bootstrap.min.js""></script>

    <!-- Slick JS -->
    <script src=""/assets/js/slick.js""></script>

    <!-- Custom JS -->
    <script src=""/assets/js/script.js""></script>


");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9707, 13, true);
            WriteLiteral("\r\n\r\n</html>\r\n");
            EndContext();
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