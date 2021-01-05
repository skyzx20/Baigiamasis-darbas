function countDown(GameStartTime, GameID, GameButtonDisable, indexHolder) {
    var countDownDate = new Date(GameStartTime).getTime();

    // Update the count down every 1 second 
    var x = setInterval(function () {

        // Get today's date and time
        var now = new Date().getTime();

        // Find the distance between now and the count down date
        var distance = countDownDate - now;

        // Time calculations for days, hours, minutes and seconds
        var days = Math.floor(distance / (1000 * 60 * 60 * 24));
        var hours = Math.floor((distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
        var minutes = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
        var seconds = Math.floor((distance % (1000 * 60)) / 1000);

        // Output the result in an element with id="demo"
        document.getElementById(GameID).innerHTML = days + "d " + hours + "h "
            + minutes + "m " + seconds + "s ";

        // If the count down is over, write some text 
        if (distance < 0) {
            clearInterval(x);
            var startText = document.getElementsByClassName("rungtyniuStartText");
            startText.hidden = true;
            var gameText = document.getElementById(GameID).innerHTML = "Rungtynės žaidžiamos";
            //if (gameText == "Rungtynės žaidžiamos")
           // {
               // console.log(indexHolder);
               //var x = document.getElementsByClassName("rungtyniuStartText")[indexHolder];
              // x.style.display = "none";
           // }
        }
    }, 1000);
}