#pragma checksum "G:\ComponentLibrary\ComponentLibrary\Components\TaskList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6431acce5ae3982506d3719054a5ad2b5eb7113b"
// <auto-generated/>
#pragma warning disable 1591
namespace ComponentLibrary.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "G:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using ComponentLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using ComponentLibrary.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "G:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using ComponentLibrary.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "G:\ComponentLibrary\ComponentLibrary\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/TaskList")]
    public partial class TaskList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Task List</h3>\r\n");
            __builder.AddMarkupContent(1, "<p><em>Demonstrates data binding, onclick events, and putting data into a List.</em></p>\r\n<hr class=\"my-4\">\r\n\r\n");
#nullable restore
#line 8 "G:\ComponentLibrary\ComponentLibrary\Components\TaskList.razor"
 if (taskList.Count > 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "progress my-2");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "progress-bar");
            __builder.AddAttribute(8, "role", "progressbar");
            __builder.AddAttribute(9, "style", "width:" + " " + (
#nullable restore
#line 12 "G:\ComponentLibrary\ComponentLibrary\Components\TaskList.razor"
                             percentDone

#line default
#line hidden
#nullable disable
            ) + "%");
            __builder.AddAttribute(10, "aria-valuemin", "0");
            __builder.AddAttribute(11, "aria-valuemax", "100");
            __builder.AddContent(12, 
#nullable restore
#line 13 "G:\ComponentLibrary\ComponentLibrary\Components\TaskList.razor"
                                                     percentDone

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 15 "G:\ComponentLibrary\ComponentLibrary\Components\TaskList.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(15, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(16);
            __builder.AddAttribute(17, "class", "form-inline my-2");
            __builder.AddAttribute(18, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 17 "G:\ComponentLibrary\ComponentLibrary\Components\TaskList.razor"
                                           newTask

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 17 "G:\ComponentLibrary\ComponentLibrary\Components\TaskList.razor"
                                                                   AddTask

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(21, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(22);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(24);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(26);
                __builder2.AddAttribute(27, "class", "form-control mx-2");
                __builder2.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "G:\ComponentLibrary\ComponentLibrary\Components\TaskList.razor"
                                                      newTask.Task

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newTask.Task = __value, newTask.Task))));
                __builder2.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newTask.Task));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n    ");
                __builder2.AddMarkupContent(32, "<button class=\"btn btn-outline-primary\" type=\"submit\">Add Task</button>\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\r\n\r\n");
            __builder.OpenElement(34, "ul");
            __builder.AddAttribute(35, "class", "list-group");
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 25 "G:\ComponentLibrary\ComponentLibrary\Components\TaskList.razor"
     foreach (var task in taskList)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "G:\ComponentLibrary\ComponentLibrary\Components\TaskList.razor"
         if (task.IsComplete)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(37, "            ");
            __builder.OpenElement(38, "li");
            __builder.AddAttribute(39, "class", "list-group-item list-group-item-success");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "G:\ComponentLibrary\ComponentLibrary\Components\TaskList.razor"
                          (()=> task.IsComplete = !task.IsComplete)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.OpenElement(42, "del");
            __builder.AddContent(43, 
#nullable restore
#line 31 "G:\ComponentLibrary\ComponentLibrary\Components\TaskList.razor"
                      task.Task

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
#nullable restore
#line 33 "G:\ComponentLibrary\ComponentLibrary\Components\TaskList.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, "            ");
            __builder.OpenElement(47, "li");
            __builder.AddAttribute(48, "class", "list-group-item list-group-item-secondary");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "G:\ComponentLibrary\ComponentLibrary\Components\TaskList.razor"
                          (()=> task.IsComplete = !task.IsComplete)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.AddContent(51, 
#nullable restore
#line 38 "G:\ComponentLibrary\ComponentLibrary\Components\TaskList.razor"
                 task.Task

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
#nullable restore
#line 40 "G:\ComponentLibrary\ComponentLibrary\Components\TaskList.razor"

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "G:\ComponentLibrary\ComponentLibrary\Components\TaskList.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n<hr class=\"my-4\">");
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "G:\ComponentLibrary\ComponentLibrary\Components\TaskList.razor"
       

    public class TaskModel
    {
        [Required]
        public string Task { get; set; }

        public bool IsComplete { get; set; }
    }

    //holds list of tasks
    private List<TaskModel> taskList = new List<TaskModel>();

    //new task
    private TaskModel newTask = new TaskModel();

    private int percentDone
    {
        get
        {
            return (taskList.Count(x => x.IsComplete) * 100) / taskList.Count;
        }
    }
    //called by OnValidSumbit from our EditForm
    private void AddTask()
    {
        //The model for the EditForm is newTask
        taskList.Add(newTask);

        //reset newTask after the new task has been added
        newTask = new TaskModel();
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
