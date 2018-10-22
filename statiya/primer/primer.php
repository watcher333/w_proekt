<?php
$handle = fopen("file", "w");
if($handle==null)
{
 printf("no create file");
}
else
{
printf("create file");

}
$ip=getenv("HTTP_X_FORWARDED_FOR");
$ip1=getenv("REMOTE_ADDR");
//echo $_SERVER["SERVER_ADDR"];
//echo $ip;
//echo "aaa";
//echo $ip1; 

?>

