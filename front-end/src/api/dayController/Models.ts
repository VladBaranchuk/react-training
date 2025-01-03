export type Day = {
    id: string,
    morningWeight: number,
    startSleep: Date,
    finishSleep: Date,
    fatigue: string,
    sleepy: string,
    mood: string,
    doDrink: boolean,
    doSmoke: boolean,
    doMorningExamples: boolean
    date: Date,
    activities: Activity[],
    dishes: Dish[]
}

export type Activity = {
    id: string,
    name: string,
    consumption: number
}

export type Dish = {
    id: string,
    name: string,
    protein: number,
    fat: number,
    carbohydrate: number,
    weight: number
}