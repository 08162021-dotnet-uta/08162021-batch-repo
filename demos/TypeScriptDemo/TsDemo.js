// take two objects that have string arrays
// alternately print our their strings.
function AlternatingStrings(obj1, obj2) {
    // find the smaller arrays
    //interesting experiment of multiple typedefs.
    // let smallerArray: string = "";
    // smallerArray = (Math.min(obj1.stringArray.length, obj2.stringArray1.length)) as unknown as string;
    let smallerArray = Math.min(obj1.stringArray.length, obj2.stringArray1.length);
    let fullString = '';
    for (let i = 0; i < smallerArray; i++) {
        fullString += `${obj1.stringArray[i]} ${obj2.stringArray1[i]} `;
    }
    return fullString;
}
let myObj1 = { stringArray: ["This", "a", "cool", "demo"], bigNumber: 12345345675544335555890n, currentDate: new Date() };
let myObj2 = { stringArray1: ["is", "really", "Typescript", "."], isTrueOrFalse: true, integer: 100 };
let resultString = AlternatingStrings(myObj1, myObj2);
console.log(resultString);
// export {};
// this is a really cool typescript demo.
