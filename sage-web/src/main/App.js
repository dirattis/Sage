import React, { useState } from 'react';
import '../styles/App.css';
import Header from '../components/header';
import Container from "@material-ui/core/Container";
import TableApp from "../components/table-app/TableApp";
import Button from "@material-ui/core/Button";
import ModalApp from "../components/modal-app/ModalApp";

function App() {
  const [open, setOpen] = useState(false);

  function openModal(){
    setOpen(true);
  }

  function closeModal(){
    setOpen(false);
  }

  return (
    <div className="App">
      <Header title="Cadastro de Pessoas"/>
      <Container>
        <ModalApp open={open} close={closeModal}/>
        <Button  variant="contained" className="primary"  onClick={openModal} >Adicionar</Button>
        <TableApp />
      </Container>
    </div>
  );
}

export default App;
