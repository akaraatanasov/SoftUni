<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    N: <input type="text" name="num" />
    <input type="submit" />
</form>
<?php
if(isset($_GET['num']))
{
    $n = intval($_GET['num']);
    $numbers = array();

    for($i = 0; $i < $n; $i++)
    {
        if ($i == 0 || $i == 1)
        {
            array_push($numbers, 1);
        }
        else if($i == 2)
        {
            array_push($numbers, 2);
        }
        else
        {
            array_push($numbers, $numbers[$i - 1] + $numbers[$i - 2] + $numbers[$i - 3]);
        }
    }

    echo implode(" ", $numbers);
}
?>
</body>
</html>