
//we can call an IIFE to get a list of all the customers
(function () {
	fetch("customer/Customerlist")
		.then(res => res.json())
		.then(data => {
			console.log(data)
			const lop = document.querySelector('.listofplayers');
			for (let x = 0; x < data.length; x++) {
				lop.innerHTML += `<p>The customer is ${data[x].fname} ${data[x].lname}.</p>`;
			}
		});
})();
