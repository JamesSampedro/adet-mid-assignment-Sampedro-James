#pragma checksum "C:\Users\jamez\source\repos\adet-mid-assignment-Sampedro-James\WebappTasking\Views\Task\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "127c7b3b46f80d884df16ee2d2329340f7c1a462"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_Index), @"mvc.1.0.view", @"/Views/Task/Index.cshtml")]
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
#line 1 "C:\Users\jamez\source\repos\adet-mid-assignment-Sampedro-James\WebappTasking\Views\_ViewImports.cshtml"
using Tasking_CRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jamez\source\repos\adet-mid-assignment-Sampedro-James\WebappTasking\Views\_ViewImports.cshtml"
using Tasking_CRUD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"127c7b3b46f80d884df16ee2d2329340f7c1a462", @"/Views/Task/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f874185c8e0c9fcde779a7b6b51477501c3cc601", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Tasking_CRUD.Models.TaskModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Upsert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Task", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangeState", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "127c7b3b46f80d884df16ee2d2329340f7c1a4624957", async() => {
                WriteLiteral("Create");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \n");
#nullable restore
#line 5 "C:\Users\jamez\source\repos\adet-mid-assignment-Sampedro-James\WebappTasking\Views\Task\Index.cshtml"
 foreach (var task in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"task-card\">\n    <div class=\"task-card--header\">\n        <h3>");
#nullable restore
#line 9 "C:\Users\jamez\source\repos\adet-mid-assignment-Sampedro-James\WebappTasking\Views\Task\Index.cshtml"
       Write(Html.DisplayFor(taskItem => task.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n        <h3>");
#nullable restore
#line 10 "C:\Users\jamez\source\repos\adet-mid-assignment-Sampedro-James\WebappTasking\Views\Task\Index.cshtml"
       Write(Html.DisplayFor(taskItem => task.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "127c7b3b46f80d884df16ee2d2329340f7c1a4627208", async() => {
                WriteLiteral("\n            <button type=\"submit\" onclick=\"return confirm(\'Are you sure you want to permanently delete this task\')\">Delete</button>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 11 "C:\Users\jamez\source\repos\adet-mid-assignment-Sampedro-James\WebappTasking\Views\Task\Index.cshtml"
                                    WriteLiteral(task.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "127c7b3b46f80d884df16ee2d2329340f7c1a4629994", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "C:\Users\jamez\source\repos\adet-mid-assignment-Sampedro-James\WebappTasking\Views\Task\Index.cshtml"
                                                       WriteLiteral(task.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 15 "C:\Users\jamez\source\repos\adet-mid-assignment-Sampedro-James\WebappTasking\Views\Task\Index.cshtml"
         if (task.State != "Done")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "127c7b3b46f80d884df16ee2d2329340f7c1a46212652", async() => {
                WriteLiteral("\n                <button type=\"submit\">");
#nullable restore
#line 18 "C:\Users\jamez\source\repos\adet-mid-assignment-Sampedro-James\WebappTasking\Views\Task\Index.cshtml"
                                  Write(task.State != "To Do" ? "Finish" : "Start");

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\n");
#nullable restore
#line 19 "C:\Users\jamez\source\repos\adet-mid-assignment-Sampedro-James\WebappTasking\Views\Task\Index.cshtml"
                 if(task.State == "Doing")
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <label>Total Hours of Work:</label>\n                    <input type=\"text\" value=\"0\" name=\"totalHours\"/>\n");
#nullable restore
#line 23 "C:\Users\jamez\source\repos\adet-mid-assignment-Sampedro-James\WebappTasking\Views\Task\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "C:\Users\jamez\source\repos\adet-mid-assignment-Sampedro-James\WebappTasking\Views\Task\Index.cshtml"
                                             WriteLiteral(task.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 25 "C:\Users\jamez\source\repos\adet-mid-assignment-Sampedro-James\WebappTasking\Views\Task\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <button class=\"details--button\" onclick=\"toggleHide(this.id)\"");
            BeginWriteAttribute("id", " id=\"", 1145, "\"", 1167, 2);
            WriteAttributeValue("", 1150, "details--", 1150, 9, true);
#nullable restore
#line 26 "C:\Users\jamez\source\repos\adet-mid-assignment-Sampedro-James\WebappTasking\Views\Task\Index.cshtml"
WriteAttributeValue("", 1159, task.Id, 1159, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">V</button>\n    </div>\n    <div class=\"task-card--details hidden\"");
            BeginWriteAttribute("id", " id=\"", 1233, "\"", 1265, 2);
            WriteAttributeValue("", 1238, "dropdown--details--", 1238, 19, true);
#nullable restore
#line 28 "C:\Users\jamez\source\repos\adet-mid-assignment-Sampedro-James\WebappTasking\Views\Task\Index.cshtml"
WriteAttributeValue("", 1257, task.Id, 1257, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n        <span>Date Created: ");
#nullable restore
#line 29 "C:\Users\jamez\source\repos\adet-mid-assignment-Sampedro-James\WebappTasking\Views\Task\Index.cshtml"
                       Write(Html.DisplayFor(taskItem => task.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 30 "C:\Users\jamez\source\repos\adet-mid-assignment-Sampedro-James\WebappTasking\Views\Task\Index.cshtml"
         if (task.State != "To Do")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span>Date Started: ");
#nullable restore
#line 32 "C:\Users\jamez\source\repos\adet-mid-assignment-Sampedro-James\WebappTasking\Views\Task\Index.cshtml"
                           Write(Html.DisplayFor(taskItem => task.DateStarted));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 33 "C:\Users\jamez\source\repos\adet-mid-assignment-Sampedro-James\WebappTasking\Views\Task\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\jamez\source\repos\adet-mid-assignment-Sampedro-James\WebappTasking\Views\Task\Index.cshtml"
         if(task.State == "Done")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span>Date Finished: ");
#nullable restore
#line 36 "C:\Users\jamez\source\repos\adet-mid-assignment-Sampedro-James\WebappTasking\Views\Task\Index.cshtml"
                            Write(Html.DisplayFor(taskItem => task.DateFinished));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n            <span>Total Hours: ");
#nullable restore
#line 37 "C:\Users\jamez\source\repos\adet-mid-assignment-Sampedro-James\WebappTasking\Views\Task\Index.cshtml"
                          Write(Html.DisplayFor(taskItem => task.TotalHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 38 "C:\Users\jamez\source\repos\adet-mid-assignment-Sampedro-James\WebappTasking\Views\Task\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>");
#nullable restore
#line 39 "C:\Users\jamez\source\repos\adet-mid-assignment-Sampedro-James\WebappTasking\Views\Task\Index.cshtml"
      Write(Html.DisplayFor(taskItem => task.TaskDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    </div>\n</div>   \n");
#nullable restore
#line 42 "C:\Users\jamez\source\repos\adet-mid-assignment-Sampedro-James\WebappTasking\Views\Task\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Tasking_CRUD.Models.TaskModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
