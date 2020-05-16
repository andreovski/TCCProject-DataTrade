const btnAddData = document.getElementById('btn-add-data');
const btns_modal = document.getElementById('btn-options'); // btns 'adc data' e 'adc estrategia';

function dataModal(modalId) {
  let modal = document.getElementById(modalId);

  if (modal) {
    modal.classList.add('on');

    btns_modal.classList.remove('b-on');

    modal.addEventListener('click', (event) => {
      if(event.target.id == modalId || event.target.id == 'close') {
        modal.classList.remove('on');
      }
    })
  }
};

btnAddData.addEventListener('click', () => dataModal('md-modal'));
