<?php
/*---------------------------------------------------------------
# Package - Sboost Framework  
# ---------------------------------------------------------------
# Author - mixwebtemplates http://www.mixwebtemplates.com
# Copyright (C) 2008 - 2015 mixwebtemplates.com. All Rights Reserved. 
# Websites: http://www.mixwebtemplates.com
-----------------------------------------------------------------*/
//no direct accees
defined ('_JEXEC') or die ('resticted aceess');

if ($this->getParam('showcp')) {
//echo JText::_('JU') . ' &copy; ' . $this->getParam('copyright'); 
echo 'Viajemos Pues <br>Todos los derechos reservados &copy 2015 ';
}
echo '<span class="designed_by">Diseñado por <a target="_blank" title="innovasistemas.co" href="http://www.innovasistemas.co">innovasistemas.co</a><br /></span>';
