const fields = document.querySelectorAll("[required]");

function validateField(field) {
  // verificação de existencia de erros
  function verifyErrors() {
    let foundError = false;

    for (let error in field.validity) {

      if (field.validity[error] && !field.validity.valid) {
        foundError = error;
      }
    }

    return foundError;
  }

  function customMessage(typeError) {
    const messages = {
      email: {
        valueMissing: "Campo precisa ser preenchido",
        typeMismatch: "Preencha um e-mail válido",
      },
      password: {
        valueMissing: "Campo precisa ser preenchido",
      }
    }

    return messages[field.type][typeError];
  }


  function setCustomMessage(message) {
    const spanError = field.parentNode.querySelector("span.error");

    if (message) {
      spanError.classList.add("active");
      spanError.innerHTML = message;
    } else {
      spanError.classList.remove("active");
      spanError.innerHTML = "";
    }
  }; 

  return function() {
    const error = verifyErrors();
  
    if (error && error !== "valueMissing") {

      const message = customMessage(error);
      
      field.classList.add("inputError");
      setCustomMessage(message);
    } else if (error === "valueMissing") {
      const message = customMessage(error);

      field.classList.add("inputError");
      field.classList.remove("inputValid");
      setCustomMessage(message);
    } else {
      field.classList.remove("inputError");
      field.classList.add("inputValid");
      setCustomMessage();
    }
  };
};

function customValidation(event) {

  const field = event.target;
  const validation = validateField(field);

  validation();
}

const btnSubmit = document.querySelector('.btnLogin');

for (field of fields) {
  field.addEventListener("invalid", event => {
    // eliminar bubble
    event.preventDefault();

    customValidation(event);
  });

  btnSubmit.addEventListener("click", customValidation);
}

