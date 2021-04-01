        console.log("Skriptin suoritus alkaa");
        $("#lasketaan").click(function () {
        console.log("Nappia painettu");
        const luku1 = $("#number1").val();
        const luku2 = $("#number2").val();

        const c = parseInt(luku1) + parseInt(luku2);
        alert("Summa on : " + c);
    });