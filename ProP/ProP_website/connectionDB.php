<?php
function check($query) {
    
// Connection to the  MySQL Database  
$host = "localhost"; // Which server : localhost 
$username = "dbi275231"; // username
$password = "uJOaHhNP6c"; // password
$dbname = "dbi275231"; // Name of the database
$db_error1 = "ERROR: connection to the databaseserver was not successful"; // error 1
$db_error2 = "ERROR: selection of the database was not successful"; // error 2
$db_error3 = "ERROR: closing of the database was not successful"; // error 3


// Connection to the Databaseserver
$db=mysqli_connect($host, $username, $password, $dbname)  or die($db_error1);

//  Connection to the Database
mysqli_select_db($db, $dbname) or die($db_error2); 

//Query and extra error messages
$result = mysqli_query ($db, $query) or die("ERROR: " . mysqli_errno($db) . " - " . mysqli_error($db));
$nr = mysqli_num_rows($result);
mysqli_free_result($result);    
// Close Databaseconnection
mysqli_close($db) or die ($db_error3);




return $nr;
}

function insert($query) {
    
// Connection to the  MySQL Database  
$host = "localhost"; // Which server : localhost 
$username = "dbi275231"; // username
$password = "uJOaHhNP6c"; // password
$dbname = "dbi275231"; // Name of the database
$db_error1 = "ERROR: connection to the databaseserver was not successful"; // error 1
$db_error2 = "ERROR: selection of the database was not successful"; // error 2
$db_error3 = "ERROR: closing of the database was not successful"; // error 3


// Connection to the Databaseserver
$db=mysqli_connect($host, $username, $password, $dbname)  or die($db_error1);

//  Connection to the Database
mysqli_select_db($db, $dbname) or die($db_error2); 

//Query and extra error messages
$result = mysqli_query ($db, $query) or die("ERROR: " . mysqli_errno($db) . " - " . mysqli_error($db));
//$nr = mysqli_num_rows($result);
//mysqli_free_result($result);
    
// Close Databaseconnection
mysqli_close($db) or die ($db_error3);

}


