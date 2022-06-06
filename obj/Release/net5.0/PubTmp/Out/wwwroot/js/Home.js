$(document).ready((e) => {
    generateCalendar();
});
$("#hsboton").on('click', (e) => {
    const ID = "6272c98f960692748a582e9c";
    window.location.replace(window.location.href + "Movie/FichaPelicula/" + ID);
});
function generateCalendar() {
    $("#mCalendar").fullCalendar('destroy');
    $("#mCalendar").fullCalendar({
        header: {
            left: 'title',
            center: '',
            right: 'prev,next today'
        },
        firstDay: 1,
        events: function (start, end, timezone, callback) {
            $.ajax({
                url: '/Home/GetEvents',
                type: "GET",
                success: function (result) {
                    var events = [];
                  
                    $.each(result, function (i, data) {
                        console.log(data);
                        events.push(
                            {
                                title: data.title,
                                start: data.start,
                                end :data.end 
                            });
                    });
                    callback(events);
                }
            });
        },
    });
    $("#mCalendar").fullCalendar('render');
}


