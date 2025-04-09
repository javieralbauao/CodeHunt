import React, { useState } from "react";
import Login from "./components/Login";
import ProtectedPage from "./components/ProtectedPage";

function App() {
  const [token, setToken] = useState(localStorage.getItem("token"));

  return (
    <div>
      {!token ? (
        <Login onLogin={setToken} />
      ) : (
        <ProtectedPage />
      )}
    </div>
  );
}

export default App;
