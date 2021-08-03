<?php
    require_once 'config.php';
 $name=$tel=$address=$F=$location=$star_date=$end_date="";
 $namee=$tell=$addresss=$Ff=$locationn=$star_datee=$end_datee ="";

if($_SERVER["REQUEST_METHOD"]=="POST"){



    $input_name = trim($_POST["name"]);
    if (empty($input_name)) {
        $namee = "Enter a name";
    } elseif (!filter_var(trim($_POST["name"]), FILTER_VALIDATE_REGEXP,
        array("options" => array("regexp" => "/^[a-zA-Z'-.\s]+$/")))) {
        $namee = 'Enter a valid name';
    } else {
        $name = $input_name;
    }

    $input_tel = trim($_POST["tel"]);
    if (empty($input_tel)){
        $tell="Enter a tel";
    }else {
        $tel = $input_tel;
    }

    $input_address = trim($_POST["address"]);
    if (empty($input_address)){
        $addresss="Enter an address";
    }else {
        $address = $input_address;
    }

    $input_F = trim($_POST["F"]);
    if (empty($input_F)){
        $Ff="Enter a F";
    }else {
        $F = $input_F;
    }

    $input_location = trim($_POST["location"]);
    if (empty($input_location)){
        $locationn="Enter a location";
    }else {
        $location = $input_location;
    }

    $input_start = trim($_POST["star_date"]);
    if (empty($input_start)){
        $star_datee= "Enter a start date";
    }else {
        $star_date = $input_start;
    }

    $input_end = trim($_POST["end_date"]);
    if (empty($input_end)){
        $end_datee="Enter a end date";
    }else {
        $end_date = $input_end;
    }

    if ( empty($namee) && empty($tell) && empty($addresss) && empty($Ff) && empty($locationn) && empty($star_datee) && empty($end_datee)){
        $sql = "INSERT INTO people ( name, tel,address,F,location,star_date,end_date)VALUE (?,?,?,?,?,?,?)";
        if ($stmt = mysqli_prepare($link,$sql)){
            mysqli_stmt_bind_param($stmt,"ssd",$param_name, $param_tel,$param_address,$param_F,$param_location,$param_star,$param_end);
//            $param_id = $id;
            $param_name = $name;
            $param_tel = $tel;
            $param_address = $address;
            $param_F = $F;
            $param_location = $location;
            $param_star= $star_date;
            $param_end = $end_date;

            if (mysqli_stmt_execute($stmt)){
                header("location:indexCovid.php");
                exit();
            }else{
                echo "Something went wrong.Please try again later";
            }
        }
        mysqli_stmt_close($stmt);

    }
    mysqli_close($link);

}
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Create Record</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.css">
    <style type="text/css">
        .wrapper{
            width:  500px;
            margin: 0 auto;
            height: 900px;
        }
    </style>
</head>
<body>
<div class="wrapper">
    <div class="container_fluid">
        <div class="row">
            <div class="page-header">
                <h2>Create Record</h2>
            </div>
            <form action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"])?>" method="post">

<!--                <div class="form-group --><?php //echo (!empty($idd))? 'has-error':''; ?><!--">-->
<!--                    <label>ID</label>-->
<!--                    <input type="text" name="id" class="form-control" value="">-->
<!--                    <span class="help-block">--><?php //echo $idd; ?><!--</span>-->
<!--                </div>-->

                <div class="form-group <?php echo (!empty($namee))? 'has-error':''; ?>">
                    <label>Name</label>
                    <input type="text" name="name" class="form-control" value="">
                    <span class="help-block"><?php echo $namee; ?></span>
                </div>

                <div class="form-group <?php echo (!empty($tell))? 'has-error':''; ?>">
                    <label>Tel</label>
                    <input type="text" name="tel" class="form-control" value="">
                    <span class="help-block"><?php echo $tell; ?></span>
                </div>

                <div class="form-group <?php echo (!empty($addresss))? 'has-error':''; ?>">
                    <label>Address</label>
                    <input type="text" name="address" class="form-control" value="">
                    <span class="help-block"><?php echo $addresss; ?></span>
                </div>

                <div class="form-group <?php echo (!empty($Ff))? 'has-error':''; ?>">
                    <label>F</label>
                    <input type="text" name="F" class="form-control" value="">
                    <span class="help-block"><?php echo $Ff; ?></span>
                </div>

                <div class="form-group <?php echo (!empty($locationn))? 'has-error':''; ?>">
                    <label>Location</label>
                    <input type="text" name="location" class="form-control" value="">
                    <span class="help-block"><?php echo $locationn; ?></span>
                </div>

                <div class="form-group <?php echo (!empty($star_datee))? 'has-error':''; ?>">
                    <label>Star Date</label>
                    <input type="date" name="star_date" class="form-control" value="">
                    <span class="help-block"><?php echo $star_date; ?></span>
                </div>

                <div class="form-group <?php echo (!empty($end_datee))? 'has-error':''; ?>">
                    <label>End Date</label>
                    <input type="date" name="end_date" class="form-control" value="">
                    <span class="help-block"><?php echo $star_datee; ?></span>
                </div>
                <input type="submit" class="btn btn-primary" value="Submit">
                <a href="indexCovid.php" class="btn btn-default">Cancel</a>
            </form>
        </div>
    </div>
</div>
</body>
</html>


