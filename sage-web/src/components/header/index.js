import React from "react";
import './header.css'

const Header = (props) => {
    return (
        <header>
            <img className="logo" src="logo.png" alt="Logo Sage"/>
            <h1 className="title">{props.title}</h1>
        </header>       

    );
}

export default Header;
