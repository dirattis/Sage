import { combineReducers } from "redux";
import addressReducer from '../components/address/address-reducer';
import personReducer from '../components/person/person-reducer';

export default combineReducers({
    addressReducer,
    personReducer
});