function passwordTransform() {
    var x = document.getElementById("password");
    var y = document.getElementById("passwordV");
    if (x.type === "password") {
        x.type = "text";
        y.type = "text";
    }
    else {
        x.type = "password";
        y.type = "password";
    }
}

    
 function Check_username(username) {
     var reg = /^[^#$%&|(){}\[\]\-=+/.\\,^~]{5,20}$/g;
     if (!reg.test(username)) {
         return false;
     }
     else
         return true;
 }
 function Check_password(pass) {
     var reg = /^(?=.*[0-9]+.*)(?=.*[a-zA-Z]+.*)[0-9a-zA-Z]{5,12}$/g;
     if (!reg.test(pass)) {
         return false;
     }
     else
         return true;
 }
 function Check_email(email) {
     var reg = /(([^<>()[\]\.,;:\s@\"]+(\.[^<>()[\]\.,;:\s@\"]+)*)|(\".+\"))@(([^<>()[\]\.,;:\s@\"]+\.)+[^<>()[\]\.,;:\s@\"]{2,})$/g;
     if (!reg.test(email)) {
         return false
     }
     else
         return true;
 }
 function Check_phone(phone) {
     var reg = /^0(2|3|4|8|9|5(0|1|2|3|4|6|8|9)|(77)\d{7})|(559\d{6})|(55((2[2-7])|(3[2-3])|(44)|(5[0-1])|(55)|(6[6-8])|(7[0-2])|(8[7-9])|(89\d))\d{5})|(7(2(2|3))|(3(2|3|7))|(6(5|8))|(9(2|3|[5-9])\d{6}))[a-z]{0}$/g;
     //בדיקה המבוססת על הטלפונים השונים בישראל על פי ויקיפדיה
     if (!reg.test(phone)) {
         return false;
     }
     else
         return true;
 }
 function inputusername() {
     if (!Check_username(document.getElementById("username").value))
         document.getElementById("UsernameP").innerHTML = "*please do not contain this symbols in your username or name: '/ # , $ % ^ ~ & () -+=.\ |[]{}'. \nand make sure the length of them is between 6 to 12 characters*";
     else
         document.getElementById("UsernameP").innerHTML = "";
 }
 function inputEmail() {
     if (!Check_email(document.getElementById("email").value))
         document.getElementById("EmailP").innerHTML = "*please make sure your email is in a correct format*";
     else
         document.getElementById("EmailP").innerHTML = "";
 }
 function inputPhone() {
     if (!Check_phone(document.getElementById("phone").value)) {
         document.getElementById("phone").style.borderColor = "red";
         document.getElementById("PhoneP").innerHTML = "*make sure you wrote the phone number in it's local format. do not use any special symbols or letters*";
     }
     else
         document.getElementById("PhoneP").innerHTML = "";
 }
 function inputpassword() {
     if (!Check_password(document.getElementById("password").value))
         document.getElementById("PassP").innerHTML = "*make sure the password contains at least one upper letter, one lower letter, a symbol and a number. \nthe password needs to be from 6 to 12 characters long*";
     else
         document.getElementById("PassP").innerHTML = "";
}
function PasswordV() {
    if (document.getElementById("password").value == document.getElementById("passwordV").value) { return true; }
    else {
        document.getElementById("PassVP").innerHTML ="*the passwords don't match*";
        return false;
    }
}

var loadFile = function (event) {
    var image = document.getElementById("output");
    image.src = URL.createObjectURL(event.target.files[0]);
};
