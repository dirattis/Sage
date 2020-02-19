const initialState = {
    person: { 
        nome: 'Diego Rattis'
    }
}

export default (state = initialState, { type, payload }) => {
    switch (type) {

    case 'ADD_PERSON':
        return { ...state, ...payload }

    default:
        return state
    }
}
