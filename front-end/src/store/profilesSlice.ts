import { Dispatch } from "react";
import { Profile } from "../api/profileController/Models";
import { getProfiles } from "../api/profileController/ProfileController";
import { DispatchAction } from "./localDispatcher";
import { ProfilesActions } from "./actionFabrics";

export const fetchProfiles = () => 
    async (dispatch: Dispatch<DispatchAction>) => {
        let profiles = await getProfiles();

        if (profiles !== null) {
            dispatch(ProfilesActions.setProfiles(profiles));
            console.log('Loaded: ', profiles);
        }
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