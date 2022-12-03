// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var sortBtn = document.querySelector('.filter-menu').children;
var sortItem = document.querySelectorAll('.row>div');
console.log(sortBtn, sortItem);
for (var i = 0; i < sortBtn.length; i++) {
    sortBtn[i].addEventListener('click', function () {
        // removing class current from all li items of ul class filter-menu
        for (var j = 0; j < sortBtn.length; j++) {
            //removing currect class from all buttons
            sortBtn[j].classList.remove('current');
        }
        console.log(this);
        //this is regering to sortBtn[i]
        this.classList.add('current');
        var targetData = this.getAttribute('data-target');//getting the data-target value
        // console.log(targetData);// data-target value will be displayed e.g. js
        for (var k = 0; k < sortItem.length; k++) {
            sortItem[k].classList.remove('active');
            sortItem[k].classList.add('delete');
            // console.log(sortItem[k].getAttribute('data-item')); 
            if (sortItem[k].getAttribute('data-item') == targetData || targetData == "Reset") {
                sortItem[k].classList.remove('delete');
                sortItem[k].classList.add('active');
            }
        }
    });
}

// Slider
$(".slider-one")
.not(".slick-initialized")
.slick({

    prevArrow:".site-slider.prev",
    nextArrow: ".site-slider.next",
    slidesToShow: 5,
    slidesToScroll: 1,
    autoplaySpeed: 3000
});








/*login */
// function login()
// 	{
// 		if (query != null) 
// 		{

// 			alert('Thank You for Login & You are Redirecting to Classy Furn Website');
// 			//Redirecting to other page or webste code or you can set your own html page.
// 				 window.location = "https://localhost:7288/";
// 					  }

		
// 		else{

// 			alert("please enter authenticated user id and password combination or kindly Register and login");



// 		}
// 		 var uname = document.getElementById("email_id").value;
// 		 var pwd = document.getElementById("password").value;
// 		 var filter = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;
// 		 if(uname =='')
// 		 {
// 		 	alert("please enter user name.");
// 		 }
// 		 else if(pwd=='')
// 		 {
//          	alert("enter the password");
// 		 }
// 		 else if(!filter.test(uname))
// 		 {
// 		 	alert("Enter valid email id.");
// 		 }
// 		 else if(pwd.length < 6 || pwd.length > 6)
// 		 {
// 		 	alert("Password min and max length is 6.");
// 		 }
	
// 		{
// // 	alert('Thank You for Login & You are Redirecting to Classy Furn Website');
// //   //Redirecting to other page or webste code or you can set your own html page.
// //        window.location = "https://localhost:7288/";
// 			}
	
// 	//Reset Inputfield code.
// 	function clearFunc()
// 	{
// 		document.getElementById("email").value="";
// 		document.getElementById("pwd1").value="";
// 	}	

// //Reset Inputfield code.
//  function clearFunc()
// {
// 	 	document.getElementById("email_id").value="";
// 	document.getElementById("password").value="";
//  } 	
// login2	

// $(document).ready(function(){
// 	$("#login").click(function(){
// 	var email_id = $("#email_id").val();
// 	var password = $("#password").val();
// 	// Checking for blank fields.
// 	if( email_id =='' || password ==''){
// 	$('input[type="text"],input[type="password"]').css("border","2px solid red");
// 	$('input[type="text"],input[type="password"]').css("box-shadow","0 0 3px red");
// 	alert("Please fill all fields...!!!!!!");
// 	}else {
// 	$.post("login.php",{ email_id: email_id, password:password},
// 	function(data) {
// 	if(data=='Invalid Email.......') {
// 	$('input[type="text"]').css({"border":"2px solid red","box-shadow":"0 0 3px red"});
// 	$('input[type="password"]').css({"border":"2px solid #00F5FF","box-shadow":"0 0 5px #00F5FF"});
// 	alert(data);
// 	}else if(data=='Email or Password is wrong...!!!!'){
// 	$('input[type="text"],input[type="password"]').css({"border":"2px solid red","box-shadow":"0 0 3px red"});
// 	alert(data);
// 	} else if(data=='Successfully Logged in...'){
// 	$("form")[0].reset();
// 	$('input[type="text"],input[type="password"]').css({"border":"2px solid #00F5FF","box-shadow":"0 0 5px #00F5FF"});
// 	alert(data);
// 	} else{
// 	alert(data);
// 	}
// 	});
// 	}
// 	});
// 	});


