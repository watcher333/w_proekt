<?php 
$host="localhost:/var/lib/firebird/php_base.fdb"; 
$username="SYSDBA"; 
$password="gjkyjtufdyj"; 
$dbh=@ibase_connect($host, $username, $password) or die("no");
#$query="insert into temp(id,date1,ip,input) values(4,'07.10.2008','ddd',50);";
#$result=ibase_query($dbh,$query);
$query="select * from temp;";
$result=ibase_query($dbh,$query);
echo "<html><body><table border=1>";
while ($row = ibase_fetch_row($result))
{
printf("<tr><td>%s</td><td>%s</td><td>%s</td></tr>",$row[1],$row[2],$row[3]);
}

echo "</table></body></html>";
ibase_close ($dbh);
?> 
