function quickSort(arr: Array<number>, l: number, r: number )
{
    if(l >= r)
    {
        return
    }

    const pivotIndex = partition(arr,l,r);

    quickSort(arr, l, pivotIndex - 1);
    quickSort(arr, pivotIndex + 1, r);
}

//This function return the index of the pirovt 
function partition(arr: Array<number>, l: number, r: number): number
{
    const pivot = arr[r];
    let i = l - 1
    for(let j = l; j < r; j++ ){

        if(arr[j] < pivot)
        {
            i++;
            swap(arr, i, j);
        }
        
    }

    return 2;
}

function swap(arr: Array<number>, i: number, j: number)
{
   arr[] 
}