import MyBtn from './MyBtn';
import "./App.css"
import { useState } from 'react';

const products = [
  { title: 'Cabbage', id: 1 },
  { title: 'Garlic', id: 2 },
  { title: 'Apple', id: 3 },
];

function App() {

  const [count, setCount] = useState(0);

    function btnClickHandler(){
        alert(count);
        setCount(count + 1)
      }

  return (
  <>
    { products.map(x => <MyBtn key={x.id} count={count} btnClickHandler={btnClickHandler}/>)}
  </>
  );
}

export default App;
