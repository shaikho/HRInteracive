@ModelType IEnumerable(Of Demo.Employee)
@Code
    ViewData("Title") = "Index"
End Code

<section class=" card-body shadow-sm p5">
    <h1 class="uk-heading-bullet uk-margin-auto uk-width-3-4 uk-margin-top">Employees</h1>
    <div style="position:absolute;left:19%">
        <div class="bcca-breadcrumb uk-margin-auto uk-margin-ri">
            <div class="bcca-breadcrumb-item">All Employees &nbsp;<i style="color:#451C16" class="fa fa-users"></i></div>
        </div>
    </div>
    <br />
    <br />
    <hr class="uk-divider-icon uk-margin-auto uk-margin-top uk-width-3-4">
    <div class="uk-child-width-expand@m uk-margin-auto uk-width-3-4">
        @If (TempData("Success") IsNot Nothing) Then
            @<div Class="uk-alert-success" uk-alert>
                <a Class="uk-alert-close" uk-close></a>
                <p> @TempData("Success").ToString()</p>
            </div>
        End If
        @If (TempData("Fail") IsNot Nothing) Then
            @<div Class="uk-alert-danger" uk-alert>
                <a Class="uk-alert-close" uk-close></a>
                <p> @TempData("Fail").ToString()</p>
            </div>
        End If
        <table class="table">
            <tr>
                <th>
                    @Html.DisplayNameFor(Function(model) model.Name)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.Position)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.Age)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.Salary)
                </th>
                <th>
                    Department Name
                </th>
                <th>Actions</th>
            </tr>

            @For Each item In Model
                @<tr>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.Name)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.Position)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.Age)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.Salary)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.Department.Name)
                    </td>
                    <td>
                        @Html.ActionLink("Edit", "Edit", New With {.id = item.EmployeeId}) |
                        @Html.ActionLink("Details", "Details", New With {.id = item.EmployeeId}) |
                        @Html.ActionLink("Delete", "Delete", New With {.id = item.EmployeeId})
                    </td>
                </tr>
            Next

        </table>
        <br />
        <div class="uk-margin uk-margin-auto-left uk-text-center">
            <a href="/Employees/Create">
                <button type="submit" class="anotherbutton" value="Create New">Create New</button>
            </a>
        </div>

    </div>
</section>
