import { useExercisesStore } from "@/store/exercises";
import { useEffect } from "react";

export default function SelectExercise() {
    const { data, isLoading, error, fatchData } = useExercisesStore()
    useEffect(() => {
        fatchData();
    }, [fatchData]);

    if (isLoading) return ({
        render: (
            <div>Loading...</div>
        )
    })
    if (error) return ({
        render: (
            <div> Error: {error.message}</div>
        )
    })
    return ({
        render: (
            <select>
                {data.map((exercise: any) => (
                    <option key={`exercise${exercise.id}`} value={exercise.id}>{exercise.name}</option>
                ))}
                <option value=""></option>
            </select>
        )
    })
}