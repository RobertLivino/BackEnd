import { useEffect, useState } from "react";
import { useExercisesStore } from "@/store/exercises";
import React from "react";
import { Button, Menu, MenuItem } from "@mui/material";

export default function AddExercise({
    onSelect
}: {
    onSelect: [{
        exerciseId: number;
    }]
}) {
    const [anchorEl, setAnchorEl] = React.useState<null | HTMLElement>(null);
    const { data, isLoading, error, fatchData } = useExercisesStore()
    const open = Boolean(anchorEl)

    useEffect(() => {
        fatchData();
    }, [fatchData]);
    const handleClick = (event: React.MouseEvent<HTMLButtonElement>) => {
        setAnchorEl(event.currentTarget);
    }

    const handleClose = () => {
        setAnchorEl(null)
    }
    return (
        <>
            <Button
                id="basic-button"
                aria-controls={open ? 'basic-menu' : undefined}
                aria-haspopup="true"
                aria-expanded={open ? 'true' : undefined}
                onClick={handleClick}
            >
                Novo exercicio
            </Button>
            <Menu
                id="basic-menu"
                anchorEl={anchorEl}
                open={open}
                onClose={handleClose}
                slotProps={{
                    list: {
                        'aria-labelledby': 'basic-button',
                    },
                }}
            >
                {isLoading ? <div>Loading...</div> : ""}
                {error ? <div> Error: {error.message}</div> : ""}
                {data.map((item: any) =>
                    <MenuItem
                        key={`exercise${item.id}`}
                        onClick={() => {
                            onSelect.push({ exerciseId: item.id })
                            handleClose();
                        }}
                        value={item.id}
                    >
                        {item.exerciseName}
                    </MenuItem>
                )}
            </Menu>
        </>
        // <div
        //     className="mt-4 text-2xl text-center content-center rounded-md font-bold bg-gray-200 min-w-10/12 min-h-20 shadow-md cursor-pointer hover:bg-gray-300"
        //     onClick={openExerciseMenu()}
        // >
        //     Novo exercicio
        // </div>
    )
}
