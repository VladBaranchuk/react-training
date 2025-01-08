export class ProfileActions {
    static setProfile = (data: any) => ({type: "profile/setProfile", payload: data});
    static unmountProfile = () => ({type: "profile/unmountProfile"});
}

export class ProfilesActions {
    static setProfiles = (data: any) => ({type: "profiles/setProfiles", payload: data});
    static addProfile = (data: any) =>  ({type: "profiles/addProfile", payload: data});
}