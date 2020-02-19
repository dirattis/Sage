import React from "react";
import TextField from "@material-ui/core/TextField";

const Person = () => {

    return (
      <>
        <TextField
            autoFocus
            margin="dense"
            label="Nome"
            type="text"
            fullWidth
          />
           <TextField
            margin="dense"
            label="CPF"
            type="text"
            fullWidth
          />
           <TextField
            margin="dense"
            label="Data de Nascimento"
            type="date"
            fullWidth
          />
          <TextField
            
            margin="dense"
            label="Telefone Residencial"
            type="phone"
            fullWidth
          />
           <TextField
            
            margin="dense"
            label="Telefone Celular"
            type="phone"
            fullWidth
          />
           <TextField
            
            margin="dense"
            label="E-mail"
            type="email"
            fullWidth
          />
        </>
    )
}

export default Person;