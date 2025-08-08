import { useState } from "react";

export default function AddExercise() {
    const { exercise, setExercise } = useState({});





    return (
        {

            render: (
                <div
                    className="mt-4 text-2xl text-center content-center rounded-md font-bold bg-gray-200 min-w-10/12 min-h-20 shadow-md cursor-pointer hover:bg-gray-300"
                >
                    Novo exercicio
                </div>
            )
        }
    )
}
