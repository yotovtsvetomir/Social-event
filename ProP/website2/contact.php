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
  <h1>Contact sense</h1>
  </section>
  <article class="content">
  
  <section>
      <h2> Sense</h2>
    <p> Email : Sense@gmail.com</p>
    <p> Phone : 31 6 41 79 05 83</p>
    <p> Office : Fontys</p>
    <p> Located : Rachelsmolen, Eindhoven</p>
  </section>
    <section>
      <div id="body_wrapper">
        <div id="main_wrapper">
            <div id="header">
                <div class="header_right">
                    <div id="Filler">
                        <div class="cleaner"></div>
                    </div>
                    <!-- end of menu -->
                </div>

                <div class="cleaner"></div>

            </div>

            <!-- end of header -->

                        <meta http-equiv="content-type" content="text/html; charset=UTF-8">

                        <meta name="viewport" content="initial-scale=1.0, user-scalable=no">

                        <script type="text/javascript" src="http://maps.google.com/maps/api/js?sensor=false"></script>

                        <script type="text/javascript">

                            function LoadGmaps() {

                                var myLatlng = new google.maps.LatLng(51.4509636, 5.4792564);

                                var myOptions = {

                                    zoom: 16,

                                    center: myLatlng,

                                    disableDefaultUI: true,

                                    panControl: true,

                                    zoomControl: true,

                                    zoomControlOptions: {

                                        style: google.maps.ZoomControlStyle.DEFAULT

                                    },



                                    mapTypeControl: true,

                                    mapTypeControlOptions: {

                                        style: google.maps.MapTypeControlStyle.HORIZONTAL_BAR

                                    },

                                    streetViewControl: true,

                                    mapTypeId: google.maps.MapTypeId.ROADMAP

                                }

                                var map = new google.maps.Map(document.getElementById("MyGmaps"), myOptions);

                                var marker = new google.maps.Marker({

                                    position: myLatlng,

                                    map: map,

                                    title: "eindhoven rachelsmolen"

                                });

                                var infowindow = new google.maps.InfoWindow({

                                    content: "Sense base of operations"

                                });

                                google.maps.event.addListener(marker, "click", function () {

                                    infowindow.open(map, marker);

                                });

                            }

                        </script>

                        <body onload="LoadGmaps()" onunload="GUnload()">

                            <!-- Maps DIV : you can move the code below to where you want the maps to be displayed -->

                            <div id="MyGmaps" style="width: 600px; height: 400px; border: 1px solid #CECECE;"></div>

                    </div>
                <!-- End of Maps DIV -->
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
