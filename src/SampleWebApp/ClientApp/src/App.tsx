import * as React from 'react';
import './App.css';

const logo = require('./zijemeit_logo_big.png');

class App extends React.Component {
  render() {
    return (
      <div className="App">
        <header className="App-header">
          <img src={logo} className="App-logo" alt="logo" />
          <h1 className="App-title">Vítejte na konferenci Žijeme IT 2017x</h1>
        </header>
        <p className="App-intro">
          Tato je ukázková aplikace pro workshop "Deployment automation in Azure"
        </p>
      </div>
    );
  }
}

export default App;
