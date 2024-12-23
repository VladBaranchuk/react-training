import { Dispatch, Middleware } from "redux";
import { DispatchAction } from "../store/profilesSlice";
import { RootState } from "../store/reducer";

export const useThunk: Middleware<Dispatch<DispatchAction>, RootState> = store => next => action => {
    if (typeof action === 'function') {
        return action(store.dispatch, store.getState);
    }

    return next(action)
}