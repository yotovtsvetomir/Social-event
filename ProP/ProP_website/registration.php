<?php
session_start();
include_once 'getMaxAccountNr.php';
include 'connectionDB.php';
    $regUser = $_POST['user1'];
    $regPass1 = $_POST['pass1'];
    $regPass2 = $_POST['pass2'];
    $regFname = $_POST['firstName1'];
    $regLname = $_POST['lastName1'];
    
    if ($regPass1 == $regPass2 && $regUser != NULL && $regPass1 != NULL)
    {
        $max = MaxID()+1;
        $query = "Insert into client (AccountNumber, Email, First_name, Last_name, password) Values ('".$max ."', '" .$regUser ."','" .$regFname ."', '" .$regLname ."', '" .$regPass1 ."');";
        insert($query);
        header("Refresh: 2; url=registration_form.php");
            echo 'registration succefully';
    }
    else
    {
        header("Refresh: 2; url=registration_form.php"); // message & redirect after 1 seconds
            echo "Passwords are not correct.<br>You are being redirected.";
    }





