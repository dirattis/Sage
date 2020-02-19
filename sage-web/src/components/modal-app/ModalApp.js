import React, { useState } from 'react';
import Button from '@material-ui/core/Button';
import Dialog from '@material-ui/core/Dialog';
import DialogActions from '@material-ui/core/DialogActions';
import DialogContent from '@material-ui/core/DialogContent';
import DialogTitle from '@material-ui/core/DialogTitle';
import Slide from "@material-ui/core/Slide";
import Fade from '@material-ui/core/Fade';
import Paper from '@material-ui/core/Paper';
import Person from "../person";
import Address from "../address";

const Transition = React.forwardRef(function Transition(props, ref) {
  return <Slide direction="right" ref={ref} {...props} />;
});

export default function ModalApp(props) {

  const [viewPersonComponent, setViewPersonComponent] = useState(true);
  const [title, setTitle] = useState('Pessoa');
  const timeoutTransition = 500;

  function configNavigationParams() {
    setViewPersonComponent(!viewPersonComponent);
    setTitle(!viewPersonComponent ? 'Pessoa' : 'Endereço');
  }

  function save(){

  }

  return (
    <div>
      <Dialog open={props.open} onClose={props.close} aria-labelledby="form-dialog-title"
        TransitionComponent={Transition}
        keepMounted>
        <DialogTitle id="form-dialog-title">{title}</DialogTitle>
        <DialogContent>
          {viewPersonComponent &&
            <Fade in={viewPersonComponent} timeout={timeoutTransition}>
              <Person />
            </Fade>
          }
          {!viewPersonComponent &&
            <Fade in={!viewPersonComponent} timeout={timeoutTransition}>
              <Address />
            </Fade>
          }
        </DialogContent>
        <DialogActions>
          {viewPersonComponent && <div>
            <Button onClick={props.close} color="primary">
              Cancelar
            </Button>
            <Button onClick={configNavigationParams} color="primary">
              Continue
            </Button>
          </div>
          }
          {!viewPersonComponent && <div>
            <Button onClick={configNavigationParams} color="primary">
              Voltar
          </Button>
            <Button onClick={save} color="primary">
              Salvar
          </Button>
          </div>
          }
        </DialogActions>
      </Dialog>
    </div>
  );
}
