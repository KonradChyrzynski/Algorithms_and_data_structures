import { pigeonholeSort } from '../PigeonholeSort';

describe('pigeonholeSort', () => {
    it('should sort the array in ascending order', () => {
        const arr = [9, 3, 7, 1, 5];
        pigeonholeSort(arr);
        expect(arr).toEqual([1, 3, 5, 7, 9]);
    });

    it('should sort an array with repeated elements', () => {
        const arr = [5, 3, 2, 5, 1, 3, 2];
        pigeonholeSort(arr);
        expect(arr).toEqual([1, 2, 2, 3, 3, 5, 5]);
    });

    it('should sort an already sorted array', () => {
        const arr = [1, 2, 3, 4, 5];
        pigeonholeSort(arr);
        expect(arr).toEqual([1, 2, 3, 4, 5]);
    });

    it('should sort an array with a single element', () => {
        const arr = [7];
        pigeonholeSort(arr);
        expect(arr).toEqual([7]);
    });

    it('should sort an empty array', () => {
        const arr: number[] = [];
        pigeonholeSort(arr);
        expect(arr).toEqual([]);
    });
});
