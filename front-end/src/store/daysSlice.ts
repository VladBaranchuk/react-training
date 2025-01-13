import { Day } from "../api/dayController/Models";

let defaultState: Day = {
    id: '',
    morningWeight: 0,
    startSleep: new Date(),
    finishSleep: new Date(),
    fatigue: '',
    sleepy: '',
    mood: '',
    doDrink: false,
    doSmoke: false,
    doMorningExamples: false,
    date: new Date(),
    activities: [],
    dishes: []
}

export const domain = "days";

const daysReducer = (state: Day[] = [], action: any): Day[] => {
    if (typeof action !== 'object')
        return state;

    switch (action.type) {
        case `${domain}/setDays`:
            return action.payload;
        case `${domain}/clear`:
            return [];
        default:
            return state;
    }
};

export default daysReducer;