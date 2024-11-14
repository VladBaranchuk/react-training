import { FC, useEffect, useState } from "react";
import { Profile } from "../api/profileController/Models";
import { getProfiles } from "../api/profileController/ProfileController";

const Profiles: FC = () => {

    const [profiles, setProfiles] = useState<Profile[]>([]);

    useEffect( () => {
        getProfiles()
            .then(x => setProfiles(x ?? []));
    }, []) 

    return (
      <pre>
        {JSON.stringify(profiles)}
      </pre>
    );
  }
  
  export default Profiles;