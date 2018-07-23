/*---------------------------------------------------------------
# Package - Joomla Template based on Sboost Framework   
# ---------------------------------------------------------------
# Author - mixwebtemplates http://www.mixwebtemplates.com
# Copyright (C) 2008 - 2015 mixwebtemplates.com. All Rights Reserved.
# Websites: http://www.mixwebtemplates.com
-----------------------------------------------------------------*/

body.bg{color: #222;background-color:#fff}
body{margin:0;font-family:Arial,Helvetica,sans-serif;font-size:12px;line-height:150%}
a{text-decoration:none;}
a:hover,a:active,a:focus{text-decoration:none;}
.mx-base{margin-left:auto;margin-right:auto}
.mx-block{float:left;display:inline}
.mod-block {padding:10px}
.mx-inner{padding-left:10px;padding-right:10px}
.mx-block .first {margin-left:-10px}
.mx-block .last {margin-right:-10px}
.mx-block .single {margin-left:-10px;margin-right:-10px}
.gap{clear:both;margin-bottom:10px}
.top-bg{padding-top:10px}
.clearfix{*zoom:1;}.clearfix:before,.clearfix:after{display:table;content:"";line-height:0;}
.clearfix:after{clear:both;}
/*top bar*/
#mx-top-header {margin-top:3px;}
#mx-banner,
#mx-search,
#members-area{float:right}
#mx-search {margin-top:10px;}
#mx-top-menu{margin-top:10px;float:left}
#mx-top-menu ul.menu {margin:0;padding:0;}
/*#mx-top-menu li{display:inline-block;list-style:none;border-left:1px solid #ccc;padding:0 5px;line-height:12px}*/
#mx-top-menu li{display:inline-block;list-style:none;border-left:1px solid #01A9DB;padding:0 5px;line-height:12px}
#mx-top-menu li a{color:#6f6f6f}


/*Header*/
#headershow .mx-inner {padding:0}
#header {position:relative}
.slider .mx-inner {padding:0}
a#logo,#logo-text,a#logom{float:left; position: relative; z-index: 100;}
#logo-text h1{font-size:200%;font-weight:bold;text-transform:uppercase;border:0!important;margin:10px 0 0!important;padding:0!important}
#logo-text h1 a{}
#logo-text p.site-slogan{margin:0;padding:0;}

/*search*/
#mx-search .mod-search input#mod-search-searchword, 
#mx-search .mod-search input#mod-finder-searchword{background:#fff url(../images/search.png) no-repeat 3% 50%;padding: 4px 3px 4px 30px; margin:0;
	border-radius:5px;
	-moz-border-radius:5px;
	-webkit-border-radius:5px;
	box-shadow:0 0 6px rgba(0,0,0,0.3);
}

/* Layout */
#mx-leftcol, #mx-rightcol, #mx-maincol ,#mx-sideleft, #mx-sideright, #inner_content {float:left}
#mx-leftcol, #mx-rightcol, #mx-maincol {padding:10px 0}
#sj-br{position: absolute; top: 0px; left: -5500px;}

/* Breadcrumbs */
#mx-breadcrumbs .mx-inner {padding:0}
#mx-breadcrumbs .breadcrumb {
	margin:0;
	background:transparent;
	-webkit-border-radius: 0;
	-moz-border-radius: 0;
	border-radius: 0;
	border-top:1px solid #e7e7e7;
	border-bottom:1px solid #e7e7e7	
}
.readmore, a.readmore {
	font-size: 0.9em;
	text-align: center;
	-webkit-transition: background-color 0.2s ease-in-out;
	-moz-transition: background-color 0.2s ease-in-out;
	-ms-transition: background-color 0.2s ease-in-out;
	-o-transition: background-color 0.2s ease-in-out;
	transition: background-color 0.2s ease-in-out;
	color: #ffffff;
	background: #444;
	border-radius: 3px;
	padding: 3px 8px;
}
/* Footer */
#mx-footer {}
#mx-bft { padding:10px}
#mx-footer .cp {float:left; line-height:26px; }

/*Footer Navigation*/
#mx-footer-nav{float:right}
#mx-footer-nav ul{list-style-type:none;padding:0;margin:0 0 5px 0}
#mx-footer-nav li{background:none;padding:0;display:inline} 
#mx-footer-nav .nav > li > a:hover {background:none;}
#mx-footer-nav a{font-weight:normal;text-decoration:none;display:inline;margin:0;padding:0 8px;color:#838181}
a#pagetop{float:right; }
span.designed_by {display:block;}
/*logo*/
a#logo{background:url(../images/logo/logo.png) no-repeat}
/* clr */
.clr{clear:both;display:block;overflow:hidden;visibility:hidden;width:0;height:0}
/* template colors */
div.color-site{height:16px;line-height:16px; margin-top:6px; text-align: right;}
div.color-site a {padding: 1px 6px; height: 16px; 
box-shadow:0 0 3px rgba(0,0,0,0.5);
-moz-box-shadow:0 0 3px rgba(0,0,0,0.5);
-webkit-box-shadow:0 0 3px rgba(0,0,0,0.5);}
div.color-site a.btn_fs_blue{ background: #399cdd; color: #399cdd;}
div.color-site a.btn_fs_red{ background: #c30; color: #c30;}
div.color-site a.btn_fs_orange{ background: #f99d26; color: #f99d26;}
div.color-site a.btn_fs_green{ background: #99cc33; color: #99cc33;}
div.color-site a.btn_fs_brown{ background: #cc9966; color: #cc9966;}
div.color-site a.btn_fs_lilac{ background: #ad77bb; color: #ad77bb;}

/* Button, Input */

input, select, textarea, .inputbox, button, .button, input[type="button"], input[type="submit"] {
	padding: 3px;
}

input[type="button"], input[type="text"] {}

input[type="button"] { }

input[type="text"], input[type="password"], input[type="email"], textarea, .inputbox, .validate-username, .validate-password { 
	border: 0; background: #fff; color:#999; 
	-webkit-box-shadow: 0 0 0 1px #ccc inset; box-shadow: 0 0 0 1px #ccc inset;
	border-radius: 3px; -webkit-border-radius: 3px;
}

input[type="text"]#modlgn-username {width:70%;}

input[type="password"]#modlgn-passwd {width:70%;}

#ol-topsl .inputbox, #ol-botsl .inputbox, #ol-user-panel .inputbox {}

input[type="text"]:hover, input[type="password"]:hover, input[type="email"]:hover,
input[type="text"]:focus, input[type="password"]:focus, input[type="email"]:focus,
.inputbox:hover, .inputbox:focus,
 textarea:hover, textarea:focus { background: #ffffcc; color:#666; }


.browserChrome input[type="text"]:focus, .browserChrome input[type="password"]:focus, .browserChrome input[type="email"]:focus,
.browserSafari input[type="text"]:focus, .browserSafari input[type="password"]:focus, .browserSafari input[type="email"]:focus,
.browserChrome .inputbox:focus, .browserChrome  textarea:focus,
.browserSafari .inputbox:focus, .browserSafari textarea:focus {outline: none;}

/* buttons */
.button, button, input[type="button"], input[type="submit"] {
	line-height:24px;
	color: #888;
	text-transform: uppercase; 
	border:0; 
	font-size: 11px !important;
	cursor:pointer;
	zoom: 1;
	*display: inline;
	vertical-align: top;
	outline: none;
	text-align: center;
	text-decoration: none;
	padding: 4px 15px !important;
	text-shadow: 0 1px 1px rgba(0,0,0, 0.1);
	-webkit-border-radius: 0px; border-radius: 0px;
	-webkit-box-shadow: 0 0 0 1px #BBBBBB inset;	
	-ms-box-shadow: 0 0 0 1px #bbbbbb inset;	
	box-shadow: 0 0 0 1px #BBBBBB inset;
	background: #f6f6f6;
	background-image: -webkit-linear-gradient(top,  #fff, #fafafa);
	background-image: -moz-linear-gradient(top, #fff, #fafafa);
	background-image: -ms-linear-gradient(top, #fff, #fafafa);
	background-image: -o-linear-gradient(top, #fff, #fafafa);
}
.btn-primary {
	text-transform: uppercase;
  border-bottom-color: transparent;
    border-radius: 3px !important;
  -webkit-box-shadow: inset 0 -3px 0 rgba(0, 0, 0, 0.06);
  box-shadow: inset 0 -3px 0 rgba(0, 0, 0, 0.06);
  padding: 5px 20px !important; 
  background-repeat: repeat-x; 
}
.btn-primary:hover,
.btn-primary:focus {
  background-color: #444;
  background-position: 0 -45px;
  border-color: #444;
}
.btn-primary:active,
.btn-primary.active {
  background-color: #555;
  border-color: #555;
  -webkit-box-shadow: inset 0 3px 0 rgba(0, 0, 0, 0.12);
  box-shadow: inset 0 3px 0 rgba(0, 0, 0, 0.12);
}
