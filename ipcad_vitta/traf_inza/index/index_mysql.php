<?php
exec("/var/www/html/traf_inza/traf_eth0",$traf_inza);
exec("/var/www/html/traf_inza/traf_eth1",$traf_inza1);
set_time_limit(330);
$j=0;
$sum1=0;
$sum2=0;
$sum3=0;

$day=date('d');
$month=date('m');
$year=date('y'); 
$date="20".$year."-".$month."-".$day;

$link = mysql_connect("localhost", "root", "") or die("no connect"); 
mysql_select_db("vitta", $link) or die("no vibor");

for($i=0;$i<(count($traf_inza)/4)-1;$i++)
{
$traf_ip=trim($traf_inza[$i+$j]);
$traf_mail=trim($traf_inza[$i+$j+1]);
$traf_squid=trim($traf_inza[$i+$j+2]);
$traf_nat=trim($traf_inza[$i+$j+3]);
$sum1+=$traf_inza[$i+$j+1];
$sum2+=$traf_inza[$i+$j+2];
$sum3+=$traf_inza[$i+$j+3];

$query="INSERT INTO eth0 (date,ip,sendmail,squid,nat) VALUES ('$date','$traf_ip','$traf_mail','$traf_squid','$traf_nat')";
$result = mysql_query($query,$link);
$j+=3;

}
$query="INSERT INTO eth0 (date,ip,sendmail,squid,nat) VALUES ('$date','VITTA','$sum1','$sum2','$sum3')";
$result = mysql_query($query,$link);

$j=0;
$sum1=0;
$sum2=0;
for($i=0;$i<(count($traf_inza1)/3)-1;$i++)
{
$traf_ip=trim($traf_inza1[$i+$j]);
$traf_out=trim($traf_inza1[$i+$j+1]);
$traf_in=trim($traf_inza1[$i+$j+2]);
$sum1+=$traf_inza1[$i+$j+1];
$sum2+=$traf_inza1[$i+$j+2];
$query="INSERT INTO eth1 (date,ip,output,input) VALUES ('$date','$traf_ip','$traf_out','$traf_in')";
$result = mysql_query($query,$link);
$j+=2;
}
$query="INSERT INTO eth1 (date,ip,output,input) VALUES ('$date','VITTA','$sum1','$sum2')";
$result = mysql_query($query,$link);
mysql_close($link);
exec("/usr/bin/rsh localhost clear ip accounting");
?>
