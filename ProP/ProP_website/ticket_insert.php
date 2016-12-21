<?php
session_start();
include_once 'getMaxAccountNr.php';
include 'connectionDB.php';
/* 
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
$f_name = $_POST['FirstName'];
$l_name = $_POST['LastName'];
$gender = $_POST['sex'];
$bday = $_POST['bday'];
$city = $_POST['City'];
$address = $_POST['StreetAddress1'];
$z_code = $_POST['Zip'];
$country = $_POST['Country'];
$quantity = $_POST['quantity'];
$moneyBalance = $_POST['Wallet'];

if(isset($_POST['ticketreserve']) && isset($_POST['camping'])){
    $max = MaxCampingId()+1;
    $id = AccountId($_SESSION['userLogin']);
    $query1 = "UPDATE `client` SET 
        `First_Name`= '" .$f_name ."',
        `Last_Name`= '" .$l_name ."',
        `City`= '" .$city ."',
        `Address`= '" .$address ."',
        `ZipCode`= '" .$z_code ."',
        `Gender`= '" .$gender ."',
        `DateOfBirth`= '" .$bday ."',
        `InEvent`= '0',
        `MoneyBalance`= '-25'
        WHERE Email = '" .$_SESSION['userLogin'] ."';";
    insert($query1);
        $query2 = "INSERT INTO campingspot(Camp_id, NumberOfGuests, Client_AccountNumber)
        VALUES (".$max .", ".$quantity .", ".$id .");";
    insert($query2);
    $amount = 10 + 10 + $quantity * 10;
}
elseif (!isset($_POST['ticketreserve']) && isset($_POST['camping'])){
    $max = MaxCampingId()+1;
    $id = AccountId($_SESSION['userLogin']);
    $query1 = "UPDATE `client` SET 
        `First_Name`= '" .$f_name ."',
        `Last_Name`= '" .$l_name ."',
        `City`= '" .$city ."',
        `Address`= '" .$address ."',
        `ZipCode`= '" .$z_code ."',
        `Gender`= '" .$gender ."',
        `DateOfBirth`= '" .$bday ."',
        `InEvent`= '0',
        `MoneyBalance`= '" .$moneyBalance ."'
        WHERE Email = '" .$_SESSION['userLogin'] ."';";
    insert($query1);
        $query2 = "INSERT INTO campingspot(Camp_id, NumberOfGuests, Client_AccountNumber)
        VALUES (".$max .", ".$quantity .", ".$id .");";
    insert($query2);
    $amount = 35 + $moneyBalance + 10 + 10 * $quantity;
}
elseif (isset($_POST['ticketreserve']) && !isset($_POST['camping'])) {
$query3 = "UPDATE `client` SET 
        `First_Name`= '" .$f_name ."',
        `Last_Name`= '" .$l_name ."',
        `City`= '" .$city ."',
        `Address`= '" .$address ."',
        `ZipCode`= '" .$z_code ."',
        `Gender`= '" .$gender ."',
        `DateOfBirth`= '" .$bday ."',
        `InEvent`= '0',
        `MoneyBalance`= '-25'
        WHERE Email = '" .$_SESSION['userLogin'] ."';";
    insert($query3);
    $amount = 10;
}
else {
$query = "UPDATE `client` SET 
        `First_Name`= '" .$f_name ."',
        `Last_Name`= '" .$l_name ."',
        `City`= '" .$city ."',
        `Address`= '" .$address ."',
        `ZipCode`= '" .$z_code ."',
        `Gender`= '" .$gender ."',
        `DateOfBirth`= '" .$bday ."',
        `InEvent`= '0',
        `MoneyBalance`= '" .$moneyBalance ."'
        WHERE Email = '" .$_SESSION['userLogin'] ."';";
    insert($query);
    $amount = 35 + $moneyBalance;
}

    header("Refresh: 3; url=registration_form.php");
     echo "You have bought tickets. </br> you have paid: " .$amount ."</br> redirecting to your profile";