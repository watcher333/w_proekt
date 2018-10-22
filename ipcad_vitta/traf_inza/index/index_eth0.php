<?php
exec("/var/www/html/traf_inza/traf_eth0",$traf_inza);
set_time_limit(330);
$j=0;
$sum1=0;
$sum2=0;
$sum3=0;

echo "<table border=1>\n";
echo "<tr><td><FONT SIZE=3 COLOR=green><b>IP</front></b></td>
      <td><FONT SIZE=3 COLOR=green><b>SENDMAIL[MB]</front></b></td>
      <td><FONT SIZE=3 COLOR=green><b>SQUID[MB]</front></b></td>
      <td><FONT SIZE=3 COLOR=green><b>NAT[MB]</front></b></td></tr>\n";

for($i=0;$i<(count($traf_inza)/4)-1;$i++)
{
 if($traf_inza[$i+$j+1]>9)
 {$color1=red;} else {$color1=black;}
 if($traf_inza[$i+$j+2]>9)
 {$color2=red;} else {$color2=black;}
 if($traf_inza[$i+$j+3]>9)
 {$color3=red;} else {$color3=black;}
 $sum1+=$traf_inza[$i+$j+1];
 $sum2+=$traf_inza[$i+$j+2];
 $sum3+=$traf_inza[$i+$j+3];
 printf("<tr><td><FONT SIZE=3 COLOR=blue><b>%s</b></front></td>
         </td><td><FONT SIZE=3 COLOR=$color1><b>%9.2f</b></font></td>
         </td><td><FONT SIZE=3 COLOR=$color2><b>%9.2f</b></font></td>
         </td><td><FONT SIZE=3 COLOR=$color3><b>%9.2f</b></font></td></tr>\n",
         $traf_inza[$i+$j],$traf_inza[$i+$j+1],$traf_inza[$i+$j+2],$traf_inza[$i+$j+3]);
         $j+=3;

}
 printf("<tr><td><FONT SIZE=3 COLOR=blue><b>VITTA.RU</b></front></td>
         </td><td><FONT SIZE=3 COLOR=red><b>%9.2f</b></font></td>
         </td><td><FONT SIZE=3 COLOR=red><b>%9.2f</b></font></td>
         </td><td><FONT SIZE=3 COLOR=red><b>%9.2f</b></font></td>    
         </tr>\n",$sum1,$sum2,$sum3);
echo "</table>\n";
?>
