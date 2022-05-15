$(document).ready(() => {
    const imagenes = [];
    var indiceImagenes = 0;
    const tiempo = 6000
    imagenes[0] = "https://i.ibb.co/Hp3cMfv/thebatman.jpg";
    imagenes[1] = "https://i.ibb.co/5B6W5Y0/4.png";
    imagenes[2] = "https://i.ibb.co/qD3nwtY/thenorhman.jpg";
    imagenes[3] = "https://i.ibb.co/h9mjBJm/3.jpg";
    function cambiarImagenes() {
        $("#slider").attr("src", imagenes[indiceImagenes]);
        if (indiceImagenes < 2) {
            indiceImagenes++;
        } else {
            indiceImagenes = 0;
        }
    }
    setInterval(cambiarImagenes, tiempo)
});


