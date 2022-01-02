@ModelType Demo.VacationType
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>VacationType</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.VacatonType)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.VacatonType)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.VacationCode }) |
    @Html.ActionLink("Back to List", "Index")
</p>
