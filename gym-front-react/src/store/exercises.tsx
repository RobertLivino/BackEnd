import { create } from 'zustand'

interface exercisesStore {
    data: any;
    isLoading?: boolean;
    error: any;
    fatchData: () => void;
}
export const useExercisesStore = create<exercisesStore>((set) => ({
    data: [],
    isLoading: false,
    error: null,
    fatchData: async () => {
        const { data } = useExercisesStore.getState();
        if (data.length > 0) return;
        set({ isLoading: true, error: null });
        try {
            const response = await fetch('http://localhost:5100/api/Exercises');
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            const json = await response.json();
            set({ data: json, isLoading: false, error: null });
            console.log('Fetched exercises:', json);
        }
        catch (error) {
            set({ error: error, isLoading: false });
        }
    }
    //   yourAction : (val) => set( (state) => ({ yourState : state.yourState }) )
}))
