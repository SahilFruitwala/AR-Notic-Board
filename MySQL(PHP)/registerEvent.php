<?php
    session_start();    
?>

<?php

    if(isset($_SESSION["user"]))
    {
        echo "available";
    }
    else
    {
        $eno = $_POST['enrollment'];
        $event = $_POST['event'];

        // $eno = $eno.trim();
        // $event = $event.trim();

        $con = mysqli_connect("localhost","root","") or die("die");
        
        mysqli_select_db($con,"scetathon");

        $sql = "SELECT * FROM user WHERE Enrollment = '".$eno."'";
        $result = mysqli_query($con,$sql);
        $row=mysqli_fetch_array($result);

        $sql = "INSERT INTO ".$event." VALUES('".$eno."','".$row[3]."','".$row[4]."','".$row[5]."','".$row[6]."')";
        
        $result = mysqli_query($con,$sql);
        if($result)
        {
            echo "success";
        }
        else
        {
            echo "fail";
        }

    }
?>