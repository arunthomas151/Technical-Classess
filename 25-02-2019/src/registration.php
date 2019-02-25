<?php
$con=mysqli_connect("localhost","root","","angular");

header("Access-Control-Allow-Origin:*");
header("Access-Control-Allow-Methods:PUT,GET,POST");
header("Access-Control-Allow-Header:origin,X-Requested-with,Content-Type,Accept");

$postdata=file_get_contents("php://input");

$request = json_decode($postdata);

$name=mysqli_real_escape_string($con,trim($request->data->name));
$email=mysqli_real_escape_string($con,trim($request->data->email));
$contact=mysqli_real_escape_string($con,trim($request->data->phone));
$pass=mysqli_real_escape_string($con,trim($request->data->password));


$sql="insert into reg values(null,'$name','$email','$contact','$pass')";
$result=mysqli_query($con,$sql);
if($result)
{
    http_response_code(201);
    $student=[
        'name'=> $name,
        'email'=> $email,
        'contact'=> $contact,
        'pass'=> $pass,
        'id'=>$mysql_insert_id($con)
    ];
    echo json_encode(['data'=>$student]);
}
else
{
    http_response_code(422);
}
?>