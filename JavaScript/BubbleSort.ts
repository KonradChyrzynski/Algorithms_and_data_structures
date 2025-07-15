export default function bubble_sort(arr: number[]): void {
  for (let i = 0; i < arr.length; ++i) {
    for (let j = 0; j < arr.length - 1 - i; ++j) {
      if (arr[j] > arr[j + 1]) {
        const temp = arr[j];
        arr[j] = arr[j + 1];
        arr[j + 1] = temp;
      }
    }
  }
}

// Benchmark
Deno.bench("bubble_sort 1000 items", () => {
  const arr = Array.from({ length: 1000 }, () =>
    Math.floor(Math.random() * 10000),
  );

  bubble_sort(arr);
});
