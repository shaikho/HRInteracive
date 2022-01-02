@ModelType Demo.VacationsLog
@Code
    ViewData("Title") = "Details"
End Code

<section class="card-body shadow-sm p5">
    <h1 class="uk-heading-bullet uk-margin-auto uk-width-3-4 uk-margin-top">Scheduled Vacations</h1>
    <div style="position:absolute;left:18%">
        <div class="bcca-breadcrumb uk-margin-auto uk-margin-ri">
            <div class="bcca-breadcrumb-item">Vacation details <i style="color:#451C16" class="fa fa-info-circle"></i></div>
        </div>
    </div>
    <br />
    <br />
    <hr class="uk-divider-icon uk-margin-auto uk-margin-top uk-width-3-4">
    <div class="uk-child-width-expand@m uk-margin-auto uk-width-3-4">
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
    </div>
    <div Class="uk-margin uk-margin-auto-left uk-text-center">
        <a href="/Employees">
            <button type="button" class="cancelbutton"><span uk-icon="arrow-left"></span> Back</button>
        </a>
        <a href="/VacationsLogs/Edit/@Model.VacationId">
            <button type="submit" class="anotherbutton" value="Save">Edit</button>
        </a>
    </div>
</section>