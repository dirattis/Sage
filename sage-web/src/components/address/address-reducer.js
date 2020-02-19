const initialState = {
    address: {}
}

export default (state = initialState, { type, payload }) => {
    switch (type) {

    case 'ADD_ADDRESS':
        return { ...state, ...payload }

    default:
        return state
    }
}
