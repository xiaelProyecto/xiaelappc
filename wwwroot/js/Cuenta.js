﻿$(document).ready((e) => {
    $(".inputSaveDesc").hide();
    $("#CUAjustes").hide();
});
$("#guardarDescripcion").on('click', (e) => {
    var desc = $(".CUTextArea").val();
    $.ajax({
        url: "/Login/updateDesc",
        type: "PUT",
        data: { desc: desc },
        success: (e)=>{
            $(".inputSaveDesc").show();
        }
    });
});

$("#CUBtnNavGeneral").on('click', (e) => {
    $("#CUAfav").show();
    $("#CUMfav").show();
    $("#CUDescripcion").show();
    $("#CUUserContent").show();
    $("#guardarDescripcion").show();
    $("#CUAjustes").hide();
});

$("#CUBtnNavAjustes").on('click', (e) => {
    $("#CUAfav").hide();
    $("#CUMfav").hide();
    $("#CUDescripcion").hide();
    $("#CUUserContent").hide();
    $("#guardarDescripcion").hide();
    $("#CUAjustes").show();
});

$("#CUAJUser").on('click', (e) => {
    var value = $("#CUInputAjName").val();
    $.ajax({
        url: "/Login/updateNick",
        type:"PUT",
        data: { nick: value },
        success: (e) => {
            alert("Se ha cambiado el nombre de usuario correctamente");
        }
    });
})

$("#CUAJPass").on('click', (e) => {
    var value = $("#CUInputAjPass").val();
    $.ajax({
        url: "/Login/updatePassword",
        type: "PUT",
        data: { password: value },
        success: (e) => {
            alert("Se ha cambiado la contraseña del usuario correctamente");
        }
    });
})
$("#CUAAge").on('click', (e) => {
    var value = $("#CUInputAjAge").val();
    $.ajax({
        url: "/Login/updateAge",
        type: "PUT",
        data: { age: value },
        success: (e) => {
            alert("Se ha cambiado la edad del usuario correctamente");
        }
    });
})
$("#CUAJMail").on('click', (e) => {
    var value = $("#CUInputAjMail").val();
    $.ajax({
        url: "/Login/updateMail",
        type: "PUT",
        data: { mail: value },
        success: (e) => {
            alert("Se ha cambiado el mail del usuario correctamente");
        }
    });
})


//CUAfav
//CUMfav
//CUDescripcion
//CUUserContent


//CUAjustes