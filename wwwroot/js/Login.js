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
})
