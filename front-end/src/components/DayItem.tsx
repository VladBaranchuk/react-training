import { Button } from "@progress/kendo-react-buttons";
import { FC } from "react";

interface IDayItem {
    dayId: string,
    date: Date
}

const ProfileItem: FC<IDayItem> = ({dayId, date}) => {
    return (
        <Button 
            style={{
                width: "250px",
                justifyContent: "left",
                marginBottom: "10px",
                fontWeight: "bold"
            }}
            >{date.getDate()}</Button>
    );
} 

export default ProfileItem;