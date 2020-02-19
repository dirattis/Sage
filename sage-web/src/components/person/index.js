import { connect } from 'react-redux';
import { bindActionCreators } from 'redux';
import { addPerson } from './person-action';
import PersonWeb from './person-view';

const mapStateToProps = state => ({ 
  person: state.personReducer.person
});

const mapDispatchToProps = dispatch => bindActionCreators({
    addPerson
}, dispatch);

export default connect(mapStateToProps, mapDispatchToProps)(PersonWeb);

