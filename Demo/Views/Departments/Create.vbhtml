@ModelType Demo.Department
@Code
    ViewData("Title") = "Create"
End Code

<section class=" card-body shadow-sm p5">
    <h1 class="uk-heading-bullet uk-margin-auto uk-width-3-4 uk-margin-top">Departments</h1>
    <div style="position:absolute;left:19%">
        <div class="bcca-breadcrumb uk-margin-auto uk-margin-ri">
            <div class="bcca-breadcrumb-item">Create new department &nbsp;<i style="color:#451C16" class="fa fa-building"></i></div>
        </div>
    </div>
    <br />
    <br />
    <hr class="uk-divider-icon uk-margin-auto uk-margin-top uk-width-3-4">
    <div class="uk-child-width-expand@m uk-margin-auto uk-width-3-4">
        @Using (Html.BeginForm())
            @Html.AntiForgeryToken()
            @<div class="form-horizontal">
                @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
                <div class="form-group">
                    <strong>
                        @Html.LabelFor(Function(model) model.Name)
                    </strong>
                    @Html.EditorFor(Function(model) model.Name, New With {.htmlAttributes = New With {.class = "form-control-lg uk-input"}})
                    @Html.ValidationMessageFor(Function(model) model.Name, "", New With {.class = "text-danger"})
                </div>
                <div class="form-group">
                    <strong>
                        @Html.LabelFor(Function(model) model.Description)
                    </strong>
                    @Html.EditorFor(Function(model) model.Description, New With {.htmlAttributes = New With {.class = "form-control-lg uk-input"}})
                    @Html.ValidationMessageFor(Function(model) model.Description, "", New With {.class = "text-danger"})
                </div>
                <div Class="uk-margin uk-margin-auto-left uk-text-center">
                    <button type="submit" class="anotherbutton" value="Save">Save</button>
                </div>
            </div>
        End Using
    </div>
</section>