function solve(arr) {

    let counter = 1;
    let sum = 0;
    let bitcoin = 0;
    let dayFirst = 0;
    for (let i = 0; i < arr.length; i++) {
        if(counter%3 ===0){

            arr[i] = arr[i] - (arr[i]*30)/100;
        }
        sum += arr[i]*67.51;


        if(sum>=11949.16){
            if(bitcoin===0){
                dayFirst = counter;
            }

           bitcoin +=Math.floor(sum/11949.16);
            let op = Math.floor(sum/11949.16);
            for (let j = 0; j < op; j++) {
                sum-=11949.16;
            }
        }
        counter++;
    }
    let result = '';
    if(dayFirst===0){
       result = `Bought bitcoins: ${bitcoin}\nLeft money: ${sum.toFixed(2)} lv.`
    }else {
        result = `Bought bitcoins: ${bitcoin}\nDay of the first purchased bitcoin: ${dayFirst}\nLeft money: ${sum.toFixed(2)} lv.`;
    }
    return result;
}
