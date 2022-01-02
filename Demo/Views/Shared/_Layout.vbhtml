<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <title>Interactive - HR</title>
    <link href="~/Images/interactivelogo-removebg-preview.png" rel="shortcut icon" type="image/x-icon" />


    <!-- UIkit CSS -->
    <link href="~/Content/uikit.min.css" rel="stylesheet" />

    <!-- UIkit JS -->
    <script src="~/Scripts/uikit.min.js"></script>
    <script src="~/Scripts/uikit-icons.min.js"></script>

    <!-- Sweet Alert -->
    <script src="~/Scripts/sweetalert2.9.js"></script>

    <!-- Anime script-->
    <script src="~/Scripts/anime.min.js"></script>

    <!-- Datepicker style-->

    <style>
        [type="date"] {
            background: #fff url('../../Images/calendar_2 (1).png') 97% 50% no-repeat;
        }

            [type="date"]::-webkit-inner-spin-button {
                display: none;
            }

            [type="date"]::-webkit-calendar-picker-indicator {
                opacity: 0;
            }
    </style>

    <!-- Font awsome -->
    @*<link href="~/Content/font-awesome.min.css" rel="stylesheet" />*@
    <link href="~/Content/bootstrap.min.css" rel="stylesheet" />
    <link href="~/Content/jquerysctipttop.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">

    <!-- datatables style -->
    <!-- -->
    @*<link href="~/Content/dataTables.uikit.min.css" rel="stylesheet" />*@

    @* Form Style *@

    <style>

        * {
            -webkit-user-select: none;
            --khtml-user-select: none;
            -moz-user-select: none;
            -ms-user-select: none;
            --o-user-select: none;
            user-select: none;
        }

        .validation-summary-errors {
            color: red;
            width: 30%;
        }

        .field-validation-error {
            color: red;
        }

        thead {
            color: black;
        }

        body {
            overflow-x: hidden;
            background: -webkit-gradient(linear, left top, right top, from(#fc354c), to(#0abfbc));
            background: linear-gradient(to right, #fc354c, #0abfbc);
        }

        a {
            color: #451C16;
            text-decoration: none;
        }

            a:hover {
                color: #dfb748;
                text-decoration: none;
            }

        .uk-button-primary {
            background-color: #451C16;
            background-image: url('../../Images/asfalt-light.png');
            border-radius: 5px;
            /*margin-left: 40%;*/
        }

            .uk-button-primary:hover {
                background-color: #dfb748;
                background-image: url('../../Images/asfalt-light.png');
                border-radius: 5px;
            }

            .uk-button-primary:focus {
                background-color: #dfb748;
                background-image: url('../../Images/asfalt-light.png');
                border-radius: 5px;
            }

        .uk-select:focus {
            border-color: #dfb748;
        }

        .uk-input:focus {
            border-color: #dfb748;
        }

        .uk-textarea:focus {
            border-color: #dfb748;
        }

        .anotherbutton {
            width: 140px;
            height: 45px;
            font-size: 11px;
            text-transform: uppercase;
            letter-spacing: 2.5px;
            font-weight: 500;
            color: white;
            background-color: #fff;
            border: none;
            border-radius: 5px;
            box-shadow: 0px 8px 15px rgba(0, 0, 0, 0.1);
            transition: all 0.3s ease 0s;
            cursor: pointer;
            outline: none;
            background-color: #451C16;
            background-image: url('../../Images/asfalt-light.png');
        }

        .alsoanotherbutton {
            width: 140px;
            height: 45px;
            font-size: 11px;
            text-transform: uppercase;
            letter-spacing: 2.5px;
            font-weight: 500;
            color: white;
            background-color: #fff;
            border: none;
            border-radius: 5px;
            box-shadow: 0px 8px 15px rgba(0, 0, 0, 0.1);
            transition: all 0.3s ease 0s;
            cursor: pointer;
            outline: none;
            background-color: #451C16;
            background-image: url('../../Images/asfalt-light.png');
        }

        .cancelbutton {
            width: 140px;
            height: 45px;
            font-size: 11px;
            text-transform: uppercase;
            letter-spacing: 2.5px;
            font-weight: 500;
            color: white;
            background-color: #fff;
            border: none;
            border-radius: 5px;
            box-shadow: 0px 8px 15px rgba(0, 0, 0, 0.1);
            transition: all 0.3s ease 0s;
            cursor: pointer;
            outline: none;
            background-color: #451C16;
            background-image: url('../../Images/asfalt-light.png');
        }

        .anotherbutton:hover {
            background-color: #dfb748;
            background-image: url('../../Images/asfalt-light.png');
            box-shadow: 0px 15px 20px rgba(212, 175, 83, 0.7);
            color: #fff;
            transform: translateY(-7px);
        }

        .anotherbutton:focus {
            background-color: #dfb748;
            background-image: url('../../Images/asfalt-light.png');
            box-shadow: 0px 15px 20px rgba(212, 175, 83, 0.7);
            color: #fff;
            transform: translateY(-7px);
        }

        .alsoanotherbutton:hover {
            background-color: #dfb748;
            background-image: url('../../Images/asfalt-light.png');
            box-shadow: 0px 15px 20px rgba(212, 175, 83, 0.7);
            color: #fff;
            transform: translateX(7px);
        }

        .alsoanotherbutton:focus {
            background-color: #dfb748;
            background-image: url('../../Images/asfalt-light.png');
            box-shadow: 0px 15px 20px rgba(212, 175, 83, 0.7);
            color: #fff;
            transform: translateX(7px);
        }

        .cancelbutton:hover {
            background-color: #dfb748;
            background-image: url('../../Images/asfalt-light.png');
            box-shadow: 0px 15px 20px rgba(212, 175, 83, 0.7);
            color: #fff;
            transform: translateX(-7px);
        }

        .cancelbutton:focus {
            background-color: #dfb748;
            background-image: url('../../Images/asfalt-light.png');
            box-shadow: 0px 15px 20px rgba(212, 175, 83, 0.7);
            color: #fff;
            transform: translateX(-7px);
        }
    </style>

    @*  *@

    @* breadcrumb style *@


    <style>
        .bcca-breadcrumb {
            margin: 0 auto;
            /*margin-top: 40px;*/
        }

        /*** breadcrumb container ***/
        .bcca-breadcrumb {
            display: flex;
            flex-direction: row-reverse;
            flex-shrink: 0;
            width: 100%;
            margin-bottom: 15px;
            /*position: relative;*/
            border-radius: 4px;
        }

            /*** breadcrumb items ***/
            .bcca-breadcrumb - item {
                transition: all 0.2s ease-in-out;
                height: 40px;
                background: white;
                box-shadow: 0px 0px 18px -2px #d9d9d9;
                line-height: 40px;
                padding-left: 30px;
                padding-right: 10px;
                font-size: 13px;
                font-weight: 600;
                color: rgba(74, 74, 74, 0.8);
                position: relative;
                cursor: pointer;
                float: left;
            }

                .bcca-breadcrumb - item: after {
                    transition: all ease -in-out 0.2s;
                    content: "";
                    position: absolute;
                    /*left: calc(100% - 10px);*/
                    top: 6px;
                    z-index: 1;
                    width: 0;
                    height: 0;
                    border: 14px solid #ffffff;
                    border-left - color: transparent;
                    border-bottom - color: transparent;
                    box-shadow: 0px 0px 0 0px #d9d9d9, 5px -5px 10px -4px #d9d9d9;
                    transform: rotate(45deg);
                    margin-left: -4px;
                }

                .bcca-breadcrumb - item: last-child {
                    border-top - left - radius: 4px;
                    border-bottom - left - radius: 4px;
                    padding-left: 10px;
                }

                .bcca-breadcrumb - item: first-child {
                    border-top - right - radius: 4px;
                    border-bottom - right - radius: 4px;
                    background-color: rgba(159, 59, 62, 0.2);
                }

                    .bcca-breadcrumb - item: first-child: after {
                        content: "";
                        display: none;
                    }

                .bcca-breadcrumb - item i {
                    margin-left: 5px;
                    color: rgba(0, 0, 0, 0.2);
                }

                /*** hover breadcrumbs ***/
                .bcca-breadcrumb - item: hover {
                    background - color: #f9f9f9;
                }

                    .bcca-breadcrumb - item: hover : after {
                        border: 14px solid #f9f9f9;
                        border-left - color: transparent;
                        border-bottom - color: transparent;
                    }

                .bcca-breadcrumb - item: first-child: hover {
                    background - color: rgba(212, 175, 83, 0.15);
                }

        .bcca-breadcrumb {
            text-align: center;
        }
    </style>

    @*  *@

    @* Alerts style *@

    <style>
        .u-truncate {
            white-space: nowrap;
            overflow: hidden;
            text-overflow: ellipsis;
        }

        .u-italic {
            font-style: italic;
        }

        .u-relative {
            position: relative;
        }

        .u-fullWidth {
            min-width: 100%;
            width: 100%;
        }

        .alertContainer {
            z-index: 1000;
            display: -webkit-flex;
            display: -moz-flex;
            display: flex;
            display: -ms-flexbox;
            -webkit-flex-flow: row wrap;
            -moz-flex-flow: row wrap;
            flex-flow: row wrap;
            -ms-flex-direction: row;
            -ms-flex-wrap: wrap;
        }

            .alertContainer:not(.alerts--stackRight):not(.alerts--floatTop):not(.alerts--stackTop) {
                z-index: 1;
                position: absolute;
                top: 0;
                left: 0;
                right: 0;
            }

                .alertContainer:not(.alerts--stackRight):not(.alerts--floatTop):not(.alerts--stackTop) .alert {
                    margin: 0;
                    border-radius: 0;
                }

        .alerts--floatTop,
        .alerts--stackRight {
            padding-top: 1rem;
        }

            .alerts--floatTop .alert,
            .alerts--stackRight .alert {
                border-radius: .1rem;
                margin: 0 1rem 1rem 0;
                box-shadow: 0 0.2rem 1rem 0 rgba(0, 0, 0, 0.3);
            }

        .alerts--floatTop {
            -webkit-flex-flow: row wrap;
            -moz-flex-flow: row wrap;
            flex-flow: row wrap;
            -ms-flex-direction: row;
            -ms-flex-wrap: wrap;
            padding-left: 1rem;
        }

            .alerts--floatTop .alert {
                flex-grow: 1;
                max-width: 50rem;
            }

                .alerts--floatTop .alert .alert-title {
                    flex-grow: 1;
                }

        .alerts--stackTop .alert {
            margin: 1rem 0 0 0;
        }

        .alerts--stackRight {
            max-width: 45rem;
            border-radius: 0;
            position: absolute;
            right: 0;
            top: 0;
        }

        .alerts--limitHeight .alert {
            max-height: 15rem;
        }

        .alerts--limitHeight .alert-body {
            overflow-y: auto;
        }

        .alert {
            background-color: #33a3dc;
            padding-left: 3rem;
            font-size: 1.7rem;
            /*background-image: url(data:image/svg+xml;base64,PHN2ZyB2ZXJzaW9uPSIxLjEiIGlkPSJMYXllcl8xIiB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHhtbG5zOnhsaW5rPSJodHRwOi8vd3d3LnczLm9yZy8xOTk5L3hsaW5rIiB4PSIwcHgiIHk9IjBweCIKCSB2aWV3Qm94PSIwIDAgMzIgMzIiIHN0eWxlPSJlbmFibGUtYmFja2dyb3VuZDpuZXcgMCAwIDMyIDMyOyIgeG1sOnNwYWNlPSJwcmVzZXJ2ZSI+CjxzdHlsZSB0eXBlPSJ0ZXh0L2NzcyI+Cgkuc3Qwe2ZpbGw6I0ZGRkZGRjt9Cjwvc3R5bGU+CjxnPgoJPHBhdGggY2xhc3M9InN0MCIgZD0iTTE2LDJDOC4zLDIsMiw4LjMsMiwxNmMwLDcuNyw2LjMsMTQsMTQsMTRzMTQtNi4zLDE0LTE0QzMwLDguMywyMy43LDIsMTYsMnogTTE1LDE3aC0zdjYuNGMwLDAtNC0wLjQtNC02LjQKCQl2LTdoN1YxN3ogTTI0LDE3aC0zdjYuNGMwLDAtNC0wLjQtNC02LjR2LTdoN1YxN3oiLz4KPC9nPgo8L3N2Zz4=);*/
            background-size: 1.7rem;
            background-position: calc(3rem / 2 - 1.7rem / 2) calc(3.5rem / 2 - 1.7rem / 2);
            background-repeat: no-repeat;
            border-radius: .2rem;
            overflow: hidden;
            display: -webkit-flex;
            display: -moz-flex;
            display: flex;
            display: -ms-flexbox;
            -webkit-flex-flow: column nowrap;
            -moz-flex-flow: column nowrap;
            flex-flow: column nowrap;
            -ms-flex-direction: column;
            -ms-flex-wrap: nowrap;
        }

            .alert.is-success {
                /*background-image: url(data:image/svg+xml;base64,PHN2ZyB2ZXJzaW9uPSIxLjEiIGlkPSJzdGF0dXNOb3JtYWwiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyIgeG1sbnM6eGxpbms9Imh0dHA6Ly93d3cudzMub3JnLzE5OTkveGxpbmsiIHg9IjBweCIgeT0iMHB4IgoJIHZpZXdCb3g9IjAgMCAyNCAyNCIgZW5hYmxlLWJhY2tncm91bmQ9Im5ldyAwIDAgMjQgMjQiIHhtbDpzcGFjZT0icHJlc2VydmUiPgo8cG9seWdvbiBmaWxsPSIjRkZGRkZGIiBwb2ludHM9IjksMjEuNSAxLjIsMTMuOCA0LjgsMTAuMiA5LDE0LjUgMTkuMiw0LjIgMjIuOCw3LjggIi8+Cjwvc3ZnPg==);*/
                background-color: #71bf43;
            }

                .alert.is-success .alert-title {
                    color: #32561d;
                }

                .alert.is-success .alert-body {
                    color: #396121;
                }

            .alert.is-warning {
                /*background-image: url(data:image/svg+xml;base64,PHN2ZyB2ZXJzaW9uPSIxLjEiIGlkPSJMYXllcl8xIiB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHhtbG5zOnhsaW5rPSJodHRwOi8vd3d3LnczLm9yZy8xOTk5L3hsaW5rIiB4PSIwcHgiIHk9IjBweCIKCSB2aWV3Qm94PSIwIDAgMzIgMzIiIGVuYWJsZS1iYWNrZ3JvdW5kPSJuZXcgMCAwIDMyIDMyIiB4bWw6c3BhY2U9InByZXNlcnZlIj4KPHBhdGggZmlsbD0iI0ZGRkZGRiIgZD0iTTI4LjUsMjloLTI1Yy0xLjcsMC0yLjctMS44LTEuOS0zLjJMMTQuMSw0LjFjMC44LTEuNCwyLjktMS40LDMuOCwwbDEyLjUsMjEuN0MzMS4yLDI3LjIsMzAuMiwyOSwyOC41LDI5eiIKCS8+CjxnPgoJPGNpcmNsZSBmaWxsPSIjRThBRjAwIiBjeD0iMTYiIGN5PSIyNSIgcj0iMiIvPgoJPHBhdGggZmlsbD0iI0U4QUYwMCIgZD0iTTE1LDhoMmMwLjYsMCwxLDAuNCwxLDF2MTFjMCwwLjYtMC40LDEtMSwxaC0yYy0wLjYsMC0xLTAuNC0xLTFWOUMxNCw4LjQsMTQuNCw4LDE1LDh6Ii8+CjwvZz4KPC9zdmc+);*/
                background-color: #e6b003;
            }

                .alert.is-warning .alert-title {
                    color: #594401;
                }

                .alert.is-warning .alert-body {
                    color: #685001;
                }

            .alert.is-alert {
                /*background-image: url(data:image/svg+xml;base64,PHN2ZyB2ZXJzaW9uPSIxLjEiIGlkPSJMYXllcl8xIiB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHhtbG5zOnhsaW5rPSJodHRwOi8vd3d3LnczLm9yZy8xOTk5L3hsaW5rIiB4PSIwcHgiIHk9IjBweCIKCSB2aWV3Qm94PSIwIDAgMzIgMzIiIGVuYWJsZS1iYWNrZ3JvdW5kPSJuZXcgMCAwIDMyIDMyIiB4bWw6c3BhY2U9InByZXNlcnZlIj4KPGNpcmNsZSBmaWxsPSIjRkZGRkZGIiBjeD0iMTYiIGN5PSIxNiIgcj0iMTQiLz4KPGc+Cgk8Y2lyY2xlIGZpbGw9IiNCRTFFMkMiIGN4PSIxNiIgY3k9IjI0IiByPSIyIi8+Cgk8cGF0aCBmaWxsPSIjQkUxRTJDIiBkPSJNMTUsN2gyYzAuNiwwLDEsMC40LDEsMXYxMWMwLDAuNi0wLjQsMS0xLDFoLTJjLTAuNiwwLTEtMC40LTEtMVY4QzE0LDcuNCwxNC40LDcsMTUsN3oiLz4KPC9nPgo8L3N2Zz4=);*/
                background-color: #da2028;
            }

                .alert.is-alert .alert-title {
                    color: #5d0e11;
                }

                .alert.is-alert .alert-body {
                    color: #6b1014;
                }

        > .alert .alert-container.is-success {
            order: 0;
        }

        > .alert .alert-container.is-warning {
            order: -1;
        }

        > .alert .alert-container.is-alert {
            order: -2;
        }

        .alert .alert-title {
            color: #15587a;
            padding: 1rem 3rem 1rem 1rem;
            background-color: rgba(255, 255, 255, 0.55);
            font-size: 1.0rem;
            line-height: 1.3;
            font-weight: bold;
            position: relative;
            min-width: 0;
            -webkit-flex: 0 0 auto;
            -moz-flex: 0 0 auto;
            -ms-flex: 0 0 auto;
            flex: 0 0 auto;
        }

            .alert .alert-title .alert-dismiss {
                display: inline-block;
                position: absolute;
                top: 0;
                right: 0;
                width: 2.0rem;
                height: 2.0rem;
                /*background-image: url(data:image/svg+xml;base64,PHN2ZyB2ZXJzaW9uPSIxLjEiIGlkPSJMYXllcl8xIiB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHhtbG5zOnhsaW5rPSJodHRwOi8vd3d3LnczLm9yZy8xOTk5L3hsaW5rIiB4PSIwcHgiIHk9IjBweCIKCSB2aWV3Qm94PSIwIDAgMzIgMzIiIHN0eWxlPSJlbmFibGUtYmFja2dyb3VuZDpuZXcgMCAwIDMyIDMyOyIgeG1sOnNwYWNlPSJwcmVzZXJ2ZSI+CjxzdHlsZSB0eXBlPSJ0ZXh0L2NzcyI+Cgkuc3Qwe2ZpbGw6I0ZGRkZGRjtzdHJva2U6I0ZGRkZGRjtzdHJva2Utd2lkdGg6MS41O3N0cm9rZS1taXRlcmxpbWl0OjEwO30KPC9zdHlsZT4KPGxpbmUgY2xhc3M9InN0MCIgeDE9IjkiIHkxPSI5IiB4Mj0iMjMiIHkyPSIyMyIvPgo8bGluZSBjbGFzcz0ic3QwIiB4MT0iMjMiIHkxPSI5IiB4Mj0iOSIgeTI9IjIzIi8+Cjwvc3ZnPg==);*/
                background-repeat: no-repeat;
                cursor: pointer;
            }

                .alert .alert-title .alert-dismiss:not(:hover) {
                    opacity: 0.6;
                }

        .alert .alert-body {
            color: #145576;
            padding: 1rem;
            background-color: rgba(255, 255, 255, 0.65);
            border-top: solid 0.1rem rgba(212,175,83, 0.1);
            font-size: 1.0rem;
            line-height: 1.3;
            flex-grow: 1;
            overflow-y: auto;
        }

        @@media (max-width: 650px) {
            .alert {
                min-width: none;
                width: 100%;
            }
        }

        .alertColors--default {
            background-color: #c2e3f5;
            color: #0e394f;
        }

        .alertColor--default {
            color: #2087bc;
        }

        .alertColors--warning {
            background-color: #f8e7b3;
            color: #362901;
        }

        .alertColor--warning {
            color: #b48902;
        }

        .alertColors--alert {
            background-color: #f4bcbf;
            color: #3e090b;
        }

        .alertColor--alert {
            color: #ae1920;
        }

        .alertColors--success {
            background-color: #d4ecc7;
            color: #233b14;
        }

        .alertColor--success {
            color: #5a9a35;
        }
    </style>

    @*  *@

    @* Table Style *@

    <style>

        .table-responsive {
            min-height: .01%;
            overflow-x: auto;
        }

        @@media screen and (max-width: 801px) {
            .table-responsive {
                width: 100%;
                overflow-y: hidden;
                -ms-overflow-style: -ms-autohiding-scrollbar;
            }
        }

        /* Default table */
        table {
            border-collapse: collapse;
            border-spacing: 0;
            -webkit-box-shadow: 0px 7px 6px -6px rgba(0, 0, 0, .28);
            -moz-box-shadow: 0px 7px 6px -6px rgba(0, 0, 0, .28);
            box-shadow: 0px 7px 6px -6px rgba(0, 0, 0, .28);
            margin-bottom: 40px;
            margin-top: .5em;
            width: 100%;
            max-width: 100%;
        }

            table thead tr {
                border-bottom: 3px solid #451C16;
                color: #000;
            }

            table tfoot tr {
                border-top: 3px solid #451C16;
            }

            table thead th,
            table tfoot th {
                background-color: #fff;
                color: #000;
                font-size: .83333em;
                line-height: 1.8;
                padding: 15px 14px 13px 14px;
                position: relative;
                text-align: left;
                text-transform: uppercase;
            }

            table tbody tr {
                background-color: #fff;
            }

                table tbody tr:hover {
                    background-color: #eee;
                    color: #000;
                }

            table th,
            table td {
                border: 1px solid #bfbfbf;
                padding: 10px 14px;
                position: relative;
                vertical-align: middle;
            }

        caption {
            font-size: 1.111em;
            font-weight: 300;
            padding: 10px 0;
        }

        @@media (max-width:1024px) {
            table {
                font-size: .944444em;
            }
        }

        @@media (max-width:767px) {
            table {
                font-size: 1em;
            }
        }

        /* Responsive table full */
        @@media (max-width: 767px) {
            .table-responsive-full {
                box-shadow: none;
            }

                .table-responsive-full thead tr,
                .table-responsive-full tfoot tr {
                    display: none;
                }

                .table-responsive-full tbody tr {
                    -webkit-box-shadow: 0px 7px 6px -6px rgba(0, 0, 0, .28);
                    -moz-box-shadow: 0px 7px 6px -6px rgba(0, 0, 0, .28);
                    box-shadow: 0px 7px 6px -6px rgba(0, 0, 0, .28);
                    margin-bottom: 20px;
                }

                    .table-responsive-full tbody tr:last-child {
                        margin-bottom: 0;
                    }

                .table-responsive-full tr,
                .table-responsive-full td {
                    display: block;
                }

                .table-responsive-full td {
                    background-color: #fff;
                    border-top: none;
                    position: relative;
                    padding-left: 50%;
                }

                    .table-responsive-full td:hover {
                        background-color: #eee;
                        color: #000;
                    }

                        .table-responsive-full td:hover:before {
                            color: hsl(0, 0%, 40%);
                        }

                    .table-responsive-full td:first-child {
                        border-top: 1px solid #bfbfbf;
                        border-bottom: 3px solid #451C16;
                        border-radius: 4px 4px 0 0;
                        color: #000;
                        font-size: 1.11111em;
                        font-weight: bold;
                    }

                    .table-responsive-full td:before {
                        content: attr(data-label);
                        display: inline-block;
                        color: hsl(0, 0%, 60%);
                        font-size: 14px;
                        font-weight: normal;
                        margin-left: -100%;
                        text-transform: uppercase;
                        width: 100%;
                        white-space: nowrap;
                    }
        }

        @@media (max-width: 360px) {
            .table-responsive-full td {
                /*padding-left: 14px;*/
            }

                .table-responsive-full td:before {
                    display: block;
                    margin-bottom: .5em;
                    margin-left: 0;
                }
        }

        /* Sort table */
        .sort-table-arrows {
            float: right;
            transition: .3s ease;
        }

            .sort-table-arrows button {
                margin: 0;
                padding: 4px 8px;
            }

        .sort-table th.title,
        .sort-table th.composer {
            width: 20% !important;
        }

        .sort-table th.lyrics,
        .sort-table th.arranger,
        .sort-table th.set,
        .sort-table th.info {
            width: 15% !important;
        }

        .sort-table .title {
            font-weight: bold;
        }

            .sort-table .title small {
                font-weight: normal;
            }

        @@media (max-width:1024px) {

            .sort-table th,
            .sort-table-arrows {
                text-align: center;
            }

            .sort-table-arrows {
                float: none;
                padding: 8px 0 0;
                position: relative;
                right: 0px;
            }

                .sort-table-arrows button {
                    bottom: 0;
                }
        }

        @@media (max-width:767px) {
            .sort-table thead tr {
                border-bottom: none;
                display: block;
                margin: 10px 0;
                text-align: center;
            }

                .sort-table thead tr th.arranger {
                    display: none;
                }

            .sort-table th {
                border-bottom: 1px solid #451C16;
                border-radius: 4px;
                display: inline-block;
                font-size: .75em;
                line-height: 1;
                margin: 3px 0;
                padding: 10px;
            }

                .sort-table th.title,
                .sort-table th.composer,
                .sort-table th.lyrics,
                .sort-table th.set,
                .sort-table th.info {
                    width: 100px !important;
                }

            .sort-table td.title:before {
                display: none;
            }

            .sort-table td.title {
                letter-spacing: .03em;
                padding-left: 14px;
            }
        }
    </style>

    @*  *@

    @* loader style *@

    <style>

        .loader {
            position: absolute;
            width: 15rem;
            height: 15rem;
            left: 50%;
            top: 50%;
            -moz-transform: translateX(-50%) translateY(-50%) rotate(-90deg) scaleX(-1);
            -ms-transform: translateX(-50%) translateY(-50%) rotate(-90deg) scaleX(-1);
            -webkit-transform: translateX(-50%) translateY(-50%) rotate(-90deg) scaleX(-1);
            transform: translateX(-50%) translateY(-50%) rotate(-90deg) scaleX(-1);
        }

            .loader div {
                position: absolute;
                left: 0;
                width: 0.5rem;
                height: 0.5rem;
                background: white;
                border-radius: 1rem;
                opacity: 0;
            }

                .loader div:nth-child(1) {
                    top: 0rem;
                    background: #c1575b;
                    -moz-animation: dna_rotate 2s 0s infinite ease-in-out;
                    -webkit-animation: dna_rotate 2s 0s infinite ease-in-out;
                    animation: dna_rotate 2s 0s infinite ease-in-out;
                }

                .loader div:nth-child(2) {
                    top: 0.6rem;
                    background: #dbbd70;
                    -moz-animation: dna_rotate 2s 1.1s infinite ease-in-out;
                    -webkit-animation: dna_rotate 2s 1.1s infinite ease-in-out;
                    animation: dna_rotate 2s 1.1s infinite ease-in-out;
                }

                .loader div:nth-child(3) {
                    top: 1.2rem;
                    background: #c1575b;
                    -moz-animation: dna_rotate 2s 0.2s infinite ease-in-out;
                    -webkit-animation: dna_rotate 2s 0.2s infinite ease-in-out;
                    animation: dna_rotate 2s 0.2s infinite ease-in-out;
                }

                .loader div:nth-child(4) {
                    top: 1.8rem;
                    background: #dbbd70;
                    -moz-animation: dna_rotate 2s 1.3s infinite ease-in-out;
                    -webkit-animation: dna_rotate 2s 1.3s infinite ease-in-out;
                    animation: dna_rotate 2s 1.3s infinite ease-in-out;
                }

                .loader div:nth-child(5) {
                    top: 2.4rem;
                    background: #c1575b;
                    -moz-animation: dna_rotate 2s 0.4s infinite ease-in-out;
                    -webkit-animation: dna_rotate 2s 0.4s infinite ease-in-out;
                    animation: dna_rotate 2s 0.4s infinite ease-in-out;
                }

                .loader div:nth-child(6) {
                    top: 3rem;
                    background: #dbbd70;
                    -moz-animation: dna_rotate 2s 1.5s infinite ease-in-out;
                    -webkit-animation: dna_rotate 2s 1.5s infinite ease-in-out;
                    animation: dna_rotate 2s 1.5s infinite ease-in-out;
                }

                .loader div:nth-child(7) {
                    top: 3.6rem;
                    background: #451C16;
                    -moz-animation: dna_rotate 2s 0.6s infinite ease-in-out;
                    -webkit-animation: dna_rotate 2s 0.6s infinite ease-in-out;
                    animation: dna_rotate 2s 0.6s infinite ease-in-out;
                }

                .loader div:nth-child(8) {
                    top: 4.2rem;
                    background: #dbbd70;
                    -moz-animation: dna_rotate 2s 1.7s infinite ease-in-out;
                    -webkit-animation: dna_rotate 2s 1.7s infinite ease-in-out;
                    animation: dna_rotate 2s 1.7s infinite ease-in-out;
                }

                .loader div:nth-child(9) {
                    top: 4.8rem;
                    background: #c1575b;
                    -moz-animation: dna_rotate 2s 0.8s infinite ease-in-out;
                    -webkit-animation: dna_rotate 2s 0.8s infinite ease-in-out;
                    animation: dna_rotate 2s 0.8s infinite ease-in-out;
                }

                .loader div:nth-child(10) {
                    top: 5.4rem;
                    background: #dbbd70;
                    -moz-animation: dna_rotate 2s 1.9s infinite ease-in-out;
                    -webkit-animation: dna_rotate 2s 1.9s infinite ease-in-out;
                    animation: dna_rotate 2s 1.9s infinite ease-in-out;
                }

                .loader div:nth-child(11) {
                    top: 6rem;
                    background: #c1575b;
                    -moz-animation: dna_rotate 2s 1s infinite ease-in-out;
                    -webkit-animation: dna_rotate 2s 1s infinite ease-in-out;
                    animation: dna_rotate 2s 1s infinite ease-in-out;
                }

                .loader div:nth-child(12) {
                    top: 6.6rem;
                    background: #dbbd70;
                    -moz-animation: dna_rotate 2s 2.1s infinite ease-in-out;
                    -webkit-animation: dna_rotate 2s 2.1s infinite ease-in-out;
                    animation: dna_rotate 2s 2.1s infinite ease-in-out;
                }

                .loader div:nth-child(13) {
                    top: 7.2rem;
                    background: #c1575b;
                    -moz-animation: dna_rotate 2s 1.2s infinite ease-in-out;
                    -webkit-animation: dna_rotate 2s 1.2s infinite ease-in-out;
                    animation: dna_rotate 2s 1.2s infinite ease-in-out;
                }

                .loader div:nth-child(14) {
                    top: 7.8rem;
                    background: #dbbd70;
                    -moz-animation: dna_rotate 2s 2.3s infinite ease-in-out;
                    -webkit-animation: dna_rotate 2s 2.3s infinite ease-in-out;
                    animation: dna_rotate 2s 2.3s infinite ease-in-out;
                }

                .loader div:nth-child(15) {
                    top: 8.4rem;
                    background: #c1575b;
                    -moz-animation: dna_rotate 2s 1.4s infinite ease-in-out;
                    -webkit-animation: dna_rotate 2s 1.4s infinite ease-in-out;
                    animation: dna_rotate 2s 1.4s infinite ease-in-out;
                }

                .loader div:nth-child(16) {
                    top: 9rem;
                    background: #dbbd70;
                    -moz-animation: dna_rotate 2s 2.5s infinite ease-in-out;
                    -webkit-animation: dna_rotate 2s 2.5s infinite ease-in-out;
                    animation: dna_rotate 2s 2.5s infinite ease-in-out;
                }

                .loader div:nth-child(17) {
                    top: 9.6rem;
                    background: #c1575b;
                    -moz-animation: dna_rotate 2s 1.6s infinite ease-in-out;
                    -webkit-animation: dna_rotate 2s 1.6s infinite ease-in-out;
                    animation: dna_rotate 2s 1.6s infinite ease-in-out;
                }

                .loader div:nth-child(18) {
                    top: 10.2rem;
                    background: #dbbd70;
                    -moz-animation: dna_rotate 2s 2.7s infinite ease-in-out;
                    -webkit-animation: dna_rotate 2s 2.7s infinite ease-in-out;
                    animation: dna_rotate 2s 2.7s infinite ease-in-out;
                }

                .loader div:nth-child(19) {
                    top: 10.8rem;
                    background: #c1575b;
                    -moz-animation: dna_rotate 2s 1.8s infinite ease-in-out;
                    -webkit-animation: dna_rotate 2s 1.8s infinite ease-in-out;
                    animation: dna_rotate 2s 1.8s infinite ease-in-out;
                }

                .loader div:nth-child(20) {
                    top: 11.4rem;
                    background: #dbbd70;
                    -moz-animation: dna_rotate 2s 2.9s infinite ease-in-out;
                    -webkit-animation: dna_rotate 2s 2.9s infinite ease-in-out;
                    animation: dna_rotate 2s 2.9s infinite ease-in-out;
                }

                .loader div:nth-child(21) {
                    top: 12rem;
                    background: #c1575b;
                    -moz-animation: dna_rotate 2s 2s infinite ease-in-out;
                    -webkit-animation: dna_rotate 2s 2s infinite ease-in-out;
                    animation: dna_rotate 2s 2s infinite ease-in-out;
                }

                .loader div:nth-child(22) {
                    top: 12.6rem;
                    background: #dbbd70;
                    -moz-animation: dna_rotate 2s 3.1s infinite ease-in-out;
                    -webkit-animation: dna_rotate 2s 3.1s infinite ease-in-out;
                    animation: dna_rotate 2s 3.1s infinite ease-in-out;
                }

                .loader div:nth-child(23) {
                    top: 13.2rem;
                    background: #c1575b;
                    -moz-animation: dna_rotate 2s 2.2s infinite ease-in-out;
                    -webkit-animation: dna_rotate 2s 2.2s infinite ease-in-out;
                    animation: dna_rotate 2s 2.2s infinite ease-in-out;
                }

                .loader div:nth-child(24) {
                    top: 13.8rem;
                    background: #dbbd70;
                    -moz-animation: dna_rotate 2s 3.3s infinite ease-in-out;
                    -webkit-animation: dna_rotate 2s 3.3s infinite ease-in-out;
                    animation: dna_rotate 2s 3.3s infinite ease-in-out;
                }

                .loader div:nth-child(25) {
                    top: 14.4rem;
                    background: #c1575b;
                    -moz-animation: dna_rotate 2s 2.4s infinite ease-in-out;
                    -webkit-animation: dna_rotate 2s 2.4s infinite ease-in-out;
                    animation: dna_rotate 2s 2.4s infinite ease-in-out;
                }

                .loader div:nth-child(26) {
                    top: 15rem;
                    background: #dbbd70;
                    -moz-animation: dna_rotate 2s 3.5s infinite ease-in-out;
                    -webkit-animation: dna_rotate 2s 3.5s infinite ease-in-out;
                    animation: dna_rotate 2s 3.5s infinite ease-in-out;
                }

        @@-moz-keyframes dna_rotate {
            0% {
                opacity: 1;
                -moz-transform: scale(1);
                transform: scale(1);
                left: 40%;
                z-index: 0;
            }

            25% {
                opacity: 1;
                -moz-transform: scale(1.8);
                transform: scale(1.8);
            }

            50% {
                opacity: 1;
                left: 60%;
                z-index: 1;
                -moz-transform: scale(1);
                transform: scale(1);
            }

            75% {
                opacity: 1;
                -moz-transform: scale(0.5);
                transform: scale(0.5);
            }

            100% {
                opacity: 1;
                left: 40%;
                z-index: 0;
                -moz-transform: scale(1);
                transform: scale(1);
            }
        }

        @@-webkit-keyframes dna_rotate {
            0% {
                opacity: 1;
                -webkit-transform: scale(1);
                transform: scale(1);
                left: 40%;
                z-index: 0;
            }

            25% {
                opacity: 1;
                -webkit-transform: scale(1.8);
                transform: scale(1.8);
            }

            50% {
                opacity: 1;
                left: 60%;
                z-index: 1;
                -webkit-transform: scale(1);
                transform: scale(1);
            }

            75% {
                opacity: 1;
                -webkit-transform: scale(0.5);
                transform: scale(0.5);
            }

            100% {
                opacity: 1;
                left: 40%;
                z-index: 0;
                -webkit-transform: scale(1);
                transform: scale(1);
            }
        }

        @@keyframes dna_rotate {
            0% {
                opacity: 1;
                -moz-transform: scale(1);
                -ms-transform: scale(1);
                -webkit-transform: scale(1);
                transform: scale(1);
                left: 40%;
                z-index: 0;
            }

            25% {
                opacity: 1;
                -moz-transform: scale(1.8);
                -ms-transform: scale(1.8);
                -webkit-transform: scale(1.8);
                transform: scale(1.8);
            }

            50% {
                opacity: 1;
                left: 60%;
                z-index: 1;
                -moz-transform: scale(1);
                -ms-transform: scale(1);
                -webkit-transform: scale(1);
                transform: scale(1);
            }

            75% {
                opacity: 1;
                -moz-transform: scale(0.5);
                -ms-transform: scale(0.5);
                -webkit-transform: scale(0.5);
                transform: scale(0.5);
            }

            100% {
                opacity: 1;
                left: 40%;
                z-index: 0;
                -moz-transform: scale(1);
                -ms-transform: scale(1);
                -webkit-transform: scale(1);
                transform: scale(1);
            }
        }
    </style>

    @*  *@

    @* Loading text style *@

    <style>
        .ml16 {
            padding-top: 10%;
            color: #402d2d;
            padding: 40px 0;
            font-weight: 800;
            font-size: 1.6em;
            text-transform: uppercase;
            letter-spacing: 0.1em;
            overflow: hidden;
        }

            .ml16 .letter {
                display: inline-block;
                line-height: 1em;
            }
    </style>

    @*  *@

    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>

@* loader *@

<div class="socket" id="loader" style=" position: absolute; left: 35%; top: 50%; visibility: hidden; z-index: 200">
    <div class='loader'>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
        <div></div>
    </div>
    <h1 style="margin-top:40%" class="ml16">Processing your request ...</h1>
</div>

@*  *@

<body style="background-color: #451C16; background-image: url('../../Images/asfalt-light.png'); height: auto; min-height: 100vh; padding-right: 15px ">
    <div class="uk-container">
        <!-- nav -->
        <nav class="uk-navbar-container uk-visible@l" uk-navbar style="border-radius: 5px; background-image: url('../../Images/fabric-of-squares.png'); width: 102%">
            <div class="uk-navbar-left">
                <a class="uk-navbar-item uk-logo" href="@Url.Action("Index", "Home")"><img src="~/Images/interactivelogo-removebg-preview.png" width="70" height="70" /></a>
                <ul class="uk-navbar-nav">
                    <li>
                        <a href="@Url.Action("Index", "Home")" style="color:#451C16;font-weight:700" uk-icon="home"></a>
                    </li>
                    <li>
                        <a style="color:#451C16;font-weight:700">
                            Employees
                        </a>
                        <div class="uk-navbar-dropdown">
                            <ul class="uk-nav uk-navbar-dropdown-nav">
                                <li style="font-weight:500"><a href="/Employees"> All Employees</a></li>
                                <li style="font-weight:500"><a href="/Employees/Create">Add Employee</a></li>

                            </ul>
                        </div>
                    </li>
                    <li>
                        <a style="color:#451C16;font-weight:700">
                            Departments
                        </a>
                        <div class="uk-navbar-dropdown">
                            <ul class="uk-nav uk-navbar-dropdown-nav">
                                <li style="font-weight:500"><a href="/Departments"> All Departments</a></li>
                                <li style="font-weight:500"><a href="/Departments/Create">Add Department</a></li>

                            </ul>
                        </div>
                    </li>
                    <li>
                        <a style="color:#451C16;font-weight:700">
                            Vacations
                        </a>
                        <div class="uk-navbar-dropdown">
                            <ul class="uk-nav uk-navbar-dropdown-nav">
                                <li style="font-weight:500"><a href="/VacationsLogs">Scheduled Vacations</a></li>
                                <li style="font-weight:500"><a href="/VacationTypes">Vacation Types Management</a></li>

                            </ul>
                        </div>
                    </li>
                    @*<li>
                        <a style="color:#451C16;font-weight:700">
                            TEST
                        </a>
                    </li>*@
                </ul>
            </div>
            <div class="uk-navbar-right">
                <ul class="uk-navbar-nav">
                    <li style="margin-right:10px">
                        <a href="/Home/Login" style="color: #451C16"><button type="submit" class="alsoanotherbutton" onclick="window.location.href='<%= Url.Action(" Logout","Home") %>Logout <span uk-icon="sign-out"></span></button></a>
                    </li>
                </ul>
            </div>
        </nav>
        <!-- content -->
        <div class="uk-container" style="background-color: #451C16; background-image: url('../../Images/fabric-of-squares.png'); border-radius: 5px; width: 100%; height: 100%; background-color: white; margin-top: 1%; padding: 1%">
            @RenderBody()
        </div>
    </div>
    @Scripts.Render("~/bundles/jquery")
</body>
</html>

@* datepicker scripts //todo cleaned up *@

<script>

    //datepicker script
    $(function () {

        $.fn.datepicker.defaults.format = "dd/mm/yyyy";
        $('.datepicker').datepicker({
        });
        $('#sandbox-container .input-append.date').datepicker({

        });
        $('#sandbox-container .input-append.date').datepicker({
            format: "dd/mm/yyyy",
            clearBtn: true,
            multidate: false,
            multidateSeparator: "/"
        });

    });

    $(function () {

        $.fn.datepicker.defaults.format = "dd/mm/yyyy";
        $('.datepicker').datepicker({
        });
        $('#sandbox-container .input-append.date').datepicker({

        });
        $('#sandbox-container .input-append.date').datepicker({
            format: "dd/mm/yyyy",
            clearBtn: true,
            multidate: false,
            multidateSeparator: "/"
        });

    });

    $(function () {

        $.fn.datepicker.defaults.format = "dd/mm/yyyy";
        $('.datepicker').datepicker({
        });
        $('#sandbox-container .input-append.date').datepicker({

        });
        $('#sandbox-container .input-append.date').datepicker({
            format: "dd/mm/yyyy",
            clearBtn: true,
            multidate: false,
            multidateSeparator: "/"
        });

    });

    //From Date picker
    $('#datepicker').datepicker({
        format: "dd/mm/yyyy",
        autoclose: true
    });
    //To Date picker
    $('#Todatepicker').datepicker({
        format: "dd/mm/yyyy",
        autoclose: true
    });

</script>

@* overlay and alerts hiding script *@

<script type="text/javascript">

    $(document).on('submit', 'form', function () {
        $('#myOverlay').show();
        document.getElementById("loader").style.visibility = "visible";
        setTimeout(function () {
            $('#myOverlay').hide();
            $('#loader').hide();
        }, 20000);
    });

    window.setTimeout(function () {
        $(".alert").fadeTo(500, 0).slideUp(500, function () {
            $(this).remove();
        });
    }, 10000);
</script>

<script>
    // This is a guide using Jquery - Project .js may vary and implementation may vary as well based on tech stack

    $('.alert-dismiss').click(function () {
        var target = $(this);
        if (target.closest('.alertContainer').hasClass('alerts--floatTop')) {
            target.closest('.alert').fadeOut(400)
        } else {
            target.closest('.alert').slideUp()
        }
    });

</script>

@* datepicker script *@

<script type="text/javascript">
    var foopicker = new FooPicker({
        id: 'datepicker',
        dateFormat: 'dd/MM/yyyy',
        disable: ['29/07/2017', '30/07/2017', '31/07/2017', '01/08/2017']
    });
    var foopicker2 = new FooPicker({
        id: 'datepicker2',
        dateFormat: 'dd/MM/yyyy',
        disable: ['29/07/2017', '30/07/2017', '31/07/2017', '01/08/2017']
    });
</script>

@*  *@

@*  Datatables scripts*@

<script>

    //datatables
    $(document).ready(function () {
        $('#example').DataTable({
            "paging": true,
            "ordering": false,
            "info": false
        });
    });

</script>
<script src="~/Scripts/jquery.dataTables.min.js"></script>
@*<script src="~/Scripts/dataTables.uikit.min.js"></script>*@

@*  *@

@* loading text script *@

<script>
    // Wrap every letter in a span
    var textWrapper = document.querySelector('.ml16');
    textWrapper.innerHTML = textWrapper.textContent.replace(/\ S / g, "<span class='letter'>$&</span>");

    anime.timeline({ loop: true })
        .add({
            targets: '.ml16 .letter',
            translateY: [-100, 0],
            easing: "easeOutExpo",
            duration: 1400,
            delay: (el, i) => 30 * i
        }).add({
            targets: '.ml16',
            opacity: 0,
            duration: 1000,
            easing: "easeOutExpo",
            delay: 1000
        });

</script>

@*  *@

@* Mobile menu script *@

<script>
    $(document).ready(function () {
        var touch = $('#resp-menu');
        var menu = $('.menu');

        $(touch).on('click', function (e) {
            e.preventDefault();
            menu.slideToggle();
        });

        $(window).resize(function () {
            var w = $(window).width();
            if (w > 767 && menu.is(':hidden')) {
                menu.removeAttr('style');
            }
        });

    });
</script>

@*  *@

