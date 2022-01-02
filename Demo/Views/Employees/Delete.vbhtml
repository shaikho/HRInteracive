@ModelType Demo.Employee
@Code
    ViewData("Title") = "Delete"
End Code

<section class=" card-body shadow-sm p5">
    <h1 class="uk-heading-bullet uk-margin-auto uk-width-3-4 uk-margin-top">Employees</h1>
    <div style="position:absolute;left:19%">
        <div class="bcca-breadcrumb uk-margin-auto uk-margin-right">
            <div class="bcca-breadcrumb-item">Delete  &nbsp;<i style="color:#451C16" class="fa fa-trash"></i></div>
        </div>
    </div>
    <br />
    <br />
    <hr class="uk-divider-icon uk-margin-auto uk-margin-top uk-width-3-4">
    <div class="uk-child-width-expand@m uk-margin-auto uk-width-3-4">
        <dl class="dl-horizontal">
            <strong>Are you sure you want to delete this?</strong>
            <dt>
                <h5 class="uk-heading-bullet uk-margin-auto uk-margin-top">@Html.DisplayNameFor(Function(model) model.Name)</h5>
            </dt>
            <dd>
                <strong>
                    @Html.DisplayFor(Function(model) model.Name)
                </strong>
            </dd>
            <dt>
                <h5 class="uk-heading-bullet uk-margin-auto uk-margin-top">@Html.DisplayNameFor(Function(model) model.Position)</h5>
            </dt>
            <dd>
                <strong>
                    @Html.DisplayFor(Function(model) model.Position)
                </strong>
            </dd>
            <dt>
                <h5 class="uk-heading-bullet uk-margin-auto uk-margin-top">@Html.DisplayNameFor(Function(model) model.Age)</h5>
            </dt>
            <dd>
                <strong>
                    @Html.DisplayFor(Function(model) model.Age)
                </strong>
            </dd>
            <dt>
                <h5 class="uk-heading-bullet uk-margin-auto uk-margin-top">@Html.DisplayNameFor(Function(model) model.Position)</h5>
            </dt>
            <dd>
                <strong>
                    @Html.DisplayFor(Function(model) model.Position)
                </strong>
            </dd>
            <dt>
                <h5 class="uk-heading-bullet uk-margin-auto uk-margin-top">@Html.DisplayNameFor(Function(model) model.Department)</h5>
            </dt>
            <dd>
                <strong>
                    @Html.DisplayFor(Function(model) model.Department.Name)
                </strong>
            </dd>
        </dl>
        @Using (Html.BeginForm())
            @Html.AntiForgeryToken()
            @<div Class="uk-margin uk-margin-auto-left uk-text-center">
                <a href="/Employees">
                    <button type="button" class="cancelbutton"><span uk-icon="arrow-left"></span> Cancel</button>
                </a>
                <button type="submit" class="anotherbutton" value="Save">Delete</button>
            </div>
        End Using
    </div>
</section>

@*<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Employee</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Position)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Position)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Age)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Age)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Salary)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Salary)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Department.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Department.Name)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>*@
