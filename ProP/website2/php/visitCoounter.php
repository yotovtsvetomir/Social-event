<?php
/* 
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

$today = date("m_d_y"); 
$todayCounterFile = "php/visits/".$today .".txt";
$totalCounterFile = "php/visits/total.txt";
 
// Check if a text file exists. If not create.
if (!file_exists($todayCounterFile)) {
  $f = fopen($todayCounterFile, "w");
  fwrite($f,"0");
  fclose($f);
}
if (!file_exists($totalCounterFile)) {
  $f = fopen($totalCounterFile, "w");
  fwrite($f,"0");
  fclose($f);
}
 
// Read the current value of our counter file
$f = fopen($todayCounterFile,"r");
$counterDay = fread($f, filesize($todayCounterFile));
$f = fopen($totalCounterFile,"r");
$counterTotal = fread($f, filesize($totalCounterFile));
fclose($f);
//....to check


 

// if not same user(check cookie) increase visits
if(!isset($_COOKIE['userCounter'])){
  setcookie("userCounter", "counted_today", mktime(24,0,0)); // cookie for 1 day
 
  ++$counterDay ;
  ++$counterTotal;
   
  $f = fopen($todayCounterFile, "w");
  fwrite($f, $counterDay);
  $f = fopen($totalCounterFile, "w");
  fwrite($f, $counterTotal);
  fclose($f);
}
 //show number of visitors 
echo "<p><b>Visitors<br> Today: $counterDay  <br> Total: $counterTotal </b></p>";
?>
