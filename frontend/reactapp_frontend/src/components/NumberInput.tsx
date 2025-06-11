import { motion } from 'framer-motion';
import { ArrowDownWideNarrow, ArrowUpWideNarrow } from 'lucide-react';
import { useNumberSorter } from '../hooks/useNumberSorter';

export default function NumberInput() {
  const { raw, error, sorted, ascending, parse, toggle } = useNumberSorter();

  return (
    <div className="rounded-2xl bg-white shadow-xl ring-1 ring-gray-100 p-6">
      <form
        onSubmit={e => {
          e.preventDefault();
          parse(raw);
        }}
        className="space-y-4"
      >
        <label className="block text-sm font-medium text-gray-700">
          Numbers (comma-separated)
          <input
            value={raw}
            onChange={e => parse(e.target.value)}
            className="mt-1 w-full rounded-lg border-gray-300 p-3 shadow-sm focus:border-indigo-500 focus:ring-indigo-500"
            placeholder="e.g. 10, 7.5, 42"
          />
        </label>

        {error && (
          <p className="rounded-lg bg-red-50 px-3 py-2 text-sm text-red-600">
            {error}
          </p>
        )}

        {sorted.length > 0 && (
          <motion.div
            initial={{ opacity: 0, y: 6 }}
            animate={{ opacity: 1, y: 0 }}
            className="space-y-3"
          >
            <button
              type="button"
              onClick={toggle}
              className="inline-flex items-center gap-1.5 rounded-lg bg-indigo-600 px-4 py-2 text-sm font-medium text-white hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-indigo-400"
            >
              {ascending ? (
                <>
                  <ArrowDownWideNarrow size={16} /> Descending
                </>
              ) : (
                <>
                  <ArrowUpWideNarrow size={16} /> Ascending
                </>
              )}
            </button>

            <pre className="rounded-lg bg-gray-100 p-4 font-mono text-sm text-gray-800 shadow-inner">
              {sorted.join(', ')}
            </pre>
          </motion.div>
        )}
      </form>
    </div>
  );
}