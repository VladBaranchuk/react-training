import { Dispatch } from "react";
import { Profile } from "../api/profileController/Models";
import { getProfiles } from "../api/profileController/ProfileController";
import { RootState } from "./reducer";

export interface DispatchAction {
    type: string,
    payload?: any
}

export const fetchProfiles = (dispatch: Dispatch<DispatchAction>, getState: () => RootState) => {
    getProfiles().then(data => {
        dispatch({type: "action/setProfiles", payload: data});
        
        console.log('Loaded: ', data);
    })
}

const profileReducer = (state: Profile[] = [], action: any): Profile[] => {
    if (typeof action !== 'object')
        return state;

    switch (action.type) {
        case "action/setProfiles":
            return action.payload;
        default:
            return state;
    }
};

export default profileReducer;