<?php
	$korime = $_POST["korime"];
	$lozinka = $_POST["loz"];
	
	$con = pg_connect("host=localhost port=5432 dbname=postgres user=postgres password=admin")
		or die("Could not connect\n");
	$query = "SELECT * FROM korisnici WHERE korime = '$korime' AND lozinka = '$lozinka'";
	
	$result = pg_query($con, $query) or die("Could not execute query\n");

	if (!$result) {
		echo "Problem with query " . $query . "<br\>";
		echo pg_last_error();
		exit();
	}	
	
	$myrow = pg_fetch_assoc($result);
	if($myrow == NULL)
		echo "-1";
	else
		echo "$myrow[id]";
	pg_close($con);
?>