var loginTemplate = $("#login")
var registroTemplate = $("#registro")
var btnLoginDisplay = $("#blg")
var btnSingUpDisplay = $("#brg")
$(document).ready((e) => {
    loginTemplate.hide();
});
btnLoginDisplay.on('click', (e) => {
    registroTemplate.hide();
    loginTemplate.show();
})
btnSingUpDisplay.on('click', (e) => {
    loginTemplate.hide();
    registroTemplate.show();
});
$("#formLoginAccess").on('submit', (e) => {
    e.preventDefault();
    var user = $("#userLogin").val();
    var pass = $("#UserLoginPass").val();
    $.ajax({
        url: "/Login/LoginAccess",
        type:"GET",
        data: {
            username: user,
            password: pass
        }, success: (e) => {
           
            window.location ="/Home/Index"
        }, error: (e) => {
            alert(e);
        }
    });
})
