function solution(arr) {

    let massive;
    for (let i = 0; i < arr.length; i++) {

        if(i ===0) {
             massive = arr[i].split(` `);
             continue;
        }

        let command = arr[i].split(` `);
        let com = command[0];
        let item = command[1];

        if(com === `Buy` && !massive.includes(item)){

            massive.push(item);
            continue;
        }
        if(com === `Trash`){

           massive =  massive.filter(a=>a!==item);
           continue;
        }

        if(com === `Repair` && massive.includes(item)){

            let sub = massive.filter(a=>a===item);
            massive = massive.filter(a=>a!==item);

            massive.push(sub[0]);

            continue;

        }

        if(com === `Upgrade`){

            let equipment = item.split(`-`);

            if(massive.includes(equipment[0])){

                let possition = massive.indexOf(equipment[0]);

                let arr = item.split(`-`);

                arr = arr.join(`:`);


                massive.splice(possition+1,0,arr);

                continue;
            }
        }
        if(com ===`Fight`){

            console.log(massive.join(` `));
            return;
        }
    }

    console.log(massive.join(` `));
}