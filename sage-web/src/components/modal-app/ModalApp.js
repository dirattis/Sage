import React, { useState } from 'react';
import Button from '@material-ui/core/Button';
import Dialog from '@material-ui/core/Dialog';
import DialogActions from '@material-ui/core/DialogActions';
import DialogContent from '@material-ui/core/DialogContent';
import DialogTitle from '@material-ui/core/DialogTitle';
import Slide from "@material-ui/core/Slide";
import Person from "../person";
import Address from "../address";

const Transition = React.forwardRef(function Transition(props, ref) {
  return <Slide direction="right" ref={ref} {...props} />;
});

export default function ModalApp(props) {

  const [viewPersonComponent, setViewPersonComponent] = useState(true);
  function next(){
    setViewPersonComponent(!viewPersonComponent);
  }

  return (
    <div>    
    <Dialog open={props.open} onClose={props.close} aria-labelledby="form-dialog-title"
     TransitionComponent={Transition}
     keepMounted>
        <DialogTitle id="form-dialog-title">Nova Pessoa</DialogTitle>
        <DialogContent>
          {viewPersonComponent && <Person />}
          {!viewPersonComponent && <Address />}
        </DialogContent>
        <DialogActions>
          <Button onClick={props.close} color="primary">
            Cancel
          </Button>
          <Button onClick={next} color="primary">
            Continue
          </Button>
        </DialogActions>
      </Dialog>
    </div>
  );
}
