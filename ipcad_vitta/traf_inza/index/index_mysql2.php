<?php
if(isset($_POST['month_begin']) && isset($_POST['year_begin']) && isset($_POST['day_begin']) && isset($_POST['year_end']) && isset($_POST['month_end']) && isset($_POST['day_end']))
{
  $date_d1=$_POST['day_begin'];
  $date_m1=$_POST['month_begin'];
  $date_y1=$_POST['year_begin'];
  $date_d2=$_POST['day_end'];
  $date_m2=$_POST['month_end'];
  $date_y2=$_POST['year_end'];
  
  $date_begin=$date_y1."-".$date_m1."-".$date_d1;
  $date_end=$date_y2."-".$date_m2."-".$date_d2;

echo "<HTML><TITLE> ipcad.vitta.ru $date_begin  -  $date_end </TITLE></HTML>";

echo "<table border=1>\n";
echo "<tr><td><FONT SIZE=3 COLOR=green><b>IP</front></b></td>
      <td><FONT SIZE=3 COLOR=green><b>SENDMAIL[MB]</front></b></td>
      <td><FONT SIZE=3 COLOR=green><b>SQUID[MB]</front></b></td>
      <td><FONT SIZE=3 COLOR=green><b>NAT[MB]</front></b></td></tr>\n";

$link = mysql_connect("localhost", "root", "") or die("no connect");
mysql_select_db("vitta", $link) or die("no vibor");

$ip_array=file("/var/www/html/traf_inza/eth0");
for($i=0;$i<count($ip_array);$i++)
{
$ip=trim($ip_array[$i]);
$query="select * from eth0 where ip='$ip' && date>='$date_begin' && date<='$date_end';";
$result = mysql_query($query,$link);
$sum_mail=0;
$sum_squid=0;
$sum_nat=0;

while ($traf=mysql_fetch_row($result))
  {
    $sum_mail+=$traf[3];
    $sum_squid+=$traf[4];
    $sum_nat+=$traf[5];
  }

printf("<tr><td><FONT SIZE=3 COLOR=blue><b>%s</b></front></td>
         </td><td><FONT SIZE=3 COLOR=black><b>%9.2f</b></font></td>
         </td><td><FONT SIZE=3 COLOR=black><b>%9.2f</b></font></td>
         </td><td><FONT SIZE=3 COLOR=black><b>%9.2f</b></font></td></tr>\n",
         $ip,$sum_mail,$sum_squid,$sum_nat);


}

$query="select * from eth0 where ip='VITTA' && date>='$date_begin' && date<='$date_end';";
$result = mysql_query($query,$link);
$sum_mail=0;
$sum_squid=0;
$sum_nat=0;
while ($traf=mysql_fetch_row($result))
  {
    $sum_mail+=$traf[3];
    $sum_squid+=$traf[4];
    $sum_nat+=$traf[5];
  }
printf("<tr><td><FONT SIZE=3 COLOR=blue><b>VITTA.RU</b></front></td>
         </td><td><FONT SIZE=3 COLOR=red><b>%9.2f</b></font></td>
         </td><td><FONT SIZE=3 COLOR=red><b>%9.2f</b></font></td>
         </td><td><FONT SIZE=3 COLOR=red><b>%9.2f</b></font></td></tr>\n",
         $sum_mail,$sum_squid,$sum_nat);


echo "</table>";

echo "<table border=1>\n";
echo "<tr><td><FONT SIZE=3 COLOR=green><b>IP</front></b></td>
      <td><FONT SIZE=3 COLOR=green><b>OUTPUT[MB]</front></b></td>
      <td><FONT SIZE=3 COLOR=green><b>INPUT[MB]</front></b></td></tr>\n";

$ip_array=file("/var/www/html/traf_inza/eth1");
for($i=0;$i<count($ip_array);$i++)
{
   
   $ip=trim($ip_array[$i]);
   $query="select * from eth1 where ip='$ip' && date>='$date_begin' && date<='$date_end';";
   $result = mysql_query($query,$link);
   $sum_out=0;
   $sum_in=0;
while ($traf=mysql_fetch_row($result))
  {
    $sum_out+=$traf[3];
    $sum_in+=$traf[4];
  }
        
printf("<tr><td><FONT SIZE=3 COLOR=blue><b>%s</b></front></td>
         </td><td><FONT SIZE=3 COLOR=black><b>%9.4f</b></font></td>
         </td><td><FONT SIZE=3 COLOR=black><b>%9.4f</b></font></td>
         </tr>\n",$ip,$sum_out,$sum_in);

}

$query="select * from eth1 where ip='VITTA' && date>='$date_begin' && date<='$date_end';";
$result = mysql_query($query,$link);
$sum_out=0;
$sum_in=0;
while ($traf=mysql_fetch_row($result))
  {
    $sum_out+=$traf[3];
    $sum_in+=$traf[4];
  }

printf("<tr><td><FONT SIZE=3 COLOR=blue><b>VITTA.RU</b></front></td>
         </td><td><FONT SIZE=3 COLOR=red><b>%9.4f</b></font></td>
         </td><td><FONT SIZE=3 COLOR=red><b>%9.4f</b></font></td>
         </tr>\n",$sum_out,$sum_in);


echo "</table>";
mysql_close($link);


}
?>
