import {BrowserRouter, Route, Routes} from "react-router-dom";
import { createContext } from "react";
import Home from "./View/Home";

export const ApplicationContext = createContext();

const Application = () => {

    const gateway = process.env.REACT_APP_GATEWAY_URL;

    return(
        <ApplicationContext.Provider value={ {
            gateway
        } }>
            <BrowserRouter>
                <Routes>
                    <Route path="/" element={<Home />}/>
                </Routes>
            </BrowserRouter>
        </ApplicationContext.Provider>
    )
}

export default Application;