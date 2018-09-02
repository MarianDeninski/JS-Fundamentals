function solution(fights, helmetprice, swordPrice, shieldPrice, armorPrice) {

    let hPrice = 0;
    let swPrice = 0;
    let shprice = 0;
    let aPrice = 0;

    let counth = 0;
    let counts = 0;
    let countArmour = 0;

    for (let i = 1; i <= fights; i++) {

        counth = 0;

        counts = 0;
        if (i % 2 === 0 && i !== 0) {

            hPrice += helmetprice;
            counth = 1;
        }

        if (i % 3 === 0 && i !== 0) {

            swPrice += swordPrice;
            counts = 1;

        }

        if (counth+counts === 2) {
            counth = 0;
            counts = 0;
            shprice += shieldPrice;
            countArmour++
        }

        if(countArmour===2){
            countArmour =0;
            aPrice+=armorPrice;
        }

    }

    let sum = hPrice + swPrice + shprice + aPrice;
    console.log(`Gladiator expenses: ${sum.toFixed(2)} aureus`)

}