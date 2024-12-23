import { FC } from "react";
import ProfileItem from "../components/ProfleItem";
import { useSelector } from "react-redux";
import { Button } from "@progress/kendo-react-buttons";
import { plusIcon } from '@progress/kendo-svg-icons';
import { SvgIcon } from "@progress/kendo-react-common";
import { RootState } from "../store/reducer";

const Profiles: FC = () => {
    const profileIds = useSelector((x: RootState) => x.profiles?.map(y => y.id));

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
          {profileIds && profileIds.map((item) => {
            return <ProfileItem key={item} profileId={item} />
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