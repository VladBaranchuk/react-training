export function connect(serverUrl: string, roomId: string) {
  console.log('✅ Connecting to "' + roomId + '" room at ' + serverUrl + '...');
}
export function disconnect(serverUrl: string, roomId: string) {
  console.log('❌ Disconnected from "' + roomId + '" room at ' + serverUrl);
}