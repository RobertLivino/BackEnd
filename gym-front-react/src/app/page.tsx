'use client';
import { useRouter } from "next/navigation";

export default function Home() {
    const route = useRouter();
    function redirectTonewRoutine() {
        return () => {
            console.log("Redirecting to new routine");
            route.push("/newRoutine");
        }
    }
    return (
        <div className="flex flex-col items-center min-h-screen">
            <h1 className="text-4xl font-bold">Welcome to the Gym Management System</h1>
            <div
                className="mt-4 text-2xl text-center content-center rounded-md font-bold bg-gray-200 min-w-10/12 min-h-20 shadow-md cursor-pointer hover:bg-gray-300"
                onClick={redirectTonewRoutine()}
            >
                Nova Rotina
            </div>
        </div >
    )
}
