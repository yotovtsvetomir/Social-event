<?php

/* 
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
session_start();
include 'connectionDB.php';

    $upPass1 = $_POST['pass3'];
    $upPass2 = $_POST['pass4'];
    
    if ($upPass1 != NULL && $upPass1 == $upPass2)
    {
        $query = "UPDATE client SET Password = '" .$upPass1 ."' WHERE Email = '" .$_SESSION["userLogin"] ."';";
        insert($query);
        header("Refresh: 2; url=registration_form.php");
            echo 'updated succefully';
    }
    else 
    {
        header("Refresh: 2; url=registration_form.php"); // message & redirect after 1 seconds
            echo "Passwords are not correct.<br>You are being redirected.";
    }
