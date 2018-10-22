<?php
$link = mysql_connect("localhost", "root", "") or die("no connect");
mysql_select_db("counter", $link) or die("no vibor");
$day=date('d');
$month=date('m');
$year=date('y');
$count2=0;
$date="20".$year."-".$month."-".$day;
$ip=getenv("REMOTE_ADDR")." ".getenv("HTTP_X_FORWARDED_FOR");
$query="select * from counter where ip='$ip' && other='sysadmins.ru'";
$result=mysql_query($query,$link);
while ($count=mysql_fetch_row($result))
  {
    if($ip==$count[2] && $count[4]=="sysadmins.ru")
    {
    $count1=$count[3]+1;
    $query="update counter set input='$count1',date='$date' where ip='$ip' && other='sysadmins.ru'";
    $result=mysql_query($query,$link);
    $count2++;
    }

  }



if($count2==0)
{
 $query="INSERT INTO counter (date,ip,input,other) VALUES ('$date','$ip','1','sysadmins.ru')";
 $result = mysql_query($query,$link);
 mysql_close($link);
}
?>


<HTML>
<TITLE> sysadmins </TITLE>
<BODY BGCOLOR="#e5e8e7" TEXT="#002040">
<h2 align=center><font color=green>SYSADMINS.SPACEDUST.RU</font> </h2>
<br>
<br>
<br>
<h4 align=left><font color=red>linux</font></h4>
<p><b><a href=gazeta/trafik/index.html><font color=blue>Система учета трафика связка ipcad&mysql&httpd&php</font></a></b></p>
<p><b><a href=gazeta/filial/index.html><font color=blue>Воруем интернет у своего филиала</font></a></b></p>
<p><b><a href=gazeta/service/index.html><font color=blue>Пишем свой скрипт для service (на примере openldap)</font></a></b></p>
<p><b><a href=gazeta/snort/index.html><font color=blue>Установка и настройка snort&&mysql&&base </font></a></b></p>
<p><b><a href=gazeta/openldap/index.html><font color=blue>Связка samba+openldap на Centos 5.1</font></a></b></p>
<p><b><a href=gazeta/kernel/index.html><font color=blue>Обновляем ядро на Centos5.1 </font></a></b></p>
<p><b><a href=gazeta/vmware/index.html><font color=blue>Установка vmware-server на Fedora 6</font></a></b></p>
<p><b><a href=gazeta/sendmail/index.html><font color=blue>Связка sendmail+clamav+spamassassin на Centos 5.1</font></a></b></p>
<p><b><a href=gazeta/claster/index.html><font color=blue>Пробуем сделать кластер на linux, на основе mosix</font></a></b></p>

<br>
<h4 align=left><font color=red>windows</font></h4>
<p><b><a href=gazeta/revent/index.html><font color=blue>RemoteEvent - удаленный сбор информации о событиях Windows 2003 server</font></a></b></p>
<p><b><a href=gazeta/show_process/index.html><font color=blue>Show_process - следим за процессами в сети</font></a></b></p>
<p><b><a href=gazeta/backup2005/index.html><font color=blue>backup2005 - backup баз mssql2005</font></a></b></p>
<br>
<br>
<br>
<br>
<br>
<br>
<br>
<p><h5 align=right> <font color=green>Senkevich Vyacheslav
</font></h5></p>

</BODY>

</HTML>

