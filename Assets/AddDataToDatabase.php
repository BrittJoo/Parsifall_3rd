<?php 
        $database = mysql_connect('mysql_host', 'mysql_user', 'mysql_password') or die('Could not connect: ' . mysql_error()); 
        mysql_select_db('my_database') or die('Could not select database');
 
 
        // Strings must be escaped to prevent SQL injection attack. 
        $character = mysql_real_escape_string($_GET['character'], $db); 
		
		$characterScore = mysql_real_escape_string($_GET['characterScore'], $db); 
		
        $stellingOneAnswer = mysql_real_escape_string($_GET['stellingOneAnswer'], $db); 
		$stellingTwoAnswer = mysql_real_escape_string($_GET['stellingTwoAnswer'], $db); 
		$stellingThreeAnswer = mysql_real_escape_string($_GET['stellingThreeAnswer'], $db); 
		$stellingFourAnswer = mysql_real_escape_string($_GET['stellingFourAnswer'], $db); 
		$stellingFiveAnswer = mysql_real_escape_string($_GET['stellingFiveAnswer'], $db);		
		$stellingSixAnswer = mysql_real_escape_string($_GET['stellingSixAnswer'], $db);	
		$stellingSevenAnswer = mysql_real_escape_string($_GET['stellingSevenAnswer'], $db);
		$stellingEightAnswer = mysql_real_escape_string($_GET['stellingEightAnswer'], $db);
		$stellingNineAnswer = mysql_real_escape_string($_GET['stellingNineAnswer'], $db);
		
		$stellingTenAnswer = mysql_real_escape_string($_GET['stellingOneAnswer'], $db); 
		$stellingElevenAnswer = mysql_real_escape_string($_GET['stellingTwoAnswer'], $db); 
		$stellingTwelveAnswer = mysql_real_escape_string($_GET['stellingThreeAnswer'], $db); 
		$stellingThirteenAnswer = mysql_real_escape_string($_GET['stellingFourAnswer'], $db); 
		$stellingFourteenAnswer = mysql_real_escape_string($_GET['stellingFiveAnswer'], $db);		
		$stellingFifteenAnswer = mysql_real_escape_string($_GET['stellingSixAnswer'], $db);	
		$stellingSixteenAnswer = mysql_real_escape_string($_GET['stellingSevenAnswer'], $db);
		$stellingSeventeenAnswer = mysql_real_escape_string($_GET['stellingEightAnswer'], $db);
		$stellingEighteenAnswer = mysql_real_escape_string($_GET['stellingNineAnswer'], $db);
		
		// This will contain the data points required send by the C# script in unity
        $hash = $_GET['hash']; 
 
        $uniqueKey = "mySecretKey"; # Change this value to match the value stored in the client c# script 
		
		
        $real_hash = md5($character . $characterScore . $stellingOneAnswer . $stellingTwoAnswer . $stellingThreeAnswer . $stellingFourAnswer . $stellingFiveAnswer . $stellingSixAnswer . $stellingSevenAnswer . $stellingEightAnswer . $stellingNineAnswer
						 . $stellingTenAnswer . $stellingElevenAnswer . $stellingTwelveAnswer . $stellingThirteenAnswer . $stellingFourteenAnswer . $stellingFifteenAnswer . $stellingSixteenAnswer . $stellingSeventeenAnswer . $stellingEighteenAnswer . $uniqueKey); 
						 
		// Sees if the datapoints from the given hash matches the tables in the database. (I assume - 03-07-18)				 
        if($real_hash == $hash) 
		{ 
            // Send variables for the MySQL database class. 
			// "DataValue" needs to be the SQL query (i.e Datavalues.sql) when creating a table.
            $query = "insert into DataValue values (NULL, '$character', '$characterScore', '$stellingOneAnswer', '$stellingTwoAnswer', '$stellingThreeAnswer', '$stellingFourAnswer'
													, '$stellingFiveAnswer', '$stellingSixAnswer', '$stellingSevenAnswer', '$stellingEightAnswer', '$stellingNineAnswer', '$stellingTenAnswer'
													, '$stellingElevenAnswer', '$stellingTwelveAnswer', '$stellingThirteenAnswer', '$stellingFourteenAnswer', '$stellingFifteenAnswer'
													, '$stellingSixteenAnswer', '$stellingSeventeenAnswer', '$stellingEighteenAnswer');"; 
            $result = mysql_query($query) or die('Query failed: ' . mysql_error()); 
        } 
?>