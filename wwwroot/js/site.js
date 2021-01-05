$(function () {
    $("input[name=email]").on("invalid", function () {
        this.setCustomValidity("Neteisingas formatas");
    });
});