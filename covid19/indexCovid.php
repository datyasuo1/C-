<?php
$myDB = new mysqli('localhost', 'root', '', 'covid');
if ($myDB->connect_error)
{
    die('Connect Error (' . $myDB->connect_error . ') '
        . $myDB->connect_error);
}
$sql = "SELECT * FROM people ";
$result = $myDB->query($sql);
?>
<html>
<body>
<h3 align="center">List People</h3>

<table border="1"  align="center">

    <tr >
        <td align="center">Id</td>
        <td align="center">Name</td>
        <td align="center">Tel</td>
        <td align="center">Address</td>
        <td align="center">F</td>
        <td align="center">Location</td>
        <td align="center">Start_Date</td>
        <td align="center">End_Date</td>
    </tr>
    <?php
    while ($row = $result->fetch_assoc() ) {
        echo "<tr>";
        echo "<td>";
        echo  $row["id"];
        echo "</td><td align='center'>";
        echo $row["name"];
        echo "</td><td>";
        echo $row["tel"];
        echo "</td><td>";
        echo $row["address"];
        echo "</td><td>";
        echo $row["F"];
        echo "</td><td>";
        echo $row["location"];
        echo "</td><td>";
        echo $row["star_date"];
        echo "</td><td>";
        echo  $row["end_date"];
        echo "</td>";
        echo "</tr>";
    }
    ?>
</table>
</body>
</html>
