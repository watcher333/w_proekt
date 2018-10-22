<?php
include 'conn.php';

if(isset($_POST['select1'])==true)
{
	$id=$_POST['select1'];
	$query = "select DISTINCT(adress) from pp983_report_dom where gorod='".$id."'"." "."ORDER BY adress"; 
	//$query="select DISTINCT(adress) from controll where gorod=$id";
	$result = mysql_query($query);
	$res = mysql_error($link);
	echo "<option selected='selected'>Выберите улицу</option>";
	if($result==NULL)
	{
		echo "<option>$res</option>";
		//echo "<option value = '$query' >$query</option>";
	}
	else
	{
	while($object = mysql_fetch_object($result)){

         echo "<option value = '$object->adress' > $object->adress </option>";
	 
	}
	}
   		
}

if(isset($_POST['select2'])==true)
{
	//$id=$_POST['select2'];
        //echo "<option value = '1' >$id</option>";
        /*$array = explode(":", $_POST['select2']);
        echo "<option value = '1' >$array[0]</option>";
	echo "<option value = '1' >$array[1]</option>";*/

        $array = explode(":", $_POST['select2']);
        $query = "select dom from pp983_report_dom where gorod='".$array[1]."'"." and adress='".$array[0]."'" ;
        $result = mysql_query($query);
        $res = mysql_error($link);
        echo "<option selected='selected'>Выберите номер дома</option>";
        if($result==NULL)
        {
                echo "<option>$res</option>";
                //echo "<option value = '$query' >$query</option>";
        }
        else
        {
        while($object = mysql_fetch_object($result)){

     echo "<option value = '$object->dom' > $object->dom </option>";

        }
        }

        
		
}

if(isset($_POST['select3'])==true)
{
$array = explode(":", $_POST['select3']);
$query = "select url_file from pp983_report_dom where gorod='".$array[2]."'"." and adress='".$array[1]."'"." and dom='".$array[0]."'";
$result = mysql_query($query);
$res = mysql_error($link);

 if($result==NULL)
        {
                echo $res;
                
        }
        else
        {
        while($object = mysql_fetch_object($result)){

       $name=$array[2].",".$array[1].",".$array[0];
       $url_msv = explode("*", $object->url_file);
       echo "<br><table border='1' width='480px' height='70px'><tr><td align='center'>$name</td><td align='center'>";
       for ($i=0; $i < count($url_msv); $i=$i+2)
       {
        $pos=strripos($url_msv[$i],"первый");

          if($pos==false)
           {
           $url_file="http://www.fondgkh-nso.ru/965/report_dom/".$url_msv[$i+1];
           echo "<a href='$url_file'>$url_msv[$i]</a><br>";
           }       
       }
       echo "</td></tr></table>";

        }
        }




}


 
?>

	
