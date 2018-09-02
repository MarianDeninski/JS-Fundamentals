function solve(matrix, arr) {

    let kingdom = new Map();
    let general = new Map();

    for (let obj of matrix) {

        if (!kingdom.has(obj.kingdom)) {
            kingdom.set(obj.kingdom, {wins: 0, losses: 0, generals: []});
            kingdom.get(obj.kingdom).generals.push(obj.general);
        } else {
            if (!kingdom.get(obj.kingdom).generals.includes(obj.general)) {
                kingdom.get(obj.kingdom).generals.push(obj.general);
            }
        }

        if (!general.has(obj.general)) {
            general.set(obj.general, {army: obj.army, wins: 0, losses: 0});
        } else {
            general.get(obj.general).army += obj.army;
        }
    }
    for (let obj of arr) {

        if(obj[0] === obj[2]){
            continue;
        }
        if (general.get(obj[1]).army > general.get(obj[3]).army) {

            general.get(obj[1]).army = Math.floor(general.get(obj[1]).army + (general.get(obj[1]).army * 10) / 100);
            general.get(obj[3]).army = Math.floor(general.get(obj[3]).army - (general.get(obj[3]).army * 10) / 100);
            kingdom.get(obj[0]).wins++;
            general.get(obj[1]).wins++;
            kingdom.get(obj[2]).losses++;
            general.get(obj[3]).losses++;

        }
       else if (general.get(obj[1]).army < general.get(obj[3]).army) {

            general.get(obj[3]).army = Math.floor(general.get(obj[3]).army + (general.get(obj[3]).army * 10) / 100);
            general.get(obj[1]).army = Math.floor(general.get(obj[1]).army - (general.get(obj[1]).army * 10) / 100);
            kingdom.get(obj[2]).wins++;
            general.get(obj[3]).wins++;
            kingdom.get(obj[0]).losses++;
            general.get(obj[1]).losses++;

        }
    }
    let kingdomWin = [...kingdom].sort((a,b)=>{
        if(a[1].wins !==b[1].wins){
            return b[1].wins- a[1].wins
        }
         if(a[1].losses !== b[1].losses){
            return a[1] - b[1]
        }
       return a[0].localeCompare(b[0]);
    });

    let generals = [...general].sort((a,b)=>{

            return b[1].army- a[1].army


    });

    for (let [key, value] of kingdomWin) {
        console.log(`Winner: ${key}`);

        for (let [key1, value1] of generals) {
            if(value.generals.includes(key1)) {
                console.log(`/\\general: ${key1}`);
                console.log(`---army: ${value1.army}`);
                console.log(`---wins: ${value1.wins}`);
                console.log(`---losses: ${value1.losses}`);
            }
        }

        break;

    }
}
