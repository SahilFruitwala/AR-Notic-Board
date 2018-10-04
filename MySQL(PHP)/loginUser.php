<?php
    // error_reporting(0);
    // session_start();
?>

<?php

    // if(isset($_SESSION["user"]))
    // {
    //     echo "available";
    // }
    // else
    // {
        $eno = $_POST['enrollment'];
        $pass = $_POST['password'];

        // $eno = $eno.trim();
        // $pass = $pass.trim();

        $con = mysqli_connect("localhost","root","") or die("die");
        
        mysqli_select_db($con,"scetathon");

        $sql = "SELECT Password from user WHERE Enrollment = '".$eno."'";
        
        $result = mysqli_query($con,$sql);
        $data = mysqli_fetch_row($result);

        if($data[0] == $pass)
        {
            // $_SESSION['user'] = $eno;
            // echo "0";
        }
        if($data[0] != $pass)
        {
            echo "0";
        }
    // }

        // header("location: loginUser.php");
?>