function pigeonholeSort(arr: number[]): void {
    let min = arr[0];
    let max = arr[0];

    for (const el of arr) {
        min = el < min ? el : min;
        max = el > max ? el : max;
    }

    const range = max - min + 1;
    const phole: number[] = Array.from({ length: range }, () => 0);

    for (const element of arr) {
        phole[element - min]++;
    }

    let index = 0;

    for (let i = 0; i < range; i++) {
        while (phole[i]-- > 0) {
            arr[index++] = i + min;
        }
    }
}

export { pigeonholeSort };
