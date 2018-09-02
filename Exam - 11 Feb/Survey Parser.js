function solve(string) {

    let paternSVG = /<svg>([^]*)<\/svg>/g;
    let patternCat = /<cat><text>(.|\n)*\[((.|\n)*)\](.|\n)*<\/text><\/cat>\s*<cat>((.|\n)*)<\/cat>/g;
    let patternG = /<g><val>([0-9]*)<\/val>([0-9]*)<\/g>/g;


    let surveyLabel = '';
    let voteCount = 0;
    let ratingValue = 0;
    let result = 0;
    if (paternSVG.test(string)) {

            let item = patternCat.exec(string);
            if(item === null){
                console.log(`Invalid format`);
                return;
            }

            surveyLabel = item[2];

            let gto = patternG.exec(item[5]);
            while(gto){

                if(gto[1]<=0 || gto[1]>10){
                    gto = patternG.exec(item[5]);
                    continue;
                }

                if(gto[2]<0){
                    gto = patternG.exec(item[5]);
                    continue;
                }

                voteCount+=(+gto[1])*(+gto[2]);
                ratingValue+=(+gto[2]);


                gto = patternG.exec(item[5]);

            }
            result = parseFloat((voteCount/ratingValue).toFixed(2));
    } else {

        console.log(`No survey found`);
        return;
    }

    console.log(surveyLabel+`: ${result}`);
    return;
}
