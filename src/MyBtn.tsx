import { FC, useState } from "react";

interface IButton {
    count: number,
    btnClickHandler: React.MouseEventHandler<HTMLButtonElement>
}

let obj = {
    text: "new name"
  }

const MyBtn: FC<IButton> = ({count, btnClickHandler}) => {
    return (
    <>
        <button className="mybtn" onClick={btnClickHandler} >{obj.text}</button>
    </>
    )
}

export default MyBtn