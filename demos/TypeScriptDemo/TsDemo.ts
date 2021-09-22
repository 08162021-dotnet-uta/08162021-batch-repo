

// take two objects that have string arrays

import { I1 } from "./TsDemoInterface1";
import { I2 } from "./TsDemoInterface2";

// alternately print our their strings.
function AlternatingStrings(obj1: I1, obj2: I2): string {
  // find the smaller arrays
  //interesting experiment of multiple typedefs.
  // let smallerArray: string = "";
  // smallerArray = (Math.min(obj1.stringArray.length, obj2.stringArray1.length)) as unknown as string;

  let smallerArray: number = Math.min(obj1.stringArray.length, obj2.stringArray1.length)
  let fullString: string = '';
  for (let i: number = 0; i < smallerArray; i++) {
    fullString += `${obj1.stringArray[i]} ${obj2.stringArray1[i]} `;
  }
  return fullString;
}

let myObj1: I1 = { stringArray: ["This", "a", "cool", "demo"], bigNumber: 12345345675544335555890n, currentDate: new Date() }
let myObj2: I2 = { stringArray1: ["is", "really", "Typescript", "."], isTrueOrFalse: true, integer: 100 }

let resultString: string = AlternatingStrings(myObj1, myObj2);
console.log(resultString);

// this is a really cool typescript demo.