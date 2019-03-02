import React, { Component } from 'react';

export class Home extends Component {
  displayName = Home.name

  render() {
    return (
      <div>
        <h1>Hello, world!</h1>
        <p>Welcome to the Radium UTXO server</p>
        
        <p>You can get a list of uxto's associated with an address</p>
       
            <p>ussing the endpoint <code>api/values/getaddressutxos/XkpKS4PzyvXcEsZA7vVoU1dot2Z8gbn76B</code></p>
      </div>
    );
  }
}
