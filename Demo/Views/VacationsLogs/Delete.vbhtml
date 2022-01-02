@ModelType Demo.VacationsLog
@Code
    ViewData("Title") = "Delete"
End Code

<section class=" card-body shadow-sm p5">
    <h1 class="uk-heading-bullet uk-margin-auto uk-width-3-4 uk-margin-top">Sceduled Vacations</h1>
    <div style="position:absolute;left:19%">
        <div class="bcca-breadcrumb uk-margin-auto uk-margin-ri">
            <div class="bcca-breadcrumb-item">Delete scheduled vacation  &nbsp;<i style="color:#451C16" class="fa fa-trash"></i></div>
        </div>
    </div>
    <br />
    <br />
    <hr class="uk-divider-icon uk-margin-auto uk-margin-top uk-width-3-4">
    <div class="uk-child-width-expand@m uk-margin-auto uk-width-3-4">
        <dl class="dl-horizontal">
            <strong>Are you sure you want to delete this?</strong>
            <dt>
                <h5 class="uk-heading-bullet uk-margin-auto uk-margin-top">@Html.DisplayNameFor(Function(model) model.StartDate)</h5>
            </dt>
            <dd>
                <strong>
                    @Html.DisplayFor(Function(model) model.StartDate)
                </strong>
            </dd>
            <dt>
                <h5 class="uk-heading-bullet uk-margin-auto uk-margin-top">@Html.DisplayNameFor(Function(model) model.EndDate)</h5>
            </dt>
            <dd>
                <strong>
                    @Html.DisplayFor(Function(model) model.EndDate)
                </strong>
            </dd>
            <dt>
                <h5 class="uk-heading-bullet uk-margin-auto uk-margin-top">@Html.DisplayNameFor(Function(model) model.Employee.Name)</h5>
            </dt>
            <dd>
                <strong>
                    @Html.DisplayFor(Function(model) model.Employee.Name)
                </strong>
            </dd>
            <dt>
                <h5 class="uk-heading-bullet uk-margin-auto uk-margin-top">@Html.DisplayNameFor(Function(model) model.VacationType.VacatonType)</h5>
            </dt>
            <dd>
                <strong>
                    @Html.DisplayFor(Function(model) model.VacationType.VacatonType)
                </strong>
            </dd>
        </dl>
    </div>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()
        @<div Class="uk-margin uk-margin-auto-left uk-text-center">
            <a href="/VacationsLogs">
                <button type="button" class="cancelbutton"><span uk-icon="arrow-left"></span> Cancel</button>
            </a>
            <Button type="submit" Class="anotherbutton" value="Save">Delete</Button>
        </div>
    End Using
</section>
