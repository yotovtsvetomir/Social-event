<?php

session_start();

if(isset($_POST['logOut'])) 
{$_SESSION["name"]= NULL; $_SESSION["loggedin"]= NULL;session_destroy();     }

if (isset($_POST["name"]) && isset($_POST["password"])) 
    {
     $name = $_POST["name"];
     $password = $_POST["password"];

     $_SESSION["name"] = $_POST["name"]; // set sessionvalue of 'name'
     $_SESSION["loggedin"] ="true"; // set sessionvalue of 'loggedin'   
        include_once 'mySqlConnect.php'; 
//assssssssssaaaa
    }
    
// Check if visitor is logged in
if(!isset($_SESSION["loggedin"]))
{   echo '
        <form method="POST" action="logIn.php">
  	Name:<input type="text" name="name">
	Password:<input type="password" name="password">
        <input type="submit" value="LogIn">
        <button name = "Register">Register</button>
        </form>
        ';  
}


if(isset($_SESSION["loggedin"]))
{
echo '<form method="post"> LogedIn as ',
     "$_SESSION[name]",
        '<button name = "logOut">LogOut</button> </form>';
}
?>