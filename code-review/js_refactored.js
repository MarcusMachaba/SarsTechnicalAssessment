/**
 * Alphabetically sorts a CSV string.
 * @param {string} csv e.g. "c,b,a"
 * @returns {string}  e.g. "a,b,c"
 */
export function sortCsv(csv) {
    if (typeof csv !== 'string') throw new TypeError('csv must be a string');

    return csv
        .split(',')
        .map(v => v.trim())
        .filter(Boolean)
        .sort((a, b) => a.localeCompare(b))
        .join(',');
}
