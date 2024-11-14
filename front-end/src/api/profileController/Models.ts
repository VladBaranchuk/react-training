import { Day } from "../dayController/Models"

export type CreateProfile = {
    firstName: string,
    lastName: string,
    weight: number
}

export type Profile = {
    id: string,
    firstName: string,
    lastName: string,
    weight: number,
    startDay: Date,
    days: Day[]
}