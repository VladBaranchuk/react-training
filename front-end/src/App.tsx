import "./App.css"
import { FC } from 'react';
import Profiles from "./pages/Profiles";
import {BrowserRouter as Router} from 'react-router-dom';

const App: FC = () => {

  return (
    <Router>
      <Profiles />
    </Router>
  );
}

export default App;