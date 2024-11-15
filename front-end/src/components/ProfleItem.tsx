import { Button } from "@progress/kendo-react-buttons";
import { toSvg } from "jdenticon";
import { FC } from "react";
import { Profile } from "../api/profileController/Models";

interface IProfileItem {
    profile: Profile
}

const generateImage = (id: string, size: number): string => {
    let svg = toSvg(id, size);
    let blob = new Blob([svg], { type: "image/svg+xml" });
    return URL.createObjectURL(blob);
}

const ProfileItem: FC<IProfileItem> = ({profile}) => {

    let icon = generateImage(profile.id, 50);

    return (
        <>
            <Button imageUrl={icon}>{profile.firstName + " "+ profile.lastName}</Button>
        </>
    );
} 

export default ProfileItem;