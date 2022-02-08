// Print from 1 to 255
function Print1to255(){
    for(let i = 1; i <= 255; i++){
        console.log(i);
    }
}

// Print1to255();

function printSum(){
    let sum = 0;
    for(let i = 0; i <= 255; i++){
        console.log(i);
        sum+=i;
        console.log(sum);
    }
}

// printSum();

function printArray(arr){
    for(let i = 0; i < arr.length; i++){
        console.log(arr[i]);
    }
}

// printArray([2,6,9,2,7,4]);

function dojoReplace(arr){
    // we need to go through the array
    for(let i = 0; i < arr.length; i++){
        // we need to check if the value is negative
        if(arr[i] < 0){
            arr[i] = "dojo";
        }
    }
    return arr;
}

console.log(dojoReplace([1,-2,3,-4,5]));