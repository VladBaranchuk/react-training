import { request, header, host } from "../Api";
import { Day } from "./Models";

export const getDay = (profileId: string, dayId: string) => 
    request<Day>(`${host}/api/profile/${profileId}/days/${dayId}`, header("GET"));

export const getDays = (profileId: string, page: number = 1, size: number = 10) =>
    request<Day[]>(`${host}/api/profile/${profileId}/days?page=${page}&size=${size}`, header("GET"));