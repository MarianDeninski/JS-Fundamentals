function solve(string) {
    let pattern = /^<message[a-zA-Z0-9\s=".]*>[^]*<\/message>$/;
    let pattern1 = /\sfrom=["a-zA-Z0-9.\s]*\"{1}/;
    let pattern2 = /\sto=["a-zA-Z0-9.\s]*\"{1}/;
    let pattern3 = />[^]*</;

    if (pattern.test(string)) {

        if (pattern1.test(string) && pattern2.test(string)) {

            let fromAd = pattern1.exec(string)[0].split(`from=`).filter(a => a !== ' ')[0];
            let from = fromAd.slice(1, fromAd.length - 1);
            console.log(`<article>`);
            console.log(` <div>From: <span class="sender">${from}</span></div>`);

            let toAd = pattern2.exec(string)[0].split(`to=`).filter(a => a !== ' ')[0];
           
            let to = toAd.slice(1, toAd.length - 1);
            console.log(`<div>To: <span class="recipient">${to}</span></div>`);

            let messageAd = pattern3.exec(string)[0];
            let message = messageAd.slice(1, messageAd.length - 1).split(`\n`);


            console.log(`<div>`);
            for (let obj of message) {

                console.log(`<p>${obj}</p>`)

            }
            console.log(`</div>`);
            console.log(`</article>`);


        } else {
            console.log(`Missing attributes`)
        }

    } else {
        console.log(`Invalid message format`)
    }
}