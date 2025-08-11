'use client';
import { SetStateAction, useState } from 'react';
import AddExercise from './components/addExercise';

export default function NewRoutine() {
    // const { render } = AddExercise();
    const [select, setSelect] = useState<SetStateAction<any>>([]);
    console.log('Selected exercises:', select.length);
    return (
        <div className="flex flex-col items-center min-h-screen">
            <input className=" border-b-2 min-w-10/12 text-4xl font-bold" type="text" placeholder="Nome da Rotina" />
            <AddExercise onSelect={(select)} />
            {/* {render} */}
        </div>
    )
}