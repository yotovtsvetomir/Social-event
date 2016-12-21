<?php 
if (isset($_POST["FromEmailAddress"]))
    {
    include_once 'php\mySqlConnectHelper.php';
    $query = 'Select firstname from users where user = "'.$_POST["FromEmailAddress"].'";' ;
    if(sqlQuery($query)==FALSE)
        {
        sqlRegisterNewUser();
                
        }
 else {$errorMessage='This email address is already registered!';}
    }  ?>
<!doctype html>
<html><!-- InstanceBegin template="/Templates/main.dwt" codeOutsideHTMLIsLocked="false" -->
<head>
<meta charset="utf-8">
<!-- InstanceBeginEditable name="doctitle" -->
<title>Untitled Document</title>
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
    <div id="logIn"> Register   </div> 
  <header>
    <a href="#"><img src="items/1.jpg" alt="" width="959" height="254" id="Insert_logo" style="background-color: #C6D580; display:block;" /></a>
  </header>
  <!-- InstanceBeginEditable name="content" -->
  <div class="sidebar1">
    <ul class="nav">
      <li><a href="index.php">Home</a></li>
      <li><a href="photos.php">Photos</a></li>
      <li><a href="tickets.php">Tickets</a></li>
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
  <h1>Registration</h1>
  </section>
  <article class="content">
  
    <section>
      <div id="box3" class="box">
<form action="registration.php"  method="post" onsubmit="return ValidateForm(this);">
<input id="SnapHostID" name="SnapHostID" type="hidden" value="AFKTWGNLQJ8H" />
<script type="text/javascript">
function ValidateForm(frm) {
if (frm.FirstName.value == "") {alert('First Name is required.');frm.FirstName.focus();return false;}
if (frm.LastName.value == "") {alert('Last Name is required.');frm.LastName.focus();return false;}
if (frm.FromEmailAddress.value == "") {alert('Email address is required.');frm.FromEmailAddress.focus();return false;}
if (frm.FromEmailAddress.value.indexOf("@") < 1 || frm.FromEmailAddress.value.indexOf(".") < 1) {alert('Please enter a valid email address.');frm.FromEmailAddress.focus();return false;}
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
<td><b>First, Last Name*:</b></td>
<td>
<input id="FirstName" name="FirstName" type="text" maxlength="60" style="width:146px; border:1px solid #999999" />
<input id="LastName" name="LastName" type="text" maxlength="60" style="width:146px; border:1px solid #999999" />
</td>
</tr>
<tr>
<td><b>Password*:</b></td>
<td>
    <input id="Password" name="Password" type="password" maxlength="60" style="width:146px; border:1px solid #999999" />
</td>
</tr><tr>
<td><b>age:</b></td>
<td><input type="number" name="age"></td>
</tr><tr>
<td><b>Email address*:</b></td>
<td><input id="FromEmailAddress" name="FromEmailAddress" type="text" maxlength="60" style="width:300px; border:1px solid #999999" /></td>
</tr><tr>
<td><tr>
<td colspan="2" align="center"><br />
<table border="0" cellpadding="0" cellspacing="0">
<tr valign="top">
</tr>
</table>* - required fields.  &nbsp; &nbsp;
<input id="skip_Submit" name="skip_Submit" type="submit" value="Submit" />
</td><?php if(isset($errorMessage) ){echo $errorMessage; } ?>
</tr>
</table>
<br />
</form>
      </div>
    </section>
    <!-- end .content -->
  </article>
  <aside class="sidebar1"><?php include_once ('php\visitCoounter.php')?></aside>
  <!-- InstanceEndEditable -->
  <footer>
    <p>© 2013 Sense All Rights Reserved</p>
  </footer>
  <!-- end .container --></div>
</body>
<!-- InstanceEnd --></html>
