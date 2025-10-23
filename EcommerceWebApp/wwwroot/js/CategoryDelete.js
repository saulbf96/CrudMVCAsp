// Espera a que la página esté lista
document.addEventListener("DOMContentLoaded", function () {
    const confirmBtn = document.getElementById("confirmDeleteBtn");

    if (confirmBtn) {
        confirmBtn.addEventListener("click", function () {
            // Envía el formulario cuando el usuario confirma
            const form = document.querySelector("form");
            if (form) form.submit();
        });
    }
});
