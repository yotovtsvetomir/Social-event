<!doctype html>
<html><!-- InstanceBegin template="/Templates/main.dwt" codeOutsideHTMLIsLocked="false" -->
<head>
<meta charset="utf-8">
<!-- InstanceBeginEditable name="doctitle" -->
<title>Photos</title>
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
   <div id="logIn">    <?php include_once ('php\logIn.php')?> </div> 
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
    <!-- end .sidebar1 -->
  </div>
  
  <section>
  <h1>Photos</h1>
  </section>
  <article class="content">
      <section>
        <?php
        // put your code here
        $files = glob("php/foto/*.jpg");
        foreach ($files as $file) {
            
            echo '<div style="float: center;"><IMG SRC="' .$file .'" width="575" height="327" > </div><br>';
        
        }?>
      </section>
<h3>upload More</h3>
<form action="php/Upload.php" method="post"
            enctype="multipart/form-data">
            <label for="file">Filename:</label>
            <input type="file" name="file" id="file"><br>
            <input type="submit" name="submit" value="Submit">
        </form>
    <section>
      <div id="box1" class="box"></div>

        
        
    </section>
    <!-- end .content -->
  </article>
  <aside class="sidebar1">
      <?php include_once ('php\visitCoounter.php')?>
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
