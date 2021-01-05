function ConfirmPicks(ID, userId, token) {

    var firstPick = document.getElementsByClassName("playerPickIMG")[0].src; //playeriu url
    var secondPick = document.getElementsByClassName("playerPickIMG")[1].src;
    var thirdPick = document.getElementsByClassName("playerPickIMG")[2].src;
    var forthPick = document.getElementsByClassName("playerPickIMG")[3].src;
    var fifthPick = document.getElementsByClassName("playerPickIMG")[4].src;

    var playerName = document.getElementsByClassName("playerPickName")[0].innerHTML; //playeriu name is pick listo
    var playerName2 = document.getElementsByClassName("playerPickName")[1].innerHTML;
    var playerName3 = document.getElementsByClassName("playerPickName")[2].innerHTML;
    var playerName4 = document.getElementsByClassName("playerPickName")[3].innerHTML;
    var playerName5 = document.getElementsByClassName("playerPickName")[4].innerHTML;

    var money = document.getElementById("money").innerHTML;

    if (money < 0) {
        alert("Negalima išleisti daugiau pinigų negu turima");
    }

    else if (firstPick == 'https://www.nba.com/stats/media/img/no-headshot_small.png' ||
        secondPick == 'https://www.nba.com/stats/media/img/no-headshot_small.png' ||
        thirdPick == 'https://www.nba.com/stats/media/img/no-headshot_small.png' ||
        forthPick == 'https://www.nba.com/stats/media/img/no-headshot_small.png' ||
        fifthPick == 'https://www.nba.com/stats/media/img/no-headshot_small.png')
    {
       
    }
    else {
        $.ajax({
            url: `https://localhost:5001/MatchPage/${ID}?handler=AddingUserPicks`,
            headers: { "RequestVerificationToken": token },
            type: 'POST',
            data: {
                userId: userId,
                firstPlayerPick: playerName,
                secondPlayerPick: playerName2,
                thirdPlayerPick: playerName3,
                forthPlayerPick: playerName4,
                fifthPlayerPick: playerName5,
                leftMoney: money
            },
            success: function (result) {
                document.getElementById("Error").innerText = result;
            },
            statusCode: {
                400: function (response) {
                    document.getElementById("Error").innerText = response.responseText;
                }
            }
        });
        alert("Sėkmingai užsiregistravote rungtynėse");
    }
}
