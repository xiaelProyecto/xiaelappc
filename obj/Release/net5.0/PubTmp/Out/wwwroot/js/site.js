$("#logoffNavBar").on('click', (e) => {
    $.ajax({
        url: "/Login/LogOff",
        success: (e) => {
            window.location = "/Home/Index"
        }
    });  
})