import React, { Component } from 'react';
import {CategoryMenu} from '../Category/CategoryMenu.js'

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <div>
        <div className="input-group md-form form-sm form-1 pl-0">
          <input className="form-control my-0 py-1" type="text" placeholder="Search" aria-label="Search"/>
          <button type="button" className="btn bg-secondary text-white">Search</button>
        </div>
          <CategoryMenu></CategoryMenu>
      </div>
    );
  }
}
