document.addEventListener('DOMContentLoaded', function () {
    // Inputs y spans
    const nameInput = document.getElementById('NameInput');
    const displayInput = document.getElementById('DisplayInput');
    const nameError = document.getElementById('NameError');
    const displayError = document.getElementById('DisplayError');

    const existingNames = window.existingNames || [];
    const existingDisplays = window.existingDisplays || [];
    const indexUrl = window.indexUrl || '/Category/Index';

    // Validación dinámica
    if (nameInput && nameError) {
        nameInput.addEventListener('input', function () {
            if (existingNames.includes(nameInput.value.toLowerCase())) {
                nameError.textContent = `Ya existe una categoría con el nombre '${nameInput.value}'`;
            } else {
                nameError.textContent = '';
            }
        });
    }

    if (displayInput && displayError) {
        displayInput.addEventListener('input', function () {
            if (existingDisplays.includes(parseInt(displayInput.value))) {
                displayError.textContent = `Ya existe una categoría con el Orden de visualización '${displayInput.value}'`;
            } else {
                displayError.textContent = '';
            }
        });
    }

    // Modal de éxito
    const successModalEl = document.getElementById('successModal');
    if (successModalEl) {
        const successModal = new bootstrap.Modal(successModalEl);
        successModal.show();

        const closeButtons = successModalEl.querySelectorAll('.btn-close, #modalCloseBtn');
        closeButtons.forEach(btn => {
            btn.addEventListener('click', function () {
                window.location.href = indexUrl;
            });
        });
    }
});
