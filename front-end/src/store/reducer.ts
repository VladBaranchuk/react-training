import { combineReducers } from 'redux'
import profilesReducer from './profilesSlice'
import profileReducer from './profileSlice';

const rootReducer = combineReducers({
    profiles: profilesReducer,
    profile: profileReducer
});

export default rootReducer;

export type RootState = ReturnType<typeof rootReducer>;

