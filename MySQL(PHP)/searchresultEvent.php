<!DOCTYPE html>
<html>
    <head>
        <meta charset="utf-8" />
        <meta http-equiv="X-UA-Compatible" content="IE=edge" />
        <link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Arvo">  
    </head>
    <body >

<?php
    
    $con = mysqli_connect("localhost","root","") or die("die");    
    mysqli_select_db($con,"scetathon");

    $event = $_POST['event'];

    $event = strtolower($event);
    // $event = $event.trim();
    $sql = "SELECT * FROM ".$event;
    $result = mysqli_query($con,$sql);

    echo "<table border = '1' cellpadding='10px' rules = 'all'>";
    echo "<tr>";
    while($row = mysqli_fetch_field($result))
    {
        echo "<th>".$row -> name."</th>";
    }
    while($row=mysqli_fetch_array($result))
    {
        echo "<tr>";
        $count = 0;
        while($count < 5)
        {
            echo "<td>".$row[$count]."</td>";
            $count++;
        }
        echo "</tr>";
    }
?>

    </body>
</html>