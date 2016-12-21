<?php 
session_start();
?>
<!doctype html>
<html><!-- InstanceBegin template="/Templates/main.dwt" codeOutsideHTMLIsLocked="false" -->
<head>
<meta charset="utf-8">
<!-- InstanceBeginEditable name="doctitle" -->
<title>Festival</title>
<!-- InstanceEndEditable -->
<link href="Style.css" rel="stylesheet" type="text/css"><!--[if lt IE 9]>
<script src="http://html5shiv.googlecode.com/svn/trunk/html5.js"></script>
<![endif]-->
<!-- InstanceBeginEditable name="head" -->
<!-- InstanceEndEditable -->
</head>

<body>

<!-- InstanceBeginEditable name="header" -->header<!-- InstanceEndEditable -->
<div class="container">
  <header>
    <a href="#"><img src="items/1.jpg" alt="" width="959" height="254" id="Insert_logo" style="background-color: #C6D580; display:block;" /></a>
  </header>
  <!-- InstanceBeginEditable name="content" -->
  <div class="sidebar1">
    <ul class="nav">
      <li><a href="index.php">Home</a></li>
      <?php if(isset($_SESSION['loggedin'])){
          echo '<li><a href="tickets.php">Tickets</a></li>';
      }
      else {
          echo '<li><a href="registration_form.php">Registration</a></li>';
      }?>
      <li><a href="about.php">About</a></li>
      <li><a href="contact.php">Contact</a></li>
    </ul>
    <aside>
      <h4>Welcome, to Sensations Dream.</h4>
      <h5>Sensations Dream is a two day, outdoor festival, besides a lake and in the meadows close to Eindhoven.<br>
        The festival has multiple facilities, there is the festival itself, a lake where you can swim in and a camping site to stay the night. </h5>
    </aside>
  <!-- end .sidebar1 --></div>
  <section>
  <h1>Festival tickets</h1>
  <div class="login">
  <?php
        include 'login_form.php';
        loginForm();;
        
        ?>
    </div>
  </section>
  <article class="content">
  
    <section>
      <div id="box3" class="box">
<form action="ticket_insert.php" id="" method="post" onsubmit="return ValidateForm(this);">
<input id="SnapHostID" name="SnapHostID" type="hidden" value="AFKTWGNLQJ8H" />
<script type="text/javascript">
function ValidateForm(frm) {
if (frm.FirstName.value == "") {alert('First Name is required.');frm.FirstName.focus();return false;}
if (frm.LastName.value == "") {alert('Last Name is required.');frm.LastName.focus();return false;}
if (frm.sex.value == "") {alert('Gender is required.');frm.sex.focus();return false;}
if (frm.bday.value == "") {alert('Date of birth is required.');frm.bday.focus();return false;}
if (frm.Zip.value == "") {alert('Zip code is required.');frm.Zip.focus();return false;}
if (frm.StreetAddress1.value == "") {alert('Address is required.');frm.StreetAddress1.focus();return false;}
if (frm.City.value == "") {alert('City is required.');frm.City.focus();return false;}
if (frm.Country.value == "") {alert('Country is required.');frm.Country.focus();return false;}
return true; }
function ReloadCaptchaImage(captchaImageId) {
var obj = document.getElementById(captchaImageId);
var src = obj.src;
var date = new Date();
var pos = src.indexOf('&rad=');
if (pos >= 0) { src = src.substr(0, pos); }
obj.src = src + '&rad=' + date.getTime();
return false; }
</script>
<table border="0" cellpadding="5" cellspacing="0" width="600">
<tr>
<td><b>First, Last Name:</b></td>
<td>
<input id="FirstName" name="FirstName" type="text" maxlength="60" style="width:146px; border:1px solid #999999" />
<input id="LastName" name="LastName" type="text" maxlength="60" style="width:146px; border:1px solid #999999" />
</td>
</tr><tr>
<td><b>Gender:</b></td>
<td><input type="radio" name="sex" value="male">Male
<input type="radio" name="sex" value="female">Female</td>
</tr><tr>
<td><b>Date of birth:</b></td>
<td><input type="date" name="bday"></td>
</tr><tr>
<td><b>Email address:</b></td>
<td><?php echo $_SESSION["userLogin"]; ?></td>
</tr><tr>
<td><b>Address:</b></td>
<td><input id="StreetAddress1" name="StreetAddress1" type="text" maxlength="120" style="width:350px; border:1px solid #999999" /></td>
</tr><tr>
<td><b>City:</b></td>
<td><input id="City" name="City" type="text" maxlength="120" style="width:300px; border:1px solid #999999" /></td>
</tr><tr>
<td><b>Zip/Postal Code:</b></td>
<td><input id="Zip" name="Zip" type="text" maxlength="30" style="width:100px; border:1px solid #999999" /></td>
</tr><tr>
<td><b>Country:</b></td>
<td><input id="Country" name="Country" type="text" maxlength="120" style="width:300px; border:1px solid #999999" /></td>
</tr><tr>
<td><b>Event wallet:</b></td>
<td><input id="Country" name="Wallet" type="text" maxlength="120" value="0" style="width:300px; border:1px solid #999999" /></td>
</tr><tr>
<td><b>Camping (10euros per person):</b></td>
<td><input type="checkbox" name="camping" value="CampingReserved">
reserve camping spot<br>
<input type="number" name="quantity" value="0" min="0" max="6">
add extra guests (max 6)</td>
</tr><tr>
<td><b>Reserve ticket:</b></td>
<td><input type="checkbox" name="ticketreserve" value="ticketreserve">
</tr><tr>
<td colspan="2" align="center"><br />
<table border="0" cellpadding="0" cellspacing="0">
<tr valign="top">
</tr>
</table>* - All fields are required to fill in.  &nbsp; &nbsp;
<input id="skip_Submit" name="skip_Submit" type="submit" value="Buy" />
</td>
</tr>
</table>
<br />
</form>
      </div>
    </section>
    <!-- end .content -->
  </article>
  <aside class="sidebar1">
      <h4>Ticket prices:</h4>
      <p>Entrance: 35€</p>
      <p>Reserve: 10€</p>
      <h4>Camping spot:</h4>
      <p>Camping: 10€</p>
      <p>For 1 guest: 10€</p>
  </aside>
  <!-- InstanceEndEditable -->
  <footer>
    <p>© 2013 Sense All Rights Reserved</p>
  </footer>
  <!-- end .container --></div>
</body>
<!-- InstanceEnd --></html>
