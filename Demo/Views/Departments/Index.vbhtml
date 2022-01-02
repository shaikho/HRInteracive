@ModelType IEnumerable(Of Demo.Department)
@Code
    ViewData("Title") = "Index"
End Code


<section class=" card-body shadow-sm p5">
    <h1 class="uk-heading-bullet uk-margin-auto uk-width-3-4 uk-margin-top">Departments</h1>
    <div style="position:absolute;left:19%">
        <div class="bcca-breadcrumb uk-margin-auto uk-margin-ri">
            <div class="bcca-breadcrumb-item">All Departments &nbsp;<i style="color:#451C16" class="fa fa-building"></i></div>
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

        @*<table class="table">
            <tr>
                <th>
                    @Html.DisplayNameFor(Function(model) model.Name)
                </th>
                <th>
                    @Html.DisplayNameFor(Function(model) model.Description)
                </th>
                <th></th>
            </tr>

            @For Each item In Model
                @<tr>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.Name)
                    </td>
                    <td>
                        @Html.DisplayFor(Function(modelItem) item.Description)
                    </td>
                    <td>
                        @Html.ActionLink("Edit", "Edit", New With {.id = item.DepartmentId}) |
                        @Html.ActionLink("Details", "Details", New With {.id = item.DepartmentId}) |
                        @Html.ActionLink("Delete", "Delete", New With {.id = item.DepartmentId})
                    </td>
                </tr>
            Next

        </table>*@

        <ul class="js-filter uk-child-width-1-2 uk-child-width-1-3@m uk-text-center" uk-grid>
            @For Each item In Model
                @<li data-color="blue">
                    <div class="uk-card uk-card-primary uk-card-body" style="color: white; background-color: #dfb748; background-image: url('../../Images/asfalt-light.png'); border-radius: 5px; font-weight: 500 ">
                        <strong>Name : </strong> @item.Name<br />
                        <strong>Desc : </strong>@item.Description<br />
                        <strong>Employees count : </strong>@item.Employees.Count<br /><br />
                        <a href="/Departments/edit/@item.DepartmentId" uk-icon="pencil"></a> <a href="/Departments/Delete/@item.DepartmentId" uk-icon="trash"></a> <a href="/Departments/Details/@item.DepartmentId" uk-icon="info"></a>
                    </div>
                </li>
            Next
        </ul>
        <br />
        <div class="uk-margin uk-margin-auto-left uk-text-center">
            <a href="/Departments/Create">
                <button type="submit" class="anotherbutton" value="Create New">Create New</button>
            </a>
        </div>
    </div>
</section>
