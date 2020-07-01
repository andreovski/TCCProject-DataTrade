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
    const defaultMessage = "Campo obrigatório";
    
    const messages = {
      text: {
        valueMissing: defaultMessage,
      },
      email: {
        valueMissing: defaultMessage,
        typeMismatch: "Preencha um e-mail válido",
      },
      password: {
        valueMissing: defaultMessage,
        tooShort: "Sua senha deve ter no mínimo 6 caracteres",

      },
      checkbox: {
        valueMissing: "Confirme o termo de uso.",
      }
    };

    return messages[field.type][typeError];
  }


  function setCustomMessage(message) {
    const spanError = field.parentNode.querySelector("span.error")

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

    if (error) {
      const message = customMessage(error);
      
      field.classList.add("inputError");
      setCustomMessage(message);
    } else {
      const passwordInput = document.querySelector('#password');

      if (field === passwordInput ) {
        passwordValidation(passwordInput, passwordInput.value);

        return;
      }

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

function passwordValidation(input, value) {
  const spanError = input.parentNode.querySelector("span.error")

  let regex = /^(?=.*[a-zA-Z])(?=.*[0-9])(?=.*[!@#$%*()_+^&}{:;?.])(?:([0-9a-zA-Z!@#$%;*(){}_+^&])(?!\1)){6,}$/;

  if (!regex.test(value)) {
    console.log(value, '= inválida');

    input.classList.add("inputError");

    spanError.classList.add("active");
    spanError.innerHTML = 
      "<ul><b>A senha precisa conter ao menos:</b>" + 
      "<li>Um caracter maiusculo</li>" +
      "<li>Um caracter especial</li>" +
      "<li>Um número</li>" +
      "</ul>";

    return;
  } else {
    console.log(value, '= Válida');

    input.classList.remove("inputError");
    input.classList.add("inputValid");

    spanError.classList.add("active");
    spanError.innerHTML = "";

    return;
  }
};


for (field of fields) {
  field.addEventListener("invalid", event => {
    // eliminar bubble
    event.preventDefault();

    customValidation(event);
  });

  field.addEventListener("blur", customValidation);
}