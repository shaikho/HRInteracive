@ModelType Demo.Employee
@Code
    ViewData("Title") = "Edit"
End Code

<section class=" card-body shadow-sm p5">
    <h1 class="uk-heading-bullet uk-margin-auto uk-width-3-4 uk-margin-top">Employees</h1>
    <div style="position:absolute;left:19%">
        <div class="bcca-breadcrumb uk-margin-auto uk-margin-right">
            <div class="bcca-breadcrumb-item">Edit employee &nbsp;<i style="color:#451C16" class="fa fa-edit"></i></div>
        </div>
    </div>
    <br />
    <br />
    <hr class="uk-divider-icon uk-margin-auto uk-margin-top uk-width-3-4">
    <div class="uk-child-width-expand@m uk-margin-auto uk-width-3-4">
        @Using (Html.BeginForm())
            @Html.AntiForgeryToken()
            @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
            @Html.HiddenFor(Function(model) model.EmployeeId)

            @<div Class="form-group">
                <strong>
                    @Html.LabelFor(Function(model) model.Name)
                </strong>
                @Html.EditorFor(Function(model) model.Name, New With {.htmlAttributes = New With {.class = "form-control-lg uk-input"}})
                @Html.ValidationMessageFor(Function(model) model.Name, "", New With {.class = "text-danger"})
            </div>

            @<div Class="form-group">
                <strong>
                    @Html.LabelFor(Function(model) model.Position)
                </strong>
                @Html.EditorFor(Function(model) model.Position, New With {.htmlAttributes = New With {.class = "form-control-lg uk-input"}})
                @Html.ValidationMessageFor(Function(model) model.Position, "", New With {.class = "text-danger"})
            </div>

            @<div Class="form-group">
                <strong>
                    @Html.LabelFor(Function(model) model.Age)
                </strong>
                @Html.EditorFor(Function(model) model.Age, New With {.htmlAttributes = New With {.class = "form-control-lg uk-input"}})
                @Html.ValidationMessageFor(Function(model) model.Age, "", New With {.class = "text-danger"})
            </div>

            @<div Class="form-group">
                <strong>
                    @Html.LabelFor(Function(model) model.Salary)
                </strong>
                @Html.EditorFor(Function(model) model.Salary, New With {.htmlAttributes = New With {.class = "form-control-lg uk-input"}})
                @Html.ValidationMessageFor(Function(model) model.Salary, "", New With {.class = "text-danger"})
            </div>

            @<div Class="form-group">
                <strong>
                    @Html.LabelFor(Function(model) model.DepartmentId, "DepartmentId")
                </strong>
                @Html.DropDownList("DepartmentId", Nothing, htmlAttributes:=New With {.class = "form-control-lg uk-input"})
                @Html.ValidationMessageFor(Function(model) model.DepartmentId, "", New With {.class = "text-danger"})
            </div>

            @<div Class="uk-margin uk-margin-auto-left uk-text-center">
                <button type="submit" class="anotherbutton" value="Save">Save</button>
            </div>
        End Using
    </div>
</section>

@*@Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-horizontal">
            @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
            @Html.HiddenFor(Function(model) model.EmployeeId)

            <div class="form-group">
                @Html.LabelFor(Function(model) model.Name, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.Name, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.Name, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                @Html.LabelFor(Function(model) model.Position, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.Position, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.Position, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                @Html.LabelFor(Function(model) model.Age, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.Age, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.Age, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                @Html.LabelFor(Function(model) model.Salary, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.Salary, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.Salary, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                @Html.LabelFor(Function(model) model.DepartmentId, "DepartmentId", htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.DropDownList("DepartmentId", Nothing, htmlAttributes:=New With {.class = "form-control"})
                    @Html.ValidationMessageFor(Function(model) model.DepartmentId, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                <div class="col-md-offset-2 col-md-10">
                    <input type="submit" value="Save" class="btn btn-default" />
                </div>
            </div>
        </div>
    End Using

    <div>
        @Html.ActionLink("Back to List", "Index")
    </div>*@
