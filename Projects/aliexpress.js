var superfunction = function() {
var myWindow = window.open(alliBask);
button.click();
myWindow.close();}

var button = document.getElementById('add-to-store-list-win-coins');


var hrefdataVal = document.getElementsByClassName('js-remove remove')
var alliBask = 'https://my.aliexpress.com' + hrefdataVal[0].attributes['data-href'].value

var timerId = setInterval(function() {
	superfunction();
	console.log(i);
}, 2000);

setTimeout(function() {
  clearInterval(timerId);
  console.log('остановка');
}, 30000);
