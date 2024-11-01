// script.js

// Abrir o modal
var modal = document.getElementById("modal");
var openModalBtn = document.getElementById("openModal");
var closeModalBtn = document.getElementById("closeModal");

openModalBtn.onclick = function() {
    modal.style.display = "block";
}

closeModalBtn.onclick = function() {
    modal.style.display = "none";
}

// Fechar o modal clicando fora dele
window.onclick = function(event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
}
