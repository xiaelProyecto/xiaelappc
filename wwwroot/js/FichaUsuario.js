var id = $("#FUId").val();
$(".FUBNick").on('click', (e) => {
    var value = $(".FUIUser").val();
    $.ajax({
        url: "/Admin/updateNick",
        type: "PUT",
        data: {
            id: id,
            nick: value
        },
        success: (e) => {
            alert("Se ha cambiado el nombre de usuario correctamente");
            location.reload();
        }
    });
})

$(".FUBpass").on('click', (e) => {
    var value = $(".FUIPass").val();
    $.ajax({
        url: "/Admin/updatePassword",
        type: "PUT",
        data: {
            id: id,
            password: value
        },
        success: (e) => {
            alert("Se ha cambiado la contraseña del usuario correctamente");
            location.reload();
        }
    });
})
$(".FUBAge").on('click', (e) => {
    var value = $(".FUIAge").val();
    $.ajax({
        url: "/Admin/updateAge",
        type: "PUT",
        data: {
            id: id,
            age: value
        },
        success: (e) => {
            alert("Se ha cambiado la edad del usuario correctamente");
            location.reload();
        }
    });
})
$(".FUBMail").on('click', (e) => {
    var value = $(".FUIMail").val();
    $.ajax({
        url: "/Admin/updateMail",
        type: "PUT",
        data: {
            id: id,
            mail: value
        },
        success: (e) => {
            alert("Se ha cambiado el mail del usuario correctamente");
            location.reload();
        }
    });
})