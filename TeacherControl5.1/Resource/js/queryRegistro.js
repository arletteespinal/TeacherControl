// JavaScript Document
$(document).ready(function(){
   	$(".formEstudiante").hide();
  	$(".formProfesor").hide();
	$(".btn-siguiente").click(function(){
		var x = document.getElementById("combo").selectedIndex;
			if(x==0){
				$(".form1").slideUp('slow', function(){});
				$(".formProfesor").slideDown('slow', function(){});
				
			}else
			if(x==1){
				$(".form1").slideUp('slow', function(){});
				$(".formEstudiante").slideDown('slow', function(){});
			}
	});
	$(".btn-Atras-Est").click(function(){
		$(".formEstudiante").slideUp('slow', function(){});
		$(".form1").slideDown('slow', function(){});
	});
	$(".btn-Atras-Profe").click(function(){
		$(".formProfesor").slideUp('slow', function(){});
		$(".form1").slideDown('slow', function(){});
	});
	
		
	
		
});
 //div.animate({height: '300px', width:'300',opacity: '0.4'}, "slow");