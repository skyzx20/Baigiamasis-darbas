﻿function removeNotStartedGames() {
    var length = document.getElementsByClassName("rungtynes").length;
    var i;
    for (i = length / 2; i < length; i++) {
        var x = document.getElementsByClassName("rungtynes")[i];
        var xx = x.getElementsByClassName("row")[0];
        var xxx = xx.getElementsByClassName("match")[0];
        var xxxx = xxx.getElementsByClassName("matchDate")[0];
        var xxxxx = xxx.getElementsByTagName("p")[1].innerText;

    }
}
