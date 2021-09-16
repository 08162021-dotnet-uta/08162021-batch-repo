const welcomediv = document.querySelector('.welcomediv');

if (!sessionStorage.user) {
	location.href = "index.html";
}
else {
	//console.log(sessionStorage.user.fname);
	let user = JSON.parse(sessionStorage.getItem('user'));
	console.log(user);
	welcomediv.innerHTML = `${user.fname}`;

	// create an element and give it some inntertext/HTML
	const newDiv = document.createElement("div");
	// and give it some content
	const newContent = document.createTextNode("Hi there and greetings!");
	// add the text node to the newly created div
	newDiv.appendChild(newContent);
	// add the newly created element and its content into the DOM
	const currentDiv = document.getElementsByTagName("script");
	document.body.insertBefore(newDiv, currentDiv[0]);

	GetStoreList();
}



// offer choices to navigate
//choose a store to shop from
function GetStoreList() {

}
// log out