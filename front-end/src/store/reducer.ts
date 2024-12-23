import { combineReducers } from 'redux'
import profileReducer from './profilesSlice'

const rootReducer = combineReducers({
    profiles: profileReducer
});

export default rootReducer;

export type RootState = ReturnType<typeof rootReducer>;

