const button = document.querySelector('.weatherlist');
const listofcustomers = document.querySelector('.listofcustomers');
const randombutton = document.querySelector(".randombutton");

button.addEventListener('click', (e) => {
	fetch('WeatherForecast') // Fetch() is default 'GET'
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
			for (let x = 0; x < res.length; x++) {
				listofcustomers.innerText += `The temp is ${res[x].temperatureC}.\nThe weather is ${res[x].summary}.\n`
			}
		})
		.catch(err => console.log(`There was an error ${err}`));
});

randombutton.addEventListener('click', (e) => {
	fetch('WeatherForecast/thisisapost')
		.then(res => {
			if (!res.ok) {
				console.log('NOT OK')
				throw new Error(`Network response was not ok (${res.status})`);
			}
			else {
				console.log(res);
				return res.text();
			}
		})
		.then(res => {
			console.log(res);
		})
		.catch(err => console.log(`There was an error ${err}`));
});

function SeePlayers() {
	location.href = "list-of-customers.html";
}