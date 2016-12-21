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

	<script type="text/javascript">
	var image1 = new Image()
	image1.src = "items/1stage.jpg"
	var image2 = new Image()
	image2.src = "items/2stage.jpg"
	var image3 = new Image()
	image3.src = "items/3stage.jpg"
	</script>
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
  <h1>About festival</h1>
  </section>
  <article class="content">
  
    <section>
      <div id="box1" class="box"></div>
      <h2>Stages</h2>
      <!--<p><img src="items/1Stage.jpg" width="575" height="327"></p>-->
      <p><img src="items/1stage.jpg" width="575" height="327" name="slide" /></p>
      <script type="text/javascript">
        var step=1;
        function slideit()
        {
            document.images.slide.src = eval("image"+step+".src");
            if(step<3)
                step++;
            else
                step=1;
            setTimeout("slideit()",1500);
        }
        slideit();
     </script>
      <p>The festival while consist of 3 stages, every stage will have their own line up, and style of music. Each stage will have it's own theme.</p>
    </section>
    <section>
      <div id="box2" class="box"></div>
      <h2>Lake</h2>
      <p><img src="items/Beach.jpg" width="575" height="327"></p>
      <p>Next to the festival is a lake, the lake will be accesable from both the festival itself and the camping site. The camping side will be devided from the festival itself. The part of the lake accesable on the festival is for cooling down and the part from the camping site is for relaxation.</p>
    </section>
    <section>
      <div id="box3" class="box"></div>
      <h2>Camping</h2>
      <p><img src="items/CampingSite.jpg" width="575" height="327"></p>
      <p>The festival has a nice camping place which you can reserve it throught this webpage when you will buy tickets.</p>
    </section>
    <!-- end .content -->
  </article>
  <aside class="sidebar1">
      <?php include_once ('php\visitCoounter.php')?>
  <h4>Navigation</h4>
    <h5><a href ="#box1">Stages</a></h5>
    <h5><a href="#box2">Lake</a></h5>
    <h5><a href ="#box3">Camping</a>  </h5>
  </aside>
  <!-- InstanceEndEditable -->
  <footer>
    <p>© 2013 Sense All Rights Reserved</p>
  </footer>
  <!-- end .container --></div>
</body>
<!-- InstanceEnd --></html>
