function RemovePlayerFromArray(index) {

    document.getElementById(document.getElementsByClassName("playerPickName")[index].innerHTML.replace(" ", "_")).disabled = false; 
    var price = document.getElementsByClassName("playerPickPrice")[index].innerText;
    document.getElementById("money").innerHTML = Number(document.getElementById("money").innerHTML) + Number(price);
    document.getElementsByClassName("playerPickIMG")[index].src = 'https://www.nba.com/stats/media/img/no-headshot_small.png';
    document.getElementsByClassName("teamPickImg")[index].src = 'https://www.nba.com/stats/media/img/no-headshot_small.png'
    document.getElementsByClassName("playerPickName")[index].innerHTML = "Vardas";
    document.getElementsByClassName("playerPickPrice")[index].innerHTML = "Kaina";
}