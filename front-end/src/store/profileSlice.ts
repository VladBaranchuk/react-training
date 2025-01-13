import { Profile } from "../api/profileController/Models";

let defaultState: Profile = {
    id: '',
    firstName: '',
    lastName: '',
    weight: 0,
    startDay: new Date(),
    days: []
}

export const domain = "profile";

const profileReducer = (state: Profile = defaultState, action: any): Profile => {
    if (typeof action !== 'object')
        return state;

    switch (action.type) {
        case `${domain}/setProfile`:
            return action.payload;
        case `${domain}/clear`:
            return defaultState;
        default:
            return state;
    }
};

export default profileReducer;