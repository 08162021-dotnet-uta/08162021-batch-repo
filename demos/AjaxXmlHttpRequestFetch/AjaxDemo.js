console.log('This is run automatically');

// 1. create the object that I'll use to make requests
// let xhr = new XMLHttpRequest();

// 2. assign something to do when the response is received.
// xhr.onreadystatechange = PrintJokes;

function PrintJoke() {
  console.log(`the onreadystatechange was fired. ${this.readyState}`)
  if (this.status == 200 && this.readyState == 4) {
    //console.log('in success if....')
    const result = JSON.parse(this.responseText);
    console.log(`${this.responseText}`);
    console.log(`This joke is ${result.value.categories[0]}.`)
    console.log(`${result.value.joke}`);

    // now do something useful
    const para = document.querySelector('p');
    para.innerHTML = result.value.joke;

  }
  else if (this.status != 200 && this.readyState == 4) {
    console.log(`the request was unsuccessful. ${this.status}`)
  }
}

function PrintJokes() {
  console.log(`the onreadystatechange was fired. ${this.readyState}`)
  if (this.status == 200 && this.readyState == 4) {
    //console.log('in success if....')
    const result = JSON.parse(this.responseText);
    const body = document.querySelector('body');
    for (let i = 0; i < result.value.length;i++){
      body.innerHTML += `<p>${result.value[i].joke}</p><br>`
    }
    console.log(this.responseText);
  }
  else if (this.status != 200 && this.readyState == 4) {
    console.log(`the request was unsuccessful. ${this.status}`)
  }
}
// 3. open a connection to the API you want to get data from
// xhr.open('GET',`http://api.icndb.com/jokes/random/5`, true);

// 4. send the requests
// xhr.send();

fetch('http://api.icndb.com/jokes/random/5',)
  .then(res => res.json())
  .then(res => {
    console.log(res)
    return res;
  })
  .then(res => {
    const body = document.querySelector('body');
    for (let i = 0; i < res.value.length; i++) {
      body.innerHTML += `<p>${res.value[i].joke}</p><br>`
    }
    console.log(this.responseText);
  });