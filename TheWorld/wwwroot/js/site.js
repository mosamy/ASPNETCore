/*site.js*/

/*
The problem with Javascript is that all variables have a global scope
so a var like "el" can also be accessed by other js functions running in other files
to implement scoping, we need to use the scopes in functions

*/
(function () // but how do we call an anonymous function?
//simple we wrap it and make it self executing :)
{
	
	
	var el = $("#username"); 
	el.text("Mohamed Samy with JQuery"); 
	
	var main = $("#mainform");

	// so this is one way to select an element by using a selector on that element
	main.on("mouseenter", function () {mainform.style = "background-color: blue;"; }); // doesn't work
	
	//or you can select the element by the document object and add the lement id as a paramater
	$(document).on("mouseleave", "#mainform",function () {mainform.style = ""; } );
	
	//now we need to add event handlers to all menu items, will show you the menu items now
	//first we use a css selector to get the items in question
	
	var menus = $("ul.menu li a");// ul is the list, menu the class name, li the item, a the anchor
	//now to add the event
	menus.on("click", function(){
		alert($(this).text());// now when we click on the item we should get an alert with the test
		//done
              	
	});

	var $toggle = $("#toggle"); // here we select the button called toggle
        $toggle.on("click", function () {
            
           $("#sidebar, #mainform").toggleClass("hide-sidebar");

        });
	
	
	
	
} )(); 