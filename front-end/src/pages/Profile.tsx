import { FC, useEffect } from "react";
import { backgroundContainer, profileContainer } from "../styles";
import { useParams } from "react-router-dom";
import { getProfile } from "../api/profileController/ProfileController";
import { useDispatch } from "react-redux";

const Profile: FC = () => {

  const {id} = useParams();
  var dispatch = useDispatch();

  useEffect(() => {
    getProfile(id!)
      .then(data => {
          if (data !== null) {
              dispatch({type: "profile/setProfile", payload: data});
              console.log('Loaded: ', data);
          }
      });
    return () => {
      dispatch({type: "profile/unmountProfile"});
    }
  });

  return (
    <>
     <div style={backgroundContainer}>
      <div style={profileContainer}>

      </div>
     </div>
    </>
    );
  }
  
  export default Profile;