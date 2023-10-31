function fib(numberOfTerms){
    if(n < 2){return n}
    else{ return fib(n-1) + fib(n - 2)}
}

const merge = (leftArr, rightArr) =>{
    const output = [];
    let leftIndex = 0;
    let rightIndex = 0;

    while(leftIndex < leftArr.length && rightIndex < rightArr.length){
        const leftEl = leftArr[leftIndex];
        const rightEl = rightArr[rightIndex];

        if(leftEl < rightEl){
            output.push(leftEl);
            leftIndex++;
        }
        else{
            output.push(rightEl)
            rightIndex++
        }
    }
    return [...output, ...rightArr.slice(rightIndex), ...leftArr.slice(leftIndex)];
}

const mergeSort = array => {
    if(array.length <=1 ){
        return array
    }

    const midleIndex = Math.floor(array.length / 2);
    const leftArr = array.slice(0,midleIndex);
    const rightArr = array.slice(midleIndex);

    return merge(mergeSort(leftArr), mergeSort(rightArr))
}

const mergedArray = mergeSort([2,10,59,29,39,49,59,19,22,43]);

console.log(mergedArray);
