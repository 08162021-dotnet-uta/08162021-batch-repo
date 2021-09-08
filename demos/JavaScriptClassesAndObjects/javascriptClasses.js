let class1 = new Object();// object constructor syntax
let class2 = {};// object literal syntax.

class2.fname = 'Mark';
console.log(class2.fname);

//you can have objects inside objects and classes
class2.myObject = {
  fname: 'Joe',
  lname: 'Dimaggio'
}

class2.myFunc = () => `This is the internal function ${class2.fname}`;

console.log(`The first value was ${class2.name}. The greatest husband ever was ${class2.myObject.fname} ${class2.myObject.lname}`);
console.log(`${class2.myFunc()}`);


//create a reuseable class declaration
function baseballPlayer(battingAvg= .111, fname, lname, team) {
  return {
    battingAvg: battingAvg,
    fname: fname,
    lname: lname,
    team:team
  }
}

let joeyD = baseballPlayer('Joe','Dimaggio','Yankees');
let NolanR = baseballPlayer(.050, 'Nolan', 'Ryan', 'Rangers');

console.log(`My two fav bb players are ${joeyD.fname} ${joeyD.lname} and ${NolanR.fname} ${NolanR.lname}`);

// let class3 = {
//   name
// };
// class3.name = 'Mark';
// class3.age = 42;


// console.log(`${class3.name}`);

//use 'in' to see if an object has a property.
// remember to get ahold of hte object...NOT the function representing the object
console.log("battingAvg" in baseballPlayer());
console.log("fname" in class2);

for(let x in class2) {
  console.log(x);
}

// create actual classes in JS
class MyBirdClass3{
  constructor(type, region) {
    this.type = type;
    this.region = region;
  }

  PrintDeets() {
    return `This bird is from ${this.region} and it's a ${this.type}`
  }

  set SetRegion(x) {
    if (x.length > 20) {
      return;
    }
    else {
      this.region = x;
      return;
    }
  }

  set SetType(y) {
    this.type = y;
  }
};

let myFirstBird = new MyBirdClass3('swallow', 'Africa');

console.log(`The bird is ${myFirstBird.type}`);
console.log(`The bird is ${myFirstBird.PrintDeets()}`);

console.log(myFirstBird.SetRegion='Americaaaaaaaaaaaaaaaa', `The new value is ${myFirstBird.region}`);

class MyFalconClass extends MyBirdClass3{
  constructor(type, region, numToes, lifeSpan) {
    super(type, region);
    this.numToes = numToes;
    this.lifeSpan = lifeSpan;
  }
}

let myFalcon = new MyFalconClass('Falcon', '\'Merca', 3, 10);

console.log(`This falcon is a ${myFalcon.type}. She's from ${myFalcon.region}, has ${myFalcon.numToes} for ${myFalcon.lifeSpan} years`)


