<?php
    $con=mysqli_connect("localhost","root","","project_bca");
    /*$table=mysqli_query($con,"create table user_table(id int(3) auto_increment primary key , u_name varchar(20),pwd int(10),
    u_gen varchar(20),u_hobby1 varchar(20),u_hobby2 varchar(20),photo varchar(20))");
    if($table)
    {
        echo "table is create";
    }
    else{
        echo "table is not create";
    }*/
    if($con)
    {
        echo "connecter";
        if(isset($_POST['submit']))
        {
        $emp_id = $_POST['id'];
        $emp_uname = $_POST['u_name'];
        $emp_pwd = $_POST['password'];
        $emp_gen = $_POST['gender'];
        $emp_hobby1 = $_POST['gaming'];
        $emp_hobby2 = $_POST['reading'];
        $emp_image = $_POST['myfile'];
        $ins = mysqli_query($con, "insert into user_table values ('$emp_id','$emp_uname',$emp_pwd,'$emp_gen','$emp_hobby1','$emp_hobby2','$emp_image')");
        echo "recored is inserted <br><br>";

            echo "printing the recode :- <br>";

            $display = mysqli_query($con,"select * from user_table");
            if($display)
            {
               foreach ($display as $display2)
               {
                echo $display2."<br>";
               }
            }

        }
        else{
            echo "recored is not insert";
        }
    } 
    else 
    {
        echo "error in connection";

    }
?>