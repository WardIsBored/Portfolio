const User1="QWRtaW4=";
const Pass1="UDNudDQh";
const User=                                                                                                                                                                                                                                                                                                                                                                                                                                             atob(User1);
const Pass=                                                                                                                                                                                                                                                                                                                                                                                                                                             atob(Pass1);


function validate(){
    var username=document.getElementById("username").value;
    var password=document.getElementById("password").value;
    if(username==User && password==Pass){
        alert("Login Successful");
        window.location.href="secro.html";
        return false;
    }
    else{
        alert("Login Failed");
        window.location.href="https://www.google.com";
        return false;
    }
}