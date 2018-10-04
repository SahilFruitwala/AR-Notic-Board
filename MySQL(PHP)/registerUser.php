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
        $fname = $_POST['fname'];
        $lname = $_POST['lname'];
        $ph = $_POST['phone'];
        $email = $_POST['email'];
        $branch = $_POST['branch'];
        $year = $_POST['year'];
        $pass = $_POST['password'];

        // $eno = $eno.trim();
        // $fname = $fname.trim();
        // $lname = $lname.trim();
        // $ph = $ph.trim();
        // $email = $email.trim();
        // $branch = $branch.trim();
        // $year = $year.trim();
        // $pass = $pass.trim();

        $con = mysqli_connect("localhost","root","") or die("die");
        
        mysqli_select_db($con,"scetathon");

        $sql = "INSERT INTO user values('".$eno."','".$fname."','".$lname."','".$ph."','".$email."','".$branch."','".$year."','".$pass."')";
        
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