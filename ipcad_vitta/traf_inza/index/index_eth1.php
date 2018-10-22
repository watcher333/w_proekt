<?php
exec("/var/www/html/traf_inza/traf_eth1",$traf_inza);
set_time_limit(330);
$j=0;
$sum1=0;
$sum2=0;

echo "<table border=1>\n";
echo "<tr><td><FONT SIZE=3 COLOR=green><b>IP</front></b></td>
      <td><FONT SIZE=3 COLOR=green><b>OUTPUT[MB]</front></b></td>
      <td><FONT SIZE=3 COLOR=green><b>INPUT[MB]</front></b></td></tr>\n";

for($i=0;$i<(count($traf_inza)/3)-1;$i++)
{
 if($traf_inza[$i+$j+1]>280)
 {$color1=red;} else {$color1=black;}
 if($traf_inza[$i+$j+2]>280)
 {$color2=red;} else {$color2=black;}
 $sum1+=$traf_inza[$i+$j+1];
 $sum2+=$traf_inza[$i+$j+2];
 printf("<tr><td><FONT SIZE=3 COLOR=blue><b>%s</b></front></td>
         </td><td><FONT SIZE=3 COLOR=$color1><b>%9.4f</b></font></td>
         </td><td><FONT SIZE=3 COLOR=$color2><b>%9.4f</b></font></td>
         </tr>\n",$traf_inza[$i+$j],$traf_inza[$i+$j+1],$traf_inza[$i+$j+2]);
         $j+=2;

}
 printf("<tr><td><FONT SIZE=3 COLOR=blue><b>VITTA.RU</b></front></td>
         </td><td><FONT SIZE=3 COLOR=red><b>%9.4f</b></font></td>
         </td><td><FONT SIZE=3 COLOR=red><b>%9.4f</b></font></td>
         </tr>\n",$sum1,$sum2);
echo "</table>\n";
?>
