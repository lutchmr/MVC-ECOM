<?php
// $servername = "localhost";
// $database = "furndb";
// $username = "root";
// $password = "Lambo@786";
// Create connection

// $conn = mysqli_connect($servername, $username, $password, $database);

// Check connection

// if ($conn->connect_error) {
// die("Connection failed: " . $conn->connect_error);
// }

// echo "Connected successfully";

// mysqli_close($conn);

$connection = mysql_connect("localhost", "root", "Lambo@786"); // Establishing connection with server..
$db = mysql_select_db("furndb", $connection); // Selecting Database.
$email_id=$_POST['email1']; // Fetching Values from URL.
$password= sha1($_POST['password1']); // Password Encryption, If you like you can also leave sha1.
// check if e-mail address syntax is valid or not
$email_id = filter_var($email_id, FILTER_SANITIZE_EMAIL); // sanitizing email(Remove unexpected symbol like <,>,?,#,!, etc.)
if (!filter_var($email_id, FILTER_VALIDATE_EMAIL)){
echo "Invalid Email.......";
}else{
// Matching user input email and password with stored email and password in database.
$result = mysql_query("SELECT email_id,password FROM customer WHERE email_id='$email_id' AND password='$password'");
$data = mysql_num_rows($result);
echo ($result);
if($data==1){
echo "Successfully Logged in...";
}else{
echo "Email or Password is wrong...!!!!";
}
}
mysql_close ($connection); // Connection Closed.
?>