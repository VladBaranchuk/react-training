import { domain as Days } from "./daysSlice";
import { domain as Profile } from "./profileSlice";
import { domain as Profiles } from "./profilesSlice";

export class ProfileActions {
    static setProfile = (data: any) => ({type: `${Profile}/setProfile`, payload: data});
    static unmountProfile = () => ({type: `${Profile}/clear`});
}

export class ProfilesActions {
    static setProfiles = (data: any) => ({type: `${Profiles}/setProfiles`, payload: data});
    static addProfile = (data: any) =>  ({type: `${Profiles}/addProfile`, payload: data});
}

export class DaysActions {
    static setDays = (data: any) => ({type: `${Days}/setDays`, payload: data});
    static unmountDays = () => ({type: `${Days}/clear`});
}