<?php
session_start();
static $lastVisit;
if(isset($_POST['logOut'])) 
{$_SESSION["name"]= NULL; $_SESSION["loggedin"]= NULL;session_destroy();     }

if (isset($_POST["name"]) && isset($_POST["password"])) 
    {
    include_once 'mySqlConnectHelper.php';
   
    if(LogInCheck($_POST["name"],$_POST["password"])!= FALSE)
       {
        $_SESSION["loggedin"] ="true"; // set sessionvalue of 'loggedin'
        ini_set("session.cookie_lifetime","900");
        $lastVisit=' Last time visited:'.sqlQueryLastVisit();
        
        }
        
 else {}
    }
    
// Check if visitor is logged in
if(!isset($_SESSION["loggedin"]))
{   echo '<b>
        <form method="POST" action="index.php">
  	Name:<input type="text" name="name">
	Password:<input type="password" name="password">
        <input type="submit" value="LogIn"> &nbsp
<a href="registration.php">
    Registration
    </a>
 </form> </b>
        ';  
}

if(isset($_SESSION["loggedin"]))
{
echo '<form method="post"> LogedIn as  '.
     "$_SESSION[name]".
        $lastVisit.
        '<button name = "logOut">LogOut</button> </form>';
}
?>