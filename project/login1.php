<html>
    <head>
        <title>Login and Registration form</title>
        <link rel="stylesheet" href="style_p.css">
    </head>
    <body>
        <div class="container">
            <form action="process.php" metho="post"></form>
            <h1 class="a" align="center">Login Form</h1>
        <table border="1px" bgcolor="#E4F1FF" align="center">
            <tr>
			<form method="post" action="process.php">
        <tr><td> 
            user name:<input type="text" name="u_name" placeholder="username"><br>
    
        </td></tr>
            <tr><td>
                user password:<input type="password" name="password" placeholder="password"><br>
            </td></tr>
		<tr>
		<td><br>
        Gender:
		<input type="radio" name="gender" value="female">Female
		<input type="radio" name="gender" value="male">Male
		<input type="radio" name="gender" value="other">Other	
		</td>
		</tr>
		<tr>
		<td><br>
        hobby:-<br>
        gaming<input type="checkbox" value="gaming" name="gaming"><br>
		      reading<input type="checkbox" value="reading" name="reading">
		</td>
        </tr>
		<tr>
		<td>
		<p>Chose the image file:</p>
		<input type="file" id="myfile" name="myfile">
		</td>
		</tr>
        </table>
        <br><br>
            <div>
            <center><button type="submit" name="submit">submit</button><center><br>
            </div>
        </div>
    </body>
</html>