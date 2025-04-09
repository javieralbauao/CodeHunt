import React, { useState } from "react";
import Login from "./components/Login";
import ProtectedPage from "./components/ProtectedPage";
import StatusCheck from "./components/StatusCheck";

function App() {
  const [token, setToken] = useState(localStorage.getItem("token"));

  return (
    <div>
      {/* Muestra el login si no hay token, o la página protegida si sí hay */}
      {!token ? (
        <Login onLogin={setToken} />
      ) : (
        <ProtectedPage />
      )}

      {/* Este componente hace una prueba de conexión con la API */}
      <StatusCheck />
    </div>
  );
}

export default App;
