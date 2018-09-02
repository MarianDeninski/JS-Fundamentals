function solve(matrix, arr) {

    for (let i = 0; i < matrix.length; i++) {

      matrix[i] = matrix[i].split(' ');
    }

    for (let i = 0; i < arr.length; i++) {

      let here = arr[i].split(` `);

        if (here[0] === `breeze`) {
            for (let r = 0; r < matrix.length; r++) {

                if(r === +here[1]) {

                    for (let c = 0; c < matrix.length; c++) {

                        if(Number(matrix[r][c]) - 15<0){
                            matrix[r][c] =0;
                            continue;
                        }
                        matrix[r][c] = Number(matrix[r][c]) - 15;
                    }
                }
            }
        }

        else if (here[0] === `gale`) {
            for (let r = 0; r < matrix.length; r++) {

                for (let c = 0; c < matrix.length; c++) {

                    if(c === +here[1]){

                        if(Number(matrix[r][c]) - 20<0){
                            matrix[r][c] =0;
                            continue;
                        }

                        matrix[r][c]= Number(matrix[r][c]) - 20;

                    }
                }
            }
        }

        else if (here[0] === `smog`) {
            for (let r = 0; r < matrix.length; r++) {

                for (let c = 0; c < matrix.length; c++) {

                    matrix[r][c]= Number(matrix[r][c]) + Number(here[1]);

                }
            }
        }

    }

    let result = [];

    let count = 0;
    for (let i = 0; i < matrix.length; i++) {

        for (let j = 0; j < matrix.length; j++) {

            if(matrix[i][j]>=50){

                count++;
                result.push(`[${i}-${j}]`);
            }

        }

    }

if(count ===0){
    return `No polluted areas`;
}
    return`Polluted areas: `+result.join(', ');

}
