import { useContext, useEffect, useState } from "react";
import { ApplicationContext } from "../Application";

const Home = () => {

    const { gateway } = useContext(ApplicationContext);

    const [item, setItem] = useState([]);

    fetchDataAuthentication = async () => {
        console.log("FETCHING DATA...")
        const fetchData = await fetch(`${gateway}/api/User`)
        const data = await fetchData.json();

        if(fetchData.ok) {
            setItem(data);
        }
    }

    useEffect(() => {
        fetchDataAuthentication();
    }, [])

    return(
        <div>
            {item.map((i, index) => (
                <div key={index}>{i.password}</div>
            ))}
        </div>
    )
}

export default Home;