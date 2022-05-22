$(document).ready((e) => {
    $(".inputSaveDesc").hide();
    $("#CUAjustes").hide();
    $("#CUAadmin").hide();
    $("#CUAvatar").show();
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
    $("#CUAvatar").show();
    $("#CUDescripcion").show();
    $("#CUUserContent").show();
    $("#guardarDescripcion").show();
    $(".inputSaveDesc").hide();
    $("#CUAadmin").hide();
    $("#CUAjustes").hide();
});

$("#CUBtnNavAjustes").on('click', (e) => {
    $("#CUAfav").hide();
    $("#CUMfav").hide();
    $("#CUAvatar").show();
    $("#CUDescripcion").hide();
    $("#CUUserContent").hide();
    $(".inputSaveDesc").hide();
    $("#CUAadmin").hide();
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
            $.ajax({
                url: "/Login/LogOff",
                success: (e) => {
                    alert("Se ha cambiado un elemento clave se ha procedido a cerrar la sesión")
                    window.location = "/Home/Index"
                }
            });            
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
            $.ajax({
                url: "/Login/LogOff",
                success: (e) => {
                    alert("Se ha cambiado un elemento clave se ha procedido a cerrar la sesión")
                    window.location = "/Home/Index"
                }
            });
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
$("#CUBtnNavAdmin").on('click', (e) => {
    $("#CUAfav").hide();
    $("#CUMfav").hide();
    $("#CUDescripcion").hide();
    $("#CUUserContent").hide();
    $("#CUAvatar").hide();
    $(".inputSaveDesc").hide();
    $("#guardarDescripcion").hide();
    $("#CUAjustes").hide();
    $.ajax({
        url: "/Admin/AdminPanel",
        type: "GET",
        success: (partialViewResult) => {
            $("#CUAadmin").show();
            $("#CUAadmin").html(partialViewResult);
        },
    });
});
