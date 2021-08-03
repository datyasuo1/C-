<html>
<?php
$title = '';
if (!empty($_POST['title'])) {
    $title = $_POST['title'];
    echo "Finding record, {$_POST['title']}, and Result";
}
?>

<form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="post">
    Enter your name: <input type="text" name="title" />
    <input type="submit" value="Search"/>
</form>


<?php
$myDB = new mysqli('localhost', 'root', '', 'covid');
if ($myDB->connect_error)
{
    die('Connect Error (' . $myDB->connect_error . ') '
        . $myDB->connect_error);
}

if ($title != '') {
    $sql = "SELECT * FROM people 
    where name like '%{$title}%'
    or F like '%{$title}%'
    or location like '%{$title}%'
    order by name";
} else {
    $sql = "select * from people order by name";
}

$result = $myDB->query($sql);
?>
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
</html>

