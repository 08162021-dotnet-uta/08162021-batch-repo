console.log(`Hey there, 08162021batch!`)
let x = 21;
//function declaration
function myfunc1(x, y = 'this is a default value') {
  return `I have ${x} values called ${y}.`
}

console.log(myfunc1(3, 4));

//function expression
let myfunc2 = function (x,y) {
  return x + y;
}

console.log(myfunc2(4, 5));
let myfunc3 = myfunc2;
console.log(myfunc2(1,2));
console.log(myfunc3(10, 12));

//arrow syntax/function. these to the exact same thing.
// if yoru arrow functions body needs more that one line, then you must use {}.
let myfunc4 = (x,y) => x+y;
let myfunc5 = function (x,y) {
  return x+y;
}

console.log(myfunc4(9, 10));
console.log(myfunc5(9, 10));

//multipine arrow function.
let myfunc6 = () => {
  console.log(`This is a multiline Arrow functions`)
  console.log(`it uses more than one line in the body of the function.`)
}
myfunc6();


//callback functions!!!!
function callback1(param1) {
  return `This value is EVEN...${param1}`;
}

function callback2(param1) {
  return `This value is ODD...${param1}`;
}


// this arrow function will evaluate the x. if x is a Number and even,
// then the callback function y will be invoked...
// if not, then z will be invoked.
let myfunc7 = (x, y, z) => {
  if (x % 2 === 0) {
    console.log(y(x));
  }
  else {
    console.log(z(x));
  }
};

myfunc7(1, callback1, callback2);
myfunc7(
  1,
  (param1) => `This value is EVEN...${param1}`,
  (param1) => `This value is ODD...${param1}`
);

(function(
  x=1,
  y=(param1) => `This value is EVEN...${param1}`,
  z=(param1) => `This value is ODD...${param1}`
  ){
  if (x % 2 === 0) {
    console.log(y(x));
  }
  else {
    console.log(z(x));
  }
})();

// closure and lexical scope.
function makeadder(x) {
  return (y) => {
    return x + y;
  }
}

let makeadderholder = makeadder(10);
console.log(makeadderholder(5));

function concatSentences(x) {
  console.log(`The first call was with "${x}".`)
  return (y) => {
    console.log(`The second call was with "${y}".`)
    return x + ' ' + y;
  }
}

let concatInnerFunction = concatSentences('Marks computer');
console.log(concatInnerFunction);
console.log(concatInnerFunction('is really hot right now.'));

try {
  throw new SyntaxError('There was an induced error');
  // zero
}
catch (err) {
  console.log(`err.name is "${err.name}"`);
  console.log(`err.stack is "${err.stack}"`);
  console.log(`err.message is "${err.message}"`);
}
finally {
  console.log(`This is the finally block`);
}





