import Profile from "../pages/Profile";
import Profiles from "../pages/Profiles";

export const routes = [
    {
        path: '/',
        element: Profiles
    },
    {
        path: '/Profile/:id',
        element: Profile
    }
]