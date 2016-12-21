<?php

/* 
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
session_start();

$user1 = $_POST['user'];
$pass1 = $_POST['pass'];
 
 $query = "Select * from client where Email ='" .$user1 ."' and Password ='" .$pass1 ."';";

 include 'connectionDB.php';
 

 if (check($query) == 1)
 {
     $_SESSION["loggedin"] ="true";
     $_SESSION["userLogin"] = $user1;
     $_SESSION["userPassword"] = $pass1;
     setcookie("userInfo", $user1, time()*60*60*24*30);
     
 
     header("Refresh: 3; url=index.php"); // message & redirect after 3 seconds
            echo "You are logged in successfully.<br>You are being redirected.";
 }
 else {
     header("Refresh: 3; url=index.php");
     echo "Bad password or login name.<br>You are being redirected.";
}
