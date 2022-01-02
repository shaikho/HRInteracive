@ModelType Demo.VacationType
@Code
    ViewData("Title") = "Delete"
End Code


<section class=" card-body shadow-sm p5">
    <h1 class="uk-heading-bullet uk-margin-auto uk-width-3-4 uk-margin-top">Vacation Types</h1>
    <div style="position:absolute;left:19%">
        <div class="bcca-breadcrumb uk-margin-auto uk-margin-ri">
            <div class="bcca-breadcrumb-item">Delete vacation type&nbsp;<i style="color:#451C16" class="fa fa-trash"></i></div>
        </div>
    </div>
    <br />
    <br />
    <hr class="uk-divider-icon uk-margin-auto uk-margin-top uk-width-3-4">
    <div class="uk-child-width-expand@m uk-margin-auto uk-width-3-4">
        <dl class="dl-horizontal">
            <dt>
                <h5 class="uk-heading-bullet uk-margin-auto uk-margin-top">@Html.DisplayNameFor(Function(model) model.VacatonType)</h5>
            </dt>
            <dd>
                <strong>
                    @Html.DisplayFor(Function(model) model.VacatonType)
                </strong>
            </dd>
        </dl>
        @Using (Html.BeginForm())
            @Html.AntiForgeryToken()
            @<div Class="uk-margin uk-margin-auto-left uk-text-center">
                <a href="/VacationTypes">
                    <button type="button" class="cancelbutton"><span uk-icon="arrow-left"></span> Cancel</button>
                </a>
                <Button type="submit" Class="anotherbutton" value="Save">Delete</Button>
            </div>
        End Using
    </div>

</section>