import { Dispatch, Middleware } from "redux";
import { RootState } from "../store/reducer";
import { DispatchAction } from "../store/localDispatcher";

export const useThunk: Middleware<Dispatch<DispatchAction>, RootState> = store => next => action => {
    if (typeof action === 'function') {
        return action(store.dispatch, store.getState);
    }

    return next(action)
}