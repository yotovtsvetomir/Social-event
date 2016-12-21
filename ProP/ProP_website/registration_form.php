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
    <!-- end .sidebar1 -->
  </div>
  <section>
  <h1>Registration, update and details of your profile</h1>
   
  <div class="login">
  <?php
        include 'login_form.php';
        loginForm();
        
        ?>
        </div>
  </section>
  <article class="content">
  
    <section>
      <div id="box1" class="box"></div>
      <h3>registration form</h3>
      
        <?php
        
        if(!isset($_SESSION['userLogin'])){
        echo '<form action="registration.php" method="POST">
            Email: <input type="text" name="user1" size="15"/><br />
            Password: <input type="password" name="pass1" size="15" /><br />
            Re-Password: <input type="password" name="pass2" size="15" /><br />
            First name: <input type="text" name="firstName1" size="15" /><br />
            Last name: <input type="text" name="lastName1" size="15" /><br />
                <p><input type="submit" name="submit" value="Registration" /></p>
        </form>';
        }
        else
        {   
            echo "You can't registrate when you are logged in";
        }
        ?>
      
        <h3>Here you can change your password</h3>
        
        <?php
        include_once 'getMaxAccountNr.php';
        if(isset($_SESSION['userLogin'])){
        echo '<form action="update.php" method="POST">
            Email: ' .$_SESSION["userLogin"] .'<br />
            Password: <input type="password" name="pass3" size="15" /><br />
            Re-Password: <input type="password" name="pass4" size="15" /><br />
                <p><input type="submit" name="submit" value="Update" /></p>
            </form><br>';
        
        echo '<h3>Details about your profile</h3>';
        if(InEvent($_SESSION['userLogin']) != NULL){
        echo 'You have bought tickets to event<br>';
        echo Camping(AccountId($_SESSION['userLogin']));
        echo 'Your money balance in event: ';
        echo Wallet($_SESSION['userLogin']);
        }
        else {
        echo 'you dont have tikets to this event HURRY UP!!!';}
        
        
        
        }
        else
        {
            echo 'You must login if you want to update your information<br>';
        }
        ?>
        
    </section>
    <!-- end .content -->
  </article>
  <aside class="sidebar1">
  </aside>
  <!-- InstanceEndEditable -->
  <footer>
    <p>© 2013 Sense All Rights Reserved</p>
  </footer>
  <!-- end .container --></div>
</body>
<!-- InstanceEnd --></html>
