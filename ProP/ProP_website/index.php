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
  <h1>Home</h1>
   
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
      <h2>The Main Stage</h2>
      <p><img src="items/1stage.jpg" width="575" height="327"></p>
      <p>This will be the main point of entertainement. The best artist will be staged here and the genre will be House music<br>
        On the second day the music genre will be different and theme will change, again each stage will have it's own theme and line-up.    </p>
    </section>
    <section>
      <div id="box2" class="box"></div>
      <h2>The Lake Stage</h2>
      <p><img src="items/2stage.jpg" width="575" height="327"></p>
      <p> This stage will be located close to the lake, on a beach. It will have summer themed music.</p>
    </section>
    <section>
      <div id="box3" class="box"></div>
      <h2>The Second Stage</h2>
      <p><img src="items/3stage.jpg" width="575" height="327"></p>
      <p>The second stage will be inside in case of the bad weather and there will be electro and generic beats, beginning DJ's will have a chance to shine here. In very spaces tents everybody can enjoy the music all night long.</p>
    </section>
    <!-- end .content -->
  </article>
  <aside class="sidebar1">
    <h4>Navigation</h4>
    <h5><a href ="#box1">The Main stag</a></h5>
    <h5><a href="#box2">The Lake stage</a></h5>
    <h5><a href ="#box3">The Second stage</a>  </h5>
  </aside>
  <!-- InstanceEndEditable -->
  <footer>
    <p>© 2013 Sense All Rights Reserved</p>
  </footer>
  <!-- end .container --></div>
</body>
<!-- InstanceEnd --></html>
