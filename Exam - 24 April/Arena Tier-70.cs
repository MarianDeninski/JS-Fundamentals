function solution(arr) {


    let gladiator = new Map();

    for (let obj of arr) {

        if(obj ===`Ave Cesar`){
            break;
        }
        let here = obj.split(` `);

        if(here.length !== 3) {
            let data = obj.split(` -> `);

            let name = data[0];
            let technique = data[1];
            let result = data[2];

            if (!gladiator.has(name)) {

                gladiator.set(name, new Map());
            }

            if (!gladiator.get(name).has(technique)) {


                gladiator.get(name).set(technique,result)

            }else{
               if( +gladiator.get(name).get(technique) < +technique){
                   gladiator.get(name).set(technique,technique)
               }
            }


        }else{
            let data = obj.split(` vs `);

            let glad1 = data[0];
            let glad2 = data[1];

            if(!gladiator.has(glad1) || !gladiator.has(glad2)){
                continue;
            }

            for (let obj1 of gladiator.get(glad1)) {

                for (let obj2 of gladiator.get(glad2)) {


                    if(obj1[0] === obj2[0]){

                        if(+obj1[1]>+obj2[1]){

                            gladiator.delete(glad2);
                            break;


                        }

                       else if(+obj1[1]<+obj2[1]){
                            gladiator.delete(glad1);
                            break;
                        }else{
                           break;
                        }

                    }

                }

            }


        }


    }


    let me = [...gladiator];

let finish1 = new Map();
let finish2 = new Map();


    for (let obj of gladiator.keys()) {


        finish1.set(obj,{sum:0});

        for (let obj2 of gladiator.get(obj).values()) {

            finish1.get(obj).sum+=+obj2
        }
        for (let obj1 of gladiator.values()) {



        }
    }

    for (let obj of gladiator.keys()) {

        for (let obj1 of gladiator.get(obj).keys()) {



            finish2.set(obj1,{general: obj, power:+gladiator.get(obj).get(obj1)})

        }

    }

   let finito =  [...finish1].sort((a,b)=>{

        if(b[1].sum !== a[1].sum){

            return b[1].sum - a[1].sum;
        }else{

           return a[0].localeCompare(b[0])
        }
    });

   let finito2 =  [...finish2].sort((a,b)=>{

        if(a[1].power !== b[1].power){

          return  b[1].power - a[1].power
        }else{


           return a[0].localeCompare(b[0]);
        }
    });

    for (let [key, value] of finito) {

        console.log(`${key}: ${value.sum} skill`);
        for (let [key1, value1] of finito2) {

            if(key ===value1.general) {

                console.log(`- ${key1} <!> ${value1.power}`)
            }

        }

    }

}