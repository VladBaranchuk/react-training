import { combineReducers } from 'redux'
import profilesReducer from './profilesSlice'
import profileReducer from './profileSlice';
import daysReducer from './daysSlice';

const rootReducer = combineReducers({
    profiles: profilesReducer,
    profile: profileReducer,
    days: daysReducer,
});

export default rootReducer;

export type RootState = ReturnType<typeof rootReducer>;

