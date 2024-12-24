import { FC, useState } from "react";
import ProfileItem from "../components/ProfleItem";
import { useSelector } from "react-redux";
import { Button } from "@progress/kendo-react-buttons";
import { plusIcon } from '@progress/kendo-svg-icons';
import { SvgIcon } from "@progress/kendo-react-common";
import { RootState } from "../store/reducer";
import CreateProfileDialog from "../components/CreateProfileDialog";
import { createProfile, profilesContainer, profilesContainerInternal } from "../styles";

const Profiles: FC = () => {
  let [visible, setVisible] = useState<boolean>(false);

  const profileIds = useSelector((x: RootState) => x.profiles?.map(y => y.id));

  return (
    <>
      {visible && <CreateProfileDialog visible={visible} setVisible={setVisible}/>}
      <div style={profilesContainer}>
        <div style={profilesContainerInternal}>
          {profileIds && profileIds.map((item) => {
            return <ProfileItem key={item} profileId={item} />
          })}
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