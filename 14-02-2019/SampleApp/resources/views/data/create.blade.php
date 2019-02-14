<html>
    <head>
        <title>Registration</title>
    </head>
    <body>
        <form method="POST" action="{{route('datas.store')}}">
            @csrf
            <table border="2">
                <tr>
                    <td><label>Name</label></td><td><input type="text" id="uname" name="uname"></td>
                </tr>
                <tr>
                    <td><label>Email</label></td><td><input type="email" id="email" name="email"></td>
                </tr>
                <tr>
                    <td><label>Password</label></td><td><input type="password" id="pword" name="pword"></td>
                </tr>
                <tr>
                    <td></td><td><input type="submit" id="submit" value="submit"></td>
                </tr>
            </table>
        </form>
    </body>
</html>