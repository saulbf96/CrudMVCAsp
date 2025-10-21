document.addEventListener('DOMContentLoaded', function () { //esto hace que se ejecute despues que todo el html este cargado
    // Inputs y spans
    //seleccion de los elementos del DOM 
    const nameInput = document.getElementById('NameInput');//campos de texto donde el usuario escribe el campo de categorria
    const displayInput = document.getElementById('DisplayInput');//campo del numero de display 
    const nameError = document.getElementById('NameError');//spans div donde se muestra los erorres 
    const displayError = document.getElementById('DisplayError');//spans o divs ......

    //obtener datos globales desde window

    const existingNames = window.existingNames || [];//lista de nombres ya existentes cargadas desde el razor o controlador 
    const existingDisplays = window.existingDisplays || [];//lista de display que ya existen 
    const indexUrl = window.indexUrl || '/Category/Index'; //url donde se dirigi cuando el modal sea un exito
    //|| [] o || '/Category/Index' asegura que si no existen estas variables, se usen valores por defecto.

    // Validación dinámica
    if (nameInput && nameError) { //esto se ejecuta si existe error 
        nameInput.addEventListener('input', function () {// escucha cada vez que el usuario escriba o borre ...
            if (existingNames.includes(nameInput.value.toLowerCase())) {//si el valor de existingNames ya existe muestra el mensaje de error 
                nameError.textContent = `Ya existe una categoría con el nombre '${nameInput.value}'`;
            } else {
                nameError.textContent = '';// si no existe borra el mensaje 
            }
        });
    }
    //funcion que valida el nombre 
    if (displayInput && displayError) {
        displayInput.addEventListener('input', function () {
            if (existingDisplays.includes(parseInt(displayInput.value))) {//convertimos el valor input a int 
                displayError.textContent = `Ya existe una categoría con el Orden de visualización '${displayInput.value}'`;
            } else {
                displayError.textContent = '';
            }
        });
    }   

    // Modal de éxito, busca el modal success que esta en create chtml de category 
    const successModalEl = document.getElementById('successModal');
    if (successModalEl) {
        const successModal = new bootstrap.Modal(successModalEl);
        successModal.show();//si existe lo inicializa como un modal de bootstrap
        
        // selecionamos los botonones de cerrar  la x o aceptar 
        const closeButtons = successModalEl.querySelectorAll('.btn-close, #modalCloseBtn');
        closeButtons.forEach(btn => {
            btn.addEventListener('click', function () {
                window.location.href = indexUrl;
            });
        });
    }

 
    

});
