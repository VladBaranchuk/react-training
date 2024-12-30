import { Profile } from "../api/profileController/Models";

let defaultState: Profile = {
    id: '',
    firstName: '',
    lastName: '',
    weight: 0,
    startDay: new Date(),
    days: []
}

const profileReducer = (state: Profile = defaultState, action: any): Profile => {
    if (typeof action !== 'object')
        return state;

    switch (action.type) {
        case "profile/setProfile":
            return action.payload;
        case "profile/unmountProfile":
            return defaultState;
        default:
            return state;
    }
};

export default profileReducer;