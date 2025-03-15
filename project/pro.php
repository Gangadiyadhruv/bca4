<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Login and Registration Form</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <h1>Welcome to User Authentication Portal</h1>

    <?php
    session_start();
    $db = new mysqli("localhost", "root", "", "project_bca");

    if ($db->connect_error) {
        die("Connection failed: " . $db->connect_error);
    }

    if (isset($_POST['reg_name'])) {
        $name = $_POST['reg_name'];
        $password = password_hash($_POST['reg_password'], PASSWORD_DEFAULT);
        $stmt = $db->prepare("INSERT INTO users (name, password) VALUES (?, ?)");
        $stmt->bind_param("ss", $name, $password);
        $stmt->execute();
        echo "<p>Registration successful. Please log in.</p>";
    }

    if (isset($_POST['name'])) {
        $name = $_POST['name'];
        $password = $_POST['password'];
        $gender = $_POST['gender'];
        $hobby = $_POST['hobby'];
        $profileImage = $_FILES['profile_image']['name'];
        $uploadPath = "uploads/" . basename($profileImage);
        move_uploaded_file($_FILES['profile_image']['tmp_name'], $uploadPath);

        $stmt = $db->prepare("SELECT * FROM users WHERE name = ?");
        $stmt->bind_param("s", $name);
        $stmt->execute();
        $result = $stmt->get_result();
        $user = $result->fetch_assoc();

        if ($user && password_verify($password, $user['password'])) {
            $_SESSION['user'] = $name;
            echo "<p>Login successful. Welcome, $name!</p>";

            $stmt = $db->prepare("INSERT INTO user_details (name, gender, hobby, profile_image) VALUES (?, ?, ?, ?)");
            $stmt->bind_param("ssss", $name, $gender, $hobby, $profileImage);
            $stmt->execute();
        } else {
            echo "<p>Invalid login credentials.</p>";
        }
    }

    if (!isset($_SESSION['user'])) {
        echo '<div class="form-container">
            <h2>Registration Form</h2>
            <form action="" method="POST" enctype="multipart/form-data">
                <label for="reg_name">Name:</label>
                <input type="text" name="reg_name" id="reg_name" required><br>

                <label for="reg_password">Password:</label>
                <input type="password" name="reg_password" id="reg_password" required><br>

                <input type="submit" value="Register">
            </form>
        </div>';

        echo '<div class="form-container">
            <h2>Login Form</h2>
            <form action="" method="POST" enctype="multipart/form-data">
                <label for="name">Name:</label>
                <input type="text" name="name" id="name" required><br>

                <label for="password">Password:</label>
                <input type="password" name="password" id="password" required><br>

                <label>Gender:</label>
                <input type="radio" name="gender" value="Male" required> Male
                <input type="radio" name="gender" value="Female" required> Female<br>

                <label for="hobby">Hobby:</label>
                <select name="hobby" id="hobby" required>
                    <option value="Reading">Reading</option>
                    <option value="Traveling">Traveling</option>
                    <option value="Gaming">Gaming</option>
                    <option value="Music">Music</option>
                </select><br>

                <label for="profile_image">Profile Image:</label>
                <input type="file" name="profile_image" id="profile_image" required><br>

                <input type="submit" value="Login">
            </form>
        </div>';
    }
    ?>
</body>
</html>
