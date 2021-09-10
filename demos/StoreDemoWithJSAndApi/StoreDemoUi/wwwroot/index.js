const button = document.querySelector('.weatherlist');
const listofcustomers = document.querySelector('.listofcustomers');

button.addEventListener('click', (e) => {

  fetch('WeatherForecast')
  .then(res => {
    if (!res.ok) {
      console.log('NOT OK')
      throw new Error(`Network response was not ok (${res.status})`);
    }
    else {
      return res.json();
    }
  })
  .then(res => {
    console.log(res);
    //res.foreach(x => listofcustomers.innerHTML += x)
    for (let x = 0; x < res.length;x++) {
      listofcustomers.innerText += `The temp is ${res[x].temperatureC}.\nThe weather is ${res[x].summary}.\n`
    }
  })
    .catch(err => console.log(`There was an error ${err}`));
});