const btn_add = document.querySelector('#add-btn-show');

function openButtons(modalId) {
  let modal = document.getElementById(modalId)

  if(modal) {
    modal.classList.add('b-on')
    
    modal.addEventListener('click', (event) => {
      if(event.target.id == modalId) {
        modal.classList.remove('b-on');
      }
    });
  }
}

btn_add.addEventListener('click', () => openButtons('btn-options'));
