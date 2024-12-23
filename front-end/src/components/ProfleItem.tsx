import { Button } from "@progress/kendo-react-buttons";
import { toSvg } from "jdenticon";
import { FC } from "react";
import { useSelector } from "react-redux";
import { RootState } from "../store/reducer";

interface IProfileItem {
    profileId: string
}

const generateImage = (id: string, size: number): string => {
    let svg = toSvg(id, size);
    let blob = new Blob([svg], { type: "image/svg+xml" });
    return URL.createObjectURL(blob);
}

const ProfileItem: FC<IProfileItem> = ({profileId}) => {
    const icon = generateImage(profileId, 50);
    const profile = useSelector((state: RootState) => state.profiles.find(y => y.id === profileId));
    
    return (
        <>
            <Button 
                imageUrl={icon}
                style={{
                    width: "250px",
                    justifyContent: "left",
                    marginBottom: "10px",
                    fontWeight: "bold"
                }}
                >{profile?.firstName + " "+ profile?.lastName}</Button>
        </>
    );
} 

export default ProfileItem;