function Solve(base, increment) {

    let increm = increment;
    let size = base;
    let stone = 0;
    let marble = 0;
    let lapis = 0;
    let gold = increment;
    let counter = increment;
    let count = 1;

    while (size>2){

        if(count%5==0){
            stone += (size-2)*(size-2)*increment;
            lapis += ((size*4)-4);
            counter+=increment;
            size-=2;
            count++;
            continue;
        }
        stone += (size-2)*(size-2)*increment;
        marble += ((size*4)-4)*increment;
        size-=2;

        counter+=increment;
        count++;

    }
    console.log(`Stone required: ${Math.ceil(stone)}`);
    console.log(`Marble required: ${Math.ceil(marble)}`);
    console.log(`Lapis Lazuli required: ${Math.ceil(lapis*increment)}`);
    console.log(`Gold required: ${Math.ceil(size*size*increment)}`);
    console.log(`Final pyramid height: ${Math.floor(count*increment)}`);
}