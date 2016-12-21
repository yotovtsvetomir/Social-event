<?php

function loginForm() {
        if(!isset($_SESSION['loggedin']))
        {
            if(isset($_COOKIE['userInfo']))
            {
        echo '<h3>Login</h3>
            <form action="login.php" method="POST">
            Email: <input type="text" name="user" value="'.$_COOKIE['userInfo'] .'" size="15"/><br />
            Password: <input type="password" name="pass" size="15" /><br />
                <p><input type="submit" value="Login" /></p>
        </form>';
            }
            else
            {
                echo '<h3>Login</h3>
                    <form action="login.php" method="POST">
                    Username: <input type="text" name="user" size="15"/><br />
                    Password: <input type="password" name="pass" size="15" /><br />
                <p><input type="submit" value="Login" /></p>
                </form>';
            }
        }
        else
        {
            echo '<h3>Logged In</h3>
                '.'logged in as: <a href = "registration_form.php">'.$_SESSION['userLogin'] .'</a>
	<form name="logout" action="logout.php" method="POST">
		<input type="submit" name="logout" value="Log Out">
	</form>';
        }
 }