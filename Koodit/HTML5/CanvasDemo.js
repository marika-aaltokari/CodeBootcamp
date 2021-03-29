 var c = document.getElementById("myCanvas");
        var ctx = c.getContext("2d");

// Create gradient
         var grd = ctx.createLinearGradient(0, 0, 200, 0);
         grd.addColorStop(0, "yellow");
         grd.addColorStop(1, "white");

// Fill a rectangle with gradient
        ctx.fillStyle = grd;
        ctx.fillRect(10, 10, 100, 80);

// draw a circle
        ctx.beginPath();
        ctx.arc(95, 50, 40, 0, 2 * Math.PI);
        ctx.stroke();