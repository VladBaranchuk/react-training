import { FC, useEffect } from "react";
import { backgroundContainer, daysContainer, profileContainer } from "../styles";
import { Link, useParams } from "react-router-dom";
import { getProfile } from "../api/profileController/ProfileController";
import { useDispatch, useSelector } from "react-redux";
import { RootState } from "../store/reducer";
import { DaysActions, ProfileActions } from "../store/actionFabrics";
import { Grid, GridColumn as Column } from '@progress/kendo-react-grid';
import { getDays } from "../api/dayController/DayController";
import DayItem from "../components/DayItem";

const Profile: FC = () => {

  const {id} = useParams();
  var dispatch = useDispatch();

  useEffect(() => {
    async function fetchProfile() {
      let profile = await getProfile(id!);

      if (profile !== null) {
          dispatch(ProfileActions.setProfile(profile));

          let days = await getDays(id!);
          dispatch(DaysActions.setDays(days));
      }
    };
    fetchProfile();
    
    return () => {
      dispatch(ProfileActions.unmountProfile());
      dispatch(DaysActions.unmountDays());
    }
  });

  // const profile = useSelector((x: RootState) => x.profiles?.find(y => y.id === id));
  // const days = useSelector((x: RootState) => x.days);

  // console.log("daysseeeee", days);
  return (
    <>
     <div style={backgroundContainer}>
      <div style={profileContainer}>
        <div>
        {/* {profile?.firstName} {profile?.lastName} */}
        <div style={daysContainer}>
          {/* {days && days?.map(x => <DayItem key={x.id} dayId={x.id} date={x.date} />)} */}
          
        </div>
        <Grid 
          style={{ height: '400px' }} 
          >
            {/* {columns.map((column, index) => {
                return (
                    <Column
                        field={column.field}
                        title={column.title}
                        key={index}
                        width={setWidth(column.minWidth)}
                    />
                );
            })} */}
        </Grid>
        </div>
      </div>
     </div>
    </>
    );
  }
  
  export default Profile;