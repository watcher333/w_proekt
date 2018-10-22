<script src="jquery-3.1.1.min.js"></script>
<script>
    jQuery(document).ready(function(){
        jQuery('#select1').change(function(){
            var select1 = jQuery('#select1 option:selected').val();
                     jQuery.ajax({
                type: "POST",
                url: "street.php",
                data: "select1="+select1,
                cache: false,
                success: function(html)
                 {
                   jQuery('#select2').html(html);
                }

            });
            //alert(select1);
        });

 jQuery('#select2').change(function(){
            var select2 = jQuery('#select2 option:selected').val();
            var select1 = jQuery('#select1 option:selected').val();
                     jQuery.ajax({
                type: "POST",
                url: "street.php",
                data: "select2="+select2+":"+select1,
                cache: false,
                success: function(html)
                 {
                   jQuery('#select3').html(html);
                }

            });
            //alert(select1);
        });

 

 jQuery('#select3').change(function(){

            var select3 = jQuery('#select3 option:selected').val();
            var select2 = jQuery('#select2 option:selected').val();
            var select1 = jQuery('#select1 option:selected').val();
                     jQuery.ajax({
                type: "POST",
                url: "street.php",
                data: "select3="+select3+":"+select2+":"+select1,
                cache: false,
                success: function(html)
                 {
                   jQuery('#select4').html(html);
                }

            });
            //alert(select1);
        });



    });
</script>

<!DOCTYPE html>
<html lang="ru-RU"><head>
<meta http-equiv="content-type" content="text/html; charset=UTF-8">
  <meta charset="utf-8">
  <meta http-equiv="x-ua-compatible" content="ie=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <title>Отчеты по приказу №965 — Региональный оператор капитального ремонта многоквартирных домов Новосибирской области</title>
<link rel="dns-prefetch" href="http://fonts.googleapis.com/">
<link rel="dns-prefetch" href="http://maxcdn.bootstrapcdn.com/">
<link rel="dns-prefetch" href="http://s.w.org/">
		<div class="fit-vids-style" id="fit-vids-style" style="display: none;">­<style>.fluid-width-video-wrapper{width:100%;position:relative;padding:0;}.fluid-width-video-wrapper iframe,.fluid-width-video-wrapper object,.fluid-width-video-wrapper embed {position:absolute;top:0;left:0;width:100%;height:100%;}</style></div><script type="text/javascript" id="www-widgetapi-script" src="965_files/www-widgetapi.js" async=""></script><script type="text/javascript">
			window._wpemojiSettings = {"baseUrl":"https:\/\/s.w.org\/images\/core\/emoji\/2.2.1\/72x72\/","ext":".png","svgUrl":"https:\/\/s.w.org\/images\/core\/emoji\/2.2.1\/svg\/","svgExt":".svg","source":{"concatemoji":"http:\/\/www.fondgkh-nso.ru\/wp-includes\/js\/wp-emoji-release.min.js?ver=4.7.1"}};
			!function(a,b,c){function d(a){var b,c,d,e,f=String.fromCharCode;if(!k||!k.fillText)return!1;switch(k.clearRect(0,0,j.width,j.height),k.textBaseline="top",k.font="600 32px Arial",a){case"flag":return k.fillText(f(55356,56826,55356,56819),0,0),!(j.toDataURL().length<3e3)&&(k.clearRect(0,0,j.width,j.height),k.fillText(f(55356,57331,65039,8205,55356,57096),0,0),b=j.toDataURL(),k.clearRect(0,0,j.width,j.height),k.fillText(f(55356,57331,55356,57096),0,0),c=j.toDataURL(),b!==c);case"emoji4":return k.fillText(f(55357,56425,55356,57341,8205,55357,56507),0,0),d=j.toDataURL(),k.clearRect(0,0,j.width,j.height),k.fillText(f(55357,56425,55356,57341,55357,56507),0,0),e=j.toDataURL(),d!==e}return!1}function e(a){var c=b.createElement("script");c.src=a,c.defer=c.type="text/javascript",b.getElementsByTagName("head")[0].appendChild(c)}var f,g,h,i,j=b.createElement("canvas"),k=j.getContext&&j.getContext("2d");for(i=Array("flag","emoji4"),c.supports={everything:!0,everythingExceptFlag:!0},h=0;h<i.length;h++)c.supports[i[h]]=d(i[h]),c.supports.everything=c.supports.everything&&c.supports[i[h]],"flag"!==i[h]&&(c.supports.everythingExceptFlag=c.supports.everythingExceptFlag&&c.supports[i[h]]);c.supports.everythingExceptFlag=c.supports.everythingExceptFlag&&!c.supports.flag,c.DOMReady=!1,c.readyCallback=function(){c.DOMReady=!0},c.supports.everything||(g=function(){c.readyCallback()},b.addEventListener?(b.addEventListener("DOMContentLoaded",g,!1),a.addEventListener("load",g,!1)):(a.attachEvent("onload",g),b.attachEvent("onreadystatechange",function(){"complete"===b.readyState&&c.readyCallback()})),f=c.source||{},f.concatemoji?e(f.concatemoji):f.wpemoji&&f.twemoji&&(e(f.twemoji),e(f.wpemoji)))}(window,document,window._wpemojiSettings);
		</script><script src="965_files/wp-emoji-release.js" type="text/javascript" defer="defer"></script>
		<style type="text/css">
img.wp-smiley,
img.emoji {
	display: inline !important;
	border: none !important;
	box-shadow: none !important;
	height: 1em !important;
	width: 1em !important;
	margin: 0 .07em !important;
	vertical-align: -0.1em !important;
	background: none !important;
	padding: 0 !important;
}
</style>
<link rel="stylesheet" id="jeweltheme-jquery-ui-style-css" href="965_files/jquery-ui.css" type="text/css" media="all">
<link rel="stylesheet" id="dashicons-css" href="965_files/dashicons.css" type="text/css" media="all">
<link rel="stylesheet" id="contact-form-7-css" href="965_files/styles.css" type="text/css" media="all">
<link rel="stylesheet" id="rss-news-display.css-css" href="965_files/rss-news-display.css" type="text/css" media="all">
<link rel="stylesheet" id="ccss-css" href="965_files/a.css" type="text/css" media="all">
<link rel="stylesheet" id="__EPYT__style-css" href="965_files/ytprefs.css" type="text/css" media="all">
<style id="__EPYT__style-inline-css" type="text/css">

                .epyt-gallery-thumb {
                        width: 33.333%;
                }
                
</style>
<link rel="stylesheet" id="sage/roboto-css" href="965_files/css.css" type="text/css" media="all">
<link rel="stylesheet" id="sage/fa-css" href="965_files/font-awesome.css" type="text/css" media="all">
<link rel="stylesheet" id="sage/css-css" href="965_files/main.css" type="text/css" media="all">
<script type="text/javascript" src="965_files/jquery_002.js"></script>
<script type="text/javascript" src="965_files/jquery-migrate.js"></script>
<script type="text/javascript" src="965_files/jquery_003.js"></script>
<script type="text/javascript">
/* <![CDATA[ */
var _EPYT_ = {"ajaxurl":"http:\/\/www.fondgkh-nso.ru\/wp-admin\/admin-ajax.php","security":"2e03835b2f","gallery_scrolloffset":"20","eppathtoscripts":"http:\/\/www.fondgkh-nso.ru\/wp-content\/plugins\/youtube-embed-plus\/scripts\/","epresponsiveselector":"[\"iframe.__youtube_prefs_widget__\"]","epdovol":"1","version":"11.5","evselector":"iframe.__youtube_prefs__[src], iframe[src*=\"youtube.com\/embed\/\"], iframe[src*=\"youtube-nocookie.com\/embed\/\"]"};
/* ]]> */
</script>
<script type="text/javascript" src="965_files/ytprefs.js"></script><script src="965_files/iframe_api" type="text/javascript"></script>
<link rel="https://api.w.org/" href="http://www.fondgkh-nso.ru/wp-json/">
<link rel="EditURI" type="application/rsd+xml" title="RSD" href="http://www.fondgkh-nso.ru/xmlrpc.php?rsd">
<link rel="wlwmanifest" type="application/wlwmanifest+xml" href="http://www.fondgkh-nso.ru/wp-includes/wlwmanifest.xml"> 
<meta name="generator" content="WordPress 4.7.1">
<link rel="canonical" href="http://www.fondgkh-nso.ru/popechitelskij-sovet/">
<link rel="shortlink" href="http://www.fondgkh-nso.ru/?p=318">
<link rel="alternate" type="application/json+oembed" href="http://www.fondgkh-nso.ru/wp-json/oembed/1.0/embed?url=http%3A%2F%2Fwww.fondgkh-nso.ru%2Fpopechitelskij-sovet%2F">
<link rel="alternate" type="text/xml+oembed" href="http://www.fondgkh-nso.ru/wp-json/oembed/1.0/embed?url=http%3A%2F%2Fwww.fondgkh-nso.ru%2Fpopechitelskij-sovet%2F&amp;format=xml">
		<style type="text/css">.recentcomments a{display:inline !important;padding:0 !important;margin:0 !important;}</style>
		<link rel="icon" href="http://www.fondgkh-nso.ru/wp-content/uploads/2016/12/logo-80x80.png" sizes="32x32">
<link rel="icon" href="http://www.fondgkh-nso.ru/wp-content/uploads/2016/12/logo.png" sizes="192x192">
<link rel="apple-touch-icon-precomposed" href="http://www.fondgkh-nso.ru/wp-content/uploads/2016/12/logo.png">
<meta name="msapplication-TileImage" content="http://www.fondgkh-nso.ru/wp-content/uploads/2016/12/logo.png">
<script type="text/javascript">

    jQuery(document).ready(function($) {
            jQuery(".accordion").accordion({heightStyle: "content", collapsible: true, active: false});
    });

    
</script>
</head>
  <body class="page-template page-template-page-templates page-template-left-sidebar-page page-template-page-templatesleft-sidebar-page-php page page-id-318 popechitelskij-sovet">
    <!--[if IE]>
      <div class="alert alert-warning">
        Вы используете <strong>устаревший</strong> браузер. Пожалуйста, <a href="http://browsehappy.com/">обновите Ваш браузер</a> для лучшего отображения сайта.      </div>
    <![endif]-->
    <header class="banner">
  <style type="text/css">
        .header-image {
      background: url(http://www.fondgkh-nso.ru/wp-content/uploads/2016/12/3NSK-header-bg2.png) no-repeat 50% 50%;
      -webkit-background-size: cover;
      -moz-background-size:    cover;
      -o-background-size:      cover;
      background-size:         cover;
      height: 225px;
    }
      </style>
  <div class="container-fluid" style="padding: 0;">
    <div class="header-image">
      <div class="col-lg-offset-2 col-lg-6 col-sm-offset-1 col-sm-10 col-xs-12">
        <table>
          <tbody><tr>
            <td class="col-lg-2 col-xs-2">
              <img src="965_files/logo.png" alt="Региональный оператор капитального ремонта многоквартирных домов Новосибирской области" class="img-responsive pull-left">            </td>
            <td style="padding-left: 9px;">
              <hr>
              <h3 class="site-title"><a href="http://www.fondgkh-nso.ru/" rel="home">Региональный оператор капитального ремонта многоквартирных домов Новосибирской области</a></h3>
              <hr>
            </td>
          </tr>
        </tbody></table>
      </div>
    </div>
    <nav>
            <div class="navbar navbar-default nav-top-wrap">
        <div class="container">
          <div class="nav-top">
            <div class="navbar-header">
              <!-- .navbar-toggle is used as the toggle for collapsed navbar content -->
              <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                <span class="sr-only">Toggle navigation</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
              </button>
            </div>

            <!-- The WordPress Menu goes here -->
            <div class="collapse navbar-collapse"><ul id="main-menu" class="nav navbar-nav nav-top-desktop pull-right"><li id="menu-item-347" class="menu-item menu-item-type-custom menu-item-object-custom current-menu-ancestor current-menu-parent menu-item-has-children menu-item-347 dropdown"><a title="Фонд" href="#" data-toggle="dropdown" class="dropdown-toggle" aria-haspopup="true">Фонд <span class="caret"></span></a>
<ul role="menu" class=" dropdown-menu">
	<li id="menu-item-257" class="menu-item menu-item-type-post_type menu-item-object-page menu-item-257"><a title="О фонде" href="http://www.fondgkh-nso.ru/o-fonde/">О фонде</a></li>
	<li id="menu-item-351" class="menu-item menu-item-type-post_type menu-item-object-page menu-item-351"><a title="Правление фонда" href="http://www.fondgkh-nso.ru/pravlenie-fonda/">Правление фонда</a></li>
	<li id="menu-item-350" class="menu-item menu-item-type-post_type menu-item-object-page current-menu-item page_item page-item-318 current_page_item menu-item-350 active"><a title="Отчеты по приказу №965" href="http://www.fondgkh-nso.ru/popechitelskij-sovet/">    Попечительский совет
    Общественный совет
    Правление фонда
    Контроль
    Отчетность
    Общие сведения
    Закупки (архив)
    Конкурсы (архив)
    Отчеты по приказу №965

Правление фонда
</a></li>
	<li id="menu-item-348" class="menu-item menu-item-type-post_type menu-item-object-page menu-item-348"><a title="Регламентирующие документы" href="http://www.fondgkh-nso.ru/ustav/">Регламентирующие документы</a></li>
	<li id="menu-item-716" class="menu-item menu-item-type-post_type menu-item-object-page menu-item-716"><a title="Общие сведения" href="http://www.fondgkh-nso.ru/obshie_sveden/">Общие сведения</a></li>
	<li id="menu-item-532" class="menu-item menu-item-type-post_type menu-item-object-page menu-item-532"><a title="Отчетность" href="http://www.fondgkh-nso.ru/otchety_fkr/">Отчетность</a></li>
	<li id="menu-item-517" class="menu-item menu-item-type-post_type menu-item-object-page menu-item-517"><a title="Контроль" href="http://www.fondgkh-nso.ru/otchety/">Контроль</a></li>
	<li id="menu-item-379" class="menu-item menu-item-type-post_type menu-item-object-page menu-item-379"><a title="Общественный совет" href="http://www.fondgkh-nso.ru/konkursy/">Общественный совет</a></li>
	<li id="menu-item-5486" class="menu-item menu-item-type-post_type menu-item-object-page menu-item-5486"><a title="Руководство" href="http://www.fondgkh-nso.ru/rukovodstvo/">Руководство</a></li>
</ul>
</li>
<li id="menu-item-42" class="menu-item menu-item-type-custom menu-item-object-custom menu-item-42"><a title="Главная" href="http://www.fondgkh-nso.ru/">Главная</a></li>
<li id="menu-item-374" class="menu-item menu-item-type-custom menu-item-object-custom menu-item-has-children menu-item-374 dropdown"><a title="Новости" href="#" data-toggle="dropdown" class="dropdown-toggle" aria-haspopup="true">Новости <span class="caret"></span></a>
<ul role="menu" class=" dropdown-menu">
	<li id="menu-item-36" class="menu-item menu-item-type-taxonomy menu-item-object-category menu-item-36"><a title="Наши новости" href="http://www.fondgkh-nso.ru/category/news/">Наши новости</a></li>
	<li id="menu-item-5233" class="menu-item menu-item-type-post_type menu-item-object-page menu-item-5233"><a title="Видео" href="http://www.fondgkh-nso.ru/video/">Видео</a></li>
	<li id="menu-item-5247" class="menu-item menu-item-type-custom menu-item-object-custom menu-item-5247"><a title="Министерство ЖКХ и энергетики НСО" href="http://www.mjkh.nso.ru/news">Министерство ЖКХ и энергетики НСО</a></li>
	<li id="menu-item-5246" class="menu-item menu-item-type-custom menu-item-object-custom menu-item-5246"><a title="Фонд Содействия Реформированию ЖКХ" href="http://fondgkh.ru/news/c/novosti/">Фонд Содействия Реформированию ЖКХ</a></li>
</ul>
</li>
<li id="menu-item-430" class="menu-item menu-item-type-post_type menu-item-object-page menu-item-430"><a title="Законодательство" href="http://www.fondgkh-nso.ru/norms/">Законодательство</a></li>
<li id="menu-item-345" class="menu-item menu-item-type-post_type menu-item-object-page menu-item-345"><a title="Обратная связь" href="http://www.fondgkh-nso.ru/feedback/">Обратная связь</a></li>
<li id="menu-item-442" class="menu-item menu-item-type-post_type menu-item-object-page menu-item-442"><a title="Контакты" href="http://www.fondgkh-nso.ru/kontakty/">Контакты</a></li>
<li id="menu-item-5329" class="menu-item menu-item-type-post_type menu-item-object-page menu-item-5329"><a title="Руководство" href="http://www.fondgkh-nso.ru/rukovodstvo/">Руководство</a></li>
</ul></div>          </div>
        </div>
      </div><!-- .navbar -->
    </nav><!-- .site-navigation -->
  </div>
</header>
    <div class="wrap container-fluid" role="document">
      <div class="content row">
        <main class="main">
          <section class="row content-page">
  <div class="col-lg-2">
    <div></div>
  </div>
  <div class="col-lg-8">
          
<div class="page-header">
  <ul id="breadcrumbs" class="breadcrumbs"><li class="item-home"><a class="bread-link bread-home" href="http://www.fondgkh-nso.ru/" title="Главная">Главная</a></li><li class="separator separator-home"> &gt; </li><li class="item-current item-318"><strong class="bread-current bread-318"> Отчеты по приказу №965</strong></li></ul>  <h1>Отчеты по приказу №965</h1>
</div>
      <div class="row">
  <div class="col-xs-3">
    <nav class="nav-primary">
      <div class="menu-%d0%be-%d1%84%d0%be%d0%bd%d0%b4%d0%b5-container"><ul id="menu-%d0%be-%d1%84%d0%be%d0%bd%d0%b4%d0%b5" class="nav"><li id="menu-item-258" class="menu-item menu-item-type-post_type menu-item-object-page menu-item-258"><a href="http://www.fondgkh-nso.ru/o-fonde/">О фонде</a></li>
<li id="menu-item-265" class="menu-item menu-item-type-post_type menu-item-object-page menu-item-265"><a href="http://www.fondgkh-nso.ru/ustav/">Регламентирующие документы</a></li>
<li id="menu-item-321" class="menu-item menu-item-type-post_type menu-item-object-page current-menu-item page_item page-item-318 current_page_item menu-item-321"><a href="http://www.fondgkh-nso.ru/popechitelskij-sovet/">Попечительский совет</a></li>
<li id="menu-item-357" class="menu-item menu-item-type-post_type menu-item-object-page menu-item-357"><a href="http://www.fondgkh-nso.ru/konkursy/">Общественный совет</a></li>
<li id="menu-item-324" class="menu-item menu-item-type-post_type menu-item-object-page menu-item-324"><a href="http://www.fondgkh-nso.ru/pravlenie-fonda/">Правление фонда</a></li>
<li id="menu-item-518" class="menu-item menu-item-type-post_type menu-item-object-page menu-item-518"><a href="http://www.fondgkh-nso.ru/otchety/">Контроль</a></li>
<li id="menu-item-531" class="menu-item menu-item-type-post_type menu-item-object-page menu-item-531"><a href="http://www.fondgkh-nso.ru/otchety_fkr/">Отчетность</a></li>
<li id="menu-item-717" class="menu-item menu-item-type-post_type menu-item-object-page menu-item-717"><a href="http://www.fondgkh-nso.ru/obshie_sveden/">Общие сведения</a></li>
<li id="menu-item-5320" class="menu-item menu-item-type-taxonomy menu-item-object-category menu-item-5320"><a href="http://www.fondgkh-nso.ru/category/general/partners/zakupki/">Закупки (архив)</a></li>
<li id="menu-item-5321" class="menu-item menu-item-type-taxonomy menu-item-object-category menu-item-5321"><a href="http://www.fondgkh-nso.ru/category/konkursy/">Конкурсы (архив)</a></li>
<li id="menu-item-5567" class="menu-item menu-item-type-custom menu-item-object-custom menu-item-5567"><a href="http://www.fondgkh-nso.ru/965/report.php">Отчеты по приказу №965</a></li>
</ul></div>    </nav>
  </div>
  <div class="col-xs-9">
   <p>Отчет специализированной некоммерческой организации, осуществляющей деятельность, направленную на обеспечение проведения капитального ремонта общего имущества в многоквартирных домах (Приказ Минстроя России от 30.12.2015 г. № 965/пр)</p>
    <?php

include 'conn.php';

/*$link = mysql_connect('localhost', 'root', 'jomlaBD') or die('Не удалось соединиться: ' . mysql_error());

mysql_set_charset('utf8',$link);

mysql_select_db('336J7') or die('Не удалось выбрать базу данных');*/

// Выполняем SQL-запрос
$query = 'SELECT DISTINCT(gorod) FROM pp983_report_dom ORDER BY gorod';
$result = mysql_query($query) or die('Запрос не удался: ' . mysql_error());

echo "<form action='' method='POST'>";

echo "<table><tr><td><br>Выберите город<br>";

echo "<select id='select1' name='select1'>";

echo "<option selected='selected'>Выберите город</option>";
while($object = mysql_fetch_object($result)){

       echo "<option value = '$object->gorod' > $object->gorod </option>";

}
echo "</select></td></tr>";

echo "<tr><td><br>Выберите улицу</td></tr>";

echo "<tr><td>";

echo "<select id='select2' name='select2'><option selected='selected'>Выберите улицу</option></select>";

echo "</td></tr>";

echo "<tr><td><br>Выберите номер дома</td></tr>";

echo "<tr><td>";

echo "<select id='select3' name='select3'><option selected='selected'>Выберите номер дома</option></select>";

echo "</td></tr>";


echo "<tr><td>";

echo "<div id='select4' name='select4'></div>";

 

echo "</td></tr></table></form>";

 

mysql_free_result($result);

mysql_close($link);

?>
      </div>
</div>
      </div>
  <div class="col-lg-2">
    <div class="visible-lg-block our-charters">
  </div>
  </div>
</section>
        </main><!-- /.main -->
              </div><!-- /.content -->
    </div><!-- /.wrap -->
    <footer class="content-info" id="site-footer">
  <div class="container">
    <div class="row">
      <section class="col-lg-3 col-md-4">        <a href="https://www.reformagkh.ru/" class="charter-btn">
            <div class="media alert btn-info">
              <div class="media-left media-middle">
                <img class="media-object" src="965_files/reforma-jkh.png"></div>
              <div class="media-body media-middle">
                <p><small>Реформа ЖКХ</small></p>              </div>
            </div>
          </a>
        </section><section class="col-lg-3 col-md-4">        <a href="https://www.nso.ru/" class="charter-btn">
            <div class="media alert btn-info">
              <div class="media-left media-middle">
                <img class="media-object" src="965_files/default_logo.png"></div>
              <div class="media-body media-middle">
                <p><small>Правительство Новосибирской области </small></p>              </div>
            </div>
          </a>
        </section><section class="col-lg-3 col-md-4">        <a href="http://fondgkh.ru/" class="charter-btn">
            <div class="media alert btn-info">
              <div class="media-left media-middle">
                <img class="media-object" src="965_files/fond-sodeistviya.png"></div>
              <div class="media-body media-middle">
                <p><small>Фонд содействия реформирования ЖКХ</small></p>              </div>
            </div>
          </a>
        </section><section class="col-lg-3 col-md-4">        <a href="http://gkhrazvitie.ru/" class="charter-btn">
            <div class="media alert btn-info">
              <div class="media-left media-middle">
                <img class="media-object" src="965_files/razvitie_jkh.png"></div>
              <div class="media-body media-middle">
                <p><small>Развитие ЖКХ</small></p>              </div>
            </div>
          </a>
        </section>    </div>
    <div class="row">
      <p class="copyright">
        <span class="glyphicon glyphicon-copyright-mark"></span>&nbsp;2017 Фонд модернизации ЖКХ
      </p>
    </div>
  </div>
</footer>
<script type="text/javascript" src="965_files/core.js"></script>
<script type="text/javascript" src="965_files/widget.js"></script>
<script type="text/javascript" src="965_files/accordion.js"></script>
<script type="text/javascript" src="965_files/jquery.js"></script>
<script type="text/javascript">
/* <![CDATA[ */
var _wpcf7 = {"recaptcha":{"messages":{"empty":"\u041f\u043e\u0436\u0430\u043b\u0443\u0439\u0441\u0442\u0430 \u043f\u043e\u0434\u0442\u0432\u0435\u0440\u0434\u0438\u0442\u0435, \u0447\u0442\u043e \u0412\u044b - \u043d\u0435 \u0440\u043e\u0431\u043e\u0442."}}};
/* ]]> */
</script>
<script type="text/javascript" src="965_files/scripts.js"></script>
<script type="text/javascript" src="965_files/main.js"></script>
<script type="text/javascript" src="965_files/fitvids.js"></script>
<script type="text/javascript" src="965_files/wp-embed.js"></script>
  

</body></html>
