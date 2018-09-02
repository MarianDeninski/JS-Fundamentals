function Solve(arr) {


    let result = 0;
    let noOperands = false;
    for (let i = 0; i < arr.length; i++) {

        if(arr[1] == '*' || arr[1] == '-' || arr[1] == '/' || arr[1] == '+'||
            arr[0] == '*' || arr[0] == '-' || arr[0] == '/' || arr[0] == '+'){
            console.log('Error: not enough operands!');
            return;
        }

        if(arr.length==1){
            console.log(arr.join())
            return;
        }

        if(arr[i] == '*' || arr[i] == '-' || arr[i] == '/' || arr[i] == '+'){

            if(arr[i]=='*'){
                result = Number(arr[i-2]) * Number(arr[i-1]);
                arr.splice(i-2,3,result);
                i = -1;
                continue;
            }
            else if(arr[i]=='+'){
                result = Number(arr[i-2]) + Number(arr[i-1]);
                arr.splice(i-2,3,result);
                i = -1;
                continue;
            }
            else if(arr[i]=='-'){
                result = Number(arr[i-2]) - Number(arr[i-1]);
                arr.splice(i-2,3,result);
                i = -1;
                continue;
            }
            else if(arr[i]=='/'){
                result = Number(arr[i-2]) / Number(arr[i-1]);
                arr.splice(i-2,3,result);
                i = -1;
                continue;
            }
        }

    }
    console.log('Error: too many operands!');
}