function Solve(arr) {

    let sum = 0;
    let massive = [];

    let counter = arr.length;
    for (let i = 0; i < arr.length; i++) {

        if(arr[i]>=30){
            counter--;
        }

        if(counter == 0){
            break;
        }
        arr[i]++;
        if(i == arr.length-1){
            i = -1;
            massive.push(counter*195)
            sum+= counter*195;
            counter = arr.length;
        }
    }
    console.log(massive.join(', '));
    console.log(1900*sum + ' pesos');
}
