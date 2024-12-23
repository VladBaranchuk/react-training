import { createStore, applyMiddleware } from "redux";
import { useThunk } from "../middlewares/useThunk";
import rootReducer from "./reducer";

const middleware = applyMiddleware(useThunk);

export default createStore(rootReducer, middleware);

