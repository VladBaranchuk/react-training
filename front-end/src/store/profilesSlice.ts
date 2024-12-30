import { Dispatch } from "react";
import { Profile } from "../api/profileController/Models";
import { getProfiles } from "../api/profileController/ProfileController";
import { RootState } from "./reducer";
import { DispatchAction } from "./localDispatcher";

export const fetchProfiles = (dispatch: Dispatch<DispatchAction>, getState: () => RootState) => {
    getProfiles()
    .then(data => {
        if (data !== null) {
            dispatch({type: "profiles/setProfiles", payload: data});
            console.log('Loaded: ', data);
        }
    })
}

const profilesReducer = (state: Profile[] = [], action: any): Profile[] => {
    if (typeof action !== 'object')
        return state;

    switch (action.type) {
        case "profiles/setProfiles":
            return action.payload;
        case "profiles/addProfile":
            return [...state, action.payload];
        default:
            return state;
    }
};

export default profilesReducer;