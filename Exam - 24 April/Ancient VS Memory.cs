function solution(arr) {

    let pattern = /32656 19759 32763 [0] [0-9]+ [0] (.*)/;

    let all = arr.join(` `);

    let result = '';

    let here = pattern.exec(all);

    while (here){

        let numbers = here[1].split(` `);

        for (let obj of numbers) {


            if(obj ===`0`){
                result+=`\n`;
                break;
            }
           let op =  String.fromCharCode(obj);
           result+=op;
        }
        pattern = /32656 19759 32763 [0] [0-9]+ [0] (.*)/;
        here = pattern.exec(numbers.join(` `));

    }
    console.log(result.split(`\n`).filter(a=>a!==``).join(`\n`));
}