<table border="2">
    <tr>
        <th>Id</th>
        <th>Name</th>
        <th>Email</th>
        <th>Edit</th>
        <th>Delete</th>
    </tr>
    @foreach ($dbdata as $row)
        <tr>
            <td>{{($row['id'])}}</td>
            <td>{{($row['name'])}}</td>
            <td>{{($row['email'])}}</td>
            <td><a href>Edit</a></td>
            <td><a href>Delete</a></td>
        </tr>  
    @endforeach

</table>