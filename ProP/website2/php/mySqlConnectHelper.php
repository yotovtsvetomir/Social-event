<?php
// Connection to the  MySQL Database
//"mysql:host=localhost;dbname=db_ita2";}
      function LogInCheck($userName,$userPass) 
        {$username = "root"; // username
        $password = ""; // password
        $link = mysql_connect('localhost',$username,$password) or die('Cant connect to Database');
        mysql_select_db('db_ita2') ;
       $query = "Select firstname From Users Where user = '$userName' and password = '$userPass' ;";
        $result = mysql_query($query) or die(mysql_error());
        if (mysql_num_rows($result)>0) {
            $row = mysql_fetch_row($result);
             $_SESSION["name"] =$row[0];
             return TRUE;
        }
        else{return FALSE;}   
        }
        
              function sqlQuery($query) 
        {$username = "root"; // username
        $password = ""; // password
        $link = mysql_connect('localhost',$username,$password) or die('Cant connect to Database');
        mysql_select_db('db_ita2') ;
       
        $result = mysql_query($query) or die(mysql_error());
        if (mysql_num_rows($result)>0) {
            $row = mysql_fetch_row($result);
             $_SESSION["name"] =$row[0];
             return TRUE;
        }
        else{return FALSE;}   
        }
                      
        function sqlQueryLastVisit() 
        {$username = "root"; // username
        $password = ""; // password
        $link = mysql_connect('localhost',$username,$password) or die('Cant connect to Database');
        mysql_select_db('db_ita2') ;
       $query= 'SELECT log FROM users WHERE firstname = \''.$_SESSION["name"].'\'';
        $result = mysql_query($query) or die(mysql_error());
       
            $row = mysql_fetch_row($result);
            $query= 'UPDATE users SET log = NOW( ) WHERE firstname = \''.$_SESSION["name"].'\'';
            mysql_query($query)or die(mysql_error());;
             return $row[0];
        }
        function  sqlRegisterNewUser()
                {$username = "root"; // username
        $password = ""; // password
        $link = mysql_connect('localhost',$username,$password) or die('Cant connect to Database');
        mysql_select_db('db_ita2') ;
       $query= 'INSERT INTO `users`( `user`, `password`, `firstname`, `lastname`, `age`, `log`) VALUES (\''
               .$_POST[FromEmailAddress].'\',\''.$_POST[Password].'\',\''.$_POST[FirstName].'\',\''.$_POST[LastName].'\',\''.$_POST[age].'\',Now())';

            mysql_query($query)or die(mysql_error());
        }
?>

