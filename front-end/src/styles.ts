type FlexDirection = "column" | "inherit" | "-moz-initial" | "initial" | "revert" | "unset" | "column-reverse" | "row" | "row-reverse" | undefined;

export const backgroundContainer = {
    display: "flex",
    minHeight: "100vh",
    justifyContent: "center",
    alignItems: "center",
    backgroundImage: "url(https://random-image-pepebigotes.vercel.app/api/random-image)",
    backgroundRepeat: "no-repeat",
    backgroundSize: "cover",
};

export const profilesContainer = {
    display: "flex",
    justifyContent: "center",
    alignItems: "center",
    flexDirection: "column" as FlexDirection,
    padding: "30px 60px",
    border: "1px solid rgb(157, 157, 157)",
    borderRadius: "5px",
    backgroundColor: "#ffffff1a",
    backdropFilter: "blur(15px)"
};

export const profileContainer = {
    display: "flex",
    justifyContent: "center",
    alignItems: "center",
    flexDirection: "column" as FlexDirection,
    padding: "30px 60px",
    border: "1px solid rgb(157, 157, 157)",
    borderRadius: "5px",
    backgroundColor: "white",
    backdropFilter: "blur(15px)"
}

export const createProfile = {
    width: "250px",
    height: "60px",
    justifyContent: "center"
}

