import { request, header, host } from "../Api";
import { Profile, CreateProfile } from "./Models";

export const createProfile = (newProfile: CreateProfile) => 
    request(`${host}/api/profiles`, header("POST", JSON.stringify(newProfile)));

export const getProfile = (profileId: string) => 
    request<Profile>(`${host}/api/profiles/${profileId}`, header("GET"));

export const getProfiles = (page: number = 1, size: number = 10) =>
    request<Profile[]>(`${host}/api/profiles?page=${page}&size=${size}`, header("GET"));
