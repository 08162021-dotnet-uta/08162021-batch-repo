"Use Strict"
// alert("this is an alert!")
// let response = prompt("this is a prompt", "this is the default");
// console.log(`${response}`);

let something = "whatever you want";
console.log(`${something}`);

const constVar = 200;
console.log(`${constVar}`);
//constVar = 2000;
console.log(`${constVar}`);

var varVar = "My var is a Var, var."
console.log(`${varVar}`);

let guy = "Mark", age = 42, address = "123 Main St.";
console.log(`${guy} is ${age} and lives at ${address}`);

// cannot start vars with a #
// let mark0 = "Mark";

const UPPERCASE = 1000;// convention to have all uppercase for const vars

guy = 42;
age = "Mark"
console.log(`${guy} is ${age} and lives at ${address}`);

// you can create scope out of nowhere and anything declared inside the {} is only available inside that scope.
// {
//   let scoped1 = "this is a scope var";
// }
// console.log(scoped1);

// there are l6 Primitive data types
let mybigint = 12345689862354444444444444444444444444444444444444444444986n;// bigint
let myString = "Davian 'quote' is here", myString1 = 'myOtherString';// string
console.log(`The 5th char is => ${myString[5]}`);
let myBool = true;//boolean
console.log(myBool);
myBool = "Mark";// TS is weakly typed.. this means I can change the type of the variable 
console.log(myBool);

let myNumber = 1234.6542;
let myNumber1 = 101;
console.log(`${myNumber} and ${myNumber1} are valid as Number type`);

//null data type
let marksWallet = null;
console.log(`${marksWallet}`);

//undefined data typed
let x;
console.log(`${x}`);

//create an object
let marksObject = {name:"Mark", age:42, strength:"weaker every day"};
console.log(`${marksObject.name} is now ${marksObject.age} and is ${marksObject.strength}`);

console.log(typeof (marksObject));
console.log(typeof myString);

console.log(5+5);
console.log(5*5);
console.log(5/5);
console.log(5 - 5);
console.log(5 ** 2);
console.log(10 / (3 + 2) * 4 + 5 ** 2 + (6 - 9));//30?
console.log(marksObject.name + ' ' + (5+5));
console.log(5 - 5 + 5 + 110);//115
let oneten = 110
console.log(5 - 5 + 5 + oneten++);
console.log(oneten);

// whats the diff btwn =, ==, ===?
// =  is assignment
// == performs type coersion. TC is testing differen ttypes() number, bigint, string, etc) to see if 
// there is any way that the types difference can be reconciled.
let myNum5 = '5';// if you trype define this to a number, then thedy are equal 'Number(myNum5)';
let myNum6 = 5;
console.log(myNum5 == myNum6);
console.log(myNum5 === myNum6);
let false1 = false;
if (!false1) {
  console.log(`It was false`)
}
else {
  console.log(`It was true`)
}

let nullVal = null;
if (!nullVal) {
  console.log(`It was false`)
}
else {
  console.log(`It was true`)
}

let zeroVal = null;
if (!zeroVal) {
  console.log(`It was false`)
}
else {
  console.log(`It was true`)
}

if (!"") {
  console.log(`It was very false`)
}
else {
  console.log(`It was true`)
}

let undef;
let nulVall1 = null;
let false3 = false;
let noANum = '3d3';
let emptyString = '';
let numnum = 0;

console.log(Number(emptyString));
console.log(Boolean(Number(numnum)));

console.log(Math.random() * 10);
console.log(Math.max(1,65,37,95,333,9867,2));

let myobj1 = { myName: "Mark", myAge: 42, strength: "weaker every day" };
console.log(myobj1);
console.log(JSON.stringify(myobj1));
let myobj2 = JSON.stringify(myobj1);
console.log(JSON.parse(myobj2));















