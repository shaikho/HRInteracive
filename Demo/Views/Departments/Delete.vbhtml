@ModelType Demo.Department
@Code
    ViewData("Title") = "Delete"
End Code

<section class=" card-body shadow-sm p5">
    <h1 class="uk-heading-bullet uk-margin-auto uk-width-3-4 uk-margin-top">Departments</h1>
    <div style="position:absolute;left:19%">
        <div class="bcca-breadcrumb uk-margin-auto uk-margin-ri">
            <div class="bcca-breadcrumb-item">Delete department &nbsp;<i style="color:#451C16" class="fa fa-trash"></i></div>
        </div>
    </div>
    <br />
    <br />
    <hr class="uk-divider-icon uk-margin-auto uk-margin-top uk-width-3-4">
    <div class="uk-child-width-expand@m uk-margin-auto uk-width-3-4">
        <dl class="dl-horizontal">
            <p style="color:red">
                <strong>* Note : Departments containing employees can not be deleted.</strong>
            </p>
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
                <h5 class="uk-heading-bullet uk-margin-auto uk-margin-top">@Html.DisplayNameFor(Function(model) model.Description)</h5>

            </dt>
            <dd>
                <strong>
                    @Html.DisplayFor(Function(model) model.Description)
                </strong>
            </dd>
            <dt>
                <h5 class="uk-heading-bullet uk-margin-auto uk-margin-top">Emplyees count</h5>

            </dt>
            <dd>
                <strong>
                    @Html.DisplayFor(Function(model) model.Employees.Count) Employees
                </strong>
            </dd>
        </dl>
        @Using (Html.BeginForm())
            @Html.AntiForgeryToken()
            @<div Class="uk-margin uk-margin-auto-left uk-text-center">
                <a href = "/Departments" >
                    <button type="button" class="cancelbutton"><span uk-icon="arrow-left"></span> Cancel</button>
                            </a>
                <button type = "submit" class="anotherbutton" value="Save">Delete</button>
            </div>
        End Using
        </div>
</section>
