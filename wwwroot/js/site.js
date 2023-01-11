// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const favoriteButton = document.getElementById("favorite-button");
const favoriteIndicator = document.getElementById("favorite-indicator");

favoriteButton.addEventListener("click", function() {
    if (localStorage.getItem("favorite")) {
        localStorage.removeItem("favorite");
        favoriteIndicator.innerHTML = "";
    } else {
        localStorage.setItem("favorite", true);
        favoriteIndicator.innerHTML = "Favorited";
    }
});

if (localStorage.getItem("favorite")) {
    favoriteIndicator.innerHTML = "Favorited";
}