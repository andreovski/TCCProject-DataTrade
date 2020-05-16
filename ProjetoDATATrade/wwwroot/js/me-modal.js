const btnAddEstrategia = document.getElementById('btn-add-estrategia');

function meModal(modalId) {
  let modal = document.getElementById(modalId);
  
  if (modal) {
    modal.classList.add('on');
    btns_modal.classList.remove('b-on')

    modal.addEventListener('click', (event) => {
      if(event.target.id == modalId || event.target.id == 'close') {
        modal.classList.remove('on');
      }
    })
  }
}

btnAddEstrategia.addEventListener('click', () => meModal('me-modal'));