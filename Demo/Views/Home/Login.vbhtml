
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <style>
        body {
            background-color: #451C16;
            background-image: url('../../Images/asfalt-light.png');
            font-family: "Asap", sans-serif;
        }

        .login {
            overflow: hidden;
            background-color: white;
            padding: 40px 30px 30px 30px;
            border-radius: 10px;
            position: absolute;
            top: 50%;
            left: 50%;
            width: 400px;
            -webkit-transform: translate(-50%, -50%);
            -moz-transform: translate(-50%, -50%);
            -ms-transform: translate(-50%, -50%);
            -o-transform: translate(-50%, -50%);
            transform: translate(-50%, -50%);
            -webkit-transition: -webkit-transform 300ms, box-shadow 300ms;
            -moz-transition: -moz-transform 300ms, box-shadow 300ms;
            transition: transform 300ms, box-shadow 300ms;
            box-shadow: 5px 10px 10px rgba(2, 128, 144, 0.2);
        }

            .login::before, .login::after {
                content: "";
                position: absolute;
                width: 600px;
                height: 600px;
                border-top-left-radius: 40%;
                border-top-right-radius: 45%;
                border-bottom-left-radius: 35%;
                border-bottom-right-radius: 40%;
                z-index: -1;
            }

            .login::before {
                left: 40%;
                bottom: -80%;
                background-color: rgba(223, 183, 72, 0.15);
                -webkit-animation: wawes 6s infinite linear;
                -moz-animation: wawes 6s infinite linear;
                animation: wawes 6s infinite linear;
            }

            .login::after {
                left: 35%;
                bottom: -80%;
                background-color: rgba(223, 183, 72, 0.2);
                -webkit-animation: wawes 7s infinite;
                -moz-animation: wawes 7s infinite;
                animation: wawes 7s infinite;
            }

            .login > input {
                font-family: "Asap", sans-serif;
                display: block;
                border-radius: 5px;
                font-size: 16px;
                background: white;
                width: 100%;
                border: 0;
                padding: 10px 10px;
                margin: 15px -10px;
            }

            .login > a > button {
                font-family: "Asap", sans-serif;
                cursor: pointer;
                color: #fff;
                font-size: 16px;
                text-transform: uppercase;
                width: 80px;
                border: 0;
                padding: 10px 0;
                margin-top: 10px;
                margin-left: -5px;
                border-radius: 5px;
                background-color: #dfb748;
                -webkit-transition: background-color 300ms;
                -moz-transition: background-color 300ms;
                transition: background-color 300ms;
            }

                .login > a > button:hover {
                    background-color: #e8b833;
                }

        @@-webkit-keyframes wawes {
            from {
                -webkit-transform: rotate(0);
            }

            to {
                -webkit-transform: rotate(360deg);
            }
        }

        @@-moz-keyframes wawes {
            from {
                -moz-transform: rotate(0);
            }

            to {
                -moz-transform: rotate(360deg);
            }
        }

        @@keyframes wawes {
            from {
                -webkit-transform: rotate(0);
                -moz-transform: rotate(0);
                -ms-transform: rotate(0);
                -o-transform: rotate(0);
                transform: rotate(0);
            }

            to {
                -webkit-transform: rotate(360deg);
                -moz-transform: rotate(360deg);
                -ms-transform: rotate(360deg);
                -o-transform: rotate(360deg);
                transform: rotate(360deg);
            }
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
    </style>
    <title>Interactive - HR</title>
</head>
<body>
    <br />
    <br />

    <form class="login">
        <img src="~/Images/interactivelmited-removebg-preview.png" style="margin-left:30%" />
        <input type="text" placeholder="Username">
        <input type="password" placeholder="Password">
        <a href="/Home">
            <button type="button" class="cancelbutton">Login</button>
        </a>
    </form>
</body>
</html>
