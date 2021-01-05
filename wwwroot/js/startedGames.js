function removeFinnishedGames() {
    var length = document.getElementsByClassName("rungtynes").length;
    var i;
    for (i = 0; i < length / 2; i++) {
        var x = document.getElementsByClassName("rungtynes")[i];
        var xx = x.getElementsByClassName("row")[0];
        var xxx = xx.getElementsByClassName("match")[0];
        var xxxx = xxx.getElementsByClassName("matchDate")[0];
        var xxxxx = xxx.getElementsByTagName("p")[1].innerText;
        if (xxxxx == "Rungtynės žaidžiamos") {
            x.style.display = "none";
        }
    }
}
