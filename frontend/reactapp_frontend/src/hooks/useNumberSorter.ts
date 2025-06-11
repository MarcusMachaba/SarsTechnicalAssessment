import { useState } from 'react';

export type SortState = {
    raw: string;
    numbers: number[];
    error: string | null;
    ascending: boolean;
};

export function useNumberSorter() {
    const [state, setState] = useState<SortState>({
        raw: '',
        numbers: [],
        error: null,
        ascending: true,
    });

    const parse = (input: string) => {
        const trimmed = input.trim();
        if (!trimmed) {
            return setState(s => ({ ...s, raw: input, numbers: [], error: null }));
        }
        const parts = trimmed.split(',').map(p => p.trim());
        const nums: number[] = [];
        for (const p of parts) {
            const n = Number(p);
            if (Number.isNaN(n)) {
                return setState(s => ({
                    ...s,
                    raw: input,
                    error: `'${p}' is not a valid number.`,
                    numbers: [],
                }));
            }
            nums.push(n);
        }
        setState({
            raw: input,
            numbers: nums,
            error: null,
            ascending: true,
        });
    };

    const toggle = () =>
        setState(s => ({ ...s, ascending: !s.ascending }));

    const sorted = [...state.numbers].sort(
        (a, b) => (state.ascending ? a - b : b - a),
    );

    return { ...state, sorted, parse, toggle };
}