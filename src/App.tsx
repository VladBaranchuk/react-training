import "./App.css"
import { connect, disconnect } from './chat';
import { FC, useState, useEffect } from 'react';

const serverUrl = 'https://localhost:1234';

function ChatRoom({ roomId } : {roomId: string}) {
  return (<h1>Welcome to the {roomId} room!</h1>);
}

const App: FC = () => {

  const [roomId, setRoomId] = useState<string>('general');
  const [show, setShow] = useState<boolean>(false);

  useEffect(() => {
    connect(serverUrl, roomId);
    setShow(true);
    return disconnect(serverUrl, roomId);
  }, [roomId]);

  return (
    <>
      <label>
        Choose the chat room:{' '}
        <select
          value={roomId}
          onChange={e => setRoomId(e.target.value)}
        >
          <option value="general">general</option>
          <option value="travel">travel</option>
          <option value="music">music</option>
        </select>
      </label>
      <button onClick={() => setShow(!show)}>
        {show ? 'Close chat' : 'Open chat'}
      </button>
      {show && <hr />}
      {show && <ChatRoom roomId={roomId} />}
    </>
  );
}

export default App;