function Solve(ballot) {
let ballots = ballot[0];
if(+ballot[0]<0){
    return;
}
    let produce =0;
    let workers = 0;
    let left = ballots;
    let days = 0;

    while (true){

        if(ballots<100){
            if(produce>=26) {
                produce -= 26;
            }
            console.log(days);
            console.log(produce);

            return;
        }
        days++;

        workers=ballots-26;
        ballots -=10;

        produce+=workers;

    }
    console.log()

}