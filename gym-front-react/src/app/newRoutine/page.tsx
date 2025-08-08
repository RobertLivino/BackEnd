'use client';
import AddExercise from './components/addExercise';

export default function NewRoutine() {
    const { render } = AddExercise();
    return (
        <div className="flex flex-col items-center min-h-screen">
            <input className=" border-b-2 min-w-10/12 text-4xl font-bold" type="text" placeholder="Nome da Rotina" />
            {render}
        </div>
    )
}