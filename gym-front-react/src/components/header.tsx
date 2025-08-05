'use client';
import { useRouter } from 'next/navigation';
export default function Header() {
    const router = useRouter();
    return (
        <header className="flex bg-slate-700 p-4 justify-between">
            <h1 className="text-gray-200 text-2xl font-semibold cursor-pointer" onClick={() => router.push('/')}>Gym Management System</h1>
            <h1 className="text-gray-200 text-2xl font-semibold cursor-pointer hover:text-gray-500" onClick={() => router.push('/')}>Home</h1>
        </header>
    );
}   