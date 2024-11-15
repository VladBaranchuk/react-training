import { FC, useEffect, useState } from "react";
import { Profile } from "../api/profileController/Models";
import { getProfiles } from "../api/profileController/ProfileController";
import ProfileItem from "../components/ProfleItem";

const Profiles: FC = () => {

    const [profiles, setProfiles] = useState<Profile[]>([]);

    useEffect( () => {
        getProfiles()
            .then(x => setProfiles(x ?? []));
    }, []) 

    return (
      <>
      {profiles.map((item) => {
        return <ProfileItem key={item.id} profile={item} />
      })}
    </>
      
    );
  }
  
  export default Profiles;