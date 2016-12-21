<?php
// Connection to the  MySQL Database

function MaxID() {
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

// selection of Records from the table in the database
$query ="SELECT max(AccountNumber) FROM
client";

//Query and extra error messages
$result = mysqli_query ($db, $query) or die("ERROR: " . mysqli_errno($db) . " - " . mysqli_error($db));



// Values  of the selected  records in the array.
while ($row = mysqli_fetch_array($result)) {	
    $maxId = $row[0];
    }
    
// free memory which holds the results from the query
mysqli_free_result($result);
    
// Close Databaseconnection
mysqli_close($db) or die ($db_error3);

return $maxId;
}

function MaxCampingId() {
    
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

// selection of Records from the table in the database
$query ="SELECT max(camp_id) FROM
campingspot";

//Query and extra error messages
$result = mysqli_query ($db, $query) or die("ERROR: " . mysqli_errno($db) . " - " . mysqli_error($db));



// Values  of the selected  records in the array.
while ($row = mysqli_fetch_array($result)) {	
    $maxId = $row[0];
    }
    
// free memory which holds the results from the query
mysqli_free_result($result);
    
// Close Databaseconnection
mysqli_close($db) or die ($db_error3);
return $maxId;
}

function AccountId($email)
{
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

// selection of Records from the table in the database
$query ="SELECT AccountNumber FROM
client where Email = '" .$email ."';";

//Query and extra error messages
$result = mysqli_query ($db, $query) or die("ERROR: " . mysqli_errno($db) . " - " . mysqli_error($db));



// Values  of the selected  records in the array.
while ($row = mysqli_fetch_array($result)) {	
    $accountNr = $row[0];
    }
    
// free memory which holds the results from the query
mysqli_free_result($result);
    
// Close Databaseconnection
mysqli_close($db) or die ($db_error3);

return $accountNr;
}

function InEvent($email)
{
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

// selection of Records from the table in the database
$query ="SELECT InEvent FROM
client where Email = '" .$email ."';";

//Query and extra error messages
$result = mysqli_query ($db, $query) or die("ERROR: " . mysqli_errno($db) . " - " . mysqli_error($db));



// Values  of the selected  records in the array.
while ($row = mysqli_fetch_array($result)) {	
    $InEvent = $row[0];
    }
    
// free memory which holds the results from the query
mysqli_free_result($result);
    
// Close Databaseconnection
mysqli_close($db) or die ($db_error3);

return $InEvent;
}

function Wallet($email)
{
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

// selection of Records from the table in the database
$query ="SELECT moneyBalance FROM
client where Email = '" .$email ."';";

//Query and extra error messages
$result = mysqli_query ($db, $query) or die("ERROR: " . mysqli_errno($db) . " - " . mysqli_error($db));



// Values  of the selected  records in the array.
while ($row = mysqli_fetch_array($result)) {	
    $Wallet = $row[0];
    }
    
// free memory which holds the results from the query
mysqli_free_result($result);
    
// Close Databaseconnection
mysqli_close($db) or die ($db_error3);

return $Wallet;
}

function Camping($accountNr)
{
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

// selection of Records from the table in the database
$query ="SELECT Camp_id, NumberOfGuests FROM
campingspot where Client_AccountNumber = '" .$accountNr ."';";

//Query and extra error messages
$result = mysqli_query ($db, $query) or die("ERROR: " . mysqli_errno($db) . " - " . mysqli_error($db));



// Values  of the selected  records in the array.
while ($row = mysqli_fetch_array($result)) {	
    $Camp_id = $row[0];
    $guests = $row[1];
    }
    
// free memory which holds the results from the query
mysqli_free_result($result);
    
// Close Databaseconnection
mysqli_close($db) or die ($db_error3);

if (isset($Camp_id)){
$a = "you have camping spot: " .$Camp_id ." with guests : " .$guests ."<br>";
}
 else {
$a = "You Dont have camping spot<br>";    
 }
 return $a;
}

?>