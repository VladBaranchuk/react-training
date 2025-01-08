import { FC, useEffect } from "react";
import { backgroundContainer, profileContainer } from "../styles";
import { useParams } from "react-router-dom";
import { getProfile } from "../api/profileController/ProfileController";
import { useDispatch, useSelector } from "react-redux";
import { RootState } from "../store/reducer";
import { ProfileActions } from "../store/actionFabrics";

const Profile: FC = () => {

  const {id} = useParams();
  var dispatch = useDispatch();

  useEffect(() => {
    async function fetchProfile() {
      let profile = getProfile(id!);

      if (profile !== null) {
          dispatch(ProfileActions.setProfile(profile));
          console.log('Loaded: ', profile);
      }
    };
    fetchProfile();
    
    return () => {
      dispatch(ProfileActions.unmountProfile());
    }
  });

  const profile = useSelector((x: RootState) => x.profiles?.find(y => y.id === id));

  return (
    <>
     <div style={backgroundContainer}>
      <div style={profileContainer}>
        <div>
        {profile?.firstName} {profile?.lastName}
        </div>
      </div>
     </div>
    </>
    );
  }
  
  export default Profile;