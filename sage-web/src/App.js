import React from 'react';
import './App.css';
import Header from './components/header/Header';
import Container from "@material-ui/core/Container";
import TableApp from "./components/table-app/TableApp";
import Button from "@material-ui/core/Button";

function App() {
  return (
    <div className="App">
      <Header title="Cadastro de Pessoas"/>
      <Container>
        <Button  variant="contained" className="primary">Adicionar</Button>
        <TableApp />
      </Container>
    </div>
  );
}

export default App;
