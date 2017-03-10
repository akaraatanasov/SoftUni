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

    for($i = $n; $i > 2; $i--)
    {
        $count = 0;
        for($j = $i; $j > 1; $j--)
        {
            if($i % $j == 0)
            {
                $count++;
            }
        }

        if($count == 1)
        {
            array_push($numbers, $i);
        }
    }

    echo implode(" ", $numbers);
}
?>
</body>
</html>