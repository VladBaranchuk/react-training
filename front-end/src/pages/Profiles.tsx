import { FC, useEffect, useState } from "react";
import { Profile } from "../api/profileController/Models";
import { getProfiles } from "../api/profileController/ProfileController";
import ProfileItem from "../components/ProfleItem";
import { Button } from "@progress/kendo-react-buttons";
import { plusIcon } from '@progress/kendo-svg-icons';
import { SvgIcon } from "@progress/kendo-react-common";

const Profiles: FC = () => {

    const [profiles, setProfiles] = useState<Profile[]>([]);

    useEffect( () => {
        getProfiles()
            .then(x => setProfiles(x ?? []));
    }, []) 

    return (
      <div style={{
        display: "flex",
        minHeight: "100vh",
        justifyContent: "center",
        alignItems: "center",
        backgroundImage: "url(https://random-image-pepebigotes.vercel.app/api/random-image)",
        backgroundRepeat: "no-repeat",
        backgroundSize: "cover",
      }}>
        <div style={{
        display: "flex",
        justifyContent: "center",
        alignItems: "center",
        flexDirection: "column",
        padding: "30px 60px",
        border: "1px solid rgb(157, 157, 157)",
        borderRadius: "5px",
        backgroundColor: "#ffffff1a",
        backdropFilter: "blur(15px)"
      }}>
          {profiles.map((item) => {
            return <ProfileItem key={item.id} profile={item} />
          })}
              <Button 
                style={{
                    width: "250px",
                    height: "60px",
                    justifyContent: "center"
                }}><SvgIcon icon={plusIcon} size="large"/></Button>
        </div>
    </div>  
    );
  }
  
  export default Profiles;