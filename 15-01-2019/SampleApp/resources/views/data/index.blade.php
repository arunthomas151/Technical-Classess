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
            <td><a href="{{route('datas.edit',$row->id)}}">Edit</a></td>
            <td>
                <form action="{{route('datas.destroy',$row->id)}}" method="POST">
                    @csrf
                    @method('Delete')
                    <button name="delete">Delete</button></td>
                </form>
        </tr>  
    @endforeach

</table>