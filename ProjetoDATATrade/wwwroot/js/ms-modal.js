const avatar = document.querySelector('.avatar');

function msModal(modalId) {
  let modal = document.getElementById(modalId);

  if (modal) {
    modal.classList.add('on');
    modal.addEventListener('click', (event) => {
      
      if(event.target.id == modalId || event.target.id == 'close') {
        modal.classList.remove('on');
      }  
    })
  }
};

avatar.addEventListener('click', () => msModal('modalInitial'));

