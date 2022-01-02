@ModelType Demo.Department
@Code
    ViewData("Title") = "Details"
End Code

<section class="card-body shadow-sm p5">
    <h1 class="uk-heading-bullet uk-margin-auto uk-width-3-4 uk-margin-top">Departments</h1>
    <div style="position:absolute;left:19%">
        <div class="bcca-breadcrumb uk-margin-auto uk-margin-ri">
            <div class="bcca-breadcrumb-item">Department details &nbsp;<i style="color:#451C16" class="fa fa-info-circle"></i></div>
        </div>
    </div>
    <br />
    <br />
    <hr class="uk-divider-icon uk-margin-auto uk-margin-top uk-width-3-4">
    <div class="uk-child-width-expand@m uk-margin-auto uk-width-3-4">
        <dl class="dl-horizontal">
            <dt>
                <h5 class="uk-heading-bullet uk-margin-auto uk-margin-top">@Html.DisplayNameFor(Function(model) model.Name)</h5>
            </dt>
            <dd>
                <strong>
                    @Html.DisplayFor(Function(model) model.Name)
                </strong>
            </dd>

            <dt>
                <h5 class="uk-heading-bullet uk-margin-auto uk-margin-top">@Html.DisplayNameFor(Function(model) model.Description)</h5>

            </dt>

            <dd>
                <strong>
                    @Html.DisplayFor(Function(model) model.Description)
                </strong>
            </dd>
        </dl>
        <div Class="uk-margin uk-margin-auto-left uk-text-center">
            <a href="/Departments">
                <button type="button" class="cancelbutton"><span uk-icon="arrow-left"></span> Back</button>
            </a>
            <a href="/Departments/Edit/@Model.DepartmentId">
                <button type="submit" class="anotherbutton" value="Save">Edit</button>
            </a>
        </div>
        <hr class="uk-divider-icon uk-margin-auto uk-margin-top">
        <h2 class="uk-heading-bullet uk-margin-auto uk-margin-top">Department Employees</h2>
        <br />
        <table class="table">
            <tr>
                <th>
                    Employee Name
                </th>
                <th>
                    Position
                </th>
                <th>
                    Age
                </th>
                <th>
                    Salary
                </th>
                <th>Actions</th>
            </tr>

            @For Each item In Model.Employees
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
                        <a href="/Employees/Details/@item.EmployeeId">Details</a>
                    </td>
                </tr>
            Next
        </table>
    </div>
</section>