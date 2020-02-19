import React from "react";
import TextField from "@material-ui/core/TextField";

const Address = () => {

    return (
      <>
        <TextField
            autoFocus
            margin="dense"
            label="CEP"
            type="text"
            fullWidth
          />
           <TextField
            margin="dense"
            label="Logradouro"
            type="text"
            fullWidth
          />

          <TextField            
            margin="dense"
            label="Número"
            type="text"
            fullWidth
          />
           <TextField
            
            margin="dense"
            label="Complemento"
            type="text"
            fullWidth
          />
           <TextField
            
            margin="dense"
            label="Bairro"
            type="text"
            fullWidth
          />
          <TextField
            
            margin="dense"
            label="Cidade"
            type="text"
            fullWidth
          />
          <TextField
            
            margin="dense"
            label="Estado"
            type="text"
            fullWidth
          />
        </>
    )
}

export default Address;