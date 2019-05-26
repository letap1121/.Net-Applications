//A few simple jQuery functions to liven up the UI
//This gets kicked off when the page is done loading in the browser
$(document).ready(function(){
	//we add a CSS class to the unordered lists list items to give them a + icon
	$("ul li").addClass("plusIcon");
	//for the ordered list items, we assign them a class to give them a circle icon
	$("ol li").addClass("circleIcon");
	//We hide all the ordered lists when the page loads.  hide is a jQuery function which just sets display:none on the item.
	$("ol").hide();
	// We add click even handler to the list times in the un ordered list and call a function
	$("ul li").click (function () {
		//toggle class switches an elements class between two states
		$(this).toggleClass("plusIcon minusIcon");
		//toggle switches from hide to not hidden
		$(this).children("ol").toggle();
		
	});
});
