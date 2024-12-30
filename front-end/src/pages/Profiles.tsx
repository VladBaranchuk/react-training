import { FC, useState } from "react";
import ProfileItem from "../components/ProfleItem";
import { useSelector } from "react-redux";
import { Button } from "@progress/kendo-react-buttons";
import { plusIcon } from '@progress/kendo-svg-icons';
import { SvgIcon } from "@progress/kendo-react-common";
import { RootState } from "../store/reducer";
import CreateProfileDialog from "../components/CreateProfileDialog";
import { createProfile, backgroundContainer, profilesContainer } from "../styles";
import { Link } from "react-router-dom";

const getProfileItem = (id: string) => {
  return (
    <Link to={`/Profile/${id}`}>
      <ProfileItem key={id} profileId={id} />
    </Link>);
}

const Profiles: FC = () => {
  let [visible, setVisible] = useState<boolean>(false);

  const profileIds = useSelector((x: RootState) => x.profiles?.map(y => y.id));

  return (
    <>
      {visible && <CreateProfileDialog visible={visible} setVisible={setVisible}/>}
      <div style={backgroundContainer}>
        <div style={profilesContainer}>
          {profileIds && profileIds.map(getProfileItem)}
          <Button 
            onClick={() => setVisible(!visible)}
            style={createProfile}>
              <SvgIcon icon={plusIcon} size="large"/>
          </Button>
        </div>
      </div> 
    </>
    );
  }
  
  export default Profiles;