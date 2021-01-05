function AddPlayerToArray(trID,buttonID)
{
    var form = document.getElementById(trID);
    var playerInfo = form.getElementsByTagName("td");
    var foto = form.getElementsByClassName("Foto");
    var teamLogo = form.getElementsByClassName("homeTeamLogo");
    var zaidejas = {
        Name: playerInfo[1].innerText,
        Foto: foto[0].src,
        TeamLogo: teamLogo[0].src,
        Kaina: playerInfo[10].innerText
    };

    for (var i = 0; i < 5; i++)
    {
        var templateCheck = document.getElementsByClassName("playerTemplateRow")[i].getElementsByClassName("playerPickIMG")[0].src;

        if (templateCheck == 'https://www.nba.com/stats/media/img/no-headshot_small.png') {
            document.getElementById(buttonID).disabled = true;
            var foto = document.getElementsByClassName("playerPickIMG")[i].src = zaidejas.Foto;
            var teamLogo = document.getElementsByClassName("teamPickImg")[i].src = zaidejas.TeamLogo;
            var name = document.getElementsByClassName("playerPickName")[i].innerHTML = zaidejas.Name;
            var price = document.getElementsByClassName("playerPickPrice")[i].innerHTML = zaidejas.Kaina;
            document.getElementById("money").innerHTML = document.getElementById("money").innerHTML - price;

            break;
        }

    }
}