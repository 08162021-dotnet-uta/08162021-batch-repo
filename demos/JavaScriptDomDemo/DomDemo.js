console.log('Hey there');

//get a reference to the add todo form
const addtodoform = document.querySelector('.addtodo');
const todolist = document.querySelector('.todolist');
const searchterm = document.querySelector('.searchterm');
// add an event listener
addtodoform.addEventListener('submit', (e) => {
  e.preventDefault()// stopps refreshing of the page
  e.stopPropagation();// stop bubbling of the event
  console.log(e)// print the event itself

  // print the value inputted
  // console.log(`The value inputted is => ${addtodoform.addtodos.value}`);
  const todo1 = addtodoform.addtodos.value.trim();// grab the value and trim off the excess whitespace
  todolist.innerHTML += `<p class="todoitem">${todo1}</p>`
  addtodoform.reset();// reset the from to empty

});

todolist.addEventListener('click', (e) => {
  e.stopPropagation();
  console.log(e);
  e.target.remove();
});


// implement searching by the term user has entered.
searchterm.addEventListener('keyup', (e) => {
  const term = searchterm.value.trim();
  const todosarray = Array.from(todolist.children);// get all the children and put them in array form
  //filter the array to add a class to elemetns that do not
  // contain the search term.
  todosarray.filter((todo) => {
    return !todo.textContent.includes(term);
  }).forEach((todo) => todo.classList.add('hidethis'));

  todosarray.filter((todo) => {
    return todo.textContent.includes(term);
  }).forEach((todo) => todo.classList.remove('hidethis'));

});



