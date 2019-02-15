<html>
    <head>
        <title>Registration</title>
    </head>
    <body>
        <form method="POST" action="{{route('datas.update',$value->id)}}">
            @method('PATCH')
            @csrf
            <table border="2">
                <tr>
                    <td><label>Name</label></td><td><input type="text" id="uname" name="uname" value="{{($value->name)}}"></td>
                </tr>
                <tr>
                    <td><label>Email</label></td><td><input type="email" id="email" name="email" value="{{($value->email)}}"></td>
                </tr>
                <tr>
                    <td><label>Password</label></td><td><input type="password" id="pword" name="pword" value="{{($value->password)}}"></td>
                </tr>
                <tr>
                    <td></td><td><input type="submit" id="update" value="update"></td>
                </tr>
            </table>
        </form>
    </body>
</html>