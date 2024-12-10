import { createStore } from "redux";
import { Profile } from "./api/profileController/Models";

interface State {
    profiles: Profile[] | undefined
}

export interface DispatchAction {
    type: string,
    payload?: any
}

let defaultState: State = {
    profiles: []
};

const counterReducer = (state: State = defaultState, action: DispatchAction): State => {
    switch (action.type) {
        case "action/setProfiles":
            return {
                ...state,
                profiles: action.payload
            };
        default:
            return state;
    }
};

export default createStore(counterReducer);

