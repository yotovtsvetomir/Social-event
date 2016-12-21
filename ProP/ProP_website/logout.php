<?php

/* 
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
session_start();

    if( isset($_SESSION)){
        session_destroy();
        header("Refresh: 1; url=index.php"); // message & redirect after 3 seconds
            echo "You are loggout.<br>You are being redirected.";
    }
    
    